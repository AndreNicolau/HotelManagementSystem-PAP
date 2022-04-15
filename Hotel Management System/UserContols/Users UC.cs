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

            dataGridView1.DataSource = usersTableAdapter.GetData();
        }

        #region My functions

        private bool CanEdit()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                btnUpdate.Enabled = true;
                btnRemoveUser.Enabled = true;
                txtPassword.Enabled = true;

                usersBindingSource.DataSource = dataGridView1.DataSource;

                return true;
            }
            else
            {
                btnUpdate.Enabled = false;
                btnRemoveUser.Enabled = false;
                txtPassword.Enabled = false;
                txtPassword.Clear();
                return false;
            }
        }

        private bool CanInsertNewUser()
        {
            if (dataGridView1.Rows.Count == 0 && txtUsername.Text != "")
            {
                txtPassword.Enabled = true;

                if (txtPassword.Text != "")
                {
                    btnNewUser.Enabled = true;
                    return true;
                }
                else
                {
                    btnNewUser.Enabled = false;
                    return false;
                }

            }
            else
            {
                txtPassword.Enabled = false;
                btnNewUser.Enabled = false;
                return false;
            }
        }

        private void InsertNewUser()
        {
            if (CanInsertNewUser())
            {
                using (SqlConnection conn = new SqlConnection(Helper.ConnectionVal("HotelDb")))
                {
                    try
                    {
                        conn.Open();
                        usersTableAdapter.InsertUser(txtUsername.Text, txtPassword.Text);
                        dataGridView1.DataSource = usersTableAdapter.GetData();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        #endregion



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
            InsertNewUser();
            txtUsername.Clear();
            txtPassword.Clear();

            dataGridView1.DataSource = usersTableAdapter.GetData();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = usersTableAdapter.GetDataByUsername(txtUsername.Text);

            if (!CanEdit())
            {
                CanInsertNewUser();
            }

            if (txtUsername.Text == "")
                dataGridView1.DataSource = usersTableAdapter.GetData();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            CanInsertNewUser();
        }
    }
}
