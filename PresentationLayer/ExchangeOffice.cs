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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ExchangeOffice : Form
    {
        private readonly IAdminBusiness adminBusiness;
        private readonly IClientBusiness clientBusiness;
        Client client;
        public ExchangeOffice(IAdminBusiness _adminBusiness,IClientBusiness _clientBusiness, Client _client)
        {
            adminBusiness = _adminBusiness;
            clientBusiness = _clientBusiness;
            client = _client;
            InitializeComponent();
            
        }

        private void ExchangeOffice_Load(object sender, EventArgs e)
        {
            this.eXCHANGE_RATESTableAdapter1.Fill(this.aGENCIJADataSet3.EXCHANGE_RATES);
            this.eXCHANGE_RATESTableAdapter.Fill(this.aGENCIJADataSet1.EXCHANGE_RATES);
            List<ExchangeRate> transactions = adminBusiness.GetExchangeRates();
            dataGridViewExchange.DataSource = transactions;
            labelHeadline.Text += DateTime.Now.ToString("dd'/'MM'/'yyyy");

        }


        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if(textBoxAmount.Text == "")
            {
                MessageBox.Show("Provide amount that you want to convert!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAmount.Focus();
                return;
            }
            else if (!Regex.Match(textBoxAmount.Text, "^[0-9]*$").Success)
            {
                MessageBox.Show("Amount field accepts only numbers!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAmount.Focus();
                return;
            }


            decimal value = Convert.ToDecimal(comboBoxFrom.SelectedValue.ToString()) * Convert.ToDecimal(textBoxAmount.Text) / Convert.ToDecimal(comboBoxTo.SelectedValue.ToString());
            labelValue.Text = Math.Round(value,2).ToString();
            labelValue.Visible = true;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            ClientDashboard clientDashboard = new ClientDashboard(adminBusiness, clientBusiness, client);
            clientDashboard.Show();
        }


    }
}
