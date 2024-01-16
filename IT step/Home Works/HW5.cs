using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_step.Home_Works
{
    internal class HW5
    {
        public static void Converter()
        {

            Dictionary<int, string> options = new();
            options.Add(1, "Decimal to Binary");
            options.Add(2, "Binary to Decima");
            int option = 0;
            string data = "";
            string result = "";
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Choose convertion option: ");
                    foreach (var opt in options)
                    {
                        Console.WriteLine($"{opt.Key} for : {opt.Value}");
                    }
                    _ = int.TryParse(Console.ReadLine(), out option);
                    Console.WriteLine(option);
                    if (!options.ContainsKey(option))
                    {
                        Console.WriteLine("Enter a Valid Option ID \n\n\n");
                        continue;
                    }
                    Console.WriteLine("Enter Data for Convertion: ");
                    data = Console.ReadLine();
                    switch (option)
                    {
                        case 1:
                            {
                                try
                                {
                                    if (int.TryParse(data, out int intiger))
                                    {
                                        result = Convert.ToString(intiger, 2);
                                        break;
                                    }
                                }
                                catch (Exception exp)
                                {
                                    Console.WriteLine("Make sure data is valid and in scope of intiger");
                                }

                                Console.WriteLine("Enter a valid Data");
                                break;
                            }
                        default:
                            {
                                result = Convert.ToInt32(data, 2).ToString();
                                break;
                            }
                    }

                    Console.WriteLine($"From {data} to {result}");
                }
            }
        }


        public static string Encrypt(string text, int index)
        {
            char[] chars = text.ToCharArray();
            int temp = 0;
            for (int i = 0; i < chars.Length; i++)
            {

                if ((chars[i] >= 'A' && temp <= 'Z') || (chars[i] >= 'a' && temp <= 'z'))
                {
                    temp = (int)chars[i] + index;
                    chars[i] = (char)temp;
                }
            }


            Console.WriteLine("Before: " + text);
            string result = new(chars);
            Console.WriteLine("After: " + result);
            return result;
        }




        static string decrypt(string text, int index)
        {
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(chars[i] - index);
            }

            Console.WriteLine("Before: " + text);
            string result = new(chars);
            Console.WriteLine("After: " + result);
            return result;
        }
    }
}
