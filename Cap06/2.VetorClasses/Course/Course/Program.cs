using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //aqui foi criado um vetor do tipo Product (a classe), alocando n Heap
            Product[] vect = new Product[n];
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //quando for salvar os valores dentro do vetor do tipo Clase, vai precisar instanciar a Classe novamente, e ai sim, passar os valores para ela
                vect[i] = new Product { Name = name, Price = price };
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                //Para acessar um campo dentro de um vetor do tipo classe, coloca o vetor, sua posição e o nome do campo dentro daquela posição
                sum += vect[i].Price;
            }
            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}