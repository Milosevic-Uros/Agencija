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
    public partial class Login : Form
    {
        private readonly IAdminBusiness adminBusiness;
        private readonly IClientBusiness clientBusiness;

        public Login(IAdminBusiness _adminBusiness, IClientBusiness _clientBusiness)
        {
            adminBusiness= _adminBusiness;
            clientBusiness= _clientBusiness;
            InitializeComponent();
        }

        public string connString = "Data Source=MNS-AWS-L02\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RegisterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register r = new Register(adminBusiness, clientBusiness);
            r.ShowDialog();
           
        }


        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (usernameLog.Text == "" || passwordLog.Text == "") {
                MessageBox.Show("Fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameLog.Focus();
                return;
            }

            else if (!Regex.Match(usernameLog.Text, "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$").Success)
            {
                MessageBox.Show("The email field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameLog.Focus();
                return;
            }


            else if (!Regex.Match(passwordLog.Text, "^[a-zA-Z][a-zA-Z0-9]{5,15}").Success)
            {
                MessageBox.Show("The password field is not filled in correctly! The length of the password must be between 10 and 20 characters!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordLog.Focus();
                return;
            }

            else { 

                if (comboBoxLogin.SelectedItem.ToString() == "Admin")
                {
                    Admin admin = adminBusiness.GetAdmin(usernameLog.Text, passwordLog.Text);
                    if (admin.adminId == 0)
                    {
                        MessageBox.Show("The entered data does not match any user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        AdminDashboard adminDashboard = new AdminDashboard(adminBusiness, clientBusiness,admin);
                        adminDashboard.Show();
                        this.Hide();
                        usernameLog.Text = "";
                        passwordLog.Text = "";
                        comboBoxLogin.SelectedIndex = -1;
                    }
                }

                else if (comboBoxLogin.SelectedItem.ToString() == "Client")
                {
                    Client client = adminBusiness.GetClient(usernameLog.Text, passwordLog.Text);
                    if (client.clientId == 0)
                    {
                        MessageBox.Show("The entered data does not match any user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        usernameLog.Text = "";
                        passwordLog.Text = "";
                        usernameLog.Focus();
                    }
                    else
                    {
                        ClientDashboard clientDashboard = new ClientDashboard(clientBusiness, client);
                        clientDashboard.Show();
                        this.Hide();
                    }
                }
            }

        }
    }
}
