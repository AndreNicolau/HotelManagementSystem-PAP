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
    public partial class Check_Out_User_Control : UserControl
    {
        public Check_Out_User_Control()
        {
            InitializeComponent();
        }

        private void Check_Out_User_Control_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clientsTableAdapter.GetData();
        }
    }
}
