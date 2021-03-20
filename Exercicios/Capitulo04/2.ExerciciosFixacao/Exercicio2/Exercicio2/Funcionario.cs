using System.Globalization;

namespace Exercicio2
{
    internal class Funcionario
    {
        public string Nome { get; internal set; }
        public double SalarioBruto { get; internal set; }
        public double Imposto { get; internal set; }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return $"{Nome}, R$ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}