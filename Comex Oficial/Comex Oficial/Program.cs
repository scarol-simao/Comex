using System;
using System.Collections.Generic;
using Comex.Funcionalidades;
using Comex.Modelos;

namespace Comex.Program
{
    internal class Program
    {
        public static Dictionary<int, Funcionalidade> opcoesDoDicionario = new Dictionary<int, Funcionalidade>();
        public static Dictionary<string, Cliente> clientesCadastrados = new Dictionary<string, Cliente>();
        public static List<Categoria> categoriasCadastradas = new List<Categoria>();
        public static Dictionary<string, Produto> produtosCadastrados = new Dictionary<string, Produto>();



        static void Main(string[] args)
        {
            opcoesDoDicionario.Add(0, new Sair());
            opcoesDoDicionario.Add(1, new CadastraCliente(clientesCadastrados));
            opcoesDoDicionario.Add(2, new ListaClientes(clientesCadastrados));
            opcoesDoDicionario.Add(3, new CadastraCategoria(categoriasCadastradas));
            opcoesDoDicionario.Add(4, new ListaCategorias(categoriasCadastradas));
            opcoesDoDicionario.Add(5, new CadastraProduto(produtosCadastrados, categoriasCadastradas));
            opcoesDoDicionario.Add(6, new AjustaPrecoDeProduto(produtosCadastrados));
            ExibirMenuDeOpcoes();
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

        static void ExibirMenuDeOpcoes()
        {
            ExibirLogo();
            Console.WriteLine("Digite (1) para Cadastrar o Cliente:  ");
            Console.WriteLine("Digite (2) para ver a Lista dos Clientes:  ");
            Console.WriteLine("Digite (3) para Cadastrar uma Categoria:  ");
            Console.WriteLine("Digite (4) para ver a Lista de Categorias:  ");
            Console.WriteLine("Digite (5) para Cadastrar um Produto:  ");
            Console.WriteLine("Digite (6) para Ajustar o Preço de um Produto:  ");
            Console.WriteLine("Digite (0) para sair:  ");
            Console.Write("\nDigite a sua opção:  ");
            string opcaoEscolhida = Console.ReadLine();
            int opcaoNumericaCovertida = int.Parse(opcaoEscolhida);

            if (opcoesDoDicionario.ContainsKey(opcaoNumericaCovertida))
            {
                Funcionalidade menuExibidido = opcoesDoDicionario[opcaoNumericaCovertida];
                menuExibidido.Executa(opcoesDoDicionario);
                if (opcaoNumericaCovertida != 0)
                {
                    ExibirMenuDeOpcoes();
                }
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }

        }
    }
}

