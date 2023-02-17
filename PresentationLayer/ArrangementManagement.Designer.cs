namespace PresentationLayer
{
    partial class ArrangementManagement
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxLocationID = new System.Windows.Forms.TextBox();
            this.labelLocationID = new System.Windows.Forms.Label();
            this.labelReturnDate = new System.Windows.Forms.Label();
            this.labelDeparture = new System.Windows.Forms.Label();
            this.textBoxArrangementID = new System.Windows.Forms.TextBox();
            this.labelArrangementID = new System.Windows.Forms.Label();
            this.dataGridViewArrangemet = new System.Windows.Forms.DataGridView();
            this.dateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.panelClientManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrangemet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelClientManagement
            // 
            this.panelClientManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panelClientManagement.Controls.Add(this.dateTimePickerReturnDate);
            this.panelClientManagement.Controls.Add(this.dateTimePickerDeparture);
            this.panelClientManagement.Controls.Add(this.buttonDelete);
            this.panelClientManagement.Controls.Add(this.buttonUpdate);
            this.panelClientManagement.Controls.Add(this.buttonInsert);
            this.panelClientManagement.Controls.Add(this.textBoxLocationID);
            this.panelClientManagement.Controls.Add(this.labelLocationID);
            this.panelClientManagement.Controls.Add(this.labelReturnDate);
            this.panelClientManagement.Controls.Add(this.labelDeparture);
            this.panelClientManagement.Controls.Add(this.textBoxArrangementID);
            this.panelClientManagement.Controls.Add(this.labelArrangementID);
            this.panelClientManagement.Controls.Add(this.dataGridViewArrangemet);
            this.panelClientManagement.Location = new System.Drawing.Point(-1, 3);
            this.panelClientManagement.Name = "panelClientManagement";
            this.panelClientManagement.Size = new System.Drawing.Size(802, 445);
            this.panelClientManagement.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(498, 354);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(145, 57);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete arrangement";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(307, 354);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(145, 57);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Update arrangement";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(115, 355);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(145, 56);
            this.buttonInsert.TabIndex = 9;
            this.buttonInsert.Text = "Insert arrangement";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxLocationID
            // 
            this.textBoxLocationID.Location = new System.Drawing.Point(609, 273);
            this.textBoxLocationID.Name = "textBoxLocationID";
            this.textBoxLocationID.Size = new System.Drawing.Size(147, 22);
            this.textBoxLocationID.TabIndex = 8;
            // 
            // labelLocationID
            // 
            this.labelLocationID.AutoSize = true;
            this.labelLocationID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationID.Location = new System.Drawing.Point(605, 242);
            this.labelLocationID.Name = "labelLocationID";
            this.labelLocationID.Size = new System.Drawing.Size(126, 28);
            this.labelLocationID.TabIndex = 7;
            this.labelLocationID.Text = "Location ID";
            // 
            // labelReturnDate
            // 
            this.labelReturnDate.AutoSize = true;
            this.labelReturnDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnDate.Location = new System.Drawing.Point(414, 242);
            this.labelReturnDate.Name = "labelReturnDate";
            this.labelReturnDate.Size = new System.Drawing.Size(131, 28);
            this.labelReturnDate.TabIndex = 5;
            this.labelReturnDate.Text = "Return date";
            // 
            // labelDeparture
            // 
            this.labelDeparture.AutoSize = true;
            this.labelDeparture.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeparture.Location = new System.Drawing.Point(228, 241);
            this.labelDeparture.Name = "labelDeparture";
            this.labelDeparture.Size = new System.Drawing.Size(166, 28);
            this.labelDeparture.TabIndex = 3;
            this.labelDeparture.Text = "Departure date";
            // 
            // textBoxArrangementID
            // 
            this.textBoxArrangementID.Location = new System.Drawing.Point(41, 272);
            this.textBoxArrangementID.Name = "textBoxArrangementID";
            this.textBoxArrangementID.Size = new System.Drawing.Size(147, 22);
            this.textBoxArrangementID.TabIndex = 2;
            // 
            // labelArrangementID
            // 
            this.labelArrangementID.AutoSize = true;
            this.labelArrangementID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrangementID.Location = new System.Drawing.Point(37, 241);
            this.labelArrangementID.Name = "labelArrangementID";
            this.labelArrangementID.Size = new System.Drawing.Size(175, 28);
            this.labelArrangementID.TabIndex = 1;
            this.labelArrangementID.Text = "Arrangement ID";
            // 
            // dataGridViewArrangemet
            // 
            this.dataGridViewArrangemet.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewArrangemet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArrangemet.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewArrangemet.Name = "dataGridViewArrangemet";
            this.dataGridViewArrangemet.RowHeadersWidth = 51;
            this.dataGridViewArrangemet.RowTemplate.Height = 24;
            this.dataGridViewArrangemet.Size = new System.Drawing.Size(796, 177);
            this.dataGridViewArrangemet.TabIndex = 0;
            this.dataGridViewArrangemet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArrangemet_CellContentClick);
            // 
            // dateTimePickerDeparture
            // 
            this.dateTimePickerDeparture.Location = new System.Drawing.Point(232, 273);
            this.dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            this.dateTimePickerDeparture.Size = new System.Drawing.Size(162, 22);
            this.dateTimePickerDeparture.TabIndex = 12;
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(418, 273);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(162, 22);
            this.dateTimePickerReturnDate.TabIndex = 13;
            // 
            // ArrangementManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelClientManagement);
            this.Name = "ArrangementManagement";
            this.Text = "ArrangementManagement";
            this.Load += new System.EventHandler(this.ArrangementManagement_Load);
            this.panelClientManagement.ResumeLayout(false);
            this.panelClientManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrangemet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClientManagement;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxLocationID;
        private System.Windows.Forms.Label labelLocationID;
        private System.Windows.Forms.Label labelReturnDate;
        private System.Windows.Forms.Label labelDeparture;
        private System.Windows.Forms.TextBox textBoxArrangementID;
        private System.Windows.Forms.Label labelArrangementID;
        private System.Windows.Forms.DataGridView dataGridViewArrangemet;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
    }
}