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
    public partial class UserModal : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\micha\OneDrive\Documents\Inventory Database.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public UserModal()

        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirm to create user", "Create User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    cm = new SqlCommand("INSERT INTO tbUser_Table(Username,fullName,placeOfResidence,Contact,Password)VALUES(@Username,@fullName,@placeOf_Residence,@Contact,@Password)", con);
                    cm.Parameters.AddWithValue("@Username", usernameBox.Text);
                    cm.Parameters.AddWithValue("@fullName", FullNameBox.Text);
                    cm.Parameters.AddWithValue("@placeOfResidence", PORBox.Text);
                    cm.Parameters.AddWithValue("@Contact", ContactBox.Text);
                    cm.Parameters.AddWithValue("@Password", textBox1.Text);

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                  
                    MessageBox.Show("User created successfully!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FullNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PORBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContactBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userManagementCloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UserModal_Load(object sender, EventArgs e)
        {

        }
    }
}
