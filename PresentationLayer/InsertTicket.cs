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
    public partial class InsertTicket : Form
    {
        private readonly IAdminBusiness adminBusiness;
        public InsertTicket(IAdminBusiness _adminBusiness)
        {
            adminBusiness = _adminBusiness;
            InitializeComponent();
        }

        private void InsertTicket_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxTicketID.Text == "" || textBoxName.Text == ""  || dateTimePickerDeparture.Text == "" || dateTimePickerReturn.Text == "" || textBoxLocationID.Text == ""
                || comboBoxTransport.Text == "" || textBoxPrice.Text == "" || textBoxVacancies.Text == "") 
            {
                MessageBox.Show("Fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Focus();
                return;
            }

            Ticket ticket = new Ticket();
            ticket.ticketId = Convert.ToInt32(textBoxTicketID.Text);
            ticket.name = textBoxName.Text;
            ticket.dateOfDeparture = dateTimePickerDeparture.Value;
            ticket.returnDate = dateTimePickerReturn.Value;
            ticket.locationId = Convert.ToInt32(textBoxLocationID.Text);
            ticket.typeOfTransport = comboBoxTransport.SelectedItem.ToString();
            ticket.price = Convert.ToInt32(textBoxPrice.Text);
            ticket.numberOfVacancies = Convert.ToInt32(textBoxVacancies.Text);

            string result = adminBusiness.InsertTicket(ticket);
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxTicketID.Text = "";
            textBoxName.Text = "";
            dateTimePickerDeparture.Text = "";
            dateTimePickerReturn.Text = "";
            textBoxLocationID.Text = "";
            comboBoxTransport.SelectedItem= null;
            textBoxPrice.Text = "";
            textBoxVacancies.Text = "";


        }
    }
}
