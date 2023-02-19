using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
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
            adminBusiness = _adminBusiness;
            clientBusiness= _clientBusiness;
            InitializeComponent();
        }



        private void ExchangeOffice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aGENCIJADataSet3.EXCHANGE_RATES' table. You can move, or remove it, as needed.
            this.eXCHANGE_RATESTableAdapter1.Fill(this.aGENCIJADataSet3.EXCHANGE_RATES);
            // TODO: This line of code loads data into the 'aGENCIJADataSet1.EXCHANGE_RATES' table. You can move, or remove it, as needed.
            this.eXCHANGE_RATESTableAdapter.Fill(this.aGENCIJADataSet1.EXCHANGE_RATES);
            List<ExchangeRate> transactions = adminBusiness.GetExchangeRates();
            dataGridViewExchange.DataSource = transactions;
            labelHeadline.Text += DateTime.Now.ToString("dd'-'MM'-'yyyy");

        }

        private void dataGridViewExchange_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewExchange.Rows[e.RowIndex];

            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if(textBoxAmount.Text == "")
            {
                MessageBox.Show("Provide amount that you want to convert!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAmount.Focus();
                return;
            }


            decimal value = Convert.ToDecimal(comboBoxFrom.SelectedValue.ToString()) * Convert.ToDecimal(textBoxAmount.Text) / Convert.ToDecimal(comboBoxTo.SelectedValue.ToString());
            labelValue.Text = Math.Round(value,2).ToString();
            labelValue.Visible = true;

        }
    }
}
