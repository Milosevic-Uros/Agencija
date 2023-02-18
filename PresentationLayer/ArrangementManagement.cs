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
    public partial class ArrangementManagement : Form
    {
        private readonly IAdminBusiness adminBusiness;

        public ArrangementManagement(IAdminBusiness _adminBusiness)
        {
            adminBusiness= _adminBusiness;
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxArrangementID.Text == "" || textBoxLocationID.Text == "" || dateTimePickerDeparture.Text == "" || dateTimePickerReturnDate.Text == "")
            {
                MessageBox.Show("Select arrangement!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxArrangementID.Focus();
                return;
            }
            else
            {
                int arrangementID = Convert.ToInt32(textBoxArrangementID.Text);
                string result = adminBusiness.DeleteArrangement(arrangementID);
                MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewArrangemet.DataSource = adminBusiness.GetAllClients();

                textBoxArrangementID.Text = "";
                textBoxLocationID.Text = "";
                dateTimePickerDeparture.Text = "";
                dateTimePickerReturnDate.Text = "";
            }
        }

        private void ArrangementManagement_Load(object sender, EventArgs e)
        {
            List<Arrangement> accomodationList = adminBusiness.GetAllArrangements();
            dataGridViewArrangemet.DataSource = accomodationList;
        }

        private void dataGridViewArrangemet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridViewArrangemet.Rows[e.RowIndex];
                textBoxArrangementID.Text = row.Cells[0].Value.ToString();
                dateTimePickerDeparture.Text = row.Cells[1].Value.ToString();
                dateTimePickerReturnDate.Text = row.Cells[2].Value.ToString();
                textBoxLocationID.Text = row.Cells[3].Value.ToString();

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxArrangementID.Text == "" || textBoxLocationID.Text == "" || dateTimePickerDeparture.Text == "" || dateTimePickerReturnDate.Text == "")
            {
                MessageBox.Show("Select arrangement!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxArrangementID.Focus();
                return;
            }
            else if (!Regex.Match(textBoxArrangementID.Text, "^\\d{4}$").Success)
            {
                MessageBox.Show("The ID number field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxArrangementID.Focus();
                return;
            }
            else if (!Regex.Match(textBoxLocationID.Text, "^\\d{4}$").Success)
            {
                MessageBox.Show("The ID number field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLocationID.Focus();
                return;
            }

            Arrangement arrangement = new Arrangement();
            arrangement.arrangementId = Convert.ToInt32(textBoxArrangementID.Text);
            arrangement.locationId = Convert.ToInt32(textBoxLocationID.Text);
            arrangement.dateOfDeparture = dateTimePickerDeparture.Value;
            arrangement.returnDate = dateTimePickerReturnDate.Value;
            string result = adminBusiness.UpdateArrangement(arrangement);
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridViewArrangemet.DataSource = adminBusiness.GetAllClients();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            InsertArrangement insertArrangement = new InsertArrangement(adminBusiness);
            insertArrangement.Show();
        }

        private void comboBoxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelClientManagement_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
