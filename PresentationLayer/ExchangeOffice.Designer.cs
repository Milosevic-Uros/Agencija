namespace PresentationLayer
{
    partial class ExchangeOffice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExchangeOffice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelConvertedValue = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.eXCHANGERATESBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aGENCIJADataSet3 = new PresentationLayer.AGENCIJADataSet3();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.eXCHANGERATESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aGENCIJADataSet1 = new PresentationLayer.AGENCIJADataSet1();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.dataGridViewExchange = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelINSERT = new System.Windows.Forms.Label();
            this.eXCHANGERATESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXCHANGE_RATESTableAdapter = new PresentationLayer.AGENCIJADataSet1TableAdapters.EXCHANGE_RATESTableAdapter();
            this.eXCHANGE_RATESTableAdapter1 = new PresentationLayer.AGENCIJADataSet3TableAdapters.EXCHANGE_RATESTableAdapter();
            this.labelHeadline = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eXCHANGERATESBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGENCIJADataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXCHANGERATESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGENCIJADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExchange)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eXCHANGERATESBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.labelConvertedValue);
            this.panel1.Controls.Add(this.buttonConvert);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelFrom);
            this.panel1.Controls.Add(this.comboBoxTo);
            this.panel1.Controls.Add(this.comboBoxFrom);
            this.panel1.Controls.Add(this.textBoxAmount);
            this.panel1.Controls.Add(this.labelValue);
            this.panel1.Controls.Add(this.dataGridViewExchange);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 452);
            this.panel1.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(9, 317);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(81, 49);
            this.buttonClose.TabIndex = 35;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelConvertedValue
            // 
            this.labelConvertedValue.AutoSize = true;
            this.labelConvertedValue.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConvertedValue.Location = new System.Drawing.Point(524, 346);
            this.labelConvertedValue.Name = "labelConvertedValue";
            this.labelConvertedValue.Size = new System.Drawing.Size(192, 29);
            this.labelConvertedValue.TabIndex = 34;
            this.labelConvertedValue.Text = "Converted value:";
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.Location = new System.Drawing.Point(260, 322);
            this.buttonConvert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(115, 34);
            this.buttonConvert.TabIndex = 4;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = false;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "To";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(179, 305);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(52, 22);
            this.labelFrom.TabIndex = 30;
            this.labelFrom.Text = "From";
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.DataSource = this.eXCHANGERATESBindingSource2;
            this.comboBoxTo.DisplayMember = "currency_code";
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(260, 272);
            this.comboBoxTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTo.TabIndex = 2;
            this.comboBoxTo.ValueMember = "mean_exchange_rate";
            // 
            // eXCHANGERATESBindingSource2
            // 
            this.eXCHANGERATESBindingSource2.DataMember = "EXCHANGE_RATES";
            this.eXCHANGERATESBindingSource2.DataSource = this.aGENCIJADataSet3;
            // 
            // aGENCIJADataSet3
            // 
            this.aGENCIJADataSet3.DataSetName = "AGENCIJADataSet3";
            this.aGENCIJADataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.DataSource = this.eXCHANGERATESBindingSource1;
            this.comboBoxFrom.DisplayMember = "currency_code";
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(136, 272);
            this.comboBoxFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFrom.TabIndex = 1;
            this.comboBoxFrom.ValueMember = "mean_exchange_rate";
            // 
            // eXCHANGERATESBindingSource1
            // 
            this.eXCHANGERATESBindingSource1.DataMember = "EXCHANGE_RATES";
            this.eXCHANGERATESBindingSource1.DataSource = this.aGENCIJADataSet1;
            // 
            // aGENCIJADataSet1
            // 
            this.aGENCIJADataSet1.DataSetName = "AGENCIJADataSet1";
            this.aGENCIJADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(136, 326);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(127, 22);
            this.textBoxAmount.TabIndex = 3;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue.Location = new System.Drawing.Point(524, 396);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(192, 29);
            this.labelValue.TabIndex = 25;
            this.labelValue.Text = "Converted value:";
            this.labelValue.Visible = false;
            // 
            // dataGridViewExchange
            // 
            this.dataGridViewExchange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExchange.Location = new System.Drawing.Point(71, 120);
            this.dataGridViewExchange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewExchange.Name = "dataGridViewExchange";
            this.dataGridViewExchange.RowHeadersWidth = 51;
            this.dataGridViewExchange.RowTemplate.Height = 24;
            this.dataGridViewExchange.Size = new System.Drawing.Size(622, 144);
            this.dataGridViewExchange.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.labelDate);
            this.panel3.Controls.Add(this.labelHeadline);
            this.panel3.Location = new System.Drawing.Point(53, 71);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 35);
            this.panel3.TabIndex = 24;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(302, 14);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(7, 13);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "\r\n";
            // 
            // labelHeadline
            // 
            this.labelHeadline.AutoSize = true;
            this.labelHeadline.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadline.Location = new System.Drawing.Point(130, 10);
            this.labelHeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(176, 21);
            this.labelHeadline.TabIndex = 0;
            this.labelHeadline.Text = "Exchange rates on date: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.labelINSERT);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 89);
            this.panel2.TabIndex = 22;
            // 
            // labelINSERT
            // 
            this.labelINSERT.AutoSize = true;
            this.labelINSERT.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelINSERT.Location = new System.Drawing.Point(164, 17);
            this.labelINSERT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelINSERT.Name = "labelINSERT";
            this.labelINSERT.Size = new System.Drawing.Size(343, 55);
            this.labelINSERT.TabIndex = 0;
            this.labelINSERT.Text = "Exchange office";
            // 
            // eXCHANGERATESBindingSource
            // 
            this.eXCHANGERATESBindingSource.DataMember = "EXCHANGE_RATES";
            // 
            // eXCHANGE_RATESTableAdapter
            // 
            this.eXCHANGE_RATESTableAdapter.ClearBeforeFill = true;
            // 
            // eXCHANGE_RATESTableAdapter1
            // 
            this.eXCHANGE_RATESTableAdapter1.ClearBeforeFill = true;
            // 
            // labelHeadline
            // 
            this.labelHeadline.AutoSize = true;
            this.labelHeadline.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadline.Location = new System.Drawing.Point(115, 10);
            this.labelHeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(176, 21);
            this.labelHeadline.TabIndex = 0;
            this.labelHeadline.Text = "Exchange rates on date: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.labelHeadline);
            this.panel3.Location = new System.Drawing.Point(53, 71);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 35);
            this.panel3.TabIndex = 24;
            // 
            // ExchangeOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ExchangeOffice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExchangeOffice";
            this.Load += new System.EventHandler(this.ExchangeOffice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eXCHANGERATESBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGENCIJADataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXCHANGERATESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGENCIJADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExchange)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eXCHANGERATESBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewExchange;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelINSERT;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelConvertedValue;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.BindingSource eXCHANGERATESBindingSource;
        private AGENCIJADataSet1 aGENCIJADataSet1;
        private System.Windows.Forms.BindingSource eXCHANGERATESBindingSource1;
        private AGENCIJADataSet1TableAdapters.EXCHANGE_RATESTableAdapter eXCHANGE_RATESTableAdapter;
        private AGENCIJADataSet3 aGENCIJADataSet3;
        private System.Windows.Forms.BindingSource eXCHANGERATESBindingSource2;
        private AGENCIJADataSet3TableAdapters.EXCHANGE_RATESTableAdapter eXCHANGE_RATESTableAdapter1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelHeadline;
    }
}