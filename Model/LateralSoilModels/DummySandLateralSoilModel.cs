using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ModelTests")]
namespace Model
{
    public class DummySandLateralSoilModel : LateralSandSoilModel
    {
        protected override string title => "Sand";

        public DummySandLateralSoilModel(double soilDepth = 15.0, double pileDiameter = 1.0, double unitWeight = 18000.0,
            double phi = 30.0, double coefficientOfSubgradeModulus = 1.357e8)
            : base(soilDepth, pileDiameter, unitWeight)
        {
            AddParameter("phi", phi);
            AddParameter("coefficientOfSubgradeModulus", coefficientOfSubgradeModulus);
        }

        public DummySandLateralSoilModel(Dictionary<string, Parameter> parameters) : base(parameters)
        {

        }

        internal override List<CurvePoint> GeneratePYCurve()
        {
            var pyCurve = new List<CurvePoint>();
            double? soilDepth, pileDiameter, gm, phi, ks;
            soilDepth = GetParameter("soilDepth")?.GetValue();
            pileDiameter = GetParameter("pileDiameter")?.GetValue();
            gm = GetParameter("unitWeight")?.GetValue();
            phi = GetParameter("phi")?.GetValueWithUnit(Math.PI / 180.0);
            ks = GetParameter("coefficientOfSubgradeModulus")?.GetValue();

            if (soilDepth is null || pileDiameter is null || gm is null || phi is null || ks is null)
                return pyCurve;

            return GeneratePYCurve((double)soilDepth, (double)pileDiameter, (double)gm, (double)phi);
        }

        private List<CurvePoint> GeneratePYCurve(double soilDepth, double pileDiameter, double gm, double phi)
        {
            // Generate a dummy curve
            var aCoefficient = CalculateACoefficient(soilDepth, pileDiameter);
            var curve = new List<CurvePoint>();
            double lasty = 0;
            double lastP = 0;
            for (int y = 0; y <= minDataPointCount; y += 1)
            {
                double p = aCoefficient * gm * pileDiameter * Math.Pow(y / pileDiameter, 2.0) * Math.Exp(-phi * y / pileDiameter);
                curve.Add(new CurvePoint(y, p));
                if (y == minDataPointCount)
                {
                    lasty = y;
                    lastP = p;
                }
            }
            if (curve.Count > 0)
                curve.Add(new CurvePoint(2.0 * lasty, lastP));
            return curve;
        }

        internal double CalculateACoefficient(double soilDepth, double pileDiameter)
        {
            var db = soilDepth / pileDiameter;
            return db <= 5.0 ? 0.88 : 1.1;
        }
    }
}
