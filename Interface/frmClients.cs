using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Interface
{
    public partial class frmClients : Form
    {
        Business.ClientsBusiness clientsBusiness;
        public frmClients()
        {
            InitializeComponent();
            listClients();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "0")
                {
                    saveNewClient();
                    listClients();
                    clearTxtFields();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja confirmar alterações?", "Atualizar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        updateClientInfo();
                        listClients();
                        clearTxtFields();
                        MessageBox.Show("Informações atualizadas!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgClients.Columns[e.ColumnIndex].Name == "dtgEdit")
            {
                txtId.Text = dtgClients.Rows[e.RowIndex].Cells["dtgId"].Value.ToString();
                txtFirstName.Text = dtgClients.Rows[e.RowIndex].Cells["dtgFirstName"].Value.ToString();
                txtLastName.Text = dtgClients.Rows[e.RowIndex].Cells["dtgLastName"].Value.ToString();
                txtAddress.Text = dtgClients.Rows[e.RowIndex].Cells["dtgAddress"].Value.ToString();
                txtNeighborhood.Text = dtgClients.Rows[e.RowIndex].Cells["dtgNeighborhood"].Value.ToString();
                txtCity.Text = dtgClients.Rows[e.RowIndex].Cells["dtgCity"].Value.ToString();
                dtpBirthdate.Value = (DateTime)dtgClients.Rows[e.RowIndex].Cells["dtgBirthdate"].Value;
                txtObservation.Text = dtgClients.Rows[e.RowIndex].Cells["dtgObservation"].Value.ToString();
                txtCpf.Text = dtgClients.Rows[e.RowIndex].Cells["dtgCpf"].Value.ToString();
                txtRg.Text = dtgClients.Rows[e.RowIndex].Cells["dtgRg"].Value.ToString();
                txtEmail.Text = dtgClients.Rows[e.RowIndex].Cells["dtgEmail"].Value.ToString();
                txtPhone.Text = dtgClients.Rows[e.RowIndex].Cells["dtgPhone"].Value.ToString();
                txtCellphone.Text = dtgClients.Rows[e.RowIndex].Cells["dtgCellphone"].Value.ToString();
                dtpRegistrationDate.Value= (DateTime)dtgClients.Rows[e.RowIndex].Cells["dtgRegistrationDate"].Value;
            }

            if (dtgClients.Columns[e.ColumnIndex].Name == "dtgDelete")
            {
                DialogResult dialogResult = MessageBox.Show("Deseja excluir este cliente?", "Deletar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (dialogResult == DialogResult.Yes)
                {
                    int clientId = Int32.Parse(dtgClients.Rows[e.RowIndex].Cells["dtgId"].Value.ToString());

                    deleteClient(clientId);
                    listClients();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listClientsByNameOrCpf();
        }

        private void saveNewClient()
        {
            clientsBusiness = new Business.ClientsBusiness();
            clientsBusiness.Save(txtFirstName.Text, txtLastName.Text, dtpBirthdate.Value, txtCpf.Text, txtRg.Text, txtAddress.Text, txtNeighborhood.Text, txtCity.Text, txtEmail.Text, txtPhone.Text, txtCellphone.Text, txtObservation.Text, dtpRegistrationDate.Value);
            MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updateClientInfo()
        {
            clientsBusiness = new Business.ClientsBusiness();
            clientsBusiness.Update(Int32.Parse(txtId.Text), txtFirstName.Text, txtLastName.Text, dtpBirthdate.Value, txtCpf.Text, txtRg.Text, txtAddress.Text, txtNeighborhood.Text, txtCity.Text, txtEmail.Text, txtPhone.Text, txtCellphone.Text, txtObservation.Text, dtpRegistrationDate.Value);
        }

        private void deleteClient(int id)
        {
            clientsBusiness = new Business.ClientsBusiness();
            clientsBusiness.Delete(id);
            MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listClients()
        {
            try
            {
                clientsBusiness = new Business.ClientsBusiness();
                dtgClients.DataSource = clientsBusiness.List();

                dtgClients.AutoGenerateColumns = false;
                dtgClients.Columns["dtgEdit"].DisplayIndex = 14;
                dtgClients.Columns["dtgDelete"].DisplayIndex = 15;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void listClientsByNameOrCpf()
        {
            clientsBusiness = new Business.ClientsBusiness();

            if (rbName.Checked == true)
            {
                dtgClients.DataSource = clientsBusiness.ListByName(txtSearch.Text);
            }
            else
            {
                dtgClients.DataSource = clientsBusiness.ListByCpf(txtSearch.Text);
            }
        }

        private void clearTxtFields()
        {
            txtId.Text = "0";
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtNeighborhood.Clear();
            txtCity.Clear();
            dtpBirthdate.Value = DateTime.Now;
            txtRg.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtCellphone.Clear();
            txtObservation.Clear();
            dtpRegistrationDate.Value = DateTime.Now;
        }
    }
}
