using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class LaboratorioValidator
    {
        StringValidator stringValidator = new StringValidator();
        Normatization normatization = new Normatization();
        public Response Validate(Laboratorio laboratorio)
        {
            StringBuilder erros = new StringBuilder("");

            erros.Append(stringValidator.ValidateRazaoSocial(laboratorio.RazaoSocial));
            erros.Append(stringValidator.ValidateCNPJ(laboratorio.CNPJ));

            if (erros.Length != 0)
            {
                return new Response(erros.ToString(), false);
            }

            laboratorio.RazaoSocial = normatization.NormatizarNome(laboratorio.RazaoSocial);
            return new Response("Laboratório validado com sucesso.", true);
        }
        
    }
}
