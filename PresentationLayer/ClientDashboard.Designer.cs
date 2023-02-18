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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlide)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.pictureBoxSlide);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 453);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxSlide
            // 
            this.pictureBoxSlide.Location = new System.Drawing.Point(3, 89);
            this.pictureBoxSlide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSlide.Name = "pictureBoxSlide";
            this.pictureBoxSlide.Size = new System.Drawing.Size(795, 362);
            this.pictureBoxSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSlide.TabIndex = 4;
            this.pictureBoxSlide.TabStop = false;
            this.pictureBoxSlide.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.panel3.Size = new System.Drawing.Size(797, 89);
            this.panel3.TabIndex = 3;
            // 
            // buttonTicket
            // 
            this.buttonTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.buttonTicket.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicket.Location = new System.Drawing.Point(437, 9);
            this.buttonTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Size = new System.Drawing.Size(167, 73);
            this.buttonTicket.TabIndex = 6;
            this.buttonTicket.Text = "Ticket store";
            this.buttonTicket.UseVisualStyleBackColor = false;
            // 
            // buttonArrangements
            // 
            this.buttonArrangements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.buttonArrangements.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArrangements.Location = new System.Drawing.Point(251, 9);
            this.buttonArrangements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonArrangements.Name = "buttonArrangements";
            this.buttonArrangements.Size = new System.Drawing.Size(167, 73);
            this.buttonArrangements.TabIndex = 5;
            this.buttonArrangements.Text = "Arrangement collection";
            this.buttonArrangements.UseVisualStyleBackColor = false;
            // 
            // buttonExchange
            // 
            this.buttonExchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.buttonExchange.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExchange.Location = new System.Drawing.Point(620, 9);
            this.buttonExchange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExchange.Name = "buttonExchange";
            this.buttonExchange.Size = new System.Drawing.Size(167, 73);
            this.buttonExchange.TabIndex = 4;
            this.buttonExchange.Text = "Exchange office";
            this.buttonExchange.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(245, 90);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}