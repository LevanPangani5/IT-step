using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IT_step.Home_Works
{
    internal class HW14
    {
        static void Login()
        {
            string password = passwordValidation();
            Console.Write("\n\n");

            //mail validation
            string email;       //at least one lowercase uppercase number special emil
            Regex EmailRegex = new(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&#])[A-Za-z\d@$!%*?&]{8,}@([\w-]{2,}\.)+[\w-]{2,4}$");
            do
            {
                Console.WriteLine("!! warning !!");

                Console.WriteLine("Email should contain at least one lower one Upper one number and one special character \n" +
                "should be at least 12 characters long");

                Console.WriteLine("Enter Email: ");

                email = Console.ReadLine()!;
                if (!EmailRegex.IsMatch(email))
                {
                    Console.WriteLine("\nInvalid Email try again ... \n\n");
                }
                else
                {
                    break;
                }
            } while (true);

            Console.WriteLine($"\npassword: {password} and email:{email} are valid");
        }


        //password generation & validation
        static string passwordValidation()
        {
            StringBuilder password = new();
            ConsoleKeyInfo? info;
            Regex PasswordRegex = new(@"(^[a-zA-Z0-9.!_%+-/]).{7,}$");

            do
            {
                Console.WriteLine("!!Warning!!");
                Console.WriteLine("Password must be at least 8 characters long containing only letters, numbers and special characters");
                Console.WriteLine("Enter Password: ");
                do
                {
                    info = Console.ReadKey(true);
                    if (info?.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                    else if (info?.Key == ConsoleKey.Backspace)
                    {
                        int pos = Console.CursorLeft;
                        if (password.Length > 0)
                        {
                            password.Length--;
                            Console.SetCursorPosition(pos - 1, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        }
                        else
                        {
                            Console.Write(" ");
                            Console.SetCursorPosition(pos, Console.CursorTop);
                        }
                    }
                    else
                    {
                        password.Append(info?.KeyChar);
                        Console.Write("*");
                    }
                } while (true);

                if (!PasswordRegex.IsMatch(password.ToString()))
                {
                    Console.WriteLine("\nInvalid password try again ... \n\n");
                    password.Clear();
                }
                else
                {
                    break;
                }
            } while (true);

            return password.ToString();
        }


        delegate void Mydelegate(string message);
    }
}
