using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ClientsBusiness
    {
        DataAccess.ClientsDataAccess newClient;

        public void Save(string name, string address, string neighborhood, string city, DateTime birthdate, string rg, string cpf, string phone, string cellphone, string observation, DateTime registrationDate)
        {
            try
            {
                newClient = new DataAccess.ClientsDataAccess();
                newClient.Save(name, address, neighborhood, city, birthdate, rg, cpf, phone, cellphone, observation, registrationDate);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
