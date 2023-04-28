using ServiceWCFLogicaClientes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWCFLogicaClientes
{
    [ServiceContract]
    public interface IClienteContract
    {
        [OperationContract]
        List<Cliente> GetClientes();

        [OperationContract]
        Cliente FindCliente(int idcliente);
    }
}
