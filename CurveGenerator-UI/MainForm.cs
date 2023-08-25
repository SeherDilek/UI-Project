using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

using Model;

namespace CurveGenerator_UI
{
    public partial class MainForm : Form
    {
        private string currentModelName;
        private Dictionary<string, Dictionary<string, Parameter>> modelParameters = new Dictionary<string, Dictionary<string, Parameter>>();

        public MainForm(Dictionary<string, Dictionary<string, Parameter>> modelParameters)
        {
            InitializeComponent();
            this.modelParameters = modelParameters;
            SetCmbSoilModelDataSource();
            cmbSoilModels.SelectedIndex = 0;
            currentModelName = cmbSoilModels.SelectedValue.ToString();
            UpdateInputTextBoxes();
            AddDgvPYCurveColumns();
        }

        private void AddDgvPYCurveColumns()
        {
            var yCol = new DataGridViewTextBoxColumn()
            {
                Name = "y",
                HeaderText = "y (m)",
                MinimumWidth = 50,
                FillWeight = 50f,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            dgvPYCurve.Columns.Add(yCol);

            var pCol = new DataGridViewTextBoxColumn()
            {
                Name = "P",
                HeaderText = "P (N/m)",
                MinimumWidth = 150,
                FillWeight = 50f,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            dgvPYCurve.Columns.Add(pCol);
        }

        private void SetCmbSoilModelDataSource()
        {
            this.cmbSoilModels.DataSource = new BindingList<string>(modelParameters.Keys.ToList());
        }

        private void CmbSoilModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentModelName = cmbSoilModels.SelectedValue as string;
            UpdateInputTextBoxes();
            dgvPYCurve.Rows.Clear();
            chartPYCurve.Series.Clear();
        }

        private void UpdateInputTextBoxes()
        {
            if (currentModelName is null)
                return;

            tlpInputs.Controls.Clear();

            var inputs = modelParameters[currentModelName];
            foreach (var input in inputs)
            {
                tlpInputs.Controls.Add(new Label
                {
                    Text = Utility.ConvertString(input.Key),
                    Anchor = (AnchorStyles.Left | AnchorStyles.Right),
                    AutoSize = true,
                });
                
                var textBox = new TextBox
                {
                    Name = input.Key,
                    Text = input.Value.GetValue().ToString(),
                    Anchor = (AnchorStyles.Left | AnchorStyles.Right),
                    AutoSize = true,
                    Tag = input.Key
                };
                textBox.TextChanged += TbInput_TextChanged;
                textBox.Enter += TbInput_Enter;
                tlpInputs.Controls.Add(textBox);
            }
        }

        private string previousValue = "";
        private void TbInput_Enter(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            previousValue = textBox.Text;
        }

        private void TbInput_TextChanged(object sender, EventArgs e)
        {
            if (currentModelName is null)
                return;

            if (sender is TextBox textBox && textBox.Tag is string parameterName)
            {
                if (Utility.ValidateInput(textBox.Text))
                    modelParameters[currentModelName][parameterName] = new Parameter(Convert.ToDouble(textBox.Text));
                else
                {
                    MessageBox.Show("Invalid input. Enter a positive number.", "Warning");
                    textBox.Text = previousValue;
                }
            }
        }

        private void BtnGenerateCurve_Click(object sender, EventArgs e)
        {
            if (currentModelName is null)
            {
                MessageBox.Show("Please select a soil model.");
                return;
            }

            IModel model = null;
            try
            {
                model = ModelFactory.CreateModel(currentModelName, modelParameters[currentModelName]);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "The curve could not be created.", "Warning");
            }

            var pyCurve = model.GenerateCurve();
            Utility.ReportCurve(dgvPYCurve, pyCurve);
            Utility.DrawCurve(chartPYCurve, pyCurve);
        }

        private void DgvPYCurve_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex % 2 == 0)
                    e.CellStyle.BackColor = Color.White;
                else
                    e.CellStyle.BackColor = Color.LightGray;
            }
        }
    }
}
