namespace TicketClassLibrary
{
    public class Car : Vehicle
    {

        /// <summary>
        /// Returns the price of the ticket
        /// </summary>
        /// <returns>A double representing the price of the ticket</returns>
        public override double Price(bool discount)
        {
            return 240*Brobizz(discount);
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
