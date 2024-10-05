using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class MC : Vehicle
    {
        /// <summary>
        /// Returns the price of the vehicle
        /// </summary>
        /// <returns>A double representing the price of the vehicle</returns>
        public override double Price(bool discount)
        {
            return 125*Brobizz(discount);
        }

        /// <summary>
        /// Returns the type of the vehicle
        /// </summary>
        /// <returns>A string representing the vehicle type</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
