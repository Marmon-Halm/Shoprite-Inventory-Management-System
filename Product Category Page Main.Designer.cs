namespace Shoprite_Inventory_Management
{
    partial class Product_Category_Page_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Category_Page_Main));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.cDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cCategoryButton = new System.Windows.Forms.Button();
            this.cHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNumber,
            this.cName,
            this.cEdit,
            this.cDelete});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(22, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1269, 494);
            this.dataGridView1.TabIndex = 0;
            // 
            // cNumber
            // 
            this.cNumber.HeaderText = "No.";
            this.cNumber.Name = "cNumber";
            this.cNumber.Width = 50;
            // 
            // cName
            // 
            this.cName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cName.FillWeight = 80F;
            this.cName.HeaderText = "Category Name";
            this.cName.Name = "cName";
            // 
            // cEdit
            // 
            this.cEdit.HeaderText = "";
            this.cEdit.Image = ((System.Drawing.Image)(resources.GetObject("cEdit.Image")));
            this.cEdit.Name = "cEdit";
            this.cEdit.Width = 50;
            // 
            // cDelete
            // 
            this.cDelete.HeaderText = "";
            this.cDelete.Image = ((System.Drawing.Image)(resources.GetObject("cDelete.Image")));
            this.cDelete.Name = "cDelete";
            this.cDelete.Width = 50;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cCategoryButton);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(37, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 560);
            this.panel1.TabIndex = 1;
            // 
            // cCategoryButton
            // 
            this.cCategoryButton.Font = new System.Drawing.Font("Georgia", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cCategoryButton.Location = new System.Drawing.Point(1099, 16);
            this.cCategoryButton.Name = "cCategoryButton";
            this.cCategoryButton.Size = new System.Drawing.Size(146, 41);
            this.cCategoryButton.TabIndex = 1;
            this.cCategoryButton.Text = "Create Category";
            this.cCategoryButton.UseVisualStyleBackColor = true;
            // 
            // cHeader
            // 
            this.cHeader.AutoSize = true;
            this.cHeader.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cHeader.Location = new System.Drawing.Point(79, 27);
            this.cHeader.Name = "cHeader";
            this.cHeader.Size = new System.Drawing.Size(113, 27);
            this.cHeader.TabIndex = 2;
            this.cHeader.Text = "Category";
            // 
            // Product_Category_Page_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 666);
            this.Controls.Add(this.cHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_Category_Page_Main";
            this.Text = "Product_Category_Page_Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn cNumber;
        private DataGridViewTextBoxColumn cName;
        private DataGridViewImageColumn cEdit;
        private DataGridViewImageColumn cDelete;
        private Panel panel1;
        private Button cCategoryButton;
        private Label cHeader;
    }
}