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
    public partial class UpdateCategoryModal : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\micha\OneDrive\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public UpdateCategoryModal()
        {
            InitializeComponent();
        }

        private void updateCategoryNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirm product category update?", "Updating Product Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)


                {
                    cm = new SqlCommand("UPDATE tbCat SET CategoryName=@CategoryName WHERE categoryID LIKE '" + categoryIDBox.Text + "'", con);
                    cm.Parameters.AddWithValue("@CategoryName", updateCategoryNameBox.Text);
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
            updateCategoryNameBox.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void categoryIDBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
