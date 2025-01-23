

using System;
using System.Globalization;
using static _23_1_2025.Calculator;

namespace _23_1_2025
{
    //---------------------Overload----------------------------
    public class Calculator
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public void Add(int num1, int num2, int num3) //same name but different parameters (change in # of parameters)
        {
            Console.WriteLine(num1 + num2 + num3);
        }

        public void Add(double num1, double num2) //same name but different parameters (change in data type)
        {
            Console.WriteLine(num1 + num2);
        }
    }
    //----------------------------Override-------------------------
        public class shape //base class / parent class / super class
    {
         public virtual void draw ()   //virtual keyword is used to allow the method to be overridden in the derived class
        { 
                Console.WriteLine("This is a basic shape"); //method to be overridden
        }

        
        }


        public class  Circle : shape //derived class / child class / sub class

    {
            public override void draw() //override keyword is used to override the method in the derived class
        {
                Console.WriteLine("Drawing a circle"); //overriding the method
        }

        }

        public class  Rectangle : shape //derived class / child class / sub class

    {
            public override void draw()  //override keyword is used to override the method in the derived class
        {
                Console.WriteLine("Drawing a rectangle");
            }
        }
    //--------------------------------Abstract-----------------------------------------
        public  abstract class Animal //abstract class
    {
          public  abstract void animalSound(); //abstract method

        public void sleep() //non-abstract method
        {
                Console.WriteLine("Animal is sleeping"); //method to be inherited
        }
        }

        public class Dog : Animal //derived class
    {
            public override void animalSound()  //override the abstract method (implement the abstract method)
        {
                Console.WriteLine("Dog barks");
            }
        }

        public class Cat : Animal //derived class
    {
            public override void animalSound()
            {
                Console.WriteLine("Cat meows");
            }
        }

    //---------------------------------Interface----------------------------------

    interface IPlayable //interface
    {
         void play(); //method to be implemented by the derived class 

    }

    class Guitar: IPlayable //derived class
    {
        public void play()
        {
            Console.WriteLine("Playing the guitar.");
        }

    }

    class Piano: IPlayable
    {
        public void play()
        {
            Console.WriteLine("Playing the piano");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------------Overload----------------------------
            Calculator addition = new Calculator();
            addition.Add(5, 6);
            addition.Add(5, 6, 7);
            addition.Add(5.5, 6.5);


            //---------------------Override----------------------------
            shape s1 = new Circle(); 
            s1.draw();

            shape s2 = new Rectangle();
            s2.draw();


            //---------------------Abstract----------------------------
            Dog dog = new Dog();
            dog.animalSound();

            Cat cat = new Cat();
            cat.animalSound();
            //---------------------Interface----------------------------
            IPlayable playable = new Piano();
            playable.play();

            IPlayable playable1 = new Guitar();      
            playable1.play();




        }
    }
}
