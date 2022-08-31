using DataAccessLayer;
using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer
{
    //Projeto (Assembly) > Namespace > classe

    public class FuncionarioValidator
    {
        private StringValidator stringValidator = new StringValidator();
        private Normatization normatization = new Normatization();

        public Response Validate(Funcionario funcionario)
        {
            StringBuilder erros = new StringBuilder("");

            erros.Append(stringValidator.ValidateNome(funcionario.Nome));
            erros.Append(stringValidator.ValidateCPF(funcionario.CPF));
            erros.Append(stringValidator.ValidateEmail(funcionario.Email));
            erros.Append(stringValidator.ValidateTelefone(funcionario.Telefone));
            //Sintaxe funcionario.Endereco?.CEP verifica e só passaria o CEP informado caso a propriedade
            //Endereco de dentro do Funcionario não seja nula, caso contrário, passará o valor
            //padrão do CEP (que é uma string e vale null!)
            erros.Append(stringValidator.ValidateCEP(funcionario.Endereco?.CEP));

            //Se encontramos erro
            if (erros.Length != 0)
            {
                return new Response(erros.ToString(), false);
            }

            //Se chegou aqui, validamos com sucesso!
            funcionario.Nome = normatization.NormatizarNome(funcionario.Nome);
            return new Response("Funcionário validado com sucesso.", true);
        }
    }
}