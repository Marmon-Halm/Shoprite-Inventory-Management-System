namespace Shoprite_Inventory_Management
{
    partial class UpdateCategoryModal
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.categoryClose = new System.Windows.Forms.PictureBox();
            this.PCatCloseButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.updateCategoryNameBox = new System.Windows.Forms.TextBox();
            this.pcmCategoryName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryIDBox = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCatCloseButton)).BeginInit();
            this.SuspendLayout();
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
            this.panel3.TabIndex = 21;
            // 
            // categoryClose
            // 
            this.categoryClose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.categoryClose.Image = global::Shoprite_Inventory_Management.Properties.Resources.close_500px;
            this.categoryClose.Location = new System.Drawing.Point(460, 12);
            this.categoryClose.Name = "categoryClose";
            this.categoryClose.Size = new System.Drawing.Size(29, 28);
            this.categoryClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.categoryClose.TabIndex = 3;
            this.categoryClose.TabStop = false;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(123, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Product Category";
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.Location = new System.Drawing.Point(309, 254);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(92, 33);
            this.updateBtn.TabIndex = 24;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(407, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 25;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateCategoryNameBox
            // 
            this.updateCategoryNameBox.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateCategoryNameBox.Location = new System.Drawing.Point(57, 155);
            this.updateCategoryNameBox.Name = "updateCategoryNameBox";
            this.updateCategoryNameBox.Size = new System.Drawing.Size(388, 31);
            this.updateCategoryNameBox.TabIndex = 27;
            this.updateCategoryNameBox.TextChanged += new System.EventHandler(this.updateCategoryNameBox_TextChanged);
            // 
            // pcmCategoryName
            // 
            this.pcmCategoryName.AutoSize = true;
            this.pcmCategoryName.Font = new System.Drawing.Font("Georgia", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pcmCategoryName.Location = new System.Drawing.Point(57, 112);
            this.pcmCategoryName.Name = "pcmCategoryName";
            this.pcmCategoryName.Size = new System.Drawing.Size(200, 21);
            this.pcmCategoryName.TabIndex = 26;
            this.pcmCategoryName.Text = "Product Category Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Category ID :";
            // 
            // categoryIDBox
            // 
            this.categoryIDBox.Enabled = false;
            this.categoryIDBox.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryIDBox.Location = new System.Drawing.Point(162, 204);
            this.categoryIDBox.Name = "categoryIDBox";
            this.categoryIDBox.Size = new System.Drawing.Size(39, 25);
            this.categoryIDBox.TabIndex = 28;
            this.categoryIDBox.TextChanged += new System.EventHandler(this.categoryIDBox_TextChanged);
            // 
            // UpdateCategoryModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 299);
            this.Controls.Add(this.categoryIDBox);
            this.Controls.Add(this.updateCategoryNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcmCategoryName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateCategoryModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCategoryModal";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCatCloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel3;
        private PictureBox categoryClose;
        private PictureBox PCatCloseButton;
        private Label label1;
        public Button updateBtn;
        public Button button1;
        public TextBox updateCategoryNameBox;
        private Label pcmCategoryName;
        private Label label2;
        public TextBox categoryIDBox;
    }
}