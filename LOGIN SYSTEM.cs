using Shoprite_Inventory_Management.ATTENDANT;
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
    public partial class LOGIN_SYSTEM : Form
    {
        public LOGIN_SYSTEM() => InitializeComponent();//OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Inventory Database.mdf")

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_SYSTEM_Load(object sender, EventArgs e)
        {

        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked == false)
               loginPassword.UseSystemPasswordChar = true;
            else 
                loginPassword.UseSystemPasswordChar = false;
        }

        private void loginPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginUsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the application","Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            REGISTER_SYSTEM ls = new REGISTER_SYSTEM();
            Sales_Main sm = new Sales_Main();

            if (radioAdmin.Checked == false)
            {   
                 this.Hide();
                 sm.Show();
            }
               
            else
            {
                this.Hide();
                ls.Show();
            }
               
        }

        private void radioAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
