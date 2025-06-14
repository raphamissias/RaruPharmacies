using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ClientsBusiness
    {
        DataAccess.ClientsDataAccess clientsDataAccess;

        public void Save(string first_name, string last_name, DateTime birthdate, string cpf, string rg, string address, string neighborhood, string city, string email, string phone, string cellphone, string observation, DateTime registrationDate)
        {
            try
            {
                clientsDataAccess = new DataAccess.ClientsDataAccess();
                clientsDataAccess.Save(first_name, last_name, birthdate, cpf, rg, address, neighborhood, city, email, phone, cellphone, observation, registrationDate);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(int id, string first_name, string last_name, DateTime birthdate, string cpf, string rg, string address, string neighborhood, string city, string email, string phone, string cellphone, string observation, DateTime registrationDate)
        {
            try
            {
                clientsDataAccess = new DataAccess.ClientsDataAccess();
                clientsDataAccess.Update(id, first_name, last_name, birthdate, cpf, rg, address, neighborhood, city, email, phone, cellphone, observation, registrationDate);
            }
            catch (Exception ex)
            { 
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                clientsDataAccess = new DataAccess.ClientsDataAccess();
                clientsDataAccess.Delete(id);
            }
            catch (Exception ex)
            { 
                throw new Exception(ex.Message);
            }
        }

        public DataTable List()
        {
            try
            {
                clientsDataAccess = new DataAccess.ClientsDataAccess();
                return clientsDataAccess.List();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListByName(string first_name)
        {
            try
            {
                clientsDataAccess = new DataAccess.ClientsDataAccess();
                return clientsDataAccess.ListByName(first_name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListByCpf(string cpf)
        {
            try
            {
                clientsDataAccess = new DataAccess.ClientsDataAccess();
                return clientsDataAccess.ListByCpf(cpf);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
