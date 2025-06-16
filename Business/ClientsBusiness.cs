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
                ValidateFields(first_name, last_name, birthdate, cpf, rg, address, neighborhood, city, email, phone, cellphone, observation, registrationDate);

                clientsDataAccess = new DataAccess.ClientsDataAccess();
                DataTable clientByCpf = clientsDataAccess.ListByCpf(cpf);

                if (clientByCpf.Rows.Count > 0)
                {
                    throw new Exception("CPF já cadastrado!");
                }

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
                ValidateFields(first_name, last_name, birthdate, cpf, rg, address, neighborhood, city, email, phone, cellphone, observation, registrationDate);

                clientsDataAccess = new DataAccess.ClientsDataAccess();

                DataRow clientByCpf = clientsDataAccess.ListByCpf(cpf).Rows[0];

                if ((int)clientByCpf["id"] != id)
                {
                    throw new Exception("CPF já cadastrado!");
                }

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

        public void ValidateFields(string first_name, string last_name, DateTime birthdate, string cpf, string rg, string address, string neighborhood, string city, string email, string phone, string cellphone, string observation, DateTime registrationDate)
        {
            if (first_name.Trim().Length == 0)
            {
                throw new Exception("O campo Nome não pode ser vazio!");
            }

            if (last_name.Trim().Length == 0)
            {
                throw new Exception("O campo Sobrenome não pode ser vazio!");
            }

            if (address.Trim().Length == 0)
            {
                throw new Exception("O campo Endereço não pode ser vazio!");
            }

            if (neighborhood.Trim().Length == 0)
            {
                throw new Exception("O campo Bairro não pode ser vazio!");
            }

            if (city.Trim().Length == 0)
            {
                throw new Exception("O campo Cidade não pode ser vazio!");
            }

            if (birthdate.Date == DateTime.Today)
            {
                throw new Exception("Data de nascimento inválida!");
            }

            string newCpf = cpf.Replace(".", "").Replace("-", "").Replace(" ", "");

            if (newCpf.Trim().Length < 10)
            {
                throw new Exception("CPF inválido");
            }

            string newRg = rg.Replace(".", "").Replace("-", "").Replace(" ", "");

            if (newRg.Length < 8)
            {
                throw new Exception("O campo RG não pode ser vazio!");
            }

            string newCellphone = cellphone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            if (newCellphone.Trim().Length < 11)
            {
                throw new Exception("O campo Celular não pode ser vazio!");
            }


        }
    }
}
