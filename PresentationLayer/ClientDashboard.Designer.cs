namespace PresentationLayer
{
    partial class ClientDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelLoggedIn = new System.Windows.Forms.Label();
            this.buttonBoughtArrangements = new System.Windows.Forms.Button();
            this.buttonBoughtTickets = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.pictureBoxSlide = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonTicket = new System.Windows.Forms.Button();
            this.buttonArrangements = new System.Windows.Forms.Button();
            this.buttonExchange = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlide)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBoxSlide);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 495);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.labelLoggedIn);
            this.panel4.Controls.Add(this.buttonBoughtArrangements);
            this.panel4.Controls.Add(this.buttonBoughtTickets);
            this.panel4.Controls.Add(this.buttonLogOut);
            this.panel4.Location = new System.Drawing.Point(0, 89);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 404);
            this.panel4.TabIndex = 5;
            // 
            // labelLoggedIn
            // 
            this.labelLoggedIn.AutoSize = true;
            this.labelLoggedIn.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoggedIn.Location = new System.Drawing.Point(23, 238);
            this.labelLoggedIn.Name = "labelLoggedIn";
            this.labelLoggedIn.Size = new System.Drawing.Size(121, 23);
            this.labelLoggedIn.TabIndex = 7;
            this.labelLoggedIn.Text = "Logged in as:";
            // 
            // buttonBoughtArrangements
            // 
            this.buttonBoughtArrangements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.buttonBoughtArrangements.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBoughtArrangements.Location = new System.Drawing.Point(27, 34);
            this.buttonBoughtArrangements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBoughtArrangements.Name = "buttonBoughtArrangements";
            this.buttonBoughtArrangements.Size = new System.Drawing.Size(167, 57);
            this.buttonBoughtArrangements.TabIndex = 4;
            this.buttonBoughtArrangements.Text = "Bought arrangements";
            this.buttonBoughtArrangements.UseVisualStyleBackColor = false;
            this.buttonBoughtArrangements.Click += new System.EventHandler(this.buttonBoughtArrangements_Click);
            // 
            // buttonBoughtTickets
            // 
            this.buttonBoughtTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.buttonBoughtTickets.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBoughtTickets.Location = new System.Drawing.Point(28, 111);
            this.buttonBoughtTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBoughtTickets.Name = "buttonBoughtTickets";
            this.buttonBoughtTickets.Size = new System.Drawing.Size(167, 44);
            this.buttonBoughtTickets.TabIndex = 5;
            this.buttonBoughtTickets.Text = "Bought tickets";
            this.buttonBoughtTickets.UseVisualStyleBackColor = false;
            this.buttonBoughtTickets.Click += new System.EventHandler(this.buttonBoughtTickets_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Location = new System.Drawing.Point(27, 334);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(167, 44);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // pictureBoxSlide
            // 
            this.pictureBoxSlide.Location = new System.Drawing.Point(220, 89);
            this.pictureBoxSlide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSlide.Name = "pictureBoxSlide";
            this.pictureBoxSlide.Size = new System.Drawing.Size(652, 404);
            this.pictureBoxSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSlide.TabIndex = 4;
            this.pictureBoxSlide.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.buttonTicket);
            this.panel3.Controls.Add(this.buttonArrangements);
            this.panel3.Controls.Add(this.buttonExchange);
            this.panel3.Controls.Add(this.pictureBoxLogo);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 89);
            this.panel3.TabIndex = 3;
            // 
            // buttonTicket
            // 
            this.buttonTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.buttonTicket.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicket.Location = new System.Drawing.Point(465, 9);
            this.buttonTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Size = new System.Drawing.Size(167, 73);
            this.buttonTicket.TabIndex = 2;
            this.buttonTicket.Text = "Ticket store";
            this.buttonTicket.UseVisualStyleBackColor = false;
            this.buttonTicket.Click += new System.EventHandler(this.buttonTicket_Click);
            // 
            // buttonArrangements
            // 
            this.buttonArrangements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.buttonArrangements.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArrangements.Location = new System.Drawing.Point(279, 9);
            this.buttonArrangements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonArrangements.Name = "buttonArrangements";
            this.buttonArrangements.Size = new System.Drawing.Size(167, 73);
            this.buttonArrangements.TabIndex = 1;
            this.buttonArrangements.Text = "Arrangement catalog";
            this.buttonArrangements.UseVisualStyleBackColor = false;
            this.buttonArrangements.Click += new System.EventHandler(this.buttonArrangements_Click);
            // 
            // buttonExchange
            // 
            this.buttonExchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.buttonExchange.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExchange.Location = new System.Drawing.Point(648, 9);
            this.buttonExchange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExchange.Name = "buttonExchange";
            this.buttonExchange.Size = new System.Drawing.Size(167, 73);
            this.buttonExchange.TabIndex = 3;
            this.buttonExchange.Text = "Exchange office";
            this.buttonExchange.UseVisualStyleBackColor = false;
            this.buttonExchange.Click += new System.EventHandler(this.buttonExchange_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(221, 90);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(148, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 92);
            this.panel2.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.jpg");
            this.imageList1.Images.SetKeyName(1, "2.jpg");
            this.imageList1.Images.SetKeyName(2, "3.jpg");
            this.imageList1.Images.SetKeyName(3, "4.jpg");
            this.imageList1.Images.SetKeyName(4, "5.jpg");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ClientDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientDashboard";
            this.Load += new System.EventHandler(this.ClientDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlide)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonTicket;
        private System.Windows.Forms.Button buttonArrangements;
        private System.Windows.Forms.Button buttonExchange;
        private System.Windows.Forms.PictureBox pictureBoxSlide;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label labelLoggedIn;
        private System.Windows.Forms.Button buttonBoughtArrangements;
        private System.Windows.Forms.Button buttonBoughtTickets;
    }
}