using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There is a rectange.");
            double x;
            double y;

            Console.Write("Please type its length: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please type its width: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("du, du, du...");
            Console.WriteLine("The area of this retange is : ");

            Console.Write(x * y);
            Console.ReadKey();
        }
    }
}
