using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class LateralSandSoilModel : LateralSoilModel
    {
        protected LateralSandSoilModel(double soilDepth = 15.0, double pileDiameter = 1.0, double unitWeight = 18000.0)
            : base(soilDepth, pileDiameter)
        {
            AddParameter("unitWeight", unitWeight);
        }

        protected LateralSandSoilModel(Dictionary<string, Parameter> parameters) : base(parameters)
        {

        }
    }
}
