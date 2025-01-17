﻿using Comex.Modelos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Comex.Funcionalidades
{
    internal class ListaClientes : Funcionalidade
    {
        private Dictionary<string, Cliente> BancoDeClientes;

        public ListaClientes(Dictionary<string, Cliente> bancoDeClientes)
        {
            BancoDeClientes = bancoDeClientes;
        }

        public override Task Executa(Dictionary<int, Funcionalidade> opcoes)
        {
            base.Executa(opcoes);
            ExibeTitulo("Lista de Clientes");

            if (BancoDeClientes.Count > 0)
            {
                foreach (var cliente in BancoDeClientes.Values)
                {
                    Console.WriteLine($"Nome: {cliente.Nome}, E-mail: {cliente.Email}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
            }

            return Task.CompletedTask;
        }
    }
}
