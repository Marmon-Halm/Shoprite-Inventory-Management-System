namespace Shoprite_Inventory_Management.ATTENDANT
{
    partial class Sales_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.salesLogout = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.salesSearchBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.totalAmount = new System.Windows.Forms.TextBox();
            this.salesTotalAmount = new System.Windows.Forms.Label();
            this.totalItems = new System.Windows.Forms.TextBox();
            this.salesTotalNo = new System.Windows.Forms.Label();
            this.salesClear = new System.Windows.Forms.Button();
            this.salesSubmit = new System.Windows.Forms.Button();
            this.salesCartPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.salesPlus = new System.Windows.Forms.Button();
            this.salesMinus = new System.Windows.Forms.Button();
            this.salesAmountBox = new System.Windows.Forms.TextBox();
            this.salesDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.salesProductName = new System.Windows.Forms.Label();
            this.salesProductID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.salesCartPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.salesLogout);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1563, 77);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::Shoprite_Inventory_Management.Properties.Resources.close_480px;
            this.pictureBox3.Location = new System.Drawing.Point(1487, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // salesLogout
            // 
            this.salesLogout.AutoSize = true;
            this.salesLogout.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salesLogout.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.salesLogout.LinkColor = System.Drawing.SystemColors.ControlText;
            this.salesLogout.Location = new System.Drawing.Point(1357, 35);
            this.salesLogout.Name = "salesLogout";
            this.salesLogout.Size = new System.Drawing.Size(69, 23);
            this.salesLogout.TabIndex = 2;
            this.salesLogout.TabStop = true;
            this.salesLogout.Text = "Logout";
            this.salesLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.salesLogout_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(153, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 77);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.salesSearchBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 633);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Location = new System.Drawing.Point(30, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(301, 546);
            this.panel5.TabIndex = 1;
            // 
            // salesSearchBox
            // 
            this.salesSearchBox.BackColor = System.Drawing.Color.LightGray;
            this.salesSearchBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salesSearchBox.Location = new System.Drawing.Point(29, 21);
            this.salesSearchBox.Name = "salesSearchBox";
            this.salesSearchBox.PlaceholderText = "Search Product";
            this.salesSearchBox.Size = new System.Drawing.Size(302, 29);
            this.salesSearchBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.totalAmount);
            this.panel3.Controls.Add(this.salesTotalAmount);
            this.panel3.Controls.Add(this.totalItems);
            this.panel3.Controls.Add(this.salesTotalNo);
            this.panel3.Controls.Add(this.salesClear);
            this.panel3.Controls.Add(this.salesSubmit);
            this.panel3.Controls.Add(this.salesCartPanel);
            this.panel3.Location = new System.Drawing.Point(415, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1148, 633);
            this.panel3.TabIndex = 0;
            // 
            // totalAmount
            // 
            this.totalAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalAmount.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalAmount.Location = new System.Drawing.Point(409, 592);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(88, 25);
            this.totalAmount.TabIndex = 2;
            // 
            // salesTotalAmount
            // 
            this.salesTotalAmount.AutoSize = true;
            this.salesTotalAmount.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salesTotalAmount.Location = new System.Drawing.Point(297, 595);
            this.salesTotalAmount.Name = "salesTotalAmount";
            this.salesTotalAmount.Size = new System.Drawing.Size(106, 18);
            this.salesTotalAmount.TabIndex = 0;
            this.salesTotalAmount.Text = "Total Amount";
            // 
            // totalItems
            // 
            this.totalItems.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalItems.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalItems.Location = new System.Drawing.Point(186, 592);
            this.totalItems.Name = "totalItems";
            this.totalItems.Size = new System.Drawing.Size(70, 25);
            this.totalItems.TabIndex = 2;
            // 
            // salesTotalNo
            // 
            this.salesTotalNo.AutoSize = true;
            this.salesTotalNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salesTotalNo.Location = new System.Drawing.Point(40, 595);
            this.salesTotalNo.Name = "salesTotalNo";
            this.salesTotalNo.Size = new System.Drawing.Size(140, 18);
            this.salesTotalNo.TabIndex = 0;
            this.salesTotalNo.Text = "Total No. Of Items";
            // 
            // salesClear
            // 
            this.salesClear.BackColor = System.Drawing.Color.Gray;
            this.salesClear.Font = new System.Drawing.Font("Georgia", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salesClear.ForeColor = System.Drawing.Color.White;
            this.salesClear.Location = new System.Drawing.Point(977, 590);
            this.salesClear.Name = "salesClear";
            this.salesClear.Size = new System.Drawing.Size(142, 36);
            this.salesClear.TabIndex = 1;
            this.salesClear.Text = "Clear";
            this.salesClear.UseVisualStyleBackColor = false;
            // 
            // salesSubmit
            // 
            this.salesSubmit.BackColor = System.Drawing.Color.Salmon;
            this.salesSubmit.Font = new System.Drawing.Font("Georgia", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salesSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salesSubmit.Location = new System.Drawing.Point(803, 590);
            this.salesSubmit.Name = "salesSubmit";
            this.salesSubmit.Size = new System.Drawing.Size(142, 36);
            this.salesSubmit.TabIndex = 1;
            this.salesSubmit.Text = "Submit";
            this.salesSubmit.UseVisualStyleBackColor = false;
            // 
            // salesCartPanel
            // 
            this.salesCartPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.salesCartPanel.Controls.Add(this.panel4);
            this.salesCartPanel.Location = new System.Drawing.Point(38, 30);
            this.salesCartPanel.Name = "salesCartPanel";
            this.salesCartPanel.Size = new System.Drawing.Size(1079, 544);
            this.salesCartPanel.TabIndex = 0;
            this.salesCartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.salesCartPanel_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.salesPlus);
            this.panel4.Controls.Add(this.salesMinus);
            this.panel4.Controls.Add(this.salesAmountBox);
            this.panel4.Controls.Add(this.salesDelete);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.salesProductName);
            this.panel4.Controls.Add(this.salesProductID);
            this.panel4.Location = new System.Drawing.Point(25, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1015, 53);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Shoprite_Inventory_Management.Properties.Resources.image_gallery;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(22, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 47);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // salesPlus
            // 
            this.salesPlus.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salesPlus.Location = new System.Drawing.Point(809, 12);
            this.salesPlus.Name = "salesPlus";
            this.salesPlus.Size = new System.Drawing.Size(26, 29);
            this.salesPlus.TabIndex = 1;
            this.salesPlus.Text = "+";
            this.salesPlus.UseVisualStyleBackColor = true;
            // 
            // salesMinus
            // 
            this.salesMinus.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salesMinus.Location = new System.Drawing.Point(742, 11);
            this.salesMinus.Name = "salesMinus";
            this.salesMinus.Size = new System.Drawing.Size(26, 31);
            this.salesMinus.TabIndex = 1;
            this.salesMinus.Text = "-";
            this.salesMinus.UseVisualStyleBackColor = true;
            // 
            // salesAmountBox
            // 
            this.salesAmountBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salesAmountBox.Location = new System.Drawing.Point(774, 13);
            this.salesAmountBox.Name = "salesAmountBox";
            this.salesAmountBox.PlaceholderText = "  1";
            this.salesAmountBox.Size = new System.Drawing.Size(29, 26);
            this.salesAmountBox.TabIndex = 3;
            // 
            // salesDelete
            // 
            this.salesDelete.BackColor = System.Drawing.Color.Firebrick;
            this.salesDelete.Font = new System.Drawing.Font("Georgia", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salesDelete.ForeColor = System.Drawing.Color.White;
            this.salesDelete.Location = new System.Drawing.Point(857, 11);
            this.salesDelete.Name = "salesDelete";
            this.salesDelete.Size = new System.Drawing.Size(142, 36);
            this.salesDelete.TabIndex = 2;
            this.salesDelete.Text = "Delete";
            this.salesDelete.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(562, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unit Price";
            // 
            // salesProductName
            // 
            this.salesProductName.AutoSize = true;
            this.salesProductName.Font = new System.Drawing.Font("Georgia", 14.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salesProductName.Location = new System.Drawing.Point(299, 16);
            this.salesProductName.Name = "salesProductName";
            this.salesProductName.Size = new System.Drawing.Size(158, 24);
            this.salesProductName.TabIndex = 0;
            this.salesProductName.Text = "Product Name";
            // 
            // salesProductID
            // 
            this.salesProductID.AutoSize = true;
            this.salesProductID.Font = new System.Drawing.Font("Georgia", 14.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salesProductID.Location = new System.Drawing.Point(153, 16);
            this.salesProductID.Name = "salesProductID";
            this.salesProductID.Size = new System.Drawing.Size(124, 24);
            this.salesProductID.TabIndex = 0;
            this.salesProductID.Text = "Product ID";
            // 
            // Sales_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1563, 710);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales_Main";
            this.Load += new System.EventHandler(this.Sales_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.salesCartPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel salesCartPanel;
        private Label salesProductID;
        private Panel panel5;
        private TextBox salesSearchBox;
        private TextBox totalAmount;
        private Label salesTotalAmount;
        private TextBox totalItems;
        private Label salesTotalNo;
        private Button salesClear;
        private Button salesSubmit;
        private Panel panel4;
        private Label label1;
        private Label salesProductName;
        private Button salesPlus;
        private Button salesMinus;
        private TextBox salesAmountBox;
        private Button salesDelete;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private LinkLabel salesLogout;
        private PictureBox pictureBox3;
    }
}