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

            //for(int i = 15; i > 0; i --)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 50; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for loops to print the elements of an array
            //string greeting = "My name is Little Bill.";
            ////The .Split() method takes a string and turns it into an array of smaller
            ////...strings (substrings). It defaults the split on spaces.
            //string[] wordsInGreeting = greeting.Split();
            ////for loop to print the words
            //for(int i = 0; i < wordsInGreeting.Length; i++)
            //{
            //    Console.WriteLine(wordsInGreeting[i]);
            //}

            //Create an array called days with the elements Monday, Tuesday, and Wednesday.
            //Using a for loop, print the elements of the days array.
            string daysOfWeek = "Monday Tuesday Wednesday";
            string[] weekdays = daysOfWeek.Split();
            for (int i = 0; i < weekdays.Length; i++)
            {
                Console.WriteLine(weekdays[i]);
            }

            //Start with the string "Once upon a time" and create an array called
            //storyWords using the Split method. Reverse the order of the elements in
            //the array and using a for loop, print each word.
            string storyBeginning = "Once upon a time";
            string[] storyWords = storyBeginning.Split();
            for(int i = storyWords.Length -1; i >= 0; i--)
            {
                Console.WriteLine(storyWords[i]);
            }

            //OR

            //string story = "Once upon a time";
            //string[] storyWords1 = story.Split();
            //Array.Reverse(storyWords);
            //for (int i = 0; i < storyWords.Length[i]; i++) ;

            //Add the product of (multiplication) 1 through 10 using a for loop
            //Print the product to the screen 
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int product = numbers[0];
            //for(int i = 0; i<numbers.Length; i++)
            //{
            //    product = product * numbers[i];
            //}

            //Console.WriteLine(product);

            //OR
            int product = 1;
            for(int i = 1; i <=10; i++)
            {
                product = product * 1;
            }

            Console.WriteLine(product);

           

        }
    }
}
