using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_step.Class_Works
{
    internal class CW3
    {
        public static void Matrix()
        {
            int[,] mat1 = new int[5, 5];
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

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + "  ");
                }
                Console.Write("\n");
            }

        }

        public static void Jagged()
        {
            int[][] mat1 = new int[5][];
            int[][] mat2 = new int[mat1.GetLength(0)][];
            int[][] result = new int[mat1.GetLength(0)][];
            Random rand = new();
            
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                mat1[i] = new int[rand.Next(2, 6)];

                for (int j = 0; j < mat1[i].Length; j++)
                {
                    mat1[i][j] = rand.Next(-100, 100);
                }
            }

            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                mat2[i] = new int[mat1[i].Length];

                for (int j = 0; j < mat2[i].Length; j++)
                {
                    mat2[i][j] = rand.Next(-100, 100);
                }
            }

            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                result[i] = new int[mat2[i].Length];

                for (int j = 0; j < mat2[i].Length; j++)
                {
                    result[i][j] = mat1[i][j] * mat2[i][j];
                }
            }

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result[i].Length; j++)
                {
                    Console.Write(result[i][j] + "  ");
                }
                Console.Write("\n");
            }

        }
    }
}
