using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shoprite_Inventory_Management
{
    public partial class Product_Category_Modal : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\micha\OneDrive\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public Product_Category_Modal() => InitializeComponent();

        private void PCatCloseButton_Click(object sender, EventArgs e)
        {
           
                this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirm To Add Product Category", "Add Product Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm = new SqlCommand("INSERT INTO tbCategory_Table(productCategoryName)VALUES(@productCategoryName)", con);
                    cm.Parameters.AddWithValue("@productCategoryName", categoryNameBox.Text);

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product Category Added Successfully!");
                    clear();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Confirm product category update?", "Updating Product Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)


                {
                    cm = new SqlCommand("UPDATE tbCategory_Table SET productCategoryName=@productCategoryName WHERE productCategoryId LIKE '" + catID.Text+ "'", con);
                }

                {
                    cm.Parameters.AddWithValue("@productCategoryName", categoryNameBox.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product Category Updated Successfully");
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        public void clear()
        {
            categoryNameBox.ResetText();
        }

        private void categoryClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

