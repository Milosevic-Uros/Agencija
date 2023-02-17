using BusinessLayer;
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
    public partial class Form1 : Form
    {

        public static string user;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RegisterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();
            Form1 f = new Form1();
            f.Hide();
        }


        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (usernameLog.Text == "" || passwordLog.Text == "") {
                MessageBox.Show("Fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameLog.Focus();
                return;
            }

            user = usernameLog.Text;

            //za svakog korisnika se radi foreach u baza.getallusers i onda lagani if user.username == usernameLog.Text
            // i isto to za oassword sve je uspesno, ako ne: 

            MessageBox.Show("The entered data does not match any user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

            // bolje je da osmislimo samo par usera koji se loguju kao admini i onda proveravamo
            // da li je usernamelog i passwordLog jednak njihovim kredencijalima i onda u zavisnosti od toga
            // imamo otvaranje formi, ako je u pitanju admin otvara se forma AdminDashboard
        }
    }
}
