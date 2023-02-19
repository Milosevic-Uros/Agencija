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
        private IClientBusiness clientBusiness;
        private Client client;

        public ClientDashboard(IClientBusiness _clientBusiness, Client _client)
        {
            clientBusiness = _clientBusiness;
            client = _client;
            InitializeComponent();
        }

        private void ClientDashboard_Load(object sender, EventArgs e)
        {

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
            ExchangeOffice exchangeOffice = new ExchangeOffice(clientBusiness, adminBusiness);
            exchangeOffice.Show();
            this.Close();
        }
    }
}
