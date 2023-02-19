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
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (comboBoxLocation.Text == "" || comboBoxType.Text == "" || dateTimePickerDeparture.Text == "")
            {
                MessageBox.Show("Fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxLocation.Focus();
                return;
            }
            else
            {
                //string result = clientBusiness.BookAnArrangement(client, )
                //MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ArrangementStore_Load(object sender, EventArgs e)
        {
            List<Arrangement> arrangements = clientBusiness.GetAllArrangements();
            dataGridViewArrangements.DataSource = arrangements;
        }

        private void dataGridViewArrangements_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewArrangements.Rows[e.RowIndex];
                //nema location u tabeli arrangements, dataset
                //comboBoxLocation.SelectedItem = row.Cells[4].Value.Equals();
                comboBoxType.SelectedItem = row.Cells[6].Value.ToString();
                dateTimePickerDeparture.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());

            }
        }

        private void linkLabelBought_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            BoughtArrangements boughtArrangements = new BoughtArrangements(clientBusiness, adminBusiness, client);
            boughtArrangements.Show();
        }
    }
}
