using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    internal class SalesBusiness
    {
        DataAccess.SalesDataAccess salesDataAccess;

        public void Save(int userId, int clientId, DateTime saleDate, bool status)
        {
            try
            {
                salesDataAccess = new DataAccess.SalesDataAccess();
                salesDataAccess.Save(userId, clientId, saleDate, status);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(int id, int userId, int clientId, DateTime saleDate, bool status)
        {
            try
            {
                salesDataAccess = new DataAccess.SalesDataAccess();
                salesDataAccess.Update(id, userId, clientId, saleDate, status);
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
                salesDataAccess = new DataAccess.SalesDataAccess();
                salesDataAccess.Delete(id);
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
                salesDataAccess = new DataAccess.SalesDataAccess();
                return salesDataAccess.List();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
