// number types and their ranges
/*int min1 = int.MinValue, max1 = int.MaxValue;

short min2 = short.MinValue, max2 = short.MaxValue;

double min3 = double.MinValue, max3 = double.MaxValue;

long min4 = long.MinValue, max4 = long.MaxValue;

decimal min5 = decimal.MinValue, max5 = decimal.MaxValue;

Console.WriteLine($"int : min = {min1} and max = {max1}");
Console.WriteLine($"short : min = {min2} and max = {max2}");
Console.WriteLine($"double : min = {min3} and max = {max3}");
Console.WriteLine($"long : min = {min4} and max = {max4}");
Console.WriteLine($"decimal: min = {min5} and max = {max5}");*/

using System;

namespace SailsSoft
{
    class Program
    {
        public static void fibonacci()
        {
            var fibonacci = new List<int> { 1, 1 };

            while (fibonacci.Count <= 20)
            {
                var lastNum = fibonacci.Last();
                var secondLastNum = fibonacci[fibonacci.Count - 2];
                fibonacci.Add(lastNum + secondLastNum);
                if (lastNum == 6725)
                {
                    Console.WriteLine("while loop ends here as the last num is 6725");
                }
                Console.WriteLine($"last elem is {lastNum} and second last elem is {secondLastNum}");
            }
        }
        public static void Code1()
        {
            /*
             * 1- Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)
             */
            Console.Write("enter a number\n> ");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput >= 1 && userInput <= 10)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }

        public static void Code2()
        {
            Console.Write("enter two numbers\n> ");
            var userInput = Console.ReadLine();
            var res = userInput.Split(" ");

            int[] numbers = Array.ConvertAll(res, int.Parse);

            if (numbers[0] > numbers[1])
            {
                Console.WriteLine(string.Format("max {0}", numbers[0]));
            }
            else
            {
                Console.WriteLine(string.Format("max {0}", numbers[1]));
            }
        }

        public static void Code3()
        {
            Console.Write("enter height > ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("enter width > ");
            int width = int.Parse(Console.ReadLine());

            if(width > height)
            {
                Console.WriteLine("image is landscape");
            }
            else
            {
                Console.WriteLine("image is portrait");
            }
        }

        public static void Code4()
        {
            // asks user speed limit
            Console.Write("please enter speed limit\n> ");
            var speedLmt = int.Parse(Console.ReadLine());

            // if set, asks speed of car
            if (speedLmt >= 0)
            {
                Console.WriteLine("[+] Speed limit successfully set to " + speedLmt + "km/hr");
                Console.Write("please enter speed of the car\n> ");
                var carSpeed = int.Parse(Console.ReadLine());
                // car speed < speed limit = ok | calculate demerit points
                if(carSpeed <= speedLmt)
                {
                    Console.WriteLine("[+] ok");
                }
                else
                {
                    Console.WriteLine("[!] speed limit crossed");
                    var excessSpeed = carSpeed - speedLmt;
                    float demeritPoints = excessSpeed / 5f;
                    Console.WriteLine(string.Format("[!] {0} demerit points", demeritPoints));
                    if (demeritPoints > 12)
                    {
                        Console.WriteLine("[!] license suspended");
                    }
                }
            }

            
            // demerit => 1 demerit point for 5km/hr
            // if 12 points then license suspended
        }

        public static void Loop1()
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count}");
        }

        public static void Loop2()
        {
            bool toAsk = true;
            int count = 0;
            while (toAsk)
            {
                Console.Write("enter a number\n> ");
                var numInp = Console.ReadLine();
                if(numInp.ToLower() == "ok")
                {
                    toAsk = false;
                    break;
                }
                else
                {
                    count += int.Parse(numInp);
                }
            }
            Console.WriteLine($"count is {count}");
        }

        public static void Loop3()
        {
            Console.Write("enter a number\n> ");
            var numInp = int.Parse(Console.ReadLine());

            int fact = 1, num = numInp;

            while (numInp >= 1)
            {
                fact *= numInp;
                numInp--;
            }
            Console.WriteLine($"factorial of {num}! is {fact}");
        }

        public static void secretNumber()
        {
            var random = new Random();
            int secret = random.Next(1, 10);

            int chances = 4;

            Console.WriteLine($"secret num is {secret}");
            while (chances > 0)
            {
                Console.Write("guess the secret number.\n> ");
                var numInp = int.Parse(Console.ReadLine());

                if(numInp == secret)
                {
                    Console.WriteLine("You won");
                    chances = 0;
                }
                else
                {
                    chances--;
                    Console.WriteLine("You lost");
                    Console.WriteLine($"{chances} chances left");
                }
            }
            Console.WriteLine();
        }

        public static void Loop5()
        {

            Console.Write("enter series of numbers:\n> ");
            var numInp = Console.ReadLine();
            
            // splits and converts string array to int array
            var numbers = Array.ConvertAll(numInp.Split(","), int.Parse);
            Console.WriteLine("max elem is {0}", numbers.Max());
        }

        public static void displayInfo()
        {
            bool toAsk = true;
            var names = new List<string>();
            while (toAsk)
            {
                Console.Write("enter name\n> ");
                var name = Console.ReadLine();

                if(!string.IsNullOrEmpty(name) || name != "" || !string.IsNullOrWhiteSpace(name))
                {
                    names.Add(name);
                }
                else
                {
                    toAsk = false;
                }
            }
            if(names.Count == 1)
            {
                Console.WriteLine($"{names[0]} likes your post.");
            }
            else if (names.Count == 2)
            {
                Console.WriteLine($"{names[0]} and {names[1]} likes your post.");
            }
            else if(names.Count > 2)
            {
                Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others likes your post.");
            }
            else
            {
                Console.WriteLine("no likes");
            }
        }

        public static void reverse()
        {
            Console.Write("please enter your name\n> ");
            var inp = Console.ReadLine();
            char[] stringArray = inp.ToCharArray();
            Array.Reverse(stringArray);
            string revStr = new string(stringArray);
            Console.WriteLine(revStr);
        }
        static void Main(string[] args)
        {
            secretNumber();
        }
    }
}