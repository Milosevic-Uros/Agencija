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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelIEmail = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.panelClientManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // panelClientManagement
            // 
            this.panelClientManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panelClientManagement.Controls.Add(this.buttonClose);
            this.panelClientManagement.Controls.Add(this.buttonDelete);
            this.panelClientManagement.Controls.Add(this.buttonUpdate);
            this.panelClientManagement.Controls.Add(this.buttonInsert);
            this.panelClientManagement.Controls.Add(this.textBoxPassword);
            this.panelClientManagement.Controls.Add(this.labelPassword);
            this.panelClientManagement.Controls.Add(this.textBoxEmail);
            this.panelClientManagement.Controls.Add(this.labelIEmail);
            this.panelClientManagement.Controls.Add(this.textBoxPhoneNumber);
            this.panelClientManagement.Controls.Add(this.labelPhoneNumber);
            this.panelClientManagement.Controls.Add(this.textBoxId);
            this.panelClientManagement.Controls.Add(this.labelId);
            this.panelClientManagement.Controls.Add(this.dataGridViewClients);
            this.panelClientManagement.Location = new System.Drawing.Point(-2, 1);
            this.panelClientManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelClientManagement.Name = "panelClientManagement";
            this.panelClientManagement.Size = new System.Drawing.Size(602, 362);
            this.panelClientManagement.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(11, 309);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(61, 40);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(378, 279);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 40);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete client";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(234, 279);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(109, 40);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update client";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(90, 279);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(109, 40);
            this.buttonInsert.TabIndex = 5;
            this.buttonInsert.Text = "Insert client";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(457, 222);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(111, 20);
            this.textBoxPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(454, 197);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(72, 18);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(314, 222);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(111, 20);
            this.textBoxEmail.TabIndex = 3;
            // 
            // labelIEmail
            // 
            this.labelIEmail.AutoSize = true;
            this.labelIEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIEmail.Location = new System.Drawing.Point(310, 197);
            this.labelIEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIEmail.Name = "labelIEmail";
            this.labelIEmail.Size = new System.Drawing.Size(44, 18);
            this.labelIEmail.TabIndex = 5;
            this.labelIEmail.Text = "Email";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(174, 221);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(111, 20);
            this.textBoxPhoneNumber.TabIndex = 2;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNumber.Location = new System.Drawing.Point(171, 196);
            this.labelPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(109, 18);
            this.labelPhoneNumber.TabIndex = 3;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(31, 221);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(111, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(28, 196);
            this.labelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(22, 18);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "ID";
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(2, 0);
            this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersWidth = 51;
            this.dataGridViewClients.RowTemplate.Height = 24;
            this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClients.Size = new System.Drawing.Size(597, 144);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewClients_RowHeaderMouseClick);
            // 
            // ClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 358);
            this.Controls.Add(this.panelClientManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ClientManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelIEmail;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClose;
    }
}