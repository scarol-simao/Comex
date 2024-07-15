using comex_api.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comex_api.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosAsCategoriasProduto(List<Produtos> produtos)
    {
        var todosAsCategorias = produtos.Select(categorias => categorias.categoria).Distinct().ToList();
        foreach (var categoria in todosAsCategorias)
        {
            Console.WriteLine($"- {categoria}");
        }
    }
    public static void FiltrarProdutosPorCategorias(List<Produtos> produtos, string? categoria )
    {
        var produtosPorCategoria = produtos.Where(produtos => produtos.categoria!.Contains(categoria)).Select(produtos => produtos.Produto).ToList();
        Console.WriteLine($"Exibindo os produtos por categoria>>> {categoria}");

        foreach (var produto in  produtosPorCategoria)
        {
            Console.WriteLine($"- {produto}");
        }
    }
}