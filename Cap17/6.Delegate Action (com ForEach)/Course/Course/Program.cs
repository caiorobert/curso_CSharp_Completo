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

            Action<Product> act = UpdatePrice; //Posso criar uma variavel do tipo Action<Product> e depois, passar ela pro meu ForEach, vai funcionar
            //Action<Product> act = p => { p.Price += p.Price * 0.1; }; //tb posso passar a lambda direto para minha variável se desejar
            
            list.ForEach(act);
            //list.ForEach(p => { p.Price += p.Price * 0.1; }); //o delegate action não retorna nada, no caso, eu uso as chaves {} e sem return, mostrando que é um void
            //list.ForEach(UpdatePrice); //forma alternativa de usar, criei a função e passei ela de parametro, pois é uma função void
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}