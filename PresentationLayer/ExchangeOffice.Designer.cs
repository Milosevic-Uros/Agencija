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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelConvertedValue = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewExchange = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelINSERT = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.aGENCIJADataSet1 = new PresentationLayer.AGENCIJADataSet1();
            this.eXCHANGERATESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXCHANGE_RATESTableAdapter = new PresentationLayer.AGENCIJADataSet1TableAdapters.EXCHANGE_RATESTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExchange)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aGENCIJADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXCHANGERATESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.labelConvertedValue);
            this.panel1.Controls.Add(this.buttonConvert);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelFrom);
            this.panel1.Controls.Add(this.comboBoxTo);
            this.panel1.Controls.Add(this.comboBoxFrom);
            this.panel1.Controls.Add(this.textBoxAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridViewExchange);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 367);
            this.panel1.TabIndex = 0;
            // 
            // labelConvertedValue
            // 
            this.labelConvertedValue.AutoSize = true;
            this.labelConvertedValue.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConvertedValue.Location = new System.Drawing.Point(393, 266);
            this.labelConvertedValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConvertedValue.Name = "labelConvertedValue";
            this.labelConvertedValue.Size = new System.Drawing.Size(160, 23);
            this.labelConvertedValue.TabIndex = 34;
            this.labelConvertedValue.Text = "Converted value:";
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.Location = new System.Drawing.Point(260, 306);
            this.buttonConvert.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(86, 28);
            this.buttonConvert.TabIndex = 33;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "To";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(134, 232);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(43, 18);
            this.labelFrom.TabIndex = 30;
            this.labelFrom.Text = "From";
            this.labelFrom.Click += new System.EventHandler(this.labelFrom_Click);
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.DataSource = this.eXCHANGERATESBindingSource;
            this.comboBoxTo.DisplayMember = "currency_code";
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(260, 257);
            this.comboBoxTo.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(92, 21);
            this.comboBoxTo.TabIndex = 28;
            this.comboBoxTo.ValueMember = "mean_exchange_rate";
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.DataSource = this.eXCHANGERATESBindingSource;
            this.comboBoxFrom.DisplayMember = "currency_code";
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(136, 257);
            this.comboBoxFrom.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(92, 21);
            this.comboBoxFrom.TabIndex = 27;
            this.comboBoxFrom.ValueMember = "mean_exchange_rate";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(136, 310);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(96, 20);
            this.textBoxAmount.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Converted value:";
            // 
            // dataGridViewExchange
            // 
            this.dataGridViewExchange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExchange.Location = new System.Drawing.Point(97, 120);
            this.dataGridViewExchange.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewExchange.Name = "dataGridViewExchange";
            this.dataGridViewExchange.RowHeadersWidth = 51;
            this.dataGridViewExchange.RowTemplate.Height = 24;
            this.dataGridViewExchange.Size = new System.Drawing.Size(415, 98);
            this.dataGridViewExchange.TabIndex = 23;
            this.dataGridViewExchange.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.labelDate);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(53, 71);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exchange rates on date: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.labelINSERT);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 72);
            this.panel2.TabIndex = 22;
            // 
            // labelINSERT
            // 
            this.labelINSERT.AutoSize = true;
            this.labelINSERT.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelINSERT.Location = new System.Drawing.Point(164, 17);
            this.labelINSERT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelINSERT.Name = "labelINSERT";
            this.labelINSERT.Size = new System.Drawing.Size(280, 45);
            this.labelINSERT.TabIndex = 0;
            this.labelINSERT.Text = "Exchange office";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // aGENCIJADataSet1
            // 
            this.aGENCIJADataSet1.DataSetName = "AGENCIJADataSet1";
            this.aGENCIJADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eXCHANGERATESBindingSource
            // 
            this.eXCHANGERATESBindingSource.DataMember = "EXCHANGE_RATES";
            this.eXCHANGERATESBindingSource.DataSource = this.aGENCIJADataSet1;
            // 
            // eXCHANGE_RATESTableAdapter
            // 
            this.eXCHANGE_RATESTableAdapter.ClearBeforeFill = true;
            // 
            // ExchangeOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ExchangeOffice";
            this.Text = "ExchangeOffice";
            this.Load += new System.EventHandler(this.ExchangeOffice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExchange)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aGENCIJADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXCHANGERATESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewExchange;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelINSERT;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelConvertedValue;
        private System.Windows.Forms.Button buttonConvert;
        private AGENCIJADataSet1 aGENCIJADataSet1;
        private System.Windows.Forms.BindingSource eXCHANGERATESBindingSource;
        private AGENCIJADataSet1TableAdapters.EXCHANGE_RATESTableAdapter eXCHANGE_RATESTableAdapter;
    }
}