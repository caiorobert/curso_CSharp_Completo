using System;
using Course.Entities;
using System.Collections.Generic;
using System.Linq;

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

            //O delegate Func diferente do Action que não retorna nada (void), vai retornar algo.

            //Func<Product, string> func = NameUpper; //Declarei um uma variavel do tipo delegate Func e passei a função NameUpper para ele
            Func<Product, string> func = p => p.Name.ToUpper(); //Tb posso passar uma lambda direto para a minha variavel, vai funcionar
            //Func<Product, string> func = p => { return p.Name.ToUpper(); }; //usando a chaves em volta, preciso passar o return, pois a Func espera um retorno

            List<string> result = list.Select(func).ToList(); //passando minha variavel fun no Select
            
            //List<string> result = list.Select(p => p.Name.ToUpper()).ToList(); //Preciso do ToList() pq o Select retorna um IEnumerable
            //List<string> result = list.Select(NameUpper).ToList(); //Forma alternativa, passando a função NameUpper
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}