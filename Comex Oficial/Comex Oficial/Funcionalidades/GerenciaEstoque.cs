using Comex.Funcionalidades;
using Comex.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex_Oficial.Funcionalidades
{
    internal class GerenciaEstoque : Funcionalidade
    {
        private Dictionary<string, Produtos> produtosCadastrados;
        private int[] estoque;

        public GerenciaEstoque(Dictionary<string, Produtos> produtosCadastrados, int[] estoque)
        {
            this.produtosCadastrados = produtosCadastrados;
            this.estoque = estoque;
        }

        public override async Task Executa(Dictionary<int, Funcionalidade> opcoesDoDicionario)
        {
            await AtualizaEstoque();
        }

        private async Task AtualizaEstoque()
        {
            Console.WriteLine("Digite (1) para adicionar itens ao estoque.");
            Console.WriteLine("Digite (2) para remover itens do estoque.");
            string opcao = Console.ReadLine();

            Console.Write("Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine();

            if (!produtosCadastrados.ContainsKey(nomeProduto))
            {
                Console.WriteLine("Produto não cadastrado.");
                await Pausar();
                return;
            }

            Produtos produto = produtosCadastrados[nomeProduto];
            int indiceProduto = new List<string>(produtosCadastrados.Keys).IndexOf(nomeProduto);

            Console.Write("Digite a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            if (opcao == "1")
            {
                estoque[indiceProduto] += quantidade;
                Console.WriteLine($"Produto {nomeProduto} atualizado. Nova quantidade em estoque: {estoque[indiceProduto]}");
            }
            else if (opcao == "2")
            {
                if (estoque[indiceProduto] >= quantidade)
                {
                    estoque[indiceProduto] -= quantidade;
                    Console.WriteLine($"Produto {nomeProduto} atualizado. Nova quantidade em estoque: {estoque[indiceProduto]}");
                }
                else
                {
                    Console.WriteLine("Quantidade insuficiente em estoque.");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida.");
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
