using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurveGenerator_UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var modelParameters = new Dictionary<string, Dictionary<string, Parameter>>()
            {
                {  "Dummy Sand", new Dictionary<string, Parameter>() {
                    { "soilDepth", new Parameter(15.0) },
                    { "pileDiameter", new Parameter(1.0) },
                    { "unitWeight", new Parameter(18000.0) },
                    { "phi", new Parameter(30.0) },
                    { "coefficientOfSubgradeModulus", new Parameter(1.357e8) }
                } },

                {  "Dummy Rock", new Dictionary<string, Parameter>() {
                    { "soilDepth", new Parameter(10.0) },
                    { "pileDiameter", new Parameter(1.0) },
                    { "compressiveStrength", new Parameter(20) },
                    { "initialReactionModulus", new Parameter(500) },
                } }
            };

            Application.Run(new MainForm(modelParameters));
        }
    }
}
