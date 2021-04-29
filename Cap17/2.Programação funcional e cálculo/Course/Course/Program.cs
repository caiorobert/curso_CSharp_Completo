using System;
namespace Course
{
    class Program
    {
        //programação imperativa
        public static int globalValue = 3; //variável com valor global, pode ser usada por qualquer escopo
        static void Main(string[] args)
        {
            int[] vect = new int[] { 3, 4, 5 }; //Instância um vetor
            ChangeOddValues(vect); //Chama a função de mudar os valores ímpares
            Console.WriteLine(string.Join(" ", vect)); //imprime os valores separados por espaços


            //Expressividade / "como" vs. "o quê"
            //Imperativa
            //int sum = 0;
            //            foreach (int x in list)
            //            {
            //                sum += x;
            //            }

            ////Funcional
            //int sum = list.Aggregate(0, (x, y) => x + y);
        }
        public static void ChangeOddValues(int[] numbers) //a função recebe os valores, se for ímpar, vai ser ele + o valor global da varável globalValue
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] += globalValue;
                }
            }
        }
        //Somente olhando a função acima, você não sabe o resultado esperado, pois ela recebe um valor de fora do escopo, que é o globalValue
    }
}