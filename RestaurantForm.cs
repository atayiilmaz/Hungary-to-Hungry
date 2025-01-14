﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace From_Hungary_for_hungry
{
    public partial class RestaurantForm : Form
    {

        //defining login form
        Form1 f1 = new Form1();

        public RestaurantForm()
        {
            InitializeComponent();
            viewOrdersPnl.Visible = false;
            psettingsPnl.Visible = false;
            welcomePnl.Visible = true;
            viewMenuPnl.Visible = false;
        }

        //db connection string
        public static string dbconnection = "Data Source=DESKTOP-2EBNC0D\\SQLEXPRESS;Initial Catalog=hthDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(dbconnection);

        private void RestaurantForm_Load(object sender, EventArgs e)
        {
            //for reading orders
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM tb_orders", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            orderDgv.DataSource = dt;

            //for reading all products of restaurants
            SqlDataAdapter sda1 = new SqlDataAdapter(@"SELECT * FROM tb_products", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            menuDgv.DataSource = dt1;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged Out!");
            //redirecting to login form
            f1.Show();
            this.Hide();
        }

        private void viewOrdersBtn_Click(object sender, EventArgs e)
        {
            viewOrdersPnl.Visible = true;
            psettingsPnl.Visible = false;
            welcomePnl.Visible = false;
            viewMenuPnl.Visible = false;

        }

        private void viewMenuBtn_Click(object sender, EventArgs e)
        {
            viewOrdersPnl.Visible = false;
            psettingsPnl.Visible = false;
            welcomePnl.Visible = false;
            viewMenuPnl.Visible = true;
            businessNameTxt.Visible = false;
        }

        private void psettingsBtn_Click(object sender, EventArgs e)
        {
            viewOrdersPnl.Visible = false;
            psettingsPnl.Visible = true;
            welcomePnl.Visible = false;
            viewMenuPnl.Visible = false;

        }

        void updateUser(string mail, string username, string location, string address, string businessName)
        {

            string q = "UPDATE tb_accounts SET username = @username, email=@email, businessName=@businessName, location=@location, address=@address WHERE email = @email";

            using (SqlCommand command = new SqlCommand(q, con))
            {

                command.Parameters.AddWithValue("@email", mail);

                if (!string.IsNullOrEmpty(username))
                    command.Parameters.AddWithValue("@username", username);

                if (!string.IsNullOrEmpty(location))
                    command.Parameters.AddWithValue("@location", location);

                if (!string.IsNullOrEmpty(businessName))
                    command.Parameters.AddWithValue("@businessName", businessName);

                if (!string.IsNullOrEmpty(address))
                    command.Parameters.AddWithValue("@address", address);


                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
        }

        void editProduct(float price, string name, string category, int id)
        {
            string q = "UPDATE tb_products SET name=@name, price=@price, category=@category WHERE id=@id";

            using (SqlCommand command = new SqlCommand(q, con))
            {

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@price", price);

                if (!string.IsNullOrEmpty(name))
                    command.Parameters.AddWithValue("@name", name);

                if (!string.IsNullOrEmpty(category))
                    command.Parameters.AddWithValue("@category", category);


                con.Open();
                command.ExecuteNonQuery();

            }

        }

        void addProduct(float price, string name, string category, string businessName)
        {
            string q = "INSERT INTO tb_products (price, name, category, businessName) VALUES (@price, @name, @category, @businessName)";

            using (SqlCommand command = new SqlCommand(q, con))
            {

                command.Parameters.AddWithValue("@price", price);

                if (!string.IsNullOrEmpty(name))
                    command.Parameters.AddWithValue("@name", name);

                if (!string.IsNullOrEmpty(category))
                    command.Parameters.AddWithValue("@category", category);

                if (!string.IsNullOrEmpty(businessName))
                    command.Parameters.AddWithValue("@businessName", businessName);

                con.Open();
                command.ExecuteNonQuery();

            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            string mail = mailTxtB.Text;
            string username = usernameTxtB.Text;
            string businessName = busNameTxtB.Text;
            string location = locationTxtB.Text;
            string address = addressTxtB.Text;

            // Only update the user if the email is not empty
            if (!string.IsNullOrEmpty(mail))
            {
                updateUser(mail, username, businessName, location, address);
                MessageBox.Show("User data saved successfully!");
            }
            else
            {
                MessageBox.Show("Email is required!");
            }

        }

        private void setActiveBtn_Click(object sender, EventArgs e)
        {
            if (orderDgv.SelectedRows.Count > 0)
            {
                //validation for if the order status is in Progress
                if ((string)orderDgv.SelectedRows[0].Cells["orderStatus"].Value == "Active")
                {
                    MessageBox.Show("The order has already active!");
                }
                else
                {
                    //Getting the id value when the row is clicked from DataGridView
                    int orderId = Convert.ToInt32(orderDgv.SelectedRows[0].Cells["id"].Value);

                    con.Open();

                    string sqlQuery = "UPDATE tb_orders SET orderStatus = 'Active' WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(sqlQuery, con))
                    {
                        command.Parameters.AddWithValue("@id", orderId);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Status has changed!");

                    //Refreshing the table
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM tb_orders", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    orderDgv.DataSource = dt;

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select one of them!");
            }
        }

        private void cancelledBtn_Click(object sender, EventArgs e)
        {
            if (orderDgv.SelectedRows.Count > 0)
            {
                //validation for if the order status is cancelled
                if ((string)orderDgv.SelectedRows[0].Cells["orderStatus"].Value == "Cancelled")
                {
                    MessageBox.Show("The order has already cancelled!");
                }
                else
                {
                    //Getting the id value when the row is clicked from DataGridView
                    int orderId = Convert.ToInt32(orderDgv.SelectedRows[0].Cells["id"].Value);

                    con.Open();

                    string sqlQuery = "UPDATE tb_orders SET orderStatus = 'Cancelled' WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(sqlQuery, con))
                    {
                        command.Parameters.AddWithValue("@id", orderId);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Status has changed!");

                    //Refreshing the table
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM tb_orders", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    orderDgv.DataSource = dt;

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select one of them!");
            }

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if (orderDgv.SelectedRows.Count > 0)
            {
                //validation for if the order status is done
                if ((string)orderDgv.SelectedRows[0].Cells["orderStatus"].Value == "Done")
                {
                    MessageBox.Show("The order has already done!");
                }
                else
                {
                    //Getting the id value when the row is clicked from DataGridView
                    int orderId = Convert.ToInt32(orderDgv.SelectedRows[0].Cells["id"].Value);

                    con.Open();

                    string sqlQuery = "UPDATE tb_orders SET orderStatus = 'Done' WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(sqlQuery, con))
                    {
                        command.Parameters.AddWithValue("@id", orderId);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Status has changed!");

                    //Refreshing the table
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM tb_orders", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    orderDgv.DataSource = dt;

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select one of them!");
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (orderDgv.SelectedRows.Count > 0)
            {
                //validation
                if (MessageBox.Show("Are you sure you want to delete this order?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Getting the id value when the row is clicked from DataGridView
                    int orderId = Convert.ToInt32(orderDgv.SelectedRows[0].Cells["id"].Value);

                    con.Open();

                    string sqlQuery = "DELETE FROM tb_orders WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(sqlQuery, con))
                    {
                        command.Parameters.AddWithValue("@id", orderId);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Order has been deleted!");

                    //Refreshing the table
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM tb_orders", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    orderDgv.DataSource = dt;

                    con.Close();
                }

            }
            else
            {
                MessageBox.Show("Please select one of them!");
            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string productName = pnameTxt.Text;
            float price = (float)Convert.ToDouble(priceTxt.Text);
            string businessName = businessNameTxt.Text;
            string category = categoryCb.Text;

            // Only insert the user if the email is not empty
            if (!string.IsNullOrEmpty(businessName))
            {
                addProduct(price, productName, category, businessName);
                MessageBox.Show("User data inserted successfully!");

                //for refreshing table
                SqlDataAdapter sda1 = new SqlDataAdapter(@"SELECT * FROM tb_products", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                menuDgv.DataSource = dt1;
                con.Close();
            }
            else
            {
                MessageBox.Show("The fields are empty");
            }
        }

        private void menuDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row index is selected
            {
                DataGridViewRow row = menuDgv.Rows[e.RowIndex];

                // Assuming the data is stored in specific columns of the DataGridView
                string productName = row.Cells["name"].Value.ToString();
                string price = row.Cells["price"].Value.ToString();
                string category = row.Cells["category"].Value.ToString();
                string businessName = row.Cells["businessName"].Value.ToString();

                // Populate the textboxes with the clicked row's data
                pnameTxt.Text = productName;
                priceTxt.Text = price;
                categoryCb.Text = category;
                businessNameTxt.Text = businessName;
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string productName = pnameTxt.Text;
            float price = (float)Convert.ToDouble(priceTxt.Text);
            string category = categoryCb.Text;
            int id = Convert.ToInt32(menuDgv.SelectedRows[0].Cells["id"].Value);
            //int id = menuDgv.

            // Only update the user if the email is not empty

            editProduct(price, productName, category, id);
                MessageBox.Show("Product saved successfully!");

                //for refreshing table
                SqlDataAdapter sda1 = new SqlDataAdapter(@"SELECT * FROM tb_products", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                menuDgv.DataSource = dt1;
                con.Close();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (menuDgv.SelectedRows.Count > 0)
            {
                //validation for if the membership status is false
                if (MessageBox.Show("Are you sure you want to delete this product?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Getting the id value when the row is clicked from DataGridView
                    int productId = Convert.ToInt32(menuDgv.SelectedRows[0].Cells["id"].Value);

                    con.Open();

                    string sqlQuery = "DELETE FROM tb_products WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(sqlQuery, con))
                    {
                        command.Parameters.AddWithValue("@id", productId);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Product has been deleted!");

                    //Refreshing the table
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM tb_products", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    menuDgv.DataSource = dt;

                    con.Close();
                }

            }
            else
            {
                MessageBox.Show("Please select one of them!");
            }

        }
    }
}

