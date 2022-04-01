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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDbDataSet = new Hotel_Management_System.HotelDbDataSet();
            this.clientsTableAdapter = new Hotel_Management_System.HotelDbDataSetTableAdapters.ClientsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.flowLayoutPanel1.Controls.Add(this.buttonPlus);
            this.flowLayoutPanel1.Controls.Add(this.searchButton);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.logoutButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 809);
            this.flowLayoutPanel1.TabIndex = 6;
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
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1125, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "DashBoard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlus
            // 
            this.buttonPlus.AutoEllipsis = true;
            this.buttonPlus.BackColor = System.Drawing.Color.Lime;
            this.buttonPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlus.Image")));
            this.buttonPlus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPlus.Location = new System.Drawing.Point(8, 8);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.buttonPlus.Size = new System.Drawing.Size(130, 130);
            this.buttonPlus.TabIndex = 2;
            this.buttonPlus.Text = "Check In";
            this.buttonPlus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // searchButton
            // 
            this.searchButton.AutoEllipsis = true;
            this.searchButton.BackColor = System.Drawing.Color.Gold;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchButton.Location = new System.Drawing.Point(8, 148);
            this.searchButton.Margin = new System.Windows.Forms.Padding(5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.searchButton.Size = new System.Drawing.Size(130, 130);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoEllipsis = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(8, 288);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.button2.Size = new System.Drawing.Size(130, 130);
            this.button2.TabIndex = 4;
            this.button2.Text = "Settings";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // logoutButton
            // 
            this.logoutButton.AutoEllipsis = true;
            this.logoutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutButton.BackColor = System.Drawing.Color.Red;
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logoutButton.Location = new System.Drawing.Point(8, 428);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(5);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.logoutButton.Size = new System.Drawing.Size(130, 130);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1275, 809);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private HotelDbDataSet hotelDbDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private HotelDbDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}

