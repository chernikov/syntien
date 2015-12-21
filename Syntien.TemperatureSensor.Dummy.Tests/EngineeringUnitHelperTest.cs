using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Syntien.TemperatureSensor.Dummy.Packages;

namespace Syntien.TemperatureSensor.Dummy.Tests
{
    [TestClass]
    public class EngineeringUnitHelperTest
    {
        [TestMethod]
        public void EngineeringUnitHelper_CalcTemperature_CorrectResult_0x0825()
        {
            var value = 0x0825;
            var expectedValue = 3.7;
            var calculatedData = EngineeringUnitHelper.Calc(60, value);
            Assert.AreEqual(expectedValue, calculatedData, 0.1);
        }

        [TestMethod]
        public void EngineeringUnitHelper_CalcTemperature_CorrectResult_0x075E()
        {
            var value = 0x075E;
            var expectedValue = -15.7;
            var calculatedData = EngineeringUnitHelper.Calc(60, value);
            Assert.AreEqual(expectedValue, calculatedData, 0.1);
        }



        
    }
}
