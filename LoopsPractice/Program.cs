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
            ////Keywoords break and continue

            ////For Loop
            ////Can be used for both counting and/or...
            ////...ITERATING through an array (or other collection type).
            ////Looks like this:
            ////for(initializer; condition; updater)
            ////{
            ////    do something
            ////}

            ////for(int i = 0; i <= 10; i ++)
            ////{
            ////    Console.WriteLine(i);
            ////}

            ////for(int i = 15; i > 0; i --)
            ////{
            ////    Console.WriteLine(i);
            ////}

            ////for(int i = 50; i <= 100; i++)
            ////{
            ////    Console.WriteLine(i);
            ////}


            ////for loops to print the elements of an array
            ////string greeting = "My name is Little Bill.";
            //////The .Split() method takes a string and turns it into an array of smaller
            //////...strings (substrings). It defaults the split on spaces.
            ////string[] wordsInGreeting = greeting.Split();
            //////for loop to print the words
            ////for(int i = 0; i < wordsInGreeting.Length; i++)
            ////{
            ////    Console.WriteLine(wordsInGreeting[i]);
            ////}

            ////Create an array called days with the elements Monday, Tuesday, and Wednesday.
            ////Using a for loop, print the elements of the days array.
            //string daysOfWeek = "Monday Tuesday Wednesday";
            //string[] weekdays = daysOfWeek.Split();
            //for (int i = 0; i < weekdays.Length; i++)
            //{
            //    Console.WriteLine(weekdays[i]);
            //}

            ////Start with the string "Once upon a time" and create an array called
            ////storyWords using the Split method. Reverse the order of the elements in
            ////the array and using a for loop, print each word.
            //string storyBeginning = "Once upon a time";
            //string[] storyWords = storyBeginning.Split();
            //for(int i = storyWords.Length -1; i >= 0; i--)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

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
            //int product = 1;
            //for(int i = 1; i <=10; i++)
            //{
            //    product = product * 1;
            //}

            //Console.WriteLine(product);




            //Foreach Loop - used to iterate over a collection (ex. list or array)
            //You can think of the structure of a foreach loop as the statement:
            //For each item in the collection, do something

            //string[] firstMonths = { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };
            ////Always start with the keyword foreach
            //foreach(string month in firstMonths)
            //{
            //    Console.WriteLine(month);
            //}
            //foreach loops allow the temporary variable to "know" to assign...
            //itself to each element in the collection (like an array), one at a time

            //Create an array of musicians (bands or solo artists)
            //Using a foreach loop, print each musician's name
            //string[] musicians = { "Mos Def", "Jimi Hendrix", "Masego", "Wu Tang Clan" };
            //foreach (string musician in musicians)
            //{
            //    Console.WriteLine(musician);
            //}


            //While loop is used when you want a chunk of code to run only if a condition is met first
            //While something is TRUE

            //Console.WriteLine("What is your first name?");
            //string firstName =Console.ReadLine();
            //while(firstName.ToUpper() == "ADAM")
            //{
            //    Console.WriteLine("Dude, you are amazing.");
            //    break;
            //}

            //Console.WriteLine("Do you want to play the game? YES/NO");
            //string playAgain = Console.ReadLine();
            //while(playAgain == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}


            //Do-While loop is similar to a while loop, however...
            //...the Do-While loop is used when you want a chunk of code to run...
            //...AT LEAST ONCE, but repeat only if the While condition is met

            //The structure of a do-while look looks like this:
            //do
            //{
            //    do something
            //}
            //while(condition); 

            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Welcome to my game!");
            //    //let's pretend the code for the game is here
            //    Console.WriteLine("Great game!!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //        playAgain = Console.ReadLine();
            //}
            //while (playAgain == "YES");


            //Ask the user for the class (in school) that they would like to add to their GPA calculation.
            //Ask the user for the letter grade for the class (no + or -)
            //Ask the user if they have another class they would like to add to theyr GPA calculation.
            //Using a Do-While Loop, repeate the code if the user says "YES"

            //string addedClass;
            //string gradeInClass;
            //string addedClassToo;
            //string gradeInClassToo;
            //Console.WriteLine("Do you have a class you would like to add to your GPA calculation? YES/NO");
            //addedClass = Console.ReadLine();
            //Console.WriteLine("What is the grade you received in the class?");
            //gradeInClass = Console.ReadLine();
            //do
            //{
            //    Console.WriteLine("Do you have another class you would like to add to your GPA calculation? YES/NO");
            //    addedClassToo = Console.ReadLine();
            //    //if addedClassToo(Console.ReadLine() == "NO");
            //    //    {
            //    //    continue;
            //    //}
            //    Console.WriteLine("What is the grade you received in the class?");
            //    gradeInClassToo = Console.ReadLine(); 
            //}
            //while (addedClassToo == "YES");


            //Nested Loop
            //loop inside of another loop

            //Create a nested loop structure that prints:
            //1234
            //1234

            //for(int rows = 1; rows <=6; rows++)
            //{
            //    for(int columns = 1; columns <=4; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //}

            //Print a Triangle
            //Outer loop will go line by line
            //The inner loop will go over different elements in the line.
            //Result:
            //1
            //1 2
            //1 2 3 
            //1 2 3 4...

            //for(int rows =1; rows <=4; rows++)
            //{
            //    for(int columns = 1; columns <= rows; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine("Lets play FizzBuzz!");
            //Console.WriteLine("Please enter your FIZZ number");
            //int fizz = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter your BUZZ number");
            //int buzz = int.Parse(Console.ReadLine());
            //Console.WriteLine("What number would you like me to count to? (Pick a high one)");
            //int endNumber = int.Parse(Console.ReadLine());
            //for(int i = 0; i <= endNumber; i++)
            //{
            //    if(i % fizz == 0 && i % buzz == 0)
            //    {
            //        Console.WriteLine("Fizz Buzz!");
            //    }
            //    else if (i % fizz == 0)
            //    {
            //        Console.WriteLine("Fizz!");
            //    }

            //else if (i % buzz == 0)
            //    {
            //        Console.WriteLine("Buzz!");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }



            //Write a program that prints a multiplication table (5 x 5, for example) using a nested loops.
            .
            //int multNum = 1;
            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= 5; j++)
            //    {
            //        Console.Write(multNum * j + " ");
            //    }
            //    multNum += 1; 
            //    Console.WriteLine();
            //}

            //Create an array of your favorite movies.Print out each movie in the list, unless the move starts with a vowel. 
            //Hint: Research.startsWith()






            //Write a console application that asks the user for an integer. If that integer is evenly divisible by 3, 
            //...then write “You Won!” If it isn’t, write “You Lost.” Keep asking them for a number (looping)until they win


        }
    }
}
