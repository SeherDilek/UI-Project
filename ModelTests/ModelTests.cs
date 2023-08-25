using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Model;

namespace ModelTests
{
    [TestClass]
    public class LateralSoilModelTests
    {
        private const double tolerance = 1e-5;

        private bool AreEqual(List<double> expectedCurve, List<double> actualCurve)
        {
            Assert.AreEqual(expectedCurve.Count, actualCurve.Count);
            for (int i = 0; i < expectedCurve.Count; i++)
            {
                // Check displacement
                Assert.AreEqual(expectedCurve[i], actualCurve[i], tolerance * actualCurve[i]);
                // Check resistance
                Assert.AreEqual(expectedCurve[i], actualCurve[i], tolerance * actualCurve[i]);
            }

            return true;
        }

        [TestMethod]
        public void DummySandLateralSoilModel()
        {
            var model = new DummySandLateralSoilModel(6.0, 1.0, 8192.999484104974, 30.0, 16286828.469658198);
            var pyCurve = model.GenerateCurve();

            // Check Results
            var expectedValues_py_y = new List<double> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 40};
            var actualValues_py_y = pyCurve.Select(dp => dp.X).ToList();
            AreEqual(expectedValues_py_y, actualValues_py_y);

            var expectedValues_py_p = new List<double> { 0, 5338.74962214668, 12650.3775163697,
                16861.2568917978, 17757.0721551143, 16435.9694923759, 14020.4437576331, 11304.7062003074,
                8746.75807997222, 6557.76879431953, 4795.95415446884, 3437.67118839023, 2423.5132422567,
                1684.89775113044, 1157.56892176903, 787.185790751224, 530.56504531972, 354.813759227811,
                235.641382114614, 155.531261335854, 102.087936265327, 102.087936265327 };
            var actualValues_py_p = pyCurve.Select(dp => dp.Y).ToList();
            AreEqual(expectedValues_py_p, actualValues_py_p);
        }

        [TestMethod]
        [DataRow(20.0, 3.0, 1.1)]
        [DataRow(10.0, 5.0, 0.88)]
        public void DummySand_CalculateACoefficient(double soilDepth, double pileDiameter, double expectedA)
        {
            var reeseSand = new DummySandLateralSoilModel(soilDepth, pileDiameter);
            var actualA = reeseSand.CalculateACoefficient(soilDepth, pileDiameter);
            Assert.AreEqual(expectedA, actualA, expectedA * tolerance);
        }

        [TestMethod]
        public void DummyRockLateralSoilModel()
        {
            var model = new DummyRockLateralSoilModel(10.0, 1.0, 20000000.0, 500000.0);
            
            List<CurvePoint> pyCurve = model.GenerateCurve();
            var expectedValues_py_y = new List<double> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 40};
            var actualValues_py_y = pyCurve.Select(dp => dp.X).ToList();
            AreEqual(expectedValues_py_y, actualValues_py_y);

            var expectedValues_py_p = new List<double> { 0, 20000000, 41000000, 63000000, 86000000, 110000000,
                135000000, 161000000, 188000000, 216000000, 245000000, 275000000, 306000000, 338000000, 371000000,
                405000000, 440000000, 476000000, 513000000, 551000000, 590000000, 590000000 };
            var actualValues_py_p = pyCurve.Select(dp => dp.Y).ToList();
            AreEqual(expectedValues_py_p, actualValues_py_p);
        }
    }
}
