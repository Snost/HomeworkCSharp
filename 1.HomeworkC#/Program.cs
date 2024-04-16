using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.HomeworkC_
{
    internal class Program
    {
        static void Main()
        {
            //1

            Console.WriteLine("Enter number 1 - 100 -");
            string number = Console.ReadLine();
            int num = int.Parse(number);
            if (num >= 1 && num <= 100)
            {
                if (num % 3 == 0 && num % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (num % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (num % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Error. Enter number 1 - 100!");
            }
            Console.ReadLine();

            //-----------------------------------------------------------

            //2
            Console.WriteLine("Enter number:");
            string numb1 = Console.ReadLine();

            Console.WriteLine("Enter percent:");
            string numb2 = Console.ReadLine();

            double number = double.Parse(numb1);
            double percent = double.Parse(numb2);

            double result = number * (percent / 100);
            Console.WriteLine("Result - " + result);
            Console.ReadLine();
            //------------------------------------------------------------

            //3

            Console.WriteLine("Enter first number:");
            string num1 = Console.ReadLine();

            Console.WriteLine("Enter second number:");
            string num2 = Console.ReadLine();

            Console.WriteLine("Enter third number:");
            string num3 = Console.ReadLine();

            Console.WriteLine("Enter fourth number:");
            string num4 = Console.ReadLine();


            string numb = num1 + num2 + num3 + num4;
            int number = int.Parse(numb);
            Console.WriteLine("Number - " + (number));
            Console.ReadLine();

            //-------------------------------------------------------

            //4


            Console.WriteLine("Enter a six-digit number - ");
            string numbs = Console.ReadLine();

            if (numbs.Length != 6)
            {
                Console.WriteLine("Error! Enter a six-digit number!");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Enter the index of the two positions that need to be changed (separated by a space):");
            string[] positions = Console.ReadLine().Split(' ');

            if (positions.Length != 2)
            {
                Console.WriteLine("Error!");
                Console.ReadLine();
                return;
            }

            int pos1, pos2;
            if (!int.TryParse(positions[0], out pos1) || !int.TryParse(positions[1], out pos2))
            {
                Console.WriteLine("Error");
                Console.ReadLine();
                return;
            }

            if (pos1 < 1 || pos1 > 6 || pos2 < 1 || pos2 > 6)
            {
                Console.WriteLine("Error!");
                Console.ReadLine();
                return;
            }

            string result = "";
            for (int i = 0; i < numbs.Length; i++)
            {
                if (i == pos1 - 1)
                    result += numbs[pos2 - 1];
                else if (i == pos2 - 1)
                    result += numbs[pos1 - 1];
                else
                    result += numbs[i];
            }

            Console.WriteLine("Result - " + result);
            Console.ReadLine();


            //-----------------------------------------------------
            //5

            Console.WriteLine("Enter the date (for example - 22.12.2021):");
            string data = Console.ReadLine();
            string[] parts = data.Split('.');

            if (parts.Length != 3)
            {
                Console.WriteLine("Error!");
                Console.ReadLine();
                return;
            }

            int day, month, year;
            if (!int.TryParse(parts[0], out day) || !int.TryParse(parts[1], out month) || !int.TryParse(parts[2], out year))
            {
                Console.WriteLine("Error!");
                Console.ReadLine();
                return;
            }

            string season;
            if (month >= 3 && month <= 5)
                season = "Spring";
            else if (month >= 6 && month <= 8)
                season = "Summer";
            else if (month >= 9 && month <= 11)
                season = "Autumn";
            else
                season = "Winter";

            DateTime date = new DateTime(year, month, day);
            string dayWeek = date.DayOfWeek.ToString();

            Console.WriteLine("Result - " + season + " " + dayWeek);
            Console.ReadLine();
            //------------------------------------------------------

            //6

            Console.WriteLine("Choose an operation - ");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");

            Console.WriteLine("Enter the temperature -");
            string str = Console.ReadLine();
            double temperature = double.Parse(str);

            string choice = Console.ReadLine();
            double result;
            switch (choice)
            {
                case "1":
                    result = (temperature - 32) * 5 / 9;
                    Console.WriteLine("Temperature in Celsius - " + result);
                    break;
                case "2":
                    result = temperature * 9 / 5 + 32; ;
                    Console.WriteLine("Temperature in Fahrenheit - " + result);
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }

            Console.ReadLine();

            //------------------------------------------------------------------
            //7

            Console.WriteLine("Enter two numbers to define the range:");

            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            int number1, number2;

            try
            {
                number1 = int.Parse(num1);
                number2 = int.Parse(num2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
                Console.ReadLine();
                return;
            }
            int start = Math.Min(number1, number2);
            int end = Math.Max(number1, number2);

             Console.WriteLine("Even numbers in the range from " + start+" to " + end);
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
           

            Console.ReadLine();
        }

        
        
    }
    }
    

    
    

