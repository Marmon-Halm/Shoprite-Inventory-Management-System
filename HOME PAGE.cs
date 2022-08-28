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
    public partial class REGISTER_SYSTEM : Form
    {
        public REGISTER_SYSTEM() => InitializeComponent();

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
            pm.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
