using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    internal class StringValidator
    {
        /// <summary>
        /// Verifica algumas regras para o nome, como:
        /// 1)Apenas alfabeto romano
        /// 2)Apenas um espaço entre nome e sobrenome
        /// 3)Mínimo de 3 caracteres
        /// 4)Mínimo de 2 entre nome e sobrenome
        /// </summary>
        /// <param name="nome">Nome a ser validado</param>
        /// <returns>Retorna vazio "" caso o nome esteja correto</returns>
        public string ValidateNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return "Nome deve ser informado.\r\n";
            }
            //Trim -> Remove espaços em branco do começo e do fim da string (mas não do meio)
            nome = nome.Trim();

            //Função que remove os espaços extra entre as strings (deixando apenas um)
            nome = Regex.Replace(nome, @"\s+", " ");

            if (nome.Length < 3)
            {
                return "Nome deve conter no mínimo 3 caracteres.\r\n";
            }
            string[] nomes = nome.Split(" ");
            if (nomes.Length <= 1)
            {
                return "Nome completo deve ser informado.\r\n";
            }

            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i].Length < 2)
                {
                    return "Nome/sobrenome deve possuir, ao menos, 2 caracteres.\r\n";
                }
            }
            //Alfabeto romano e acentos gráficos
            string regex = @"^[a-zA-Záâãéêíïóõôüúç ÁÂÃÉÊÍÏÓÔÜÚÇ]+$";
            if (!Regex.IsMatch(nome, regex))
            {
                return "Nome deve conter apenas caracteres do alfabeto romano.\r\n";
            }

            if (nome.Length > 100)
            {
                return "Nome não pode conter mais que 100 caracteres.\r\n";
            }

            //Se chegou aqui, o nome ta certinho e retornamos "";
            return "";
        }

        public string ValidateRazaoSocial(string razaoSocial)
        {
            if (string.IsNullOrWhiteSpace(razaoSocial))
            {
                return "Razão social deve ser informada.\r\n";
            }
            //Trim -> Remove espaços em branco do começo e do fim da string (mas não do meio)
            razaoSocial = razaoSocial.Trim();

            //Função que remove os espaços extra entre as strings (deixando apenas um)
            razaoSocial = Regex.Replace(razaoSocial, @"\s+", " ");

            if (razaoSocial.Length < 3)
            {
                return "Razão social deve conter, no mínimo, 3 caracteres.\r\n";
            }

            //Alfabeto romano e acentos gráficos
            string regex = @"^[a-zA-Záâãéêíïóõôüúç ÁÂÃÉÊÍÏÓÔÜÚÇ]+$";
            if (!Regex.IsMatch(razaoSocial, regex))
            {
                return "Razão social deve conter apenas caracteres do alfabeto romano.\r\n";
            }

            if (razaoSocial.Length > 100)
            {
                return "Razão social não pode conter mais que 100 caracteres.\r\n";
            }

            //Se chegou aqui, a razão social ta certinho e retornamos "";
            return "";
        }

        /// <summary>
        /// Executa validação de CNPJ utilizando as regras disponibilizadas pela Receita Federal
        /// </summary>
        /// <param name="cnpj">CNPJ a ser validado</param>
        /// <returns>Retorna "" se o CNPJ está válido, caso contrário retorna a mensagem de erro</returns>
        public string ValidateCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return "CNPJ deve ter 14 dígitos.\r\n";
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            if (!cnpj.EndsWith(digito))
            {
                return "CNPJ inválido.\r\n";
            };
            return "";
        }

        public string ValidateRG(string rg)
        {
            if (string.IsNullOrWhiteSpace(rg))
            {
                return "RG deve ser informado\r\n";
            }
            return "";
        }

        /// <summary>
        /// Executa validação de CPF utilizando as regras disponibilizadas pela Receita Federal
        /// </summary>
        /// <param name="cpf">CPF a ser validado</param>
        /// <returns>Retorna "" se o CPF está válido, caso contrário retorna a mensagem de erro</returns>
        public string ValidateCPF(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
            {
                return "CPF deve ser informado.\r\n";
            }

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return "CPF deve conter 11 caracteres.\r\n";
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            bool ehValido = cpf.EndsWith(digito);
            if (!ehValido)
            {
                return "CPF com formato inválido.\r\n";
            }
            return "";
        }

        public string ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return "E-mail deve ser informado.\r\n";
            }

            email = email.Trim();

            if (email.Length < 5)
            {
                return "E-mail não pode conter menos que 5 caracteres.\r\n";
            }

            if (email.Length > 100)
            {
                return "E-mail não pode conter mais que 100 caracteres.\r\n";
            }

            if (!email.Contains("@"))
            {
                return "E-mail inválido.";
            }

            //string pattern = @"^([\w\.\-] +)@([\w\-] +)((\.(\w){ 2,3})+)$";
            //if (!Regex.IsMatch(email, pattern))
            //{
            //    return "E-mail inválido.\r\n";
            //}
            return "";
        }

        public string ValidateCEP(string cep)
        {
            if (string.IsNullOrWhiteSpace(cep))
            {
                return "CEP deve ser informado.\r\n";
            }
            //Remove espaços em branco do inicio e fim da string
            cep = cep.Trim();
            //Substitui - e . por "" (vazio)
            cep = cep.Replace("-", "").Replace(".", "");

            if (cep.Length != 8)
            {
                return "CEP deve conter 8 dígitos (sem considerar hífen/ponto).\r\n";
            }

            int temp = 0;
            if (!int.TryParse(cep, out temp))
            {
                //Se a conversão não funcionar
                return "CEP em formato incorreto.\r\n";
            }

            return "";
        }

        public string ValidateTelefone(string telefone)
        {
            if (string.IsNullOrWhiteSpace(telefone))
            {
                return "Telefone deve ser informado.\r\n";
            }
            telefone = telefone.Trim();

            telefone = telefone.Replace("(", "")
                               .Replace(")", "")
                               .Replace("-", "")
                               .Replace(" ", "")
                               .Replace(".", "")
                               .Replace("+", "");

            long temp;
            if (!long.TryParse(telefone, out temp))
            {
                return "Telefone inválido.\r\n";
            }
            return "";
        }

        public string ValidateSenha(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha))
            {
                return "Senha não pode ser vazia.\r\n";
            }
            if (senha.Length < 5 || senha.Length > 20)
            {
                return "Senha deve conter entre 5 e 20 caracteres.\r\n";
            }
            return "";
        }

        public string ValidateNomeVazio(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "Nome deve ser informado.\r\n";
            }
            return "";
        }

        public string ValidateDescricaoVazia(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "Descrição deve ser informada.\r\n";
            }
            return "";
        }

        public string ValidateRuaVazia(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "Rua deve ser informada.\r\n";
            }
            return "";
        }

        public string ValidateBairroVazio(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "Bairro deve ser informado.\r\n";
            }
            return "";
        }

        public string ValidateNumeroVazio(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "Número deve ser informado.\r\n";
            }
            return "";
        }

        public string ValidateCidadeVazia(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "Cidade deve ser informada.\r\n";
            }
            return "";
        }

    }
}
