using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    internal class SaleDetailsBusiness
    {
        DataAccess.SaleDetailsDataAccess saleDetailsDataAccess;

        public void Save(int saleId, int productId, int quantity)
        {
            try
            {
                saleDetailsDataAccess = new DataAccess.SaleDetailsDataAccess();
                saleDetailsDataAccess.Save(saleId, productId, quantity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(int id, int saleId, int productId, int quantity)
        {
            try
            {
                saleDetailsDataAccess = new DataAccess.SaleDetailsDataAccess();
                saleDetailsDataAccess.Update(id, saleId, productId, quantity);
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
                saleDetailsDataAccess = new DataAccess.SaleDetailsDataAccess();
                saleDetailsDataAccess.Delete(id);
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
                saleDetailsDataAccess = new DataAccess.SaleDetailsDataAccess();
                return saleDetailsDataAccess.List();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
