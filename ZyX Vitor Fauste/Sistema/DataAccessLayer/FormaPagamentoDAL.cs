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
    public class FormaPagamentoDAL : ICRUD<FormaPagamento>
    {
        public Response Insert(FormaPagamento formaPagamento)
        {
            string sql = $"INSERT INTO FORMAS_PAGAMENTO (NOME) VALUES @NOME";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", formaPagamento.Nome);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Forma de pagamento cadastrada com sucesso.", true);
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

        public Response Update(FormaPagamento formaPagamento)
        {
            string sql = $"UPDATE FORMAS_PAGAMENTO SET NOME = @NOME";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", formaPagamento.ID);
            command.Parameters.AddWithValue("@NOME", formaPagamento.Nome);

            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Forma de pagamento não alterada.", false);
                }
                return new Response("Forma de pagamento alterada com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_VENDAS_FORMAS_PAGAMENTO") || ex.Message.Contains("FK_COMPRAS_FORMAS_PAGAMENTO"))
                {
                    return new Response("Não é possível deletar essa forma de pagamento, pois já existe uma compra/venda vinculada a ela.", false);
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
            string sql = "DELETE FROM FORMAS_PAGAMENTO WHERE ID = @ID";

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
                    return new Response("Forma de pagamento excluída com sucesso.", true);
                }
                return new Response("Forma de pagamento não excluída.", false);
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

        public DataResponse<FormaPagamento> GetAll()
        {
            string sql = $"SELECT ID,NOME FROM FORMAS_PAGAMENTO";

            string connectionString = ConnectionString.CONNECTION_STRING;

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<FormaPagamento> formaPagamentos = new List<FormaPagamento>();
                //Enquanto houver registros, o loop será executado!
                while (reader.Read())
                {
                    FormaPagamento formaPagamento = new FormaPagamento();
                    formaPagamento.ID = Convert.ToInt32(reader["ID"]);
                    formaPagamento.Nome = Convert.ToString(reader["NOME"]);
                    formaPagamentos.Add(formaPagamento);
                }
                return new DataResponse<FormaPagamento>("Forma de pagamentos selecionadas com sucesso!", true, formaPagamentos);
            }
            catch (Exception ex)
            {
                return new DataResponse<FormaPagamento>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e "fecharão" a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
        public SingleResponse<FormaPagamento> GetByID(int id)
        {
            //PARÂMETROS SQL - AUTOMATICAMENTE ADICIONA UMA "/" NA FRENTE DE NOMES COM ' EX SHAQQILE O'NEAL
            //               - AUTOMATICAMENTE ADICIONAR '' EM DATAS, VARCHARS E CHARS
            //               - AUTOMATICAMENTE VALIDA SQL INJECTIONS BÁSICOS
            string sql = $"SELECT ID,NOME FROM FORMAS_PAGAMENTO WHERE ID = @ID";

            string connectionString = ConnectionString.CONNECTION_STRING;

            //ADO.NET 
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //Enquanto houver registros, o loop será executado!
                if (reader.Read())
                {
                    FormaPagamento formaPagamento = new FormaPagamento();
                    formaPagamento.ID = Convert.ToInt32(reader["ID"]);
                    formaPagamento.Nome = Convert.ToString(reader["NOME"]);
                    return new SingleResponse<FormaPagamento>("Forma de pagamento selecionada com sucesso!", true, formaPagamento);
                }
                return new SingleResponse<FormaPagamento>("Forma de pagamento não encontrada!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<FormaPagamento>("Erro no banco de dados, contate o administrador.", false, null);
            }
            //Instrução que SEMPRE será executada e fecha a conexão caso ela esteja aberta
            finally
            {
                //Fecha a conexão
                connection.Dispose();
            }
        }
    }
}