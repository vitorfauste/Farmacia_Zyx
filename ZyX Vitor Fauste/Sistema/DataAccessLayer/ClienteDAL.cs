using DataAcessLayer;
using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ClienteDAL : ICRUD<Cliente>
    {
        public Response Insert(Cliente cliente)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"INSERT INTO CLIENTES (NOME,CPF,RG,EMAIL,TELEFONE,TELEFONE2,ISFIDELIDADE) VALUES " +
                         $"(@NOME,@CPF,@RG,@EMAIL,@TELEFONE,@TELEFONE2,@ISFIDELIDADE)";

            string connectionString = ConnectionString.CONNECTION_STRING;

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", cliente.Nome);
            command.Parameters.AddWithValue("@CPF", cliente.CPF);
            command.Parameters.AddWithValue("@RG", cliente.RG);
            command.Parameters.AddWithValue("@EMAIL", cliente.Email);
            command.Parameters.AddWithValue("@TELEFONE", cliente.Telefone);
            command.Parameters.AddWithValue("@TELEFONE2", cliente.Telefone2);
            command.Parameters.AddWithValue("@ISFIDELIDADE", Convert.ToByte(cliente.IsFidelidade));

            //Estamos conectados na base de dados
            //try catch
            //try catch finally
            //try finally
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Cliente cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_CLIENTES_EMAIL"))
                {
                    //RETORNAR MENSAGEM QUE O EMAIL TA DUPLICADO
                    return new Response("Este e-mail já está cadastrado.", false);
                }
                if (ex.Message.Contains("UQ_CLIENTES_CPF"))
                {
                    //RETORNAR MENSAGEM QUE O CPF TA DUPLICADO
                    return new Response("Este CPF já está cadastrado.", false);
                }
                //SE NAO ENTROU EM NENHUM IF DE CIMA, SÓ PODE SER UM ERRO DE INFRAESTRUTURA
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            //Instrução que SEMPRE será executada e fechará a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }

        public Response Update(Cliente cliente)
        {
            string sql = $"UPDATE CLIENTES SET NOME = @NOME, EMAIL = @EMAIL, TELEFONE = @TELEFONE, " +
                         $"TELEFONE2 = @TELEFONE2, ISATIVO = @ISATIVO, ISFIDELIDADE = @ISFIDELIDADE " +
                         $"WHERE ID = @ID";

            string connectionString = ConnectionString.CONNECTION_STRING;

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", cliente.ID);
            command.Parameters.AddWithValue("@NOME", cliente.Nome);
            command.Parameters.AddWithValue("@CPF", cliente.CPF);
            command.Parameters.AddWithValue("@RG", cliente.RG);
            command.Parameters.AddWithValue("@EMAIL", cliente.Email);
            command.Parameters.AddWithValue("@TELEFONE", cliente.Telefone);
            command.Parameters.AddWithValue("@TELEFONE2", cliente.Telefone2);
            command.Parameters.AddWithValue("@ISATIVO", Convert.ToByte(cliente.IsAtivo));
            command.Parameters.AddWithValue("@ISFIDELIDADE", Convert.ToByte(cliente.IsFidelidade));

            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Cliente não encontrado.", false);
                }
                return new Response("Alterações do cliente realizadas com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_CLIENTES_EMAIL"))
                {
                    //RETORNAR MENSAGEM QUE O EMAIL TA DUPLICADO
                    return new Response("Este e-mail já está cadastrado.", false);
                }
                //SE NAO ENTROU NO IF DE CIMA, SÓ PODE SER UM ERRO DE INFRAESTRUTURA
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Delete(int id)
        {
            string sql = "DELETE FROM CLIENTES WHERE ID = @ID";

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
                    return new Response("Cliente excluído com sucesso.", true);
                }
                return new Response("Cliente não excluído.", false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_VENDAS_CLIENTES"))
                {
                    return new Response("Não é possível deletar esse cliente, pois já existe uma venda vinculada a ele.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<Cliente> GetAll()
        {
            string sql = $"SELECT ID,NOME,CPF,RG,EMAIL,TELEFONE,TELEFONE2,PONTOS_FIDELIDADE,ISATIVO,ISFIDELIDADE " +
                         $"FROM CLIENTES WHERE NOME != 'CLIENTE PADRÃO'";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Cliente> clientes = new List<Cliente>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.ID = Convert.ToInt32(reader["ID"]);
                    cliente.Nome = Convert.ToString(reader["NOME"]);
                    cliente.CPF = Convert.ToString(reader["CPF"]); 
                    cliente.RG = Convert.ToString(reader["RG"]);
                    cliente.Telefone = Convert.ToString(reader["TELEFONE"]); 
                    cliente.Telefone2 = Convert.ToString(reader["TELEFONE2"]);
                    cliente.Email = Convert.ToString(reader["EMAIL"]);
                    cliente.PontosFidelidade = Convert.ToInt32(reader["PONTOS_FIDELIDADE"]);
                    cliente.IsAtivo = Convert.ToBoolean(reader["ISATIVO"]);
                    cliente.IsFidelidade = Convert.ToBoolean(reader["ISFIDELIDADE"]);
                    clientes.Add(cliente);
                }
                return new DataResponse<Cliente>("Clientes selecionados com sucesso!", true, clientes);
            }
            catch (Exception ex)
            {
                return new DataResponse<Cliente>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<Cliente> GetByID(int id)
        {
            string sql = $"SELECT ID,NOME,CPF,RG,EMAIL,TELEFONE,TELEFONE2,PONTOS_FIDELIDADE,ISATIVO,ISFIDELIDADE FROM CLIENTES WHERE ID = @ID";

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
                    Cliente cliente = new Cliente();
                    cliente.ID = Convert.ToInt32(reader["ID"]);
                    cliente.Nome = Convert.ToString(reader["NOME"]);
                    cliente.CPF = Convert.ToString(reader["CPF"]);
                    cliente.RG = Convert.ToString(reader["RG"]);
                    cliente.Telefone = Convert.ToString(reader["TELEFONE"]);
                    cliente.Telefone2 = Convert.ToString(reader["TELEFONE2"]);
                    cliente.Email = Convert.ToString(reader["EMAIL"]);
                    cliente.PontosFidelidade = Convert.ToInt32(reader["PONTOS_FIDELIDADE"]);
                    cliente.IsAtivo = Convert.ToBoolean(reader["ISATIVO"]);
                    cliente.IsFidelidade = Convert.ToBoolean(reader["ISFIDELIDADE"]);

                    return new SingleResponse<Cliente>("Cliente selecionado com sucesso!", true, cliente);
                }
                return new SingleResponse<Cliente>("Cliente não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Cliente>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response UpdatePontos(Cliente cliente)
        {
            string sql = $"UPDATE CLIENTES SET PONTOS_FIDELIDADE = @PONTOS_FIDELIDADE WHERE ID = @ID";

            string connectionString = ConnectionString.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@PONTOS_FIDELIDADE", cliente.PontosFidelidade);
            command.Parameters.AddWithValue("@ID", cliente.ID);
            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Cliente não encontrado.", false);
                }
                return new Response("Pontuação do cliente alterada com sucesso.", true);
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
    }
}