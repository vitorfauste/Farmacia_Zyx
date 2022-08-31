using DataAccessLayer;
using Entities;
using Shared;
using System.Transactions;

namespace BusinessLogicalLayer
{
    public class ClienteBLL
    {
        ClienteDAL clienteDAL = new ClienteDAL();
        private Response Validate(Cliente cliente)
        {
            ClienteValidator clienteValidator = new ClienteValidator();
            return clienteValidator.Validate(cliente);
        }

        public Response Insert(Cliente cliente)
        {
            Response response = Validate(cliente);
            if (response.HasSuccess)
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    response = clienteDAL.Insert(cliente);
                    if (!response.HasSuccess)
                    {
                        return response;
                    }
                    scope.Complete();
                }//scope.Dispose();
            }
            return response;
        }

        public Response Update(Cliente cliente)
        {
            Response response = Validate(cliente);
            if (response.HasSuccess)
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    response = clienteDAL.Update(cliente);
                    if (!response.HasSuccess)
                    {
                        return response;
                    }
                    scope.Complete();
                }//scope.Dispose();
            }
            return response;
        }

        public Response Delete(Cliente cliente)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Response response = clienteDAL.Delete(cliente.ID);
                if (!response.HasSuccess)
                {
                    return response;
                }
                scope.Complete();
                return response;
            }//scope.Dispose();
        }

        public DataResponse<Cliente> GetAll()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                DataResponse<Cliente> dataResponse = clienteDAL.GetAll();
                if (!dataResponse.HasSuccess)
                {
                    return dataResponse;
                }
                scope.Complete();
                return dataResponse;
            }//scope.Dispose();
         
        }

        public SingleResponse<Cliente> GetById(int id)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                SingleResponse<Cliente> singleResponse = clienteDAL.GetByID(id);
                if (!singleResponse.HasSuccess)
                {
                    return singleResponse;
                }
                scope.Complete();
                return singleResponse;
            }//scope.Dispose();
        }

        public Response AumentarPontos(Cliente item, double Valor)
        {
            int pontos = (int)Valor / 10;
            item.PontosFidelidade += pontos;
            return clienteDAL.UpdatePontos(item);
        }

        public double VerifyIfHasDesconto(Cliente cliente)
        {
            if (cliente.PontosFidelidade >= 10)
            {
                return 10;
            }
            return 0;
        }
    }
}