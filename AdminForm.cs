using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace From_Hungary_for_hungry
{
    public partial class AdminForm : Form
    {

        Form1 f1 = new Form1();
        public AdminForm()
        {
            InitializeComponent();
            mainPnl.Visible = true;
            allAccountsPnl.Visible = false;
            allRestaurantsPnl.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewRestaurantsBtn_Click(object sender, EventArgs e)
        {


        }

        private void allAccountsBtn_Click(object sender, EventArgs e)
        {
            mainPnl.Visible = false;
            allAccountsPnl.Visible = true;
            allRestaurantsPnl.Visible = false;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
        }

        private void allRestaurantsBtn_Click(object sender, EventArgs e)
        {
            mainPnl.Visible = false;
            allAccountsPnl.Visible = false;
            allRestaurantsPnl.Visible = true;
        }
    }
}
