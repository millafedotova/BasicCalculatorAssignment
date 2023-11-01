using System;
using System.ComponentModel;
using System.Runtime.ExceptionServices;

namespace BasicCalculatorAssignment
{
    internal class Program
    {
        // The goal of this assignment is to learn how to create and use methods in our code
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("-----------------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");



                // Task 1. Read choice input and assing it to new int variable
                // Task 2. Check if user selected choice 5. If so then exit the loop
                Console.Write("Choose an operation: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                {
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    return;
                }

                // Task 3. Get the first number and assing it to new double variable

                Console.Write("Enter first number: ");
                double first_num = Convert.ToDouble(Console.ReadLine());

                // Task 4. Get the second number and assing it to new double variable

                Console.Write("Enter second number: ");
                double second_num = Convert.ToDouble(Console.ReadLine());


                // Task 5. Create double variable for default result value and assign it to be 0

                double result = 0;


                // Task 6. Handle choices using switch statement
                // Task 6.1 For each case create new function/method an call it inside the case
                //          - Case 1: Add 
                //          - Case 2: Subtract
                //          - Case 3: Multiply
                //          - Case 4: Divide, Note remeber to handle 0
                // Note: Think what the default choice should be
                // Note: Declare each case function/method outside Main method
                //       There is comment below where you can place your methods


                // Task 7. Print out the result
                switch (choice)
                {
                    case 1:
                        result = Add(first_num, second_num);
                        break;
                    case 2:
                        result = Subtract(first_num, second_num);
                        break;
                    case 3:
                        result = Multiply(first_num, second_num);
                        break;
                    case 4:
                        if (second_num != 0)
                        {
                            result = Divide(first_num, second_num);
                        }
                        else
                        {
                            Console.WriteLine("error: you cant divide by zero");
                        }
                        break;
                    default:
                        Console.WriteLine("invalid choice. select an option fron 1 to 5");
                        break;
                }

                Console.WriteLine("result: " + result);
            }

            // Declare your methods/functions here
            static double Add(double a, double b)
            {
                return a + b;
            }

            static double Subtract(double a, double b)
            {
                return a - b;
            }

            static double Multiply(double a, double b)
            {
                return a * b;
            }

            static double Divide(double a, double b)
            {
                return a / b;
            }
        }
    }
}