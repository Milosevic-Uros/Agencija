namespace PresentationLayer
{
    partial class TicketStore
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxTicketID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelBought = new System.Windows.Forms.LinkLabel();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelINSERT = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.aGENCIJADataSet1 = new PresentationLayer.AGENCIJADataSet1();
            this.eXCHANGERATESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXCHANGE_RATESTableAdapter = new PresentationLayer.AGENCIJADataSet1TableAdapters.EXCHANGE_RATESTableAdapter();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aGENCIJADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXCHANGERATESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.dataGridViewTickets);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.textBoxAmount);
            this.panel1.Controls.Add(this.labelAmount);
            this.panel1.Controls.Add(this.textBoxTicketID);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.labelBought);
            this.panel1.Controls.Add(this.buttonBuy);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 452);
            this.panel1.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(278, 354);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(341, 34);
            this.buttonClose.TabIndex = 40;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(723, 310);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(175, 22);
            this.textBoxAmount.TabIndex = 39;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(717, 278);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(75, 22);
            this.labelAmount.TabIndex = 38;
            this.labelAmount.Text = "Amount";
            // 
            // textBoxTicketID
            // 
            this.textBoxTicketID.Enabled = false;
            this.textBoxTicketID.Location = new System.Drawing.Point(354, 310);
            this.textBoxTicketID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTicketID.Name = "textBoxTicketID";
            this.textBoxTicketID.ReadOnly = true;
            this.textBoxTicketID.Size = new System.Drawing.Size(175, 22);
            this.textBoxTicketID.TabIndex = 37;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(347, 278);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(82, 22);
            this.labelID.TabIndex = 36;
            this.labelID.Text = "Ticket ID";
            // 
            // labelBought
            // 
            this.labelBought.AutoSize = true;
            this.labelBought.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBought.Location = new System.Drawing.Point(493, 411);
            this.labelBought.Name = "labelBought";
            this.labelBought.Size = new System.Drawing.Size(319, 25);
            this.labelBought.TabIndex = 35;
            this.labelBought.TabStop = true;
            this.labelBought.Text = "Click to see list of all bought tickets";
            this.labelBought.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelBought_LinkClicked);
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuy.Location = new System.Drawing.Point(643, 354);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(341, 34);
            this.buttonBuy.TabIndex = 33;
            this.buttonBuy.Text = "Buy ticket";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.labelINSERT);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1277, 89);
            this.panel2.TabIndex = 22;
            // 
            // labelINSERT
            // 
            this.labelINSERT.AutoSize = true;
            this.labelINSERT.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelINSERT.Location = new System.Drawing.Point(512, 18);
            this.labelINSERT.Name = "labelINSERT";
            this.labelINSERT.Size = new System.Drawing.Size(260, 55);
            this.labelINSERT.TabIndex = 0;
            this.labelINSERT.Text = "Ticket store";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
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
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Location = new System.Drawing.Point(3, 96);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowHeadersWidth = 51;
            this.dataGridViewTickets.RowTemplate.Height = 24;
            this.dataGridViewTickets.Size = new System.Drawing.Size(1274, 145);
            this.dataGridViewTickets.TabIndex = 41;
            // 
            // TicketStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 449);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "TicketStore";
            this.Text = "TicketStore";
            this.Load += new System.EventHandler(this.TicketStore_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aGENCIJADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXCHANGERATESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelINSERT;
        private System.Windows.Forms.Timer timer1;
        private AGENCIJADataSet1 aGENCIJADataSet1;
        private System.Windows.Forms.BindingSource eXCHANGERATESBindingSource;
        private AGENCIJADataSet1TableAdapters.EXCHANGE_RATESTableAdapter eXCHANGE_RATESTableAdapter;
        private System.Windows.Forms.LinkLabel labelBought;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxTicketID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
    }
}