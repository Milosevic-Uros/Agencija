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
    public partial class Register : Form
    {
        private readonly IAdminBusiness adminBusiness;
        private readonly IClientBusiness clientBusiness;
        public Register(IAdminBusiness _adminBusiness, IClientBusiness _clientBusiness)
        {
            adminBusiness = _adminBusiness;
            clientBusiness = _clientBusiness;
            InitializeComponent();
        }


        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" ||
                textBoxSurname.Text == "" ||
                textBoxID.Text == "" ||
                textBoxPhone.Text == "" ||
                textBoxEmail.Text == "" ||
                textBoxPassword.Text == "" ||
                textBoxJMBG.Text == "" ||
                textBoxPassport.Text == "" ||
                textBoxAddress.Text == "") {
                MessageBox.Show("Fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Focus();
                return;
            }

            if (!Regex.Match(textBoxName.Text, "^[A-Z][a-z]*$").Success)
            {
                MessageBox.Show("The name field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Focus();
                return;
            }

            if (!Regex.Match(textBoxSurname.Text, "^[A-Z][a-z]*$").Success)
            {
                MessageBox.Show("The surname field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSurname.Focus();
                return;
            }
            
            if (!Regex.Match(textBoxID.Text, "^\\d{9}$").Success)
            {
                MessageBox.Show("The ID number field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxID.Focus();
                return;
            }


            if (!Regex.Match(textBoxPhone.Text, @"^([0][6]\d{1}[0-9]\d{2,3}\d{3,4}$)?").Success)
            {
                MessageBox.Show("The phone number field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPhone.Focus();
                return;
            }


            if (!Regex.Match(textBoxEmail.Text, "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$").Success)
            {
                MessageBox.Show("The email field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmail.Focus();
                return;
            }


            if (!Regex.Match(textBoxPassword.Text, "^[a-zA-Z][a-zA-Z0-9]{5,15}").Success)
            {
                MessageBox.Show("The password field is not filled in correctly! The length of the password must be between 10 and 20 characters!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Focus();
                return;
            }

            if (!Regex.Match(textBoxJMBG.Text, "^^(0[1-9]|[12][0-9]|3[01])(0[1-9]|1[012])[0-9]{9}$").Success)
            {
                MessageBox.Show("13 characters required for JMBG field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxJMBG.Focus();
                return;
            }

            if (!Regex.Match(textBoxPassport.Text, "^\\d{9}$").Success)
            {
                MessageBox.Show("The passport number field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxID.Focus();
                return;
            }

            Client client = new Client();
            client.firstName = textBoxName.Text;
            client.lastName = textBoxSurname.Text;
            client.idNumber= textBoxID.Text;
            client.email = textBoxEmail.Text;
            client.password = textBoxPassword.Text;
            client.uniqueIdNumber = textBoxJMBG.Text;
            client.address = textBoxAddress.Text;
            client.passportNumber = textBoxPassport.Text;
            client.phoneNumber = textBoxPhone.Text;

            string result = adminBusiness.InsertClient(client);
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxID.Text = "";
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
            textBoxJMBG.Text = "";
            textBoxAddress.Text = "";
            textBoxPassport.Text = "";
            textBoxPhone.Text = "";

        }

        private void LoginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login l = new Login(adminBusiness, clientBusiness);
            l.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
