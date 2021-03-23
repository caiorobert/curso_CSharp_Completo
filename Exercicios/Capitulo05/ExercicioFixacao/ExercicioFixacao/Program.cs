using System;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria;
            double valor;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();


            Console.Write("Haverá deposito inicial (s/n): ");
            char sn = char.Parse(Console.ReadLine());
            if (sn == 's' || sn == 'S')
            {
                Console.Write("Entre com o valor de deposito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new ContaBancaria(numero, titular, valor);
            }
            else
            {
                contaBancaria = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaBancaria);


            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposito(valor);
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(contaBancaria);


            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Saque(valor);
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(contaBancaria);
        }
    }
}
