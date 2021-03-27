using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
            //Console.WriteLine(account.Balance);

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING
            //conversão de uma variavel de SubClasse para SuperClasse. Isso é possível, pq a BA é uma Account
            Account acc1 = bacc; //Posso converter minha BussinessAccount para Account assim
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0); // ou converter BussinessAccount para Account já na instanciação
            Account acc3 = new SavingsAccounts(1004, "Ana", 0.0, 0.01); //E a SavingsAccounts, por tb ser uma Account, tb é possível

            //DOWNCASTING (é uma operação insegura, pois o compilador não aponta erro, só apontará em tempo de execução)
            //Conversão de uma variavel de SuperClasse para SubClasse. Você converter passando entre (SubClasse)
            BusinessAccount acc4 = (BusinessAccount)acc2; //Convertendo a variavel acc2 que é uma Account para uma BusinessAccount
            acc4.Loan(100.0); //Dessa forma, acc4 pode usar métodos da SubClasse

            if(acc3 is BusinessAccount) //Dessa forma eu checo se a variável é do tipo que eu preciso
            {
                BusinessAccount acc5 = (BusinessAccount)acc3; //dps de checado, se for, posso usar o casting nela e atribuir a outra variável do mesmo tipo do casting
                acc5.Loan(500.0);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccounts)
            {
                //SavingsAccounts acc5 = (SavingsAccounts)acc3; //Essa é uma forma de conversão, colocando o tipo entre parenteses ()
                SavingsAccounts acc5 = acc3 as SavingsAccounts; //Essa é outra forma de conversão, usando o AS e o tipo
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
