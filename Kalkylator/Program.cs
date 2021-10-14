using System;
using System.Collections.Generic;


namespace Kalkylator
{
    class Program
    {

        static List<string> calcList = new List<string>();
        static void Main(string[] args)
        {


            int start = 0;
            do
            {
                Console.WriteLine("Hello and welcome to this simple calculator...");
                Console.WriteLine("Press 1 to start calculating..");
                Console.WriteLine("Press 2 to close the program..");
                Console.WriteLine("Press 3 to print previous calculations...");


                start = Convert.ToInt32(Console.ReadLine());

                switch (start)
                {
                    case 1:
                        Calculate();
                        break;

                    case 2:
                        CloseProgram();
                        break;

                    case 3:
                        PrintCalc();
                        break;

                    default:
                        Console.WriteLine("That was not a valid input, please try again...");
                        break;

                }

            } while (start != 0);


            void Calculate()

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

            double Add(double num1, double num2)
            {
                char testOp = '+';
                double sum = (num1 + num2);
                AddList(num1, num2, testOp, sum);
                return sum;
            }

            double Subtract(double num1, double num2)
            {
                char testOp = '-';
                double sum = (num1 - num2);
                AddList(num1, num2, testOp, sum);
                return sum;
            }

            double Multiply(double num1, double num2)
            {
                char testOp = '*';
                double sum = (num1 * num2);
                AddList(num1, num2, testOp, sum);
                return sum;
            }

            double Divide(double num1, double num2)
            {
                char testOp = '/';
                double sum = (num1 / num2);
                AddList(num1, num2, testOp, sum);
                return sum;
            }

            void AddList(double num1, double num2, char testOp, double sum)
            {

                string calc1 = num1.ToString();
                string calc2 = testOp.ToString();
                string calc3 = num2.ToString();
                string calc4 = sum.ToString();

                string calc = calc1 + calc2 + calc3 + " = " + calc4;
                calcList.Add(calc);
            }

            static void PrintCalc()
            {
                for (int i = 0; i < calcList.Count; i++)
                {
                    Console.WriteLine(calcList[i]);
                }
            }

            static void CloseProgram()
            {
                System.Environment.Exit(0);
            }
        }
    }
}
