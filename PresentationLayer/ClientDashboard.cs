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
    public partial class ClientDashboard : Form
    {
        private readonly IAdminBusiness adminBusiness;
        private readonly IClientBusiness clientBusiness;
        private Client client;

        public ClientDashboard(IAdminBusiness _adminBusiness,IClientBusiness _clientBusiness, Client _client)
        {
            adminBusiness=_adminBusiness;
            clientBusiness = _clientBusiness;
            client = _client;
            InitializeComponent();
        }

        private void ClientDashboard_Load(object sender, EventArgs e)
        {
            labelName.Text = client.firstName.ToString() + client.lastName.ToString();
        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 5)
            {
                pictureBoxSlide.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
            
        }

        private void buttonExchange_Click(object sender, EventArgs e)
        {
            ExchangeOffice exchangeOffice = new ExchangeOffice(adminBusiness, clientBusiness);
            exchangeOffice.ShowDialog();
            this.Close();
        }

        private void buttonTicket_Click(object sender, EventArgs e)
        {
            TicketStore ticketStore = new TicketStore(adminBusiness, clientBusiness, client);
            ticketStore.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login(adminBusiness, clientBusiness);
            login.ShowDialog();
        }

        private void buttonBoughtTickets_Click(object sender, EventArgs e)
        {
            BoughtTickets boughtTickets = new BoughtTickets(clientBusiness, client);
            boughtTickets.Show();
        }

        private void buttonBoughtArrangements_Click(object sender, EventArgs e)
        {
            BoughtArrangements boughtArrangements= new BoughtArrangements();
            boughtArrangements.Show();
        }
    }
}
