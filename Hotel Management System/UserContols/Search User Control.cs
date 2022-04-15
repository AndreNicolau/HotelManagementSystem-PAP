using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Management_System.UserContols
{
    public partial class Search_User_Control : UserControl
    {
        public Search_User_Control()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Helper.ConnectionVal("HotelDb")))
            {
                conn.Open();
                dataGridView1.DataSource = clientsTableAdapter.GetDataByLastName(txtLastName.Text);
            }

            if (dataGridView1.Rows != null && dataGridView1.Rows.Count != 0)
            {
                btnCheckOut.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnCheckOut.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }
    }
}
