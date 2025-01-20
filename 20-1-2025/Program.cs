
using System;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace _20_1_2025
{
    internal class Program
    {
        //Q1..........................................................
        static void EvenOdd()
        {
            Console.WriteLine("Q1 \n Insert a number to check if it\'s even or odd: ");
           int number = Convert.ToInt32(Console.ReadLine());
            

            if (number % 2 == 0)
            {
                Console.WriteLine($"The Number Is Even"); ;
            }
            else
            {
                Console.WriteLine($"The Number Is Odd"); ;
            }

        }
        //Q2....................................................................
        static void SecondSmallest()
        {
            Console.WriteLine("Q2 \n Insert a number to check the second smallest number: ");
            int[] NumberArray = new int[5];
            for (int i = 0; i < 5; i++)
            {
                NumberArray[i] = Convert.ToInt32(Console.ReadLine());
               

            }

            Array.Sort(NumberArray);
            Console.WriteLine(NumberArray[1]);
        }
        //Q3....................................................................
        static void Factorial() 
        {    
            Console.WriteLine("Q3 \n Insert a number to get the factorial: ");
            int count = 1;
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = number; i > 0; i--)
                count *= i; 
            {
                Console.WriteLine(count);
            }
        }
        //Q4....................................................................
        static void PrimeBetween()
        {
            Console.WriteLine("Q4 \n Insert two numbers to get the prime numbers between them: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            for (int i = num1+1; i < num2; i++)    
            {
                bool IsPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        IsPrime = false;
                        break;

                    }

                }

                if (IsPrime && i>1)
                {
                    Console.WriteLine(i);
                }


            }
        }

        //Q5....................................................................
        static void Max()

        { 
            Console.WriteLine("Q5 \n Insert elemnts number to compare (array size): ");
            // 1) to let the user determine the array size 

            int size = int.Parse(Console.ReadLine());
            int[] arrofNumbers = new int[size];
            Console.WriteLine("  Insert elemnts to compare: ");
            // 2) to add the elemnts into the array 
            for (int i = 0; i < size; i++)
            {
                arrofNumbers[i] = int.Parse(Console.ReadLine());
            }

            //3)  to find the maximum number in the array
            int max = 0;
            foreach (int element in arrofNumbers)
                {

                 max = arrofNumbers.Max();
            }
            Console.WriteLine($"The Maximum Number is: " + max);

        }

        //Q6....................................................................
        static void Pattern()
        {

            int n = 5; //number of rows
            int count = 1; //initialize the count (all of the work depends on the count "it's a commulative process")
            // i represent the current row number
            for (int i = 1; i <= n; i++)
                {
                // j represent number of columns ( number of elements will be written)
                for (int j = 1; j <= i; j++)
                    {

                        Console.Write(count +" ");
                    count++;
                    }
                    Console.WriteLine();
                }
           
        }

        //Q Class && Object

        public  class  Hotel_Reservations 
        {
            public int RoomNumber;
            public string RoomType;
            public double PricePerNight;
            public bool IsBooked;
            public const string hotelname= "Grand Stay Hotel";
        }



        static void Main(string[] args)
        {

            EvenOdd();

            SecondSmallest();

            Factorial();

            PrimeBetween();

            Max();

            Pattern();


            Console.WriteLine("Q7 \n Insert the room number and room type: ");
            Hotel_Reservations room1 = new Hotel_Reservations();
            room1.RoomNumber = int.Parse(Console.ReadLine());
            room1.RoomType = Console.ReadLine();
            room1.PricePerNight = 100;
            room1.IsBooked = false;

            Console.WriteLine($"Room Number: {room1.RoomNumber} \n" +
                $" Room Type: {room1.RoomType} \n" +
                $" Price Per Night: {room1.PricePerNight} \n " +
                $"Is Booked: {room1.IsBooked} \n " +
                $"Hotel Name: {Hotel_Reservations.hotelname}");

            Hotel_Reservations room2 = new Hotel_Reservations();
            room2.RoomNumber = int.Parse(Console.ReadLine());
            room2.RoomType = Console.ReadLine();
            room2.PricePerNight = 200;
            room2.IsBooked = true;

            Console.WriteLine($"Room Number :  {room2.RoomNumber} \n" +
               $"Room Type: {room2.RoomType} \n" +
               $"Price Per Night :  {room2.PricePerNight}\n" +
               $"Is Booked:  {room2.IsBooked }\n" +
               $"Hotel Name : { Hotel_Reservations.hotelname}");


        }
    }
}
