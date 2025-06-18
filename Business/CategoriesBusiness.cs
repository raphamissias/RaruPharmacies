using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CategoriesBusiness
    {
        DataAccess.CategoriesDataAccess categoriesDataAccess;

        public void Save(string name, string details)
        {
            try
            {
                ValidateFields(name, details);

                categoriesDataAccess = new DataAccess.CategoriesDataAccess();
                categoriesDataAccess.Save(name, details);
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
                ValidateFields(name, details);

                categoriesDataAccess = new DataAccess.CategoriesDataAccess();
                categoriesDataAccess.Update(id, name, details);
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
                categoriesDataAccess = new DataAccess.CategoriesDataAccess();
                categoriesDataAccess.Delete(id);
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
                categoriesDataAccess = new DataAccess.CategoriesDataAccess();
                return categoriesDataAccess.List();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ValidateFields(string name, string details)
        {
            try
            {
                if (name.Trim().Length == 0)
                {
                    throw new Exception("O campo Nome não pode ser vazio!");
                }

                if (details.Trim().Length == 0)
                {
                    throw new Exception("O campo Detalhes não pode ser vazio!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
