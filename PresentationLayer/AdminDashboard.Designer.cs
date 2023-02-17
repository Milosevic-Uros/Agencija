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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonTransactionManagement = new System.Windows.Forms.Button();
            this.buttonTicketManagement = new System.Windows.Forms.Button();
            this.buttonArrangement = new System.Windows.Forms.Button();
            this.buttonClientManagement = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(220, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 402);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonLogOut);
            this.panel2.Controls.Add(this.buttonTransactionManagement);
            this.panel2.Controls.Add(this.buttonTicketManagement);
            this.panel2.Controls.Add(this.buttonArrangement);
            this.panel2.Controls.Add(this.buttonClientManagement);
            this.panel2.Location = new System.Drawing.Point(12, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 510);
            this.panel2.TabIndex = 1;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Location = new System.Drawing.Point(-1, 344);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(202, 51);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonTransactionManagement
            // 
            this.buttonTransactionManagement.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonTransactionManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransactionManagement.Location = new System.Drawing.Point(-1, 248);
            this.buttonTransactionManagement.Name = "buttonTransactionManagement";
            this.buttonTransactionManagement.Size = new System.Drawing.Size(202, 51);
            this.buttonTransactionManagement.TabIndex = 3;
            this.buttonTransactionManagement.Text = "Transaction management";
            this.buttonTransactionManagement.UseVisualStyleBackColor = false;
            // 
            // buttonTicketManagement
            // 
            this.buttonTicketManagement.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonTicketManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicketManagement.Location = new System.Drawing.Point(-1, 170);
            this.buttonTicketManagement.Name = "buttonTicketManagement";
            this.buttonTicketManagement.Size = new System.Drawing.Size(202, 51);
            this.buttonTicketManagement.TabIndex = 2;
            this.buttonTicketManagement.Text = "Ticket management";
            this.buttonTicketManagement.UseVisualStyleBackColor = false;
            // 
            // buttonArrangement
            // 
            this.buttonArrangement.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonArrangement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArrangement.Location = new System.Drawing.Point(0, 88);
            this.buttonArrangement.Name = "buttonArrangement";
            this.buttonArrangement.Size = new System.Drawing.Size(202, 51);
            this.buttonArrangement.TabIndex = 1;
            this.buttonArrangement.Text = "Arrangement management";
            this.buttonArrangement.UseVisualStyleBackColor = false;
            this.buttonArrangement.Click += new System.EventHandler(this.buttonArrangement_Click);
            // 
            // buttonClientManagement
            // 
            this.buttonClientManagement.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonClientManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientManagement.Location = new System.Drawing.Point(0, 10);
            this.buttonClientManagement.Name = "buttonClientManagement";
            this.buttonClientManagement.Size = new System.Drawing.Size(200, 51);
            this.buttonClientManagement.TabIndex = 0;
            this.buttonClientManagement.Text = "Client management";
            this.buttonClientManagement.UseVisualStyleBackColor = false;
            this.buttonClientManagement.Click += new System.EventHandler(this.buttonClientManagement_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(735, 410);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel2.ResumeLayout(false);
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
    }
}