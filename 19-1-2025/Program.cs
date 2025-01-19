

using System;
using System.Runtime.Remoting.Channels;

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
            double RemainMin =  Minutes % 60;
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
            Console.WriteLine($"First Name : " + Fname + $"\n Last Name : " + Lname + $"\n Total Charachters : " + FullName.Length);

            Console.WriteLine("Q5 \n Insert Two Numbers");
            string number51 = Console.ReadLine();
            string number52 = Console.ReadLine();
            int num51 = Convert.ToInt32(number51);
            int num52 = Convert.ToInt32(number52);
            if (num51 < num52)
            {
                Console.WriteLine($"The Smaller Number is :" + num51);
            }
            else
            {
                Console.WriteLine($"The Smaller Number is :" + num52);
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
            string minutesQ8 = Console.ReadLine();
            int minutesConverted = Convert.ToInt32(minutesQ8);
            minutesConversion(minutesConverted);

            Console.WriteLine("Q9 (A) insert two numbers to compare: \n");
            string Num91 = Console.ReadLine();
            string Num92 = Console.ReadLine();
            double Num91Conv = Convert.ToDouble(Num91);
            double Num92Conv = Convert.ToDouble(Num92);
            if (Num91Conv > Num92Conv)
            {
                Console.Write($"Between " + Num91Conv + $" and " + Num92Conv + "\n" + Num91Conv + $" Is Greater");
            }
            else if (Num91Conv < Num92Conv)
            {
                Console.Write($"Between " + Num91Conv + $" and " + Num92Conv + "\n" + Num91Conv + $" Is Smaller");
            }
            else
            {
                Console.Write(Num91Conv + $" and " + Num92Conv + "\n" + " Both are equal");
            }

            Console.WriteLine("Q9 (B) \n Insert a number");
            string Num9B = Console.ReadLine();
            double Sum = 0;
            for (int i = 0; i < Num9B.Length; i++)
            {
                string value = Convert.ToString(Num9B[i]);
                Sum += double.Parse(value);

            }

            Console.WriteLine(Sum);

            Console.WriteLine("Q10 \n Insert a number to reverse :");


            //trial (1) without artihmatic operations
            //string Num10 = Console.ReadLine();
            //string reversed = "";

            //for (int i = Num10.Length - 1; i >= 0; i--)
            //{
            //    reversed += Num10[i];
            //}
            //**********************************************************

            //trial(2) with artihmatic operations
            string Num10 = Console.ReadLine();
            int Num10Conv = int.Parse(Num10);
            int reversed = 0;
            while (Num10Conv > 0)
            {
                int digit = Num10Conv % 10;
                reversed = reversed * 10 + digit;
                Num10Conv /= 10;
            }

            Console.WriteLine("Reversed Number: " + reversed);


            Console.WriteLine("Q11 \n Insert two numbers to check divisibility   :");
            string BigNum = Console.ReadLine();
            string SmallNum = Console.ReadLine();
            int BigNumConv = int.Parse(BigNum);
            int SmallNumConv = int.Parse(SmallNum);
            if (BigNumConv % SmallNumConv == 0)
            {
                Console.WriteLine("Divisible");
            }
            else
            {
                Console.WriteLine("Not Divisible");
            }

            Console.WriteLine("Q12 \n Insert three numbers to find their middle value : ");
            string Num12A = Console.ReadLine();
            string Num12B = Console.ReadLine();
            string Num12C = Console.ReadLine();
            double Num12AConv = int.Parse(Num12A);
            double Num12BConv = int.Parse(Num12B);
            double Num12CConv = int.Parse(Num12C);
            double MiddleValue = (Num12AConv + Num12BConv + Num12CConv) / 3;
            Console.WriteLine($"The Middle Value for " + Num12A + $" and " + Num12B + $" and " + Num12C +" is : " + MiddleValue);

            


            Console.Read();
        }


    }
}
