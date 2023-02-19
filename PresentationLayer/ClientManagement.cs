using BusinessLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ClientManagement : Form
    {
        private readonly IAdminBusiness adminBusiness;
        private readonly IClientBusiness clientBusiness;
        Admin admin;
        public ClientManagement(IAdminBusiness _adminBusiness, IClientBusiness _clientBusiness, Admin _admin)
        {
            adminBusiness = _adminBusiness;
            clientBusiness = _clientBusiness;
            admin = _admin;
            InitializeComponent();
        }

        private void ClientManagement_Load(object sender, EventArgs e)
        {
            List<Client> clients = adminBusiness.GetAllClients();
            dataGridViewClients.DataSource = clients;
        }



        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "" || textBoxPhoneNumber.Text == "" || textBoxEmail.Text == "" || textBoxPassword.Text == "") {
                MessageBox.Show("Fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxId.Focus();
                return;
            }
            else if(!Regex.Match(textBoxId.Text, "\\d{0,5}").Success)
            {
                MessageBox.Show("The ID field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxId.Focus();
                return;
            }
            else if (!Regex.Match(textBoxPhoneNumber.Text, @"^[0][6]\d{7,8}$").Success)
            {
                MessageBox.Show("The phone number field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPhoneNumber.Focus();
                return;
            }
            else if (!Regex.Match(textBoxEmail.Text, "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$").Success)
            {
                MessageBox.Show("The email field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmail.Focus();
                return;
            }
            else if (!Regex.Match(textBoxPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,25}$").Success)
            {
                MessageBox.Show("The password field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Focus();
                return;
            }

            Client client= new Client();
            client.clientId = Int32.Parse(textBoxId.Text);
            client.phoneNumber = textBoxPhoneNumber.Text;
            client.email = textBoxEmail.Text;
            client.password = textBoxPassword.Text;

            string result = adminBusiness.UpdateClient(client);
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridViewClients.DataSource = adminBusiness.GetAllClients();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "" || textBoxPhoneNumber.Text == "" || textBoxEmail.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Select client!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxId.Focus();
                return;
            }
            else 
            {
                int clientID = Convert.ToInt32(textBoxId.Text);
                string result = adminBusiness.DeleteClient(clientID);
                MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewClients.DataSource = adminBusiness.GetAllClients();

                textBoxId.Text = "";
                textBoxPhoneNumber.Text = "";
                textBoxEmail.Text = "";
                textBoxPassword.Text = "";
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            this.Close();
            InsertClient insertClientForm = new InsertClient(adminBusiness, clientBusiness,admin);
            insertClientForm.Show();
        }

        private void dataGridViewClients_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridViewClients.Rows[e.RowIndex];
                textBoxId.Text = row.Cells[0].Value.ToString();
                textBoxPhoneNumber.Text = row.Cells[6].Value.ToString();
                textBoxEmail.Text = row.Cells[8].Value.ToString();
                textBoxPassword.Text = row.Cells[9].Value.ToString();

            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminDashboard adminDashboard = new AdminDashboard(adminBusiness, clientBusiness, admin);
            adminDashboard.Show();
        }
    }
}
