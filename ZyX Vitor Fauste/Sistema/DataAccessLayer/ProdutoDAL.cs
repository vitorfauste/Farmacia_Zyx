using DataAcessLayer;
using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ProdutoDAL : ICRUD<Produto>
    {
        public Response Insert(Produto produto)
        {
            
            string sql = $"INSERT INTO PRODUTOS (NOME,DESCRICAO,LABORATORIO,QUANTIA_ESTOQUE,LUCRO,VALOR_UNITARIO) VALUES " +
                         $"(@NOME,@DESCRICAO,@LABORATORIO,@QUANTIA_ESTOQUE,@LUCRO,@VALOR_UNITARIO)";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", produto.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", produto.Descricao);
            command.Parameters.AddWithValue("@LABORATORIO", produto.Laboratorio.ID);
            command.Parameters.AddWithValue("@QUANTIA_ESTOQUE", produto.QuantiaEmEstoque);
            command.Parameters.AddWithValue("@LUCRO", produto.Lucro);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", produto.ValorUnitario);


            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Produto cadastrado com sucesso.", true);
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

        public Response Update(Produto produto)
        {
            string sql = $"UPDATE PRODUTOS SET NOME = @NOME, DESCRICAO = @DESCRICAO, LABORATORIO = @LABORATORIO," +
                         $"QUANTIA_ESTOQUE = @QUANTIA_ESTOQUE, LUCRO = @LUCRO, VALOR_UNITARIO = @VALOR_UNITARIO WHERE ID = @ID";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", produto.ID);
            command.Parameters.AddWithValue("@NOME", produto.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", produto.Descricao);
            command.Parameters.AddWithValue("@LABORATORIO", produto.Laboratorio.ID);
            command.Parameters.AddWithValue("@QUANTIA_ESTOQUE", produto.QuantiaEmEstoque);
            command.Parameters.AddWithValue("@LUCRO", produto.Lucro);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", produto.ValorUnitario);

            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Produto não encontrado.", false);
                }
                return new Response("Alterações do produto realizadas com sucesso.", true);
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
            string sql = "DELETE FROM PRODUTOS WHERE ID = @ID";

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
                    return new Response("Produto excluído com sucesso.", true);
                }
                return new Response("Produto não excluído.", false);
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

        public DataResponse<Produto> GetAll()
        {
            string sql = $"SELECT P.ID,P.NOME,P.DESCRICAO,P.QUANTIA_ESTOQUE,P.LUCRO,P.VALOR_UNITARIO," +
                         $"L.ID AS 'ID_LABORATORIO',L.RAZAO_SOCIAL,L.CNPJ " +
                         $"FROM PRODUTOS P INNER JOIN LABORATORIOS L ON P.LABORATORIO = L.ID";
            string connectionString = ConnectionString.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                List<Produto> produtos = new List<Produto>();
                while (reader.Read())
                {
                    Produto produto = new Produto();
                    produto.ID = Convert.ToInt32(reader["ID"]);
                    produto.Nome = Convert.ToString(reader["NOME"]);
                    produto.Descricao = Convert.ToString(reader["DESCRICAO"]);
                    produto.QuantiaEmEstoque = Convert.ToDouble(reader["QUANTIA_ESTOQUE"]);
                    produto.ValorUnitario = Convert.ToDouble(reader["VALOR_UNITARIO"]);
                    produto.Lucro = Convert.ToDouble(reader["LUCRO"]);
                    produto.Laboratorio.ID = Convert.ToInt32(reader["ID_LABORATORIO"]);
                    produto.Laboratorio.RazaoSocial = Convert.ToString(reader["RAZAO_SOCIAL"]);
                    produto.Laboratorio.CNPJ = Convert.ToString(reader["CNPJ"]);

                    produtos.Add(produto);
                }
                return new DataResponse<Produto>("Produtos selecionados com sucesso!", true, produtos);
            }
            catch (Exception ex)
            {
                return new DataResponse<Produto>("Erro no banco de dados, contate  administrador", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<Produto> GetByID(int id)
        {

            string sql = $"SELECT P.ID,P.NOME,P.DESCRICAO,P.QUANTIA_ESTOQUE,P.LUCRO,P.VALOR_UNITARIO," +
                         $"L.ID AS 'ID_LABORATORIO',L.RAZAO_SOCIAL,L.CNPJ " +
                         $"FROM PRODUTOS P INNER JOIN LABORATORIOS L ON P.LABORATORIO = L.ID WHERE P.ID = @ID";
            string connectionString = ConnectionString.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@ID", id);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Produto produto = new Produto();
                    produto.ID = Convert.ToInt32(reader["ID"]);
                    produto.Nome = Convert.ToString(reader["NOME"]);
                    produto.Descricao = Convert.ToString(reader["DESCRICAO"]);
                    produto.QuantiaEmEstoque = Convert.ToDouble(reader["QUANTIA_ESTOQUE"]);
                    produto.ValorUnitario = Convert.ToDouble(reader["VALOR_UNITARIO"]);
                    produto.Lucro = Convert.ToDouble(reader["LUCRO"]);
                    produto.Laboratorio.ID = Convert.ToInt32(reader["ID_LABORATORIO"]);
                    produto.Laboratorio.RazaoSocial = Convert.ToString(reader["RAZAO_SOCIAL"]);
                    produto.Laboratorio.CNPJ = Convert.ToString(reader["CNPJ"]);

                    return new SingleResponse<Produto>("Produto selecionado com sucesso!", true, produto);
                }
                return new SingleResponse<Produto>("Produto não encontrado", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Produto>("Erro no banco de dados, contate  administrador", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}