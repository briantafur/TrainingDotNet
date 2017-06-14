using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Vehicle
    {

        private String plaque;
        private String hourIn;
        private String hourOut;
        private String state;

        public Vehicle(string plate, String hourIn)
        {
            this.plaque = plate;
            this.hourIn = hourIn;
            this.state = "Inside the parking lot";
        }

        public string Plate { get => plaque; set => plaque = value; }
        public String HourIn { get => hourIn; set => hourIn = value; }
        public String HourOut { get => hourOut; set => hourOut = value; }
        public string State { get => state; set => state = value; }
    }
}
