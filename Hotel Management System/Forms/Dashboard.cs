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

            check_In_UC.Visible = false;
            search_UC.Visible = false;
            users_UC1.Visible = false;
        }

        // Show CheckIn UserControl
        private void rdoCheckIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCheckIn.Checked)
            {
                check_In_UC.Dock = DockStyle.Fill;
                check_In_UC.Visible = true;

                rdoCheckIn.BackColor = Color.White;
            }
            else
            {
                check_In_UC.Visible = false;
                rdoCheckIn.BackColor = rdoColor;
            }

        }

        // Show Search UserControl
        private void rdoSearch_CheckedChanged(object sender, EventArgs e)
        {
            clientsTableAdapter.GetData();

            if (rdoSearch.Checked)
            {
                search_UC.Dock = DockStyle.Fill;
                search_UC.Visible = true;

                rdoSearch.BackColor = Color.White;
            }
            else
            {
                search_UC.Visible = false;
                rdoSearch.BackColor = rdoColor;
            }
        }

        // Show Users UserControl
        private void rdoUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoUsers.Checked)
            {
                users_UC1.Dock = DockStyle.Fill;
                users_UC1.Visible = true;

                rdoUsers.BackColor = Color.White;
            }
            else
            {
                users_UC1.Visible = false;
                rdoUsers.BackColor = rdoColor;
            }
        }
    }
}
