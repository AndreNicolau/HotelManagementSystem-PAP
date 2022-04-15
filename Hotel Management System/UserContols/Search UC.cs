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


        private bool CanBeEditable()
        {
            // new logic :)
            if (dataGridView1.Rows.Count > 0 && txtLastName.Text != "")
            {
                btnCheckOut.Enabled = true;
                btnUpdate.Enabled = true;
                
                txtFirstName.Enabled = true;
                txtPhoneNumber.Enabled = true;
                txtEmail.Enabled = true;

                return true;
            } else
            {
                btnCheckOut.Enabled=false;
                btnUpdate.Enabled=false;

                txtFirstName.Enabled=false;
                txtEmail.Enabled=false;
                txtPhoneNumber.Enabled=false;
               
                return false;
            }
        }

        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clientsTableAdapter.UpdateByLastName(txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text, txtEmail.Text);
            dataGridView1.DataSource = clientsTableAdapter.GetDataByLastName(txtLastName.Text);
            ClearTextBoxes();
            CanBeEditable();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            clientsTableAdapter.DeleteByLastName(txtLastName.Text);
            dataGridView1.DataSource = clientsTableAdapter.GetDataByLastName(txtLastName.Text);
            ClearTextBoxes();
            CanBeEditable();
        }



        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clientsTableAdapter.GetDataByLastName(txtLastName.Text);
            CanBeEditable();
        }
    }
}
