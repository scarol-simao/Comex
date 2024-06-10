using Comex.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Funcionalidades
{
    internal class CadastraCategoria : Funcionalidade
    {
        private List<Categoria> BancoDeCategorias;
        public CadastraCategoria(List<Categoria> bancoDeCategorias)
        {
            BancoDeCategorias = bancoDeCategorias;
        }
        public override void Executa(Dictionary<int, Funcionalidade> opcoes)
        {
            base.Executa(opcoes);
            ExibeTitulo("Cadastra Categoria");
            Console.Write("Digite a descrição da nova categoria: ");
            string descricao = Console.ReadLine();
            Categoria novaCategoria = new Categoria(descricao);
            BancoDeCategorias.Add(novaCategoria);
            Console.WriteLine($"Categoria '{descricao}' cadastrada com sucesso!");
        }
    }
}
