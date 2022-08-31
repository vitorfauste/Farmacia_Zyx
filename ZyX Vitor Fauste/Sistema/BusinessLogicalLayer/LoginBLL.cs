using DataAcessLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class LoginBLL
    {
        LoginDAL dal = new LoginDAL();

        public SingleResponse<Funcionario> UserExistsAndPasswordIsCorrect(string email, string senha)
        {
            return dal.UserExistsAndPasswordIsCorrect(email, senha);
        }
    }
}
