using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false; //aceita true ou false
            char genero = 'F'; // aspas simples por ser do tipo char
            char letra = '\u0041'; //também aceita unicode, para usar, colocar entre aspas simples e usar o \u + o código unicode

            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; //o L no final do número, é para explicitar que esse número é um tipo LONG

            float n5 = 4.5F; //o F aqui funciona igual ao LONG acima, porém sem ele, o .net irá entender que ele é double e não float, por isso o F é usado
            double n6 = 4.5;

            string nome = "Maria Green"; //aspas duplas por ser do tipo string, ele é imutavel.
            object obj1 = "Alex Brown"; //tipo genérico, ele aceita qualquer tipo, como a string nessa linha ou o tipo float na linha abaixo
            object obj2 = 4.5F;

            //existem propriedades que te ajudam por exemplo, a descobrir o menor valor dos tipos de variaveis, como o MinValue e o MaxValue 
            int minInt = int.MinValue; 
            int maxInt = int.MaxValue;
            sbyte minSbyte = sbyte.MinValue;
            decimal maxDecimal = decimal.MaxValue;


            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(minInt);
            Console.WriteLine(maxInt);
            Console.WriteLine(minSbyte);
            Console.WriteLine(maxDecimal);


            int idade = 32;
            double saldo = 10.35784;
            //String nome = "Maria";

            //Placeholders vc coloca os valores entre chaves, e passa as variaveis na ordem de substituição
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture));
            //Interpolação vc coloca as variaveis entre as chaves, porém no ínicio, deve colocar o $ para que seja possível
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            //Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo.ToString("F2", CultureInfo.InvariantCulture)} reais");
            //Concatenação é sair unificando as variáveis e o texto desejado através do +
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "
            + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
            //3 formas de concatenar strings e variáveis, e a saída será a mesma.

        }
    }
}
