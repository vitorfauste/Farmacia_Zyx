using DataAccessLayer;
using Entities;
using Shared;
using System.Transactions;

namespace BusinessLogicalLayer
{
    public class FormaPagamentoBLL
    {
        FormaPagamentoDAL formaPagamentoDAL = new FormaPagamentoDAL();

        public Response Insert(FormaPagamento formaPagamento)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Response response = formaPagamentoDAL.Insert(formaPagamento);
                if (!response.HasSuccess)
                {
                    return response;
                }
                scope.Complete();
                return response;
            }//scope.Dispose();
        }
    

        public Response Update(FormaPagamento formaPagamento)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Response response = formaPagamentoDAL.Update(formaPagamento);
                if (!response.HasSuccess)
                {
                    return response;
                }
                scope.Complete();
                return response;
            }//scope.Dispose();
        }

        public Response Delete(FormaPagamento formaPagamento)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Response response = formaPagamentoDAL.Delete(formaPagamento.ID);
                if (!response.HasSuccess)
                {
                    return response;
                }
                scope.Complete();
                return response;
            }//scope.Dispose();
        }

        public DataResponse<FormaPagamento> GetAll()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                DataResponse<FormaPagamento> dataResponse = formaPagamentoDAL.GetAll();
                if (!dataResponse.HasSuccess)
                {
                    return dataResponse;
                }
                scope.Complete();
                return dataResponse;
            }//scope.Dispose();

        }

        public SingleResponse<FormaPagamento> GetById(int id)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                SingleResponse<FormaPagamento> singleResponse = formaPagamentoDAL.GetByID(id);
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