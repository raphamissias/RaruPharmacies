using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    internal class UsersBusiness
    {
        DataAccess.UsersDataAccess usersDataAccess;

        public void Save(string name, DateTime registerDate, string username, string password, bool status, int roleId)
        {
            try
            {
                usersDataAccess = new DataAccess.UsersDataAccess();
                usersDataAccess.Save(name, registerDate, username, password, status, roleId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(int id, string name, DateTime registerDate, string username, string password, bool status, int roleId)
        {
            try
            {
                usersDataAccess = new DataAccess.UsersDataAccess();
                usersDataAccess.Update(id, name, registerDate, username, password, status, roleId);
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
                usersDataAccess = new DataAccess.UsersDataAccess();
                usersDataAccess.Delete(id);
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
                usersDataAccess = new DataAccess.UsersDataAccess();
                return usersDataAccess.List();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
