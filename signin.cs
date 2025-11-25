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
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();

            // Set placeholders for username and password textboxes
            SetPlaceholder(txt_username, "Enter username");
            SetPlaceholder(txt_password, "Enter password");

            // Add event handlers for focus events
            txt_username.GotFocus += (s, e) => RemovePlaceholder(txt_username, "Enter username");
            txt_username.LostFocus += (s, e) => SetPlaceholder(txt_username, "Enter username");

            txt_password.GotFocus += (s, e) => RemovePlaceholder(txt_password, "Enter password");
            txt_password.LostFocus += (s, e) => SetPlaceholder(txt_password, "Enter password");


        }

        private void SetPlaceholder(TextBox textBox, string placeholderText)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = Color.Gray; // Set placeholder color
            }
        }

        private void RemovePlaceholder(TextBox textBox, string placeholderText)
        {
            if (textBox.Text == placeholderText)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black; // Set normal text color
            }
        }

    


        private void SignIn()
        {
            try
            {
                
                SqlConnection connection = DbConnection.GetConnection();
                connection.Open();

               
                string username = txt_username.Text.Trim();
                string password = txt_password.Text.Trim();

                
                string query = "SELECT user_type FROM [user] WHERE username = @username AND password = @password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                   
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                       
                        string userType = result.ToString();

                       
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       
                        NavigateToDashboard(userType);
                    }
                    else
                    {
                        
                        MessageBox.Show("Login failed! Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NavigateToDashboard(string userType)
        {
            if (userType == "stores_executive")
            {
                stores_exe_dashboard storesExeDashboard = new stores_exe_dashboard();
                storesExeDashboard.Show();
                this.Hide();
            }
            else if (userType == "production_manager")
            {
                manager_dashboard managerDashboard = new manager_dashboard();
                managerDashboard.Show();
                this.Hide();
            }
            else if (userType == "admin")
            {
                admin_dashboard adminDashboard = new admin_dashboard();
                adminDashboard.Show();
                this.Hide();
            }
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SignIn();

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void signin_Load(object sender, EventArgs e)
        {


        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
