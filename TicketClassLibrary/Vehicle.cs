using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public abstract class Vehicle
    {
        private string _licensePlate;
        public string Licenseplate
        {
            get
            {
                return _licensePlate;
            }
            set
            {
                if (value.Length > 7)
                {
                    throw new Exception("License plate is too long, must be below 7 characters");
                }
                else
                {
                    _licensePlate = value;
                }
            }
        }
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the price of the ticket
        /// </summary>
        /// <returns>A double representing the price of the ticket</returns>
        public virtual double Price(bool discount)
        {
            return 0*Brobizz(discount);
        }

        /// <summary>
        /// Returns the amount of discount of the ticket
        /// </summary>
        /// <param name="discount"></param>
        /// <returns>A double that represents the discount of the ticket </returns>
        public double Brobizz(bool discount)
        {
            return discount ? 0.95: 1;
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
