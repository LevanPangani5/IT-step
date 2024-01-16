using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_step.Home_Works
{
    internal class HW2
    {
       public static void Sort()
        {

            int[] arr = new int[1000];

            Random rand = new();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-1000, 1000);
            }

            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("Biggest = " + arr[^1] + " Smallest = " + arr[0]);
        }


       public static void MySort()
        {
            int[] arr = new int[10];

            Random rand = new();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-1000, 1000);
            }

        
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }

                }
            }
            int[] desend = new int[arr.Length];
            arr.CopyTo(desend, 0);
            Array.Reverse(desend);
            for (int i = 0; i < desend.Length; i++)
            {
                Console.WriteLine(desend[i]);
            }

            Console.WriteLine("Biggest = " + desend[0] + " Smallest = " + arr[0]);
        }
    }
}
