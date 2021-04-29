using System;
using System.Linq;
using Course.Entities;
using System.Collections.Generic;

namespace Course
{
    class Program
    {

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0); //Pegar tier 1 e price menor que 900
            Print("TIER 1 AND PRICE < 900:", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name); //produtos da categoria Tools
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            //retorna os objetos que comecem com C e cria um objeto anonimo para o retorno
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            //Pega os produtos com Tier 1 e ordena por Price depois por name
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            //Skip().Take() é usado para paginação, aqui estamos falando pule 2, pegue 4
            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            //Retorna o primeiro ou nulo
            var r6 = products.FirstOrDefault();
            Console.WriteLine("First or default test1: " + r6);

            //Busca produtos onde o Price é maior que 3000 e pega somente o primeiro ou fica vazio se não existir na condição passada
            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);
            Console.WriteLine();

            //Pega o valor único ou null. Podia usar o Single(), mas ai preciso ter certeza do retorno de valor, se não ele da erro. Para evitar, usamos o SingleOrDefault()
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r8); //Aqui retorna valor
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9); //Aqui não retorna valor
            Console.WriteLine();

            //Traz o maior preço entre os produtos
            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);
            //Traz o menor preço entre os produtos
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);

            //Soma os produtos da categoria 1
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);

            //Faz a média dos preços dos produtos da categoria 1. Se a expressão não retornasse nada, daria erro.
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + r13);

            //Para evitar o erro se vier vazio a expressão do Where(), fazer da forma abaixo
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Average prices: " + r14);

            //O Aggregate é como se fosse o Map e Reduce em outras linguagens, ai para evitar erro, deixamos um valor padrão nele caso a expressão não retorne valor.
            //No caso abaixo, o retorno padrão ficou o 0.0
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + r15);
            Console.WriteLine();

            //Fazendo um GroupBy por categoria
            var r16 = products.GroupBy(p => p.Category);

            //Para imprimir esse Groupby acima, preciso fazer o esquema abaixo
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":"); //O Key é a minha Category
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}