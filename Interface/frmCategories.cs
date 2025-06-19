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
    public partial class frmCategories : Form
    {
        Business.CategoriesBusiness categoriesBusiness;
        frmProducts formProducts;

        public frmCategories(frmProducts form)
        {
            InitializeComponent();
            listCategories();
            formProducts = form;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "0")
                {
                    saveNewCategory();
                    formProducts.listCategories();
                }
                else
                {
                    updateCategoyInfo();
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
        }

        private void saveNewCategory()
        {
            try
            {
                categoriesBusiness = new Business.CategoriesBusiness();
                categoriesBusiness.Save(txtName.Text, txtDetails.Text);

                listCategories();
                clearTxtFields();
                MessageBox.Show("Categoria cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateCategoyInfo()
        {
            try
            {
                categoriesBusiness = new Business.CategoriesBusiness();
                categoriesBusiness.Update(Int32.Parse(txtId.Text), txtName.Text, txtDetails.Text);

                listCategories();
                clearTxtFields();
                MessageBox.Show("Informações atualizadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteCategory(int id)
        {
            try
            {
                categoriesBusiness = new Business.CategoriesBusiness();
                categoriesBusiness.Delete(id);

                listCategories();
                MessageBox.Show("Categoria excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listCategories()
        {
            try
            {
                categoriesBusiness = new Business.CategoriesBusiness();
                dtgCategories.DataSource = categoriesBusiness.List();

                dtgCategories.AutoGenerateColumns = false;
                dtgCategories.Columns["dtgId"].DisplayIndex = 0;
                dtgCategories.Columns["dtgName"].DisplayIndex = 1;
                dtgCategories.Columns["dtgDetails"].DisplayIndex = 2;
                dtgCategories.Columns["dtgEdit"].DisplayIndex = 3;
                dtgCategories.Columns["dtgDelete"].DisplayIndex = 4;
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
            txtDetails.Clear();
        }

        private void dtgCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgCategories.Columns[e.ColumnIndex].Name == "dtgEdit")
            {
                txtId.Text = dtgCategories.Rows[e.RowIndex].Cells["dtgId"].Value.ToString();
                txtName.Text = dtgCategories.Rows[e.RowIndex].Cells["dtgName"].Value.ToString();
                txtDetails.Text = dtgCategories.Rows[e.RowIndex].Cells["dtgDetails"].Value.ToString();
            }
            else if (dtgCategories.Columns[e.ColumnIndex].Name == "dtgDelete")
            {
                DialogResult result = MessageBox.Show("Deseja excluir produto?", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    deleteCategory(Int32.Parse(dtgCategories.Rows[e.RowIndex].Cells["dtgId"].Value.ToString()));
                }
            }
        }
    }
}
