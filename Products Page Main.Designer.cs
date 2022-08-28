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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ppProductButton = new System.Windows.Forms.Button();
            this.ppDataView = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ppProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ppDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.ppHeader = new System.Windows.Forms.Label();
            this.ppClose = new System.Windows.Forms.PictureBox();
            this.ppPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppClose)).BeginInit();
            this.SuspendLayout();
            // 
            // ppPanel
            // 
            this.ppPanel.BackColor = System.Drawing.Color.White;
            this.ppPanel.Controls.Add(this.button1);
            this.ppPanel.Controls.Add(this.button2);
            this.ppPanel.Controls.Add(this.label1);
            this.ppPanel.Controls.Add(this.label2);
            this.ppPanel.Controls.Add(this.ppProductButton);
            this.ppPanel.Controls.Add(this.ppDataView);
            this.ppPanel.Location = new System.Drawing.Point(12, 58);
            this.ppPanel.Name = "ppPanel";
            this.ppPanel.Size = new System.Drawing.Size(1293, 547);
            this.ppPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1131, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "2";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1090, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 32);
            this.button2.TabIndex = 13;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(1173, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Next";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(1020, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Previous";
            // 
            // ppProductButton
            // 
            this.ppProductButton.BackColor = System.Drawing.Color.Salmon;
            this.ppProductButton.Font = new System.Drawing.Font("Georgia", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ppProductButton.ForeColor = System.Drawing.Color.White;
            this.ppProductButton.Location = new System.Drawing.Point(1104, 14);
            this.ppProductButton.Name = "ppProductButton";
            this.ppProductButton.Size = new System.Drawing.Size(146, 41);
            this.ppProductButton.TabIndex = 2;
            this.ppProductButton.Text = "Create Product";
            this.ppProductButton.UseVisualStyleBackColor = false;
            this.ppProductButton.Click += new System.EventHandler(this.ppProductButton_Click);
            // 
            // ppDataView
            // 
            this.ppDataView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.ppDataView.Size = new System.Drawing.Size(1265, 438);
            this.ppDataView.TabIndex = 1;
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
            // ppHeader
            // 
            this.ppHeader.AutoSize = true;
            this.ppHeader.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ppHeader.Location = new System.Drawing.Point(65, 12);
            this.ppHeader.Name = "ppHeader";
            this.ppHeader.Size = new System.Drawing.Size(209, 27);
            this.ppHeader.TabIndex = 1;
            this.ppHeader.Text = "Manage Products";
            this.ppHeader.Click += new System.EventHandler(this.ppHeader_Click);
            // 
            // ppClose
            // 
            this.ppClose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ppClose.Image = global::Shoprite_Inventory_Management.Properties.Resources.close_500px;
            this.ppClose.Location = new System.Drawing.Point(1272, 12);
            this.ppClose.Name = "ppClose";
            this.ppClose.Size = new System.Drawing.Size(33, 27);
            this.ppClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ppClose.TabIndex = 2;
            this.ppClose.TabStop = false;
            this.ppClose.Click += new System.EventHandler(this.ppClose_Click);
            // 
            // Products_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 612);
            this.Controls.Add(this.ppClose);
            this.Controls.Add(this.ppHeader);
            this.Controls.Add(this.ppPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products_Page";
            this.ppPanel.ResumeLayout(false);
            this.ppPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel ppPanel;
        private DataGridView ppDataView;
        private Button ppProductButton;
        private Label ppHeader;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn ppCategory;
        private DataGridViewImageColumn productImage;
        private DataGridViewTextBoxColumn ppProductName;
        private DataGridViewTextBoxColumn ppProductDescription;
        private DataGridViewTextBoxColumn ppQuantity;
        private DataGridViewTextBoxColumn ppPrice;
        private DataGridViewImageColumn ppEdit;
        private DataGridViewImageColumn ppDelete;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private PictureBox ppClose;
    }
}