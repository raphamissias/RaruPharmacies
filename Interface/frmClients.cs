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

namespace Interface
{
    public partial class frmClients : Form
    {
        Business.ClientsBusiness newClient;
        public frmClients()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                newClient = new Business.ClientsBusiness();
                newClient.Save(txtName.Text, txtAddress.Text, txtNeighborhood.Text, txtCity.Text, dtpBirthdate.Value, txtRg.Text, txtCpf.Text, txtPhone.Text, txtCellphone.Text, txtObservation.Text, dtpRegistrationDate.Value);
                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
