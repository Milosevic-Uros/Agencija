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

    public partial class TicketStore : Form

    {
        private readonly IAdminBusiness adminBusiness;
        private readonly IClientBusiness clientBusiness;
        public TicketStore(IAdminBusiness _adminBusiness, IClientBusiness _clientBusiness)
        {
            adminBusiness = _adminBusiness;
            clientBusiness = _clientBusiness;
            InitializeComponent();
        }

        private void TicketStore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aGENCIJADataSet1.EXCHANGE_RATES' table. You can move, or remove it, as needed.
            this.eXCHANGE_RATESTableAdapter.Fill(this.aGENCIJADataSet1.EXCHANGE_RATES);
            List<ExchangeRate> transactions = adminBusiness.GetExchangeRates();
            dataGridViewExchange.DataSource = transactions;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }
        private void dataGridViewExchange_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewExchange.Rows[e.RowIndex];

            }
        }
    }
}
