using System;

namespace Kalkylator
{
    class Program
    {
        static void Main(string[] args)
        {

            int start = 0;

            do
            {
                Console.WriteLine("Hello and welcome to this simple calculator...");
                Console.WriteLine("Press 1 to start calculating..");
                Console.WriteLine("Press 2 to close the program..");

                start = Convert.ToInt32(Console.ReadLine());

                switch (start)
                {
                    case 1:
                        Calculate();
                        break;

                    case 2:
                        CloseProgram();
                        break;

                    default:
                        Console.WriteLine("That was not a valid input, please try again...");
                        break;

                }

            } while (start != 0);
            static void Calculate()

            {
                Console.WriteLine("Ok! Let's do this...");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division");

                int menu = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("Please enter first input:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter second input:");
                double num2 = Convert.ToDouble(Console.ReadLine());
                double sum = 0;

                switch (menu)
                {
                    case 1:
                        sum = Add(num1, num2);
                        break;

                    case 2:
                        sum = Subtract(num1, num2);
                        break;

                    case 3:
                        sum = Multiply(num1, num2);
                        break;

                    case 4:
                        sum = Divide(num1, num2);
                        break;

                    default:
                        Console.WriteLine("Wrong input, try again..");
                        break;
                }

                Console.WriteLine("The result is " + sum);                

            }

            static double Add(double num1, double num2)
            {
                double sum = (num1 + num2);
                return sum;
            }

            static double Subtract(double num1, double num2)
            {
                double sum = (num1 - num2);
                return sum;
            }

            static double Multiply(double num1, double num2)
            {
                double sum = (num1 * num2);
                return sum;
            }

            static double Divide(double num1, double num2)
            {
                double sum = (num1 / num2);
                return sum;
            }

            static void CloseProgram()
            {
                System.Environment.Exit(0);
            }
        }
    }
}
