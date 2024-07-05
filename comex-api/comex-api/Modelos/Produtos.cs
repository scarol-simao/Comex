using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace comex_api.Modelos;

internal class Produtos
{
    [JsonPropertyName("title")]
    public string? Produto { get; set; }

    [JsonPropertyName("id")]
    public int? ID { get; set; }

    [JsonPropertyName("description")]
    public string? Descricao { get; set; }

    [JsonPropertyName("price")]
    public double preco { get; set; }

    [JsonPropertyName("category")]
    public string? categoria { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Produto}");
        Console.WriteLine($"Id: {ID}");
        Console.WriteLine($"Descrição: {Descricao}");
        Console.WriteLine($"Preço: {preco}");
        Console.WriteLine($"Categoria: {categoria}");
    }
}
