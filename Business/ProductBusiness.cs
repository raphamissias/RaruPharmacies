using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business
{
    public class ProductBusiness
    {
        DataAccess.ProductDataAccess productsDataAccess;

        public void Save(string name, string barcode, string details, int categoryId, DateTime registerDate, int stockMin, int stockCurrent, decimal cost, decimal sale)
        {
            try
            {
                int id = -1;
                ValidateFields(id, name, barcode, details, categoryId, stockMin, stockCurrent, cost, sale);

                productsDataAccess = new DataAccess.ProductDataAccess();
                productsDataAccess.Save(name, barcode, details, categoryId, registerDate, stockMin, stockCurrent, cost, sale);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(int id, string name, string barcode, string details, int categoryId, DateTime registerDate, int stockMin, int stockCurrent, decimal cost, decimal sale)
        {
            try
            {
                ValidateFields(id, name, barcode, details, categoryId, stockMin, stockCurrent, cost, sale);

                productsDataAccess = new DataAccess.ProductDataAccess();
                productsDataAccess.Update(id, name, barcode, details, categoryId, registerDate, stockMin, stockCurrent, cost, sale);
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
                productsDataAccess = new DataAccess.ProductDataAccess();
                productsDataAccess.Delete(id);
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
                productsDataAccess = new DataAccess.ProductDataAccess();
                return productsDataAccess.List();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListByName(string name)
        {
            try
            {
                productsDataAccess = new DataAccess.ProductDataAccess();
                return productsDataAccess.ListByName(name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListByCategory(string categoryName)
        {
            try
            {
                productsDataAccess = new DataAccess.ProductDataAccess();
                return productsDataAccess.ListByCategory(categoryName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListByBarcode(string barcode)
        {
            try
            {
                productsDataAccess = new DataAccess.ProductDataAccess();
                return productsDataAccess.ListByBarcode(barcode);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ValidateFields(int id, string name, string barcode, string details, int categoryId, int stockMin, int stockCurrent, decimal cost, decimal sale)
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

                if (categoryId == 0)
                {
                    throw new Exception("O campo Categoria não pode ser vazio!");
                }

                if (stockMin == 0)
                {
                    throw new Exception("Valor do campo Estoque Mínimo inválido!");
                }

                if (stockCurrent == 0)
                {
                    throw new Exception("Valor do campo Estoque Atual inválido!");
                }

                if (cost == 0)
                {
                    throw new Exception("O campo Custo não pode ser vazio!");
                }

                if (sale == 0)
                {
                    throw new Exception("O campo Valor Venda não pode ser vazio!");
                }

                productsDataAccess = new DataAccess.ProductDataAccess();
                DataTable productsByBarcode = new DataTable();
                productsByBarcode = productsDataAccess.ListByBarcode(barcode);
                object productName = productsByBarcode.Rows[0]["name"].ToString();

                if (productsByBarcode.Rows.Count > 0)
                {
                    if (productsByBarcode.Rows[0]["id"].ToString() != id.ToString())
                    {
                        throw new Exception($"Já existe um produto cadastrado com este código de barras! \nProduto: {productName}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
