/// Homework No. 9		Exercise Part 1
/// File Name: Vehicle
/// @author: Evan Sinclair
/// Date:  Nov 9, 2020
///
/// Problem Statement: Create a class called Vehicle that has the Manufracturer name (enum), number of Cyclinders in 
/// the engine (int), and the owner (Person, see below).  Then create a classs called Truck that is derived from 
/// Vehicle and has the additional following properties: the load capacity in tons (double), and towing capacity in 
/// pounds (int).  Be sure your class has a reasonable set of constructors, getters/setters, properties and suitably 
/// defined ToString and Equals methods.  Write a driver program to test all your methods. 
/// 
/// 
/// Overall Plan:
/// 1)Complete Person Class with Constructors, setter, getter, Equals method and ToString
/// 2)Create Vehicle Class with Constructors, setters and getters, Equals and ToString methods 
/// 3)Create Truck Class that extends Vehicle Class
/// 4) Create Driver to test classes
///
///

using System;

namespace Part1
{

    class Program
    {
        static void Main(string[] args)
        {
            Person bob = new Person("Bob");
            Person dave = new Person("Dave");
            Person bob2 = new Person("Bob");
            bob.Equals(bob2);
            bob.Equals(dave);
            Truck truck1 = new Truck(ManName.Ford, 6, bob, 2.2, 5000);
            Truck truck2 = new Truck(ManName.Ford, 6, bob2, 2.2, 5000);
            Truck truck3 = new Truck(ManName.GM, 8, dave, 2.6, 8000);

            Console.WriteLine(truck1.ToString());
            Console.WriteLine(truck3.ToString());
            Console.WriteLine(truck3.Equals(truck2));
            Console.WriteLine(truck1.Equals(truck2));

            truck2.SetManuf(ManName.Toyota);
            Console.WriteLine(truck1.Equals(truck2));



            


        }
    }
}
