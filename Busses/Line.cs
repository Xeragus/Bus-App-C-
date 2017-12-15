using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busses
{
    public class Line
    {
        public string Destination { get; set; }
        public int DepartureHour { get; set; }
        public int DepartureMinute { get; set; }
        public float Price { get; set; }

        public Line(string destination, int departureHour, int departureMinute, float price)
        {
            Destination = destination;
            DepartureHour = departureHour;
            DepartureMinute = DepartureMinute;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1:00} - {2} - {3} Ден.", DepartureHour, DepartureMinute, Destination, Price);
        }
    }
}
