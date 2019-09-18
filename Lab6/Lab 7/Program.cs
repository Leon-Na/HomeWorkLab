using System;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type down how tall you are in inch. ");
            
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            if ( x <= 60 || x >= 75)
            {
                Console.WriteLine("Your height is definitely not average. ");
            }
            else
            {
                Console.WriteLine("Your height is normal. ");
            }
            Console.ReadKey();
        }
    }
}
