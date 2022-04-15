using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Management_System.UserContols
{
    public partial class Users_UC : UserControl
    {
        public Users_UC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Helper.ConnectionVal("HotelDb")))
            {
                conn.Open();
                dataGridView1.DataSource = usersTableAdapter.GetDataByUsername(txtUsername.Text);
                usersBindingSource.DataSource = dataGridView1.DataSource;
            }

        }
    }
}
