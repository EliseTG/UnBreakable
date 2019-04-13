﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BibliotecaClase;

namespace BibliotecaControlador
{
    public class DaoCliente
    {
        private static List<Cliente> clientes;

        public DaoCliente()
        {
            if (clientes == null)
            {
                clientes = new List<Cliente>();
            }
        }

        //CRUD
        public bool Agregar(Cliente cli)
        {
            if (ExisteCliente(cli.Rut) == false)
            {
                clientes.Add(cli); return true;
            }
            return false;

        }

        //se creo con la ampolleta para comprobar si existe o no el cliente
        private bool ExisteCliente(string rut)
        {
            foreach (Cliente item in clientes)
            {
                if (item.Rut.Equals(rut))
                {
                    return true;
                }
            }
            return false;
        }

        //Listar
        public List<Cliente> Listar()
        {
            return clientes;
        }

    }
}