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

        private string _nome; //utilizar este padrao de nomes para atributos privados
        private double _preco;
        private int _quantidade;

        public Produto()
        {
            _quantidade = 10;
        }

        //SOBRECARGA
        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 0;
        }

        //utilizando o this para reaproveitar valores
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        //utilizando encapsulamento
        public string GetNome()
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
        //pode acessar mas nao alterar
        public double GetPreco() 
        {
            return _preco;
        }

        public double GetQuantidade()
        {
            return _quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos (int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", R$ " 
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Toltal: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
