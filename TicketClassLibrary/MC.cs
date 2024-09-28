using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class MC
    {
        public string LicensePlate {  get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the price of the vehicle
        /// </summary>
        /// <returns>A double representing the price of the vehicle</returns>
        public double Price()
        {
            return 125;
        }

        /// <summary>
        /// Returns the type of the vehicle
        /// </summary>
        /// <returns>A string representing the vehicle type</returns>
        public string VehicleType()
        {
            return "MC";
        }
    }
}
