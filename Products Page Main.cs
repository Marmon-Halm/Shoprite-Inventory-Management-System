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
    public partial class Products_Page : Form
    {
        SqlDataReader dr;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\micha\OneDrive\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();

        public Products_Page()
        {
            InitializeComponent();
            loadProduct();
        }

        private void ppHeader_Click(object sender, EventArgs e)
        {

        }


        private void ppClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close Window", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void ppProductButton_Click(object sender, EventArgs e)
        {
            Product_Modal pm = new Product_Modal();
            pm.Show();
        }

        public void loadProduct()
        {
            int i = 0;
            ppDataView.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct_Table", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                ppDataView.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString());

            }
            dr.Close();
            con.Close();
        }

        private void ppDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
