using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using _22_1_2025;

namespace _22_1_2025
{
    class vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public void Start()
        {
            Console.WriteLine("The vehicle is starting");
        }

        public void print()
        {
            Console.WriteLine($"Car Brand: {Brand} \n Car Model : {Model} ");
        }
    }

    class Car : vehicle
     {
        public int numberOfDoors { get; set; }
     }
    internal class Program
    {
        static void Main(string[] args)
        {
            vehicle car1 = new Car();


            Car car2 = new Car();
            car2.Brand = "Toyota";
            car2.Model = "Land Crusier";
            car2.numberOfDoors = 4;
            car2.Start();
            car2.print();
        }
    }
}


//1)What is constructor?
//a special class method that is called every time an instance of the class is made. it has the same name of a class
//it has many types such as default constructor which is called without parameter and Parameterized Constructor which
//is called with atleast one parameter 

//2)What are the basic concepts of OOPs?
//abstraction, encapsulation, inheritance and polymorphism


//3)What is the Encapsulation?
//a way to restrict the direct access to some components of an object, its done with properties when we make get and set
//for data it means that i take senstive data and make operations on it without displaying the orginal data for security reasons

//4)What is the sealed class?
// it is a parent class aka(super-classes)ot(base class) which can't be inherited to child classes aka (sub-classes) (derived) although we can make object from it
// in other words the parent class can't be extended.
// it is done by adding the keyword "sealed" before the class that we want it to be sealed 

//5)What is the Inheritance concept?
//Inheritance is a fundamental concept in object-oriented programming (OOP) that allows a child class to inherit the properties from the superclass
//The new class inherits the properties and methods of the existing class and can also add new properties and methods of its own.
//Inheritance promotes code reuse, simplifies code maintenance, and improves code organization.
