using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    public enum ManName
    {
        Toyota,
        Honda,
        Ford,
        GM,
        BMW
    }

    class Vehicle
    {
        
        private ManName manuf;
        private int cylinders;
        private Person owner;

        public Vehicle()
        {

        }

        public Vehicle(ManName m, int c, Person o)
        {
            manuf = m;
            cylinders = c;
            owner = new Person(o);
        }

        public void SetManuf(ManName m)
        {
            manuf = m;
        }

        public void SetCylinders(int c)
        {
            cylinders = c;
        }
        
        public void SetOwner(Person o)
        {
            owner = o;
        }
        
         public ManName GetManuf()
        {
            return manuf;
        }

        public int GetCylinders()
        {
            return cylinders;
        }

        public Person GetOwner()
        {
            return owner;
        }

        public string ToString()
        {
            return "Manufacturer: " + Enum.GetName(typeof(ManName), manuf) + " Number of cylinders: " + cylinders
                + " Owner: " + owner.GetName();
        }

        public bool Equals(Vehicle obj)
        {
            return (manuf == obj.manuf && cylinders == obj.cylinders && owner.Equals(obj.owner));
        }


    }
}
