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
        public AdminDashboard(IAdminBusiness _adminBusiness, IClientBusiness _clientBusiness,Admin _admin)
        {
            adminBusiness= _adminBusiness;
            clientBusiness= _clientBusiness;
            admin = _admin;
            InitializeComponent();
        }


        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            labelWelcome.Text += admin.name.ToString();
            labelNumOfAvailableArrangements.Text ="      "+ adminBusiness.GetAllArrangements().Count.ToString();
            labelNumOfAvailableLocations.Text = "      " + adminBusiness.GetLocations().Count.ToString();
            labelNumOfAvailableTickets.Text = "      " + adminBusiness.GetAllTickets().Count.ToString();
            labelNumOfRegisteredClients.Text = "      " + adminBusiness.GetAllClients().Count.ToString();
            labelAvailableArrangements.Text = "Number of available\narrangements";
            labelRegisteredClients.Text = "Number of registered\nclients";



        }
        public Login RefLoginForm { get; set; }
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login(adminBusiness, clientBusiness);
            login.ShowDialog();  
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

        private void buttonTicketManagement_Click(object sender, EventArgs e)
        {
            TicketManagement ticketManagementForm = new TicketManagement(adminBusiness);
            ticketManagementForm.Show();
        }

        private void buttonTransactionManagement_Click(object sender, EventArgs e)
        {
            TransactionManagement transactionManagement = new TransactionManagement(adminBusiness);
            transactionManagement.Show();

        }
    }
}
