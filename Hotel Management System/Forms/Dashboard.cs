using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Dashboard : Form
    {
        public Color rdoColor = Color.FromArgb(0, 192, 192);
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDbDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.hotelDbDataSet.Clients);

            check_In_User_Control1.Visible = false;
            search_User_Control1.Visible = false;
        }

        private void rdoCheckIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCheckIn.Checked)
            {
                check_In_User_Control1.Dock = DockStyle.Fill;
                check_In_User_Control1.Visible = true;

                rdoCheckIn.BackColor = Color.White;
            }
            else
            {
                check_In_User_Control1.Visible = false;
                rdoCheckIn.BackColor = rdoColor;
            }

        }

        private void rdoSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSearch.Checked)
            {
                search_User_Control1.Dock = DockStyle.Fill;
                search_User_Control1.Visible = true;

                rdoSearch.BackColor = Color.White;
            }
            else
            {
                search_User_Control1.Visible = false;
                rdoSearch.BackColor = rdoColor;
            }
        }
    }
}
