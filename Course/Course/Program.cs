using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cada sessão de testes está delimitarda por //----, para testar cada uma, basta descomentar a desejada e usar
            //__________________________________________________________________________________________________________________________________________

            //bool completo = false; //aceita true ou false
            //char genero = 'F'; // aspas simples por ser do tipo char
            //char letra = '\u0041'; //também aceita unicode, para usar, colocar entre aspas simples e usar o \u + o código unicode

            //byte n1 = 126;
            //int n2 = 1000;
            //int n3 = 2147483647;
            //long n4 = 2147483648L; //o L no final do número, é para explicitar que esse número é um tipo LONG

            //float n5 = 4.5F; //o F aqui funciona igual ao LONG acima, porém sem ele, o .net irá entender que ele é double e não float, por isso o F é usado
            //double n6 = 4.5;

            //string nome = "Maria Green"; //aspas duplas por ser do tipo string, ele é imutavel.
            //object obj1 = "Alex Brown"; //tipo genérico, ele aceita qualquer tipo, como a string nessa linha ou o tipo float na linha abaixo
            //object obj2 = 4.5F;

            ////existem propriedades que te ajudam por exemplo, a descobrir o menor valor dos tipos de variaveis, como o MinValue e o MaxValue 
            //int minInt = int.MinValue; 
            //int maxInt = int.MaxValue;
            //sbyte minSbyte = sbyte.MinValue;
            //decimal maxDecimal = decimal.MaxValue;


            //Console.WriteLine(completo);
            //Console.WriteLine(genero);
            //Console.WriteLine(letra);
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);
            //Console.WriteLine(n5);
            //Console.WriteLine(n6);
            //Console.WriteLine(nome);
            //Console.WriteLine(obj1);
            //Console.WriteLine(obj2);
            //Console.WriteLine(minInt);
            //Console.WriteLine(maxInt);
            //Console.WriteLine(minSbyte);
            //Console.WriteLine(maxDecimal);

            //__________________________________________________________________________________________________________________________________________

            //int idade = 32;
            //double saldo = 10.35784;
            ////String nome = "Maria";

            ////Placeholders vc coloca os valores entre chaves, e passa as variaveis na ordem de substituição
            //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            ////Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture));
            ////Interpolação vc coloca as variaveis entre as chaves, porém no ínicio, deve colocar o $ para que seja possível
            //Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            ////Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo.ToString("F2", CultureInfo.InvariantCulture)} reais");
            ////Concatenação é sair unificando as variáveis e o texto desejado através do +
            //Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "
            //+ saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
            ////3 formas de concatenar strings e variáveis, e a saída será a mesma.

            //__________________________________________________________________________________________________________________________________________

            //int nn1 = 3 + 4 * 2;
            //int nn2 = (3 + 4) * 2;
            //int nn3 = 17 % 3;
            //double Intnn4 = 10 / 8; //Dessa forma, vai retorna apenas 1, e não 1,25 que é double, pois os numeros estão inteiros
            //double Doublenn4 = (double) 10 / 8; //Dessa forma, você está dizendo que quer o 10 como double, então a conversão é feita, e o resultado é 1,25
            //double Dbnn4 =  10.0 / 8; //Dessa forma, vai funcionar igual a linha de cima, convertendo para double

            //Console.WriteLine(nn1);
            //Console.WriteLine(nn2);
            //Console.WriteLine(nn3);
            //Console.WriteLine(Intnn4);
            //Console.WriteLine(Doublenn4);
            //Console.WriteLine(Dbnn4);

            //double a = 1.0, b = -3.0, c = -4.0;
            //double deltaTeste = b * b - 4.0 * a * c; //o Delta na matemática é representado pelo valor b2 (b ao quadrado) - 4ac (a * a * c). Essa é uma forma de escrever
            //double delta = Math.Pow(b, 2.0) - 4.0 * a * c; //dessa forma, usando o Math.Pow(valor, potencia) fica mais fácil ao indicar o número potencia, se fosse maior que 2
            //double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); //a formula Math.Sqrt(valor) é para descobrir a raiz quadrada de um valor
            //double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            //Console.WriteLine(delta);
            //Console.WriteLine(x1);
            //Console.WriteLine(x2);

            //__________________________________________________________________________________________________________________________________________

            ////Abaixo vemos o uso do Split(); que quebra sua variavel em posições dependendo do parametro passado, no caso abaixo, o espaço.
            ////Se eu passar 3 palavras divididas por espaço, o split vai armazenar cada uma em uma posição do meu vetor v
            ////Depois posso atribuir cada posição a uma variável, e usar como bem entender.
            //string s = Console.ReadLine(); //posso pedir a variavel s do console para depois fazer o split dela, conforme abaixo
            ////string[] v = s.Split(' '); 
            //string[] v = Console.ReadLine().Split(' '); //ou posso simplesmente já pedir os dados do console e fazer o split direto deles
            //string p1 = v[0];
            //string p2 = v[1];
            //string p3 = v[2];

            //Console.WriteLine(s);
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine(p3);
            
            //__________________________________________________________________________________________________________________________________________

            //O console.ReadLine() só faz leitura de string, para busca o valor se for numero como inteiro, precisa de uma conversão
            int n1 = int.Parse(Console.ReadLine()); //Dessa forma, vc está dizendo que o valor digitado do Console, é um numero INT
            char ch = char.Parse(Console.ReadLine()); //converte string para char
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //converte string para double. Recebe o valor double por ponto
            //double n2 = double.Parse(Console.ReadLine()); //converte string para double. Recebe o valor double por vírgula
            string[] v = Console.ReadLine().Split();
            string nome = v[0];
            char sexo = char.Parse(v[1]);
            int idade = int.Parse(v[2]);
            double altura = double.Parse(v[3], CultureInfo.InvariantCulture);

            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture); //imprime com o .

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura); //imprime com a vírgula



        }
    }
}
