namespace Comex.Modelos
{
    internal class Endereco
    {
        public string Logradouro { get; }
        public int Numero { get; }
        public string Bairro { get; }
        public string Cidade { get; }
        public string Estado { get; }

        public Endereco(string logradouro, int numero, string bairro, string cidade, string estado)
        {
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
    }

}
