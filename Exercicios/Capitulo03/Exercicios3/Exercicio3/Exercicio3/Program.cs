using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do combustível desejado:");
            Console.WriteLine("1 - Álcool");
            Console.WriteLine("2 - Gasolina");
            Console.WriteLine("3 - Diesel");
            Console.WriteLine("4 - Para sair. Qualquer outro valor digitado, será ignorado.");

            int combustivel = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while(combustivel != 4)
            {
                if(combustivel == 1)
                {
                    alcool++;
                }else if(combustivel == 2){
                    gasolina++;
                }
                else if(combustivel == 3){
                    diesel++;
                }

                combustivel = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine($"Álcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
