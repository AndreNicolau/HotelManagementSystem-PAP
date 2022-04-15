using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textPassword.Clear();
            textUsername.Clear();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(Helper.ConnectionVal("HotelDb"));
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Users WHERE Username='" + textUsername.Text + "' AND Password='" + textPassword.Text + "'", sqlConnection);
            DataTable dt = new DataTable();

            sqlDataAdapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Wrong password or username");
            }

        }

        private void keyDown_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonLogin_Click(sender, e);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
