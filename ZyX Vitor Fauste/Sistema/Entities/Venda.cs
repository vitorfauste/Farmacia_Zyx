using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Venda : Transacao
    {
        public int IDCliente { get; set; }
        public Venda()
        {
            this.Itens = new List<ItemTransacao>();
        }
    }
}
