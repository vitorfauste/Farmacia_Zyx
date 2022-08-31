using DataAccessLayer;
using Entities;
using Shared;
using System.Transactions;

namespace BusinessLogicalLayer
{
    public class FornecedorBLL
    {
        FornecedorDAL fornecedorDAL = new FornecedorDAL();
        private Response Validate(Fornecedor fornecedor)
        {
            FornecedorValidator fornecedorValidator = new FornecedorValidator();
            return fornecedorValidator.Validate(fornecedor);
        }

        public Response Insert(Fornecedor fornecedor)
        {
            Response response = Validate(fornecedor);
            if (response.HasSuccess)
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    response = fornecedorDAL.Insert(fornecedor);
                    if (!response.HasSuccess)
                    {
                        return response;
                    }
                    scope.Complete();
                }//scope.Dispose();
            }
            return response;
        }

        public Response Update(Fornecedor fornecedor)
        {
            Response response = Validate(fornecedor);
            if (response.HasSuccess)
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    response = fornecedorDAL.Update(fornecedor);
                    if (!response.HasSuccess)
                    {
                        return response;
                    }
                    scope.Complete();
                }//scope.Dispose();
            }
            return response;
        }

        public Response Delete(Fornecedor fornecedor)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Response response = fornecedorDAL.Delete(fornecedor.ID);
                if (!response.HasSuccess)
                {
                    return response;
                }
                scope.Complete();
                return response;
            }//scope.Dispose();
        }

        public DataResponse<Fornecedor> GetAll()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                DataResponse<Fornecedor> dataResponse = fornecedorDAL.GetAll();
                if (!dataResponse.HasSuccess)
                {
                    return dataResponse;
                }
                scope.Complete();
                return dataResponse;
            }//scope.Dispose();

        }

        public SingleResponse<Fornecedor> GetById(int id)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                SingleResponse<Fornecedor> singleResponse = fornecedorDAL.GetByID(id);
                if (!singleResponse.HasSuccess)
                {
                    return singleResponse;
                }
                scope.Complete();
                return singleResponse;
            }//scope.Dispose();
        }

        //public Response Deactivate(Fornecedor fornecedor)
        //{
        //    using (TransactionScope scope = new TransactionScope())
        //    {
        //        FornecedorDAL fornecedorDAL = new FornecedorDAL();
        //        Response response = fornecedorDAL.Delete(fornecedor.ID);
        //        if (!response.HasSuccess)
        //        {
        //            return response;
        //        }
        //        return response;
        //        scope.Complete();
        //    }//scope.Dispose();
        //}
    }
}