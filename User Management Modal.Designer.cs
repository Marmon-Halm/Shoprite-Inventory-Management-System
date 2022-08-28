﻿namespace Shoprite_Inventory_Management
{
    partial class User_Management_Modal
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userManagementCloseButton = new System.Windows.Forms.PictureBox();
            this.textBoxPOR = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.userGender = new System.Windows.Forms.ComboBox();
            this.Gender = new System.Windows.Forms.Label();
            this.userAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userManagementCloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(238, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add A New User";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.userManagementCloseButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 60);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // userManagementCloseButton
            // 
            this.userManagementCloseButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userManagementCloseButton.Image = global::Shoprite_Inventory_Management.Properties.Resources.close_500px;
            this.userManagementCloseButton.Location = new System.Drawing.Point(625, 12);
            this.userManagementCloseButton.Name = "userManagementCloseButton";
            this.userManagementCloseButton.Size = new System.Drawing.Size(42, 37);
            this.userManagementCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userManagementCloseButton.TabIndex = 1;
            this.userManagementCloseButton.TabStop = false;
            this.userManagementCloseButton.Click += new System.EventHandler(this.userManagementCloseButton_Click);
            // 
            // textBoxPOR
            // 
            this.textBoxPOR.Font = new System.Drawing.Font("Georgia", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPOR.Location = new System.Drawing.Point(59, 253);
            this.textBoxPOR.Name = "textBoxPOR";
            this.textBoxPOR.Size = new System.Drawing.Size(245, 28);
            this.textBoxPOR.TabIndex = 12;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Georgia", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFullName.Location = new System.Drawing.Point(375, 152);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(245, 28);
            this.textBoxFullName.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(58, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Place Of Residence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(375, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Full Name";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Georgia", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(57, 119);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(93, 21);
            this.username.TabIndex = 8;
            this.username.Text = "Username";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(60, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Contact";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxContact
            // 
            this.textBoxContact.Font = new System.Drawing.Font("Georgia", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxContact.Location = new System.Drawing.Point(57, 351);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(245, 28);
            this.textBoxContact.TabIndex = 14;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Georgia", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.Location = new System.Drawing.Point(59, 152);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(245, 28);
            this.textBoxUsername.TabIndex = 13;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(575, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(378, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Georgia", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(375, 351);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(245, 28);
            this.textBoxPassword.TabIndex = 14;
            // 
            // userGender
            // 
            this.userGender.Font = new System.Drawing.Font("Georgia", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userGender.FormattingEnabled = true;
            this.userGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.userGender.Location = new System.Drawing.Point(374, 252);
            this.userGender.Name = "userGender";
            this.userGender.Size = new System.Drawing.Size(245, 29);
            this.userGender.TabIndex = 21;
            this.userGender.SelectedIndexChanged += new System.EventHandler(this.userGender_SelectedIndexChanged);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Georgia", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gender.Location = new System.Drawing.Point(374, 224);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(69, 21);
            this.Gender.TabIndex = 22;
            this.Gender.Text = "Gender";
            this.Gender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // userAdd
            // 
            this.userAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.userAdd.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userAdd.Location = new System.Drawing.Point(477, 456);
            this.userAdd.Name = "userAdd";
            this.userAdd.Size = new System.Drawing.Size(92, 35);
            this.userAdd.TabIndex = 23;
            this.userAdd.Text = "Add";
            this.userAdd.UseVisualStyleBackColor = false;
            this.userAdd.Click += new System.EventHandler(this.userAdd_Click);
            // 
            // User_Management_Modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 500);
            this.Controls.Add(this.userAdd);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.userGender);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxPOR);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Management_Modal";
            this.Text = "User_Management_Modal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userManagementCloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label username;
        private Button button1;
        private Label label8;
        private PictureBox userManagementCloseButton;
        private Label Gender;
        public TextBox textBoxPOR;
        public TextBox textBoxFullName;
        public Label label6;
        public Label label3;
        public Label label7;
        public TextBox textBoxContact;
        public TextBox textBoxUsername;
        public TextBox textBoxPassword;
        public ComboBox userGender;
        public Button userAdd;
    }
}