using System;
using System.Collections.Generic;

namespace Model
{
    public class DummyRockLateralSoilModel : LateralRockSoilModel
    {
        protected override string title => "Rock";

        public DummyRockLateralSoilModel(double soilDepth = 15, double pileDiameter = 1.0,
            double compressiveStrength = 35.0, double initialReactionModulus = 369.99126895) : base(soilDepth, pileDiameter)
        {
            AddParameter("compressiveStrength", compressiveStrength);
            AddParameter("initialReactionModulus", initialReactionModulus);
        }

        public DummyRockLateralSoilModel(Dictionary<string, Parameter> parameters) : base(parameters)
        {

        }

        internal override List<CurvePoint> GeneratePYCurve()
        {
            var pyCurve = new List<CurvePoint>();
            double? soilDepth, pileDiameter, E, compressiveStrength;
            soilDepth = GetParameter("soilDepth").GetValue();
            pileDiameter = GetParameter("pileDiameter").GetValue();
            compressiveStrength = GetParameter("compressiveStrength").GetValue();
            E = GetParameter("initialReactionModulus").GetValue();

            if (soilDepth is null || pileDiameter is null || compressiveStrength is null || E is null)
                return pyCurve;

            return GeneratePYCurve((double)soilDepth, (double)pileDiameter, (double)E, (double)compressiveStrength);
        }

        private List<CurvePoint> GeneratePYCurve(double soilDepth, double pileDiameter, double E, double compressiveStrength)
        {
            // Generate a dummy curve
            List<CurvePoint> curve = new List<CurvePoint>();
            double lasty = 0;
            double lastP = 0;
            for (int y = 0; y <= minDataPointCount; y += 1)
            {
                double p = E * y * (y - pileDiameter) + y * compressiveStrength * pileDiameter;
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
    }
}
