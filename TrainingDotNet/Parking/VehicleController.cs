using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class VehicleController
    {

        LinkedList<Vehicle> vehicles = new LinkedList<Vehicle>();

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
                temp.HourIn = veh.HourIn;
                temp.HourOut = veh.HourOut;
                temp.State = veh.State;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool remove(Vehicle veh)
        {
            vehicles.Remove(veh);
            return true;
        }

    }
}
