using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class VehicleController
    {
        public static double VALOR_HORA = 2500;
        LinkedList<Vehicle> vehicles = new LinkedList<Vehicle>();

        internal LinkedList<Vehicle> Vehicles { get => vehicles; set => vehicles = value; }

        public VehicleController()
        {
        }

        public bool add(Vehicle veh)
        {
            Vehicle temp = search(veh.Plate);
            if (temp == null)
            {
                vehicles.AddLast(veh);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Vehicle search(String plate)
        {
            foreach (Vehicle item in vehicles)
            {
                if (item.Plate.Equals(plate))
                {
                    return item;
                }
            }
            return null;
        }

        public bool edit(Vehicle veh)
        {
            Vehicle temp = search(veh.Plate);
            if (temp != null)
            {
                temp.HourOut = veh.HourOut;
                temp.State = veh.State;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool editIngres(Vehicle veh)
        {
            Vehicle temp = search(veh.Plate);
            if (temp != null)
            {
                if (temp.State.Equals("Out"))
                {
                    temp.HourIn = veh.HourIn;
                    temp.State = veh.State;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public double calculateTotal(Vehicle veh)
        {
            return calculateHours(veh) * VALOR_HORA;
        }



        public int calculateHours(Vehicle veh)
        {
            DateTime hourIn = Convert.ToDateTime(veh.HourIn);
            DateTime hourOut = Convert.ToDateTime(veh.HourOut);
            int total = Convert.ToInt32(Math.Ceiling((hourOut - hourIn).TotalHours));
            return total;
        }

        public bool remove(Vehicle veh)
        {
            vehicles.Remove(veh);
            return true;
        }

    }
}
