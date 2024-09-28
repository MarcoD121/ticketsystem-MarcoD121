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
            var car = new Car();
            double price = car.Price();
            Assert.AreEqual(240, price, 0.01);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            var vehicle = new Car();
            string vehicleType = vehicle.VehicleType();
            Assert.AreEqual("Car", vehicleType);
        }
    }
}