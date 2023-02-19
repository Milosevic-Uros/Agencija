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
    public partial class BoughtArrangements : Form
    {
        private readonly IClientBusiness clientBusiness;
        private readonly IAdminBusiness adminBusiness;
        Client client;
        public BoughtArrangements(IClientBusiness _clientBusiness, IAdminBusiness _adminBusiness, Client _client)
        {
            clientBusiness = _clientBusiness;
            adminBusiness = _adminBusiness;
            client = _client;
            InitializeComponent();
        }

        private void BoughtArrangements_Load(object sender, EventArgs e)
        {
            List<object> arrangements = clientBusiness.GetAllClientArrangements(client);
            dataGridViewBoughtArrangements.DataSource = arrangements;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            ClientDashboard clientDashboard = new ClientDashboard(adminBusiness, clientBusiness, client);
            clientDashboard.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BoughtTickets boughtTickets = new BoughtTickets(clientBusiness, adminBusiness, client);
            boughtTickets.Show();
            this.Close();
        }

        private void buttonBuyMore_Click(object sender, EventArgs e)
        {
            ArrangementStore arrangementStore = new ArrangementStore(adminBusiness, clientBusiness, client);
            arrangementStore.Show();
            this.Close();
        }
    }
}
