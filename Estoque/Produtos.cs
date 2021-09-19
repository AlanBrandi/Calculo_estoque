using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estoque
{
    class Produtos
    {
        //Declarando variáveis.
        private string Nome;
        //declarando variável utilizando o auto properties.
        private double Preco
        {
            get;
            set;
        }
        private int Quantidade
        {
            get;
            set;
        }

        //Adicionando um construtor personalizado.
        public Produtos(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        //Adicionando um construtor padrão.
        public Produtos()
        {

        }
        //Utilização do properties C#
        //Properties Nome.
        public string _Nome
        {
            get
            {
                return Nome;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    Nome = value;
                }
            }
        }
        //Properties Preço.
        public double _Preco
        {
            get
            {
                return Preco;
            }
            set
            {
                if (value > 0)
                {
                    Preco = value;
                }
            }
        }
        //Properties Quantidade.
        public int _Quantidade
        {
            get
            {
                return Quantidade;
            }
            set
            {
                if (value > 0)
                {
                    Preco = value;
                }
            }
        }


        //Calculo do valor total em estoque.
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        //Adicionando a quandidade de um produto junto da quantidade enviada.
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        //Retirando uma quantidade do produto.
        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
        //Atualizando os dados junto de refinamentos das desmonstração para o usuário.
        public override string ToString()
        {
            return Nome + ", R$" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
