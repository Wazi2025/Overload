using System.ComponentModel;
using System.IO.Pipelines;
using System.Reflection.Metadata.Ecma335;

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
    }
    static void Main(string[] args)
    {
        string? number1 = "";
        string? number2 = "";
        string? number3 = "";
        Calculator calc = new Calculator();
        bool programRunning = true;

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
                    //Console.WriteLine(calc.Add(int.Parse(number1), int.Parse(number1)));
                    Console.WriteLine($"The sum is: {calc.Add(int.Parse(number1), int.Parse(number1))}");
                    break;
                case "2":
                    Console.WriteLine("First number:");
                    number1 = Console.ReadLine();
                    Console.WriteLine("Second number:");
                    number2 = Console.ReadLine();
                    Console.WriteLine("Third number:");
                    number3 = Console.ReadLine();
                    Console.WriteLine($"The sum is: {calc.Add(int.Parse(number1), int.Parse(number1), int.Parse(number1))}");
                    break;
                case "3":
                    programRunning = false;
                    break;
                default:
                    Console.WriteLine("Please choose '1' or '2'.");
                    break;
            }
        }
        //Console.WriteLine(calc.Add(int.Parse(number1), int.Parse(number1)));

        // if (!int.TryParse(number1, out int number))
        //     Console.WriteLine("Not a number!");

    }
}
