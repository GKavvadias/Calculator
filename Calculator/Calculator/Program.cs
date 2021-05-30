using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("--------C# CALCULATOR--------");
            Console.WriteLine("=============================");
            Console.WriteLine();

            int a, b;
            Console.Write("\nPlease input a positive number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease input another positive number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease choose what do you want to do: ");
            Console.WriteLine("1. ADD");
            Console.WriteLine("2. SUBTRACT");
            Console.WriteLine("3. MULTIPLY");
            Console.WriteLine("4. DIVIDE");
            Console.WriteLine();

            switch (Console.ReadLine())
            {
                case "1": Console.WriteLine($"\n{a} + {b} = " + (a + b)); break;
                case "2": Console.WriteLine($"\n{a} - {b} = " + (a - b)); break;
                case "3": Console.WriteLine($"\n{a} * {b} = " + (a * b)); break;
                case "4": Console.WriteLine($"\n{a} / {b} = " + (a / b)); break;
            }
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();

        }
    }
}
