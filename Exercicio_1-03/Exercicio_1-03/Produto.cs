using System.Globalization;

namespace Exercicio_1_03
{
    internal class Produto
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int Quantidade { get; set; }

        public Produto()
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        /*public string Nome
        {
            get { return _nome; }
        }

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                _quantidade = value;
            }
        }*/

        /*public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }*/

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            if (quantity > Quantidade)
            {
                Quantidade = 0;
            }
            else
            {
                Quantidade -= quantity;
            }
        }

        public override string ToString()
        {
            return $"{Nome}, R${Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: R${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
