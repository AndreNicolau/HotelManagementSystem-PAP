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

            if (dataGridView1.Rows != null && dataGridView1.Rows.Count != 0)
            {
                CheckEditable(true);
            }
            else
            {
                CheckEditable(false);
            }

        }

        private void CheckEditable(bool editable)
        {
            if (editable)
            {
                txtPassword.Enabled = true;

                btnRemoveUser.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                txtPassword.Enabled = false;

                btnRemoveUser.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            usersTableAdapter.UpdateByUsername(txtUsername.Text, txtPassword.Text);
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            usersTableAdapter.DeleteByUsername(txtUsername.Text);
            dataGridView1.DataSource = usersTableAdapter.GetDataByUsername(txtUsername.Text);

            btnRemoveUser.Enabled = false;
            btnUpdate.Enabled = false;

            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtUsername.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(Helper.ConnectionVal("HotelDb")))
                {
                    try
                    {
                        conn.Open();
                        usersTableAdapter.InsertUser(txtUsername.Text, txtPassword.Text);
                        dataGridView1.DataSource = usersTableAdapter.GetData();
                        btnNewUser.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password.");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                txtPassword.Enabled = true;
                btnNewUser.Enabled = true;
            }
            else
            {
                txtPassword.Enabled = false;
                btnNewUser.Enabled = false;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                usersBindingSource.DataSource = dataGridView1.SelectedRows;
            }
        }
    }
}
