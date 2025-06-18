using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoriesDataAccess
    {
        SqlCommand sqlCommand = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dataTable = new DataTable();

        public void Save(string name, string details)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.stringConnection))
                {
                    conn.Open();

                    sql.Append("INSERT INTO Categories (name, details)");
                    sql.Append(" VALUES (@name, @details)");

                    sqlCommand.Parameters.Add(new SqlParameter("@name", name));
                    sqlCommand.Parameters.Add(new SqlParameter("@details", details));

                    sqlCommand.CommandText = sql.ToString();
                    sqlCommand.Connection = conn;
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método salvar. Caso o problema persista, entre em contato com o Administrador do sistema.");
            }
        }

        public void Update(int id, string name, string details)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.stringConnection))
                {
                    conn.Open();

                    sql.Append("UPDATE Categories");
                    sql.Append(" SET name=@name, details=@details");
                    sql.Append(" WHERE id=@id");

                    sqlCommand.Parameters.Add(new SqlParameter("@id", id));
                    sqlCommand.Parameters.Add(new SqlParameter("@name", name));
                    sqlCommand.Parameters.Add(new SqlParameter("@details", details));

                    sqlCommand.CommandText = sql.ToString();
                    sqlCommand.Connection = conn;
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método atualizar. Caso o problema persista, entre em contato com o Administrador do sistema.");
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.stringConnection))
                {
                    conn.Open();

                    sql.Append("DELETE FROM Categories WHERE id=@id");

                    sqlCommand.Parameters.Add(new SqlParameter("@id", id));

                    sqlCommand.CommandText = sql.ToString();
                    sqlCommand.Connection = conn;
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Deletar. Caso o problema persista, entre em contato com o Administrador do sistema.");
            }
        }

        public DataTable List()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.stringConnection))
                {
                    conn.Open();

                    sql.Append("SELECT * FROM Categories");
                    sql.Append(" ORDER BY name ASC");

                    sqlCommand.CommandText = sql.ToString();
                    sqlCommand.Connection = conn;
                    dataTable.Load(sqlCommand.ExecuteReader());

                    return dataTable;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método de listagem. Caso o problema persista, entre em contato com o Administrador do sistema.");
            }
        }
    }
}
