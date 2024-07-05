using comex_api.Modelos;
using System.Text.Json;
using comex_api.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://fakestoreapi.com/products");
        var produto = JsonSerializer.Deserialize<List<Produtos>>(resposta)!;
        LinqFilter.FiltrarTodosAsCategoriasProduto(produto);
        LinqFilter.FiltrarProdutosPorCategorias(produto, "women's clothing");


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
