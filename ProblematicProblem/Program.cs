using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    public static class Program//all compile errors have been fixed, but there's still runtime errors that need to be tested and fixed as well.
    {
        //static Random rng = new Random();//why is this static? why is this class static? Also, VS Community suggests that this field of the static program class is never assigned to anything specific, even when an instantiation of it has been initialized as shown here on this line, but it was determined that this line of code needed to be brought inside of the main method's scope.
        static string cont;//why is this static? why is this class static?//static bool cont = true;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Laser Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };//why is this static? why is this class static?
        //activities.Add//cannot call a method outside of the main method, but we can define methods to be called inside of the main method, outside of it.
        static void Main(string[] args)
        {
            //activities.Add("Beer Pong", "Flip Cup");//activities.Add is an extension method that only accepts one argument at a time....
            activities.Add("Beer Pong");
            activities.Add("Flip Cup");
            activities.Add("Kings");
            activities.Add("Jello Shots");
            activities.Add("Chugging Contest");
            activities.Add("Edward 40 Hands");//a college favorite!
            Random rng = new Random();//we needed to make a new instance of the random class, and the 'rng' variable is actually an object that serves as an instantiation of such a class.... makes sense when I read it that way, but it's easy to forget stuff. This line of code allows for an object of the random class to also be instantiated or created at runtime, which allows this entire script to yield its intended output. Otherwise, if we did not write in this object intializination here, then an error would get thrown at the end of this whole script that suggests an instance, or object rng, of the random class could not be created, because tis value is set to null (I imagine because null would be its default value, ubless we created an instance of the class its being based off of first).
            Console.Write("Hello, welcome to the random activity generator! \n \nWould you like to generate a random activity? yes/no: ");//Console.Write is a method used to continuously keep all printed data contained and written on the same line, whereas Console.WriteLine will print data to different lines each time it is called (in other words, you could call Console.Write multiple times, and as long as they're all called within the same block of code, each typed out instance will be combined into one line).
            cont = Console.ReadLine();//cont = bool.Parse(Console.ReadLine());
            Console.WriteLine();
            #region Want a random activity generated?

            if (cont == "yes" || cont == "Yes")
            {
                Console.WriteLine("Great! Information from you will be prompted in just a moment -- We'll be with you shortly.");
                Console.WriteLine();
                Thread.Sleep(1772);
                //break;//looks like VS Community is smart enough to notice whether or not a break function is being implemented inside of a an otherwise unbreakable loop structure.
            }
            else if (cont == "no" || cont == "No")
            {
                Console.WriteLine("Sure thing, no worries. Peace.");
                Console.WriteLine();
                Thread.Sleep(1772);
                return;
            }
            while (cont != "yes" && cont != "Yes" && cont != "no" && cont != "No")
            {
                Console.WriteLine("Why couldn't you answer with a simple yes or no?");
                Console.WriteLine();
                Thread.Sleep(4772);
                Console.Clear();
                Console.WriteLine("Would you like to generate a random activity? yes/no:");
                Console.WriteLine();
                Thread.Sleep(1772);
                cont = Console.ReadLine();
                Console.WriteLine();
                Console.Clear();
                if (cont == "yes" || cont == "Yes")
                {
                    Console.WriteLine("Great! Information from you will be prompted in just a moment -- We'll be with you shortly.");
                    Console.WriteLine();
                    Thread.Sleep(1772);
                    break;//return;//Terminate;
                }
                else if (cont == "no" || cont == "No")
                {
                    Console.WriteLine("Sure thing, no worries. Peace.");
                    Console.WriteLine();
                    Thread.Sleep(1772);
                    return;
                }
            }
            #endregion

            #region What is your name? What's your age?
            Console.Write("We are going to need your information first! What is your name? ");//This string isn't well written -- it lends itself to a myriad of logical problems; pending the potential of previous prompts coming before it.... but we'll see if it can be worked with.
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is your age? ");
            //int userAge = int.Parse(Console.ReadLine());//TryParse didn't work here for some reason.
            bool actualAge = double.TryParse(Console.ReadLine(), out double userAge);//decided I'd keep variable userAge as a value type, rather than set as a bool, since it's already been written into another script that anticipates such down below, at the end of the program.
            Console.WriteLine();

            if (actualAge == true)
            {
                Console.WriteLine("Good, we'll see which activities you qualify for, in a bit.");
                Console.WriteLine();
            }
            Console.WriteLine();
            while (actualAge == false)
            {
                Console.WriteLine("Did you ever think of using an actual number? Might help, just saying.");
                Console.WriteLine();
                Thread.Sleep(4692);
                Console.Clear();
                Console.Write("What is your age? ");
                Console.WriteLine();
                actualAge = double.TryParse(Console.ReadLine(), out userAge);
                Console.WriteLine();
                Thread.Sleep(1692);
                Console.Clear();
                if (actualAge == true)
                {
                    Console.WriteLine("Good, we'll see which activities you qualify for, in a bit.");
                    Console.WriteLine();
                }
            }
            #endregion

            #region Want to see the current list of activities?
            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            //bool seeList = bool.TryParse(Console.ReadLine(), out string userResponse);//this didn't work because VS Community suggests that a string cannot be converted to a bool.//bool seeList = bool.Parse(Console.ReadLine());
            Console.WriteLine();

            var seeList = Console.ReadLine();

            if (seeList == "yes" || seeList == "Yes" || seeList == "Sure" || seeList == "sure")
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);//measured in milliseconds.
                }
                Console.WriteLine();
            }
            else if (seeList == "no" || seeList == "No" || seeList == "No Thanks" || seeList == "no thanks")
            {
                Console.WriteLine("Not to worry, carry on then.");
                Console.WriteLine();
            }
            while (seeList != "Yes" && seeList != "yes" && seeList != "Sure" && seeList != "sure" && seeList != "No" && seeList != "no" && seeList != "No thanks" && seeList != "no thanks")
            {
                Console.WriteLine("You've provided an invalid response. Try again.");
                Console.WriteLine();
                Thread.Sleep(4553);
                Console.Clear();
                Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
                Console.WriteLine();
                seeList = Console.ReadLine();
                Console.WriteLine();
                Thread.Sleep(1553);
                Console.Clear();
                if (seeList == "yes" || seeList == "Yes" || seeList == "Sure" || seeList == "sure")
                {
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }
                    Console.WriteLine();
                    break;
                }
                else if (seeList == "no" || seeList == "No" || seeList == "No Thanks" || seeList == "no thanks")
                {
                    Console.WriteLine("Not to worry, carry on then.");
                    Console.WriteLine();
                    break;
                }
            }
            #endregion

            #region Want to add any activities?
            Console.Write("Would you like to add any activities before we generate one? yes/no: ");
            Console.WriteLine();
            var addToList = Console.ReadLine();//bool addToList = bool.Parse(Console.ReadLine());
            Console.WriteLine();

            //if (addToList == "yes" || addToList == "Yes")
            //{
            //    Console.Write("What would you like to add? ");
            //    string userAddition = Console.ReadLine();
            //    Console.WriteLine();
            //    activities.Add(userAddition);
            //    Console.WriteLine();
            //    foreach (string activity in activities)
            //    {
            //        Console.Write($"{activity} ");
            //        Thread.Sleep(250);
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("Would you like to add more? yes/no: ");
            //    Console.WriteLine();
            //    addToList = Console.ReadLine();
            //    Console.WriteLine();

            //    if (addToList == "yes" || addToList == "Yes")
            //    {
            //        Console.Write("What would you like to add? ");
            //        userAddition = Console.ReadLine();
            //        Console.WriteLine();
            //        activities.Add(userAddition);
            //        Console.WriteLine();
            //        foreach (string activity in activities)
            //        {
            //            Console.Write($"{activity} ");
            //            Thread.Sleep(250);
            //        }

            //        Console.WriteLine();
            //        Console.WriteLine("Would you like to add more? yes/no: ");
            //        Console.WriteLine();
            //        addToList = Console.ReadLine();
            //        Console.WriteLine();

            //        if (addToList == "yes" || addToList == "Yes")
            //        {
            //            Console.Write("What would you like to add? ");
            //            userAddition = Console.ReadLine();
            //            Console.WriteLine();
            //            activities.Add(userAddition);
            //            Console.WriteLine();
            //            foreach (string activity in activities)
            //            {
            //                Console.Write($"{activity} ");
            //                Thread.Sleep(250);
            //            }
            //            Console.WriteLine();
            //            Console.WriteLine("Alright; no more activity adding for you.");
            //            Console.WriteLine();

            //            while (addToList != "yes" && addToList != "no" && addToList != "Yes" && addToList != "No")
            //            {
            //                Console.WriteLine("It seems that the comprehension of yes or no is beyond your capacity....");
            //                Console.WriteLine();
            //                Thread.Sleep(4871);
            //                Console.Clear();
            //                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
            //                Console.WriteLine();
            //                Thread.Sleep(1871);
            //                addToList = Console.ReadLine();
            //                Console.WriteLine();
            //                Console.Clear();
            //                if (addToList == "yes" || addToList == "Yes")//while (addToList == "yes" || seeList == "Yes")
            //                {
            //                    Console.Write("What would you like to add? ");
            //                    userAddition = Console.ReadLine();
            //                    activities.Add(userAddition);
            //                    Console.WriteLine();
            //                    foreach (string activity in activities)
            //                    {
            //                        Console.Write($"{activity} ");
            //                        Thread.Sleep(250);
            //                    }
            //                    Console.WriteLine();
            //                    Console.WriteLine("Would you like to add more? yes/no: ");
            //                    Console.WriteLine();
            //                    addToList = Console.ReadLine();//addToList = bool.Parse(Console.ReadLine());//addToList has already had its value declared above. Needed to have its type changed any per its own logic and runtime error.
            //                    Console.WriteLine();                               //strongly typed; once a variable has been declared, its type cannot be changed.
            //                }
            //                while (addToList != "yes" && addToList != "no" && addToList != "Yes" && addToList != "No")//nested a while loop inside of a nested if statement ftw.
            //                {
            //                    Console.WriteLine("Whaaaa? No yes or no for you.");
            //                    Console.WriteLine();
            //                    Thread.Sleep(4960);
            //                    Console.Clear();
            //                    Console.WriteLine("Would you like to add more? yes/no: ");
            //                    Console.WriteLine();
            //                    Thread.Sleep(1960);
            //                    addToList = Console.ReadLine();
            //                    Console.WriteLine();
            //                    Console.Clear();
            //                    if (addToList == "yes" || addToList == "Yes")
            //                    {
            //                        Console.Write("What would you like to add? ");
            //                        userAddition = Console.ReadLine();
            //                        activities.Add(userAddition);
            //                        Console.WriteLine();
            //                        foreach (string activity in activities)
            //                        {
            //                            Console.Write($"{activity} ");
            //                            Thread.Sleep(250);
            //                        }
            //                        Console.WriteLine();
            //                        Console.WriteLine("Would you like to add more? yes/no: ");
            //                        Console.WriteLine();
            //                        addToList = Console.ReadLine();
            //                        Console.WriteLine();

            //                        while (addToList != "yes" && addToList != "no" && addToList != "Yes" && addToList != "No")//nested a while loop inside of a nested if statement, inside of another while loop, inside of another if statement, ftw.
            //                        {
            //                            Console.WriteLine("Whaaaa? No yes or no for you.");
            //                            Console.WriteLine();
            //                            Thread.Sleep(4960);
            //                            Console.Clear();
            //                            Console.WriteLine("Would you like to add more? yes/no: ");
            //                            Console.WriteLine();
            //                            Thread.Sleep(1960);
            //                            addToList = Console.ReadLine();
            //                            Console.WriteLine();
            //                            Console.Clear();
            //                            if (addToList == "yes" || addToList == "Yes")
            //                            {
            //                                Console.Write("What would you like to add? ");
            //                                userAddition = Console.ReadLine();
            //                                activities.Add(userAddition);
            //                                Console.WriteLine();
            //                                foreach (string activity in activities)
            //                                {
            //                                    Console.Write($"{activity} ");
            //                                    Thread.Sleep(250);
            //                                }
            //                                Console.WriteLine();
            //                                Console.WriteLine("Alright; no more activity adding for you.");
            //                                Console.WriteLine();
            //                                break;
            //                            }
            //                            else if (addToList == "no" || addToList == "No")
            //                            {
            //                                Console.WriteLine();
            //                                Console.WriteLine("Ok, we'll just stick with what's already being offered.");
            //                                Console.WriteLine();
            //                                break;
            //                            }
            //                        }
            //                    }
            //                    else if (addToList == "no" || addToList == "No")
            //                    {
            //                        Console.WriteLine();
            //                        Console.WriteLine("Ok, we'll just stick with what's already being offered.");
            //                        Console.WriteLine();
            //                        break;
            //                    }
            //                }
            //            }
            //        else if (addToList == "no" || addToList == "No")
            //        {
            //            Console.WriteLine();
            //            Console.WriteLine("Ok, we'll just stick with what's already being offered.");
            //            Console.WriteLine();
            //            break;
            //        }
            //    }
            //}
            //else if (addToList == "no" || addToList == "No")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Ok, we'll just stick with what's already being offered.");
            //    Console.WriteLine();
            //}
            //while (addToList != "yes" && addToList != "no" && addToList != "Yes" && addToList != "No")
            //{
            //    Console.WriteLine("It seems that the comprehension of yes or no is beyond your capacity....");
            //    Console.WriteLine();
            //    Thread.Sleep(4871);
            //    Console.Clear();
            //    Console.Write("Would you like to add any activities before we generate one? yes/no: ");
            //    Console.WriteLine();
            //    Thread.Sleep(1871);
            //    addToList = Console.ReadLine();
            //    Console.WriteLine();
            //    Console.Clear();
            //        if (addToList == "yes" || addToList == "Yes")//while (addToList == "yes" || seeList == "Yes")
            //        {
            //            Console.Write("What would you like to add? ");
            //            userAddition = Console.ReadLine();
            //            activities.Add(userAddition);
            //            Console.WriteLine();
            //            foreach (string activity in activities)
            //            {
            //                Console.Write($"{activity} ");
            //                Thread.Sleep(250);
            //            }
            //            Console.WriteLine();
            //            Console.WriteLine("Would you like to add more? yes/no: ");
            //            Console.WriteLine();
            //            addToList = Console.ReadLine();//addToList = bool.Parse(Console.ReadLine());//addToList has already had its value declared above. Needed to have its type changed any per its own logic and runtime error.
            //            Console.WriteLine();                               //strongly typed; once a variable has been declared, its type cannot be changed.
            //        }
            //        while (addToList != "yes" && addToList != "no" && addToList != "Yes" && addToList != "No")//nested a while loop inside of a nested if statement ftw.
            //        {
            //            Console.WriteLine("Whaaaa? No yes or no for you.");
            //            Console.WriteLine();
            //            Thread.Sleep(4960);
            //            Console.Clear();
            //            Console.WriteLine("Would you like to add more? yes/no: ");
            //            Console.WriteLine();
            //            Thread.Sleep(1960);
            //            addToList = Console.ReadLine();
            //            Console.WriteLine();
            //            Console.Clear();
            //            if (addToList == "yes" || addToList == "Yes")
            //            {
            //                Console.Write("What would you like to add? ");
            //                userAddition = Console.ReadLine();
            //                activities.Add(userAddition);
            //                Console.WriteLine();
            //                foreach (string activity in activities)
            //                {
            //                    Console.Write($"{activity} ");
            //                    Thread.Sleep(250);
            //                }
            //                Console.WriteLine();
            //                Console.WriteLine("Would you like to add more? yes/no: ");
            //                Console.WriteLine();
            //                addToList = Console.ReadLine();
            //                Console.WriteLine();

            //                while (addToList != "yes" && addToList != "no" && addToList != "Yes" && addToList != "No")//nested a while loop inside of a nested if statement, inside of another while loop, inside of another if statement, ftw.
            //                {
            //                    Console.WriteLine("Whaaaa? No yes or no for you.");
            //                    Console.WriteLine();
            //                    Thread.Sleep(4960);
            //                    Console.Clear();
            //                    Console.WriteLine("Would you like to add more? yes/no: ");
            //                    Console.WriteLine();
            //                    Thread.Sleep(1960);
            //                    addToList = Console.ReadLine();
            //                    Console.WriteLine();
            //                    Console.Clear();
            //                    if (addToList == "yes" || addToList == "Yes")
            //                    {
            //                        Console.Write("What would you like to add? ");
            //                        userAddition = Console.ReadLine();
            //                        activities.Add(userAddition);
            //                        Console.WriteLine();
            //                        foreach (string activity in activities)
            //                        {
            //                            Console.Write($"{activity} ");
            //                            Thread.Sleep(250);
            //                        }
            //                        Console.WriteLine();
            //                        Console.WriteLine("Alright; no more activity adding for you.");
            //                        Console.WriteLine();
            //                        break;
            //                    }
            //                    else if (addToList == "no" || addToList == "No")
            //                    {
            //                        Console.WriteLine();
            //                        Console.WriteLine("Ok, we'll just stick with what's already being offered.");
            //                        Console.WriteLine();
            //                        break;
            //                    }
            //                }
            //            }
            //            else if (addToList == "no" || addToList == "No")
            //            {
            //                Console.WriteLine();
            //                Console.WriteLine("Ok, we'll just stick with what's already being offered.");
            //                Console.WriteLine();
            //                break;
            //            }
            //        }
            //    }
            //    else if (addToList == "no" || addToList == "No")
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("Ok, we'll just stick with what's already being offered.");
            //        Console.WriteLine();
            //        break;
            //    }
            //}
            if (addToList == "yes" || addToList == "Yes")
            {
                Console.Write("What would you like to add? ");//Remember that addToList is just the prompt; userChoice is the actual activity they want to add to activities list.
                var userChoice = Console.ReadLine();
                activities.Add(userChoice);
                Console.WriteLine();
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }
                Console.WriteLine();
                Console.WriteLine("Would you like to add more? yes/no: ");
                Console.WriteLine();
                addToList = Console.ReadLine();
                Console.WriteLine();
            }
            if (addToList == "yes" || addToList == "Yes")
            {
                Console.Write("What would you like to add? ");
                var userChoice = Console.ReadLine();
                activities.Add(userChoice);
                Console.WriteLine();
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }
                Console.WriteLine();
                Console.WriteLine("Alright; no more activity adding for you.");
                Console.WriteLine();
            }
            else if (addToList == "no" || addToList == "No")//C# wants every else if or else statement to be preceded by an if statement. If this does not happen, C# gets very upset.... don't make C# upset.
            {
                Console.WriteLine();
                Console.WriteLine("Ok, we'll just stick with what's already being offered.");
                Console.WriteLine();
            }
            while (addToList != "yes" && addToList != "no" && addToList != "Yes" && addToList != "No")//nested a while loop inside of a nested if statement, inside of another while loop, inside of another if statement, ftw.
            {//this while loop should trigger at any instance associated with user input, where if the user fails to put in an accepted response, it defaults to this while loop's script.... which is great in the sense that no additional scripted behavior is needed to handle errors and other exceptions.
                Console.WriteLine("Whaaaa? No yes or no for you.");
                Console.WriteLine();
                Thread.Sleep(4960);
                Console.Clear();
                Console.WriteLine("Would you like to add more? yes/no: ");
                Console.WriteLine();
                Thread.Sleep(1960);
                addToList = Console.ReadLine();
                Console.WriteLine();
                Console.Clear();
                if (addToList == "yes" || addToList == "Yes")
                {
                    Console.Write("What would you like to add? ");
                    var userChoice = Console.ReadLine();
                    activities.Add(userChoice);
                    Console.WriteLine();
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Alright; no more activity adding for you.");
                    Console.WriteLine();
                    break;
                }
                else if (addToList == "no" || addToList == "No")
                {
                    Console.WriteLine();
                    Console.WriteLine("Ok, we'll just stick with what's already being offered.");
                    Console.WriteLine();
                    break;
                }
            }

            #endregion

            if (cont == "yes" || cont == "Yes")//while (cont == "yes" || cont == "Yes")
            {
                Console.Write("Connecting to the database");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                    //break;
                }
                Console.WriteLine();
                Console.Write("Choosing your random activity");

                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                    //break;
                }
                Console.WriteLine();
                //break;
            }
            int randomNumber = rng.Next(activities.Count);
            string randomActivity = activities[randomNumber];
            while (userAge < 21 && randomActivity == "Wine Tasting" || randomActivity == "Beer pong" || randomActivity == "Flip Cup" || randomActivity == "Edward 40 Hands" || randomActivity == "Chugging Contest" || randomActivity == "Kings" || randomActivity == "Jello Shots")//if (userAge < 21 && randomActivity == "Wine Tasting" || randomActivity == "Beer pong" || randomActivity == "Flip Cup" || randomActivity == "Edward 40 Hands" || randomActivity == "Chugging Contest" || randomActivity == "Kings" || randomActivity == "Jello Shots")//it's so strange.... I had to set the first two conditial with the && operator, and then the rest of them with the || operator just to get the same finctionality for each possible input.... C# is a strange beast.
            {
                Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                Console.WriteLine();
                Thread.Sleep(770);
                Console.WriteLine("Let's get something else picked out for you!");
                Console.WriteLine();
                Thread.Sleep(770);
                Console.WriteLine("Are you ready? Then press any key followed by the return key to continue.");
                Console.ReadLine();
                Console.WriteLine();
                activities.Remove(randomActivity);
                randomNumber = rng.Next(activities.Count);
                randomActivity = activities[randomNumber];
            }
            Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
            Console.WriteLine();
            cont = Console.ReadLine();//bool cont = bool.Parse(Console.ReadLine());
            Console.WriteLine();

            if (cont == "Redo" || cont == "redo")
            {
                Console.WriteLine("Great! We'll input your request back into the activity generator, and see what comes out.");
                Console.WriteLine();
                Thread.Sleep(1772);
                activities.Remove(randomActivity);
                randomNumber = rng.Next(activities.Count);
                randomActivity = activities[randomNumber];
                while (userAge < 21 && randomActivity == "Wine Tasting" || randomActivity == "Beer pong" || randomActivity == "Flip Cup" || randomActivity == "Edward 40 Hands" || randomActivity == "Chugging Contest" || randomActivity == "Kings" || randomActivity == "Jello Shots")//if (userAge < 21 && randomActivity == "Wine Tasting" || randomActivity == "Beer pong" || randomActivity == "Flip Cup" || randomActivity == "Edward 40 Hands" || randomActivity == "Chugging Contest" || randomActivity == "Kings" || randomActivity == "Jello Shots")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine();
                    Thread.Sleep(770);
                    Console.WriteLine("Let's get something else picked out for you!");
                    Console.WriteLine();
                    Thread.Sleep(770);
                    Console.WriteLine("Are you ready? Then press any key followed by the return key to continue.");
                    Console.ReadLine();
                    Console.WriteLine();
                    activities.Remove(randomActivity);
                    randomNumber = rng.Next(activities.Count);
                    randomActivity = activities[randomNumber];
                }
                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Hope this one floats your boat. ");
                return;
            }
            else if (cont == "keep" || cont == "Keep")
            {
                Console.WriteLine("Sure thing, no worries. Peace.");
                Console.WriteLine();
                Thread.Sleep(1772);
                return;
            }
            while (cont != "yes" && cont != "Yes" && cont != "no" && cont != "No")
            {
                Console.WriteLine("Why couldn't you answer with a simple yes or no?");
                Console.WriteLine();
                Thread.Sleep(4772);
                Console.Clear();
                Console.WriteLine("Would you like to generate a random activity? yes/no:");
                Console.WriteLine();
                Thread.Sleep(1772);
                cont = Console.ReadLine();
                Console.WriteLine();
                Console.Clear();
                if (cont == "yes" || cont == "Yes")
                {
                    Console.WriteLine("Great! Information from you will be prompted in just a moment -- We'll be with you shortly.");
                    Console.WriteLine();
                    Thread.Sleep(1772);
                    while (userAge < 21 && randomActivity == "Wine Tasting" || randomActivity == "Beer pong" || randomActivity == "Flip Cup" || randomActivity == "Edward 40 Hands" || randomActivity == "Chugging Contest" || randomActivity == "Kings" || randomActivity == "Jello Shots")//if (userAge < 21 && randomActivity == "Wine Tasting" || randomActivity == "Beer Pong" || randomActivity == "Flip Cup" || randomActivity == "Edward 40 Hands" || randomActivity == "Chugging Contest" || randomActivity == "Kings" || randomActivity == "Jello Shots")
                    {
                        Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                        Console.WriteLine();
                        Thread.Sleep(770);
                        Console.WriteLine("Let's get something else picked out for you!");
                        Console.WriteLine();
                        Thread.Sleep(770);
                        Console.WriteLine("Are you ready? Then press any key followed by the return key to continue.");
                        Console.ReadLine();
                        Console.WriteLine();
                        activities.Remove(randomActivity);
                        randomNumber = rng.Next(activities.Count);
                        randomActivity = activities[randomNumber];
                    }
                    Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Hope this one floats your boat. ");
                    return;//break;
                }
                else if (cont == "no" || cont == "No")
                {
                    Console.WriteLine("Sure thing, no worries. Peace.");
                    Console.WriteLine();
                    Thread.Sleep(1772);
                    return;
                }
            }
        }
    }
}
