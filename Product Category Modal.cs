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
        public Product_Category_Modal() => InitializeComponent();

        private void PCatCloseButton_Click(object sender, EventArgs e)
        {
           
                this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
