using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_step.Home_Works
{
    internal class HW6
    {
      public  static void Random(ref int[] array, int i = 0)
        {
            if (i < array.Length)
            {
                Random rand = new();
                array[i] = rand.Next(100);
                i++;
                Random(ref array, i);
            }
            //roca ukan dabrunebas daiwyebs boloshi davbewdavT
            if (i == 1)
                Console.WriteLine("Getting answer technicly this is first way: " + array.Sum());

        }


      
        //რეკურსიულად კრიბავს მასივის მნიშვნელობას
        private static void Sum(ref int[] numbers, ref int number, int i = 0)
        {
            if (i < numbers.Length)
            {
                number += numbers[i];
                i++;
                Sum(ref numbers, ref number, i);
            }
        }

        //აგენერირებს მითითებული სიგრძის შემთხვევით მასივს. out პარამეტრით აბრუნებს მასივის ელემენტების ჯამს
        // თავად ფუნქცია კი აბრუნებს შემთხვევითად გენერირებულ მასივს
        public static int[] RandArrSum(out int result, int length = 5)
        {
            int[] arr = new int[length];
            Random rand = new();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);
            }
            result = 0;
            //იძახებს sum ფუნქციას რომელიც რეკურსიულად აჯამვს მოცემულ მასივს
            Sum(ref arr, ref result);

            foreach (int i in arr)
            {
                Console.Write(i);
                Console.Write(" + ");
            }
            Console.WriteLine($"= {result}");
            return arr;
        }

    }
}
