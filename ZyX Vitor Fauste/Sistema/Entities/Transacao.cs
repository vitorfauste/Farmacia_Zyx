using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Transacao
    {
        public int ID { get; set; }
        public int IDFuncionario { get; set; }
        public int FormaPagamento { get; set; }
        public DateTime DataTransacao { get; set; }
        public double ValorTotal { get; set; }
        public List<ItemTransacao> Itens { get; set; }

        public Transacao()
        {
            this.Itens = new List<ItemTransacao>();
        }
    }
}
