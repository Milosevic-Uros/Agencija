namespace PresentationLayer
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.comboBoxLogin = new System.Windows.Forms.ComboBox();
            this.RegisterLabel = new System.Windows.Forms.LinkLabel();
            this.labelDontHaveAnAcc = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.passwordLog = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.usernameLog = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAgency = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogIn.SuspendLayout();
            this.panelAgency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogIn
            // 
            this.panelLogIn.BackColor = System.Drawing.SystemColors.Window;
            this.panelLogIn.Controls.Add(this.comboBoxLogin);
            this.panelLogIn.Controls.Add(this.RegisterLabel);
            this.panelLogIn.Controls.Add(this.labelDontHaveAnAcc);
            this.panelLogIn.Controls.Add(this.buttonLogIn);
            this.panelLogIn.Controls.Add(this.label2);
            this.panelLogIn.Controls.Add(this.Username);
            this.panelLogIn.Controls.Add(this.passwordLog);
            this.panelLogIn.Controls.Add(this.panel4);
            this.panelLogIn.Controls.Add(this.usernameLog);
            this.panelLogIn.Controls.Add(this.panel3);
            this.panelLogIn.Controls.Add(this.label1);
            this.panelLogIn.Location = new System.Drawing.Point(320, 6);
            this.panelLogIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(361, 401);
            this.panelLogIn.TabIndex = 0;
            this.panelLogIn.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBoxLogin
            // 
            this.comboBoxLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLogin.FormattingEnabled = true;
            this.comboBoxLogin.Items.AddRange(new object[] {
            "Admin",
            "Client"});
            this.comboBoxLogin.Location = new System.Drawing.Point(140, 65);
            this.comboBoxLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxLogin.Name = "comboBoxLogin";
            this.comboBoxLogin.Size = new System.Drawing.Size(92, 26);
            this.comboBoxLogin.TabIndex = 9;
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.Location = new System.Drawing.Point(146, 346);
            this.RegisterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(102, 21);
            this.RegisterLabel.TabIndex = 8;
            this.RegisterLabel.TabStop = true;
            this.RegisterLabel.Text = "Register here";
            this.RegisterLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLabel_LinkClicked);
            // 
            // labelDontHaveAnAcc
            // 
            this.labelDontHaveAnAcc.AutoSize = true;
            this.labelDontHaveAnAcc.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDontHaveAnAcc.Location = new System.Drawing.Point(104, 318);
            this.labelDontHaveAnAcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDontHaveAnAcc.Name = "labelDontHaveAnAcc";
            this.labelDontHaveAnAcc.Size = new System.Drawing.Size(189, 21);
            this.labelDontHaveAnAcc.TabIndex = 7;
            this.labelDontHaveAnAcc.Text = "Don\'t have an account?";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.Location = new System.Drawing.Point(140, 258);
            this.buttonLogIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(102, 29);
            this.buttonLogIn.TabIndex = 6;
            this.buttonLogIn.Text = "log in";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(71, 96);
            this.Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(48, 21);
            this.Username.TabIndex = 4;
            this.Username.Text = "Email";
            // 
            // passwordLog
            // 
            this.passwordLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordLog.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLog.Location = new System.Drawing.Point(75, 202);
            this.passwordLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordLog.Name = "passwordLog";
            this.passwordLog.Size = new System.Drawing.Size(278, 24);
            this.passwordLog.TabIndex = 2;
            this.passwordLog.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panel4.Location = new System.Drawing.Point(75, 221);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 8);
            this.panel4.TabIndex = 3;
            // 
            // usernameLog
            // 
            this.usernameLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameLog.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLog.Location = new System.Drawing.Point(75, 131);
            this.usernameLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameLog.Name = "usernameLog";
            this.usernameLog.Size = new System.Drawing.Size(278, 21);
            this.usernameLog.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panel3.Location = new System.Drawing.Point(75, 147);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 8);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOG IN";
            // 
            // panelAgency
            // 
            this.panelAgency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panelAgency.Controls.Add(this.pictureBox2);
            this.panelAgency.Controls.Add(this.pictureBox1);
            this.panelAgency.Location = new System.Drawing.Point(4, -2);
            this.panelAgency.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelAgency.Name = "panelAgency";
            this.panelAgency.Size = new System.Drawing.Size(323, 410);
            this.panelAgency.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(44, 214);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 169);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(689, 417);
            this.Controls.Add(this.panelAgency);
            this.Controls.Add(this.panelLogIn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banja Travel";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.panelAgency.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogIn;
        private System.Windows.Forms.Panel panelAgency;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox usernameLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordLog;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.LinkLabel RegisterLabel;
        private System.Windows.Forms.Label labelDontHaveAnAcc;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBoxLogin;
    }
}

