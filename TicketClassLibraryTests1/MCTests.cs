using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace TicketClassLibraryTests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            Vehicle vehicle = new MC();
            double price = vehicle.Price(false);
            Assert.AreEqual(125, price, 0.01);
        }
        [TestMethod()]
        public void PriceTestWithDiscount()
        {
            Vehicle vehicle = new MC();
            double price = vehicle.Price(true);
            Assert.AreEqual(125*0.95, price, 0.01);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            Vehicle mc = new MC();
            string vehicleType = mc.VehicleType();
            Assert.AreEqual("MC", vehicleType);
        }

        [TestMethod]
        [DataRow("123456")]
        [DataRow("1234567")]
        public void LisenceplateOK(string lisenceplate)
        {
            Vehicle vehicle = new MC();
            vehicle.Licenseplate = lisenceplate;
            Assert.AreEqual(vehicle.Licenseplate.Length, lisenceplate.Length);
        }

        [TestMethod]
        [DataRow("12345678")]
        [ExpectedException(typeof(ArgumentException))]
        public void LisenceplateNotOK(string lisenceplate)
        {
            Vehicle vehicle = new MC();
            vehicle.Licenseplate = lisenceplate;
            Assert.Fail();
        }
    }
}
