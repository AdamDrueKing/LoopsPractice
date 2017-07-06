using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            //When would you use a loop?
            //Why would you use a loop?
            //Nested loops
            //Infinite loops
            //Keywoords break and continue

            //For Loop
            //Can be used for both counting and/or...
            //...ITERATING through an array (or other collection type).
            //Looks like this:
            //for(initializer; condition; updater)
            //{
            //    do something
            //}
            
            //for(int i = 0; i <= 10; i ++)
            //{
            //    Console.WriteLine(i);
            //}

            for(int i = 15; i > 0; i --)
            {
                Console.WriteLine(i);
            }

        }
    }
}
