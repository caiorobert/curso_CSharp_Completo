namespace Exercicio3
{
    internal class Aluno
    {
        public string Nome { get; internal set; }
        public double Nota1 { get; internal set; }
        public double Nota2 { get; internal set; }
        public double Nota3 { get; internal set; }

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}