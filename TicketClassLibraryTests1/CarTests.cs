using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            Vehicle car = new Car();
            double price = car.Price(false);
            Assert.AreEqual(240, price, 0.01);
        }

        [TestMethod()]
        public void PriceTestWithDiscount()
        {
            Vehicle vehicle = new Car();
            double price = vehicle.Price(true);
            Assert.AreEqual(240 * 0.95, price, 0.01);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            Vehicle vehicle = new Car();
            string vehicleType = vehicle.VehicleType();
            Assert.AreEqual("Car", vehicleType);
        }

        [TestMethod]
        [DataRow("123456")]
        [DataRow("1234567")]
        public void LisenceplateOK(string lisenceplate)
        {
            Vehicle vehicle = new Car();
            vehicle.Licenseplate = lisenceplate;
            Assert.AreEqual(vehicle.Licenseplate.Length, lisenceplate.Length);
        }

        [TestMethod]
        [DataRow("12345678")]
        [ExpectedException(typeof(Exception))]
        public void LisenceplateNotOK(string lisenceplate)
        {
            Vehicle vehicle = new Car();
            vehicle.Licenseplate = lisenceplate;
            Assert.Fail();
        }
    }
}