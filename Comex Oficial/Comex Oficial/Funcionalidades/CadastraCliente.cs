using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comex.Modelos;

namespace Comex.Funcionalidades
{
    internal class CadastraCliente : Funcionalidade
    {
        public Dictionary<string, Cliente> BancoDeClientes = new Dictionary<string, Cliente>();

        public CadastraCliente(Dictionary<string, Cliente> bancoDeClientes)
        {
            BancoDeClientes = bancoDeClientes;
        }

        public override void Executa(Dictionary<int, Funcionalidade> opcoes)
        {
            base.Executa(opcoes);
            ExibeTitulo("Cadastra Cliente");
            Console.Write("Informe o Nome Completo:  ");
            string nome = Console.ReadLine();
            Console.Write("Informe o E-mail:  ");
            string email = Console.ReadLine();
            Console.Write("Informe o telefone:  ");
            long telefone = long.Parse(Console.ReadLine());
            Console.Write("Informe o logadouro:   ");
            string logadouro  = Console.ReadLine();
            Console.Write("Informe o numero:  ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Informe o bairro: ");
            string bairro = Console.ReadLine();
            Console.Write("Informe a cidade:  ");
            string cidade = Console.ReadLine();
            Console.Write("Informe o Estado: ");
            string estado = Console.ReadLine();

            Endereco endereco = new Endereco(logadouro, numero, bairro, cidade, estado);
            Cliente cliente = new Cliente (nome, email, telefone, endereco);

            BancoDeClientes.Add(email, cliente);
            //  Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine($"Usuário <{nome}> ({email}) cadastrado com sucesso! ");



        }
    }
}
