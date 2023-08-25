using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IModel
    {
        List<CurvePoint> GenerateCurve();

        void AddParameter(string name, double value);

        Parameter GetParameter(string name);

        void SetParameterValue(string name, double value);

        IReadOnlyDictionary<string, Parameter> GetParameters();
    }
}
