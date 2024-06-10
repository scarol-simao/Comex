namespace Comex.Modelos
{
    internal class Produto
    {
        public string Nome { get; }
        public string Descricao { get; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; }
        public Categoria Categoria { get; }

        public Produto(string nome, string descricao, double precoUnitario, int quantidade, Categoria categoria)
        {
            Nome = nome;
            Descricao = descricao;
            PrecoUnitario = precoUnitario;
            Quantidade = quantidade;
            Categoria = categoria;
        }
    }
}
