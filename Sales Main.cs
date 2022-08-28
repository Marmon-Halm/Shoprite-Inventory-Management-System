using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoprite_Inventory_Management.ATTENDANT
{
    public partial class Sales_Main : Form
    {
        public Sales_Main() => InitializeComponent();

        private void Sales_Main_Load(object sender, EventArgs e)
        {

        }

        private void salesCartPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salesLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LOGIN_SYSTEM lg = new LOGIN_SYSTEM();
            this.Hide();
            lg.Show();  
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
