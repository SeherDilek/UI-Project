using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class LateralRockSoilModel : LateralSoilModel
    {
        protected LateralRockSoilModel(double soilDepth = 15.0, double pileDiameter = 1.0)
           : base(soilDepth, pileDiameter)
        {

        }

        protected LateralRockSoilModel(Dictionary<string, Parameter> parameters) : base(parameters)
        {

        }
    }
}
