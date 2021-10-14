using System;
namespace Kalkylator
{
    class Menu
    {
            public static void Calculate()

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
                        sum = Calculations.Add(num1, num2);
                        break;

                    case 2:
                        sum = Calculations.Subtract(num1, num2);
                        break;

                    case 3:
                        sum = Calculations.Multiply(num1, num2);
                        break;

                    case 4:
                        sum = Calculations.Divide(num1, num2);
                        break;


                    default:
                        Console.WriteLine("Wrong input, try again..");
                        break;
                }

                Console.WriteLine("The result is " + sum);

            }
        }
    }

