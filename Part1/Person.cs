using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    class Person
    {
        private string name;

        public Person()
        {

        }
        public Person(string theName)
        {
            name = theName;
        }
        public Person(Person obj) 
        {
            name = obj.GetName();
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string n)
        {
            name = n;
        }

        public bool Equals(Person obj)
        {
            return GetName().Equals(obj.GetName());
        }

        public string ToString()
        {
            return "Name: " + GetName();
        }
    }
}
