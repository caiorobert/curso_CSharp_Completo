using System;
using System.Collections.Generic;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Maria"); //adiciona na lista
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco"); //adiciona na lista, mas na posição especificada, no caso, a 2
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count); //faz a contagem de itens da lista
            string s1 = list.Find(x => x[0] == 'A'); //Busca o primeiro caso da lista onde a primeira letra é A
            Console.WriteLine("First 'A': " + s1);
            string s2 = list.FindLast(x => x[0] == 'A'); //Busca o último caso da lista onde a primeira letra é A
            Console.WriteLine("Last 'A': " + s2);
            int pos1 = list.FindIndex(x => x[0] == 'A'); //Busca a posição do primeiro caso da lista onde a primeira letra é A
            Console.WriteLine("First position 'A': " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A'); //Busca a posição do último caso da lista onde a primeira letra é A
            Console.WriteLine("Last position 'A': " + pos2);
            List<string> list2 = list.FindAll(x => x.Length == 5); //Busca todos os casos da lista que tenham tamanho 5
            Console.WriteLine("---------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            list.Remove("Alex"); //Remove da lista o parametro passado, se não existir, não fará nada
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveAll(x => x[0] == 'M'); //Remove da lista todos as opções que comecem com a letra M
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Existe tb o removeAt(posicao) que vai remover da lista a posição passada
            //Existe o removeRange(posicao, quantasCasas) vai remover a partir da posição informada, a quantidade de itens do segundo parametro.
            //Se for removeRange(2,2), vai remover começando da posição 2 e somando mais 2, terminando na posição 4
        }
    }
}