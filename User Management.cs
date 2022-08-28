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
    public partial class User_Management : Form

    {

        public User_Management() => InitializeComponent();

        private void User_Management_Load(object sender, EventArgs e)
        {

        }

      
        private void umClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close Window", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void hProductButton_Click(object sender, EventArgs e)
        {
            REGISTER_SYSTEM rg = new REGISTER_SYSTEM();
            rg.Show();  
            this.Hide();
        }

        private void hpProductCatButton_Click(object sender, EventArgs e)
        {
            Product_Category_Page_Main pcpm = new Product_Category_Page_Main();
            pcpm.Show();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uUserButton_Click_1(object sender, EventArgs e)
        {

            UserModal usmm = new UserModal();
            usmm.Show();

        }
    }
}
