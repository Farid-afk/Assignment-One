using System;
namespace Assignment_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter odd number btn 7 and 15");
            int odd = Convert.ToInt16(Console.ReadLine());
            int i;
            int sum = 0;
            Console.WriteLine("Odd numbers are: ");
            for (i = 7; i < 15; i++)
            {
                if(i%2==1)
                {
                    Console.WriteLine(i);
                    sum = sum + 1;

                }
            }

            Console.WriteLine("Sum is: " + sum);
        }
    }
}