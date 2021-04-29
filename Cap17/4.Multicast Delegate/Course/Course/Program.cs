using Course.Services;

namespace Course
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum; //meu delegate recebe a função ShowSun
            op += CalculationService.ShowMax; //depois recebe a função ShowMax

            op.Invoke(a, b); //Usando o Invoke, passando os valores a e b, ele vai executar na ordem as funções do delegate, ou seja, ShowSun e ShowMax
            //op(a, b); //Forma alternativa de usar
        }
    }
}