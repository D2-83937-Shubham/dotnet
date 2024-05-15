﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Hello Shubham, welcome to my calculator");

                int i, j;
                Console.WriteLine("Enter the value for i:");
                i = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the value for j:");
                j = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the choice:");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtraction");
                Console.WriteLine("3: Multiplication");
                Console.WriteLine("4: Division");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    case 1:
                        int addition = i + j;
                        Console.WriteLine("Addition: " + addition);
                        break;
                    case 2:
                        int subtraction = i - j;
                        Console.WriteLine("Subtraction: " + subtraction);
                        break;
                    case 3:
                        int multiplication = i * j;
                        Console.WriteLine("Multiplication: " + multiplication);
                        break;
                    case 4:
                        if (j != 0)
                        {
                            int division = i / j;
                            Console.WriteLine("Division: " + division);
                        }
                        else
                        {
                            Console.WriteLine("Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }

                Console.WriteLine("Do you want to perform another operation? (Enter 0 to exit, any other number to continue):");
                choice = Convert.ToInt32(Console.ReadLine());

            } while (choice != 0);

            Console.WriteLine("Thank you for using the calculator. Goodbye!");
        }
    

    }
}
