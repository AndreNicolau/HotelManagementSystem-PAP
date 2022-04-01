using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // TODO: This line of code loads data into the 'hotelDbDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.hotelDbDataSet.Clients);

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

            this.Hide();
        }
    }
}
