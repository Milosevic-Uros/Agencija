namespace PresentationLayer
{
    partial class InsertArrangement
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
            this.dateTimePickerReturn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelINSERT = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxTransportType = new System.Windows.Forms.TextBox();
            this.labelTrnasportType = new System.Windows.Forms.Label();
            this.labelDepartureDate = new System.Windows.Forms.Label();
            this.textBoxVacancies = new System.Windows.Forms.TextBox();
            this.labelVacancies = new System.Windows.Forms.Label();
            this.textBoxLocationID = new System.Windows.Forms.TextBox();
            this.labelLocationID = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxArrangement = new System.Windows.Forms.TextBox();
            this.labelArrangementType = new System.Windows.Forms.Label();
            this.labelReturnDate = new System.Windows.Forms.Label();
            this.textBoxArrangementID = new System.Windows.Forms.TextBox();
            this.labelArrangementID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.dateTimePickerReturn);
            this.panel1.Controls.Add(this.dateTimePickerDeparture);
            this.panel1.Controls.Add(this.buttonInsert);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.textBoxTransportType);
            this.panel1.Controls.Add(this.labelTrnasportType);
            this.panel1.Controls.Add(this.labelDepartureDate);
            this.panel1.Controls.Add(this.textBoxVacancies);
            this.panel1.Controls.Add(this.labelVacancies);
            this.panel1.Controls.Add(this.textBoxLocationID);
            this.panel1.Controls.Add(this.labelLocationID);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.textBoxArrangement);
            this.panel1.Controls.Add(this.labelArrangementType);
            this.panel1.Controls.Add(this.labelReturnDate);
            this.panel1.Controls.Add(this.textBoxArrangementID);
            this.panel1.Controls.Add(this.labelArrangementID);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 451);
            this.panel1.TabIndex = 1;
            // 
            // dateTimePickerReturn
            // 
            this.dateTimePickerReturn.Location = new System.Drawing.Point(88, 236);
            this.dateTimePickerReturn.Name = "dateTimePickerReturn";
            this.dateTimePickerReturn.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerReturn.TabIndex = 25;
            // 
            // dateTimePickerDeparture
            // 
            this.dateTimePickerDeparture.Location = new System.Drawing.Point(535, 154);
            this.dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            this.dateTimePickerDeparture.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDeparture.TabIndex = 24;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(418, 363);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(145, 66);
            this.buttonInsert.TabIndex = 23;
            this.buttonInsert.Text = "Insert arrangement";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(202, 363);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(145, 66);
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
            this.labelINSERT.Location = new System.Drawing.Point(157, 20);
            this.labelINSERT.Name = "labelINSERT";
            this.labelINSERT.Size = new System.Drawing.Size(508, 55);
            this.labelINSERT.TabIndex = 0;
            this.labelINSERT.Text = "Insert new arrangement";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(535, 309);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(147, 22);
            this.textBoxPrice.TabIndex = 20;
            this.textBoxPrice.UseSystemPasswordChar = true;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(531, 278);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(49, 22);
            this.labelPrice.TabIndex = 19;
            this.labelPrice.Text = "Price";
            // 
            // textBoxTransportType
            // 
            this.textBoxTransportType.Location = new System.Drawing.Point(535, 236);
            this.textBoxTransportType.Name = "textBoxTransportType";
            this.textBoxTransportType.Size = new System.Drawing.Size(147, 22);
            this.textBoxTransportType.TabIndex = 18;
            // 
            // labelTrnasportType
            // 
            this.labelTrnasportType.AutoSize = true;
            this.labelTrnasportType.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrnasportType.Location = new System.Drawing.Point(531, 205);
            this.labelTrnasportType.Name = "labelTrnasportType";
            this.labelTrnasportType.Size = new System.Drawing.Size(129, 22);
            this.labelTrnasportType.TabIndex = 17;
            this.labelTrnasportType.Text = "Transport type";
            // 
            // labelDepartureDate
            // 
            this.labelDepartureDate.AutoSize = true;
            this.labelDepartureDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartureDate.Location = new System.Drawing.Point(531, 123);
            this.labelDepartureDate.Name = "labelDepartureDate";
            this.labelDepartureDate.Size = new System.Drawing.Size(133, 22);
            this.labelDepartureDate.TabIndex = 15;
            this.labelDepartureDate.Text = "Departure date";
            // 
            // textBoxVacancies
            // 
            this.textBoxVacancies.Location = new System.Drawing.Point(319, 309);
            this.textBoxVacancies.Name = "textBoxVacancies";
            this.textBoxVacancies.Size = new System.Drawing.Size(147, 22);
            this.textBoxVacancies.TabIndex = 14;
            // 
            // labelVacancies
            // 
            this.labelVacancies.AutoSize = true;
            this.labelVacancies.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVacancies.Location = new System.Drawing.Point(315, 278);
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
            // textBoxArrangement
            // 
            this.textBoxArrangement.Location = new System.Drawing.Point(88, 309);
            this.textBoxArrangement.Name = "textBoxArrangement";
            this.textBoxArrangement.Size = new System.Drawing.Size(147, 22);
            this.textBoxArrangement.TabIndex = 8;
            // 
            // labelArrangementType
            // 
            this.labelArrangementType.AutoSize = true;
            this.labelArrangementType.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrangementType.Location = new System.Drawing.Point(84, 278);
            this.labelArrangementType.Name = "labelArrangementType";
            this.labelArrangementType.Size = new System.Drawing.Size(158, 22);
            this.labelArrangementType.TabIndex = 7;
            this.labelArrangementType.Text = "Arrangement type";
            // 
            // labelReturnDate
            // 
            this.labelReturnDate.AutoSize = true;
            this.labelReturnDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnDate.Location = new System.Drawing.Point(84, 205);
            this.labelReturnDate.Name = "labelReturnDate";
            this.labelReturnDate.Size = new System.Drawing.Size(105, 22);
            this.labelReturnDate.TabIndex = 5;
            this.labelReturnDate.Text = "Return date";
            // 
            // textBoxArrangementID
            // 
            this.textBoxArrangementID.Location = new System.Drawing.Point(88, 154);
            this.textBoxArrangementID.Name = "textBoxArrangementID";
            this.textBoxArrangementID.Size = new System.Drawing.Size(147, 22);
            this.textBoxArrangementID.TabIndex = 4;
            // 
            // labelArrangementID
            // 
            this.labelArrangementID.AutoSize = true;
            this.labelArrangementID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrangementID.Location = new System.Drawing.Point(84, 123);
            this.labelArrangementID.Name = "labelArrangementID";
            this.labelArrangementID.Size = new System.Drawing.Size(140, 22);
            this.labelArrangementID.TabIndex = 3;
            this.labelArrangementID.Text = "Arrangement ID";
            // 
            // InsertArrangement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 448);
            this.Controls.Add(this.panel1);
            this.Name = "InsertArrangement";
            this.Text = "InsertArrangement";
            this.Load += new System.EventHandler(this.InsertArrangement_Load);
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
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTrnasportType;
        private System.Windows.Forms.Label labelDepartureDate;
        private System.Windows.Forms.TextBox textBoxVacancies;
        private System.Windows.Forms.Label labelVacancies;
        private System.Windows.Forms.TextBox textBoxLocationID;
        private System.Windows.Forms.Label labelLocationID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxArrangement;
        private System.Windows.Forms.Label labelArrangementType;
        private System.Windows.Forms.Label labelReturnDate;
        private System.Windows.Forms.TextBox textBoxArrangementID;
        private System.Windows.Forms.Label labelArrangementID;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturn;
        private System.Windows.Forms.TextBox textBoxTransportType;
    }
}