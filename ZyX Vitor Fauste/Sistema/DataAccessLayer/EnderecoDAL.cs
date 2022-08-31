using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;
using Entities;
using System.Data.SqlClient;

namespace DataAcessLayer
{
    public class EnderecoDAL
    { 
        public Response Insert(Endereco item)
        {
            string sql = $"INSERT INTO ENDERECOS (RUA,NUMERO,COMPLEMENTO,BAIRRO,CIDADE,ESTADO,CEP) " +
                         $"VALUES (@RUA,@NUMERO,@COMPLEMENTO,@BAIRRO,@CIDADE,@ESTADO,@CEP); SELECT SCOPE_IDENTITY()";

            string connectionString = ConnectionString.CONNECTION_STRING;


            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@RUA", item.Rua);
            command.Parameters.AddWithValue("@NUMERO", item.Numero);
            command.Parameters.AddWithValue("@COMPLEMENTO", item.Complemento);
            command.Parameters.AddWithValue("@BAIRRO", item.Bairro);
            command.Parameters.AddWithValue("@CIDADE", item.Cidade);
            command.Parameters.AddWithValue("@ESTADO", item.Estado.ID);
            command.Parameters.AddWithValue("@CEP", item.CEP);

            try
            {
                connection.Open();
                item.ID = Convert.ToInt32(command.ExecuteScalar());
                return new Response("Endereço cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }


        }
        public Response Update(Endereco item)
        {
            string sql = $"UPDATE ENDERECOS SET RUA = @RUA, NUMERO = @NUMERO, COMPLEMENTO = @COMPLEMENTO, " +
                         $"BAIRRO = @BAIRRO, CIDADE = @CIDADE, ESTADO = @ESTADO, CEP = @CEP WHERE ID = @ID";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", item.ID);
            command.Parameters.AddWithValue("@RUA", item.Rua);
            command.Parameters.AddWithValue("@NUMERO", item.Numero);
            command.Parameters.AddWithValue("@COMPLEMENTO", item.Complemento);
            command.Parameters.AddWithValue("@BAIRRO", item.Bairro);
            command.Parameters.AddWithValue("@CIDADE", item.Cidade);
            command.Parameters.AddWithValue("@ESTADO", item.Estado.ID);
            command.Parameters.AddWithValue("@CEP", item.CEP);

            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Endereço não alterado.", false);
                }
                return new Response("Endereço alterado com sucesso.", true);
            }
            catch (Exception ex)
            {
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Delete(int id)
        {
            string sql = "DELETE FROM ENDERECOS WHERE ID = @ID";

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
                    return new Response("Endereço excluído com sucesso.", true);
                }
                return new Response("Endereço não excluído.", false);
            }
            catch (Exception ex)
            {
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public SingleResponse<Endereco> GetByID(int id)
        {
            string sql = $"SELECT CEP,RUA,NUMERO,COMPLEMENTO,BAIRRO,CIDADE,ESTADO FROM ENDERECOS WHERE ID = @ID";

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
                    Endereco endereco = new Endereco();
                    endereco.CEP = Convert.ToString(reader["CEP"]);
                    endereco.Numero = Convert.ToString(reader["NUMERO"]);
                    endereco.Rua = Convert.ToString(reader["RUA"]);
                    endereco.Bairro = Convert.ToString(reader["BAIRRO"]);
                    endereco.Cidade = Convert.ToString(reader["CIDADE"]);
                    endereco.Complemento = Convert.ToString(reader["COMPLEMENTO"]);
                    endereco.Estado.ID = Convert.ToInt32(reader["ESTADO"]);

                    return new SingleResponse<Endereco>("Endereço selecionado com sucesso!", true, endereco);
                }
                return new SingleResponse<Endereco>("Endereço não encontrado.", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Endereco>("Erro no banco de dados, contate  administrador", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<Estado> GetAllEstados()
        {
            
            string sql = $"SELECT ID,NOME,UF FROM ESTADOS ORDER BY ID";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);

           
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Estado> estados = new List<Estado>();
                while (reader.Read())
                {
                    Estado estado = new Estado();
                    estado.ID = Convert.ToInt32(reader["ID"]);
                    estado.Nome = Convert.ToString(reader["NOME"]);
                    estado.UF = Convert.ToString(reader["UF"]);

                    estados.Add(estado);
                }
                return new DataResponse<Estado>("Estados selecionados com sucesso!", true, estados);
            }
            catch (Exception ex)
            {
                return new DataResponse<Estado>("Erro no banco de dados, contate  administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
    
}