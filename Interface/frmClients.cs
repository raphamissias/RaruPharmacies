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
                clientsBusiness = new Business.ClientsBusiness();
                clientsBusiness.Save(txtName.Text, txtLastName.Text, dtpBirthdate.Value, txtCpf.Text, txtRg.Text, txtAddress.Text, txtNeighborhood.Text, txtCity.Text, txtEmail.Text, txtPhone.Text, txtCellphone.Text, txtObservation.Text, dtpRegistrationDate.Value);
                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listClients();
                clearTxtFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listClients()
        {
            try
            {
                clientsBusiness = new Business.ClientsBusiness();
                dtgClients.DataSource = clientsBusiness.ListClients();
            }
            catch (Exception ex)
            { 
                throw new Exception(ex.Message);
            }
        }

        private void clearTxtFields()
        {
            txtID.Text = "0";
            txtName.Clear();
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
