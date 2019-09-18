using System;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            String Noun1, Noun2, Noun3, Occupation, Verb, Place, Verbed, Noun4, Verbing, NounPL, Noun5, Emotion ;
            Console.WriteLine("Welcome to MadLib, please enjoy the your \"STORY\"");
            Console.WriteLine("Please type some words by following the type of word");
            Console.Write("Please enter the ");
            Console.Write("1st noun : ");
                Noun1 = Console.ReadLine();

            Console.Write("2nd noun : ");
                Noun2 = Console.ReadLine();

            Console.Write("3rd noun : ");
                Noun3 = Console.ReadLine();

            Console.Write("Occupation : ");
                Occupation = Console.ReadLine();

            Console.Write("verb : ");
                Verb = Console.ReadLine();

            Console.Write("Place : ");
                Place = Console.ReadLine();

            Console.Write("Verb ending in \"ED\" : ");
                Verbed = Console.ReadLine();

            Console.Write("4th noun : ");
                Noun4 = Console.ReadLine();
      
            Console.Write("Verb ending in \"ING\" : ");
                Verbing = Console.ReadLine();

            Console.Write("noun, plural : ");
                NounPL = Console.ReadLine();

            Console.Write("5th noun : ");
                Noun5 = Console.ReadLine();

            Console.Write("Emotion : ");
                Emotion = Console.ReadLine();

            Console.WriteLine("Here you are. ");
            //Main story
            Console.Write("It was during the battle of " + Noun1);
            Console.Write(" when I was running through a " + Noun2);
            Console.Write(" when a " + Noun3);
            Console.Write(" went off right next to my platoon. Our " + Occupation);
            Console.Write(" yelled for us to " + Verb);
            Console.Write(" to the nearest " + Place);
            Console.Write(" we could find. When we got the " + Place);
            Console.Write(" we " + Verbed);
            Console.Write(" to start a fire. As we were starting the fire, the enemy saw the " + Noun4);
            Console.Write(" from the fire and started " + Verbing);
            Console.Write(" " + NounPL);
            Console.Write(" at us. We all quickly ducked behind the "+ Noun5);
            Console.Write(" at the " + Place);
            Console.Write(" and returned fire. We quickly eliminated the enemy and were "+ Emotion);
            Console.Write( " that we had won the battle. " );
            // to the nearest
            //we could find. When we got the 
            //we
            //to start a fire. As we were starting the fire the enemy saw the
            // from the fire and started
            //
            //at us. We all quickly ducked behind the 
            // at the 
            // and returned fire. We quickly eliminated the enemy and were
            //that we had won the battle.
            //It was during the battle of light bulb when I was running through a picture frame when a washing machine went off right next to my platoon. 
            //Our construction worker yelled for us to dance to the nearest the moon we could find. When we got the the moon we kicked to start a fire. 
            //As we were starting the fire ,the enemy saw the plunger from  thr fire and started tickling tooth brushes at us. 
            //We all quickly ducked behind the wrist watch at the the moon and returned fire.
            //We quickly eliminated the enemy and were confusedthat we had won the battle.






            Console.ReadKey();


        }
    }
}
