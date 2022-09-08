using System;
namespace Assignment
{
     public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter odd numbers btn 7 amd 15");
            int odd = Convert.ToInt32(Console.ReadLine());
            int t;
            int sum = 0;
            Console.WriteLine("The odd numbers are:");
            for (t = 7; t <= 15; t++)
            {
                if (t % 2 == 1)
                {
                    Console.WriteLine(t);
                    sum = sum + t;
                }

            }

            Console.WriteLine("Sum is:" + sum);



        }





    }
}