// using System.ComponentModel;
// using System.IO.Pipelines;
// using System.Reflection.Metadata.Ecma335;

namespace Overload;

class Program
{

    public class Calculator
    {

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public bool IsANumber(string value)
        {
            //check if string can be converted to number                
            if (int.TryParse(value, out int number))
                return true;
            else
                return false;
        }


    }
    static void Main(string[] args)
    {
        string? number1 = "";
        string? number2 = "";
        string? number3 = "";
        Calculator calc = new Calculator();
        bool programRunning = true;
        const int dontPanic = 42;
        const string dontPanicMessage = @"
      ____                     __   __        ____                               
     /\  _`\                  /\ \ /\ \__    /\  _`\                __           
     \ \ \/\ \    ___     ___ \ \/ \ \ ,_\   \ \ \L\ \ __      ___ /\_\    ___   
      \ \ \ \ \  / __`\ /' _ `\\/   \ \ \/    \ \ ,__/'__`\  /' _ `\/\ \  /'___\ 
       \ \ \_\ \/\ \L\ \/\ \/\ \     \ \ \_    \ \ \/\ \L\.\_/\ \/\ \ \ \/\ \__/ 
        \ \____/\ \____/\ \_\ \_\     \ \__\    \ \_\ \__/.\_\ \_\ \_\ \_\ \____\
         \/___/  \/___/  \/_/\/_/      \/__/     \/_/\/__/\/_/\/_/\/_/\/_/\/____/
                                                                                 ";


        while (programRunning)
        {

            Console.WriteLine("How many numbers would you like to add?");
            Console.WriteLine("1. Two numbers");
            Console.WriteLine("2. Three numbers");
            Console.WriteLine("3. Exit");
            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("First number:");
                    number1 = Console.ReadLine();
                    Console.WriteLine("Second number:");
                    number2 = Console.ReadLine();

                    if (calc.IsANumber(number1) && calc.IsANumber(number2))
                    {
                        //convert strings to int after verifying
                        int num1 = Convert.ToInt32(number1);
                        int num2 = Convert.ToInt32(number2);

                        if (calc.Add(num1, num2) == dontPanic)
                            Console.WriteLine(dontPanicMessage);
                        else
                            Console.WriteLine($"The sum is: {calc.Add(num1, num2)}\n");
                    }
                    else
                    {
                        Console.WriteLine($"Please type in numbers.\n");
                    }
                    break;
                case "2":
                    Console.WriteLine("First number:");
                    number1 = Console.ReadLine();
                    Console.WriteLine("Second number:");
                    number2 = Console.ReadLine();
                    Console.WriteLine("Third number:");
                    number3 = Console.ReadLine();
                    if (calc.IsANumber(number1) && calc.IsANumber(number2) && calc.IsANumber(number3))
                    {
                        //convert strings to int after verifying
                        int num1 = Convert.ToInt32(number1);
                        int num2 = Convert.ToInt32(number2);
                        int num3 = Convert.ToInt32(number3);

                        if (calc.Add(num1, num2, num3) == dontPanic)
                            Console.WriteLine(dontPanicMessage);
                        else
                            Console.WriteLine($"The sum is: {calc.Add(num1, num2, num3)}\n");

                    }
                    else
                    {
                        Console.WriteLine($"Please type in numbers.\n");
                    }
                    break;
                case "3":
                    programRunning = false;
                    break;
                default:
                    Console.WriteLine("Please choose '1' or '2'.\n");
                    break;
            }
        }
    }
}
