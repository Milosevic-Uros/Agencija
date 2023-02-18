using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class TransactionManagement : Form
    {
        private readonly IAdminBusiness adminBusiness;
        
        public TransactionManagement(IAdminBusiness _adminBusiness)
        {
            adminBusiness = _adminBusiness;
            InitializeComponent();
        }

        private void textBoxExchangeRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelExchangeRate_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewTransaction_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridViewTransaction.Rows[e.RowIndex];
                textBoxCurrencyID.Text = row.Cells[0].Value.ToString();
                textBoxCurrencyCode.Text = row.Cells[1].Value.ToString();
                textBoxCountryName.Text = row.Cells[2].Value.ToString();
                textBoxExchangeRate.Text = row.Cells[3].Value.ToString();


            }
        }

        private void TransactionManagement_Load(object sender, EventArgs e)
        {
            List<ExchangeRate> transactions = adminBusiness.GetExchangeRates();
            dataGridViewTransaction.DataSource = transactions;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxCurrencyID.Text == "" || textBoxCurrencyCode.Text == "" || textBoxCountryName.Text == "" || textBoxExchangeRate.Text == "")
            {
                MessageBox.Show("Select ticket!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCurrencyID.Focus();
                return;
            }
            else
            {
                int transactionID = Convert.ToInt32(textBoxCurrencyID.Text);
                string result = adminBusiness.DeleteExchangeRateItem(transactionID);
                MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewTransaction.DataSource = adminBusiness.GetExchangeRates();

                textBoxCurrencyID.Text = "";
                textBoxCurrencyCode.Text = "";
                textBoxCountryName.Text = "";
                textBoxExchangeRate.Text = "";
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxCurrencyID.Text == "" || textBoxCurrencyCode.Text == "" || textBoxCountryName.Text == "" || textBoxExchangeRate.Text == "")
            {
                MessageBox.Show("Select ticket!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCurrencyID.Focus();
                return;
            }

            else if (!Regex.Match(textBoxCurrencyCode.Text, "^[A-Z]{ 3}$").Success)
            {
                MessageBox.Show("The ID number field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCurrencyID.Focus();
                return;
            }

            ExchangeRate exchangeRate= new ExchangeRate();
            exchangeRate.currencyId = textBoxCurrencyID.Text;
            exchangeRate.countryName = textBoxCountryName.Text;
            exchangeRate.currencyCode = textBoxCurrencyCode.Text;
            exchangeRate.meanExchangeRate = Convert.ToInt32(textBoxExchangeRate.Text);

            string result = adminBusiness.UpdateExchangeRateItem(exchangeRate);
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridViewTransaction.DataSource = adminBusiness.GetExchangeRates();

            textBoxCurrencyID.Text = "";
            textBoxCurrencyCode.Text = "";
            textBoxCountryName.Text = "";
            textBoxExchangeRate.Text = "";


        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxCurrencyID.Text == "" || textBoxCurrencyCode.Text == "" || textBoxCountryName.Text == "" || textBoxExchangeRate.Text == "")
            {
                MessageBox.Show("Select ticket!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCurrencyID.Focus();
                return;
            }

            else if (!Regex.Match(textBoxCurrencyCode.Text, "^[A-Z]{ 3}$").Success)
            {
                MessageBox.Show("The ID number field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCurrencyID.Focus();
                return;
            }

            ExchangeRate exchangeRate = new ExchangeRate();
            exchangeRate.currencyId = textBoxCurrencyID.Text;
            exchangeRate.countryName = textBoxCountryName.Text;
            exchangeRate.currencyCode = textBoxCurrencyCode.Text;
            exchangeRate.meanExchangeRate = Convert.ToInt32(textBoxExchangeRate.Text);

            string result = adminBusiness.InsertExchangeRateItem(exchangeRate);
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridViewTransaction.DataSource = adminBusiness.GetExchangeRates();

            textBoxCurrencyID.Text = "";
            textBoxCurrencyCode.Text = "";
            textBoxCountryName.Text = "";
            textBoxExchangeRate.Text = "";
        }
    }
}
