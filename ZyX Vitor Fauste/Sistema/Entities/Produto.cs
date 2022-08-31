using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Produto
    {
        // Fórmula pára cálculo do novo valor do produto ao entrar produtos com valores diferentes:
        // ((precoAntigo * estoqueAntigo) + (precoNovo*EstoqueNovo)) / (estoqueVelho + estoqueNovo)
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Laboratorio Laboratorio { get; set; }
        public double QuantiaEmEstoque { get; set; }
        public double Lucro { get; set; }
        public double ValorUnitario { get; set; }

        public Produto()
        {
            this.Laboratorio = new Laboratorio();
        }
    }
}
