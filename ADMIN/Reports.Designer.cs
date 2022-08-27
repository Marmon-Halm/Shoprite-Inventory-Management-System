namespace Shoprite_Inventory_Management
{
    partial class Reports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.reportsDataGrid = new System.Windows.Forms.DataGridView();
            this.reportsHeader = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rCategory = new System.Windows.Forms.Label();
            this.rGenerateButton = new System.Windows.Forms.Button();
            this.pNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rGenerateButton);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rCategory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(39, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1395, 533);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportsDataGrid);
            this.panel2.Location = new System.Drawing.Point(28, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1336, 428);
            this.panel2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(361, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Location = new System.Drawing.Point(670, 35);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(218, 21);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(283, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(598, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "End Date:";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.Location = new System.Drawing.Point(1169, 32);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(164, 23);
            this.searchBox.TabIndex = 3;
            this.searchBox.Text = "Search For Report";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // reportsDataGrid
            // 
            this.reportsDataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.reportsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pNumber,
            this.pName,
            this.pDescription,
            this.price,
            this.qSold,
            this.qRemaining,
            this.tAmount});
            this.reportsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportsDataGrid.EnableHeadersVisualStyles = false;
            this.reportsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.reportsDataGrid.Name = "reportsDataGrid";
            this.reportsDataGrid.RowTemplate.Height = 25;
            this.reportsDataGrid.Size = new System.Drawing.Size(1336, 428);
            this.reportsDataGrid.TabIndex = 0;
            this.reportsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportsDataGrid_CellContentClick);
            // 
            // reportsHeader
            // 
            this.reportsHeader.AutoSize = true;
            this.reportsHeader.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reportsHeader.Location = new System.Drawing.Point(99, 9);
            this.reportsHeader.Name = "reportsHeader";
            this.reportsHeader.Size = new System.Drawing.Size(102, 27);
            this.reportsHeader.TabIndex = 2;
            this.reportsHeader.Text = "Reports";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // rCategory
            // 
            this.rCategory.AutoSize = true;
            this.rCategory.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rCategory.Location = new System.Drawing.Point(35, 37);
            this.rCategory.Name = "rCategory";
            this.rCategory.Size = new System.Drawing.Size(65, 17);
            this.rCategory.TabIndex = 2;
            this.rCategory.Text = "Category";
            // 
            // rGenerateButton
            // 
            this.rGenerateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rGenerateButton.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rGenerateButton.Location = new System.Drawing.Point(985, 24);
            this.rGenerateButton.Name = "rGenerateButton";
            this.rGenerateButton.Size = new System.Drawing.Size(128, 38);
            this.rGenerateButton.TabIndex = 5;
            this.rGenerateButton.Text = "Generate Report";
            this.rGenerateButton.UseVisualStyleBackColor = true;
            this.rGenerateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pNumber
            // 
            this.pNumber.HeaderText = "Product No.";
            this.pNumber.Name = "pNumber";
            // 
            // pName
            // 
            this.pName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pName.FillWeight = 70F;
            this.pName.HeaderText = "Product Name";
            this.pName.Name = "pName";
            // 
            // pDescription
            // 
            this.pDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pDescription.FillWeight = 80F;
            this.pDescription.HeaderText = "Product Description";
            this.pDescription.Name = "pDescription";
            // 
            // price
            // 
            this.price.HeaderText = "Unit Price";
            this.price.Name = "price";
            this.price.Width = 110;
            // 
            // qSold
            // 
            this.qSold.HeaderText = "Quantity Sold";
            this.qSold.Name = "qSold";
            this.qSold.Width = 80;
            // 
            // qRemaining
            // 
            this.qRemaining.HeaderText = "Quantity Remaining";
            this.qRemaining.Name = "qRemaining";
            this.qRemaining.Width = 85;
            // 
            // tAmount
            // 
            this.tAmount.HeaderText = "Amount";
            this.tAmount.Name = "tAmount";
            this.tAmount.Width = 80;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1483, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportsHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Reports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Button rGenerateButton;
        private ComboBox comboBox1;
        private TextBox searchBox;
        private Label rCategory;
        private DataGridView reportsDataGrid;
        private Label reportsHeader;
        private DataGridViewTextBoxColumn pNumber;
        private DataGridViewTextBoxColumn pName;
        private DataGridViewTextBoxColumn pDescription;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn qSold;
        private DataGridViewTextBoxColumn qRemaining;
        private DataGridViewTextBoxColumn tAmount;
    }
}