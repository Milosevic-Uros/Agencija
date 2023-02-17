namespace PresentationLayer
{
    partial class Register
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
            System.Windows.Forms.Label labelPassword;
            System.Windows.Forms.Label labelEmail;
            System.Windows.Forms.Label labelSurname;
            System.Windows.Forms.Label labelName;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            System.Windows.Forms.Label labelPhone;
            System.Windows.Forms.Label labelIdNum;
            this.panelAgency = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            labelPassword = new System.Windows.Forms.Label();
            labelEmail = new System.Windows.Forms.Label();
            labelSurname = new System.Windows.Forms.Label();
            labelName = new System.Windows.Forms.Label();
            labelPhone = new System.Windows.Forms.Label();
            labelIdNum = new System.Windows.Forms.Label();
            this.panelAgency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPassword.Location = new System.Drawing.Point(258, 281);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new System.Drawing.Size(86, 23);
            labelPassword.TabIndex = 41;
            labelPassword.Text = "Password";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelEmail.Location = new System.Drawing.Point(62, 281);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(52, 23);
            labelEmail.TabIndex = 38;
            labelEmail.Text = "Email";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSurname.Location = new System.Drawing.Point(257, 106);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new System.Drawing.Size(80, 23);
            labelSurname.TabIndex = 35;
            labelSurname.Text = "Surname";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelName.Location = new System.Drawing.Point(63, 106);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(57, 23);
            labelName.TabIndex = 31;
            labelName.Text = "Name";
            // 
            // panelAgency
            // 
            this.panelAgency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panelAgency.Controls.Add(this.pictureBox2);
            this.panelAgency.Controls.Add(this.pictureBox1);
            this.panelAgency.Location = new System.Drawing.Point(477, -3);
            this.panelAgency.Name = "panelAgency";
            this.panelAgency.Size = new System.Drawing.Size(441, 504);
            this.panelAgency.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.textBoxPhone);
            this.panel1.Controls.Add(labelPhone);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(labelIdNum);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(labelPassword);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(labelEmail);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.textBoxSurname);
            this.panel1.Controls.Add(labelSurname);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(labelName);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.labelSignUp);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 489);
            this.panel1.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(262, 313);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(111, 20);
            this.textBoxPassword.TabIndex = 39;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panel2.Location = new System.Drawing.Point(262, 326);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 10);
            this.panel2.TabIndex = 40;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(66, 313);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 36;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panel7.Location = new System.Drawing.Point(66, 326);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 10);
            this.panel7.TabIndex = 37;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSurname.Location = new System.Drawing.Point(261, 138);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(111, 20);
            this.textBoxSurname.TabIndex = 33;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panel6.Location = new System.Drawing.Point(261, 151);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(111, 10);
            this.panel6.TabIndex = 34;
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(67, 138);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 28;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(154, 393);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(136, 36);
            this.buttonRegister.TabIndex = 32;
            this.buttonRegister.Text = "register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panel5.Location = new System.Drawing.Point(67, 151);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 10);
            this.panel5.TabIndex = 30;
            // 
            // labelSignUp
            // 
            this.labelSignUp.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUp.Location = new System.Drawing.Point(135, 36);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(188, 39);
            this.labelSignUp.TabIndex = 29;
            this.labelSignUp.Text = "REGISTER";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(72, 266);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(318, 208);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(262, 219);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(111, 20);
            this.textBoxPhone.TabIndex = 45;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPhone.Location = new System.Drawing.Point(258, 187);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new System.Drawing.Size(127, 23);
            labelPhone.TabIndex = 47;
            labelPhone.Text = "Phone number";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panel3.Location = new System.Drawing.Point(262, 232);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 10);
            this.panel3.TabIndex = 46;
            // 
            // textBoxID
            // 
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(68, 219);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 42;
            // 
            // labelIdNum
            // 
            labelIdNum.AutoSize = true;
            labelIdNum.Cursor = System.Windows.Forms.Cursors.Default;
            labelIdNum.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelIdNum.Location = new System.Drawing.Point(64, 187);
            labelIdNum.Name = "labelIdNum";
            labelIdNum.Size = new System.Drawing.Size(95, 23);
            labelIdNum.TabIndex = 44;
            labelIdNum.Text = "ID number";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panel4.Location = new System.Drawing.Point(68, 232);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 10);
            this.panel4.TabIndex = 43;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(919, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAgency);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Register";
            this.Text = "Banja Travel";
            this.panelAgency.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAgency;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Panel panel4;
    }
}