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
                clientsBindingSource.DataSource = dataGridView1.DataSource;
            }

            if (dataGridView1.Rows != null && dataGridView1.Rows.Count != 0)
            {
                CheckEditable(true);
            }
            else
            {
                CheckEditable(false);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clientsTableAdapter.UpdateByLastName(txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text, txtEmail.Text);
            dataGridView1.DataSource = clientsTableAdapter.GetDataByLastName(txtLastName.Text);
            ClearTextBoxes();
            CheckEditable(false);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            clientsTableAdapter.DeleteByLastName(txtLastName.Text);
            ClearTextBoxes();
            CheckEditable(false);
        }

        private void ClearTextBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Clear();
                }
            }
        }

        private void CheckEditable(bool editable)
        {
            if (editable)
            {
                txtFirstName.Enabled = true;
                txtPhoneNumber.Enabled = true;
                txtEmail.Enabled = true;

                btnCheckOut.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                txtFirstName.Enabled = false;
                txtPhoneNumber.Enabled = false;
                txtEmail.Enabled = false;

                btnCheckOut.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }
    }
}
