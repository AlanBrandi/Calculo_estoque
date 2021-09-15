using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estoque
{
    class Produtos
    {
        //Declarando variáveis.
        public string Nome;
        public double Preco;
        public int Quantidade;
        //Adicionando um construtor padrão.
        public Produtos (string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produtos()
        {

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
