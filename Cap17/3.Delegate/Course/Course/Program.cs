using Course.Services;

namespace Course
{
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            System.Console.WriteLine("Sem Delegate");
            double result = CalculationService.Sum(a, b);
            System.Console.WriteLine("Chamando Sum (CalculationService.Sum(a, b)): " + result);

            result = CalculationService.Max(a, b);
            System.Console.WriteLine("Chamando Max (CalculationService.Max (a, b)): " + result);

            result = CalculationService.Square(a);
            System.Console.WriteLine("Chamando Square de 10 (CalculationService.Square(a)): " + result);
            System.Console.WriteLine("-------------------------------------------");

            System.Console.WriteLine("Com Delegate");
            System.Console.WriteLine("BinaryNumericOperation op = CalculationService.Sum;");
            BinaryNumericOperation op = CalculationService.Sum;
            //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum); //Forma alternativa de declarar, mas é mais verbosa

            result = op(a, b);
            //result = op.Invoke(a, b); //Forma alternativa de chamar a função do delegate
            System.Console.WriteLine("Chamando Sum (op(a, b)): " + result);

            System.Console.WriteLine("op = CalculationService.Max;");
            op = CalculationService.Max;
            result = op(a, b);
            System.Console.WriteLine("Chamando Max (op(a, b)): " + result);

            //result = CalculationService.Square; Isso não funciona, pq a assinatura da função Square não casa com a definição do delegate, que recebe dois numeros double
        }
    }
}