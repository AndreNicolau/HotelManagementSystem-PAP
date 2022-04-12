using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.UserContols
{
    public partial class Check_In_User_Control : UserControl
    {
        public Check_In_User_Control()
        {
            InitializeComponent();
            ClearAll();
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            clientsTableAdapter.InsertQuery(textFirstName.Text, textLastName.Text, textPhoneNumber.Text, textEmail.Text);
            buttonCancel.PerformClick();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            textFirstName.Clear();
            textLastName.Clear();
            textPhoneNumber.Clear();
            textEmail.Clear();
        }
    }
}
