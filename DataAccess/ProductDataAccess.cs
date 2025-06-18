using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDataAccess
    {
        SqlCommand sqlCommand = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dataTable = new DataTable();

        public void Save(string name, string barcode, string details, int categoryId, DateTime registerDate, int stockMin, int stockCurrent, decimal cost, decimal sale)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.stringConnection))
                {
                    conn.Open();

                    sql.Append("INSERT INTO Products (name, barcode, details, categoryId, registerDate, stockMin, stockCurrent, cost, sale)");
                    sql.Append(" VALUES (@name, @barcode, @details, @categoryId, @registerDate, @stockMin, @stockCurrent, @cost, @sale)");

                    sqlCommand.Parameters.Add(new SqlParameter("@name", name));
                    sqlCommand.Parameters.Add(new SqlParameter("@barcode", barcode));
                    sqlCommand.Parameters.Add(new SqlParameter("@details", details));
                    sqlCommand.Parameters.Add(new SqlParameter("@categoryId", categoryId));
                    sqlCommand.Parameters.Add(new SqlParameter("@registerDate", registerDate));
                    sqlCommand.Parameters.Add(new SqlParameter("@stockMin", stockMin));
                    sqlCommand.Parameters.Add(new SqlParameter("@stockCurrent", stockCurrent));
                    sqlCommand.Parameters.Add(new SqlParameter("@cost", cost));
                    sqlCommand.Parameters.Add(new SqlParameter("@sale", sale));

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

        public void Update(int id, string name, string barcode, string details, int categoryId, DateTime registerDate, int stockMin, int stockCurrent, decimal cost, decimal sale)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.stringConnection))
                {
                    conn.Open();

                    sql.Append("UPDATE Products");
                    sql.Append(" SET name=@name, barcode=@barcode, details=@details, categoryId=@categoryId, registerDate=@registerDate, stockMin=@stockMin, stockCurrent=@stockCurrent, cost=@cost, sale=@sale");
                    sql.Append(" WHERE id=@id");

                    sqlCommand.Parameters.Add(new SqlParameter("@id", id));
                    sqlCommand.Parameters.Add(new SqlParameter("@name", name));
                    sqlCommand.Parameters.Add(new SqlParameter("@barcode", barcode));
                    sqlCommand.Parameters.Add(new SqlParameter("@details", details));
                    sqlCommand.Parameters.Add(new SqlParameter("@categoryId", categoryId));
                    sqlCommand.Parameters.Add(new SqlParameter("@registerDate", registerDate));
                    sqlCommand.Parameters.Add(new SqlParameter("@stockMin", stockMin));
                    sqlCommand.Parameters.Add(new SqlParameter("@stockCurrent", stockCurrent));
                    sqlCommand.Parameters.Add(new SqlParameter("@cost", cost));
                    sqlCommand.Parameters.Add(new SqlParameter("@sale", sale));

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

                    sql.Append("DELETE FROM Products WHERE id=@id");

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

                    sql.Append("SELECT Products.*, Categories.name AS categoryName from Products INNER JOIN Categories");
                    sql.Append(" ON Products.categoryId = Categories.id");
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

        public DataTable ListByName(string name)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.stringConnection))
                {
                    conn.Open();

                    sql.Append("SELECT * FROM Products");
                    sql.Append(" WHERE name LIKE @name");

                    sqlCommand.Parameters.Add(new SqlParameter("@name", name + "%"));

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

        public DataTable ListByCategory(string categoryName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.stringConnection))
                {
                    conn.Open();

                    sql.Append("SELECT Products.*, Categories.name AS categoryName from Products INNER JOIN Categories");
                    sql.Append(" ON Products.categoryId = Categories.id");
                    sql.Append(" WHERE categoryName=@categoryName");

                    sqlCommand.Parameters.Add(new SqlParameter("@categoryName", categoryName));

                    sqlCommand.CommandText = sql.ToString();
                    sqlCommand.Connection = conn;
                    dataTable.Load(sqlCommand.ExecuteReader());

                    return dataTable;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método listar por categoria. Caso o problema persista, entre em contato com o Administrador do sistema.");
            }
        }

        public DataTable ListByBarcode(string barcode)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.stringConnection))
                {
                    conn.Open();

                    sql.Append("SELECT * FROM Products");
                    sql.Append(" WHERE barcode=@barcode");

                    sqlCommand.Parameters.Add(new SqlParameter("@barcode", barcode));

                    sqlCommand.CommandText = sql.ToString();
                    sqlCommand.Connection = conn;
                    dataTable.Load(sqlCommand.ExecuteReader());

                    return dataTable;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método listar pelo código de barras. Caso o problema persista, entre em contato com o Administrador do sistema.");
            }

        }
    }
}