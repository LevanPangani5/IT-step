using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_step.Home_Works
{
    internal class HW16
    {
        //generates Random words with each word length of 3
        static List<string> RandomWords()
        {
            List<string> words = new();
            Random rand = new();
            char[] word = new char[3];
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    word[j] = (char)rand.Next('a', 'z');
                }
                words.Add(string.Join("", word));
                Array.Clear(word);
            }

            return words;
        }
        // generates random numbers
        static List<int> RandomNumbers()
        {
            List<int> numbers = new();
            Random rand = new();

            for (int i = 0; i < 1000; i++)
            {
                numbers.Add(rand.Next(100, 10000));
            }
            return numbers;
        }
        //returns distinct values from Ienumarable
        static IEnumerable<T> Unique<T>(IEnumerable<T> data)
        {
            return data.Distinct();
        }
        //unions to Ienumerables in ArrayList
        static ArrayList Union<T, J>(IEnumerable<T> dataSet, IEnumerable<J> dataSet2)
        {
            ArrayList union = new();
            foreach (var number in dataSet)
            {
                union.Add(number);
            }

            foreach (var word in dataSet2)
            {
                union.Add(word);
            }
            return union;
        }
    }
}
