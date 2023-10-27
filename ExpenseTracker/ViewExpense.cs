using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class ViewExpense : Form
    {
        public ViewExpense()
        {
            InitializeComponent();
            ShowExp();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\ExpenseDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void ShowExp()
        {
            Con.Open();
            string Query = "select * from ExpenseTbl where ExpUser='" + Login.User + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ExpenseDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FilterByCat()
        {
            Con.Open();
            string Query = "select * from ExpenseTbl where ExpUser='" + Login.User + "' and ExpCat='"+ExpCatCb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ExpenseDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowExp();
        }

        private void ExpCatCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCat();
        }
    }
}
