using BusinessLayer;
using DataLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void RegisterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register r = new Register(adminBusiness, clientBusiness);
            r.ShowDialog();
           
        }


        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (comboBoxLogin.SelectedIndex != 0 && comboBoxLogin.SelectedIndex != 1) 
            {
                MessageBox.Show("Please select your role at the top of the page", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameLog.Focus();
            }
            else if (usernameLog.Text == "" || passwordLog.Text == "")
            {
                MessageBox.Show("Fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameLog.Focus();
            }

            else if (!Regex.Match(usernameLog.Text, "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$").Success)
            {
                MessageBox.Show("The email field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameLog.Focus();
            }


            else if (!Regex.Match(passwordLog.Text, "^[a-zA-Z][a-zA-Z0-9]{5,15}").Success)
            {
                MessageBox.Show("The password field is not filled in correctly! The length of the password must be between 10 and 20 characters!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordLog.Focus();
            }

            else
            {

                if (comboBoxLogin.SelectedItem.ToString() == "Admin")
                {
                    Admin admin = adminBusiness.GetAdmin(usernameLog.Text, passwordLog.Text);
                    if (admin.adminId == 0)
                    {
                        MessageBox.Show("The entered data does not match any user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        AdminDashboard adminDashboard = new AdminDashboard(adminBusiness, clientBusiness, admin);
                        adminDashboard.Show();
                        this.Hide();
                        comboBoxLogin.SelectedIndex = -1;
                    }
                }

                else if (comboBoxLogin.SelectedItem.ToString() == "Client")
                {
                    Client client = adminBusiness.GetClient(usernameLog.Text, passwordLog.Text);
                    if (client.clientId == 0)
                    {
                        MessageBox.Show("The entered data does not match any user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        usernameLog.Focus();
                    }
                    else
                    {
                        ClientDashboard clientDashboard = new ClientDashboard(adminBusiness, clientBusiness, client);
                        clientDashboard.Show();
                        this.Hide();
                    }
                }
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            string connString = Constants.ConnectionString;
            SqlConnection con = new SqlConnection(connString);
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("An unexpected error occured withing the database, please contact your database administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally 
            {
                con.Close();
            }
            comboBoxLogin.SelectedItem = null;
            comboBoxLogin.SelectedText = "--select--";
        }
    }
}
