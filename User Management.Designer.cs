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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Management));
            this.uDataView = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uUname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.uDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.uPanel = new System.Windows.Forms.Panel();
            this.uUserButton = new System.Windows.Forms.Button();
            this.uHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uDataView)).BeginInit();
            this.uPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uDataView
            // 
            this.uDataView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.uDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.uUname,
            this.ufname,
            this.uDOB,
            this.uPOR,
            this.uGender,
            this.uContact,
            this.uPassword,
            this.uEdit,
            this.uDelete});
            this.uDataView.EnableHeadersVisualStyles = false;
            this.uDataView.Location = new System.Drawing.Point(18, 61);
            this.uDataView.Name = "uDataView";
            this.uDataView.RowTemplate.Height = 25;
            this.uDataView.Size = new System.Drawing.Size(1280, 471);
            this.uDataView.TabIndex = 1;
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
            // uDOB
            // 
            this.uDOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uDOB.FillWeight = 30F;
            this.uDOB.HeaderText = "Date Of Birth";
            this.uDOB.Name = "uDOB";
            // 
            // uPOR
            // 
            this.uPOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uPOR.FillWeight = 50F;
            this.uPOR.HeaderText = "Place Of Recidence";
            this.uPOR.Name = "uPOR";
            // 
            // uGender
            // 
            this.uGender.HeaderText = "Gender";
            this.uGender.Name = "uGender";
            this.uGender.Width = 80;
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
            // uPanel
            // 
            this.uPanel.BackColor = System.Drawing.Color.White;
            this.uPanel.Controls.Add(this.uUserButton);
            this.uPanel.Controls.Add(this.uDataView);
            this.uPanel.Location = new System.Drawing.Point(35, 69);
            this.uPanel.Name = "uPanel";
            this.uPanel.Size = new System.Drawing.Size(1318, 597);
            this.uPanel.TabIndex = 2;
            // 
            // uUserButton
            // 
            this.uUserButton.BackColor = System.Drawing.Color.Salmon;
            this.uUserButton.Font = new System.Drawing.Font("Georgia", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uUserButton.Location = new System.Drawing.Point(1097, 14);
            this.uUserButton.Name = "uUserButton";
            this.uUserButton.Size = new System.Drawing.Size(146, 41);
            this.uUserButton.TabIndex = 2;
            this.uUserButton.Text = "Create User";
            this.uUserButton.UseVisualStyleBackColor = false;
            this.uUserButton.Click += new System.EventHandler(this.uUserButton_Click);
            // 
            // uHeader
            // 
            this.uHeader.AutoSize = true;
            this.uHeader.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uHeader.Location = new System.Drawing.Point(72, 21);
            this.uHeader.Name = "uHeader";
            this.uHeader.Size = new System.Drawing.Size(220, 27);
            this.uHeader.TabIndex = 3;
            this.uHeader.Text = "User Management";
            // 
            // User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1394, 666);
            this.Controls.Add(this.uHeader);
            this.Controls.Add(this.uPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Management";
            this.Text = "User_Management";
            this.Load += new System.EventHandler(this.User_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uDataView)).EndInit();
            this.uPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView uDataView;
        private Panel uPanel;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn uUname;
        private DataGridViewTextBoxColumn ufname;
        private DataGridViewTextBoxColumn uDOB;
        private DataGridViewTextBoxColumn uPOR;
        private DataGridViewTextBoxColumn uGender;
        private DataGridViewTextBoxColumn uContact;
        private DataGridViewTextBoxColumn uPassword;
        private DataGridViewImageColumn uEdit;
        private DataGridViewImageColumn uDelete;
        private Label uHeader;
        private Button uUserButton;
    }
}