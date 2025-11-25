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
    public partial class view_items : Form
    {
        public view_items()
        {
            InitializeComponent();
        }




        private void LoadItems()
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetConnection())
                {
                    
                    string query = "SELECT item_id, item_name, item_price, item_quantity, min_level FROM items";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                   
                    adapter.Fill(dataTable);

                    
                    dgv_items.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchItem(string itemName)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetConnection())
                {
                    string query = "SELECT item_id, item_name, item_price, item_quantity, min_level FROM items WHERE item_name = @itemName";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@itemName", itemName);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        dgv_items.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No items found with the provided name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgv_items.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateItems()
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetConnection())
                {
                    connection.Open();

                    foreach (DataGridViewRow row in dgv_items.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int itemId = Convert.ToInt32(row.Cells["item_id"].Value);
                        string itemName = row.Cells["item_name"].Value.ToString();
                        float itemPrice = Convert.ToSingle(row.Cells["item_price"].Value);
                        int itemQuantity = Convert.ToInt32(row.Cells["item_quantity"].Value);
                        int minLevel = Convert.ToInt32(row.Cells["min_level"].Value);

                        string query = "UPDATE items SET item_name = @itemName, item_price = @itemPrice, " +
                                       "item_quantity = @itemQuantity, min_level = @minLevel WHERE item_id = @itemId";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@itemId", itemId);
                            command.Parameters.AddWithValue("@itemName", itemName);
                            command.Parameters.AddWithValue("@itemPrice", itemPrice);
                            command.Parameters.AddWithValue("@itemQuantity", itemQuantity);
                            command.Parameters.AddWithValue("@minLevel", minLevel);

                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Items updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteItem(int itemId)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetConnection())
                {
                    string query = "DELETE FROM items WHERE item_id = @itemId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@itemId", itemId);

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadItems();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchName = txt_search.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchName))
            {
                MessageBox.Show("Please enter an item name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SearchItem(searchName);
        }

        private void dgv_items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgv_items.DataSource == null || dgv_items.Rows.Count == 0)
            {
                MessageBox.Show("No data to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UpdateItems();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            stores_exe_dashboard dashboard = new stores_exe_dashboard();
            
            dashboard.Show();

            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_items.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int itemId = Convert.ToInt32(dgv_items.SelectedRows[0].Cells["item_id"].Value);

            DialogResult confirmResult = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                DeleteItem(itemId);
            }
        }

        private void view_items_Load(object sender, EventArgs e)
        {

        }

        private void dgv_items_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
