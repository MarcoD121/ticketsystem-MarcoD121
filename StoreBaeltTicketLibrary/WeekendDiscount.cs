using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public static class WeekendDiscount
    {
        /// <summary>
        /// Returns the price with a discount
        /// </summary>
        /// <param name="car"></param>
        /// <param name="day"></param>
        /// <returns>A double that represents the price after weekend discount</returns>
        /// <exception cref="ArgumentException"></exception>
        public static double PriceWithWeekendDiscount(Vehicle car, string day)
        {
            if (car.GetType() != typeof(Car))
                throw new ArgumentException("Vehicle must be a car to get Weekend discount");
            else if (day != "Sunday" && day != "Saturday")
                throw new ArgumentException("Day must be either Saturday or Sunday to get Weekend discount");
            else
                return 0.8 * car.Price(true);
        }
    }
}
