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
        private readonly IClientBusiness clientBusiness;
        Admin admin;

        public InsertTicket(IAdminBusiness _adminBusiness, IClientBusiness _clientBusiness, Admin _admin)
        {
            adminBusiness = _adminBusiness;
            adminBusiness = _adminBusiness;
            clientBusiness = _clientBusiness;
            admin = _admin;
            InitializeComponent();
        }

        private void InsertTicket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aGENCIJADataSet.LOCATIONS' table. You can move, or remove it, as needed.
            this.lOCATIONSTableAdapter.Fill(this.aGENCIJADataSet.LOCATIONS);
            comboBoxTransport.SelectedIndex = 0;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            TicketManagement ticketManagement = new TicketManagement(adminBusiness,clientBusiness, admin);
            ticketManagement.ShowDialog();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == ""  || comboBoxLocation.ValueMember ==null
                || comboBoxTransport.ValueMember ==null || textBoxPrice.Text == "" || textBoxVacancies.Text == "") 
            {
                MessageBox.Show("Fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Focus();
                return;
            }

            Ticket ticket = new Ticket();
            ticket.name = textBoxName.Text;
            ticket.dateOfDeparture = dateTimePickerDeparture.Value;
            ticket.returnDate = dateTimePickerReturn.Value;
            ticket.locationId = Convert.ToInt32(comboBoxLocation.SelectedValue);
            ticket.typeOfTransport = comboBoxTransport.SelectedItem.ToString();
            ticket.price = Convert.ToInt32(textBoxPrice.Text);
            ticket.numberOfVacancies = Convert.ToInt32(textBoxVacancies.Text);

            string result = adminBusiness.InsertTicket(ticket);
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxName.Text = "";
            dateTimePickerDeparture.Text = "";
            dateTimePickerReturn.Text = "";
            textBoxPrice.Text = "";
            textBoxVacancies.Text = "";


        }

    }
}
