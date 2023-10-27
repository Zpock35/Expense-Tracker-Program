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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            GetMaxExp();
            GetMinExp();
            GetTotExp();
            GetAvgExp();
            GetBestCat();
            GetMinCat();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\ExpenseDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void GetMaxExp()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Max(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Maxlbl.Text = "Php" + dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void GetMinExp()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Min(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Minlbl.Text ="Php" + dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void GetTotExp()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Totlbl.Text = "Php" + dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void GetBestCat()
        {
            Con.Open() ;
            string InnerQuery = "select Max(ExpAmt) from ExpenseTbl";
            DataTable dt1=new DataTable(); 
            SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
            sda1.Fill(dt1);
            string Query = "select ExpCat from ExpenseTbl where ExpAmt = '" + dt1.Rows[0][0].ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            DataTable dt= new DataTable();
            sda1.Fill(dt);
            HighCatlbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void GetMinCat()
        {
            Con.Open();
            string InnerQuery = "select Min(ExpAmt) from ExpenseTbl";
            DataTable dt1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
            sda1.Fill(dt1);
            string Query = "select ExpCat from ExpenseTbl where ExpAmt = '" + dt1.Rows[0][0].ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            LowCatlbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void GetTotExpByCat()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "' and ExpCat='" + Catcb.SelectedItem.ToString() + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TotByCatlbl.Text = "Php" + dt.Rows[0][0].ToString();
            TotByCatlbl.Visible = true;
            Con.Close();
        }
        private void GetAvgExp()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
            SqlDataAdapter sda1= new SqlDataAdapter("select Count(*) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);

            DataTable dt = new DataTable();
            DataTable dt1= new DataTable();
            sda.Fill(dt);
            sda1.Fill(dt1);
            Double Avg = Convert.ToDouble(dt.Rows[0][0].ToString()) / Convert.ToDouble(dt1.Rows[0][0].ToString());
            Avglbl.Text = "Rs" + Avg;
            Countlbl.Text = dt1.Rows[0][0].ToString() + " - number of Expenses";
            Con.Close();
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Catcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTotExpByCat();
        }
    }
}
