using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoprite_Inventory_Management
{
    public partial class Reports : Form
    {
        public Reports() => InitializeComponent();

        private void reportsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void hpUserManagement_Click(object sender, EventArgs e)
        {
            User_Management us = new User_Management();
            us.Show();
            this.Hide();
        }

        private void hpProductCatButton_Click(object sender, EventArgs e)
        {
            Product_Category_Page_Main pcpm = new Product_Category_Page_Main();
            pcpm.Show();
            this.Hide();
        }

        private void hProductButton_Click(object sender, EventArgs e)
        {
            REGISTER_SYSTEM ms = new REGISTER_SYSTEM();
            ms.Show();
            this.Hide();
        }
    }
}
