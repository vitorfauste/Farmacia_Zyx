using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Endereco
    {
        public int ID { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public Estado Estado { get; set; }

        public Endereco()
        {
            this.Estado = new Estado();
        }

        public override string ToString()
        {
            return this.Rua + "\r\n" +
                   this.Bairro + "\r\n" +
                   this.CEP + "\r\n" +
                   this.Numero + "\r\n" +
                   this.Complemento + "\r\n" +
                   this.Cidade + "\r\n" +
                   this.Estado.UF + "\r\n";
        }
    }
}
