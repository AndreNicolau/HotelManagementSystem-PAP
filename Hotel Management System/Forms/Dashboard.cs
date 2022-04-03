using System;
using System.Windows.Forms;
using System.Drawing;

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
            check_Out_User_Control1.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        private void rdoCheckOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCheckOut.Checked)
            {
                check_Out_User_Control1.Dock = DockStyle.Fill;
                check_Out_User_Control1.Visible = true;

                rdoCheckOut.BackColor = System.Drawing.Color.White;
            }
            else
            {
                check_Out_User_Control1.Visible = false;
                rdoCheckOut.BackColor = rdoColor;
            }

        }

        private void rdoCheckIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCheckIn.Checked)
            {
                check_In_User_Control1.Dock = DockStyle.Fill;
                check_In_User_Control1.Visible = true;

                rdoCheckIn.BackColor = System.Drawing.Color.White;
            }
            else
            {
                check_In_User_Control1.Visible = false;
                rdoCheckIn.BackColor = rdoColor;
            }

        }
    }
}
