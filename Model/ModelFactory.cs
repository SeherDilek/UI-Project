using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelFactory
    {
        public static IModel CreateModel(string modelName, Dictionary<string, Parameter> parameters)
        {
            switch (modelName)
            {
                case "Dummy Sand":
                    return new DummySandLateralSoilModel(parameters);
                case "Dummy Rock":
                    return new DummyRockLateralSoilModel(parameters);
                // Add more cases for other soil model names as needed
                default:
                    throw new ArgumentException("Invalid soil model name: " + modelName);
            }
        }
    }
}