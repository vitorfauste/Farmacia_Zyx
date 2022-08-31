using DataAcessLayer;
using Entities;
using Shared;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class LaboratorioDAL : ICRUD<Laboratorio>
    {
        public Response Insert(Laboratorio laboratorio)
        {
            string sql = $"INSERT INTO LABORATORIOS (RAZAO_SOCIAL,CNPJ) VALUES " +
                         $"(@RAZAO_SOCIAL,@CNPJ)";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@RAZAO_SOCIAL", laboratorio.RazaoSocial);
            command.Parameters.AddWithValue("@CNPJ", laboratorio.CNPJ);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new Response("Laboratório cadastrado com sucesso.", true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_LABORATORIOS_CNPJ"))
                {
                    return new Response("Este CNPJ já está cadastrado.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Update(Laboratorio laboratorio)
        {
            string sql = $"UPDATE LABORATORIOS SET RAZAO_SOCIAL = @RAZAO_SOCIAL WHERE ID = @ID";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", laboratorio.ID);
            command.Parameters.AddWithValue("@RAZAO_SOCIAL", laboratorio.RazaoSocial);

            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return new Response("Laboratório não encontrado.", false);
                }
                return new Response("Laboratório alterado com sucesso.", true);
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
            string sql = "DELETE FROM LABORATORIOS WHERE ID = @ID";

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
                    return new Response("Laboratório excluído com sucesso.", true);
                }
                return new Response("Laboratório não excluído.", false);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_LABORATORIOS_CNPJ"))
                {
                    return new Response("Este CNPJ já está cadastrado.", false);
                }
                return new Response("Erro no banco de dados, contate o administrador.", false);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<Laboratorio> GetAll()
        {
            string sql = $"SELECT ID,RAZAO_SOCIAL,CNPJ FROM LABORATORIOS";

            string connectionString = ConnectionString.CONNECTION_STRING;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Laboratorio> laboratorios = new List<Laboratorio>();
                while (reader.Read())
                {
                    Laboratorio laboratorio = new Laboratorio();
                    laboratorio.ID = Convert.ToInt32(reader["ID"]);
                    laboratorio.RazaoSocial = Convert.ToString(reader["RAZAO_SOCIAL"]);
                    laboratorio.CNPJ = Convert.ToString(reader["CNPJ"]);

                    laboratorios.Add(laboratorio);
                }
                return new DataResponse<Laboratorio>("Laboratórios selecionados com sucesso!", true, laboratorios);
            }
            catch (Exception ex)
            {
                return new DataResponse<Laboratorio>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<Laboratorio> GetByID(int id)
        {
            string sql = $"SELECT ID,RAZAO_SOCIAL,CNPJ FROM LABORATORIOS WHERE ID = @ID";

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
                    Laboratorio laboratorio = new Laboratorio();
                    laboratorio.ID = Convert.ToInt32(reader["ID"]);
                    laboratorio.RazaoSocial = Convert.ToString(reader["RAZAO_SOCIAL"]);
                    laboratorio.CNPJ = Convert.ToString(reader["CNPJ"]);

                    return new SingleResponse<Laboratorio>("Laboratório selecionado com sucesso!", true, laboratorio);
                }
                return new SingleResponse<Laboratorio>("Laboratório não encontrado!", false, null);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Laboratorio>("Erro no banco de dados, contate o administrador.", false, null);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}