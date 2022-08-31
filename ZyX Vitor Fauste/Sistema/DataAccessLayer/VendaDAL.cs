using DataAcessLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class VendaDAL
    {
        public Response Insert(Venda venda)
        {
            string sql = $"INSERT INTO VENDAS (DATA_VENDA,VALOR_TOTAL,CLIENTE,FUNCIONARIO,FORMA_PAGAMENTO) VALUES " +
                                            $"(@DATA_VENDA,@VALOR_TOTAL,@CLIENTE,@FUNCIONARIO,@FORMA_PAGAMENTO); SELECT SCOPE_IDENTITY()";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@DATA_VENDA", venda.DataTransacao);
            command.Parameters.AddWithValue("@VALOR_TOTAL", venda.ValorTotal);
            command.Parameters.AddWithValue("@CLIENTE", venda.IDCliente);
            command.Parameters.AddWithValue("@FUNCIONARIO", venda.IDFuncionario);
            command.Parameters.AddWithValue("@FORMA_PAGAMENTO", venda.FormaPagamento);

            try
            {
                connection.Open();
                venda.ID = Convert.ToInt32(command.ExecuteScalar());
                return new Response("Venda realizada com sucesso.", true);
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

        public Response InsertItem(ItemTransacao item)
        {
            string sql = $"INSERT INTO PRODUTOS_VENDAS (PRODUTO,VENDA,QUANTIDADE_VENDIDA,VALOR_UNITARIO) VALUES" +
                         $"(@PRODUTO,@VENDA,@QUANTIDADE_VENDIDA,@VALOR_UNITARIO)";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@PRODUTO", item.IDProduto);
            command.Parameters.AddWithValue("@VENDA", item.IDTransacao);
            command.Parameters.AddWithValue("@QUANTIDADE_VENDIDA", item.QuantidadeProduto);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", item.ValorUnitario);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Item inserido na venda com sucesso.", true);
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
