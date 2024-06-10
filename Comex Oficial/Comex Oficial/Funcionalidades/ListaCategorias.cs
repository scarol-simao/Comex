using Comex.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public override void Executa(Dictionary<int, Funcionalidade> opcoes)
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
                Console.WriteLine("Nenhum categoria cadastrada.");
            }
   }     }   
}
