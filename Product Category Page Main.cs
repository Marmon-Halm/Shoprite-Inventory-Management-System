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
    public partial class Product_Category_Page_Main : Form
    {
        SqlDataReader dr;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\micha\OneDrive\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public Product_Category_Page_Main()

        {
            InitializeComponent();
            loadCategory();
        }
      

        private void pcClose_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Close Window", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                           this.Hide(); 
                        }
        }

        private void cCategoryButton_Click(object sender, EventArgs e)
        {
            Product_Category_Modal pcm = new Product_Category_Modal();
            pcm.ShowDialog();
            loadCategory();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hProductButton_Click(object sender, EventArgs e)
        {
            REGISTER_SYSTEM rs = new REGISTER_SYSTEM();
            rs.Show();
            this.Hide();

        }

        private void hpUserManagement_Click(object sender, EventArgs e)
        {
            User_Management um = new User_Management();
            um.Show();
            this.Hide();
        }

        private void hpReports_Click(object sender, EventArgs e)
        {
            Reports rp = new Reports();
            rp.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LOGIN_SYSTEM ls = new LOGIN_SYSTEM();
            ls.Show();
            this.Hide();
        }

        public void loadCategory()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbCategory_Table", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[1].ToString(), dr[0].ToString());

            }
            dr.Close();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (columnName == "Edit")
            {
                Product_Category_Modal pm = new Product_Category_Modal();
                pm.catID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                pm.categoryNameBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                pm.button3.Enabled = false;
                pm.updateBtn.Enabled = true;
                pm.ShowDialog();

            }
            else if (columnName == "Delete")
            {
                if (MessageBox.Show("Confirm to delete product category", "Delete Product Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    con.Open();
                    cm = new SqlCommand("Delete from tbCategory_Table where productCategoryName like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product Category successfully deleted");
                }
            }

            loadCategory();
        }
    }
}
