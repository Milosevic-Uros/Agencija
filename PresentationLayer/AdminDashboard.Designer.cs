namespace PresentationLayer
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonTransactionManagement = new System.Windows.Forms.Button();
            this.buttonTicketManagement = new System.Windows.Forms.Button();
            this.buttonArrangement = new System.Windows.Forms.Button();
            this.buttonClientManagement = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelLocations = new System.Windows.Forms.Panel();
            this.panelClients = new System.Windows.Forms.Panel();
            this.panelTckets = new System.Windows.Forms.Panel();
            this.panelArrangements = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTckets);
            this.panel1.Controls.Add(this.panelArrangements);
            this.panel1.Controls.Add(this.panelClients);
            this.panel1.Controls.Add(this.panelLocations);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(206, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 460);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panel2.Controls.Add(this.buttonLogOut);
            this.panel2.Controls.Add(this.buttonTransactionManagement);
            this.panel2.Controls.Add(this.buttonTicketManagement);
            this.panel2.Controls.Add(this.buttonArrangement);
            this.panel2.Controls.Add(this.buttonClientManagement);
            this.panel2.Location = new System.Drawing.Point(7, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 377);
            this.panel2.TabIndex = 1;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Location = new System.Drawing.Point(-1, 318);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(203, 50);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonTransactionManagement
            // 
            this.buttonTransactionManagement.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonTransactionManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransactionManagement.Location = new System.Drawing.Point(-1, 226);
            this.buttonTransactionManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTransactionManagement.Name = "buttonTransactionManagement";
            this.buttonTransactionManagement.Size = new System.Drawing.Size(203, 50);
            this.buttonTransactionManagement.TabIndex = 3;
            this.buttonTransactionManagement.Text = "Transaction management";
            this.buttonTransactionManagement.UseVisualStyleBackColor = false;
            this.buttonTransactionManagement.Click += new System.EventHandler(this.buttonTransactionManagement_Click);
            // 
            // buttonTicketManagement
            // 
            this.buttonTicketManagement.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonTicketManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicketManagement.Location = new System.Drawing.Point(-1, 154);
            this.buttonTicketManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTicketManagement.Name = "buttonTicketManagement";
            this.buttonTicketManagement.Size = new System.Drawing.Size(203, 50);
            this.buttonTicketManagement.TabIndex = 2;
            this.buttonTicketManagement.Text = "Ticket management";
            this.buttonTicketManagement.UseVisualStyleBackColor = false;
            this.buttonTicketManagement.Click += new System.EventHandler(this.buttonTicketManagement_Click);
            // 
            // buttonArrangement
            // 
            this.buttonArrangement.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonArrangement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArrangement.Location = new System.Drawing.Point(0, 83);
            this.buttonArrangement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonArrangement.Name = "buttonArrangement";
            this.buttonArrangement.Size = new System.Drawing.Size(203, 50);
            this.buttonArrangement.TabIndex = 1;
            this.buttonArrangement.Text = "Arrangement management";
            this.buttonArrangement.UseVisualStyleBackColor = false;
            this.buttonArrangement.Click += new System.EventHandler(this.buttonArrangement_Click);
            // 
            // buttonClientManagement
            // 
            this.buttonClientManagement.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonClientManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientManagement.Location = new System.Drawing.Point(0, 16);
            this.buttonClientManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClientManagement.Name = "buttonClientManagement";
            this.buttonClientManagement.Size = new System.Drawing.Size(200, 50);
            this.buttonClientManagement.TabIndex = 0;
            this.buttonClientManagement.Text = "Client management";
            this.buttonClientManagement.UseVisualStyleBackColor = false;
            this.buttonClientManagement.Click += new System.EventHandler(this.buttonClientManagement_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.labelWelcome);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 91);
            this.panel3.TabIndex = 23;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(128, 18);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(203, 48);
            this.labelWelcome.TabIndex = 24;
            this.labelWelcome.Text = "Welcome, ";
            // 
            // panelLocations
            // 
            this.panelLocations.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLocations.Location = new System.Drawing.Point(85, 131);
            this.panelLocations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLocations.Name = "panelLocations";
            this.panelLocations.Size = new System.Drawing.Size(191, 128);
            this.panelLocations.TabIndex = 24;
            // 
            // panelClients
            // 
            this.panelClients.BackColor = System.Drawing.Color.SteelBlue;
            this.panelClients.Location = new System.Drawing.Point(331, 131);
            this.panelClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelClients.Name = "panelClients";
            this.panelClients.Size = new System.Drawing.Size(191, 128);
            this.panelClients.TabIndex = 25;
            // 
            // panelTckets
            // 
            this.panelTckets.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTckets.Location = new System.Drawing.Point(331, 288);
            this.panelTckets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTckets.Name = "panelTckets";
            this.panelTckets.Size = new System.Drawing.Size(191, 128);
            this.panelTckets.TabIndex = 27;
            // 
            // panelArrangements
            // 
            this.panelArrangements.BackColor = System.Drawing.Color.SteelBlue;
            this.panelArrangements.Location = new System.Drawing.Point(85, 288);
            this.panelArrangements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelArrangements.Name = "panelArrangements";
            this.panelArrangements.Size = new System.Drawing.Size(191, 128);
            this.panelArrangements.TabIndex = 26;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(211, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(794, 456);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTransactionManagement;
        private System.Windows.Forms.Button buttonTicketManagement;
        private System.Windows.Forms.Button buttonArrangement;
        private System.Windows.Forms.Button buttonClientManagement;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panelTckets;
        private System.Windows.Forms.Panel panelArrangements;
        private System.Windows.Forms.Panel panelClients;
        private System.Windows.Forms.Panel panelLocations;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}