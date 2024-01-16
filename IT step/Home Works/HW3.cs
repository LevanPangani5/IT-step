using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_step.Home_Works
{
    internal class HW3
    {
        public static void EvenOddMatrixCounter()
        {
            int[,] mat1 = new int[50, 50];
            int odds = 0;
            int even = 0;
            Random rand = new();

            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    mat1[i, j] = rand.Next(1000);
                    if (mat1[i, j] % 2 == 0)
                    {
                        even += mat1[i, j];
                    }
                    else
                    {
                        odds += mat1[i, j];
                    }
                }
            }
        }

        public static void SentencesToUpper()
        {
            Console.WriteLine("Entr atleast 2 senteces:");
            string input = Console.ReadLine();

            char[] conditions = { '.', ',' };
            string[] sentences = Console.ReadLine().Split(conditions);

            foreach (string sentence in sentences)
            {
                Console.WriteLine(sentence);
            }
        }


        public static void MatrixMultipication()
        {
            int[,] mat1 = new int[10, 10];
            int[,] mat2 = new int[mat1.GetLength(0), mat1.GetLength(1)];
            int[,] result = new int[mat1.GetLength(0), mat1.GetLength(1)];
            Random rand = new();

            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    mat1[i, j] = rand.Next(-1000, 1000);
                }
            }

            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    mat2[i, j] = rand.Next(-100, 100);
                }
            }

            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    result[i, j] = mat1[i, j] * mat2[i, j];
                }
            }


            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    Console.Write(mat1[i, j] + "  ");
                }
                Console.Write("\n");
            }

            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    Console.Write(mat2[i, j] + "  ");
                }
                Console.Write("\n");
            }

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + "  ");
                }
                Console.Write("\n");
            }
        }
    }
}
