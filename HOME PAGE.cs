﻿using System;
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
    public partial class REGISTER_SYSTEM : Form
        
        {

        SqlDataReader dr;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\micha\OneDrive\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public REGISTER_SYSTEM()

        {
            InitializeComponent();

            if(searchBoxP.Text == "")
            {
                loadProduct();
            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void REGISTER_SYSTEM_Load(object sender, EventArgs e)
        {

        }

        private void hProductButton_Click(object sender, EventArgs e)
        {

        }

        private void hProductButton_Click_1(object sender, EventArgs e)
        {
           REGISTER_SYSTEM hp = new REGISTER_SYSTEM();
            hp.Show();
        }

        private void hpProductCatButton_Click(object sender, EventArgs e)
        {
            Product_Category_Page_Main pcpm = new Product_Category_Page_Main();
            pcpm.Show();
        }

        private void hpUserManagement_Click(object sender, EventArgs e)
        {
            User_Management um = new User_Management();
            um.Show();
        }

        private void hpReports_Click(object sender, EventArgs e)
        {
            Reports rp = new Reports();
            rp.Show();
        }

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LOGIN_SYSTEM lg = new LOGIN_SYSTEM();
            this.Hide();
            lg.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product_Modal pm = new Product_Modal();
            pm.ShowDialog();
            loadProduct();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


      

        public void loadProduct()
        {
            int i = 0;
            ppDataView.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct ", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                ppDataView.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void loadProductWithSearch()
        {
            int i = 0;
            ppDataView.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(category, productName, productDescription, price) LIKE '%"+searchBoxP.Text+"%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                ppDataView.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void ppDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = ppDataView.Columns[e.ColumnIndex].Name;
            if(columnName == "Edit")
            {
                UpdateProductModal pm = new UpdateProductModal();
                pm.productIDbox1.Text = ppDataView.Rows[e.RowIndex].Cells[1].Value.ToString();
                pm.updateCategoryBox.Text = ppDataView.Rows[e.RowIndex].Cells[2].Value.ToString();
                pm.updatePNamebox.Text = ppDataView.Rows[e.RowIndex].Cells[3].Value.ToString();
                pm.updatePDbox.Text = ppDataView.Rows[e.RowIndex].Cells[4].Value.ToString();
                pm.updatePricebox.Text = ppDataView.Rows[e.RowIndex].Cells[5].Value.ToString();
                pm.updateQuantitybox.Text = ppDataView.Rows[e.RowIndex].Cells[6].Value.ToString();


                pm.ShowDialog();
             
            }
            else if(columnName == "Delete")
            {
                if (MessageBox.Show("Confirm to delete product", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
                {
                    con.Open();
                    cm = new SqlCommand("Delete from tbProduct where productID like '" + ppDataView.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product successfully deleted");
                }
            }

            loadProduct();
        }

        private void searchBoxP_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void searchBox1_Click(object sender, EventArgs e)
        {
             loadProductWithSearch();
            if (searchBoxP.Text == "")
            {
                loadProduct();
            }

        }
    }
}
