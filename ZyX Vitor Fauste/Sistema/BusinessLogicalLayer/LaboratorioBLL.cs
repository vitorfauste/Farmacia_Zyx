using DataAccessLayer;
using Entities;
using Shared;
using System.Transactions;

namespace BusinessLogicalLayer
{
    public class LaboratorioBLL
    {
        LaboratorioDAL laboratorioDAL = new LaboratorioDAL();
        private Response Validate(Laboratorio laboratorio)
        {
            LaboratorioValidator laboratorioValidator = new LaboratorioValidator();
            return laboratorioValidator.Validate(laboratorio);
        }

        public Response Insert(Laboratorio laboratorio)
        {
            Response response = Validate(laboratorio);
            if (response.HasSuccess)
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    response = laboratorioDAL.Insert(laboratorio);
                    if (!response.HasSuccess)
                    {
                        return response;
                    }
                    scope.Complete();
                }//scope.Dispose();
            }
            return response;
        }

        public Response Update(Laboratorio laboratorio)
        {
            Response response = Validate(laboratorio);
            if (response.HasSuccess)
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    response = laboratorioDAL.Update(laboratorio);
                    if (!response.HasSuccess)
                    {
                        return response;
                    }
                    scope.Complete();
                }//scope.Dispose();
            }
            return response;
        }

        public Response Delete(Laboratorio laboratorio)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Response response = laboratorioDAL.Delete(laboratorio.ID);
                if (!response.HasSuccess)
                {
                    return response;
                }
                scope.Complete();
                return response;
            }//scope.Dispose();
        }

        public DataResponse<Laboratorio> GetAll()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                DataResponse<Laboratorio> dataResponse = laboratorioDAL.GetAll();
                if (!dataResponse.HasSuccess)
                {
                    return dataResponse;
                }
                scope.Complete();
                return dataResponse;
            }//scope.Dispose();

        }

        public SingleResponse<Laboratorio> GetById(int id)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                SingleResponse<Laboratorio> singleResponse = laboratorioDAL.GetByID(id);
                if (!singleResponse.HasSuccess)
                {
                    return singleResponse;
                }
                scope.Complete();
                return singleResponse;
            }//scope.Dispose();
        }

        //public Response Deactivate(Laboratorio laboratorio)
        //{
        //    using (TransactionScope scope = new TransactionScope())
        //    {
        //        LaboratorioDAL laboratorioDAL = new LaboratorioDAL();
        //        Response response = laboratorioDAL.Delete(laboratorio.ID);
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