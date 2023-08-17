/*
 *  TaskPrioritizer
 *  Coded By: Jayavamsi Villuri
 */

using System.Security.Cryptography.X509Certificates;

// intro menu
Console.WriteLine("**************************************");
Console.WriteLine("\tTaskPrioritizer\t");
Console.WriteLine("**************************************");
Console.WriteLine("Got multiple things to do? No worries, We'll help you out by prioritizing the things.");
Console.WriteLine("Please enter your task(s) below!");

// initializing input
var input = "initial";

// declaring various list collections
var allTasks = new List<string>();
var doNow = new List<string>();
var delNow = new List<string>();
var assignNow = new List<string>();
var scheduleNow = new List<string>();

// while loop to take task inputs
while (!String.IsNullOrEmpty(input) || input != "q")
{
    Console.Write("[!] you may type (q) to exit when you are done listing your task(s)\n> ");
    input = Console.ReadLine();
    if (string.IsNullOrEmpty(input) || input.ToLower() == "q")
    {
        Console.WriteLine("Thanks for using out TaskPrioritizer.");
        break;
    }
    else
    {
        Console.Write($"[!] Is the task \"{input}\" urgent? (y/n/q to quit)\n> ");
        var inpUrgent = Console.ReadLine();

        Console.Write($"[!] Is the task \"{input}\" important? (y/n/q to quit)\n> ");
        var inpImp = Console.ReadLine();

        if (inpUrgent.ToLower() == "y" && inpImp.ToLower() == "y")
        {
            // task added to the all tasks list
            allTasks.Add(input);

            // task added to the do now task list
            doNow.Add(input);
        }

        else if (inpUrgent.ToLower() == "n" && inpImp.ToLower() == "n")
        {
            // task added to the all tasks list
            allTasks.Add(input);

            // task added to the delete now task list
            delNow.Add(input);
        }
        else if (inpUrgent.ToLower() == "y" && inpImp.ToLower() == "n")
        {
            // task added to the all task list
            allTasks.Add(input);

            // task added to the assign now task list
            assignNow.Add(input);
        }
        else if (inpUrgent.ToLower() == "n" && inpImp.ToLower() == "y")
        {
            // task added to the all task list
            allTasks.Add(input);

            // task added to the schedule now task list
            scheduleNow.Add(input);
        }
        else if (inpUrgent.ToLower() == "q" || inpImp.ToLower() == "q")
        {
            Console.WriteLine("Thanks for filling out the tasks.");
            break;
        }
        else
        {
            // handling inputs other than expected inputs.
            Console.WriteLine("wrong inputs provided. please try again!");
        }
        //allTasks.Add(input);

        Console.WriteLine(input);
    }
    
}
if (allTasks.Count > 0)
{
    Console.WriteLine("All the tasks are successfully added and organized.");
    Console.Write("Choose the option from the below menu:\n\t1. To list all the tasks.\n\t2. To list out the prioritized tasks.\n> ");
    int menuInput = Convert.ToInt32(Console.ReadLine());
    if (menuInput == 1)
    {
        if (allTasks.Count > 0)
        {
            Console.WriteLine("**************These are all the tasks**************");
            foreach (var task in allTasks)
            {
                Console.WriteLine("\t" + task.ToString());
            }

            Console.WriteLine("****************************");
            Console.WriteLine();
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("[!] No tasks to display.");
        }
    }
    else
    {
        if (doNow.Count > 0)
        {
            Console.WriteLine("**************Do these now**************");
            foreach (var task in doNow)
            {
                Console.WriteLine("\t" + task.ToString());
            }
            Console.WriteLine("****************************");
            Console.WriteLine();
            Console.WriteLine();
        }

        if (scheduleNow.Count > 0)
        {
            Console.WriteLine("**************Schedule these**************");
            foreach (var task in scheduleNow)
            {
                Console.WriteLine("\t" + task.ToString());
            }
            Console.WriteLine("****************************");
            Console.WriteLine();
            Console.WriteLine();
        }

        if (assignNow.Count > 0)
        {
            Console.WriteLine("**************Assign these**************");
            foreach (var task in assignNow)
            {
                Console.WriteLine("\t" + task.ToString());
            }
            Console.WriteLine("****************************");
            Console.WriteLine();
            Console.WriteLine();
        }

        if (delNow.Count > 0)
        {
            Console.WriteLine("**************Delete these**************");
            foreach (var task in delNow)
            {
                Console.WriteLine("\t" + task.ToString());
            }
            Console.WriteLine("****************************");
        }

    }
}
else
{
    Console.WriteLine("[!] No tasks are added.");
}

