using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            UnameLbl.Text = Login.User;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
            Obj.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report Obj = new Report();
            Obj.Show();
        }
    }
}
