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

    
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\micha\OneDrive\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
       
        public Product_Modal()
        {
            InitializeComponent();
           Load_Category();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void PManageCloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Load_Category()
        {
            cm = new SqlCommand("SELECT CategoryName FROM tbCat", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                categoryBox.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }





        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirm To Add Product", "Add New Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm = new SqlCommand("INSERT INTO tbProduct(category,productName,productDescription,price,quantity)VALUES(@category,@productName,@productDescription,@price,@quantity)", con);
                    cm.Parameters.AddWithValue("@category", categoryBox.Text);
                    cm.Parameters.AddWithValue("@productName", productName.Text);
                    cm.Parameters.AddWithValue("@productDescription", productDescription.Text);
                    cm.Parameters.AddWithValue("@price", price.Text);
                    cm.Parameters.AddWithValue("@quantity", quantity.Text);

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

       
      

        public void clear()
        {
            categoryBox.ResetText();
            productName.Clear();
            productDescription.Clear();
            price.Clear();
            quantity.Clear();


        }
    }
}
