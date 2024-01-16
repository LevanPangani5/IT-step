using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_step.Class_Works
{
    internal class CW4
    {
       public static string Encrypt(string text, int index)
        {
            char[] chars = text.ToCharArray();
            int temp = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                temp = (int)chars[i] + index;
                if ((chars[i] >= 'A' && temp <= 'Z') || (chars[i] >= 'a' && temp <= 'z'))
                {
                    chars[i] = (char)temp;
                }
            }
            Console.WriteLine("Before: " + text);
            string result = new string(chars);
            Console.WriteLine("After: " + result);
            return result;
        }


        public static string Decrypt(string text, int index)
        {
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(chars[i] - index);
            }

            Console.WriteLine("Before: " + text);
            string result = new string(chars);
            Console.WriteLine("After: " + result);
            return result;
        }
    }
}
