namespace TicketClassLibrary
{
    public class Car : Vehicle
    {

        /// <summary>
        /// Returns the price of the vehicle
        /// </summary>
        /// <returns>A double representing the price of the vehicle</returns>
        public override double Price()
        {
            return 240;
        }

        /// <summary>
        /// Returns the type of the vehicle
        /// </summary>
        /// <returns>A string representing the vehicle type</returns>
        public override string VehicleType()
        {
            return "Car";
        }


    }
}
