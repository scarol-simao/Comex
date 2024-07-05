using Comex.Modelos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Comex.Funcionalidades
{
    internal class ListaCategorias : Funcionalidade
    {
        private List<Categoria> BancoDeCategorias;

        public ListaCategorias(List<Categoria> bancoDeCategorias)
        {
            BancoDeCategorias = bancoDeCategorias;
        }

        public override Task Executa(Dictionary<int, Funcionalidade> opcoes)
        {
            base.Executa(opcoes);
            ExibeTitulo("Lista de Categorias");

            if (BancoDeCategorias.Count > 0)
            {
                foreach (var categoria in BancoDeCategorias)
                {
                    Console.WriteLine($"- {categoria.Descricao}");
                }
            }
            else
            {
                Console.WriteLine("Nenhuma categoria cadastrada.");
            }

            return Task.CompletedTask;
        }
    }
}
