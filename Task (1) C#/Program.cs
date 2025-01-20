

using System;

namespace Task__1__C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q1");
            Console.WriteLine("Enter Your Name ");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine("Q2");

            double num = 2.5;
            Console.WriteLine(num);

            String Name = "Toqa";
            Console.WriteLine(Name);

            Char Grade = 'A';
            Console.WriteLine(Grade);

            bool Case = true;
            Console.WriteLine(Case);

            int Age = 25;
            Console.WriteLine(Age);

            const double PI = 3.14;
            Console.WriteLine(PI);

            Console.WriteLine("Q3");

            String[] Cars = { "Tesla", "Mercedes", "LandCruiser", "BMW" };
            foreach (String i in Cars)
                Console.WriteLine(i);

            Console.WriteLine("Q4");
            Console.WriteLine("Input Your First Name");
            String FName = Console.ReadLine();


            Console.WriteLine("Input Your Last Name");
            String LName = Console.ReadLine();

            Console.WriteLine("Input Your Year Of Birth");
            String Year = Console.ReadLine();

            Console.Write(FName);
            Console.Write(LName);
            Console.WriteLine(Year);

            Console.WriteLine("Q5");

            string[] Elemnts = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter Element ");
                string element = Console.ReadLine();
                Elemnts[i] = element;
            }
            Console.WriteLine("The Elements are ");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Elemnts[i]);
            }


            Console.ReadLine();



        }
    }
}
