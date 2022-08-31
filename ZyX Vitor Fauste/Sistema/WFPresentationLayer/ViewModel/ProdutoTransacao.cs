using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPresentationLayer.ViewModel
{
    public class ProdutoTransacao
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Laboratorio Laboratorio { get; set; }
        public double Quantidade { get; set; }
        public double Lucro { get; set; }
        public double ValorUnitario { get; set; }

        public ProdutoTransacao()
        {
            this.Laboratorio = new Laboratorio();
        }
    }
}
