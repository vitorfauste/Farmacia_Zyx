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
    public class CompraDAL
    {

        
        public Response Insert(Compra compra)
        {
            string sql = $"INSERT INTO COMPRAS (DATA_COMPRA,VALOR_TOTAL,FORNECEDOR,FUNCIONARIO,FORMA_PAGAMENTO) VALUES" +
                                            $"(@DATA_COMPRA,@VALOR_TOTAL,@FORNECEDOR,@FUNCIONARIO,@FORMA_PAGAMENTO); SELECT SCOPE_IDENTITY()";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@DATA_COMPRA", compra.DataTransacao);
            command.Parameters.AddWithValue("@VALOR_TOTAL", compra.ValorTotal);
            command.Parameters.AddWithValue("@FORNECEDOR", compra.IDFornecedor);
            command.Parameters.AddWithValue("@FUNCIONARIO", compra.IDFuncionario);
            command.Parameters.AddWithValue("@FORMA_PAGAMENTO", compra.FormaPagamento);

            try
            {
                connection.Open();
                compra.ID = Convert.ToInt32(command.ExecuteScalar());
                return new Response("Compra realizada com sucesso.", true);
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
            string sql = $"INSERT INTO PRODUTOS_COMPRAS (PRODUTO,COMPRA,QUANTIDADE_COMPRADA,VALOR_UNITARIO) VALUES" +
                                            $"(@PRODUTO,@COMPRA,@QUANTIDADE_COMPRADA,@VALOR_UNITARIO)";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@PRODUTO", item.IDProduto);
            command.Parameters.AddWithValue("@COMPRA", item.IDTransacao);
            command.Parameters.AddWithValue("@QUANTIDADE_COMPRADA", item.QuantidadeProduto);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", item.ValorUnitario);
           
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Item inserido na compra com sucesso.", true);
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
