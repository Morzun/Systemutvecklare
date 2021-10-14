using System;
using System.Collections.Generic;


namespace Kalkylator
{
    class Program
    {

        public static List<string> calcList = new List<string>();

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
                        Menu.Calculate();
                        break;

                    case 2:
                        Calculations.CloseProgram();
                        break;

                    case 3:
                        Calculations.PrintCalc();
                        break;

                    default:
                        Console.WriteLine("That was not a valid input, please try again...");
                        break;

                }

            } while (start != 0);
           
        }
    }
}
