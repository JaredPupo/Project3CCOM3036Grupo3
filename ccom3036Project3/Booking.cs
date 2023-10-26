using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccom3036Project3
{
    internal class Booking
    {
        public Flight FlightName { get; set; }
        public Customer Passenger { get; set; }

        public Booking(Flight flightName, Customer passenger)
        {
            FlightName = flightName;
            Passenger = passenger;
        }
    }
}
