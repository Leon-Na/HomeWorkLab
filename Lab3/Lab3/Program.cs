using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            Console.WriteLine("Please type a number ");
            x = Convert.ToDouble(Console.ReadLine());
            //Ask user to input a number
            Console.WriteLine("Please type another number");
            y = Convert.ToDouble(Console.ReadLine());

            //Another number input
            //A + B and output total
            Console.Write("Here is your total: \"");
            Console.Write(x + y);
            Console.Write("\"");

            Console.ReadKey();
        }
    }
}
