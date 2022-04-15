using System;
using System.Windows.Forms;

namespace Hotel_Management_System.UserContols
{
    public partial class Search_User_Control : UserControl
    {
        public Search_User_Control()
        {
            InitializeComponent();

            dataGridView1.DataSource = clientsTableAdapter.GetData();
        }

        #region My functions
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

        #endregion

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
            dataGridView1.DataSource = clientsTableAdapter.GetDataByLastName(txtLastName.Text);
            ClearTextBoxes();
            CheckEditable(false);
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

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clientsTableAdapter.GetDataByLastName(txtLastName.Text);
        }
    }
}
