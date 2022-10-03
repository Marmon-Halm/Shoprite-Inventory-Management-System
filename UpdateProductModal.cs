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
    public partial class UpdateProductModal : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\micha\OneDrive\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public UpdateProductModal()
        {
            InitializeComponent();
            Load_Category();
        }

        private void UpdateProductModal_Load(object sender, EventArgs e)
        {

        }

        public void Load_Category()
        {
            updateCategoryBox.Items.Clear();
            cm = new SqlCommand("SELECT CategoryName FROM tbCat", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                updateCategoryBox.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Confirm Product Update?", "Updating Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {

                    cm = new SqlCommand("UPDATE tbProduct SET category=@category,productName=@productName,productDescription=@productDescription,price=@price,quantity=@quantity WHERE productID LIKE '" + productIDbox1.Text + "'", con);
                }
                {
                    cm.Parameters.AddWithValue("@category", updateCategoryBox.Text);
                    cm.Parameters.AddWithValue("@productName", updatePNamebox.Text);
                    cm.Parameters.AddWithValue("@productDescription", updatePDbox.Text);
                    cm.Parameters.AddWithValue("@price", updatePricebox.Text);
                    cm.Parameters.AddWithValue("@quantity", updateQuantitybox.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product Updated successfully");
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
            updateCategoryBox.ResetText();
            updatePNamebox.Clear();
            updatePDbox.Clear();
            updatePricebox.Clear();
            updateQuantitybox.Clear();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PManageCloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void updateCategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
