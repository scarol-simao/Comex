using Comex.Modelos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Comex.Funcionalidades
{
    internal class ListaProdutos : Funcionalidade
    {
        private static readonly HttpClient client = new HttpClient();

        public override async Task Executa(Dictionary<int, Funcionalidade> opcoesDoDicionario)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://fakestoreapi.com/products");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                var produtos = JsonSerializer.Deserialize<List<Produtos>>(responseBody);

                Console.Write("Digite a categoria desejada (ou pressione Enter para listar todos os produtos): ");
                string categoriaConsultada = Console.ReadLine();

                if (produtos != null)
                {
                    bool categoriaInformada = !string.IsNullOrWhiteSpace(categoriaConsultada);
                    int contador = 0;
                    int totalProdutos = produtos.Count;

                    foreach (var produto in produtos)
                    {
                        if (!categoriaInformada || produto.categoria.Equals(categoriaConsultada, StringComparison.OrdinalIgnoreCase))
                        {
                            produto.ExibirFichaTecnica();
                            contador++;
                            if (contador < totalProdutos)
                            {
                                Console.WriteLine(new string('-', 50)); 
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            finally
            {
                Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey(true);
                Console.Clear(); 
            }
        }
    }
}
