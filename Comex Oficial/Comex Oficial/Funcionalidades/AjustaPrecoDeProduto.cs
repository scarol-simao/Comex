using Comex.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Funcionalidades
{
    internal class AjustaPrecoDeProduto : Funcionalidade
    {
        Dictionary<string, Produto> BancoDeProdutos;

        public AjustaPrecoDeProduto(Dictionary<string, Produto> produtosCadastrados)
        {
            BancoDeProdutos = produtosCadastrados;
        }

        public override void Executa(Dictionary<int, Funcionalidade> opcoes)
        {
            base.Executa(opcoes);
            ExibeTitulo("Ajusta Preço de Produto");

            Console.Write("Informe o nome do produto: ");
            string nomeProduto = Console.ReadLine();

            if (!BancoDeProdutos.ContainsKey(nomeProduto))
            {
                Console.WriteLine("Produto não cadastrado no sistema.");

            }

            Console.Write($"Informe o novo preço para {nomeProduto}: ");
            double novoPreco = double.Parse(Console.ReadLine());

            BancoDeProdutos[nomeProduto].PrecoUnitario = novoPreco;
            Console.WriteLine($"Preço do produto '{nomeProduto}' ajustado com sucesso!");
        }
    }
}
