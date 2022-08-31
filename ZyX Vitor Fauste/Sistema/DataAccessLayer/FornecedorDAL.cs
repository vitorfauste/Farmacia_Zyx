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
    public class FornecedorDAL : ICRUD<Fornecedor>
    {
        public Response Insert(Fornecedor fornecedor)
        {
            string sql = $"INSERT INTO FORNECEDORES (RAZAO_SOCIAL,CNPJ,NOME_CONTATO,TELEFONE,EMAIL) VALUES " +
                         $"(@RAZAO_SOCIAL,@CNPJ,@NOME_CONTATO,@TELEFONE,@EMAIL)";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@RAZAO_SOCIAL", fornecedor.RazaoSocial);
            command.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@NOME_CONTATO", fornecedor.NomeContato);
            command.Parameters.AddWithValue("@TELEFONE", fornecedor.Telefone);
            command.Parameters.AddWithValue("@EMAIL", fornecedor.Email);

            
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Fornecedor cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FORNECEDORES_EMAIL"))
                {
                    return new Response("Este e-mail já está cadastrado.", false);
                }
                if (ex.Message.Contains("UQ_FORNECEDORES_CNPJ"))
                {
                    return new Response("CNPJ já está em uso.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Update(Fornecedor fornecedor)
        {
            
            string sql = $"UPDATE FORNECEDORES SET RAZAO_SOCIAL = @RAZAO_SOCIAL, EMAIL = @EMAIL, " +
                         $"TELEFONE = @TELEFONE, NOME_CONTATO = @NOME_CONTATO WHERE ID = @ID";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", fornecedor.ID);
            command.Parameters.AddWithValue("@RAZAO_SOCIAL", fornecedor.RazaoSocial);
            command.Parameters.AddWithValue("@NOME_CONTATO", fornecedor.NomeContato);
            command.Parameters.AddWithValue("@TELEFONE", fornecedor.Telefone);
            command.Parameters.AddWithValue("@EMAIL", fornecedor.Email);

            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Fornecedor excluido.", false);
                }
                return new Response("Fornecedor alterado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FORNECEDORES_EMAIL"))
                {
                    if (ex.Message.Contains("FK_COMPRAS_FORNECEDORES"))
                    {
                        return new Response("Não é possível deletar esse fornecedor, pois já existe uma compra vinculada a ele.", false);
                    }
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
            string sql = "DELETE FROM FORNECEDORES WHERE ID = @ID";

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
                    return new Response("Fornecedor excluído com sucesso.", true);
                }
                return new Response("Fornecedor não excluído.", false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FORNECEDORES_EMAIL"))
                {
                    return new Response("Este e-mail já está cadastrado.", false);
                }
                if (ex.Message.Contains("UQ_FORNECEDORES_CNPJ"))
                {
                    return new Response("CNPJ já está em uso.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<Fornecedor> GetAll()
        {
           
            string sql = $"SELECT ID,RAZAO_SOCIAL,CNPJ,NOME_CONTATO,TELEFONE,EMAIL FROM FORNECEDORES";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Fornecedor> fornecedores = new List<Fornecedor>();
                while (reader.Read())
                {
                    Fornecedor fornecedor = new Fornecedor();
                    fornecedor.ID = Convert.ToInt32(reader["ID"]);
                    fornecedor.CNPJ = Convert.ToString(reader["CNPJ"]);
                    fornecedor.RazaoSocial = Convert.ToString(reader["RAZAO_SOCIAL"]);
                    fornecedor.NomeContato = Convert.ToString(reader["NOME_CONTATO"]);
                    fornecedor.Email = Convert.ToString(reader["EMAIL"]);
                    fornecedor.Telefone = Convert.ToString(reader["TELEFONE"]);

                    fornecedores.Add(fornecedor);
                }
                return new DataResponse<Fornecedor>("Fornecedores selecionados com sucesso!", true, fornecedores);
            }
            catch (Exception ex)
            {
                return new DataResponse<Fornecedor>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<Fornecedor> GetByID(int id)
        {
            
            string sql = $"SELECT ID,CNPJ,RAZAO_SOCIAL,NOME_CONTATO,EMAIL,TELEFONE FROM FORNECEDORES WHERE ID = @ID";

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
                    Fornecedor fornecedor = new Fornecedor();
                    fornecedor.ID = Convert.ToInt32(reader["ID"]);
                    fornecedor.CNPJ = Convert.ToString(reader["CNPJ"]);
                    fornecedor.RazaoSocial = Convert.ToString(reader["RAZAO_SOCIAL"]); 
                    fornecedor.NomeContato = Convert.ToString(reader["NOME_CONTATO"]);
                    fornecedor.Email = Convert.ToString(reader["EMAIL"]); 
                    fornecedor.Telefone = Convert.ToString(reader["TELEFONE"]);

                    return new SingleResponse<Fornecedor>("Fornecedor selecionado com sucesso!", true, fornecedor);
                }
                return new SingleResponse<Fornecedor>("Fornecedor não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Fornecedor>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}