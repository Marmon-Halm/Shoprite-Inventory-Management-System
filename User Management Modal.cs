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
    public partial class User_Management_Modal : Form
    {
        public User_Management_Modal()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void userManagementCloseButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Terminate Window", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void User_Management_Modal_List(object sender, EventArgs e)
        {
               //List<Gender> list = new List<Gender>();
               //list.Add(new Gender() { ID = 1, Name = "Male"});
               //list.Add(new Gender() { ID = 2, Name = "Female"});
        }

        private void userGender_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
