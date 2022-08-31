using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Funcionario
    {
        public Funcionario()
        {
            this.Endereco = new Endereco();
        }
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public bool IsAdmin { get; set; }
    }
}
