using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkylator
{
    class Calculations
    {
        public static List<string> calcList = new List<string>();

        public static double Add(double num1, double num2)
        {
            char testOp = '+';
            double sum = (num1 + num2);
            AddList(num1, num2, testOp, sum);
            return sum;
        }

        public static double Subtract(double num1, double num2)
        {
            char testOp = '-';
            double sum = (num1 - num2);
            AddList(num1, num2, testOp, sum);
            return sum;
        }

        public static double Multiply(double num1, double num2)
        {
            char testOp = '*';
            double sum = (num1 * num2);
            AddList(num1, num2, testOp, sum);
            return sum;
        }

        public static double Divide(double num1, double num2)
        {
            char testOp = '/';
            double sum = (num1 / num2);
            AddList(num1, num2, testOp, sum);
            return sum;
        }

        
        public static void AddList(double num1, double num2, char testOp, double sum)
        {

            string calc1 = num1.ToString();
            string calc2 = testOp.ToString();
            string calc3 = num2.ToString();
            string calc4 = sum.ToString();            

            string calc = calc1 + " " + calc2 + " " + calc3 + " " + " = " + calc4;           
            calcList.Add(calc);
        }

        public static void PrintCalc()
        {
            for (int i = 0; i < calcList.Count; i++)
            {
                Console.WriteLine(calcList[i]);
            }
        }

        public static void CloseProgram()
        {
            System.Environment.Exit(0);
        }
    }
}
