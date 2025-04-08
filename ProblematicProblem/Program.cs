using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    public static class Program//all compile errors have been fixed, but there's still runtime errors that need to be tested and fixed as well.
    {
        static Random rng;
        static string cont;//static bool cont = true;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

        static void Main(string[] args)
        {

            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");//Console.Write is a method used to continuously keep all printed data contained and written on the same line, whereas Console.WriteLine will print data to different lines each time it is called (in other words, you could call Console.Write multiple times, and as long as they're all called within the same block of code, each typed out instance will be combined into one line).
            cont = Console.ReadLine();//cont = bool.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is your age? ");
            int userAge = int.Parse(Console.ReadLine());//TryParse didn't work here for some reason.
            Console.WriteLine();
            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            var seeList = Console.ReadLine();//bool seeList = bool.Parse(Console.ReadLine());
            if (seeList == "yes" || seeList == "Yes" || seeList == "Sure" || seeList == "sure")
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);//measured in milliseconds.
                }
                Console.WriteLine();
            }
            else if(seeList == "no" || seeList == "No")
            {
                Console.WriteLine("Not to worry, carry on then.");
                Console.WriteLine();
            }
            Console.Write("Would you like to add any activities before we generate one? yes/no: ");

            var addToList = Console.ReadLine();//bool addToList = bool.Parse(Console.ReadLine());
            Console.WriteLine();
            while (addToList == "yes" || seeList == "Yes")
            {
                Console.Write("What would you like to add? ");
                string userAddition = Console.ReadLine();
                activities.Add(userAddition);
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }
                Console.WriteLine();
                Console.WriteLine("Would you like to add more? yes/no: ");
                addToList = Console.ReadLine();//addToList = bool.Parse(Console.ReadLine());//addToList has already had its value declared above. Needed to have tis type changed any per its own logic and runtime error.
            }//strongly typed; once a variable has been delcared, its type cannot be changed.

            while (cont == "yes" || cont == "Yes")
            {
                Console.Write("Connecting to the database");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }
                Console.WriteLine();
                Console.Write("Choosing your random activity");
                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }
                Console.WriteLine();
                int randomNumber = rng.Next(activities.Count);
                string randomActivity = activities[randomNumber];
                if (userAge < 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");
                    activities.Remove(randomActivity);
                    randomNumber = rng.Next(activities.Count);
                    randomActivity = activities[randomNumber];
                }
                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                Console.WriteLine();
                cont = Console.ReadLine();//bool cont = bool.Parse(Console.ReadLine());
            }
        }
    }
}
