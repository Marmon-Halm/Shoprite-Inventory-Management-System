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
using System.Linq.Expressions;

namespace Shoprite_Inventory_Management
{
    public partial class User_Management_Modal : Form

    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\micha\OneDrive\Documents\Inventory Database.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public User_Management_Modal() => InitializeComponent();

        private void label5_Click(object sender, EventArgs e)
        {

        } 

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void userManagementCloseButton_Click(object sender, EventArgs e)
        {
            
                this.Hide();
        }

        private void User_Management_Modal_List(object sender, EventArgs e)
        {
             
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

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Hide();
        }

        /*private void userAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirm to create user", "Create User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {  
                    con.Open();
                   
                    cm = new SqlCommand("INSERT INTO userTable(User_ID,Full_Name,Place_Of_Residence,Contact,Password)VALUES(@User_ID,@Full_Name,@Place_Of_Residence,@Contact,@Password)", con);
                    cm.Parameters.AddWithValue("@User_ID", textBoxUsername.Text);
                    cm.Parameters.AddWithValue("@Full_Name", textBoxFullName.Text);
                    cm.Parameters.AddWithValue("@Place_Of_Residence", textBoxPOR.Text);
                    cm.Parameters.AddWithValue("@Contact", textBoxContact.Text);
                    cm.Parameters.AddWithValue("@Password", textBoxPassword.Text);

                    cm.ExecuteNonQuery();   
                    con.Close();
                    MessageBox.Show("User created successfully!");
                  
                  
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        private void textBoxFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPOR_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirm to create user", "Create User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    con.Open();

                    cm = new SqlCommand("INSERT INTO dbUser_Table(Username,Full_Name,Place_Of_Residence,Contact,Password)VALUES(@Username,@Full_Name,@Place_Of_Residence,@Contact,@Password)", con);
                    cm.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                    cm.Parameters.AddWithValue("@Full_Name", textBoxFullName.Text);
                    cm.Parameters.AddWithValue("@Place_Of_Residence", textBoxPOR.Text);
                    cm.Parameters.AddWithValue("@Contact", textBoxContact.Text);
                    cm.Parameters.AddWithValue("@Password", textBoxPassword.Text);

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
    }
}
