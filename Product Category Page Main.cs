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
    public partial class Product_Category_Page_Main : Form
    {
        public Product_Category_Page_Main() => InitializeComponent();

      

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
            pcm.Show(); 
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
    }
}
