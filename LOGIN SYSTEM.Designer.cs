namespace Shoprite_Inventory_Management
{
    partial class LOGIN_SYSTEM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN_SYSTEM));
            this.lUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.radioUser = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginUsernameBox = new System.Windows.Forms.TextBox();
            this.closeBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lUsername.Location = new System.Drawing.Point(1139, 263);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(96, 23);
            this.lUsername.TabIndex = 1;
            this.lUsername.Text = "Username";
            this.lUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1213, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Welcome!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Georgia", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.Location = new System.Drawing.Point(1213, 498);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(169, 42);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 703);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1139, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Font = new System.Drawing.Font("Georgia", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioAdmin.Location = new System.Drawing.Point(1178, 193);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(78, 24);
            this.radioAdmin.TabIndex = 5;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Admin";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.Font = new System.Drawing.Font("Georgia", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioUser.Location = new System.Drawing.Point(1320, 193);
            this.radioUser.Name = "radioUser";
            this.radioUser.Size = new System.Drawing.Size(62, 24);
            this.radioUser.TabIndex = 5;
            this.radioUser.TabStop = true;
            this.radioUser.Text = "User";
            this.radioUser.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(1162, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 67);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Font = new System.Drawing.Font("Georgia", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showPassword.Location = new System.Drawing.Point(1311, 448);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(124, 21);
            this.showPassword.TabIndex = 7;
            this.showPassword.Text = "Show Password";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // loginPassword
            // 
            this.loginPassword.Font = new System.Drawing.Font("Georgia", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginPassword.Location = new System.Drawing.Point(1139, 402);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PlaceholderText = "Enter Password";
            this.loginPassword.Size = new System.Drawing.Size(296, 28);
            this.loginPassword.TabIndex = 8;
            this.loginPassword.TextChanged += new System.EventHandler(this.loginPassword_TextChanged);
            // 
            // loginUsernameBox
            // 
            this.loginUsernameBox.Font = new System.Drawing.Font("Georgia", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginUsernameBox.Location = new System.Drawing.Point(1139, 298);
            this.loginUsernameBox.Name = "loginUsernameBox";
            this.loginUsernameBox.PlaceholderText = "Enter Username";
            this.loginUsernameBox.Size = new System.Drawing.Size(296, 28);
            this.loginUsernameBox.TabIndex = 9;
            this.loginUsernameBox.TextChanged += new System.EventHandler(this.loginUsernameBox_TextChanged);
            // 
            // closeBox
            // 
            this.closeBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.closeBox.Image = ((System.Drawing.Image)(resources.GetObject("closeBox.Image")));
            this.closeBox.Location = new System.Drawing.Point(1438, 12);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(43, 38);
            this.closeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBox.TabIndex = 10;
            this.closeBox.TabStop = false;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            // 
            // LOGIN_SYSTEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1503, 703);
            this.Controls.Add(this.closeBox);
            this.Controls.Add(this.loginUsernameBox);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.radioUser);
            this.Controls.Add(this.radioAdmin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lUsername);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LOGIN_SYSTEM";
            this.Text = "LOGIN_SYSTEM";
            this.Load += new System.EventHandler(this.LOGIN_SYSTEM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lUsername;
        private Label label3;
        private Button loginButton;
        private Panel panel1;
        private Label label2;
        private RadioButton radioAdmin;
        private RadioButton radioUser;
        private PictureBox pictureBox2;
        private CheckBox showPassword;
        private TextBox loginPassword;
        private TextBox loginUsernameBox;
        private PictureBox closeBox;
    }
}