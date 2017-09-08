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
        }
    }
}