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

    public partial class TicketStore : Form

    {
        private readonly IAdminBusiness adminBusiness;
        private readonly IClientBusiness clientBusiness;
        Client client;
        public TicketStore(IAdminBusiness _adminBusiness, IClientBusiness _clientBusiness, Client _client)
        {
            adminBusiness = _adminBusiness;
            clientBusiness = _clientBusiness;
            client = _client;
            InitializeComponent();
           
        }

        private void TicketStore_Load(object sender, EventArgs e)
        {
            List<Ticket> tickets = adminBusiness.GetAllTickets();
            dataGridViewTickets.DataSource = tickets;
        }


        private void dataGridViewTickets_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewTickets.Rows[e.RowIndex];
                textBoxTicketID.Text = row.Cells[0].Value.ToString();

            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (textBoxAmount.Text == "")
            {
                MessageBox.Show("Provide amount that you want to buy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAmount.Focus();
                return;
            }
            else if (!Regex.Match(textBoxAmount.Text, "^[0-9]*$").Success)
            {
                MessageBox.Show("Amount field accepts only numbers!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAmount.Focus();
                return;
            }
            else
            {
                string result = clientBusiness.BookATicket(client, Convert.ToInt32(textBoxTicketID.Text), Convert.ToInt32(textBoxAmount.Text));
                MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void labelBought_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BoughtTickets boughtTickets = new BoughtTickets(clientBusiness, adminBusiness, client);
            boughtTickets.Show();
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            ClientDashboard clientDashboard = new ClientDashboard(adminBusiness, clientBusiness, client);
            clientDashboard.Show();
        }
    }
}
