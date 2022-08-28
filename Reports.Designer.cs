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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportsDataGrid = new System.Windows.Forms.DataGridView();
            this.pNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pp2 = new System.Windows.Forms.Button();
            this.reportsHeader = new System.Windows.Forms.Label();
            this.pp1 = new System.Windows.Forms.Button();
            this.rGenerateButton = new System.Windows.Forms.Button();
            this.ppNext = new System.Windows.Forms.Label();
            this.ppPrevious = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.hpReports = new System.Windows.Forms.Button();
            this.hpUserManagement = new System.Windows.Forms.Button();
            this.hpProductCatButton = new System.Windows.Forms.Button();
            this.hProductButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.reportsDataGrid);
            this.panel1.Controls.Add(this.pp2);
            this.panel1.Controls.Add(this.reportsHeader);
            this.panel1.Controls.Add(this.pp1);
            this.panel1.Controls.Add(this.rGenerateButton);
            this.panel1.Controls.Add(this.ppNext);
            this.panel1.Controls.Add(this.ppPrevious);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rCategory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1529, 764);
            this.panel1.TabIndex = 0;
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
            this.reportsDataGrid.EnableHeadersVisualStyles = false;
            this.reportsDataGrid.Location = new System.Drawing.Point(235, 183);
            this.reportsDataGrid.Name = "reportsDataGrid";
            this.reportsDataGrid.RowTemplate.Height = 25;
            this.reportsDataGrid.Size = new System.Drawing.Size(1267, 531);
            this.reportsDataGrid.TabIndex = 0;
            this.reportsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportsDataGrid_CellContentClick);
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
            // pp2
            // 
            this.pp2.BackColor = System.Drawing.Color.DarkGray;
            this.pp2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pp2.Location = new System.Drawing.Point(1369, 721);
            this.pp2.Name = "pp2";
            this.pp2.Size = new System.Drawing.Size(36, 32);
            this.pp2.TabIndex = 8;
            this.pp2.Text = "2";
            this.pp2.UseVisualStyleBackColor = false;
            // 
            // reportsHeader
            // 
            this.reportsHeader.AutoSize = true;
            this.reportsHeader.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reportsHeader.Location = new System.Drawing.Point(232, 104);
            this.reportsHeader.Name = "reportsHeader";
            this.reportsHeader.Size = new System.Drawing.Size(102, 27);
            this.reportsHeader.TabIndex = 2;
            this.reportsHeader.Text = "Reports";
            // 
            // pp1
            // 
            this.pp1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pp1.Location = new System.Drawing.Point(1328, 721);
            this.pp1.Name = "pp1";
            this.pp1.Size = new System.Drawing.Size(36, 32);
            this.pp1.TabIndex = 9;
            this.pp1.Text = "1";
            this.pp1.UseVisualStyleBackColor = true;
            // 
            // rGenerateButton
            // 
            this.rGenerateButton.BackColor = System.Drawing.Color.Salmon;
            this.rGenerateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rGenerateButton.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rGenerateButton.ForeColor = System.Drawing.Color.White;
            this.rGenerateButton.Location = new System.Drawing.Point(1374, 135);
            this.rGenerateButton.Name = "rGenerateButton";
            this.rGenerateButton.Size = new System.Drawing.Size(128, 38);
            this.rGenerateButton.TabIndex = 5;
            this.rGenerateButton.Text = "Generate Report";
            this.rGenerateButton.UseVisualStyleBackColor = false;
            this.rGenerateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ppNext
            // 
            this.ppNext.AutoSize = true;
            this.ppNext.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ppNext.ForeColor = System.Drawing.Color.Salmon;
            this.ppNext.Location = new System.Drawing.Point(1411, 729);
            this.ppNext.Name = "ppNext";
            this.ppNext.Size = new System.Drawing.Size(39, 17);
            this.ppNext.TabIndex = 6;
            this.ppNext.Text = "Next";
            // 
            // ppPrevious
            // 
            this.ppPrevious.AutoSize = true;
            this.ppPrevious.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ppPrevious.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ppPrevious.Location = new System.Drawing.Point(1258, 729);
            this.ppPrevious.Name = "ppPrevious";
            this.ppPrevious.Size = new System.Drawing.Size(64, 17);
            this.ppPrevious.TabIndex = 7;
            this.ppPrevious.Text = "Previous";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(306, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.Location = new System.Drawing.Point(1130, 148);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(215, 23);
            this.searchBox.TabIndex = 3;
            this.searchBox.Text = "Search For Report";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(802, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "End Date:";
            // 
            // rCategory
            // 
            this.rCategory.AutoSize = true;
            this.rCategory.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rCategory.Location = new System.Drawing.Point(240, 149);
            this.rCategory.Name = "rCategory";
            this.rCategory.Size = new System.Drawing.Size(60, 15);
            this.rCategory.TabIndex = 2;
            this.rCategory.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(480, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Location = new System.Drawing.Point(877, 149);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(218, 21);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(561, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.Logout);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1529, 84);
            this.panel2.TabIndex = 4;
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Logout.ForeColor = System.Drawing.Color.Black;
            this.Logout.LinkColor = System.Drawing.Color.Black;
            this.Logout.Location = new System.Drawing.Point(1294, 32);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(77, 25);
            this.Logout.TabIndex = 3;
            this.Logout.TabStop = true;
            this.Logout.Text = "Logout";
            this.Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1457, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(75, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(266, 84);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.hpReports);
            this.panel3.Controls.Add(this.hpUserManagement);
            this.panel3.Controls.Add(this.hpProductCatButton);
            this.panel3.Controls.Add(this.hProductButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 680);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(391, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reports";
            // 
            // hpReports
            // 
            this.hpReports.BackColor = System.Drawing.Color.DarkSalmon;
            this.hpReports.Enabled = false;
            this.hpReports.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hpReports.ForeColor = System.Drawing.Color.Gray;
            this.hpReports.Location = new System.Drawing.Point(14, 271);
            this.hpReports.Name = "hpReports";
            this.hpReports.Size = new System.Drawing.Size(185, 44);
            this.hpReports.TabIndex = 3;
            this.hpReports.Text = "Reports";
            this.hpReports.UseVisualStyleBackColor = false;
            // 
            // hpUserManagement
            // 
            this.hpUserManagement.BackColor = System.Drawing.Color.Salmon;
            this.hpUserManagement.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hpUserManagement.ForeColor = System.Drawing.Color.Transparent;
            this.hpUserManagement.Location = new System.Drawing.Point(14, 197);
            this.hpUserManagement.Name = "hpUserManagement";
            this.hpUserManagement.Size = new System.Drawing.Size(185, 44);
            this.hpUserManagement.TabIndex = 3;
            this.hpUserManagement.Text = "User Management";
            this.hpUserManagement.UseVisualStyleBackColor = false;
            this.hpUserManagement.Click += new System.EventHandler(this.hpUserManagement_Click);
            // 
            // hpProductCatButton
            // 
            this.hpProductCatButton.BackColor = System.Drawing.Color.Salmon;
            this.hpProductCatButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hpProductCatButton.ForeColor = System.Drawing.Color.White;
            this.hpProductCatButton.Location = new System.Drawing.Point(14, 124);
            this.hpProductCatButton.Name = "hpProductCatButton";
            this.hpProductCatButton.Size = new System.Drawing.Size(185, 44);
            this.hpProductCatButton.TabIndex = 3;
            this.hpProductCatButton.Text = "Product Category";
            this.hpProductCatButton.UseVisualStyleBackColor = false;
            this.hpProductCatButton.Click += new System.EventHandler(this.hpProductCatButton_Click);
            // 
            // hProductButton
            // 
            this.hProductButton.BackColor = System.Drawing.Color.Salmon;
            this.hProductButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hProductButton.ForeColor = System.Drawing.Color.White;
            this.hProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hProductButton.Location = new System.Drawing.Point(23, 51);
            this.hProductButton.Name = "hProductButton";
            this.hProductButton.Size = new System.Drawing.Size(163, 44);
            this.hProductButton.TabIndex = 3;
            this.hProductButton.Text = "Products";
            this.hProductButton.UseVisualStyleBackColor = false;
            this.hProductButton.Click += new System.EventHandler(this.hProductButton_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1529, 764);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
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
        private Button pp2;
        private Button pp1;
        private Label ppNext;
        private Label ppPrevious;
        private Panel panel2;
        private LinkLabel Logout;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label3;
        private Button hpReports;
        private Button hpUserManagement;
        private Button hpProductCatButton;
        private Button hProductButton;
    }
}