using System;
using System.Collections.Generic;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat1 = new double[2, 3];
            Console.WriteLine(mat1.Length); //Tamanho da matriz, 2 * 3 = 6
            Console.WriteLine(mat1.Rank); //Quanto é o tamanho da primeira dimensão da matriz, o rank traz a quantidade de linhas
            Console.WriteLine(mat1.GetLength(0)); //o GetLenght pega a dimensão deseja, a 0 linhas
            Console.WriteLine(mat1.GetLength(1));// dimensão 1 é a quantidade de colunas da matriz

            Console.WriteLine("-------------------------------------------");
            
            //Exercicio resolvido
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);
        }
    }
}