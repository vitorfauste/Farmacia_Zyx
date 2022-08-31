using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class EnderecoValidator
    {
        StringValidator stringValidator = new StringValidator();
        Normatization normatization = new Normatization();
        public Response Validate(Endereco endereco)
        {
            StringBuilder erros = new StringBuilder("");

            erros.Append(stringValidator.ValidateBairroVazio(endereco.Bairro));
            erros.Append(stringValidator.ValidateRuaVazia(endereco.Rua));
            erros.Append(stringValidator.ValidateNumeroVazio(endereco.Numero));
            erros.Append(stringValidator.ValidateCidadeVazia(endereco.Cidade));
            erros.Append(stringValidator.ValidateCEP(endereco.CEP));

            if (erros.Length != 0)
            {
                return new Response(erros.ToString(), false);
            }

            endereco.Bairro = normatization.NormatizarTexto(endereco.Bairro);
            endereco.Bairro = normatization.NormatizarTexto(endereco.Rua);
            endereco.Bairro = normatization.NormatizarTexto(endereco.Cidade);

            return new Response("Endereço validado com sucesso.", true);
        }

    }
}
