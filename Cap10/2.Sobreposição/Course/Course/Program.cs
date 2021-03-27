using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccounts(1002, "Ana", 500.0, 0.01);

            acc1.Withdraw(10.0); //Método da SuperClasse, que saca os 10 com mais uma taxa de 5
            acc2.Withdraw(10.0); //Método sobrescrito na SubClasse, que saca os 10 apenas, sem taxa ou, saca os 10, cobrando a taxa de 5, mais a taxa de 2 dessa SubClasse

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
