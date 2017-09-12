using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* If Statements are used in coding when you want certain lines of code to be executed only
             * under certain circumstances.
             * For example, IF this happens, THEN this will happen.
             * 
             * Else Clauses are used with If Statements when you want certain lines of code to be executed only
             * when certain circumstances are NOT fulfilled.
             * For example, IF this happens, THEN this will happen. OTHERWISE, do this.
             */

            int x = 3;
            double y = 4.2;

            char input;

            int hp;
            int ap;

            int remainder;
            const int HALF = 2;

            // 1 --------------------------------------------------------------------------------------------------

            if (x > 0)
            {

                if (x > 0) // The parenthesis contain the condition to be tested
                {          //The curly braces contain the code to be executed if the condition is satisfied
                    Console.WriteLine("X is positive");
                }

                else if (x < 0)
                {
                    Console.WriteLine("X is negative");
                }

                else
                {
                    Console.WriteLine("X is 0");
                }
            }

            // 2 -------------------------------------------------------------------------------------------------

            if (y % 2 == 0)
            {
                Console.WriteLine("Y is a whole number");
            }

            else
            {
                Console.WriteLine("Y is not a whole number");
            }

            // 3 -------------------------------------------------------------------------------------------------

            Console.WriteLine("What day of the week is it today?");
            if (input = 'M' || 'T' || 'W' || 'R' || 'F')
            {
                Console.WriteLine("It's not the weekend yet...you have to go to work");
            }

            else
            {
                Console.WriteLine("It's the weekend! You can go back to bed");
            }

            // 4 -------------------------------------------------------------------------------------------------

            if (hp < ap)
            {
                Console.WriteLine("Your health points were depleted by the attacker...you died.");
            }

            else
            {
                Console.WriteLine("You live to fight another day");
            }

            // 5 ----------------------------------------------------------------------------------------------------

            if (x % HALF == 0)
            {
                Console.WriteLine("X is an even number");
            }

            else
            {
                Console.WriteLine("X is aan odd number");
            }
        }
    }
}