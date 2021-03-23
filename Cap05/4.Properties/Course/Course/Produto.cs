using System.Globalization;
namespace Course
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;


        //Construtor padrão, sem atributos
        public Produto()
        {

        }


        //Sobrecarga do construtor Produto com 2 parametros
        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            //Quantidade = 0; //valores numéricos começam com 0 se não informar, então não precisaria dessa linha
        }

        //sobrecarga do construtor Produto com 3 parametros, no caso abaixo, foi usado o this para pegar o contrutor de
        //2 parametros e usar ele nesse de 3, evitando refazer o código
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        //Sempre que precisar disponibilizar um atributo privado, terá que ser feito um método para isso, seja um para apenas passar o atributo, ou para altera-lo.
        //Outra forma, é usar uma propertie, disponibilizando dentro dela os métodos desejados, seja só GET ou SET, ou ambos
        public string Nome
        {
            get { return _nome; }
            set
            {
                //exemplo, só aceito mudar o atributo, se não for nulo, e for maior que 1 o tamanho
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //na forma abaixo, eu disponibilizo os atributos preco e quantidade, mas não permito alterações no mesmo, e usando properties, disponibilizando somente o GET
        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }


        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}