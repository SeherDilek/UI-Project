using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Model
{
    public class Parameter
    {
        private double value;

        public Parameter(double value)
        {
            this.value = value;
        }

        public double GetValue()
        {
            return value;
        }

        public void SetValue(double value)
        {
            this.value = value;
        }

        public double GetValueWithUnit(double unitMultiplier)
        {
            return value * unitMultiplier;
        }
    }
 
    public class ParameterManager
    {
        private readonly Dictionary<string, Parameter> parameters = new Dictionary<string, Parameter>();

        public IReadOnlyDictionary<string, Parameter> Parameters => new ReadOnlyDictionary<string, Parameter>(parameters);

        public ParameterManager()
        {

        }

        public ParameterManager(Dictionary<string, Parameter> parameters)
        {
            this.parameters = parameters;
        }

        public void AddParameter(string name, double value)
        {
            parameters[name] = new Parameter(value);
        }

        public Parameter GetParameter(string name)
        {
            if (parameters.TryGetValue(name, out var parameter))
                return parameter;

            return null;
        }

        public void SetParameterValue(string name, double value)
        {
            var parameter = GetParameter(name);
            if (parameter != null)
                parameter.SetValue(value);
        }
    }

    public class CurvePoint
    {
        public double X { get; private set; }

        public double Y { get; private set; }

        public CurvePoint(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
