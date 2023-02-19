namespace PresentationLayer
{
    partial class BoughtArrangements
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
            this.buttonBuyMore = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelBought = new System.Windows.Forms.Label();
            this.dataGridViewBoughtArrangements = new System.Windows.Forms.DataGridView();
            this.panelClientManagement.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoughtArrangements)).BeginInit();
            this.SuspendLayout();
            // 
            // panelClientManagement
            // 
            this.panelClientManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.panelClientManagement.Controls.Add(this.buttonBuyMore);
            this.panelClientManagement.Controls.Add(this.buttonClose);
            this.panelClientManagement.Controls.Add(this.linkLabel1);
            this.panelClientManagement.Controls.Add(this.label1);
            this.panelClientManagement.Controls.Add(this.panel2);
            this.panelClientManagement.Controls.Add(this.dataGridViewBoughtArrangements);
            this.panelClientManagement.Location = new System.Drawing.Point(-1, 2);
            this.panelClientManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelClientManagement.Name = "panelClientManagement";
            this.panelClientManagement.Size = new System.Drawing.Size(602, 362);
            this.panelClientManagement.TabIndex = 3;
            // 
            // buttonBuyMore
            // 
            this.buttonBuyMore.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonBuyMore.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuyMore.Location = new System.Drawing.Point(338, 284);
            this.buttonBuyMore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuyMore.Name = "buttonBuyMore";
            this.buttonBuyMore.Size = new System.Drawing.Size(198, 40);
            this.buttonBuyMore.TabIndex = 38;
            this.buttonBuyMore.Text = "Buy more";
            this.buttonBuyMore.UseVisualStyleBackColor = false;
            this.buttonBuyMore.Click += new System.EventHandler(this.buttonBuyMore_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(105, 284);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(198, 40);
            this.buttonClose.TabIndex = 37;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(172, 330);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(252, 21);
            this.linkLabel1.TabIndex = 36;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click to see list of all bought tickets";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Here you can find list off all your bought arrangements!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.labelBought);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 72);
            this.panel2.TabIndex = 22;
            // 
            // labelBought
            // 
            this.labelBought.AutoSize = true;
            this.labelBought.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBought.Location = new System.Drawing.Point(125, 17);
            this.labelBought.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBought.Name = "labelBought";
            this.labelBought.Size = new System.Drawing.Size(380, 45);
            this.labelBought.TabIndex = 0;
            this.labelBought.Text = "Bought arrangements";
            // 
            // dataGridViewBoughtArrangements
            // 
            this.dataGridViewBoughtArrangements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBoughtArrangements.Location = new System.Drawing.Point(-8, 121);
            this.dataGridViewBoughtArrangements.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewBoughtArrangements.Name = "dataGridViewBoughtArrangements";
            this.dataGridViewBoughtArrangements.RowHeadersWidth = 51;
            this.dataGridViewBoughtArrangements.RowTemplate.Height = 24;
            this.dataGridViewBoughtArrangements.Size = new System.Drawing.Size(610, 143);
            this.dataGridViewBoughtArrangements.TabIndex = 0;
            // 
            // BoughtArrangements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panelClientManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "BoughtArrangements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bought Arrangements";
            this.Load += new System.EventHandler(this.BoughtArrangements_Load);
            this.panelClientManagement.ResumeLayout(false);
            this.panelClientManagement.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoughtArrangements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClientManagement;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelBought;
        private System.Windows.Forms.DataGridView dataGridViewBoughtArrangements;
        private System.Windows.Forms.Button buttonBuyMore;
    }
}