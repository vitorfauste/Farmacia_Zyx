using Shared;
using Entities;
using DataAcessLayer;
using System.Transactions;
using DataAccessLayer;

namespace BusinessLogicalLayer
{
    public class EnderecoBLL
    {
        EnderecoDAL enderecoDAL = new EnderecoDAL();

        private Response ValidateBLL(Endereco endereco)
        {
            EnderecoValidator enderecoValidator = new EnderecoValidator();
            return enderecoValidator.Validate(endereco);
        }

        public Response Insert(Endereco endereco)
        {
            Response response = ValidateBLL(endereco);
            if (response.HasSuccess)
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    response = enderecoDAL.Insert(endereco);
                    if (!response.HasSuccess)
                    {
                        return response;
                    }
                    scope.Complete();
                }
            }
            return response;
        }

        public Response Update(Endereco endereco)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Response response = enderecoDAL.Update(endereco);
                if (!response.HasSuccess)
                {
                    return response;
                }
                scope.Complete();
                return response;

            }
        }
        public Response Delete(Endereco endereco)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Response response = enderecoDAL.Delete(endereco.ID);
                if (!response.HasSuccess)
                {
                    return response;
                }
                scope.Complete();
                return response;
            }
        }

        //public DataResponse<Endereco> GetAll()
        //{
        //    using (TransactionScope scope = new TransactionScope())
        //    {
        //        DataResponse<Endereco> dataResponse = enderecoDAL.GetAll();
        //        if (!dataResponse.HasSuccess)
        //        {
        //            return dataResponse;
        //        }
        //        scope.Complete();
        //        return dataResponse;
        //    }
        //}

        public DataResponse<Estado> GetAllEstados()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                DataResponse<Estado> dataResponse = enderecoDAL.GetAllEstados();
                if (!dataResponse.HasSuccess)
                {
                    return dataResponse;
                }
                scope.Complete();
                return dataResponse;
            }
        }

        public SingleResponse<Endereco> GetById(int id)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                SingleResponse<Endereco> singleResponse = enderecoDAL.GetByID(id);
                if (!singleResponse.HasSuccess)
                {
                    return singleResponse;
                }
                scope.Complete();
                return singleResponse;
            }//scope.Dispose();
        }
    }
}