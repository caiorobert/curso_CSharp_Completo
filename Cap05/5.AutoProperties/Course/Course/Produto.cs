using System.Globalization;
namespace Course
{
    class Produto
    {
        //propriedade privada
        private string _nome; //o nome não da para usar a autopropertie, pq ele tem uma lógica de controle própria
        //propriedades normais
        public double Preco { get; private set; } //autopropertie, assim digo que get é permitido, mas o set é privado, ou seja, não pode ser usado
        public int Quantidade { get; private set; }


        //Construtores
        //Construtor padrão, sem atributos
        public Produto()
        {

        }


        //Sobrecarga do construtor Produto com 2 parametros
        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            //Quantidade = 0; //valores numéricos começam com 0 se não informar, então não precisaria dessa linha
        }

        //sobrecarga do construtor Produto com 3 parametros, no caso abaixo, foi usado o this para pegar o contrutor de
        //2 parametros e usar ele nesse de 3, evitando refazer o código
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }


        //Propriedades customizadas
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

        //demais métodos
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}