using System;
using System.Collections.Generic;

namespace Model
{
    public abstract class LateralSoilModel : SoilModel
    {
        protected LateralSoilModel(double soilDepth = 15.0, double pileDiameter = 1.0)
            : base(soilDepth, pileDiameter)
        {

        }

        protected LateralSoilModel(Dictionary<string, Parameter> parameters) : base(parameters)
        {

        }

        public override List<CurvePoint> GenerateCurve()
        {
            return GeneratePYCurve();
        }

        internal abstract List<CurvePoint> GeneratePYCurve();
    }
}
