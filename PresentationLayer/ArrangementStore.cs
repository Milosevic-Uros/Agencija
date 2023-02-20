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
    public partial class ArrangementStore : Form
    {
        private readonly IAdminBusiness adminBusiness;
        private readonly IClientBusiness clientBusiness;
        Client client;
        public ArrangementStore(IAdminBusiness _adminBusiness, IClientBusiness _clientBusiness, Client _client)
        {
            adminBusiness = _adminBusiness;
            clientBusiness = _clientBusiness;
            client= _client;
            InitializeComponent();
        }

        private void labelBought_Click(object sender, EventArgs e)
        {
            BoughtArrangements boughtArrangements = new BoughtArrangements(clientBusiness, adminBusiness, client);
            boughtArrangements.Show();
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            ClientDashboard clientDashboard = new ClientDashboard(adminBusiness, clientBusiness, client);
            clientDashboard.Show();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (textBoxArrangementID.Text=="" || comboBoxType.Text == "" || !Regex.Match(textBoxArrangementID.Text, "^[0-9]*$").Success)
            {
                MessageBox.Show("Fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxLocation.Focus();
                return;
            }
            else
            {
                DialogResult dialogres = MessageBox.Show("Are you sure you want to reserve this arrangement?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogres == DialogResult.Yes)
                {
                    string result = clientBusiness.BookAnArrangement(client.clientId, Convert.ToInt32(textBoxArrangementID.Text), 1);
                    MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Arrangement> arrangements = clientBusiness.GetAllArrangements();
                    dataGridViewArrangements.DataSource = arrangements;
                }
            }
        }

        private void ArrangementStore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aGENCIJADataSet4.LOCATIONS' table. You can move, or remove it, as needed.
            this.lOCATIONSTableAdapter.Fill(this.aGENCIJADataSet4.LOCATIONS);
            List<Arrangement> arrangements = clientBusiness.GetAllArrangements();
            dataGridViewArrangements.DataSource = arrangements;
            comboBoxType.SelectedIndex = 0;
        }

        private void dataGridViewArrangements_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewArrangements.Rows[e.RowIndex];
                textBoxArrangementID.Text = row.Cells[0].Value.ToString();

            }
        }

        private void linkLabelBought_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            BoughtArrangements boughtArrangements = new BoughtArrangements(clientBusiness, adminBusiness, client);
            boughtArrangements.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int locationId = Convert.ToInt32(comboBoxLocation.SelectedValue);

            string item = comboBoxType.SelectedItem.ToString();
            int index = comboBoxType.Items.IndexOf(item);
            string type = comboBoxType.Items[index].ToString();
            DateTime date = dateTimePickerDeparture.Value;
            List<Object> lista= clientBusiness.GetAllArrangementsByLocationTypeAndDate(locationId, type, date);
            dataGridViewArrangements.DataSource = lista;
            /*comment*/

            
        }
    }
}
