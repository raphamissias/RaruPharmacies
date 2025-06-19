using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmProducts : Form
    {
        Business.ProductBusiness productBusiness;
        Business.CategoriesBusiness categoriesBusiness;

        public frmProducts()
        {
            InitializeComponent();
            listProducts();
            listCategories();
            VerifyStock();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "0")
                {
                    saveNewProduct();
                } else 
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja confirmar alterações?", "Atualizar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        updateProductInfo();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearTxtFields();
            listProducts();
        }

        private void dtgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgProducts.Columns[e.ColumnIndex].Name == "dtgEdit")
            {
                txtId.Text = dtgProducts.Rows[e.RowIndex].Cells["dtgId"].Value.ToString();
                txtName.Text = dtgProducts.Rows[e.RowIndex].Cells["dtgName"].Value.ToString();
                txtBarcode.Text = dtgProducts.Rows[e.RowIndex].Cells["dtgBarcode"].Value.ToString();
                txtDetails.Text = dtgProducts.Rows[e.RowIndex].Cells["dtgDetails"].Value.ToString();
                dtpRegistrationDate.Text = dtgProducts.Rows[e.RowIndex].Cells["dtgRegisterDate"].Value.ToString();
                numMin.Text = dtgProducts.Rows[e.RowIndex].Cells["dtgStockMin"].Value.ToString();
                numCurrent.Text = dtgProducts.Rows[e.RowIndex].Cells["dtgStockCurrent"].Value.ToString();
                txtCost.Text = dtgProducts.Rows[e.RowIndex].Cells["dtgCost"].Value.ToString();
                txtSale.Text = dtgProducts.Rows[e.RowIndex].Cells["dtgSale"].Value.ToString();
                cbCategory.SelectedValue = Int32.Parse(dtgProducts.Rows[e.RowIndex].Cells["categoryId"].Value.ToString());
            }
            else if (dtgProducts.Columns[e.ColumnIndex].Name == "dtgDelete")
            {
                DialogResult result = MessageBox.Show("Deseja excluir produto?", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    deleteProduct(Int32.Parse(dtgProducts.Rows[e.RowIndex].Cells["dtgId"].Value.ToString()));
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listProductsByOptions();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Form frmCategories = new frmCategories(this);
            frmCategories.ShowDialog();
        }

        private void saveNewProduct()
        {
            try
            {
                productBusiness = new Business.ProductBusiness();
                productBusiness.Save(txtName.Text, txtBarcode.Text, txtDetails.Text, (int)cbCategory.SelectedValue, dtpRegistrationDate.Value.Date, (int)numMin.Value, (int)numCurrent.Value, decimal.Parse(txtCost.Text), decimal.Parse(txtSale.Text));

                listProducts();
                clearTxtFields();
                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateProductInfo()
        {
            try
            {
                productBusiness = new Business.ProductBusiness();
                productBusiness.Update(Int32.Parse(txtId.Text), txtName.Text, txtBarcode.Text, txtDetails.Text, (int)cbCategory.SelectedValue, dtpRegistrationDate.Value.Date, (int)numMin.Value, (int)numCurrent.Value, decimal.Parse(txtCost.Text), decimal.Parse(txtSale.Text));

                listProducts();
                clearTxtFields();
                MessageBox.Show("Informações atualizadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteProduct(int id)
        {
            try
            {
                productBusiness = new Business.ProductBusiness();
                productBusiness.Delete(id);

                listProducts();
                MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listProducts()
        {
            try
            {
                productBusiness = new Business.ProductBusiness();
                dtgProducts.DataSource = productBusiness.List();

                dtgProducts.AutoGenerateColumns = false;
                dtgProducts.Columns["dtgBarcode"].DisplayIndex = 3;
                dtgProducts.Columns["dtgName"].DisplayIndex = 4;
                dtgProducts.Columns["dtgDetails"].DisplayIndex = 5;
                dtgProducts.Columns["dtgStockCurrent"].DisplayIndex = 6;
                dtgProducts.Columns["dtgSale"].DisplayIndex = 7;
                dtgProducts.Columns["dtgCategory"].DisplayIndex = 8;
                dtgProducts.Columns["dtgEdit"].DisplayIndex = 9;
                dtgProducts.Columns["dtgDelete"].DisplayIndex = 10;

                VerifyStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listProductsByOptions()
        {
            try
            {
                productBusiness = new Business.ProductBusiness();

                if (rbName.Checked == true)
                {
                    dtgProducts.DataSource = productBusiness.ListByName(txtSearch.Text);
                }
                else if (rbCategory.Checked == true)
                {
                    dtgProducts.DataSource = productBusiness.ListByCategory(txtSearch.Text);
                }
                else if (rbBarcode.Checked == true)
                {
                    dtgProducts.DataSource = productBusiness.ListByBarcode(txtSearch.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void listCategories()
        {
            categoriesBusiness = new Business.CategoriesBusiness();
            cbCategory.DataSource = categoriesBusiness.List();
            cbCategory.DisplayMember = "name";
            cbCategory.ValueMember = "id";
            cbCategory.SelectedValue = 0;
        }

        private void VerifyStock()
        {
            try
            {
                productBusiness = new Business.ProductBusiness();
                dtgStock.DataSource = productBusiness.VerifyStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearTxtFields()
        {
            txtId.Text = "0";
            txtName.Clear();
            txtBarcode.Clear();
            txtDetails.Clear();
            dtpRegistrationDate.Value = DateTime.Today;
            numMin.Value = 0;
            numCurrent.Value = 0;
            txtCost.Text = "0";
            txtSale.Text = "0";
        }

        private void dtgStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgStock.Rows[e.RowIndex].Cells["dtgStockId"].Value.ToString();
            txtName.Text = dtgStock.Rows[e.RowIndex].Cells["dtgStockName"].Value.ToString();
            txtBarcode.Text = dtgStock.Rows[e.RowIndex].Cells["dtgStockBarcode"].Value.ToString();
            txtDetails.Text = dtgStock.Rows[e.RowIndex].Cells["dtgStockDetails"].Value.ToString();
            dtpRegistrationDate.Text = dtgStock.Rows[e.RowIndex].Cells["dtgStockRegisterDate"].Value.ToString();
            numMin.Text = dtgStock.Rows[e.RowIndex].Cells["dtgStockStockMin"].Value.ToString();
            numCurrent.Text = dtgStock.Rows[e.RowIndex].Cells["dtgStockStockCurrent"].Value.ToString();
            txtCost.Text = dtgStock.Rows[e.RowIndex].Cells["dtgStockCost"].Value.ToString();
            txtSale.Text = dtgStock.Rows[e.RowIndex].Cells["dtgStockSale"].Value.ToString();
            cbCategory.SelectedValue = Int32.Parse(dtgStock.Rows[e.RowIndex].Cells["dtgStockCategoryId"].Value.ToString());
        }
    }
}
