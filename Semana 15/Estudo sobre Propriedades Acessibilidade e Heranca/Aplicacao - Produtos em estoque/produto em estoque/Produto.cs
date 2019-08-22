using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace produto_em_estoque
{
    class Produto
    {

        private string _nome; //utilizar este padrao de nomes para atributos privados (convencao)
        public double Preco { get; private set; } //fazendo isso, dispensa a implementacao 
        public int Quantidade { get; private set; }

        public Produto()
        {
            Quantidade = 10;
        }

        //SOBRECARGA
        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 0;
        }

        //utilizando o this para reaproveitar valores
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        //estudo de propriedades
        public string Nome
        {
            get { return _nome; }
            set { if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
               
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos (int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", R$ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Toltal: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
