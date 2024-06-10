using Comex.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Funcionalidades
{
    internal class CadastraProduto : Funcionalidade
    {
        Dictionary<string, Produto> BancoDeProdutos;
        List<Categoria> BancoDeCategorias;

        public CadastraProduto(Dictionary<string, Produto> produtosCadastrados, List<Categoria> categoriasCadastradas)
        {
            BancoDeProdutos = produtosCadastrados;
            BancoDeCategorias = categoriasCadastradas;
        }

        public override void Executa(Dictionary<int, Funcionalidade> opcoes)
        {
            base.Executa(opcoes);
            ExibeTitulo("Cadastra Produto");

            Console.WriteLine("Informe os dados do produto:");
            Console.Write("Informe a Categoria: ");
            string categoriaDoProduto = Console.ReadLine();
            Categoria categoria = BancoDeCategorias.Find(c => c.Descricao == categoriaDoProduto);
            if (categoria == null)
            {
                Console.WriteLine("Categoria não encontrada. Cadastre a categoria primeiro.");
                return;
            }

            Console.Write("Informe o Nome do produto: ");
            string nomeProduto = Console.ReadLine();
            Console.Write($"Informe a descrição do {nomeProduto}: ");
            string descricaoProduto = Console.ReadLine();
            Console.Write($"Informe o Preço Unitário do {nomeProduto}: ");
            double precoUnitario = double.Parse(Console.ReadLine());
            Console.Write("Informe a Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto novoProduto = new Produto(nomeProduto, descricaoProduto, precoUnitario, quantidade, categoria);
            BancoDeProdutos.Add(nomeProduto, novoProduto);
            Console.WriteLine($"Produto '{nomeProduto}' cadastrado com sucesso!");

            
        }
    }
}
