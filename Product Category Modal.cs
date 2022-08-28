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
    public partial class Product_Category_Modal : Form
    {
        public Product_Category_Modal()
        {
            InitializeComponent();
        }

        private void PCatCloseButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Terminate Window", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
