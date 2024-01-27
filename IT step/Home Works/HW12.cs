using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_step.Home_Works
{
    internal class HW12
    {
        static void dispalyCalcResult(double x, double y, char action, double result)
        {
            Console.WriteLine($"{x} {action} {y}= {result}");
        }

        static void add(double x, double y, DisplayDelegate del)
        {
            double result = x + y;
            del(x, y, '+', result);

        }

        static void multiplay(double x, double y, DisplayDelegate del)
        {
            double result = x * y;
            del(x, y, '*', result);
        }

        static void devide(double x, double y, DisplayDelegate del)
        {
            double result = x / y;
            del(x, y, '/', result);
        }

        static void subtract(double x, double y, DisplayDelegate del)
        {
            double result = x - y;
            del(x, y, '-', result);
        }

        static void power(double x, double y, DisplayDelegate del)
        {
            double result = Math.Pow(x, y);
            del(x, y, '^', result);
        }

        public delegate void DisplayDelegate(double x, double y, char action, double result);

        public delegate void CalculatorDelegate(double x, double y, DisplayDelegate del);

        //Class Work
        public class MyCalculator
        {
            public void Add(double x, double y, DisplayDelegate del)
            {
                double result = x + y;
                del(x, y, '+', result);

            }
            public void Subtract(double x, double y, DisplayDelegate del)
            {
                double result = x - y;
                del(x, y, '-', result);
            }
            public void Multiplay(double x, double y, DisplayDelegate del)
            {
                double result = x * y;
                del(x, y, '*', result);
            }
            public void Devide(double x, double y, DisplayDelegate del)
            {
                double result = x / y;
                del(x, y, '/', result);
            }
        }
    }
}
