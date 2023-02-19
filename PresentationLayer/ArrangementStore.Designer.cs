namespace PresentationLayer
{
    partial class ArrangementStore
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
            this.panelClientManagement = new System.Windows.Forms.Panel();
            this.labelDepartureDate = new System.Windows.Forms.Label();
            this.labelArrangementType = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.linkLabelBought = new System.Windows.Forms.LinkLabel();
            this.dateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.dataGridViewArrangements = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelBought = new System.Windows.Forms.Label();
            this.aGENCIJADataSet4 = new PresentationLayer.AGENCIJADataSet4();
            this.lOCATIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOCATIONSTableAdapter = new PresentationLayer.AGENCIJADataSet4TableAdapters.LOCATIONSTableAdapter();
            this.panelClientManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrangements)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aGENCIJADataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOCATIONSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelClientManagement
            // 
            this.panelClientManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panelClientManagement.Controls.Add(this.labelDepartureDate);
            this.panelClientManagement.Controls.Add(this.labelArrangementType);
            this.panelClientManagement.Controls.Add(this.labelLocation);
            this.panelClientManagement.Controls.Add(this.linkLabelBought);
            this.panelClientManagement.Controls.Add(this.dateTimePickerDeparture);
            this.panelClientManagement.Controls.Add(this.comboBoxLocation);
            this.panelClientManagement.Controls.Add(this.comboBoxType);
            this.panelClientManagement.Controls.Add(this.buttonSearch);
            this.panelClientManagement.Controls.Add(this.buttonClose);
            this.panelClientManagement.Controls.Add(this.buttonBuy);
            this.panelClientManagement.Controls.Add(this.dataGridViewArrangements);
            this.panelClientManagement.Controls.Add(this.label1);
            this.panelClientManagement.Controls.Add(this.panel2);
            this.panelClientManagement.Location = new System.Drawing.Point(1, 0);
            this.panelClientManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelClientManagement.Name = "panelClientManagement";
            this.panelClientManagement.Size = new System.Drawing.Size(1084, 609);
            this.panelClientManagement.TabIndex = 4;
            // 
            // labelDepartureDate
            // 
            this.labelDepartureDate.AutoSize = true;
            this.labelDepartureDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartureDate.Location = new System.Drawing.Point(604, 145);
            this.labelDepartureDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDepartureDate.Name = "labelDepartureDate";
            this.labelDepartureDate.Size = new System.Drawing.Size(110, 18);
            this.labelDepartureDate.TabIndex = 50;
            this.labelDepartureDate.Text = "Departure date";
            // 
            // labelArrangementType
            // 
            this.labelArrangementType.AutoSize = true;
            this.labelArrangementType.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrangementType.Location = new System.Drawing.Point(443, 143);
            this.labelArrangementType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelArrangementType.Name = "labelArrangementType";
            this.labelArrangementType.Size = new System.Drawing.Size(131, 18);
            this.labelArrangementType.TabIndex = 49;
            this.labelArrangementType.Text = "Arrangement type";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(286, 143);
            this.labelLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(115, 18);
            this.labelLocation.TabIndex = 48;
            this.labelLocation.Text = "Choose location";
            // 
            // linkLabelBought
            // 
            this.linkLabelBought.AutoSize = true;
            this.linkLabelBought.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBought.Location = new System.Drawing.Point(385, 577);
            this.linkLabelBought.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelBought.Name = "linkLabelBought";
            this.linkLabelBought.Size = new System.Drawing.Size(305, 21);
            this.linkLabelBought.TabIndex = 47;
            this.linkLabelBought.TabStop = true;
            this.linkLabelBought.Text = "Click to see list of all bought arrangements";
            this.linkLabelBought.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBought_LinkClicked);
            // 
            // dateTimePickerDeparture
            // 
            this.dateTimePickerDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDeparture.Location = new System.Drawing.Point(608, 173);
            this.dateTimePickerDeparture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            this.dateTimePickerDeparture.Size = new System.Drawing.Size(107, 20);
            this.dateTimePickerDeparture.TabIndex = 46;
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.DataSource = this.lOCATIONSBindingSource;
            this.comboBoxLocation.DisplayMember = "location_name";
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(290, 171);
            this.comboBoxLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(126, 21);
            this.comboBoxLocation.TabIndex = 45;
            this.comboBoxLocation.ValueMember = "location_id";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "First minute",
            "Last minute",
            "Sightseeing tour",
            "Business travel",
            "Field trip"});
            this.comboBoxType.Location = new System.Drawing.Point(446, 171);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(123, 21);
            this.comboBoxType.TabIndex = 44;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(754, 167);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(132, 26);
            this.buttonSearch.TabIndex = 43;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(260, 522);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(256, 38);
            this.buttonClose.TabIndex = 42;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuy.Location = new System.Drawing.Point(534, 522);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(256, 38);
            this.buttonBuy.TabIndex = 41;
            this.buttonBuy.Text = "Buy arrangement";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // dataGridViewArrangements
            // 
            this.dataGridViewArrangements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArrangements.Location = new System.Drawing.Point(0, 230);
            this.dataGridViewArrangements.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewArrangements.Name = "dataGridViewArrangements";
            this.dataGridViewArrangements.RowHeadersWidth = 51;
            this.dataGridViewArrangements.RowTemplate.Height = 24;
            this.dataGridViewArrangements.Size = new System.Drawing.Size(1084, 259);
            this.dataGridViewArrangements.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Find and book your dream arrangement!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.labelBought);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 72);
            this.panel2.TabIndex = 22;
            // 
            // labelBought
            // 
            this.labelBought.AutoSize = true;
            this.labelBought.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBought.Location = new System.Drawing.Point(374, 15);
            this.labelBought.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBought.Name = "labelBought";
            this.labelBought.Size = new System.Drawing.Size(372, 45);
            this.labelBought.TabIndex = 0;
            this.labelBought.Text = "Arrangement catalog";
            this.labelBought.Click += new System.EventHandler(this.labelBought_Click);
            // 
            // aGENCIJADataSet4
            // 
            this.aGENCIJADataSet4.DataSetName = "AGENCIJADataSet4";
            this.aGENCIJADataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOCATIONSBindingSource
            // 
            this.lOCATIONSBindingSource.DataMember = "LOCATIONS";
            this.lOCATIONSBindingSource.DataSource = this.aGENCIJADataSet4;
            // 
            // lOCATIONSTableAdapter
            // 
            this.lOCATIONSTableAdapter.ClearBeforeFill = true;
            // 
            // ArrangementStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 609);
            this.Controls.Add(this.panelClientManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ArrangementStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArrangementStore";
            this.Load += new System.EventHandler(this.ArrangementStore_Load);
            this.panelClientManagement.ResumeLayout(false);
            this.panelClientManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrangements)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aGENCIJADataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOCATIONSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClientManagement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelBought;
        private System.Windows.Forms.DataGridView dataGridViewArrangements;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.LinkLabel linkLabelBought;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelDepartureDate;
        private System.Windows.Forms.Label labelArrangementType;
        private AGENCIJADataSet4 aGENCIJADataSet4;
        private System.Windows.Forms.BindingSource lOCATIONSBindingSource;
        private AGENCIJADataSet4TableAdapters.LOCATIONSTableAdapter lOCATIONSTableAdapter;
    }
}