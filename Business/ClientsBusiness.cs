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
        DataAccess.ClientsDataAccess clients;

        public void Save(string first_name, string last_name, DateTime birthdate, string cpf, string rg, string address, string neighborhood, string city, string email, string phone, string cellphone, string observation, DateTime registrationDate)
        {
            try
            {
                clients = new DataAccess.ClientsDataAccess();
                clients.Save(first_name, last_name, birthdate, cpf, rg, address, neighborhood, city, email, phone, cellphone, observation, registrationDate);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListClients()
        {
            try
            {
                clients = new DataAccess.ClientsDataAccess();
                return clients.List();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
