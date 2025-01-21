using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace _21_1_2025
{

    class Student //Creating a class
    {
        public string Name { get; set; } //Creating a property

        private int age; //Creating a field
        public int Age //Creating a property

        {
            get { return age; }
            set { if (age < MinAge) { age = 18; }
                else if (age > MaxAge) { age = 60; }
                else
                    age = value; }
        } 

        public int Id { get; set; } //  Creating a property

        public string Email { get; set; } //    Creating a property 

        private const int  MinAge = 18;    // Creating a field ()
        private const int MaxAge = 60;     // Creating a field ()

        public void GetDetails() //creating a method
        {
            Console.WriteLine($" Name : {Name} \n " + $" Age : {Age} \n " + $" Id : {Id} \n" + $" Email :   {Email} \n"); 

        }
        public Student()
        {
            Name = "";
            Age = 18;
            Id = 0;
            Email = "";
        }
       public Student(string Name , int Age, int Id, string Email) 
        { 
            this.Name= Name;
            this.Age = Age;

            if (Age < MinAge) { this.Age = 18; }
            else if (Age > MaxAge) { this.Age = 60; }
            else
                this.Age = Age;

            this.Id = Id;
            this.Email = Email;
        }

        ~Student()
        {
            Console.WriteLine("Destructor Called");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.Name = "Ahmad";
            S1.Age = 22;
            S1.Id = 1001;
            S1.Email = "Ahmad@gmail.com";
            S1.GetDetails();

            Student S2 = new Student("Toqa", 25, 1110, "toqamusa@gmail.com");
            S2.GetDetails();

            Student S3 = new Student("Adam", 27, 1111, "Adam@gmail.com");
            S3.GetDetails();








            //        Questions:
            //1-    What is class?

            //      A class is a user-defined blueprint or prototype from which objects are created
            //      Basically, a class combines the fields and methods(member functions which define actions) into a single unit.

            //***********************************************************************************************************************

            //2-	What is object?
            // object is the instance of a class, An object holds data and can access methods and their properties.
            //When an object is created, memory is allocated to store its data and the object’s address is assigned to the variable.
            //**********************************************************************************************************
            //3-	Difference between class && object
            // Objects have state(values of attributes / properties) and behavior (methods).
            // While Classes define the common characteristics shared by multiple objects.

            //**************************************************************************************************************
            //4-	Mention the OOP Principles 

            //1-	Encapsulation
            //2-	Inheritance
            //3-	Polymorphism
            //4-	Abstraction
            //**************************************************************************************************************
            //5-	What is property 
            //A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field.
            //*******************************************************************************************************************

            //6-	What is field 
            //A field is a variable that is declared directly in a class or struct. Fields are members of their containing type. they can be accessed directly by using the object name.
            //*******************************************************************************************************************
            //7-	What is constructor 
            //A constructor is a special method of a class or structure in object-oriented programming that initializes an object of that type. and it has the same name as the class. also, it doesn't have a return type.
            //8-	What is encapsulation
            //Encapsulation is one of the fundamental principles of object-oriented programming (OOP). It refers to the bundling of data with the methods that operate on that data. and it restricts access to some of an object's components.for security reasons.

        }
    }
}
