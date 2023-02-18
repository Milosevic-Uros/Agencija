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
            if (textBoxName.Text == ""  || comboBoxLocation.DisplayMember == "" || comboBoxArrangement.DisplayMember == "" || comboBoxTransport.DisplayMember == "" || textBoxVacancies.Text == "" || textBoxPrice.Text == "")
            {
                    MessageBox.Show("Fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxName.Focus();
                    return;
            }
            

            Arrangement arrangement = new Arrangement();
            arrangement.name = textBoxName.Text;
            arrangement.dateOfDeparture = dateTimePickerDeparture.Value;
            arrangement.returnDate = dateTimePickerReturn.Value;
            arrangement.locationId = Convert.ToInt32(comboBoxLocation.ValueMember);
            arrangement.typeofTransport = comboBoxTransport.SelectedItem.ToString();
            arrangement.typeOfArrangement = comboBoxArrangement.DisplayMember;
            arrangement.numberOfVacancies = Convert.ToInt32(textBoxVacancies.Text);
            arrangement.price = Convert.ToInt32(textBoxPrice.Text);


            string result = adminBusiness.InsertArrangement(arrangement);
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxName.Text = "";
            dateTimePickerDeparture.Value = DateTime.Now;
            dateTimePickerReturn.Value = DateTime.Now;
            comboBoxLocation.SelectedIndex = 0;
            comboBoxTransport.SelectedIndex = 0;
            comboBoxArrangement.SelectedIndex = 0;
            textBoxVacancies.Text = "";
            textBoxPrice.Text = "";
        }

        private void InsertArrangement_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
