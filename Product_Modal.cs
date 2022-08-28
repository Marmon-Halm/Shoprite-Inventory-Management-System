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
    public partial class Product_Modal : Form

    {

    
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\micha\OneDrive\Documents\Inventory Database.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
    public Product_Modal() => InitializeComponent();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PManageCloseButton_Click(object sender, EventArgs e)
        {
           
                this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirm To Add Product", "Add New Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    cm = new SqlCommand("INSERT INTO tbProduct_Table(Category,Product_Name,Product_Description,Price,Quantity)VALUES(@Category,@Product_Name,@Product_Description,@Price,@Quantity)", con);
                    cm.Parameters.AddWithValue("@Category", categoryBox.Text);
                    cm.Parameters.AddWithValue("@Product_Name", productName.Text);
                    cm.Parameters.AddWithValue("@Product_Description", productDescription.Text);
                    cm.Parameters.AddWithValue("@Price", price.Text);
                    cm.Parameters.AddWithValue("@Quantity", quantity.Text);

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Product Added Successfully!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void productName_TextChanged(object sender, EventArgs e)
        {

        }

        private void productDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
