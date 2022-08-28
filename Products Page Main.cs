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
    public partial class Products_Page : Form
    {
        public Products_Page() => InitializeComponent();

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
    }
}
