using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progDemo07
{
    public class GroundControl
    {
        private List<Flight>_flights;
        private DateTime _currentTime = DateTime.Now;

        public GroundControl()
        {
            _flights = new List<Flight>();
        }

        public void AddFlight(Flight flight)
        {
            _flights.Add(flight);
        }

        private double AverageDelay()
        {
            double delayInMinutes = 0;
            double countDelayedFlights = 0;
            foreach (Flight flight in _flights)
            {
                if (flight.GepStatusz == statusz.Delayed)
                {
                    delayInMinutes += flight.KesesPercben;
                }

                if (flight.GepStatusz != statusz.Canceled)
                {
                    countDelayedFlights++;
                }
            }

            if (countDelayedFlights == 0)
            {
                return 0;
            }

            else
            {
                return delayInMinutes / countDelayedFlights;
            }
        }

        public void DisplayFlightData()
        {
            foreach (Flight flight in _flights)
            {
                Console.WriteLine(flight.AllData());
            }

            Console.WriteLine($"Average delay is {AverageDelay()} minutes.");
        }
    }   
}