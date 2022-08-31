using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Shared;
namespace DataAcessLayer
{
    public class LoginDAL
    {
        public SingleResponse<Funcionario> UserExistsAndPasswordIsCorrect(string email, string senha)
        {
            string sql = $"SELECT * FROM FUNCIONARIOS WHERE EMAIL = @EMAIL";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@EMAIL", email);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.ID = Convert.ToInt32(reader["ID"]);
                    funcionario.Nome = Convert.ToString(reader["NOME"]);
                    funcionario.CPF = Convert.ToString(reader["CPF"]);
                    funcionario.RG = Convert.ToString(reader["RG"]);
                    funcionario.Telefone = Convert.ToString(reader["TELEFONE"]);
                    funcionario.Email = Convert.ToString(reader["EMAIL"]);
                    funcionario.Endereco.ID = Convert.ToInt32(reader["ENDERECO"]);
                    funcionario.Senha = Convert.ToString(reader["SENHA"]);
                    funcionario.IsAdmin = Convert.ToBoolean(reader["ISADMIN"]);
                    
                    if (senha != funcionario.Senha)
                    {
                        return new SingleResponse<Funcionario>("Usuário e/ou senha inválidos.", false, null);
                    }
                    return new SingleResponse<Funcionario>(funcionario.IsAdmin ? "Admin" : "", true, funcionario);

                }
                return new SingleResponse<Funcionario>("Usuário e/ou senha inválidos.", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Funcionario>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }

        //public DataResponse<Funcionario> ExistemFuncionarios()
        //{
        //    //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
        //    //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
        //    //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
        //    string sql = $"SELECT * FROM FUNCIONARIOS";

        //    string connectionString = ConnectionString.CONNECTION_STRING;

        //    SqlConnection connection = new SqlConnection(connectionString);

        //    SqlCommand command = new SqlCommand(sql, connection);

        //    //Estamos conectados na base de dados
        //    //try catch
        //    //try catch finally
        //    //try finally

        //    try
        //    {
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        //Enquanto houver registros, o loop será executado!
        //        List<Funcionario> funcionarios = new List<Funcionario>();
        //        while (reader.Read())
        //        {
        //            Funcionario funcionario = new Funcionario();
        //            funcionario.ID = Convert.ToInt32(reader["ID"]);
        //            funcionario.Nome = Convert.ToString(reader["NOME"]);
        //            funcionario.CPF = Convert.ToString(reader["CPF"]);
        //            funcionario.RG = Convert.ToString(reader["RG"]);
        //            funcionario.Telefone = Convert.ToString(reader["TELEFONE"]);
        //            funcionario.Email = Convert.ToString(reader["EMAIL"]);
        //            funcionario.Endereco.ID = Convert.ToInt32(reader["ENDERECO"]);
        //            funcionario.Senha = Convert.ToString(reader["SENHA"]);
        //            funcionario.IsAdmin = Convert.ToBoolean(reader["ISADMIN"]);

        //            funcionarios.Add(funcionario);
        //        }

        //        if (funcionarios.Count <= 0)
        //        {
        //            sql = $"INSERT INTO FUNCIONARIOS
        //        }
        //        return new DataResponse<Funcionario>("Já existem usuários cadastrados.", true, funcionarios);

        //    }
        //    catch (Exception ex)
        //    {
        //        return new DataResponse<Funcionario>("Erro no banco de dados, contate o administrador.", false, null);
        //    }
        //    finally
        //    {
        //        //Fecha a conexão
        //        connection.Dispose();
        //    }
        //}
    }
}
