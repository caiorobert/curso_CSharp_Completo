using System;
using Course.Entities;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Na linha abaixo, eu estou usando uma labda que no final, retorna um bool para minha lista
            list.RemoveAll(p => p.Price >= 100.0); //Na assinatura do objeto RemoveAll, ele tem uma função que recebe um objeto e devolve um bool


            //list.RemoveAll(ProductTest); //dessa forma alternativa, eu criei uma função ProductTest que retorna um bool, e posso usar ela no meu RemoveAll
            foreach (Product p in list)
            {
                Console.WriteLine(p); //Aqui eu testo se ele vai trazer somente os produtos abaixo de 100
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}