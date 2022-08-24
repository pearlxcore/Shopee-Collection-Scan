namespace Shopee_Payday_Sale_Scan
{
    partial class Form1
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
            this.tbLog = new DarkUI.Controls.DarkTextBox();
            this.copyProductLinkToolStripMenuItem = new DarkUI.Controls.DarkToolStrip();
            this.openProductLinkToolStripMenuItem = new DarkUI.Controls.DarkToolStrip();
            this.darkLabelStatus = new DarkUI.Controls.DarkLabel();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.darkLabelCollectionName = new DarkUI.Controls.DarkLabel();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.darkButtonScan = new DarkUI.Controls.DarkButton();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkTextBoxSearchItem = new DarkUI.Controls.DarkTextBox();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.tbCollectionId = new DarkUI.Controls.DarkTextBox();
            this.dataGridView1 = new DarkUI.Controls.DarkDataGridView();
            this.numericUpDown1 = new DarkUI.Controls.DarkNumericUpDown();
            this.label1 = new DarkUI.Controls.DarkLabel();
            this.label2 = new DarkUI.Controls.DarkLabel();
            this.numericUpDown2 = new DarkUI.Controls.DarkNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLog
            // 
            this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLog.Location = new System.Drawing.Point(43, 166);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(420, 22);
            this.tbLog.TabIndex = 120;
            this.tbLog.Visible = false;
            // 
            // copyProductLinkToolStripMenuItem
            // 
            this.copyProductLinkToolStripMenuItem.AutoSize = false;
            this.copyProductLinkToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.copyProductLinkToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.copyProductLinkToolStripMenuItem.Location = new System.Drawing.Point(0, 0);
            this.copyProductLinkToolStripMenuItem.Name = "copyProductLinkToolStripMenuItem";
            this.copyProductLinkToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.copyProductLinkToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.copyProductLinkToolStripMenuItem.TabIndex = 0;
            this.copyProductLinkToolStripMenuItem.Text = "Copy product link";
            this.copyProductLinkToolStripMenuItem.Click += new System.EventHandler(this.copyProductLinkToolStripMenuItem_Click);
            // 
            // openProductLinkToolStripMenuItem
            // 
            this.openProductLinkToolStripMenuItem.AutoSize = false;
            this.openProductLinkToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.openProductLinkToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.openProductLinkToolStripMenuItem.Location = new System.Drawing.Point(0, 0);
            this.openProductLinkToolStripMenuItem.Name = "openProductLinkToolStripMenuItem";
            this.openProductLinkToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.openProductLinkToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.openProductLinkToolStripMenuItem.TabIndex = 0;
            this.openProductLinkToolStripMenuItem.Text = "Open product link";
            this.openProductLinkToolStripMenuItem.Click += new System.EventHandler(this.openProductLinkToolStripMenuItem_Click);
            // 
            // darkLabelStatus
            // 
            this.darkLabelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkLabelStatus.AutoSize = true;
            this.darkLabelStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.darkLabelStatus.Location = new System.Drawing.Point(12, 441);
            this.darkLabelStatus.Name = "darkLabelStatus";
            this.darkLabelStatus.Size = new System.Drawing.Size(13, 13);
            this.darkLabelStatus.TabIndex = 122;
            this.darkLabelStatus.Text = "..";
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(108, 77);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Size = new System.Drawing.Size(87, 23);
            this.darkButton1.TabIndex = 121;
            this.darkButton1.Text = "Stop scan";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // darkLabelCollectionName
            // 
            this.darkLabelCollectionName.AutoSize = true;
            this.darkLabelCollectionName.ForeColor = System.Drawing.Color.Gainsboro;
            this.darkLabelCollectionName.Location = new System.Drawing.Point(117, 51);
            this.darkLabelCollectionName.Name = "darkLabelCollectionName";
            this.darkLabelCollectionName.Size = new System.Drawing.Size(13, 13);
            this.darkLabelCollectionName.TabIndex = 119;
            this.darkLabelCollectionName.Text = "..";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.darkLabel2.Location = new System.Drawing.Point(12, 51);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(96, 13);
            this.darkLabel2.TabIndex = 118;
            this.darkLabel2.Text = "Collection name :";
            // 
            // darkButtonScan
            // 
            this.darkButtonScan.Location = new System.Drawing.Point(15, 77);
            this.darkButtonScan.Name = "darkButtonScan";
            this.darkButtonScan.Size = new System.Drawing.Size(87, 23);
            this.darkButtonScan.TabIndex = 117;
            this.darkButtonScan.Text = "Scan";
            this.darkButtonScan.Click += new System.EventHandler(this.darkButtonScan_Click);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.darkLabel1.Location = new System.Drawing.Point(12, 18);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(78, 13);
            this.darkLabel1.TabIndex = 115;
            this.darkLabel1.Text = "Collection Id :";
            // 
            // darkTextBoxSearchItem
            // 
            this.darkTextBoxSearchItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.darkTextBoxSearchItem.Location = new System.Drawing.Point(690, 77);
            this.darkTextBoxSearchItem.Name = "darkTextBoxSearchItem";
            this.darkTextBoxSearchItem.Size = new System.Drawing.Size(132, 22);
            this.darkTextBoxSearchItem.TabIndex = 125;
            this.darkTextBoxSearchItem.TextChanged += new System.EventHandler(this.darkTextBoxSearchItem_TextChanged);
            // 
            // darkLabel3
            // 
            this.darkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.darkLabel3.Location = new System.Drawing.Point(559, 82);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(72, 13);
            this.darkLabel3.TabIndex = 126;
            this.darkLabel3.Text = "Search Item :";
            // 
            // tbCollectionId
            // 
            this.tbCollectionId.Location = new System.Drawing.Point(120, 13);
            this.tbCollectionId.Name = "tbCollectionId";
            this.tbCollectionId.Size = new System.Drawing.Size(140, 22);
            this.tbCollectionId.TabIndex = 127;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 4;
            this.dataGridView1.Location = new System.Drawing.Point(15, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 41;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(807, 328);
            this.dataGridView1.TabIndex = 128;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.numericUpDown1.IncrementAlternate = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(690, 13);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.MousewheelSingleIncrement = true;
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 22);
            this.numericUpDown1.TabIndex = 129;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(559, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 130;
            this.label1.Text = "Delay interval (second):";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(559, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 132;
            this.label2.Text = "Limit per page :";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.numericUpDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.numericUpDown2.IncrementAlternate = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(690, 46);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown2.MousewheelSingleIncrement = true;
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(55, 22);
            this.numericUpDown2.TabIndex = 131;
            this.numericUpDown2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbCollectionId);
            this.Controls.Add(this.darkLabel3);
            this.Controls.Add(this.darkTextBoxSearchItem);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.darkLabelStatus);
            this.Controls.Add(this.darkButton1);
            this.Controls.Add(this.darkLabelCollectionName);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.darkButtonScan);
            this.Controls.Add(this.darkLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopee Collection Scan";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkTextBox tbLog;
        private DarkUI.Controls.DarkToolStrip copyProductLinkToolStripMenuItem;
        private DarkUI.Controls.DarkToolStrip openProductLinkToolStripMenuItem;
        private DarkUI.Controls.DarkLabel darkLabelStatus;
        private DarkUI.Controls.DarkButton darkButton1;
        private DarkUI.Controls.DarkLabel darkLabelCollectionName;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkButton darkButtonScan;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkTextBox darkTextBoxSearchItem;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkTextBox tbCollectionId;
        private DarkUI.Controls.DarkDataGridView dataGridView1;
        private DarkUI.Controls.DarkNumericUpDown numericUpDown1;
        private DarkUI.Controls.DarkLabel label1;
        private DarkUI.Controls.DarkLabel label2;
        private DarkUI.Controls.DarkNumericUpDown numericUpDown2;
    }
}

