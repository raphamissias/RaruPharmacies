﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ClientsDataAccess
    {
        SqlCommand sqlCommand = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dataTable = new DataTable();

        public void Save(string first_name, string last_name, DateTime birthdate, string cpf, string rg, string address, string neighborhood, string city, string email, string phone, string cellphone, string observation, DateTime registrationDate)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.stringConnection))
                {
                    conn.Open();

                    sql.Append("INSERT INTO Clients (first_name, last_name, birthdate, cpf, rg, address, neighborhood, city, email, phone, cellphone, observation, registrationDate)");
                    sql.Append(" VALUES (@first_name, @last_name, @birthdate, @cpf, @rg, @address, @neighborhood, @city, @email, @phone, @cellphone, @observation, @registrationDate)");

                    sqlCommand.Parameters.Add(new SqlParameter("@first_name", first_name));
                    sqlCommand.Parameters.Add(new SqlParameter("@last_name", last_name));
                    sqlCommand.Parameters.Add(new SqlParameter("@birthdate", birthdate));
                    sqlCommand.Parameters.Add(new SqlParameter("@cpf", cpf));
                    sqlCommand.Parameters.Add(new SqlParameter("@rg", rg));
                    sqlCommand.Parameters.Add(new SqlParameter("@address", address));
                    sqlCommand.Parameters.Add(new SqlParameter("@neighborhood", neighborhood));
                    sqlCommand.Parameters.Add(new SqlParameter("@city", city));
                    sqlCommand.Parameters.Add(new SqlParameter("@email", email));
                    sqlCommand.Parameters.Add(new SqlParameter("@phone", phone));
                    sqlCommand.Parameters.Add(new SqlParameter("@cellphone", cellphone));
                    sqlCommand.Parameters.Add(new SqlParameter("@observation", observation));
                    sqlCommand.Parameters.Add(new SqlParameter("@registrationDate", registrationDate));

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

        public void Update(int id, string first_name, string last_name, DateTime birthdate, string cpf, string rg, string address, string neighborhood, string city, string email, string phone, string cellphone, string observation, DateTime registrationDate)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.stringConnection))
                {
                    conn.Open();

                    sql.Append("UPDATE Clients");
                    sql.Append(" SET first_name=@first_name, last_name=@last_name, birthdate=@birthdate, cpf=@cpf, rg=@rg, address=@address, neighborhood=@neighborhood, city=@city, email=@email, phone=@phone, cellphone=@cellphone, observation=@observation");
                    sql.Append(" WHERE id=@id");

                    sqlCommand.Parameters.Add(new SqlParameter("@id", id));
                    sqlCommand.Parameters.Add(new SqlParameter("@first_name", first_name));
                    sqlCommand.Parameters.Add(new SqlParameter("@last_name", last_name));
                    sqlCommand.Parameters.Add(new SqlParameter("@birthdate", birthdate));
                    sqlCommand.Parameters.Add(new SqlParameter("@cpf", cpf));
                    sqlCommand.Parameters.Add(new SqlParameter("@rg", rg));
                    sqlCommand.Parameters.Add(new SqlParameter("@address", address));
                    sqlCommand.Parameters.Add(new SqlParameter("@neighborhood", neighborhood));
                    sqlCommand.Parameters.Add(new SqlParameter("@city", city));
                    sqlCommand.Parameters.Add(new SqlParameter("@email", email));
                    sqlCommand.Parameters.Add(new SqlParameter("@phone", phone));
                    sqlCommand.Parameters.Add(new SqlParameter("@cellphone", cellphone));
                    sqlCommand.Parameters.Add(new SqlParameter("@observation", observation));

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

                    sql.Append("DELETE FROM Clients WHERE id=@id");

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

                    sql.Append("SELECT * FROM Clients");
                    sql.Append(" ORDER BY first_name ASC");

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

        public DataTable ListByName(string first_name)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.stringConnection))
                {
                    conn.Open();

                    sql.Append("SELECT * FROM Clients");
                    sql.Append(" WHERE first_name LIKE @first_name");

                    sqlCommand.Parameters.Add(new SqlParameter("@first_name", first_name + "%"));

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

        public DataTable ListByCpf(string cpf)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.stringConnection))
                {
                    conn.Open();

                    sql.Append("SELECT * FROM Clients");
                    sql.Append(" WHERE cpf=@cpf");

                    sqlCommand.Parameters.Add(new SqlParameter("@cpf", cpf));

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
