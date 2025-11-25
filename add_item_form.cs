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

namespace IMS
{
    public partial class add_item_form : Form
    {
        public add_item_form()
        {
            InitializeComponent();
        }

        private void AddItem()
        {
            // Validate textboxes
            if (string.IsNullOrWhiteSpace(txt_itemname.Text) ||
                string.IsNullOrWhiteSpace(txt_price.Text) ||
                string.IsNullOrWhiteSpace(txt_quantity.Text) ||
                string.IsNullOrWhiteSpace(txt_minimumlevel.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse input values
            string itemName = txt_itemname.Text.Trim();
            float itemPrice;
            int itemQuantity, minLevel;

            // Validate numeric input
            if (!float.TryParse(txt_price.Text.Trim(), out itemPrice) ||
                !int.TryParse(txt_quantity.Text.Trim(), out itemQuantity) ||
                !int.TryParse(txt_minimumlevel.Text.Trim(), out minLevel))
            {
                MessageBox.Show("Please enter valid numeric values for Price, Quantity, and Minimum Level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SqlConnection connection = DbConnection.GetConnection();

                // Insert query
                string query = "INSERT INTO items (item_name, item_price, item_quantity, min_level) " +
                               "VALUES (@itemName, @itemPrice, @itemQuantity, @minLevel)";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@itemName", itemName);
                    command.Parameters.AddWithValue("@itemPrice", itemPrice);
                    command.Parameters.AddWithValue("@itemQuantity", itemQuantity);
                    command.Parameters.AddWithValue("@minLevel", minLevel);

                    // Execute the command
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Success message
                        MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Navigate back to stores_exe_dashboard
                        stores_exe_dashboard dashboard = new stores_exe_dashboard();
                        dashboard.Show();
                        this.Close();
                    }
                    else
                    {
                        // Failure message
                        MessageBox.Show("Failed to add the item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            stores_exe_dashboard dashboard = new stores_exe_dashboard();

            dashboard.Show();

            this.Close();
        }

        private void add_item_form_Load(object sender, EventArgs e)
        {

        }
    }
}
