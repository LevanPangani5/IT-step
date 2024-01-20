using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_step.Home_Works
{
    internal class HW9
    {
        class Calculator
        {
            //enm-დან დინამიურად ქმნის ოპერაციების ლისტს
            private List<char> GetMathOperations()
            {
                OperationSymbols[] enumValues = (OperationSymbols[])Enum.GetValues(typeof(OperationSymbols));
                List<char> MathOperation = new();

                foreach (var value in enumValues)
                {
                    MathOperation.Add((char)value);
                }

                return MathOperation;
            }
            //ფუნქცია რიცხვითი მონაცემების დასამუშავებლად 
            private double TryParseDouble(string data)
            {
                bool result = double.TryParse(data, out double value);
                if (result)
                {
                    return value;
                }
                else
                {
                    throw new Exception("Not a valid type value");
                }
            }
            // კალკულატორის ოპერაციების ფუნქციონალი
            private double MakeOperation(double argA, double argB, char operation)
            {
                var result = operation switch
                {
                    '+' => argA + argB,
                    '-' => argA - argB,
                    '*' => argA * argB,
                    _ => argA / argB,
                };
                return result;
            }
            // უშვალო კალკულატორის ფუნქცია
            public void RunCalculator()
            {
                var mathOperations = GetMathOperations();
                double? argA = null;
                double? argB = null;
                char? operation = null;
                while (true)
                {
                    Console.WriteLine("\n\n");
                    try
                    {
                        Console.WriteLine("Enter the first argument: ");
                        argA = TryParseDouble(Console.ReadLine()!);
                        Console.WriteLine("Enter the Second argument: ");
                        argB = TryParseDouble(Console.ReadLine()!);
                        Console.WriteLine($"Enter one from this math operations: {string.Join(", ", mathOperations)}");
                        operation = Console.ReadLine()![0];
                        if (mathOperations.Contains((char)operation))
                        {
                            if (argB == 0 && operation == '/')
                            {
                                throw new Exception("Can't devide by zero");
                            }
                            else
                            {
                                Console.WriteLine($"{argA} {operation} {argB} = {MakeOperation((double)argA, (double)argB, (char)operation)}");
                                argA = null;
                                argB = null;
                                operation = null;
                                Console.WriteLine("if you want to stop calculator press tab key\nelse tap eny key for starting new opration on calculator");
                                ConsoleKeyInfo keyInfo = Console.ReadKey();
                                if (keyInfo.Key == ConsoleKey.Tab)
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            throw new Exception("Not a valid operation symbol");
                        }
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                }
            }

            private enum OperationSymbols
            {
                add = '+',
                subtract = '-',
                devide = '/',
                multiply = '*',
            }
        }
    }
}
