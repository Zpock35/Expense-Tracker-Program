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

namespace ExpenseTracker
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            ShowUser();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\ExpenseDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowUser()
        {
            Con.Open();
            string Query = "select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UsersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            UnameTb.Text = "";
            UPasswordTb.Text = "";
            UPhoneTb.Text = "";
            AddressTb.Text = "";
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || UPhoneTb.Text == "" || UPasswordTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl (UName,UDOB,UPhone,UPass,UAddress) values(@UN,@UD,@UP,@UPA,@UA)", Con);
                cmd.Parameters.AddWithValue("@UN", UnameTb.Text);
                cmd.Parameters.AddWithValue("@UD", UDOB.Value.Date);
                cmd.Parameters.AddWithValue("@UP", UPhoneTb.Text);
                cmd.Parameters.AddWithValue("@UPA", UPasswordTb.Text);
                cmd.Parameters.AddWithValue("@UA", AddressTb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added");
                Con.Close();
                ShowUser();
                Clear();
            }

        }

    }
}
