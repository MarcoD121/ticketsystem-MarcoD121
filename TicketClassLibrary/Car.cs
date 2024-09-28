namespace TicketClassLibrary
{
    public class Car
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the price of the vehicle
        /// </summary>
        /// <returns>A double representing the price of the vehicle</returns>
        public double Price()
        {
            return 240;
        }

        /// <summary>
        /// Returns the type of the vehicle
        /// </summary>
        /// <returns>A string representing the vehicle type</returns>
        public string VehicleType()
        {
            return "Car";
        }


    }
}
