namespace PresentationLayer
{
    partial class ClientManagement
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
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.labelPhoneNum = new System.Windows.Forms.Label();
            this.textBoxIDNumber = new System.Windows.Forms.TextBox();
            this.labelIDnum = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.panelClientManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // panelClientManagement
            // 
            this.panelClientManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panelClientManagement.Controls.Add(this.buttonDelete);
            this.panelClientManagement.Controls.Add(this.buttonUpdate);
            this.panelClientManagement.Controls.Add(this.buttonInsert);
            this.panelClientManagement.Controls.Add(this.textBoxPhoneNum);
            this.panelClientManagement.Controls.Add(this.labelPhoneNum);
            this.panelClientManagement.Controls.Add(this.textBoxIDNumber);
            this.panelClientManagement.Controls.Add(this.labelIDnum);
            this.panelClientManagement.Controls.Add(this.textBoxLastname);
            this.panelClientManagement.Controls.Add(this.labelSurname);
            this.panelClientManagement.Controls.Add(this.textBoxName);
            this.panelClientManagement.Controls.Add(this.labelName);
            this.panelClientManagement.Controls.Add(this.dataGridViewClients);
            this.panelClientManagement.Location = new System.Drawing.Point(-2, 1);
            this.panelClientManagement.Name = "panelClientManagement";
            this.panelClientManagement.Size = new System.Drawing.Size(802, 445);
            this.panelClientManagement.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(498, 354);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(145, 49);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete client";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(307, 354);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(145, 49);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Update client";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(115, 355);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(145, 49);
            this.buttonInsert.TabIndex = 9;
            this.buttonInsert.Text = "Insert client";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.Location = new System.Drawing.Point(609, 273);
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(147, 22);
            this.textBoxPhoneNum.TabIndex = 8;
            // 
            // labelPhoneNum
            // 
            this.labelPhoneNum.AutoSize = true;
            this.labelPhoneNum.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNum.Location = new System.Drawing.Point(605, 242);
            this.labelPhoneNum.Name = "labelPhoneNum";
            this.labelPhoneNum.Size = new System.Drawing.Size(127, 22);
            this.labelPhoneNum.TabIndex = 7;
            this.labelPhoneNum.Text = "Phone number";
            // 
            // textBoxIDNumber
            // 
            this.textBoxIDNumber.Location = new System.Drawing.Point(418, 273);
            this.textBoxIDNumber.Name = "textBoxIDNumber";
            this.textBoxIDNumber.Size = new System.Drawing.Size(147, 22);
            this.textBoxIDNumber.TabIndex = 6;
            // 
            // labelIDnum
            // 
            this.labelIDnum.AutoSize = true;
            this.labelIDnum.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDnum.Location = new System.Drawing.Point(414, 242);
            this.labelIDnum.Name = "labelIDnum";
            this.labelIDnum.Size = new System.Drawing.Size(96, 22);
            this.labelIDnum.TabIndex = 5;
            this.labelIDnum.Text = "ID number";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(232, 272);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(147, 22);
            this.textBoxLastname.TabIndex = 4;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(228, 241);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(91, 22);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Last name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(41, 272);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(147, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(37, 241);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 22);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersWidth = 51;
            this.dataGridViewClients.RowTemplate.Height = 24;
            this.dataGridViewClients.Size = new System.Drawing.Size(796, 177);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.panelClientManagement);
            this.Name = "ClientManagement";
            this.Text = "ClientManagement";
            this.Load += new System.EventHandler(this.ClientManagement_Load);
            this.panelClientManagement.ResumeLayout(false);
            this.panelClientManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClientManagement;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxPhoneNum;
        private System.Windows.Forms.Label labelPhoneNum;
        private System.Windows.Forms.TextBox textBoxIDNumber;
        private System.Windows.Forms.Label labelIDnum;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
    }
}