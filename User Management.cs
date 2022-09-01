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
    public partial class User_Management : Form

    {
        SqlDataReader dr;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\micha\OneDrive\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public User_Management()
        {

            InitializeComponent();
            loadUser();
        }
        private void User_Management_Load(object sender, EventArgs e)
        {

        }

      
        private void umClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close Window", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void hProductButton_Click(object sender, EventArgs e)
        {
            REGISTER_SYSTEM rg = new REGISTER_SYSTEM();
            rg.ShowDialog();  
            this.Dispose();
        }

        private void hpProductCatButton_Click(object sender, EventArgs e)
        {
            Product_Category_Page_Main pcpm = new Product_Category_Page_Main();
            pcpm.ShowDialog();
            this.Dispose();
        }

        private void hpReports_Click(object sender, EventArgs e)
        {
            Reports rp = new Reports();
            rp.ShowDialog();
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LOGIN_SYSTEM ls = new LOGIN_SYSTEM();
            ls.ShowDialog();
            this.Dispose();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uUserButton_Click_1(object sender, EventArgs e)
        {

            UserModal usmm = new UserModal();
            usmm.ShowDialog();
            loadUser();

        }

        public void loadUser()
        {
            int i = 0;
            uDataView.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbUser", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                uDataView.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());

            }
            dr.Close();
            con.Close();
        }

        private void uDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string columnName = uDataView.Columns[e.ColumnIndex].Name;
            if (columnName == "Edit")
            {
                UserModal pm = new UserModal();
                pm.usernameBox.Text = uDataView.Rows[e.RowIndex].Cells[1].Value.ToString();
                pm.FullNameBox.Text = uDataView.Rows[e.RowIndex].Cells[2].Value.ToString();
                pm.PORBox.Text = uDataView.Rows[e.RowIndex].Cells[3].Value.ToString();
                pm.ContactBox.Text = uDataView.Rows[e.RowIndex].Cells[4].Value.ToString();
                pm.textBox1.Text = uDataView.Rows[e.RowIndex].Cells[5].Value.ToString();

                pm.button1.Enabled = false;
                pm.UpdateBtn.Enabled = true;
                pm.Show();
               

            }
            else if (columnName == "Delete")
            {
                if (MessageBox.Show("Confirm to delete user", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("Delete from tbUser where username like '" + uDataView.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User Successfully Deleted");
                }
            }

            loadUser();
        }
    }
}
