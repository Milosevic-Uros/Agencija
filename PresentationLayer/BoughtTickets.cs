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
    public partial class BoughtTickets : Form
    {
        private readonly IClientBusiness clientBusiness;
        Client client;
        public BoughtTickets(IClientBusiness _clientBusiness, Client _client)
        {
            clientBusiness = _clientBusiness;
            client = _client;
            InitializeComponent();
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BoughtArrangements boughtArrangements = new BoughtArrangements();
            boughtArrangements.Show();
            this.Close();
        }

        private void BoughtTickets_Load(object sender, EventArgs e)
        {
            List<object> tickets = clientBusiness.GetAllClientTickets(client);
            dataGridViewBoughtTickets.DataSource = tickets;
        }
    }
}
