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
    public partial class ExchangeOffice : Form
    {
        private readonly IAdminBusiness adminBusiness;
        private readonly IClientBusiness clientBusiness;
        public ExchangeOffice(IClientBusiness _clientBusiness, IAdminBusiness _adminBusiness)
        {
            InitializeComponent();
            _clientBusiness = clientBusiness;
            _adminBusiness = adminBusiness;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }

        private void ExchangeOffice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aGENCIJADataSet1.EXCHANGE_RATES' table. You can move, or remove it, as needed.
            this.eXCHANGE_RATESTableAdapter.Fill(this.aGENCIJADataSet1.EXCHANGE_RATES);

            List<ExchangeRate> rates = adminBusiness.GetExchangeRates();
            dataGridViewExchange.DataSource= rates;
        }

        private void dataGridViewExchange_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewExchange.Rows[e.RowIndex];

            }
        }

        private void labelFrom_Click(object sender, EventArgs e)
        {

        }
    }
}
