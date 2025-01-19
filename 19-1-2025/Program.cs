

using System;

namespace _19_1_2025
{
    internal class Program
    {

        static double Speed(double KmperHour)
        {
            double Mph = KmperHour * 0.621371;
            return Mph;
        }

        static double timeConversion(double TimeinHours, double TimeinMinutes)
        {
            double Time = TimeinHours * 60 ;
            Time += TimeinMinutes;
            return Time;
        }

        static void minutesConversion (int Minutes)
        {
            int Hours = Minutes / 60;
            double RemainMin = Hours % 60;
            Console.WriteLine($"Time in hours : " + Hours);
            Console.WriteLine($"Time in minutes : " + RemainMin);

           

        }
        static void Main(string[] args)
        {

   
            Console.WriteLine("Q1 \n Insert a a double number: ");
           String number1 = Console.ReadLine();
            double doubleNumber = Convert.ToDouble(number1);
            int intNumber = Convert.ToInt32(doubleNumber);
            Console.WriteLine($"The integer number is: " + intNumber);


            Console.WriteLine("Q2 \n Insert a number: ");
            String number2 = Console.ReadLine();
            String number2String = Convert.ToString(number2);
            Console.WriteLine("Your number is: " + number2String);

            Console.WriteLine("Q3 \n Insert a Sentence: ");
            String sentence = Console.ReadLine();
            Console.WriteLine($"UpperCase  :  " + sentence.ToUpper());
            Console.WriteLine($"Lower Case : " + sentence.ToLower());

            Console.WriteLine("Q4 \n Insert Your First & Last Name: ");
            String Fname = Console.ReadLine();
            String Lname = Console.ReadLine();
            String FullName = Fname + Lname;
            Console.WriteLine($"First Name : " + Fname  + $"\n Last Name : " + Lname + $"\n Total Charachters : " + FullName.Length );

            Console.WriteLine("Q5 \n Insert Two Numbers");
            string number51 = Console.ReadLine();
            string number52 = Console.ReadLine();
            int num51 = Convert.ToInt32(number51);       
            int num52 = Convert.ToInt32(number52);
            if (num51 < num52)
            {
                Console.WriteLine  ( $"The Smaller Number is :" + num51);
            }
            else
            {
                Console.WriteLine  ($"The Smaller Number is :" + num52);
            }


            Console.WriteLine("Q6 \n Insert the speed: ");
            string speedString = Console.ReadLine();
            double speedKmperhour = Convert.ToDouble(speedString);
            Console.WriteLine(Speed(speedKmperhour));


            Console.WriteLine("Q7 \n Insert Time in hours and minutes: ");
            string hours = Console.ReadLine();
            string minutes = Console.ReadLine();
            double TimeinHours = Convert.ToDouble(hours);
            double TimeinMinutes = Convert.ToDouble(minutes);

            timeConversion(TimeinHours, TimeinMinutes);
            Console.WriteLine($"Time in minutes is : " + timeConversion(TimeinHours, TimeinMinutes));


            Console.WriteLine("Q8 \n Insert Time in minutes: ");
            String minutesQ8 = Console.ReadLine();
            int minutesConverted = Convert.ToInt32(minutesQ8);
            minutesConversion(minutesConverted);



            Console.Read();
        }


    }
}
