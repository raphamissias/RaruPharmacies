using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ClientsDataAccess
    {
        SqlCommand sqlCommand = new SqlCommand();
        StringBuilder sql = new StringBuilder();

        public void Save(string name, string address, string neighborhood, string city, DateTime birthdate, string rg, string cpf, string phone, string cellphone, string observation, DateTime registrationDate)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.stringConnection))
                {
                    conn.Open();

                    sql.Append("INSERT INTO Clients (CLIENT_NAME, ADDRESS, NEIGHBORHOOD, CITY, BIRTHDATE, RG, CPF, PHONE, CELLPHONE, OBSERVATION, REGISTRATION_DATE)");
                    sql.Append(" VALUES (name, address, neighborhood, city, birthdate, rg, cpf, phone, cellphone, observation, registrationDate)");

                    sqlCommand.Parameters.Add(new SqlParameter("name", name));
                    sqlCommand.Parameters.Add(new SqlParameter("address", address));
                    sqlCommand.Parameters.Add(new SqlParameter("neighborhood", neighborhood));
                    sqlCommand.Parameters.Add(new SqlParameter("city", city));
                    sqlCommand.Parameters.Add(new SqlParameter("birthdate", birthdate));
                    sqlCommand.Parameters.Add(new SqlParameter("rg", rg));
                    sqlCommand.Parameters.Add(new SqlParameter("cpf", cpf));
                    sqlCommand.Parameters.Add(new SqlParameter("phone", phone));
                    sqlCommand.Parameters.Add(new SqlParameter("cellphone", cellphone));
                    sqlCommand.Parameters.Add(new SqlParameter("observation", observation));
                    sqlCommand.Parameters.Add(new SqlParameter("registrationDate", registrationDate));

                    sqlCommand.CommandText = sql.ToString();
                    sqlCommand.Connection = conn;
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}
