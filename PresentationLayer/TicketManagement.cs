using BusinessLayer;
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
    public partial class TicketManagement : Form
    {
        private readonly IAdminBusiness adminBusiness;
        public TicketManagement(IAdminBusiness _adminBusiness)
        {
            adminBusiness = _adminBusiness;
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxTicketID.Text == "" || comboBoxTransport.Text == "" || dateTimePickerDeparture.Text == "" || dateTimePickerReturnDate.Text == "")
            {
                MessageBox.Show("Select ticket!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTicketID.Focus();
                return;
            }
            else
            {
                int ticketID = Convert.ToInt32(textBoxTicketID.Text);
                string result = adminBusiness.DeleteTicket(ticketID);
                MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewTickets.DataSource = adminBusiness.GetAllTickets();

                textBoxTicketID.Text = "";
                comboBoxTransport.SelectedIndex = -1;
                dateTimePickerDeparture.Text = "";
                dateTimePickerReturnDate.Text = "";
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxTicketID.Text == "" || comboBoxTransport.Text == "" || dateTimePickerDeparture.Text == "" || dateTimePickerReturnDate.Text == "")
            {
                MessageBox.Show("Select ticket!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTicketID.Focus();
                return;
            }
            else if (!Regex.Match(textBoxTicketID.Text, "^\\d{4}$").Success)
            {
                MessageBox.Show("The ID number field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTicketID.Focus();
                return;
            }

            Ticket ticket = new Ticket();
            ticket.ticketId = Convert.ToInt32(textBoxTicketID.Text);
            ticket.dateOfDeparture = dateTimePickerDeparture.Value;
            ticket.returnDate = dateTimePickerDeparture.Value;

            if (comboBoxTransport.SelectedItem.ToString() == "Autobus")
                ticket.typeOfTransport = "Autobus";
            else
                ticket.typeOfTransport = "Avion";

            string result = adminBusiness.UpdateTicket(ticket);
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridViewTickets.DataSource = adminBusiness.GetAllTickets();

        }

        private void TicketManagement_Load(object sender, EventArgs e)
        {
            List<Ticket> ticketList = adminBusiness.GetAllTickets();
            dataGridViewTickets.DataSource = ticketList;
        }

        private void dataGridViewTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridViewTickets.Rows[e.RowIndex];
                textBoxTicketID.Text = row.Cells[0].Value.ToString();
                dateTimePickerDeparture.Text = row.Cells[1].Value.ToString();
                dateTimePickerReturnDate.Text = row.Cells[2].Value.ToString();
                //comboBoxTransport. = row.Cells[3].Value.ToString();

            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            InsertTicket insertTicket = new InsertTicket();
            insertTicket.Show();
        }
    }
}
