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
        public ClientManagement(IAdminBusiness _adminBusiness)
        {
            adminBusiness = _adminBusiness;
            InitializeComponent();
        }

        private void ClientManagement_Load(object sender, EventArgs e)
        {
            List<Client> clients = adminBusiness.GetAllClients();
            dataGridViewClients.DataSource = clients;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
            
                DataGridViewRow row = this.dataGridViewClients.Rows[e.RowIndex];
                textBoxName.Text = row.Cells[0].Value.ToString();
                textBoxLastname.Text = row.Cells[1].Value.ToString();
                textBoxIDNumber.Text = row.Cells[2].Value.ToString();
                textBoxPhoneNum.Text = row.Cells[3].Value.ToString();
            
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxLastname.Text == "" || textBoxIDNumber.Text == "" || textBoxPhoneNum.Text == "") {
                MessageBox.Show("Fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Focus();
                return;
            }
            else if(!Regex.Match(textBoxName.Text, "^[A-Z][a-z]*$").Success)
            {
                MessageBox.Show("The name field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Focus();
                return;
            }
            else if (!Regex.Match(textBoxLastname.Text, "^[A-Z][a-z]*$").Success)
            {
                MessageBox.Show("The last name field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLastname.Focus();
                return;
            }
            else if (!Regex.Match(textBoxIDNumber.Text, "^\\d{9}$").Success)
            {
                MessageBox.Show("The ID number field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIDNumber.Focus();
                return;
            }
            else if (!Regex.Match(textBoxPhoneNum.Text, @"^([0][6]\d{1}[0-9]\d{2,3}\d{3,4}$)?").Success)
            {
                MessageBox.Show("The phone number field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPhoneNum.Focus();
                return;
            }

            Client client= new Client();
            client.firstName = textBoxName.Text;
            client.lastName = textBoxLastname.Text;
            client.idNumber = textBoxIDNumber.Text;
            client.phoneNumber = textBoxPhoneNum.Text;

            string result = adminBusiness.UpdateClient(client);
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridViewClients.DataSource = adminBusiness.GetAllClients();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxLastname.Text == "" || textBoxIDNumber.Text == "" || textBoxPhoneNum.Text == "")
            {
                MessageBox.Show("Select client!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Focus();
                return;
            }
            else 
            {
                int clientID = Convert.ToInt32(textBoxIDNumber.Text);
                string result = adminBusiness.DeleteClient(clientID);
                MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewClients.DataSource = adminBusiness.GetAllClients();

                textBoxName.Text = "";
                textBoxLastname.Text = "";
                textBoxIDNumber.Text = "";
                textBoxPhoneNum.Text = "";
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            InsertClient insertClientForm = new InsertClient(adminBusiness);
            insertClientForm.Show();
        }
    }
}
