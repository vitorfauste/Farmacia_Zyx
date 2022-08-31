using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class ProdutoValidator
    {
        StringValidator stringValidator = new StringValidator();
        Normatization normatization = new Normatization();
        public Response Validate(Produto produto)
        {
            StringBuilder erros = new StringBuilder("");

            erros.Append(stringValidator.ValidateNomeVazio(produto.Nome));
            erros.Append(stringValidator.ValidateDescricaoVazia(produto.Descricao));

            if (erros.Length != 0)
            {
                return new Response(erros.ToString(), false);
            }

            produto.Nome = normatization.NormatizarNome(produto.Nome);
            produto.Descricao = normatization.NormatizarTexto(produto.Descricao);
            return new Response("Produto validado com sucesso.", true);
        }

    }
}
