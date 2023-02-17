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
    public partial class InsertArrangement : Form
    {
        private readonly IAdminBusiness adminBusiness;
        public InsertArrangement(IAdminBusiness _adminBusiness)
        {
            adminBusiness= _adminBusiness;
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxArrangementID.Text == "" || textBoxName.Text == "" || dateTimePickerDeparture.Text == "" || dateTimePickerReturn.Text == "" ||
                textBoxLocationID.Text == "" || textBoxTransportType.Text == "" || textBoxArrangement.Text == "" || textBoxVacancies.Text == "" || textBoxPrice.Text == "")
            {
                    MessageBox.Show("Fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxName.Focus();
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
            arrangement.name = textBoxName.Text;
            arrangement.dateOfDeparture = dateTimePickerDeparture.Value;
            arrangement.returnDate = dateTimePickerReturn.Value;
            arrangement.locationId = Convert.ToInt32(textBoxLocationID.Text);
            arrangement.typeofTransport = textBoxTransportType.Text;
            arrangement.typeOfArrangement = textBoxArrangement.Text;
            arrangement.numberOfVacancies = Convert.ToInt32(textBoxVacancies.Text);
            arrangement.price = Convert.ToInt32(textBoxPrice.Text);


            string result = adminBusiness.InsertArrangement(arrangement);
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxArrangementID.Text = "";
            textBoxName.Text = "";
            dateTimePickerDeparture.Text = "";
            dateTimePickerReturn.Text = "";
            textBoxLocationID.Text = "";
            textBoxTransportType.Text = "";
            textBoxArrangement.Text = "";
            textBoxVacancies.Text = "";
            textBoxPrice.Text = "";
        }
    }
}
