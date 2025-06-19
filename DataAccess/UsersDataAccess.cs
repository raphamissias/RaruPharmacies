using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UsersDataAccess
    {
        SqlCommand sqlCommand = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dataTable = new DataTable();

        public void Save(string name, DateTime registerDate, string username, string password, bool status, int roleId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.stringConnection))
                {
                    conn.Open();

                    sql.Append("INSERT INTO Users (name, registerDate, username, password, status, roleId)");
                    sql.Append(" VALUES (@name, @registerDate, @username, @password, @status, @roleId)");

                    sqlCommand.Parameters.Add(new SqlParameter("@name", name));
                    sqlCommand.Parameters.Add(new SqlParameter("@registerDate", registerDate));
                    sqlCommand.Parameters.Add(new SqlParameter("@username", username));
                    sqlCommand.Parameters.Add(new SqlParameter("@password", password));
                    sqlCommand.Parameters.Add(new SqlParameter("@status", status));
                    sqlCommand.Parameters.Add(new SqlParameter("@roleId", roleId));

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

        public void Update(int id, string name, DateTime registerDate, string username, string password, bool status, int roleId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.stringConnection))
                {
                    conn.Open();

                    sql.Append("UPDATE Users");
                    sql.Append(" SET name=@name, registerDate=@registerDate, username=@username, password=@password, status=@status, roleId=@roleId");
                    sql.Append(" WHERE id=@id");

                    sqlCommand.Parameters.Add(new SqlParameter("@id", id));
                    sqlCommand.Parameters.Add(new SqlParameter("@name", name));
                    sqlCommand.Parameters.Add(new SqlParameter("@registerDate", registerDate));
                    sqlCommand.Parameters.Add(new SqlParameter("@username", username));
                    sqlCommand.Parameters.Add(new SqlParameter("@password", password));
                    sqlCommand.Parameters.Add(new SqlParameter("@status", status));
                    sqlCommand.Parameters.Add(new SqlParameter("@roleId", roleId));
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

                    sql.Append("DELETE FROM Users WHERE id=@id");

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

                    sql.Append("SELECT Users.*, Roles.name AS roleName FROM Users INNER JOIN Roles");
                    sql.Append(" ON Users.id = Roles.id");
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
