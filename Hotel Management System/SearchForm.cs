using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using System.Data.Sql;

namespace Hotel_Management_System
{
    public partial class SearchForm : Form
    {
        List<Client> client = new List<Client>();
        public SearchForm()
        {
            InitializeComponent();
        }

        private void UpdateBinding()
        {
            listBox1.DataSource = client;
            listBox1.DisplayMember = "FullInfo";
        }

        public List<Client> GetClient(string lastName)
        {
            using (SqlConnection connection = new SqlConnection(Helper.ConnectionVal("HotelDb")))
            {
                //clientsTableAdapter.FillByLastName(hotelDbDataSet.Clients, lastName);
                var output = connection.Query<Client>("dbo.selectByLastName @lastName", new { lastName = lastName}).ToList();
                return output;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string lastName = textLastName.Text;

            client = GetClient(lastName);

            UpdateBinding();

            textLastName.Clear();

            
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDbDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.hotelDbDataSet.Clients);

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Clear();
                }
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchButton.PerformClick();
        }
    }

    public class Client
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string FullInfo
        {
            get
            {
                return $"{firstName} {lastName} {phoneNumber} ({email})";
            }
        }
    }
}
