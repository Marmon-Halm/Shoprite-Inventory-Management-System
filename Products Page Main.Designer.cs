namespace Shoprite_Inventory_Management
{
    partial class Products_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products_Page));
            this.ppPanel = new System.Windows.Forms.Panel();
            this.pp2 = new System.Windows.Forms.Button();
            this.pp1 = new System.Windows.Forms.Button();
            this.ppNext = new System.Windows.Forms.Label();
            this.ppPrevious = new System.Windows.Forms.Label();
            this.ppProductButton = new System.Windows.Forms.Button();
            this.ppDataView = new System.Windows.Forms.DataGridView();
            this.ppHeader = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ppProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ppDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.ppPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // ppPanel
            // 
            this.ppPanel.BackColor = System.Drawing.Color.White;
            this.ppPanel.Controls.Add(this.pp2);
            this.ppPanel.Controls.Add(this.pp1);
            this.ppPanel.Controls.Add(this.ppNext);
            this.ppPanel.Controls.Add(this.ppPrevious);
            this.ppPanel.Controls.Add(this.ppProductButton);
            this.ppPanel.Controls.Add(this.ppDataView);
            this.ppPanel.Location = new System.Drawing.Point(30, 78);
            this.ppPanel.Name = "ppPanel";
            this.ppPanel.Size = new System.Drawing.Size(1311, 547);
            this.ppPanel.TabIndex = 0;
            // 
            // pp2
            // 
            this.pp2.BackColor = System.Drawing.Color.DarkGray;
            this.pp2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pp2.Location = new System.Drawing.Point(1124, 506);
            this.pp2.Name = "pp2";
            this.pp2.Size = new System.Drawing.Size(36, 32);
            this.pp2.TabIndex = 3;
            this.pp2.Text = "2";
            this.pp2.UseVisualStyleBackColor = false;
            // 
            // pp1
            // 
            this.pp1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pp1.Location = new System.Drawing.Point(1083, 506);
            this.pp1.Name = "pp1";
            this.pp1.Size = new System.Drawing.Size(36, 32);
            this.pp1.TabIndex = 3;
            this.pp1.Text = "1";
            this.pp1.UseVisualStyleBackColor = true;
            // 
            // ppNext
            // 
            this.ppNext.AutoSize = true;
            this.ppNext.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ppNext.Location = new System.Drawing.Point(1166, 514);
            this.ppNext.Name = "ppNext";
            this.ppNext.Size = new System.Drawing.Size(39, 17);
            this.ppNext.TabIndex = 1;
            this.ppNext.Text = "Next";
            // 
            // ppPrevious
            // 
            this.ppPrevious.AutoSize = true;
            this.ppPrevious.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ppPrevious.Location = new System.Drawing.Point(1013, 514);
            this.ppPrevious.Name = "ppPrevious";
            this.ppPrevious.Size = new System.Drawing.Size(64, 17);
            this.ppPrevious.TabIndex = 1;
            this.ppPrevious.Text = "Previous";
            // 
            // ppProductButton
            // 
            this.ppProductButton.Font = new System.Drawing.Font("Georgia", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ppProductButton.Location = new System.Drawing.Point(1104, 14);
            this.ppProductButton.Name = "ppProductButton";
            this.ppProductButton.Size = new System.Drawing.Size(146, 41);
            this.ppProductButton.TabIndex = 2;
            this.ppProductButton.Text = "Create Product";
            this.ppProductButton.UseVisualStyleBackColor = true;
            // 
            // ppDataView
            // 
            this.ppDataView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ppDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ppDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ppDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.ppCategory,
            this.productImage,
            this.ppProductName,
            this.ppProductDescription,
            this.ppQuantity,
            this.ppPrice,
            this.ppEdit,
            this.ppDelete});
            this.ppDataView.EnableHeadersVisualStyles = false;
            this.ppDataView.Location = new System.Drawing.Point(15, 61);
            this.ppDataView.Name = "ppDataView";
            this.ppDataView.RowTemplate.Height = 25;
            this.ppDataView.Size = new System.Drawing.Size(1278, 432);
            this.ppDataView.TabIndex = 1;
            // 
            // ppHeader
            // 
            this.ppHeader.AutoSize = true;
            this.ppHeader.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ppHeader.Location = new System.Drawing.Point(45, 24);
            this.ppHeader.Name = "ppHeader";
            this.ppHeader.Size = new System.Drawing.Size(209, 27);
            this.ppHeader.TabIndex = 1;
            this.ppHeader.Text = "Manage Products";
            this.ppHeader.Click += new System.EventHandler(this.ppHeader_Click);
            // 
            // Number
            // 
            this.Number.HeaderText = "No.";
            this.Number.Name = "Number";
            this.Number.Width = 50;
            // 
            // ppCategory
            // 
            this.ppCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ppCategory.FillWeight = 40F;
            this.ppCategory.HeaderText = "Category";
            this.ppCategory.Name = "ppCategory";
            // 
            // productImage
            // 
            this.productImage.HeaderText = "Product Image";
            this.productImage.Name = "productImage";
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
            // ppQuantity
            // 
            this.ppQuantity.HeaderText = "Quantity";
            this.ppQuantity.Name = "ppQuantity";
            this.ppQuantity.Width = 90;
            // 
            // ppPrice
            // 
            this.ppPrice.HeaderText = "Unit Price";
            this.ppPrice.Name = "ppPrice";
            this.ppPrice.Width = 110;
            // 
            // ppEdit
            // 
            this.ppEdit.HeaderText = "";
            this.ppEdit.Image = ((System.Drawing.Image)(resources.GetObject("ppEdit.Image")));
            this.ppEdit.Name = "ppEdit";
            this.ppEdit.Width = 40;
            // 
            // ppDelete
            // 
            this.ppDelete.HeaderText = "";
            this.ppDelete.Image = ((System.Drawing.Image)(resources.GetObject("ppDelete.Image")));
            this.ppDelete.Name = "ppDelete";
            this.ppDelete.Width = 40;
            // 
            // Products_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 627);
            this.Controls.Add(this.ppHeader);
            this.Controls.Add(this.ppPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products_Page";
            this.Text = "Products_Page";
            this.ppPanel.ResumeLayout(false);
            this.ppPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel ppPanel;
        private DataGridView ppDataView;
        private Label ppNext;
        private Label ppPrevious;
        private Button ppProductButton;
        private Label ppHeader;
        private Button pp2;
        private Button pp1;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn ppCategory;
        private DataGridViewImageColumn productImage;
        private DataGridViewTextBoxColumn ppProductName;
        private DataGridViewTextBoxColumn ppProductDescription;
        private DataGridViewTextBoxColumn ppQuantity;
        private DataGridViewTextBoxColumn ppPrice;
        private DataGridViewImageColumn ppEdit;
        private DataGridViewImageColumn ppDelete;
    }
}