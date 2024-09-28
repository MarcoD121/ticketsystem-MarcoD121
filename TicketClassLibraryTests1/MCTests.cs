using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace TicketClassLibraryTests1
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            Vehicle mc = new MC();
            double price = mc.Price();
            Assert.AreEqual(125, price, 0.01);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            Vehicle mc = new MC();
            string vehicleType = mc.VehicleType();
            Assert.AreEqual("MC", vehicleType);
        }
    }
}
