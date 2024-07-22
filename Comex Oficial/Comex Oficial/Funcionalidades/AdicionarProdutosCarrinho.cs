using Comex.Modelos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Comex.Funcionalidades
{
    internal class AdicionaProdutoAoCarrinho : Funcionalidade
    {
        private Dictionary<string, Produtos> produtosCadastrados;
        private int[] estoque;
        private Dictionary<string, int> carrinho;

        public AdicionaProdutoAoCarrinho(Dictionary<string, Produtos> produtosCadastrados, int[] estoque, Dictionary<string, int> carrinho)
        {
            this.produtosCadastrados = produtosCadastrados;
            this.estoque = estoque;
            this.carrinho = carrinho;
        }

        public override async Task Executa(Dictionary<int, Funcionalidade> opcoesDoDicionario)
        {
            await AdicionarProdutoAoCarrinho();
        }

        private async Task AdicionarProdutoAoCarrinho()
        {
            Console.Write("Digite o nome do produto a adicionar ao carrinho: ");
            string nomeProduto = Console.ReadLine();

            if (!produtosCadastrados.ContainsKey(nomeProduto))
            {
                Console.WriteLine("Produto não cadastrado.");
                await Pausar();
                return;
            }

            Produtos produto = produtosCadastrados[nomeProduto];
            int indiceProduto = new List<string>(produtosCadastrados.Keys).IndexOf(nomeProduto);

            Console.Write("Digite a quantidade desejada: ");
            int quantidade = int.Parse(Console.ReadLine());

            if (estoque[indiceProduto] < quantidade)
            {
                Console.WriteLine($"Quantidade insuficiente no estoque. Disponíveis: {estoque[indiceProduto]}");
            }
            else
            {
                estoque[indiceProduto] -= quantidade;

                if (carrinho.ContainsKey(nomeProduto))
                {
                    carrinho[nomeProduto] += quantidade;
                }
                else
                {
                    carrinho[nomeProduto] = quantidade;
                }

                Console.WriteLine($"Produto {nomeProduto} adicionado ao carrinho. Quantidade adicionada: {quantidade}. Quantidade restante no estoque: {estoque[indiceProduto]}");
            }

            await Pausar();
        }

        private async Task Pausar()
        {
            Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
