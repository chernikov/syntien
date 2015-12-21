using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Syntien.TemperatureSensor.Dummy.Tools;

namespace Syntien.TemperatureSensor.Dummy.Tests
{
    [TestClass]
    public class BitsTest
    {
        [TestMethod]
        public void ShiftNunber_3ShiftTwo_Expect12()
        {
            var result = 3 << 2;
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void ShiftSerialNumber_Some()
        {
            var value = 0xE203C004 << 2;

            var bytes = BitConverter.GetBytes(value);

            var str = BitTools.ByteArrayToString(bytes);

            Assert.AreEqual(0, 0);
        }
    }
}
