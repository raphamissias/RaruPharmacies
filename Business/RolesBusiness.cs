using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    internal class RolesBusiness
    {
        DataAccess.RolesDataAccess rolesDataAccess;

        public void Save(string name, string details)
        {
            try
            {
                rolesDataAccess = new DataAccess.RolesDataAccess();
                rolesDataAccess.Save(name, details);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(int id, string name, string details)
        {
            try
            {
                rolesDataAccess = new DataAccess.RolesDataAccess();
                rolesDataAccess.Update(id, name, details);
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
                rolesDataAccess = new DataAccess.RolesDataAccess();
                rolesDataAccess.Delete(id);
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
                rolesDataAccess = new DataAccess.RolesDataAccess();
                return rolesDataAccess.List();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
