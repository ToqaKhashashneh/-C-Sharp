

using System;

namespace Array_Task
{
    internal class Program
    {
        public static void jana()
        {
            int x = 15;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    break;
                }
                else
                {

                    Console.WriteLine("prime");
                    break;

                }
            }
        }
        static void Main(string[] args)
        {
            jana();
            //string[] fruits = new string[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Enter Fruit ");
            //    string fruit = Console.ReadLine();
            //    fruits[i] = fruit;
            //}
            ////for (int i = 0; i < 5; i++)
            //{

            //    Console.WriteLine("fruit at index" +{ i}
            //    +"is" + { fruits[i] });

            //}
            //    Console.WriteLine(fruits[i])

            //      Console.ReadLine();

        }
    }
}
