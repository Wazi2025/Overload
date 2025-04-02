// using System.ComponentModel;
// using System.IO.Pipelines;
// using System.Reflection.Metadata.Ecma335;

namespace Overload;

class Program
{

    public class Calculator
    {

        //create method's with the same name but a different amount or type of parameters == method overload
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

        //instantiate our calc object
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

        //the while loop will continue until the user chooses option 3 (exit) since the loop depends on
        //programRunning being true.
        while (programRunning)
        {
            Console.WriteLine("How many numbers would you like to add?");
            Console.WriteLine("1. Two numbers");
            Console.WriteLine("2. Three numbers");
            Console.WriteLine("3. Exit");
            string? input = Console.ReadLine();

            //choose case based on the main menu choices (1,2,3)
            switch (input)
            {
                case "1":
                    Console.WriteLine("First number:");
                    number1 = Console.ReadLine();
                    Console.WriteLine("Second number:");
                    number2 = Console.ReadLine();

                    //check if entered numbers (in string format) can be parsed into int
                    if (calc.IsANumber(number1) && calc.IsANumber(number2))
                    {
                        //convert strings to int after verifying
                        int num1 = Convert.ToInt32(number1);
                        int num2 = Convert.ToInt32(number2);

                        //display a special message if the sum is the answer to Life, the Universe & Everything :-)
                        if (calc.Add(num1, num2) == dontPanic)
                            Console.WriteLine(dontPanicMessage);
                        else
                            //display the sum
                            Console.WriteLine($"The sum is: {calc.Add(num1, num2)}\n");
                    }
                    else
                    {
                        //inform user that he must type in numbers                        
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
                    //if user chooses 3, set programRunning to false ensuring that the while loop
                    //will exit
                    programRunning = false;
                    break;
                default:
                    //inform user that he must choose 1,2 or 3                    
                    Console.WriteLine("Please choose '1','2' or '3'.\n");
                    break;
            }
        }
    }
}
