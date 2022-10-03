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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shoprite_Inventory_Management
{
    public partial class UpdateUserModal : Form
    {
        SqlDataReader dr;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\micha\OneDrive\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public UpdateUserModal()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Confirm User Update?", "Updating User Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {

                    cm = new SqlCommand("Update tbUser SET fullName=@fullName,placeOfResidence=@placeOfResidence,contact=@contact,password=@password WHERE userID like '" + userIDbox.Text + "'", con);


                    cm.Parameters.AddWithValue("@username", usernameBoxU.Text);
                    cm.Parameters.AddWithValue("@fullName", FullNameBoxU.Text);
                    cm.Parameters.AddWithValue("@placeOfResidence", PORBoxU.Text);
                    cm.Parameters.AddWithValue("@contact", ContactBoxU.Text);
                    cm.Parameters.AddWithValue("@password", textBox1U.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User Updated Successfully");
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void usernameBoxU_TextChanged(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            usernameBoxU.ResetText();
            FullNameBoxU.Clear();
            PORBoxU.Clear();
            ContactBoxU.Clear();
            textBox1U.Clear();
            userIDbox.Clear();


        }

        private void FullNameBoxU_TextChanged(object sender, EventArgs e)
        {

        }

        private void PORBoxU_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContactBoxU_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1U_TextChanged(object sender, EventArgs e)
        {

        }

        private void userManagementCloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void userIDbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
