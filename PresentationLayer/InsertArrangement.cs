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
    public partial class InsertArrangement : Form
    {
        private readonly IAdminBusiness adminBusiness;
        private readonly IClientBusiness clientBusiness;
        Admin admin;
        public InsertArrangement(IAdminBusiness _adminBusiness, IClientBusiness _clientBusiness, Admin _admin)
        {
            adminBusiness = _adminBusiness;
            clientBusiness = _clientBusiness;
            admin = _admin;
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            ArrangementManagement arrangementManagement = new ArrangementManagement(adminBusiness,clientBusiness,admin);
            arrangementManagement.ShowDialog();
            this.Close();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == ""  || comboBoxLocation.SelectedValue == "" || comboBoxArrangement.SelectedValue == "" || comboBoxTransport.SelectedValue == "" || textBoxVacancies.Text == "" || textBoxPrice.Text == "")
            {
                    MessageBox.Show("Fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxName.Focus();
                    return;
            }
            

            Arrangement arrangement = new Arrangement();
            arrangement.name = textBoxName.Text;
            arrangement.dateOfDeparture = dateTimePickerDeparture.Value;
            arrangement.returnDate = dateTimePickerReturn.Value;
            arrangement.locationId = Convert.ToInt32(comboBoxLocation.SelectedValue);
            arrangement.typeofTransport = comboBoxTransport.SelectedItem.ToString();
            arrangement.typeOfArrangement = comboBoxArrangement.SelectedItem.ToString();
            arrangement.numberOfVacancies = Convert.ToInt32(textBoxVacancies.Text);
            arrangement.price = Convert.ToInt32(textBoxPrice.Text);
            arrangement.description = "Trip to " + arrangement.name;


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
            this.lOCATIONSTableAdapter.Fill(this.aGENCIJADataSet.LOCATIONS);
            comboBoxTransport.SelectedIndex = 0;
            comboBoxArrangement.SelectedIndex = 0;
        }
    }
}
