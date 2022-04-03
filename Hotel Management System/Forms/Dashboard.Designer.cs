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
            this.rdoCheckIn = new System.Windows.Forms.RadioButton();
            this.rdoCheckOut = new System.Windows.Forms.RadioButton();
            this.btnLogout = new System.Windows.Forms.Button();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDbDataSet = new Hotel_Management_System.HotelDbDataSet();
            this.clientsTableAdapter = new Hotel_Management_System.HotelDbDataSetTableAdapters.ClientsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.hotelDbDataSet1 = new Hotel_Management_System.HotelDbDataSet();
            this.rdoSearch = new System.Windows.Forms.RadioButton();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.check_In_User_Control1 = new Hotel_Management_System.UserContols.Check_In_User_Control();
            this.check_Out_User_Control1 = new Hotel_Management_System.UserContols.Check_Out_User_Control();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet1)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoCheckIn
            // 
            this.rdoCheckIn.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdoCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCheckIn.Image = global::Hotel_Management_System.Properties.Resources._64_add;
            this.rdoCheckIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rdoCheckIn.Location = new System.Drawing.Point(682, 49);
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
            // rdoCheckOut
            // 
            this.rdoCheckOut.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdoCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCheckOut.Image = global::Hotel_Management_System.Properties.Resources._64_minus;
            this.rdoCheckOut.Location = new System.Drawing.Point(818, 49);
            this.rdoCheckOut.Name = "rdoCheckOut";
            this.rdoCheckOut.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.rdoCheckOut.Size = new System.Drawing.Size(130, 130);
            this.rdoCheckOut.TabIndex = 8;
            this.rdoCheckOut.TabStop = true;
            this.rdoCheckOut.Text = "Chek Out";
            this.rdoCheckOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdoCheckOut.UseVisualStyleBackColor = false;
            this.rdoCheckOut.CheckedChanged += new System.EventHandler(this.rdoCheckOut_CheckedChanged);
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
            this.btnLogout.Location = new System.Drawing.Point(1092, 51);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.btnLogout.Size = new System.Drawing.Size(130, 130);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.label1.Size = new System.Drawing.Size(1886, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "DashBoard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(83)))), ((int)(((byte)(99)))));
            this.mainPanel.Controls.Add(this.check_Out_User_Control1);
            this.mainPanel.Controls.Add(this.check_In_User_Control1);
            this.mainPanel.Location = new System.Drawing.Point(9, 207);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1886, 820);
            this.mainPanel.TabIndex = 8;
            // 
            // hotelDbDataSet1
            // 
            this.hotelDbDataSet1.DataSetName = "HotelDbDataSet";
            this.hotelDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rdoSearch
            // 
            this.rdoSearch.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSearch.Image = global::Hotel_Management_System.Properties.Resources._64_search;
            this.rdoSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rdoSearch.Location = new System.Drawing.Point(954, 49);
            this.rdoSearch.Name = "rdoSearch";
            this.rdoSearch.Padding = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.rdoSearch.Size = new System.Drawing.Size(130, 130);
            this.rdoSearch.TabIndex = 10;
            this.rdoSearch.TabStop = true;
            this.rdoSearch.Text = "Search";
            this.rdoSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdoSearch.UseVisualStyleBackColor = false;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.headerPanel.Controls.Add(this.rdoCheckIn);
            this.headerPanel.Controls.Add(this.rdoCheckOut);
            this.headerPanel.Controls.Add(this.rdoSearch);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.btnLogout);
            this.headerPanel.Location = new System.Drawing.Point(9, 9);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1886, 193);
            this.headerPanel.TabIndex = 9;
            // 
            // check_In_User_Control1
            // 
            this.check_In_User_Control1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.check_In_User_Control1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_In_User_Control1.ForeColor = System.Drawing.Color.White;
            this.check_In_User_Control1.Location = new System.Drawing.Point(33, 39);
            this.check_In_User_Control1.Margin = new System.Windows.Forms.Padding(0);
            this.check_In_User_Control1.Name = "check_In_User_Control1";
            this.check_In_User_Control1.Size = new System.Drawing.Size(200, 200);
            this.check_In_User_Control1.TabIndex = 0;
            // 
            // check_Out_User_Control1
            // 
            this.check_Out_User_Control1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.check_Out_User_Control1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Out_User_Control1.ForeColor = System.Drawing.Color.White;
            this.check_Out_User_Control1.Location = new System.Drawing.Point(33, 264);
            this.check_Out_User_Control1.Margin = new System.Windows.Forms.Padding(0);
            this.check_Out_User_Control1.Name = "check_Out_User_Control1";
            this.check_Out_User_Control1.Size = new System.Drawing.Size(200, 200);
            this.check_Out_User_Control1.TabIndex = 1;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet1)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private HotelDbDataSet hotelDbDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private HotelDbDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private HotelDbDataSet hotelDbDataSet1;
        private System.Windows.Forms.RadioButton rdoCheckOut;
        private System.Windows.Forms.RadioButton rdoCheckIn;
        private System.Windows.Forms.RadioButton rdoSearch;
        private System.Windows.Forms.Panel headerPanel;
        private UserContols.Check_Out_User_Control check_Out_User_Control1;
        private UserContols.Check_In_User_Control check_In_User_Control1;
    }
}

