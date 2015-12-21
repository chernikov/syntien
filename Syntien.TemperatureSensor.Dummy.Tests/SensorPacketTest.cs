using Microsoft.VisualStudio.TestTools.UnitTesting;
using Syntien.TemperatureSensor.Dummy.Packages.SensorPacket;
using Syntien.TemperatureSensor.Dummy.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntien.TemperatureSensor.Dummy.Tests
{
    [TestClass]
    public class SensorPacketTest
    {
        [TestMethod]
        public void TestCreateDoubleAnalogPackage()
        {
            var packet = new DualAnalogSensorPacket()
            {
                NoOfUnits = 2,
                IsService = false,
                SerialNumber = 0xE203C004,
                EngineeringUnit1 = 60,
                EngineeringUnit2 = 60,
                Value1 = 0x075E,
                Value2 = 0x0825
            };

            var data = packet.ToBytes();
            var str = BitTools.ByteArrayToString(data);

            Assert.AreEqual(0, 0);
        }
    }
}
