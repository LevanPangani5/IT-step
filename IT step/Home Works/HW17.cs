﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_step.Home_Works
{
    internal class HW17
    {
        static void ReadWrite()
        {
            const string filePath = "C:/me/projects/sweeft/IT step/IT step/File.txt";
            char[] options = { '1', '2' };
            char option;
            ConsoleKeyInfo keyInfo = new();
            //saves users Prsonal ID before offering other functinality
            Console.WriteLine("");
            //offers user ATM funtionality
            do
            {

                Console.WriteLine("Choose coresponding number for desired functinality: ");
                Console.WriteLine("1 - Write in the File");
                Console.WriteLine("2 - Read from the file");

                option = Console.ReadKey(true).KeyChar;
                Console.Write("\n\n");
                if (!options.Contains(option))
                {
                    Console.WriteLine("Invalid option try again");
                    continue;
                }
                switch (option)
                {
                    case '1':
                        {
                            string? text = null;
                            do
                            {
                                Console.WriteLine("Enter text you want to write in the file: ");
                                text = Console.ReadLine();

                            } while (text == null);
                            Write(filePath, text);
                            break;

                        }
                    default:
                        {
                            Reader(filePath);
                            break;
                        }
                }

                Console.Write("\n\nIf you want to colse menu click tab\n click any other key to continue: ");
                keyInfo = Console.ReadKey(true);
                Console.Write("\n");
            } while (keyInfo.Key != ConsoleKey.Tab);
        }
        static void Write(string filePath, string text)
        {
            using (StreamWriter writer = new("C:/me/projects/sweeft/IT step/IT step/File.txt", true))
            {
                writer.WriteLine(text);
            }
        }

        static void Reader(string filePath)
        {
            using (StreamReader reader = new("C:/me/projects/sweeft/IT step/IT step/File.txt"))
            {
                string? line;
                Console.WriteLine("File data: ");
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
