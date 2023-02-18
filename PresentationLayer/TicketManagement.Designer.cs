namespace PresentationLayer
{
    partial class TicketManagement
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
            this.panelClientManagement = new System.Windows.Forms.Panel();
            this.comboBoxTransport = new System.Windows.Forms.ComboBox();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.labelReturnDate = new System.Windows.Forms.Label();
            this.labelDeparture = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.labelTransportType = new System.Windows.Forms.Label();
            this.textBoxTicketID = new System.Windows.Forms.TextBox();
            this.labelTicketID = new System.Windows.Forms.Label();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelClientManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // panelClientManagement
            // 
            this.panelClientManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panelClientManagement.Controls.Add(this.buttonClose);
            this.panelClientManagement.Controls.Add(this.comboBoxTransport);
            this.panelClientManagement.Controls.Add(this.dateTimePickerReturnDate);
            this.panelClientManagement.Controls.Add(this.dateTimePickerDeparture);
            this.panelClientManagement.Controls.Add(this.labelReturnDate);
            this.panelClientManagement.Controls.Add(this.labelDeparture);
            this.panelClientManagement.Controls.Add(this.buttonDelete);
            this.panelClientManagement.Controls.Add(this.buttonUpdate);
            this.panelClientManagement.Controls.Add(this.buttonInsert);
            this.panelClientManagement.Controls.Add(this.labelTransportType);
            this.panelClientManagement.Controls.Add(this.textBoxTicketID);
            this.panelClientManagement.Controls.Add(this.labelTicketID);
            this.panelClientManagement.Controls.Add(this.dataGridViewTickets);
            this.panelClientManagement.Location = new System.Drawing.Point(-1, 2);
            this.panelClientManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelClientManagement.Name = "panelClientManagement";
            this.panelClientManagement.Size = new System.Drawing.Size(803, 446);
            this.panelClientManagement.TabIndex = 1;
            // 
            // comboBoxTransport
            // 
            this.comboBoxTransport.FormattingEnabled = true;
            this.comboBoxTransport.Items.AddRange(new object[] {
            "Airplane",
            "Bus"});
            this.comboBoxTransport.Location = new System.Drawing.Point(609, 273);
            this.comboBoxTransport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTransport.Name = "comboBoxTransport";
            this.comboBoxTransport.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTransport.TabIndex = 18;
            this.comboBoxTransport.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(415, 273);
            this.dateTimePickerReturnDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(161, 22);
            this.dateTimePickerReturnDate.TabIndex = 17;
            // 
            // dateTimePickerDeparture
            // 
            this.dateTimePickerDeparture.Location = new System.Drawing.Point(229, 273);
            this.dateTimePickerDeparture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            this.dateTimePickerDeparture.Size = new System.Drawing.Size(161, 22);
            this.dateTimePickerDeparture.TabIndex = 16;
            // 
            // labelReturnDate
            // 
            this.labelReturnDate.AutoSize = true;
            this.labelReturnDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnDate.Location = new System.Drawing.Point(411, 242);
            this.labelReturnDate.Name = "labelReturnDate";
            this.labelReturnDate.Size = new System.Drawing.Size(105, 22);
            this.labelReturnDate.TabIndex = 15;
            this.labelReturnDate.Text = "Return date";
            // 
            // labelDeparture
            // 
            this.labelDeparture.AutoSize = true;
            this.labelDeparture.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeparture.Location = new System.Drawing.Point(225, 241);
            this.labelDeparture.Name = "labelDeparture";
            this.labelDeparture.Size = new System.Drawing.Size(133, 22);
            this.labelDeparture.TabIndex = 14;
            this.labelDeparture.Text = "Departure date";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(506, 350);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(145, 49);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete ticket";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(314, 350);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(145, 49);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Update ticket";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(122, 350);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(145, 49);
            this.buttonInsert.TabIndex = 9;
            this.buttonInsert.Text = "Insert ticket";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // labelTransportType
            // 
            this.labelTransportType.AutoSize = true;
            this.labelTransportType.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransportType.Location = new System.Drawing.Point(605, 242);
            this.labelTransportType.Name = "labelTransportType";
            this.labelTransportType.Size = new System.Drawing.Size(151, 22);
            this.labelTransportType.TabIndex = 7;
            this.labelTransportType.Text = "Type of transport";
            // 
            // textBoxTicketID
            // 
            this.textBoxTicketID.Location = new System.Drawing.Point(41, 272);
            this.textBoxTicketID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTicketID.Name = "textBoxTicketID";
            this.textBoxTicketID.Size = new System.Drawing.Size(147, 22);
            this.textBoxTicketID.TabIndex = 2;
            // 
            // labelTicketID
            // 
            this.labelTicketID.AutoSize = true;
            this.labelTicketID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicketID.Location = new System.Drawing.Point(37, 241);
            this.labelTicketID.Name = "labelTicketID";
            this.labelTicketID.Size = new System.Drawing.Size(82, 22);
            this.labelTicketID.TabIndex = 1;
            this.labelTicketID.Text = "Ticket ID";
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowHeadersWidth = 51;
            this.dataGridViewTickets.RowTemplate.Height = 24;
            this.dataGridViewTickets.Size = new System.Drawing.Size(796, 177);
            this.dataGridViewTickets.TabIndex = 0;
            this.dataGridViewTickets.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTickets_RowHeaderMouseClick);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(13, 388);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(81, 49);
            this.buttonClose.TabIndex = 33;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // TicketManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelClientManagement);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TicketManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketManagement";
            this.Load += new System.EventHandler(this.TicketManagement_Load);
            this.panelClientManagement.ResumeLayout(false);
            this.panelClientManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClientManagement;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label labelTransportType;
        private System.Windows.Forms.TextBox textBoxTicketID;
        private System.Windows.Forms.Label labelTicketID;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private System.Windows.Forms.Label labelReturnDate;
        private System.Windows.Forms.Label labelDeparture;
        private System.Windows.Forms.ComboBox comboBoxTransport;
        private System.Windows.Forms.Button buttonClose;
    }
}