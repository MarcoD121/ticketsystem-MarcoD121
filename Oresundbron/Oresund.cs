using TicketClassLibrary;

namespace Oresundbron;

public static class Oresund
{
    public static double Price(Vehicle vehicle, bool brobizz)
    {
        if(vehicle.GetType() == typeof(Car))
            return brobizz ? 161 : 410;
       
        if(vehicle.GetType() == typeof(MC))
            return brobizz ? 73 : 210;

        throw new Exception("Vehicle must be either a Car or MC");
    }

    public static string VehicleType(Vehicle vehicle)
    {
        if(vehicle is Car)
            return "Oresund car";

        if (vehicle is MC) 
            return "Oresund MC";

        throw new Exception("Vehicle must be either a Car or MC");
    }
}
