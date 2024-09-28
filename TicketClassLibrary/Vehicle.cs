using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public abstract class Vehicle
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the price of the vehicle
        /// </summary>
        /// <returns>A double representing the price of the vehicle</returns>
        public virtual double Price()
        {
            return 0;
        }

        /// <summary>
        /// Returns the type of the vehicle
        /// </summary>
        /// <returns>A string representing the vehicle type</returns>
        public virtual string VehicleType()
        {
            return "";
        }
    }
}
