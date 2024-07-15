using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Comex.Funcionalidades
{
    internal class Sair : Funcionalidade
    {
        public override Task Executa(Dictionary<int, Funcionalidade> opcoes)
        {
            base.Executa(opcoes);
            Console.WriteLine("\n\n\n");
            Console.WriteLine("COMEX FINALIZADO!");

            return Task.CompletedTask;
        }
    }
}
