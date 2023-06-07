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

namespace From_Hungary_for_hungry
{
    public partial class CustomerForm : Form
    {

        Form1 f1 = new Form1();

        public CustomerForm()
        {
            InitializeComponent();
        }

        //db connection string
        public static string dbconnection = "Data Source=DESKTOP-2EBNC0D\\SQLEXPRESS;Initial Catalog=hthDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(dbconnection);

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show selected restaurants menu on the MenuPanel
            //do it by creating listbox within that panel
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void PopulateRestaurantListView()
        {
            // Clear the ListView
            listView1.Items.Clear();

            // Retrieve the restaurant data from the database
            string query = "SELECT businessName, rating FROM tb_accounts WHERE type='Restaurant'";


            using (SqlCommand command = new SqlCommand(query, con))
            {
                con.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        float rating = (float)Convert.ToDouble(reader["rating"]);
                        string name = reader["businessName"].ToString();

                        // Create a new ListViewItem with the restaurant name and set the Tag property to store the restaurant ID
                        ListViewItem item = new ListViewItem(name);
                        item.Tag = rating;

                        // Add the ListViewItem to the ListView
                        listView1.Items.Add(item);
                    }
                }

            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

            PopulateRestaurantListView();

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                // Retrieve the selected restaurant information from the ListView
                string businessName = e.Item.SubItems[3].Text; // Assuming the restaurant ID is stored in the first column

                // Query the database to fetch the menu items for the selected restaurant
                string query = "SELECT name, price FROM tb_products WHERE businessName = @businessName";

           
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@businessName", businessName);

                        con.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear any existing menu items from the panel
                            MenuPanel.Controls.Clear();

                            // Iterate through the menu items and add them to the panel
                            while (reader.Read())
                            {
                                string menuItemName = reader["name"].ToString();
                                float price = (float)Convert.ToDouble(reader["price"]);

                                // Create a label to display the menu item
                                Label labelMenuItem = new Label();
                                labelMenuItem.Text = $"{menuItemName} - ${price}";
                                labelMenuItem.AutoSize = true;

                                // Add the label to the panel
                                MenuPanel.Controls.Add(labelMenuItem);
                            }
                        }
                    }
                
            }
        }

        //Add button
        private void button1_Click(object sender, EventArgs e)
        {
            //Add selected products from "created listbox" to a listbox that is in CartPanel
        }

        //Remove button
        private void button2_Click(object sender, EventArgs e)
        {
            //Remove from the last listbox
        }

        private void logouttBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged Out!");
            //redirecting to login form
            f1.Show();
            this.Hide();
        }
    }
}
