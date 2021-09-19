using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Descrevendo e pedindo os dados para o usuário + armazenando os dados do usuário.
            Console.WriteLine("Entre com os dados do produto:");
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);
            Console.WriteLine("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            //Declarando e instanciando objeto Produtos.
            Produtos p = new Produtos(nome, preco, quantidade);

            //Demonstrando para o usuário seus resultados já somados.
            Console.WriteLine("Dados do produto: " + p);

            //Descrevendo para o usuário adicionar novas quantias do mesmo produto.
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            //Declarando a quantidade de novos produtos.
            int qte = int.Parse(Console.ReadLine());
            //Adicinando o produto a quantidade que ja possuí no estoque.
            p.AdicionarProduto(qte);
            //Atualizando os dados.
            Console.WriteLine("Dados atualizados: " + p);
            //Retirando a quantidade desejada pelo usuário.
            Console.WriteLine("Digite um número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            //Atualizando os dados.
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
