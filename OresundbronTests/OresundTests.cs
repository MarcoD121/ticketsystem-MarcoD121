using TicketClassLibrary;

namespace Oresundbron.Tests;

[TestClass()]
public class OresundTests
{
    [TestMethod()]
    [DataRow(true, 161)]
    [DataRow(false, 410)]
    public void PriceTestCarOK(bool brobizz, int expected)
    {
        Vehicle car = new Car();
        double actual = Oresund.Price(car, brobizz);
        Assert.AreEqual(expected, actual, 0.01);
    }

    [TestMethod()]
    [DataRow(true, 73)]
    [DataRow(false, 210)]
    public void PriceTestMCOK(bool brobizz, int expected)
    {
        Vehicle mc = new MC();
        double actual = Oresund.Price(mc, brobizz);
        Assert.AreEqual(expected, actual, 0.01);
    }
    

    [TestMethod()]
    public void VehicleTypeCarTest()
    {
        Vehicle car = new Car();
        string actual = Oresund.VehicleType(car); 
        Assert.AreEqual("Oresund car", actual);
    }
    [TestMethod()]
    public void VehicleTypeMCTest()
    {
        Vehicle mc = new MC();
        string actual = Oresund.VehicleType(mc);
        Assert.AreEqual("Oresund MC", actual);
    }
}