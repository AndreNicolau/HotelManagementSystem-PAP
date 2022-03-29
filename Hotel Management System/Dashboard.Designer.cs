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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(424, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 200);
            this.button1.TabIndex = 3;
            this.button1.Text = "Edit Clients Info";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonPlus
            // 
            this.buttonPlus.AutoEllipsis = true;
            this.buttonPlus.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlus.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlus.Image")));
            this.buttonPlus.Location = new System.Drawing.Point(218, 244);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(200, 200);
            this.buttonPlus.TabIndex = 2;
            this.buttonPlus.Text = "Register Client";
            this.buttonPlus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPlus.UseVisualStyleBackColor = false;
            // 
            // logoutButton
            // 
            this.logoutButton.AutoEllipsis = true;
            this.logoutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.Location = new System.Drawing.Point(630, 244);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(200, 200);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.AutoEllipsis = true;
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(12, 244);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(200, 200);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.searchButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button1;
    }
}

