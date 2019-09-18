using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("");
       
            //Create a short fill in the blank math quiz. Prompt the user with a question and accept a typed answer as input.

            //Let the user know if they got the answer write or wrong.
            int Correct = 0;
            int Wrong = 0;
            double x;
            //Question 1
            Console.WriteLine("Answer the sum of 111 + 222 + 333 + 444. ");
            x = Convert.ToDouble(Console.ReadLine());
            
            
            if (x == 1110)
            {
                Console.WriteLine("Correct ! ");
                //Correct = Convert.ToInt32(Console.ReadLine());
                Correct = Correct + 1; 
            }
            else
            {
                Console.WriteLine("Sorry, you got wrong answer. ");
                //Wrong = Convert.ToInt32(Console.ReadLine());
                Wrong = Wrong + 1;
            }
            // Question 2

            Console.WriteLine("Simplify: 26 + 32 - 12 ");
            x = Convert.ToDouble(Console.ReadLine());
            if (x == 46)
            {
                Console.WriteLine("Correct ! ");
                Correct = Correct + 1;
            }

            else
            {
                Console.WriteLine("Sorry, you got wrong answer. ");
                Wrong = Wrong + 1;
            }

            // Question 3

            Console.WriteLine(" ");
            x = Convert.ToDouble(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("Correct ! ");
                Correct = Correct + 1;
            }

            else
            {
                Console.WriteLine("Sorry, you got wrong answer. ");
                Wrong = Wrong + 1;
            }

            // Question 4

            Console.WriteLine(" ");
            x = Convert.ToDouble(Console.ReadLine());
            if (x == 0 )
            {
                Console.WriteLine("Correct ! ");
                Correct = Correct + 1;
            }

            else
            {
                Console.WriteLine("Sorry, you got wrong answer. ");
                Wrong = Wrong + 1;
            }

            //Question 5

            Console.WriteLine(" ");
            x = Convert.ToDouble(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("Correct ! ");
                Correct = Correct + 1;
            }

            else
            {
                Console.WriteLine("Sorry, you got wrong answer. ");
                Wrong = Wrong + 1;
            }

            Console.WriteLine("This is your totally correct times: "+ Correct );
            Console.WriteLine("And this is yout totally wrong times: " + Wrong);

            //Determine how many questions the user answers correctly and incorrectly.

            //Your math quiz should include at least 5 questions.

            Console.ReadKey();
        }
    }
}
