namespace PresentationLayer
{
    partial class TransactionManagement
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
            this.textBoxExchangeRate = new System.Windows.Forms.TextBox();
            this.labelExchangeRate = new System.Windows.Forms.Label();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.labelCountryName = new System.Windows.Forms.Label();
            this.textBoxCurrencyCode = new System.Windows.Forms.TextBox();
            this.labelCurrencyCode = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxCurrencyID = new System.Windows.Forms.TextBox();
            this.labelCurrencyID = new System.Windows.Forms.Label();
            this.dataGridViewTransaction = new System.Windows.Forms.DataGridView();
            this.panelClientManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // panelClientManagement
            // 
            this.panelClientManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panelClientManagement.Controls.Add(this.textBoxExchangeRate);
            this.panelClientManagement.Controls.Add(this.labelExchangeRate);
            this.panelClientManagement.Controls.Add(this.textBoxCountryName);
            this.panelClientManagement.Controls.Add(this.labelCountryName);
            this.panelClientManagement.Controls.Add(this.textBoxCurrencyCode);
            this.panelClientManagement.Controls.Add(this.labelCurrencyCode);
            this.panelClientManagement.Controls.Add(this.buttonClose);
            this.panelClientManagement.Controls.Add(this.buttonDelete);
            this.panelClientManagement.Controls.Add(this.buttonUpdate);
            this.panelClientManagement.Controls.Add(this.buttonInsert);
            this.panelClientManagement.Controls.Add(this.textBoxCurrencyID);
            this.panelClientManagement.Controls.Add(this.labelCurrencyID);
            this.panelClientManagement.Controls.Add(this.dataGridViewTransaction);
            this.panelClientManagement.Location = new System.Drawing.Point(-1, 2);
            this.panelClientManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelClientManagement.Name = "panelClientManagement";
            this.panelClientManagement.Size = new System.Drawing.Size(803, 446);
            this.panelClientManagement.TabIndex = 2;
            // 
            // textBoxExchangeRate
            // 
            this.textBoxExchangeRate.Location = new System.Drawing.Point(600, 272);
            this.textBoxExchangeRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxExchangeRate.Name = "textBoxExchangeRate";
            this.textBoxExchangeRate.Size = new System.Drawing.Size(147, 22);
            this.textBoxExchangeRate.TabIndex = 39;
            this.textBoxExchangeRate.TextChanged += new System.EventHandler(this.textBoxExchangeRate_TextChanged);
            // 
            // labelExchangeRate
            // 
            this.labelExchangeRate.AutoSize = true;
            this.labelExchangeRate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExchangeRate.Location = new System.Drawing.Point(596, 241);
            this.labelExchangeRate.Name = "labelExchangeRate";
            this.labelExchangeRate.Size = new System.Drawing.Size(122, 22);
            this.labelExchangeRate.TabIndex = 38;
            this.labelExchangeRate.Text = "Exchange rate";
            this.labelExchangeRate.Click += new System.EventHandler(this.labelExchangeRate_Click);
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.Location = new System.Drawing.Point(408, 272);
            this.textBoxCountryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(147, 22);
            this.textBoxCountryName.TabIndex = 37;
            // 
            // labelCountryName
            // 
            this.labelCountryName.AutoSize = true;
            this.labelCountryName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountryName.Location = new System.Drawing.Point(404, 241);
            this.labelCountryName.Name = "labelCountryName";
            this.labelCountryName.Size = new System.Drawing.Size(123, 22);
            this.labelCountryName.TabIndex = 36;
            this.labelCountryName.Text = "Country name";
            // 
            // textBoxCurrencyCode
            // 
            this.textBoxCurrencyCode.Location = new System.Drawing.Point(227, 272);
            this.textBoxCurrencyCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCurrencyCode.Name = "textBoxCurrencyCode";
            this.textBoxCurrencyCode.Size = new System.Drawing.Size(147, 22);
            this.textBoxCurrencyCode.TabIndex = 35;
            // 
            // labelCurrencyCode
            // 
            this.labelCurrencyCode.AutoSize = true;
            this.labelCurrencyCode.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrencyCode.Location = new System.Drawing.Point(223, 241);
            this.labelCurrencyCode.Name = "labelCurrencyCode";
            this.labelCurrencyCode.Size = new System.Drawing.Size(124, 22);
            this.labelCurrencyCode.TabIndex = 34;
            this.labelCurrencyCode.Text = "Currency code";
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
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(507, 350);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(145, 49);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete ";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(315, 350);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(145, 49);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Update ";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(123, 350);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(145, 49);
            this.buttonInsert.TabIndex = 9;
            this.buttonInsert.Text = "Insert ";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxCurrencyID
            // 
            this.textBoxCurrencyID.Location = new System.Drawing.Point(41, 272);
            this.textBoxCurrencyID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCurrencyID.Name = "textBoxCurrencyID";
            this.textBoxCurrencyID.Size = new System.Drawing.Size(147, 22);
            this.textBoxCurrencyID.TabIndex = 2;
            // 
            // labelCurrencyID
            // 
            this.labelCurrencyID.AutoSize = true;
            this.labelCurrencyID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrencyID.Location = new System.Drawing.Point(37, 241);
            this.labelCurrencyID.Name = "labelCurrencyID";
            this.labelCurrencyID.Size = new System.Drawing.Size(104, 22);
            this.labelCurrencyID.TabIndex = 1;
            this.labelCurrencyID.Text = "Currency ID";
            // 
            // dataGridViewTransaction
            // 
            this.dataGridViewTransaction.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransaction.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTransaction.Name = "dataGridViewTransaction";
            this.dataGridViewTransaction.RowHeadersWidth = 51;
            this.dataGridViewTransaction.RowTemplate.Height = 24;
            this.dataGridViewTransaction.Size = new System.Drawing.Size(796, 177);
            this.dataGridViewTransaction.TabIndex = 0;
            this.dataGridViewTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransaction_CellContentClick);
            // 
            // TransactionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelClientManagement);
            this.Name = "TransactionManagement";
            this.Text = "TransactionManagement";
            this.Load += new System.EventHandler(this.TransactionManagement_Load);
            this.panelClientManagement.ResumeLayout(false);
            this.panelClientManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClientManagement;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxCurrencyID;
        private System.Windows.Forms.Label labelCurrencyID;
        private System.Windows.Forms.DataGridView dataGridViewTransaction;
        private System.Windows.Forms.TextBox textBoxExchangeRate;
        private System.Windows.Forms.Label labelExchangeRate;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.Label labelCountryName;
        private System.Windows.Forms.TextBox textBoxCurrencyCode;
        private System.Windows.Forms.Label labelCurrencyCode;
    }
}