using System;
using System.Collections.Generic;

namespace Comex.Funcionalidades
{
     internal class Funcionalidade
    {
        public string Titulo { get;}
        public  virtual void ExibeTitulo(string Titulo)
        {
            int quantiadeDeletra = Titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantiadeDeletra, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(Titulo);
            Console.WriteLine(asteriscos + "\n");
        }

        public virtual void Executa(Dictionary<int, Funcionalidade> opcoes)
        {
            Console.Clear();
        }       
    }
}
