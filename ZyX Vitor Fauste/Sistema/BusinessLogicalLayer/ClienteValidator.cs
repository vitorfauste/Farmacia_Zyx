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
    public class ClienteValidator
    {
        private StringValidator stringValidator = new StringValidator();
        private Normatization normatization = new Normatization();

        public Response Validate(Cliente cliente)
        {
            StringBuilder erros = new StringBuilder("");

            erros.Append(stringValidator.ValidateNome(cliente.Nome));
            erros.Append(stringValidator.ValidateCPF(cliente.CPF));
            erros.Append(stringValidator.ValidateEmail(cliente.Email));
            erros.Append(stringValidator.ValidateTelefone(cliente.Telefone));
            erros.Append(stringValidator.ValidateTelefone(cliente.Telefone2));
            erros.Append(stringValidator.ValidateRG(cliente.RG));

            if (erros.Length != 0)
            {
                return new Response(erros.ToString(), false);
            }
            cliente.Nome = normatization.NormatizarNome(cliente.Nome);
            return new Response("Cliente validado com sucesso.", true);
        }
    }
}
