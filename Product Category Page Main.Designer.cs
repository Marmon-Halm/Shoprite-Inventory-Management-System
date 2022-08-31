namespace Shoprite_Inventory_Management
{
    partial class Product_Category_Page_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Category_Page_Main));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cCategoryButton = new System.Windows.Forms.Button();
            this.cHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.hpReports = new System.Windows.Forms.Button();
            this.hpUserManagement = new System.Windows.Forms.Button();
            this.hpProductCatButton = new System.Windows.Forms.Button();
            this.hProductButton = new System.Windows.Forms.Button();
            this.cNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNumber,
            this.cName,
            this.Edit,
            this.Delete});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(233, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1272, 543);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cCategoryButton);
            this.panel1.Controls.Add(this.cHeader);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1529, 764);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(1387, 720);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 32);
            this.button4.TabIndex = 21;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(1346, 720);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 32);
            this.button5.TabIndex = 22;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(1429, 728);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Next";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(1276, 728);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Previous";
            // 
            // cCategoryButton
            // 
            this.cCategoryButton.BackColor = System.Drawing.Color.Salmon;
            this.cCategoryButton.Font = new System.Drawing.Font("Georgia", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cCategoryButton.ForeColor = System.Drawing.Color.White;
            this.cCategoryButton.Location = new System.Drawing.Point(1346, 113);
            this.cCategoryButton.Name = "cCategoryButton";
            this.cCategoryButton.Size = new System.Drawing.Size(146, 41);
            this.cCategoryButton.TabIndex = 1;
            this.cCategoryButton.Text = "Add Category";
            this.cCategoryButton.UseVisualStyleBackColor = false;
            this.cCategoryButton.Click += new System.EventHandler(this.cCategoryButton_Click);
            // 
            // cHeader
            // 
            this.cHeader.AutoSize = true;
            this.cHeader.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cHeader.Location = new System.Drawing.Point(233, 119);
            this.cHeader.Name = "cHeader";
            this.cHeader.Size = new System.Drawing.Size(209, 27);
            this.cHeader.TabIndex = 2;
            this.cHeader.Text = "Product Category";
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
            this.panel2.TabIndex = 2;
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
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.hpReports);
            this.panel3.Controls.Add(this.hpUserManagement);
            this.panel3.Controls.Add(this.hpProductCatButton);
            this.panel3.Controls.Add(this.hProductButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 680);
            this.panel3.TabIndex = 3;
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
            this.hpProductCatButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.hpProductCatButton.Enabled = false;
            this.hpProductCatButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hpProductCatButton.ForeColor = System.Drawing.Color.Gray;
            this.hpProductCatButton.Location = new System.Drawing.Point(14, 124);
            this.hpProductCatButton.Name = "hpProductCatButton";
            this.hpProductCatButton.Size = new System.Drawing.Size(185, 44);
            this.hpProductCatButton.TabIndex = 3;
            this.hpProductCatButton.Text = "Product Category";
            this.hpProductCatButton.UseVisualStyleBackColor = false;
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
            // cNumber
            // 
            this.cNumber.HeaderText = "No.";
            this.cNumber.Name = "cNumber";
            this.cNumber.Width = 50;
            // 
            // cName
            // 
            this.cName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cName.FillWeight = 80F;
            this.cName.HeaderText = "Category Name";
            this.cName.Name = "cName";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.Width = 50;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.Width = 50;
            // 
            // Product_Category_Page_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 764);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_Category_Page_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_Category_Page_Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button cCategoryButton;
        private Label cHeader;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private LinkLabel Logout;
        private Label label2;
        private Button hpReports;
        private Button hpUserManagement;
        private Button hpProductCatButton;
        private Button hProductButton;
        private Button button4;
        private Button button5;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn cNumber;
        private DataGridViewTextBoxColumn cName;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}