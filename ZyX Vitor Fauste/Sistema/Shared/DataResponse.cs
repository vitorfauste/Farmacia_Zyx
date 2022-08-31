using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class DataResponse<T> : Response
    {
        public DataResponse(string message, bool hasSuccess, List<T> dados) : base(message, hasSuccess)
        {
            this.Dados = dados;
        }
        public List<T> Dados { get; private set; }
    }
}
