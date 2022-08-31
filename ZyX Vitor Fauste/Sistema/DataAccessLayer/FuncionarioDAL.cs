using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;
using Shared;
using DataAcessLayer;

namespace DataAccessLayer
{
    public class FuncionarioDAL : ICRUD<Funcionario>
    {
        public Response Insert(Funcionario funcionario)
        {
            string sql = $"INSERT INTO FUNCIONARIOS (NOME,CPF,RG,EMAIL,ENDERECO,TELEFONE,SENHA,ISADMIN) VALUES " +
                         $"(@NOME,@CPF,@RG,@EMAIL,@ENDERECO,@TELEFONE,@SENHA,@ISADMIN)";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", funcionario.Nome);
            command.Parameters.AddWithValue("@CPF", funcionario.CPF);
            command.Parameters.AddWithValue("@RG", funcionario.RG);
            command.Parameters.AddWithValue("@EMAIL", funcionario.Email);
            command.Parameters.AddWithValue("@ENDERECO", funcionario.Endereco.ID);
            command.Parameters.AddWithValue("@TELEFONE", funcionario.Telefone);
            command.Parameters.AddWithValue("@SENHA", funcionario.Senha);
            command.Parameters.AddWithValue("@ISADMIN", Convert.ToByte(funcionario.IsAdmin));

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Funcionário cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FUNCIONARIOS_EMAIL"))
                {
                    return new Response("Este e-mail já está cadastrado.", false);
                }
                if (ex.Message.Contains("UQ_FUNCIONARIOS_CPF"))
                {
                    return new Response("Este CPF já está cadastrado.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Update(Funcionario funcionario)
        {
            string sql = $"UPDATE FUNCIONARIOS SET NOME = @NOME, RG = @RG, EMAIL = @EMAIL, ENDERECO = @ENDERECO, " +
                         $"TELEFONE = @TELEFONE, SENHA = @SENHA, ISADMIN = @ISADMIN WHERE ID = @ID";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", funcionario.ID);
            command.Parameters.AddWithValue("@NOME", funcionario.Nome);
            command.Parameters.AddWithValue("@RG", funcionario.RG);
            command.Parameters.AddWithValue("@EMAIL", funcionario.Email);
            command.Parameters.AddWithValue("@ENDERECO", funcionario.Endereco.ID);
            command.Parameters.AddWithValue("@TELEFONE", funcionario.Telefone);
            command.Parameters.AddWithValue("@SENHA", funcionario.Senha);
            command.Parameters.AddWithValue("@ISADMIN", Convert.ToByte(funcionario.IsAdmin));

            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Funcionário não alterado.", false);
                }
                return new Response("Funcionário alterado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FUNCIONARIOS_EMAIL"))
                {
                    return new Response("Este e-mail já está cadastrado.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Delete(int id)
        {
            string sql = "DELETE FROM FUNCIONARIOS WHERE ID = @ID";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            
            try
            {
                connection.Open();
                int qtdLinhasExcluidas = command.ExecuteNonQuery();
                if (qtdLinhasExcluidas == 1)
                {
                    return new Response("Funcionário excluído com sucesso.", true);
                }
                return new Response("Funcionário não excluído.", false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_VENDAS_FUNCIONARIOS") || ex.Message.Contains("FK_COMPRAS_FUNCIONARIOS"))
                {
                    return new Response("Não é possível deletar esse funcionário, pois já existe uma compra e/ou venda vinculada a ele.", false);
                }
                if (ex.Message.Contains("FK_ENDERECOS_FUNCIONARIOS"))
                {
                    return new Response("Não é possível deletar esse funcionário, pois já existe um endereço vinculado a ele.", false);
                }

                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<Funcionario> GetAll()
        {
            string sql = $"SELECT F.ID,F.NOME,F.CPF,F.RG,F.EMAIL,F.TELEFONE,F.SENHA,F.ISADMIN,E.ID AS 'ID_ENDERECO'," +
                         $"E.CEP,E.RUA,E.NUMERO,E.CIDADE,E.ESTADO,E.COMPLEMENTO,E.BAIRRO " +
                         $"FROM FUNCIONARIOS F INNER JOIN ENDERECOS E ON F.ENDERECO = E.ID";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Funcionario> funcionarios = new List<Funcionario>();
                while (reader.Read())
                {
                    Funcionario funcionario = new Funcionario();

                    //Dados pessoais
                    funcionario.ID = Convert.ToInt32(reader["ID"]);
                    funcionario.Nome = Convert.ToString(reader["NOME"]);
                    funcionario.CPF = Convert.ToString(reader["CPF"]);
                    funcionario.RG = Convert.ToString(reader["RG"]);
                    funcionario.Telefone = Convert.ToString(reader["TELEFONE"]);
                    funcionario.Email = Convert.ToString(reader["EMAIL"]);
                    funcionario.Senha = Convert.ToString(reader["SENHA"]);
                    funcionario.IsAdmin = Convert.ToBoolean(reader["ISADMIN"]);

                    //Dados do endereço
                    funcionario.Endereco.ID = Convert.ToInt32(reader["ID_ENDERECO"]);
                    funcionario.Endereco.CEP = Convert.ToString(reader["CEP"]);
                    funcionario.Endereco.Rua = Convert.ToString(reader["RUA"]);
                    funcionario.Endereco.Bairro = Convert.ToString(reader["BAIRRO"]);
                    funcionario.Endereco.Numero = Convert.ToString(reader["NUMERO"]);
                    funcionario.Endereco.Cidade = Convert.ToString(reader["CIDADE"]);
                    funcionario.Endereco.Estado.ID = Convert.ToInt32(reader["ESTADO"]);
                    funcionario.Endereco.Complemento = Convert.ToString(reader["COMPLEMENTO"]);

                    funcionarios.Add(funcionario);
                }
                return new DataResponse<Funcionario>("Funcionários selecionados com sucesso!", true, funcionarios);
            }
            catch (Exception ex)
            {
                return new DataResponse<Funcionario>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }


        public SingleResponse<Funcionario> GetByID(int id)
        {
            string sql = $"SELECT F.ID,F.NOME,F.CPF,F.RG,F.EMAIL,F.TELEFONE,F.SENHA,F.ISADMIN,E.ID AS 'ID_ENDERECO'," +
                         $"E.CEP,E.RUA,E.NUMERO,E.CIDADE,E.ESTADO,E.COMPLEMENTO,E.BAIRRO " +
                         $"FROM FUNCIONARIOS F INNER JOIN ENDERECOS E ON F.ENDERECO = E.ID WHERE F.ID = @ID";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Funcionario funcionario = new Funcionario();

                    //Dados pessoais
                    funcionario.ID = Convert.ToInt32(reader["ID"]);
                    funcionario.Nome = Convert.ToString(reader["NOME"]);
                    funcionario.CPF = Convert.ToString(reader["CPF"]);
                    funcionario.RG = Convert.ToString(reader["RG"]);
                    funcionario.Telefone = Convert.ToString(reader["TELEFONE"]);
                    funcionario.Email = Convert.ToString(reader["EMAIL"]);
                    funcionario.Senha = Convert.ToString(reader["SENHA"]);
                    funcionario.IsAdmin = Convert.ToBoolean(reader["ISADMIN"]);

                    //Dados do endereço
                    funcionario.Endereco.ID = Convert.ToInt32(reader["ID_ENDERECO"]);
                    funcionario.Endereco.CEP = Convert.ToString(reader["CEP"]);
                    funcionario.Endereco.Rua = Convert.ToString(reader["RUA"]);
                    funcionario.Endereco.Bairro = Convert.ToString(reader["BAIRRO"]);
                    funcionario.Endereco.Numero = Convert.ToString(reader["NUMERO"]);
                    funcionario.Endereco.Cidade = Convert.ToString(reader["CIDADE"]);
                    funcionario.Endereco.Estado.ID = Convert.ToInt32(reader["ESTADO"]);
                    funcionario.Endereco.Complemento = Convert.ToString(reader["COMPLEMENTO"]);

                    return new SingleResponse<Funcionario>("Funcionários selecionados com sucesso!", true, funcionario);
                }
                return new SingleResponse<Funcionario>("Funcionários não encontrado.", true, null);
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

        public SingleResponse<int> GetEnderecoID(int IDFuncionario)
        {
            string sql = $"SELECT ENDERECO FROM FUNCIONARIOS WHERE ID = @ID";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", IDFuncionario);
            try
            {
                connection.Open();
                int enderecoID = Convert.ToInt32(command.ExecuteScalar());
                return new SingleResponse<int>("ID do endereço obtido com sucesso.", true, enderecoID);
            }
            catch (Exception ex)
            {

                return new SingleResponse<int>("Erro no banco de dados, contate o administrador." + ex, false, 0);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}