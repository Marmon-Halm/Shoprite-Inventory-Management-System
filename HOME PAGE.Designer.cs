namespace Shoprite_Inventory_Management
{
    partial class REGISTER_SYSTEM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REGISTER_SYSTEM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.hpReports = new System.Windows.Forms.Button();
            this.hpUserManagement = new System.Windows.Forms.Button();
            this.hpProductCatButton = new System.Windows.Forms.Button();
            this.hProductButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ppDataView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.ppHeader = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1529, 84);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Logout.ForeColor = System.Drawing.Color.Black;
            this.Logout.LinkColor = System.Drawing.Color.Black;
            this.Logout.Location = new System.Drawing.Point(1301, 32);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.hpReports);
            this.panel2.Controls.Add(this.hpUserManagement);
            this.panel2.Controls.Add(this.hpProductCatButton);
            this.panel2.Controls.Add(this.hProductButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 680);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(391, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reports";
            // 
            // hpReports
            // 
            this.hpReports.BackColor = System.Drawing.Color.Salmon;
            this.hpReports.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hpReports.ForeColor = System.Drawing.Color.Transparent;
            this.hpReports.Location = new System.Drawing.Point(14, 271);
            this.hpReports.Name = "hpReports";
            this.hpReports.Size = new System.Drawing.Size(185, 44);
            this.hpReports.TabIndex = 3;
            this.hpReports.Text = "Reports";
            this.hpReports.UseVisualStyleBackColor = false;
            this.hpReports.Click += new System.EventHandler(this.hpReports_Click);
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
            this.hpProductCatButton.ForeColor = System.Drawing.Color.Transparent;
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
            this.hProductButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.hProductButton.Enabled = false;
            this.hProductButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hProductButton.ForeColor = System.Drawing.Color.Gray;
            this.hProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hProductButton.Location = new System.Drawing.Point(23, 51);
            this.hProductButton.Name = "hProductButton";
            this.hProductButton.Size = new System.Drawing.Size(163, 44);
            this.hProductButton.TabIndex = 3;
            this.hProductButton.Text = "Products";
            this.hProductButton.UseVisualStyleBackColor = false;
            this.hProductButton.Click += new System.EventHandler(this.hProductButton_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.ppDataView);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.ppHeader);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(215, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1314, 680);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(1180, 636);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 32);
            this.button4.TabIndex = 17;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(1139, 636);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 32);
            this.button5.TabIndex = 18;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.Font = new System.Drawing.Font("Georgia", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1139, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 41);
            this.button3.TabIndex = 14;
            this.button3.Text = "Add Product";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ppDataView
            // 
            this.ppDataView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ppDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ppDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ppDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.Column1,
            this.ppCategory,
            this.ppProductName,
            this.ppProductDescription,
            this.ppPrice,
            this.ppQuantity,
            this.Edit,
            this.Delete});
            this.ppDataView.EnableHeadersVisualStyles = false;
            this.ppDataView.Location = new System.Drawing.Point(16, 89);
            this.ppDataView.MultiSelect = false;
            this.ppDataView.Name = "ppDataView";
            this.ppDataView.RowTemplate.Height = 25;
            this.ppDataView.Size = new System.Drawing.Size(1273, 536);
            this.ppDataView.TabIndex = 1;
            this.ppDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ppDataView_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(1222, 644);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Next";
            // 
            // ppHeader
            // 
            this.ppHeader.AutoSize = true;
            this.ppHeader.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ppHeader.Location = new System.Drawing.Point(16, 34);
            this.ppHeader.Name = "ppHeader";
            this.ppHeader.Size = new System.Drawing.Size(209, 27);
            this.ppHeader.TabIndex = 4;
            this.ppHeader.Text = "Manage Products";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(1069, 644);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Previous";
            // 
            // number
            // 
            this.number.HeaderText = "No.";
            this.number.Name = "number";
            this.number.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // ppCategory
            // 
            this.ppCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ppCategory.FillWeight = 40F;
            this.ppCategory.HeaderText = "Product Category";
            this.ppCategory.Name = "ppCategory";
            // 
            // ppProductName
            // 
            this.ppProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ppProductName.FillWeight = 50F;
            this.ppProductName.HeaderText = "Product Name";
            this.ppProductName.Name = "ppProductName";
            // 
            // ppProductDescription
            // 
            this.ppProductDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ppProductDescription.FillWeight = 70F;
            this.ppProductDescription.HeaderText = "Product Description";
            this.ppProductDescription.Name = "ppProductDescription";
            // 
            // ppPrice
            // 
            this.ppPrice.HeaderText = "Price";
            this.ppPrice.Name = "ppPrice";
            this.ppPrice.Width = 80;
            // 
            // ppQuantity
            // 
            this.ppQuantity.HeaderText = "Quantity";
            this.ppQuantity.Name = "ppQuantity";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.ToolTipText = "Edit Product";
            this.Edit.Width = 40;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ToolTipText = "Edit Product";
            this.Delete.Width = 40;
            // 
            // REGISTER_SYSTEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1529, 764);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "REGISTER_SYSTEM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTER_SYSTEM";
            this.Load += new System.EventHandler(this.REGISTER_SYSTEM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private Button hpReports;
        private Button hpUserManagement;
        private Button hpProductCatButton;
        private Button hProductButton;
        private PictureBox pictureBox2;
        private LinkLabel Logout;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label ppHeader;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label4;
        private Label label5;
        public DataGridView ppDataView;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ppCategory;
        private DataGridViewTextBoxColumn ppProductName;
        private DataGridViewTextBoxColumn ppProductDescription;
        private DataGridViewTextBoxColumn ppPrice;
        private DataGridViewTextBoxColumn ppQuantity;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}