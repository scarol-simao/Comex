namespace Comex.Modelos
{
    internal class Cliente
    {
        public string Nome { get; }
        public string Email { get; }
        public long Telefone { get; }

        public Endereco Endereco { get; }
        

        public Cliente(string nome, string email, long telefone, Endereco endereco)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
          
        }
    }
}
 