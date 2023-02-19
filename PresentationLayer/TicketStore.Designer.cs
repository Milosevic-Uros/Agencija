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
            this.buttonConvert = new System.Windows.Forms.Button();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelINSERT = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.aGENCIJADataSet1 = new PresentationLayer.AGENCIJADataSet1();
            this.eXCHANGERATESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXCHANGE_RATESTableAdapter = new PresentationLayer.AGENCIJADataSet1TableAdapters.EXCHANGE_RATESTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aGENCIJADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXCHANGERATESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.buttonConvert);
            this.panel1.Controls.Add(this.dataGridViewTickets);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 452);
            this.panel1.TabIndex = 1;
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.Location = new System.Drawing.Point(347, 377);
            this.buttonConvert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(115, 34);
            this.buttonConvert.TabIndex = 33;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Location = new System.Drawing.Point(3, 95);
            this.dataGridViewTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowHeadersWidth = 51;
            this.dataGridViewTickets.RowTemplate.Height = 24;
            this.dataGridViewTickets.Size = new System.Drawing.Size(795, 176);
            this.dataGridViewTickets.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.labelINSERT);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 89);
            this.panel2.TabIndex = 22;
            // 
            // labelINSERT
            // 
            this.labelINSERT.AutoSize = true;
            this.labelINSERT.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelINSERT.Location = new System.Drawing.Point(265, 21);
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
            // TicketStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "TicketStore";
            this.Text = "TicketStore";
            this.Load += new System.EventHandler(this.TicketStore_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aGENCIJADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXCHANGERATESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelINSERT;
        private System.Windows.Forms.Timer timer1;
        private AGENCIJADataSet1 aGENCIJADataSet1;
        private System.Windows.Forms.BindingSource eXCHANGERATESBindingSource;
        private AGENCIJADataSet1TableAdapters.EXCHANGE_RATESTableAdapter eXCHANGE_RATESTableAdapter;
    }
}