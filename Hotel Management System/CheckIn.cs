using System;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            // clears all TextBox
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Clear();
                }
            }
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            string firstName = textFirstName.Text;
            string lastName = textLastName.Text;
            string contact = textContact.Text;
            string email = textEmail.Text;

            try
            {
                clientsTableAdapter.InsertQuery(firstName, lastName, email, contact);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            clientsTableAdapter.Fill(this.hotelDbDataSet.Clients);

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
