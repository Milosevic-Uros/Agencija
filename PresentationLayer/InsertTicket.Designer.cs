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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.lOCATIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aGENCIJADataSet = new PresentationLayer.AGENCIJADataSet();
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
            this.labelLocationID = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelReturn = new System.Windows.Forms.Label();
            this.lOCATIONSTableAdapter = new PresentationLayer.AGENCIJADataSetTableAdapters.LOCATIONSTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOCATIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGENCIJADataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.comboBoxLocation);
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
            this.panel1.Controls.Add(this.labelLocationID);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.labelReturn);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 366);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.DataSource = this.lOCATIONSBindingSource;
            this.comboBoxLocation.DisplayMember = "location_name";
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(80, 193);
            this.comboBoxLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(111, 21);
            this.comboBoxLocation.TabIndex = 4;
            this.comboBoxLocation.ValueMember = "location_id";
            // 
            // lOCATIONSBindingSource
            // 
            this.lOCATIONSBindingSource.DataMember = "LOCATIONS";
            this.lOCATIONSBindingSource.DataSource = this.aGENCIJADataSet;
            // 
            // aGENCIJADataSet
            // 
            this.aGENCIJADataSet.DataSetName = "AGENCIJADataSet";
            this.aGENCIJADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxTransport
            // 
            this.comboBoxTransport.FormattingEnabled = true;
            this.comboBoxTransport.Items.AddRange(new object[] {
            "Airplane",
            "Bus"});
            this.comboBoxTransport.Location = new System.Drawing.Point(224, 192);
            this.comboBoxTransport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTransport.Name = "comboBoxTransport";
            this.comboBoxTransport.Size = new System.Drawing.Size(132, 21);
            this.comboBoxTransport.TabIndex = 5;
            // 
            // dateTimePickerReturn
            // 
            this.dateTimePickerReturn.Location = new System.Drawing.Point(401, 127);
            this.dateTimePickerReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerReturn.Name = "dateTimePickerReturn";
            this.dateTimePickerReturn.Size = new System.Drawing.Size(131, 20);
            this.dateTimePickerReturn.TabIndex = 3;
            // 
            // dateTimePickerDeparture
            // 
            this.dateTimePickerDeparture.Location = new System.Drawing.Point(224, 125);
            this.dateTimePickerDeparture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            this.dateTimePickerDeparture.Size = new System.Drawing.Size(132, 20);
            this.dateTimePickerDeparture.TabIndex = 2;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(314, 295);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(109, 40);
            this.buttonInsert.TabIndex = 8;
            this.buttonInsert.Text = "Insert ticket";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(152, 295);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(109, 40);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.labelINSERT);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 72);
            this.panel2.TabIndex = 21;
            // 
            // labelINSERT
            // 
            this.labelINSERT.AutoSize = true;
            this.labelINSERT.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelINSERT.Location = new System.Drawing.Point(164, 17);
            this.labelINSERT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelINSERT.Name = "labelINSERT";
            this.labelINSERT.Size = new System.Drawing.Size(296, 45);
            this.labelINSERT.TabIndex = 0;
            this.labelINSERT.Text = "Insert new ticket";
            // 
            // labelTicketType
            // 
            this.labelTicketType.AutoSize = true;
            this.labelTicketType.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicketType.Location = new System.Drawing.Point(220, 167);
            this.labelTicketType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTicketType.Name = "labelTicketType";
            this.labelTicketType.Size = new System.Drawing.Size(82, 18);
            this.labelTicketType.TabIndex = 17;
            this.labelTicketType.Text = "Ticket type";
            // 
            // labelDeparture
            // 
            this.labelDeparture.AutoSize = true;
            this.labelDeparture.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeparture.Location = new System.Drawing.Point(220, 100);
            this.labelDeparture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDeparture.Name = "labelDeparture";
            this.labelDeparture.Size = new System.Drawing.Size(110, 18);
            this.labelDeparture.TabIndex = 15;
            this.labelDeparture.Text = "Departure date";
            // 
            // textBoxVacancies
            // 
            this.textBoxVacancies.Location = new System.Drawing.Point(224, 251);
            this.textBoxVacancies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxVacancies.Name = "textBoxVacancies";
            this.textBoxVacancies.Size = new System.Drawing.Size(132, 20);
            this.textBoxVacancies.TabIndex = 7;
            // 
            // labelVacancies
            // 
            this.labelVacancies.AutoSize = true;
            this.labelVacancies.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVacancies.Location = new System.Drawing.Point(220, 225);
            this.labelVacancies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVacancies.Name = "labelVacancies";
            this.labelVacancies.Size = new System.Drawing.Size(73, 18);
            this.labelVacancies.TabIndex = 13;
            this.labelVacancies.Text = "Vacancies";
            // 
            // labelLocationID
            // 
            this.labelLocationID.AutoSize = true;
            this.labelLocationID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationID.Location = new System.Drawing.Point(76, 167);
            this.labelLocationID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLocationID.Name = "labelLocationID";
            this.labelLocationID.Size = new System.Drawing.Size(65, 18);
            this.labelLocationID.TabIndex = 11;
            this.labelLocationID.Text = "Location";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(80, 127);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(111, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(76, 102);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(48, 18);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(401, 193);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(131, 20);
            this.textBoxPrice.TabIndex = 6;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(398, 168);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(42, 18);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Price";
            // 
            // labelReturn
            // 
            this.labelReturn.AutoSize = true;
            this.labelReturn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturn.Location = new System.Drawing.Point(398, 102);
            this.labelReturn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(86, 18);
            this.labelReturn.TabIndex = 5;
            this.labelReturn.Text = "Return date";
            // 
            // lOCATIONSTableAdapter
            // 
            this.lOCATIONSTableAdapter.ClearBeforeFill = true;
            // 
            // InsertTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "InsertTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertTicket";
            this.Load += new System.EventHandler(this.InsertTicket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOCATIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGENCIJADataSet)).EndInit();
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
        private System.Windows.Forms.Label labelLocationID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturn;
        private System.Windows.Forms.ComboBox comboBoxTransport;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private AGENCIJADataSet aGENCIJADataSet;
        private System.Windows.Forms.BindingSource lOCATIONSBindingSource;
        private AGENCIJADataSetTableAdapters.LOCATIONSTableAdapter lOCATIONSTableAdapter;
    }
}