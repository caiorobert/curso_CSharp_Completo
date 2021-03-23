using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n]; //criação de um vetor double de n posições

            for (int i = 0; i < n; i++)
            {
                //executa loop pergutando n vezes a entrada de dados, e armazenando nas posições do vetor
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                //faz a soma de todos os valores do vetor, pois percorre cada uma de suas posições
                sum += vect[i];
            }

            double avg = sum / n;

            //Resultado da média dos valores do vetor.
            Console.WriteLine($"AVARAGE HEIGHT = {avg.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
