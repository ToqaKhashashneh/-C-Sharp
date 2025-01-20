

using System;

namespace Problem_Solving
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string arr = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'a' || arr[i] == 'e' || arr[i] == 'o' || arr[i] == 'u' || arr[i] == 'i')
                {
                    count++;

                }

            }
            Console.WriteLine($"Number of vowels is : " + count);
        }
    }
}
