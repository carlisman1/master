using ServiceWCFLogicaClientes.Model;
using ServiceWCFLogicaClientes.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWCFLogicaClientes
{
    public class ClientesClass : IClienteContract
    {
        private RepositoryClientes repo;

        public ClientesClass()
        {
            this.repo = new RepositoryClientes();
        }

        public Cliente FindCliente(int idcliente)
        {
            return this.repo.FindCliente(idcliente);
        }

        public List<Cliente> GetClientes()
        {
            return this.repo.GetClientes();
        }
    }
}