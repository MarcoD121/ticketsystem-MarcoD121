using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class WeekendDiscountTests
    {
        [TestMethod()]
        [DataRow("Saturday")]
        [DataRow("Sunday")]
        public void PriceWithWeekendDiscountTest(string day)
        {
            Vehicle vehicle = new Car();
            double actual = WeekendDiscount.PriceWithWeekendDiscount(vehicle, day);
            Assert.AreEqual(vehicle.Price(true) * 0.8, actual, 0.01);   
        }
    }
}