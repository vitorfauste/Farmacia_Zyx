using DataAccessLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class FornecedorValidator
    {
        private StringValidator stringValidator = new StringValidator();
        private Normatization normatization = new Normatization();
        public Response Validate(Fornecedor fornecedor)
        {
            StringBuilder erros = new StringBuilder("");

            erros.Append(stringValidator.ValidateRazaoSocial(fornecedor.RazaoSocial));
            erros.Append(stringValidator.ValidateCNPJ(fornecedor.CNPJ));
            erros.Append(stringValidator.ValidateEmail(fornecedor.Email));
            erros.Append(stringValidator.ValidateTelefone(fornecedor.Telefone));
            erros.Append(stringValidator.ValidateNomeVazio(fornecedor.NomeContato));

            if (erros.Length != 0)
            {
                return new Response(erros.ToString(), false);
            }

            fornecedor.RazaoSocial = normatization.NormatizarNome(fornecedor.RazaoSocial);
            fornecedor.NomeContato = normatization.NormatizarNome(fornecedor.NomeContato);
            return new Response("Fornecedor validado com sucesso.", true);
        }
    }
}
