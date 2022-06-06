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
            if (dataGridView1.Rows.Count > 0 && txtLastName.Text != "")
            {
                btnCheckOut.Enabled = true;
                btnUpdate.Enabled = true;

                txtFirstName.Enabled = true;
                txtPhoneNumber.Enabled = true;
                txtEmail.Enabled = true;

                return true;
            }
            else
            {
                btnCheckOut.Enabled = false;
                btnUpdate.Enabled = false;

                txtFirstName.Enabled = false;
                txtEmail.Enabled = false;
                txtPhoneNumber.Enabled = false;

                return false;
            }
        }

        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clientsTableAdapter.UpdateByLastName(txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text, txtEmail.Text);
            dataGridView1.DataSource = clientsTableAdapter.GetDataByLastName(txtLastName.Text);
            CanBeEditable();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            clientsTableAdapter.DeleteByLastName(txtLastName.Text);
            dataGridView1.DataSource = clientsTableAdapter.GetData();
            ClearTextBoxes();
            CanBeEditable();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text != "")
            {
                dataGridView1.DataSource = clientsTableAdapter.GetDataByLastName(txtLastName.Text);
                btnClear.Enabled = true;
            }   
            else
            {
                dataGridView1.DataSource = clientsTableAdapter.GetData();
                btnClear.Enabled = false;
            }
                

            if (dataGridView1.Rows.Count == 1)
                clientsBindingSource.DataSource = dataGridView1.DataSource;

            CanBeEditable();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
                txtFirstName.Text = dataGridViewRow.Cells[0].Value.ToString();
                txtLastName.Text = dataGridViewRow.Cells[1].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void Search_User_Control_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clientsTableAdapter.GetData();
        }
    }
}
