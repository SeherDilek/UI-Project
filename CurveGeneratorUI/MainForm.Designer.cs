namespace CurveGeneratorUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGenerateCurve = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chartPYCurve = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvPYCurve = new System.Windows.Forms.DataGridView();
            this.cmbSoilModels = new System.Windows.Forms.ComboBox();
            this.tlpInputs = new System.Windows.Forms.TableLayoutPanel();
            this.lblSoilModel = new System.Windows.Forms.Label();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPYCurve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPYCurve)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateCurve
            // 
            this.btnGenerateCurve.Location = new System.Drawing.Point(131, 249);
            this.btnGenerateCurve.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateCurve.Name = "btnGenerateCurve";
            this.btnGenerateCurve.Size = new System.Drawing.Size(133, 25);
            this.btnGenerateCurve.TabIndex = 0;
            this.btnGenerateCurve.Text = "Generate Curve";
            this.btnGenerateCurve.UseVisualStyleBackColor = true;
            this.btnGenerateCurve.Click += new System.EventHandler(this.BtnGenerateCurve_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Length unit: m";
            // 
            // chartPYCurve
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPYCurve.ChartAreas.Add(chartArea1);
            this.chartPYCurve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPYCurve.Location = new System.Drawing.Point(278, 2);
            this.chartPYCurve.Margin = new System.Windows.Forms.Padding(2);
            this.chartPYCurve.Name = "chartPYCurve";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartPYCurve.Series.Add(series1);
            this.chartPYCurve.Size = new System.Drawing.Size(1107, 583);
            this.chartPYCurve.TabIndex = 12;
            this.chartPYCurve.Text = "chart1";
            // 
            // dgvPYCurve
            // 
            this.dgvPYCurve.AllowUserToResizeRows = false;
            this.dgvPYCurve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPYCurve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPYCurve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPYCurve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPYCurve.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPYCurve.Location = new System.Drawing.Point(7, 278);
            this.dgvPYCurve.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPYCurve.Name = "dgvPYCurve";
            this.dgvPYCurve.ReadOnly = true;
            this.dgvPYCurve.RowHeadersVisible = false;
            this.dgvPYCurve.RowTemplate.Height = 24;
            this.dgvPYCurve.Size = new System.Drawing.Size(258, 298);
            this.dgvPYCurve.TabIndex = 13;
            // 
            // cmbSoilModels
            // 
            this.cmbSoilModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSoilModels.FormattingEnabled = true;
            this.cmbSoilModels.Location = new System.Drawing.Point(98, 7);
            this.cmbSoilModels.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSoilModels.Name = "cmbSoilModels";
            this.cmbSoilModels.Size = new System.Drawing.Size(168, 21);
            this.cmbSoilModels.TabIndex = 15;
            this.cmbSoilModels.SelectedIndexChanged += new System.EventHandler(this.CmbSoilModel_SelectedIndexChanged);
            // 
            // tlpInputs
            // 
            this.tlpInputs.ColumnCount = 2;
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7093F));
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.2907F));
            this.tlpInputs.Location = new System.Drawing.Point(4, 60);
            this.tlpInputs.Margin = new System.Windows.Forms.Padding(2);
            this.tlpInputs.Name = "tlpInputs";
            this.tlpInputs.RowCount = 5;
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInputs.Size = new System.Drawing.Size(260, 185);
            this.tlpInputs.TabIndex = 16;
            // 
            // lblSoilModel
            // 
            this.lblSoilModel.AutoSize = true;
            this.lblSoilModel.Location = new System.Drawing.Point(2, 10);
            this.lblSoilModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoilModel.Name = "lblSoilModel";
            this.lblSoilModel.Size = new System.Drawing.Size(89, 13);
            this.lblSoilModel.TabIndex = 17;
            this.lblSoilModel.Text = "Select soil model:";
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 276F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.chartPYCurve, 1, 0);
            this.tlpMain.Controls.Add(this.panel1, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1387, 587);
            this.tlpMain.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbSoilModels);
            this.panel1.Controls.Add(this.dgvPYCurve);
            this.panel1.Controls.Add(this.tlpInputs);
            this.panel1.Controls.Add(this.btnGenerateCurve);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblSoilModel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 583);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Force Unit: N";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 587);
            this.Controls.Add(this.tlpMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1403, 626);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Curve Generator";
            ((System.ComponentModel.ISupportInitialize)(this.chartPYCurve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPYCurve)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateCurve;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPYCurve;
        private System.Windows.Forms.DataGridView dgvPYCurve;
        private System.Windows.Forms.ComboBox cmbSoilModels;
        private System.Windows.Forms.TableLayoutPanel tlpInputs;
        private System.Windows.Forms.Label lblSoilModel;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

