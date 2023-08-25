using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Model
{
    public abstract class SoilModel : IModel
    {
        protected ParameterManager parameterManager = new ParameterManager();

        public IReadOnlyDictionary<string, Parameter> Parameters => parameterManager.Parameters;

        protected abstract string title { get; }

        // Minimum data point count in the curve
        protected const int minDataPointCount = 20;

        protected SoilModel(double soilDepth = 15.0, double pileDiameter = 1.0)
        {
            AddParameter("soilDepth", soilDepth);
            AddParameter("pileDiameter", pileDiameter);
        }

        protected SoilModel(Dictionary<string, Parameter> parameters)
        {
            this.parameterManager = new ParameterManager(parameters);
        }

        public abstract List<CurvePoint> GenerateCurve();

        public void AddParameter(string name, double value)
        {
            parameterManager.AddParameter(name, value);
        }

        public Parameter GetParameter(string name)
        {
            return parameterManager.GetParameter(name);
        }

        public IReadOnlyDictionary<string, Parameter> GetParameters()
        {
            return Parameters;
        }

        public void SetParameterValue(string name, double value)
        {
            parameterManager.SetParameterValue(name, value);
        }

        public override string ToString()
        {
            return this.title;
        }
    }
}
