using Shared;
using Entities;
using DataAcessLayer;
using System.Transactions;
using DataAccessLayer;

namespace BusinessLogicalLayer
{
    public class FuncionarioBLL
    {
        FuncionarioDAL funcionarioDAL = new FuncionarioDAL();
        EnderecoDAL enderecoDAL = new EnderecoDAL();
        
        private Response ValidateBLL(Funcionario funcionario)
        {
            FuncionarioValidator funcionarioValidator = new FuncionarioValidator();
            return funcionarioValidator.Validate(funcionario);
        }

        public Response Insert(Funcionario funcionario)
        {
            Response response = ValidateBLL(funcionario);
            if (response.HasSuccess)
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    //INSERE UM ENDEREÇO NO BANCO E JÁ VINCULA O ID DESTE ENDEREÇO COM O SELECT NO BANCO 
                    Response responseEndereco = enderecoDAL.Insert(funcionario.Endereco);
                    response = funcionarioDAL.Insert(funcionario);
                    if (!response.HasSuccess || !responseEndereco.HasSuccess)
                    {
                        return response;
                    }
                    scope.Complete();
                }//scope.Dispose();
            }
            return response;
        }

        public Response Update(Funcionario funcionario)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                 FuncionarioDAL funcionarioDAL = new FuncionarioDAL();
                 EnderecoDAL enderecoDAL = new EnderecoDAL();
                 //INSERE UM ENDEREÇO NO BANCO E JÁ VINCULA O ID DESTE ENDEREÇO COM O SELECT NO BANCO 
                 Response responseEndereco = enderecoDAL.Update(funcionario.Endereco);
                 Response response = funcionarioDAL.Update(funcionario);
                 if (!response.HasSuccess || !responseEndereco.HasSuccess)
                 {
                     return response;
                 }
                 scope.Complete();
                 return response;
            }
        }
        public Response Delete(Funcionario funcionario)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Response response = funcionarioDAL.Delete(funcionario.ID);
                if (!response.HasSuccess)
                {
                    return response;
                }
                scope.Complete();
                return response;
            }//scope.Dispose();
        }

        public DataResponse<Funcionario> GetAll()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                DataResponse<Funcionario> dataResponse = funcionarioDAL.GetAll();
                if (!dataResponse.HasSuccess)
                {
                    return dataResponse;
                }
                scope.Complete();
                return dataResponse;
            }//scope.Dispose();

        }

        public SingleResponse<Funcionario> GetById(int id)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                SingleResponse<Funcionario> singleResponse = funcionarioDAL.GetByID(id);
                if (!singleResponse.HasSuccess)
                {
                    return singleResponse;
                }
                scope.Complete();
                return singleResponse;
            }//scope.Dispose();
        }

        public SingleResponse<int> GetEnderecoID(int id)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                SingleResponse<int> singleResponse = funcionarioDAL.GetEnderecoID(id);
                if (!singleResponse.HasSuccess)
                {
                    return singleResponse;
                }
                scope.Complete();
                return singleResponse;
            }
        }
    }
}