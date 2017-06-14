using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Vehicle
    {

        private String plate;
        private int hourIn;
        private int hourOut;
        private String state;

        public Vehicle(string plate, int hourIn)
        {
            this.plate = plate;
            this.hourIn = hourIn;
            this.state = "Inside the parking lot";
        }

        public string Plate { get => plate; set => plate = value; }
        public int HourIn { get => hourIn; set => hourIn = value; }
        public int HourOut { get => hourOut; set => hourOut = value; }
        public string State { get => state; set => state = value; }
    }
}
