using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SalesDataAccess
    {
        SqlCommand sqlCommand = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dataTable = new DataTable();

        public void Save(int userId, int clientId, DateTime saleDate, bool status)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.stringConnection))
                {
                    conn.Open();

                    sql.Append("INSERT INTO Sales (userId, clientId, saleDate, status, registerDate, stockMin, stockCurrent, cost, sale)");
                    sql.Append(" VALUES (@userId, @clientId, @saleDate, @status, @registerDate, @stockMin, @stockCurrent, @cost, @sale)");

                    sqlCommand.Parameters.Add(new SqlParameter("@userId", userId));
                    sqlCommand.Parameters.Add(new SqlParameter("@clientId", clientId));
                    sqlCommand.Parameters.Add(new SqlParameter("@saleDate", saleDate));
                    sqlCommand.Parameters.Add(new SqlParameter("@status", status));

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

        public void Update(int id, int userId, int clientId, DateTime saleDate, bool status)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.stringConnection))
                {
                    conn.Open();

                    sql.Append("UPDATE Sales");
                    sql.Append(" SET userId=@userId, clientId=@clientId, saleDate=@saleDate, status=@status, registerDate=@registerDate, stockMin=@stockMin, stockCurrent=@stockCurrent, cost=@cost, sale=@sale");
                    sql.Append(" WHERE id=@id");

                    sqlCommand.Parameters.Add(new SqlParameter("@id", id));
                    sqlCommand.Parameters.Add(new SqlParameter("@userId", userId));
                    sqlCommand.Parameters.Add(new SqlParameter("@clientId", clientId));
                    sqlCommand.Parameters.Add(new SqlParameter("@saleDate", saleDate));
                    sqlCommand.Parameters.Add(new SqlParameter("@status", status));

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

                    sql.Append("DELETE FROM Sales WHERE id=@id");

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

                    sql.Append("SELECT * FROM Sales");
                    sql.Append(" ORDER BY id DESC");

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
