using System;


namespace Kalkylator
{
    class Menu
    {
        public static void Calculate()

        {
            int menu = 0;
            double num1;
            double num2;
            double sum = 0;

            do
            {
                bool invalidInput = false;
                do
                {
                    Console.WriteLine("Ok! Let's do this...");
                    Console.WriteLine("Press 1 for Addition");
                    Console.WriteLine("Press 2 for Subtraction");
                    Console.WriteLine("Press 3 for Multiplication");
                    Console.WriteLine("Press 4 for Division");


                    try
                    {
                        menu = int.Parse(Console.ReadLine());
                        invalidInput = false;
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input, try again...");
                        invalidInput = true;
                    }


                } while (invalidInput);

                Console.WriteLine("Please enter first input:");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter second input:");
                num2 = Convert.ToDouble(Console.ReadLine());
                

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

            } while (menu != 0);



        }
    }
}

