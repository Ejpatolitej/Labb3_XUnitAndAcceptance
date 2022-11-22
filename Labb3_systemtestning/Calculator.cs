using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_XUnitAndAcceptance
{
    public class Calculator
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int result { get; set; }
        public List<string> calculations { get; set; }


        public void userMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose calculation: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Division");
            Console.WriteLine("4. Multiplication");
            Console.WriteLine("5. Print calculations");
            Console.WriteLine("6. Exit");
           

            try
            {
                int userChoice = Int32.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        addition(num1, num2);
                        break;
                    case 2:
                        subtraction(num1, num2);
                        break;
                    case 3:
                        division(num1, num2);
                        break;
                    case 4:
                        multiplication(num1, num2);
                        break;
                    case 5:
                        printResult();
                        break;
                    case 6:
                        Console.WriteLine("Goodbye!");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Invalid choice, try again!");
                        Console.ReadKey();
                        userMenu();
                        break;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid choice, try again!");
                Console.ReadKey();
                userMenu();
            }
        }

        public int firstInput()
        {
            try
            {
                //Comment out for testing!
                //num1 = 1;
                Console.WriteLine("Enter your first number: ");
                num1 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid choice, try again!");
                Console.ReadKey();
                firstInput();
            }
            return num1;
        }

        public int secondInput()
        {
            try
            {
                Console.WriteLine("Enter your second number: ");
                num2 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid choice, try again!");
                Console.ReadKey();
                firstInput();
            }
            return num2;
        }



        public int addition(int num1, int num2)
        {
            firstInput();
            secondInput();
            result = num1 + num2;
            string calc = "Calculation: " + num1.ToString() + " + " + num2.ToString() + " = " + result.ToString();
            calculations.Add(calc);
            userMenu();
            return result;
        }

        public int subtraction(int num1, int num2)
        {
            firstInput();
            secondInput();
            result = num1 - num2;
            string calc = "Calculation: " + num1.ToString() + " - " + num2.ToString() + " = " + result.ToString();
            calculations.Add(calc);
            userMenu();
            return result;
        }

        public int division(int num1, int num2)
        {
            firstInput();
            secondInput();
            if (num1 == 0 || num2 == 0)
            {
                Console.WriteLine("YOU DIVIDED BY ZERO?! YOU FOOL!!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            int result = num1 / num2;
            string calc = "Calculation: " + num1.ToString() + " / " + num2.ToString() + " = " + result.ToString();
            calculations.Add(calc);
            userMenu();
            return result;
        }
        public int multiplication(int num1, int num2)
        {
            firstInput();
            secondInput();
            result = num1 * num2;
            string calc = "Calculation: " + num1.ToString() + " * " + num2.ToString() + " = " + result.ToString();
            calculations.Add(calc);
            userMenu();
            return result;
        }

        public void printResult()
        {
            foreach (var calculation in calculations)
            {
                Console.WriteLine(calculation);
            }
            Console.ReadKey();
            userMenu(); 
        }
    }
}
