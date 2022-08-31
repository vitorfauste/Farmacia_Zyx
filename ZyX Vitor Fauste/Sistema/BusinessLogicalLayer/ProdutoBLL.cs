using DataAccessLayer;
using Entities;
using Shared;
using System.Transactions;

namespace BusinessLogicalLayer
{
    public class ProdutoBLL
    {
        ProdutoDAL produtoDAL = new ProdutoDAL();
        private Response Validate(Produto produto)
        {
            ProdutoValidator produtoValidator = new ProdutoValidator();
            return produtoValidator.Validate(produto);
        }

        public Response Insert(Produto produto)
        {
            Response response = Validate(produto);
            if (response.HasSuccess)
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    response = produtoDAL.Insert(produto);
                    if (!response.HasSuccess)
                    {
                        return response;
                    }
                    scope.Complete();
                }//scope.Dispose();
            }
            return response;
        }

        public Response Update(Produto produto)
        {
            Response response = Validate(produto);
            if (response.HasSuccess)
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    response = produtoDAL.Update(produto);
                    if (!response.HasSuccess)
                    {
                        return response;
                    }
                    scope.Complete();
                }//scope.Dispose();
            }
            return response;
        }

        public Response Delete(Produto produto)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Response response = produtoDAL.Delete(produto.ID);
                if (!response.HasSuccess)
                {
                    return response;
                }
                scope.Complete();
                return response;
            }//scope.Dispose();
        }

        public DataResponse<Produto> GetAll()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                DataResponse<Produto> dataResponse = produtoDAL.GetAll();
                if (!dataResponse.HasSuccess)
                {
                    return dataResponse;
                }
                scope.Complete();
                return dataResponse;
            }//scope.Dispose();

        }

        public SingleResponse<Produto> GetById(int id)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                SingleResponse<Produto> singleResponse = produtoDAL.GetByID(id);
                if (!singleResponse.HasSuccess)
                {
                    return singleResponse;
                }
                scope.Complete();
                return singleResponse;
            }//scope.Dispose();
        }

        //public Response Deactivate(Produto produto)
        //{
        //    using (TransactionScope scope = new TransactionScope())
        //    {
        //        ProdutoDAL produtoDAL = new ProdutoDAL();
        //        Response response = produtoDAL.Delete(produto.ID);
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