using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ItemTransacao
    {
        public int IDTransacao { get; set; }
        public int IDProduto { get; set; }
        public double QuantidadeProduto { get; set; }
        public double ValorUnitario { get; set; }
    }
}
