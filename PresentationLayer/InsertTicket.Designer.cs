namespace PresentationLayer
{
    partial class InsertTicket
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
            this.comboBoxTransport = new System.Windows.Forms.ComboBox();
            this.dateTimePickerReturn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelINSERT = new System.Windows.Forms.Label();
            this.labelTicketType = new System.Windows.Forms.Label();
            this.labelDeparture = new System.Windows.Forms.Label();
            this.textBoxVacancies = new System.Windows.Forms.TextBox();
            this.labelVacancies = new System.Windows.Forms.Label();
            this.textBoxLocationID = new System.Windows.Forms.TextBox();
            this.labelLocationID = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelReturn = new System.Windows.Forms.Label();
            this.textBoxTicketID = new System.Windows.Forms.TextBox();
            this.labelTciketID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.comboBoxTransport);
            this.panel1.Controls.Add(this.dateTimePickerReturn);
            this.panel1.Controls.Add(this.dateTimePickerDeparture);
            this.panel1.Controls.Add(this.buttonInsert);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelTicketType);
            this.panel1.Controls.Add(this.labelDeparture);
            this.panel1.Controls.Add(this.textBoxVacancies);
            this.panel1.Controls.Add(this.labelVacancies);
            this.panel1.Controls.Add(this.textBoxLocationID);
            this.panel1.Controls.Add(this.labelLocationID);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.labelReturn);
            this.panel1.Controls.Add(this.textBoxTicketID);
            this.panel1.Controls.Add(this.labelTciketID);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 451);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxTransport
            // 
            this.comboBoxTransport.FormattingEnabled = true;
            this.comboBoxTransport.Location = new System.Drawing.Point(535, 236);
            this.comboBoxTransport.Name = "comboBoxTransport";
            this.comboBoxTransport.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTransport.TabIndex = 27;
            // 
            // dateTimePickerReturn
            // 
            this.dateTimePickerReturn.Location = new System.Drawing.Point(88, 236);
            this.dateTimePickerReturn.Name = "dateTimePickerReturn";
            this.dateTimePickerReturn.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerReturn.TabIndex = 26;
            // 
            // dateTimePickerDeparture
            // 
            this.dateTimePickerDeparture.Location = new System.Drawing.Point(535, 154);
            this.dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            this.dateTimePickerDeparture.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDeparture.TabIndex = 25;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(418, 363);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(145, 49);
            this.buttonInsert.TabIndex = 23;
            this.buttonInsert.Text = "Insert ticket";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(202, 363);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(145, 49);
            this.buttonClose.TabIndex = 22;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.labelINSERT);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 89);
            this.panel2.TabIndex = 21;
            // 
            // labelINSERT
            // 
            this.labelINSERT.AutoSize = true;
            this.labelINSERT.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelINSERT.Location = new System.Drawing.Point(219, 21);
            this.labelINSERT.Name = "labelINSERT";
            this.labelINSERT.Size = new System.Drawing.Size(361, 55);
            this.labelINSERT.TabIndex = 0;
            this.labelINSERT.Text = "Insert new ticket";
            // 
            // labelTicketType
            // 
            this.labelTicketType.AutoSize = true;
            this.labelTicketType.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicketType.Location = new System.Drawing.Point(531, 205);
            this.labelTicketType.Name = "labelTicketType";
            this.labelTicketType.Size = new System.Drawing.Size(100, 22);
            this.labelTicketType.TabIndex = 17;
            this.labelTicketType.Text = "Ticket type";
            // 
            // labelDeparture
            // 
            this.labelDeparture.AutoSize = true;
            this.labelDeparture.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeparture.Location = new System.Drawing.Point(531, 123);
            this.labelDeparture.Name = "labelDeparture";
            this.labelDeparture.Size = new System.Drawing.Size(133, 22);
            this.labelDeparture.TabIndex = 15;
            this.labelDeparture.Text = "Departure date";
            // 
            // textBoxVacancies
            // 
            this.textBoxVacancies.Location = new System.Drawing.Point(439, 309);
            this.textBoxVacancies.Name = "textBoxVacancies";
            this.textBoxVacancies.Size = new System.Drawing.Size(147, 22);
            this.textBoxVacancies.TabIndex = 14;
            // 
            // labelVacancies
            // 
            this.labelVacancies.AutoSize = true;
            this.labelVacancies.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVacancies.Location = new System.Drawing.Point(435, 278);
            this.labelVacancies.Name = "labelVacancies";
            this.labelVacancies.Size = new System.Drawing.Size(86, 22);
            this.labelVacancies.TabIndex = 13;
            this.labelVacancies.Text = "Vacancies";
            // 
            // textBoxLocationID
            // 
            this.textBoxLocationID.Location = new System.Drawing.Point(319, 236);
            this.textBoxLocationID.Name = "textBoxLocationID";
            this.textBoxLocationID.Size = new System.Drawing.Size(147, 22);
            this.textBoxLocationID.TabIndex = 12;
            // 
            // labelLocationID
            // 
            this.labelLocationID.AutoSize = true;
            this.labelLocationID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationID.Location = new System.Drawing.Point(315, 205);
            this.labelLocationID.Name = "labelLocationID";
            this.labelLocationID.Size = new System.Drawing.Size(101, 22);
            this.labelLocationID.TabIndex = 11;
            this.labelLocationID.Text = "Location ID";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(319, 154);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(147, 22);
            this.textBoxName.TabIndex = 10;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(315, 123);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 22);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(208, 309);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(147, 22);
            this.textBoxPrice.TabIndex = 8;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(204, 278);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(49, 22);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Price";
            // 
            // labelReturn
            // 
            this.labelReturn.AutoSize = true;
            this.labelReturn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturn.Location = new System.Drawing.Point(84, 205);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(105, 22);
            this.labelReturn.TabIndex = 5;
            this.labelReturn.Text = "Return date";
            // 
            // textBoxTicketID
            // 
            this.textBoxTicketID.Location = new System.Drawing.Point(88, 154);
            this.textBoxTicketID.Name = "textBoxTicketID";
            this.textBoxTicketID.Size = new System.Drawing.Size(147, 22);
            this.textBoxTicketID.TabIndex = 4;
            // 
            // labelTciketID
            // 
            this.labelTciketID.AutoSize = true;
            this.labelTciketID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTciketID.Location = new System.Drawing.Point(84, 123);
            this.labelTciketID.Name = "labelTciketID";
            this.labelTciketID.Size = new System.Drawing.Size(82, 22);
            this.labelTciketID.TabIndex = 3;
            this.labelTciketID.Text = "Ticket ID";
            // 
            // InsertTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "InsertTicket";
            this.Text = "InsertTicket";
            this.Load += new System.EventHandler(this.InsertTicket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelINSERT;
        private System.Windows.Forms.Label labelTicketType;
        private System.Windows.Forms.Label labelDeparture;
        private System.Windows.Forms.TextBox textBoxVacancies;
        private System.Windows.Forms.Label labelVacancies;
        private System.Windows.Forms.TextBox textBoxLocationID;
        private System.Windows.Forms.Label labelLocationID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.TextBox textBoxTicketID;
        private System.Windows.Forms.Label labelTciketID;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturn;
        private System.Windows.Forms.ComboBox comboBoxTransport;
    }
}