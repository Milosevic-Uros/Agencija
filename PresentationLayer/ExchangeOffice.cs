using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ExchangeOffice : Form
    {
        private readonly IAdminBusiness adminBusiness;
        private readonly IClientBusiness clientBusiness;
        public ExchangeOffice(IAdminBusiness _adminBusiness,IClientBusiness _clientBusiness)
        {
            _adminBusiness = adminBusiness;
            _clientBusiness = clientBusiness;
            InitializeComponent();
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
            List<ExchangeRate> transactions = adminBusiness.GetExchangeRates();
            dataGridViewExchange.DataSource = transactions;
            
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
