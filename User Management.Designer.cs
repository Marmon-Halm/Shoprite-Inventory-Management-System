namespace Shoprite_Inventory_Management
{
    partial class User_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Management));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.umClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.hpReports = new System.Windows.Forms.Button();
            this.hpUserManagement = new System.Windows.Forms.Button();
            this.hpProductCatButton = new System.Windows.Forms.Button();
            this.hProductButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uDataView = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uUname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.uDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.uHeader = new System.Windows.Forms.Label();
            this.uUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.umClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // umClose
            // 
            this.umClose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.umClose.Image = global::Shoprite_Inventory_Management.Properties.Resources.close_500px;
            this.umClose.Location = new System.Drawing.Point(1262, 9);
            this.umClose.Name = "umClose";
            this.umClose.Size = new System.Drawing.Size(32, 27);
            this.umClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.umClose.TabIndex = 4;
            this.umClose.TabStop = false;
            this.umClose.Click += new System.EventHandler(this.umClose_Click);
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
            this.panel1.Size = new System.Drawing.Size(1530, 84);
            this.panel1.TabIndex = 5;
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Logout.ForeColor = System.Drawing.Color.Black;
            this.Logout.LinkColor = System.Drawing.Color.Black;
            this.Logout.Location = new System.Drawing.Point(1290, 32);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(77, 25);
            this.Logout.TabIndex = 5;
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
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.hpUserManagement.BackColor = System.Drawing.Color.DarkSalmon;
            this.hpUserManagement.Enabled = false;
            this.hpUserManagement.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hpUserManagement.ForeColor = System.Drawing.Color.Gray;
            this.hpUserManagement.Location = new System.Drawing.Point(14, 197);
            this.hpUserManagement.Name = "hpUserManagement";
            this.hpUserManagement.Size = new System.Drawing.Size(185, 44);
            this.hpUserManagement.TabIndex = 3;
            this.hpUserManagement.Text = "User Management";
            this.hpUserManagement.UseVisualStyleBackColor = false;
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(1392, 728);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 32);
            this.button4.TabIndex = 32;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(1351, 728);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 32);
            this.button5.TabIndex = 33;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(1434, 736);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Next";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(1281, 736);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Previous";
            // 
            // uDataView
            // 
            this.uDataView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.uUname,
            this.ufname,
            this.uPOR,
            this.gender,
            this.uContact,
            this.uPassword,
            this.uEdit,
            this.uDelete});
            this.uDataView.EnableHeadersVisualStyles = false;
            this.uDataView.Location = new System.Drawing.Point(231, 169);
            this.uDataView.Name = "uDataView";
            this.uDataView.RowTemplate.Height = 25;
            this.uDataView.Size = new System.Drawing.Size(1287, 553);
            this.uDataView.TabIndex = 27;
            // 
            // Number
            // 
            this.Number.HeaderText = "No.";
            this.Number.Name = "Number";
            this.Number.Width = 40;
            // 
            // uUname
            // 
            this.uUname.HeaderText = "Username";
            this.uUname.Name = "uUname";
            this.uUname.Width = 120;
            // 
            // ufname
            // 
            this.ufname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ufname.FillWeight = 70F;
            this.ufname.HeaderText = "Full Name";
            this.ufname.Name = "ufname";
            // 
            // uPOR
            // 
            this.uPOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uPOR.FillWeight = 50F;
            this.uPOR.HeaderText = "Place Of Recidence";
            this.uPOR.Name = "uPOR";
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            // 
            // uContact
            // 
            this.uContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uContact.HeaderText = "Contact";
            this.uContact.Name = "uContact";
            this.uContact.Width = 87;
            // 
            // uPassword
            // 
            this.uPassword.HeaderText = "Password";
            this.uPassword.Name = "uPassword";
            this.uPassword.Width = 130;
            // 
            // uEdit
            // 
            this.uEdit.HeaderText = "";
            this.uEdit.Image = ((System.Drawing.Image)(resources.GetObject("uEdit.Image")));
            this.uEdit.Name = "uEdit";
            this.uEdit.Width = 50;
            // 
            // uDelete
            // 
            this.uDelete.HeaderText = "";
            this.uDelete.Image = ((System.Drawing.Image)(resources.GetObject("uDelete.Image")));
            this.uDelete.Name = "uDelete";
            this.uDelete.Width = 50;
            // 
            // uHeader
            // 
            this.uHeader.AutoSize = true;
            this.uHeader.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uHeader.Location = new System.Drawing.Point(231, 117);
            this.uHeader.Name = "uHeader";
            this.uHeader.Size = new System.Drawing.Size(220, 27);
            this.uHeader.TabIndex = 29;
            this.uHeader.Text = "User Management";
            // 
            // uUserButton
            // 
            this.uUserButton.BackColor = System.Drawing.Color.Salmon;
            this.uUserButton.Font = new System.Drawing.Font("Georgia", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uUserButton.ForeColor = System.Drawing.Color.White;
            this.uUserButton.Location = new System.Drawing.Point(1348, 111);
            this.uUserButton.Name = "uUserButton";
            this.uUserButton.Size = new System.Drawing.Size(146, 41);
            this.uUserButton.TabIndex = 28;
            this.uUserButton.Text = "Add A User";
            this.uUserButton.UseVisualStyleBackColor = false;
            this.uUserButton.Click += new System.EventHandler(this.uUserButton_Click_1);
            // 
            // User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1530, 764);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uDataView);
            this.Controls.Add(this.uHeader);
            this.Controls.Add(this.uUserButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.umClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "REGISTER_SYSTEM";
            this.Text = "User_Management";
            this.Load += new System.EventHandler(this.User_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.umClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox umClose;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label2;
        private Button hpReports;
        private Button hpUserManagement;
        private Button hpProductCatButton;
        private Button hProductButton;
        private LinkLabel Logout;
        private Button button4;
        private Button button5;
        private Label label4;
        private Label label5;
        private DataGridView uDataView;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn uUname;
        private DataGridViewTextBoxColumn ufname;
        private DataGridViewTextBoxColumn uPOR;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn uContact;
        private DataGridViewTextBoxColumn uPassword;
        private DataGridViewImageColumn uEdit;
        private DataGridViewImageColumn uDelete;
        private Label uHeader;
        private Button uUserButton;
    }
}