using System;
using System.Collections.Generic;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source.
            int[] numbers = new int[] { 2, 3, 4, 5 }; //vetor (minha fonte de dados, podia ser list, um banco, tanto faz

            // Define the query expression.
            //pegar todo numero par e multiplicar por 10, salvando numa nova coleção
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0) //o where filtra o predicado que eu passei, aqui falo que quero numeros pares
                .Select(x => 10 * x); //com o select, eu informo que meu resultado, quero multiplicar por 10
            
            // Execute the query.
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}