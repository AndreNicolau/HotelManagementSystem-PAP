namespace Hotel_Management_System.UserContols
{
    partial class Check_In_User_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.clientsTableAdapter = new Hotel_Management_System.HotelDbDataSetTableAdapters.ClientsTableAdapter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(875, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(875, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(861, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(894, 307);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(783, 124);
            this.textFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(270, 26);
            this.textFirstName.TabIndex = 6;
            this.textFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(783, 196);
            this.textLastName.Margin = new System.Windows.Forms.Padding(5);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(270, 26);
            this.textLastName.TabIndex = 7;
            this.textLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(783, 268);
            this.textPhoneNumber.Margin = new System.Windows.Forms.Padding(5);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(270, 26);
            this.textPhoneNumber.TabIndex = 8;
            this.textPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPhoneNumber.Leave += new System.EventHandler(this.textPhoneNumber_Leave);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(783, 340);
            this.textEmail.Margin = new System.Windows.Forms.Padding(5);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(270, 26);
            this.textEmail.TabIndex = 9;
            this.textEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.BackColor = System.Drawing.Color.Lime;
            this.buttonCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCheckIn.Image = global::Hotel_Management_System.Properties.Resources._64_check;
            this.buttonCheckIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCheckIn.Location = new System.Drawing.Point(783, 416);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.buttonCheckIn.Size = new System.Drawing.Size(130, 130);
            this.buttonCheckIn.TabIndex = 12;
            this.buttonCheckIn.Text = "Check In";
            this.buttonCheckIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCheckIn.UseVisualStyleBackColor = false;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancel.Image = global::Hotel_Management_System.Properties.Resources._64_cross;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCancel.Location = new System.Drawing.Point(923, 416);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.buttonCancel.Size = new System.Drawing.Size(130, 130);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Check In";
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // Check_In_User_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCheckIn);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Check_In_User_Control";
            this.Size = new System.Drawing.Size(2631, 1531);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label5;
        private HotelDbDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
    }
}
