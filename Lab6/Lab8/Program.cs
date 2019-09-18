using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Have the computer generate a random integer between 1 and 10. The user must attempt to guess the number. 
            //After each guess, the system should tell the user whether they guessed too high or too low until the user guesses the answer.
            // Once the user has guessed the right answer, congratulate the user and let them know how many guesses it took to determine the correct answer.
            int x;
            int count = 0;
            Random r = new Random();
            int rnd = r.Next(0, 11);
            Console.WriteLine("Please enter an integer between 1 - 10. ");

            x = Convert.ToInt32(Console.ReadLine());
            while (x > rnd || x < rnd) // x!= rnd
            {
                if (x < rnd)
                {
                    Console.WriteLine("Your number is smaller than mine. ");
                    Console.Write("Type another integer. ");
                    x = Convert.ToInt32(Console.ReadLine());
                    count++;
                    
                }


                else
                {
                    Console.WriteLine("Your number is greater than mine. ");
                    Console.Write("Type another integer? ");
                    x = Convert.ToInt32(Console.ReadLine());
                    count++;
                }

            }

                count++;
                Console.WriteLine("Correct!!! And this is the answer : " + x );
                Console.WriteLine("You have tried " + count + " times.");
                Console.ReadKey();
            
        }
    }
}
