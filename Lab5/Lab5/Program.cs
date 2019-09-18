using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here we have a circle. ");
            double r;
            Console.WriteLine("Please type a radius");
                       
            r = Convert.ToDouble(Console.ReadLine());
            //PI * 2 * r 
            Console.WriteLine("Here is your circumference");
            Console.WriteLine(Math.PI * 2 * r);
            Console.WriteLine("Here is your area : ");
            Console.WriteLine(Math.PI * r * r);
            //PI * r * r
            //Ask the user for a radius of a circle (numbers with decimals should be accepted.)
            //Calculate the area and circumference.
            //Display the results.
            Console.ReadKey();
            
        }
    }
}
