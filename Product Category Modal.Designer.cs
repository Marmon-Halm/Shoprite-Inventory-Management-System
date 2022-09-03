namespace Shoprite_Inventory_Management
{
    partial class Product_Category_Modal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.categoryClose = new System.Windows.Forms.PictureBox();
            this.PCatCloseButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryNameBox = new System.Windows.Forms.TextBox();
            this.pcmCategoryName = new System.Windows.Forms.Label();
            this.catID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCatCloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.catID);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.categoryNameBox);
            this.panel1.Controls.Add(this.pcmCategoryName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 299);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // updateBtn
            // 
            this.updateBtn.Enabled = false;
            this.updateBtn.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.Location = new System.Drawing.Point(286, 254);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(92, 33);
            this.updateBtn.TabIndex = 23;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(384, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(188, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 33);
            this.button3.TabIndex = 22;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Salmon;
            this.panel3.Controls.Add(this.categoryClose);
            this.panel3.Controls.Add(this.PCatCloseButton);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 60);
            this.panel3.TabIndex = 20;
            // 
            // categoryClose
            // 
            this.categoryClose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.categoryClose.Image = global::Shoprite_Inventory_Management.Properties.Resources.close_500px;
            this.categoryClose.Location = new System.Drawing.Point(447, 12);
            this.categoryClose.Name = "categoryClose";
            this.categoryClose.Size = new System.Drawing.Size(42, 37);
            this.categoryClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.categoryClose.TabIndex = 3;
            this.categoryClose.TabStop = false;
            this.categoryClose.Click += new System.EventHandler(this.categoryClose_Click);
            // 
            // PCatCloseButton
            // 
            this.PCatCloseButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PCatCloseButton.Image = global::Shoprite_Inventory_Management.Properties.Resources.close_500px;
            this.PCatCloseButton.Location = new System.Drawing.Point(595, 16);
            this.PCatCloseButton.Name = "PCatCloseButton";
            this.PCatCloseButton.Size = new System.Drawing.Size(42, 30);
            this.PCatCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCatCloseButton.TabIndex = 2;
            this.PCatCloseButton.TabStop = false;
            this.PCatCloseButton.Click += new System.EventHandler(this.PCatCloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(130, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add A Product Category";
            // 
            // categoryNameBox
            // 
            this.categoryNameBox.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryNameBox.Location = new System.Drawing.Point(55, 151);
            this.categoryNameBox.Name = "categoryNameBox";
            this.categoryNameBox.Size = new System.Drawing.Size(388, 31);
            this.categoryNameBox.TabIndex = 19;
            this.categoryNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pcmCategoryName
            // 
            this.pcmCategoryName.AutoSize = true;
            this.pcmCategoryName.Font = new System.Drawing.Font("Georgia", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pcmCategoryName.Location = new System.Drawing.Point(55, 108);
            this.pcmCategoryName.Name = "pcmCategoryName";
            this.pcmCategoryName.Size = new System.Drawing.Size(200, 21);
            this.pcmCategoryName.TabIndex = 18;
            this.pcmCategoryName.Text = "Product Category Name";
            // 
            // catID
            // 
            this.catID.AutoSize = true;
            this.catID.Location = new System.Drawing.Point(405, 95);
            this.catID.Name = "catID";
            this.catID.Size = new System.Drawing.Size(38, 15);
            this.catID.TabIndex = 24;
            this.catID.Text = "label2";
            this.catID.Visible = false;
            // 
            // Product_Category_Modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 299);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_Category_Modal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_Category_Modal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCatCloseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private Label pcmCategoryName;
        private PictureBox PCatCloseButton;
        public Button updateBtn;
        public TextBox categoryNameBox;
        public Button button1;
        public Button button3;
        private PictureBox categoryClose;
        public Label catID;
    }
}