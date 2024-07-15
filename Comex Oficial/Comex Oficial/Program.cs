using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Comex.Funcionalidades;
using Comex.Modelos;

namespace Comex.Program
{
    internal class Program
    {
        public static Dictionary<int, Funcionalidade> opcoesDoDicionario = new Dictionary<int, Funcionalidade>();
        public static Dictionary<string, Cliente> clientesCadastrados = new Dictionary<string, Cliente>();
        public static List<Categoria> categoriasCadastradas = new List<Categoria>();
        public static Dictionary<string, Produtos> produtosCadastrados = new Dictionary<string, Produtos>();

        static async Task Main(string[] args)
        {
            opcoesDoDicionario.Add(0, new Sair());
            opcoesDoDicionario.Add(1, new CadastraCliente(clientesCadastrados));
            opcoesDoDicionario.Add(2, new ListaClientes(clientesCadastrados));
            opcoesDoDicionario.Add(3, new CadastraCategoria(categoriasCadastradas));
            opcoesDoDicionario.Add(4, new ListaCategorias(categoriasCadastradas));
            opcoesDoDicionario.Add(5, new ListaProdutos());
            await ExibirMenuDeOpcoes();
            Console.ReadLine();
        }

        static void ExibirLogo()
        {
            Console.WriteLine(@"
             
░█▀▀█ ░█▀▀▀█ ░█▀▄▀█ ░█▀▀▀ ▀▄░▄▀ 
░█─── ░█──░█ ░█░█░█ ░█▀▀▀ ─░█── 
░█▄▄█ ░█▄▄▄█ ░█──░█ ░█▄▄▄ ▄▀░▀▄
      
             ");
        }

        static async Task ExibirMenuDeOpcoes()
        {
            ExibirLogo();
            Console.WriteLine("Digite (1) para Cadastrar o Cliente:  ");
            Console.WriteLine("Digite (2) para ver a Lista dos Clientes:  ");
            Console.WriteLine("Digite (3) para Cadastrar uma Categoria:  ");
            Console.WriteLine("Digite (4) para ver a Lista de Categorias:  ");
            Console.WriteLine("Digite (5) para ver a Lista de Produtos por Categorias:  ");
            Console.WriteLine("Digite (0) para sair:  ");
            Console.Write("\nDigite a sua opção:  ");
            string opcaoEscolhida = Console.ReadLine();
            int opcaoNumericaCovertida = int.Parse(opcaoEscolhida);

            if (opcoesDoDicionario.ContainsKey(opcaoNumericaCovertida))
            {
                Funcionalidade menuExibidido = opcoesDoDicionario[opcaoNumericaCovertida];
                await menuExibidido.Executa(opcoesDoDicionario);
                if (opcaoNumericaCovertida != 0)
                {
                    await ExibirMenuDeOpcoes();
                }
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }
    }
}
