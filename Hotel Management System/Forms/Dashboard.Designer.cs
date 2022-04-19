namespace Hotel_Management_System
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDbDataSet = new Hotel_Management_System.HotelDbDataSet();
            this.clientsTableAdapter = new Hotel_Management_System.HotelDbDataSetTableAdapters.ClientsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoCheckIn = new System.Windows.Forms.RadioButton();
            this.rdoSearch = new System.Windows.Forms.RadioButton();
            this.rdoUsers = new System.Windows.Forms.RadioButton();
            this.btnLogout = new System.Windows.Forms.Button();
            this.users_UC1 = new Hotel_Management_System.UserContols.Users_UC();
            this.search_UC = new Hotel_Management_System.UserContols.Search_User_Control();
            this.check_In_UC = new Hotel_Management_System.UserContols.Check_In_User_Control();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.hotelDbDataSet;
            // 
            // hotelDbDataSet
            // 
            this.hotelDbDataSet.DataSetName = "HotelDbDataSet";
            this.hotelDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1904, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "DashBoard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(83)))), ((int)(((byte)(99)))));
            this.mainPanel.Controls.Add(this.users_UC1);
            this.mainPanel.Controls.Add(this.search_UC);
            this.mainPanel.Controls.Add(this.check_In_UC);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(0, 200);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1904, 841);
            this.mainPanel.TabIndex = 8;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.headerPanel.Controls.Add(this.flowLayoutPanel1);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1904, 200);
            this.headerPanel.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rdoCheckIn);
            this.flowLayoutPanel1.Controls.Add(this.rdoSearch);
            this.flowLayoutPanel1.Controls.Add(this.rdoUsers);
            this.flowLayoutPanel1.Controls.Add(this.btnLogout);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(664, 46);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(576, 150);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // rdoCheckIn
            // 
            this.rdoCheckIn.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdoCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCheckIn.Image = global::Hotel_Management_System.Properties.Resources._64_add;
            this.rdoCheckIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rdoCheckIn.Location = new System.Drawing.Point(4, 4);
            this.rdoCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCheckIn.Name = "rdoCheckIn";
            this.rdoCheckIn.Padding = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.rdoCheckIn.Size = new System.Drawing.Size(130, 130);
            this.rdoCheckIn.TabIndex = 9;
            this.rdoCheckIn.TabStop = true;
            this.rdoCheckIn.Text = "Chek In";
            this.rdoCheckIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdoCheckIn.UseVisualStyleBackColor = false;
            this.rdoCheckIn.CheckedChanged += new System.EventHandler(this.rdoCheckIn_CheckedChanged);
            // 
            // rdoSearch
            // 
            this.rdoSearch.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSearch.Image = global::Hotel_Management_System.Properties.Resources._64_search;
            this.rdoSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rdoSearch.Location = new System.Drawing.Point(138, 4);
            this.rdoSearch.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSearch.Name = "rdoSearch";
            this.rdoSearch.Padding = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.rdoSearch.Size = new System.Drawing.Size(130, 130);
            this.rdoSearch.TabIndex = 10;
            this.rdoSearch.TabStop = true;
            this.rdoSearch.Text = "Search";
            this.rdoSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdoSearch.UseVisualStyleBackColor = false;
            this.rdoSearch.CheckedChanged += new System.EventHandler(this.rdoSearch_CheckedChanged);
            // 
            // rdoUsers
            // 
            this.rdoUsers.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdoUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoUsers.Image = global::Hotel_Management_System.Properties.Resources._64_user;
            this.rdoUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rdoUsers.Location = new System.Drawing.Point(273, 5);
            this.rdoUsers.Name = "rdoUsers";
            this.rdoUsers.Padding = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.rdoUsers.Size = new System.Drawing.Size(130, 130);
            this.rdoUsers.TabIndex = 11;
            this.rdoUsers.TabStop = true;
            this.rdoUsers.Text = "Users";
            this.rdoUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdoUsers.UseVisualStyleBackColor = false;
            this.rdoUsers.CheckedChanged += new System.EventHandler(this.rdoUsers_CheckedChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnLogout.AutoEllipsis = true;
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(408, 4);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.btnLogout.Size = new System.Drawing.Size(130, 130);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // users_UC1
            // 
            this.users_UC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.users_UC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_UC1.Location = new System.Drawing.Point(445, 39);
            this.users_UC1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.users_UC1.Name = "users_UC1";
            this.users_UC1.Size = new System.Drawing.Size(200, 200);
            this.users_UC1.TabIndex = 5;
            // 
            // search_UC
            // 
            this.search_UC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.search_UC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_UC.Location = new System.Drawing.Point(237, 39);
            this.search_UC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search_UC.Name = "search_UC";
            this.search_UC.Size = new System.Drawing.Size(200, 200);
            this.search_UC.TabIndex = 4;
            // 
            // check_In_UC
            // 
            this.check_In_UC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.check_In_UC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_In_UC.ForeColor = System.Drawing.Color.White;
            this.check_In_UC.Location = new System.Drawing.Point(33, 39);
            this.check_In_UC.Margin = new System.Windows.Forms.Padding(0);
            this.check_In_UC.Name = "check_In_UC";
            this.check_In_UC.Size = new System.Drawing.Size(200, 200);
            this.check_In_UC.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(83)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private HotelDbDataSet hotelDbDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private HotelDbDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.RadioButton rdoCheckIn;
        private System.Windows.Forms.RadioButton rdoSearch;
        private System.Windows.Forms.Panel headerPanel;
        private UserContols.Check_In_User_Control check_In_UC;
        private UserContols.Search_User_Control search_UC;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rdoUsers;
        private UserContols.Users_UC users_UC1;
    }
}

