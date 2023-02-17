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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" ||
                textBoxSurname.Text == "" ||
                textBoxID.Text == "" ||
                textBoxPhone.Text == "" ||
                textBoxEmail.Text == "" ||
                textBoxPassword.Text == "") {
                MessageBox.Show("Fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Focus();
                return;
            }

            if (!Regex.Match(textBoxName.Text, "^[A-Z][a-z]*$").Success)
            {
                MessageBox.Show("The name field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Focus();
                return;
            }

            if (!Regex.Match(textBoxSurname.Text, "^[A-Z][a-z]*$").Success)
            {
                MessageBox.Show("The surname field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSurname.Focus();
                return;
            }

            //regex za ID 


            if (!Regex.Match(textBoxPhone.Text, @"^([0][6]\d{1}[0-9]\d{2,3}\d{3,4}$)?").Success)
            {
                MessageBox.Show("The phone number field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPhone.Focus();
                return;
            }


            if (!Regex.Match(textBoxEmail.Text, "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$").Success)
            {
                MessageBox.Show("The email field is not filled in correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmail.Focus();
                return;
            }


            if (!Regex.Match(textBoxPassword.Text, "^[a-zA-Z][a-zA-Z0-9]{9,20}").Success)
            {
                MessageBox.Show("The password field is not filled in correctly! The length of the password must be between 10 and 20 characters!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Focus();
                return;
            }


            //Client client = new Client(textBoxName.Text, textBoxSurname.Text, textBoxID.Text, textBoxPhone.Text, textBoxEmail.Text, textBoxPassword.Text);
            // potrebna insert user metoda koja ce da kupi samo ove podatke i mapira ih u bazu

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
