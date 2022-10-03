namespace Shoprite_Inventory_Management
{
    partial class Product_Modal
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
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.productDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pmProductName = new System.Windows.Forms.Label();
            this.pmProductDescription = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PManageCloseButton = new System.Windows.Forms.PictureBox();
            this.pmQuantity = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PManageCloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(236, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add A New Product";
            // 
            // categoryBox
            // 
            this.categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.categoryBox.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(37, 132);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(245, 28);
            this.categoryBox.TabIndex = 1;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // productName
            // 
            this.productName.Font = new System.Drawing.Font("Georgia", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productName.Location = new System.Drawing.Point(353, 131);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(245, 28);
            this.productName.TabIndex = 2;
            this.productName.TextChanged += new System.EventHandler(this.productName_TextChanged);
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Georgia", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price.Location = new System.Drawing.Point(353, 238);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(245, 28);
            this.price.TabIndex = 2;
            this.price.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // productDescription
            // 
            this.productDescription.Font = new System.Drawing.Font("Georgia", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productDescription.Location = new System.Drawing.Point(37, 238);
            this.productDescription.Name = "productDescription";
            this.productDescription.Size = new System.Drawing.Size(245, 28);
            this.productDescription.TabIndex = 2;
            this.productDescription.TextChanged += new System.EventHandler(this.productDescription_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Category";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pmProductName
            // 
            this.pmProductName.AutoSize = true;
            this.pmProductName.Font = new System.Drawing.Font("Georgia", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pmProductName.Location = new System.Drawing.Point(353, 98);
            this.pmProductName.Name = "pmProductName";
            this.pmProductName.Size = new System.Drawing.Size(125, 21);
            this.pmProductName.TabIndex = 0;
            this.pmProductName.Text = "Product Name";
            // 
            // pmProductDescription
            // 
            this.pmProductDescription.AutoSize = true;
            this.pmProductDescription.Font = new System.Drawing.Font("Georgia", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pmProductDescription.Location = new System.Drawing.Point(37, 208);
            this.pmProductDescription.Name = "pmProductDescription";
            this.pmProductDescription.Size = new System.Drawing.Size(169, 21);
            this.pmProductDescription.TabIndex = 0;
            this.pmProductDescription.Text = "Product Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(352, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.PManageCloseButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 60);
            this.panel1.TabIndex = 3;
            // 
            // PManageCloseButton
            // 
            this.PManageCloseButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PManageCloseButton.Image = global::Shoprite_Inventory_Management.Properties.Resources.close_500px;
            this.PManageCloseButton.Location = new System.Drawing.Point(588, 12);
            this.PManageCloseButton.Name = "PManageCloseButton";
            this.PManageCloseButton.Size = new System.Drawing.Size(33, 34);
            this.PManageCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PManageCloseButton.TabIndex = 2;
            this.PManageCloseButton.TabStop = false;
            this.PManageCloseButton.Click += new System.EventHandler(this.PManageCloseButton_Click);
            // 
            // pmQuantity
            // 
            this.pmQuantity.AutoSize = true;
            this.pmQuantity.Font = new System.Drawing.Font("Georgia", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pmQuantity.Location = new System.Drawing.Point(37, 313);
            this.pmQuantity.Name = "pmQuantity";
            this.pmQuantity.Size = new System.Drawing.Size(80, 21);
            this.pmQuantity.TabIndex = 0;
            this.pmQuantity.Text = "Quantity";
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Georgia", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantity.Location = new System.Drawing.Point(37, 348);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(245, 28);
            this.quantity.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(532, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(434, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 33);
            this.button2.TabIndex = 19;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Product_Modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.productDescription);
            this.Controls.Add(this.price);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pmQuantity);
            this.Controls.Add(this.pmProductDescription);
            this.Controls.Add(this.pmProductName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_Modal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_Modal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PManageCloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox PManageCloseButton;
        public ComboBox categoryBox;
        public TextBox productDescription;
        public TextBox productName;
        public TextBox price;
        public Label label2;
        public Label pmProductName;
        public Label pmProductDescription;
        public Label label6;
        public Label pmQuantity;
        public TextBox quantity;
        public Button button2;
        public Button button1;
    }
}