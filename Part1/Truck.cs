using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    class Truck : Vehicle
    {
        private double loadCap;    // in imperial tons
        private int towCap;        // in pounds

        public Truck()
        {

        }
        public Truck(ManName m, int c, Person o, double l, int t)
        {
            SetManuf(m);
            SetCylinders(c);
            SetOwner(o);
            SetLoadCap(l);
            SetTowCap(t);

        }

        public void SetTowCap(int t)
        {
            towCap = t;
        }

        public void SetLoadCap(double l)
        {
            loadCap = l;
        }

        public int GetTowCap()
        {
            return towCap;
        }

        public double GetLoadCap()
        {
            return loadCap;
        }

        public string ToString()
        {
            return "Manufacturer: " + Enum.GetName(typeof(ManName), GetManuf()) + " Number of cylinders: " + GetCylinders() +
                " Tow capacity in pounds: " + GetTowCap() + " Load capacity in tons: " + GetLoadCap() + 
                " Owner: " + GetOwner().GetName();
        }

        public bool Equals(Truck obj)
        {
            return GetManuf() == obj.GetManuf() && GetCylinders() == obj.GetCylinders() && GetOwner().Equals(obj.GetOwner())
                && GetLoadCap() == obj.GetLoadCap() && GetTowCap() == obj.GetTowCap();
                

        }

    }
}
