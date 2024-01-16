using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_step.Home_Works
{
    internal class HW1
    {
        //task1
        public static void PercentCalculator()
        {
            float num = 0;
            float perc = 0;
            float result;
            bool isPerc = false;
            bool isNum = false;
            Console.WriteLine("Calculates given Percent of given Number");
            while (true)
            {
                while (!isPerc && !isNum)
                {
                    Console.WriteLine("Enter a Number: ");
                    isNum = float.TryParse(Console.ReadLine(), out num);
                    if (!isNum)
                    {
                        Console.WriteLine("Enter a valid argument \n\n\n");
                        continue;
                    }
                    Console.WriteLine("Enter Percent");
                    isPerc = float.TryParse(Console.ReadLine(), out perc);
                    if (!isPerc)
                    {
                        Console.WriteLine("Enter a valid arguments \n\n\n");
                        continue;
                    }
                    result = num * perc / 100;
                    Console.WriteLine(num + " % " + perc + " = " + result + "\n");

                    Console.WriteLine("Write CTRL + C to exit \n\n\n");
                    isPerc = false;
                    isNum = false;
                }
            }

        }

        //task2
        public static void switchPlaces()
        {
            string num = "";
            int indx1;
            int indx2;
            bool isNum = false;
            bool isIndex1 = false;
            bool isIndex2 = false;
            char temp;
            Console.WriteLine("This Function will let you to swap digits inside a 6 digit long number");
            while (true)
            {
                while (num.Length < 6 || !isIndex1 || isIndex2 || isNum)
                {
                    Console.WriteLine("Enter a six digit intiger: ");
                    num = Console.ReadLine();
                    isNum = int.TryParse(num, out _);
                    if (!isNum || num.Length < 6)
                    {
                        Console.WriteLine("Enter a valid argumentbetween\n\n\n");
                        continue;
                    }
                    Console.WriteLine("Ent 1st index between 1 and 6");
                    isIndex1 = int.TryParse(Console.ReadLine(), out indx1);
                    if (!isIndex1 || indx1 > 6 || indx1 < 1)
                    {
                        Console.WriteLine("Enter a valid argument \n\n\n");
                        continue;
                    }
                    Console.WriteLine("Ent 2st index between 1 and 6");
                    isIndex2 = int.TryParse(Console.ReadLine(), out indx2);
                    if (!isIndex2 || indx2 > 6 || indx2 < 1)
                    {
                        Console.WriteLine("Enter a valid argument \n\n\n");
                        continue;
                    }

                    temp = num[indx1 - 1];
                    num = num.Remove(indx1 - 1, 1).Insert(indx1 - 1, num[indx2 - 1].ToString());
                    num = num.Remove(indx2 - 1, 1).Insert(indx2 - 1, temp.ToString());

                    Console.WriteLine(num);

                    Console.WriteLine("Write CTRL + C to exit \n\n\n");
                    num = "";
                    isNum = false;
                    isIndex1 = false;
                    isIndex2 = false;
                }
            }
        }


       public  static void temperatureConverter()
        {
            float temperature;
            bool isNum = false;
            char? scale = null;
            Console.WriteLine("Convert Feranhite to Celcius and vise versa\n");
            while (true)
            {
                while (!isNum || scale != null)
                {
                    Console.WriteLine("Enter number: ");
                    isNum = float.TryParse(Console.ReadLine(), out temperature);
                    if (!isNum)
                    {
                        Console.WriteLine("Enter a valid Number \n\n");
                        continue;
                    }
                    Console.WriteLine("Choose in which format you want data to be foramtted: \n " +
                        "c or C for Celcius and f or F for fahrenheit \n example: " +
                        "if you choose c it will be converted to f");
                    scale = Console.ReadLine().ToUpper()[0];
                    if (scale != 'F' && scale != 'C')
                    {
                        Console.WriteLine("Enter a valid argument \n\n");
                        continue;
                    }

                    switch (scale)
                    {
                        case 'F':
                            Console.WriteLine(temperature + "C  = " + temperature * 9 / 5 + 32 + " F");
                            break;
                        default:
                            Console.WriteLine(temperature + "F  = " + (temperature - 32) * 5 / 9 + " C");
                            break;
                    }
                    Console.WriteLine("Write CTRL + C to exit \n\n\n");
                    isNum = false;
                    scale = null;
                }
            }

        }


    }
}
