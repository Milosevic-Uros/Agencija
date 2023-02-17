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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AdminDashboard : Form
    {
        private readonly IAdminBusiness adminBusiness;
        private readonly IClientBusiness clientBusiness;
        Admin admin;
        public AdminDashboard(AdminBusiness _adminBusiness, ClientBusiness _clientBusiness)
        {
            adminBusiness= _adminBusiness;
            clientBusiness= _clientBusiness;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            //textBoxBroj.Text = adminBusiness.GetAllClients().Count.ToString();
        }
        public Form1 RefLoginForm { get; set; }
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.RefLoginForm.Show();
            this.Close();
        }

        private void buttonClientManagement_Click(object sender, EventArgs e)
        {
            ClientManagement clientManagementForm = new ClientManagement(adminBusiness);
            clientManagementForm.Show();
        }

        private void buttonArrangement_Click(object sender, EventArgs e)
        {
            ArrangementManagement arrangementManagementForm = new ArrangementManagement(adminBusiness);
            arrangementManagementForm.Show();
        }
    }
}
