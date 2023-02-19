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
            this.panelClientManagement = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelBought = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelArrangementType = new System.Windows.Forms.Label();
            this.labelDepartureDate = new System.Windows.Forms.Label();
            this.panelClientManagement.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelClientManagement
            // 
            this.panelClientManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panelClientManagement.Controls.Add(this.labelDepartureDate);
            this.panelClientManagement.Controls.Add(this.labelArrangementType);
            this.panelClientManagement.Controls.Add(this.labelLocation);
            this.panelClientManagement.Controls.Add(this.linkLabel1);
            this.panelClientManagement.Controls.Add(this.dateTimePickerDeparture);
            this.panelClientManagement.Controls.Add(this.comboBoxLocation);
            this.panelClientManagement.Controls.Add(this.comboBoxType);
            this.panelClientManagement.Controls.Add(this.buttonSearch);
            this.panelClientManagement.Controls.Add(this.buttonClose);
            this.panelClientManagement.Controls.Add(this.buttonBuy);
            this.panelClientManagement.Controls.Add(this.dataGridView1);
            this.panelClientManagement.Controls.Add(this.label1);
            this.panelClientManagement.Controls.Add(this.panel2);
            this.panelClientManagement.Location = new System.Drawing.Point(1, 0);
            this.panelClientManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelClientManagement.Name = "panelClientManagement";
            this.panelClientManagement.Size = new System.Drawing.Size(1445, 749);
            this.panelClientManagement.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "Find and book your dream arrangement!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.labelBought);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1442, 89);
            this.panel2.TabIndex = 22;
            // 
            // labelBought
            // 
            this.labelBought.AutoSize = true;
            this.labelBought.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBought.Location = new System.Drawing.Point(501, 18);
            this.labelBought.Name = "labelBought";
            this.labelBought.Size = new System.Drawing.Size(453, 55);
            this.labelBought.TabIndex = 0;
            this.labelBought.Text = "Arrangement catalog";
            this.labelBought.Click += new System.EventHandler(this.labelBought_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1445, 319);
            this.dataGridView1.TabIndex = 24;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(357, 643);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(341, 47);
            this.buttonClose.TabIndex = 42;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuy.Location = new System.Drawing.Point(722, 643);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(341, 47);
            this.buttonBuy.TabIndex = 41;
            this.buttonBuy.Text = "Buy arrangement";
            this.buttonBuy.UseVisualStyleBackColor = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(1008, 206);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(176, 32);
            this.buttonSearch.TabIndex = 43;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(578, 211);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(164, 24);
            this.comboBoxType.TabIndex = 44;
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(389, 211);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(166, 24);
            this.comboBoxLocation.TabIndex = 45;
            // 
            // dateTimePickerDeparture
            // 
            this.dateTimePickerDeparture.Location = new System.Drawing.Point(765, 213);
            this.dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            this.dateTimePickerDeparture.Size = new System.Drawing.Size(185, 22);
            this.dateTimePickerDeparture.TabIndex = 46;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(523, 710);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(383, 25);
            this.linkLabel1.TabIndex = 47;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click to see list of all bought arrangements";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(385, 176);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(170, 28);
            this.labelLocation.TabIndex = 48;
            this.labelLocation.Text = "Choose location";
            // 
            // labelArrangementType
            // 
            this.labelArrangementType.AutoSize = true;
            this.labelArrangementType.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrangementType.Location = new System.Drawing.Point(574, 176);
            this.labelArrangementType.Name = "labelArrangementType";
            this.labelArrangementType.Size = new System.Drawing.Size(158, 22);
            this.labelArrangementType.TabIndex = 49;
            this.labelArrangementType.Text = "Arrangement type";
            // 
            // labelDepartureDate
            // 
            this.labelDepartureDate.AutoSize = true;
            this.labelDepartureDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartureDate.Location = new System.Drawing.Point(761, 178);
            this.labelDepartureDate.Name = "labelDepartureDate";
            this.labelDepartureDate.Size = new System.Drawing.Size(133, 22);
            this.labelDepartureDate.TabIndex = 50;
            this.labelDepartureDate.Text = "Departure date";
            // 
            // ArrangementStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 750);
            this.Controls.Add(this.panelClientManagement);
            this.Name = "ArrangementStore";
            this.Text = "ArrangementStore";
            this.panelClientManagement.ResumeLayout(false);
            this.panelClientManagement.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClientManagement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelBought;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelDepartureDate;
        private System.Windows.Forms.Label labelArrangementType;
    }
}