using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Comex.Funcionalidades
{
    internal class Funcionalidade
    {
        public string Titulo { get; }

        public virtual void ExibeTitulo(string titulo)
        {
            int quantidadeDeLetra = titulo.Length;
            string asteriscos = new string('*', quantidadeDeLetra);
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }

        public virtual Task Executa(Dictionary<int, Funcionalidade> opcoes)
        {
            Console.Clear();
            return Task.CompletedTask;
        }
    }
}
