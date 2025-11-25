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
    public partial class stores_exe_dashboard : Form
    {
        public stores_exe_dashboard()
        {
            InitializeComponent();

           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            view_items viewItemForm = new view_items();
            viewItemForm.Show();

            this.Hide();
        }

        private void btn_viewrequests_Click(object sender, EventArgs e)
        {

        }

        private void btn_additem_Click(object sender, EventArgs e)
        {
            // Open the add_item_form
            add_item_form addItemForm = new add_item_form();
            addItemForm.Show();

            // Optionally hide the current dashboard form
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            signin dashboard = new signin();

            dashboard.Show();

            this.Close();
        }
    }
}
