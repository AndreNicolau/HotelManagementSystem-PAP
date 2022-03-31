namespace Hotel_Management_System
{
    partial class CheckIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.texFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textContact = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numNights = new System.Windows.Forms.NumericUpDown();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numNights)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check In";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(84, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primeiro Nome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(84, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Último Nome";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(84, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contacto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(84, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // texFirstName
            // 
            this.texFirstName.Location = new System.Drawing.Point(88, 44);
            this.texFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texFirstName.Name = "texFirstName";
            this.texFirstName.Size = new System.Drawing.Size(270, 26);
            this.texFirstName.TabIndex = 5;
            this.texFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(88, 118);
            this.textLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(270, 26);
            this.textLastName.TabIndex = 6;
            this.textLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textContact
            // 
            this.textContact.Location = new System.Drawing.Point(88, 192);
            this.textContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(270, 26);
            this.textContact.TabIndex = 7;
            this.textContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(88, 266);
            this.textEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(270, 26);
            this.textEmail.TabIndex = 8;
            this.textEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(84, 316);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nights";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numNights
            // 
            this.numNights.Location = new System.Drawing.Point(88, 339);
            this.numNights.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNights.Name = "numNights";
            this.numNights.Size = new System.Drawing.Size(270, 26);
            this.numNights.TabIndex = 10;
            this.numNights.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numNights.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.BackColor = System.Drawing.Color.Green;
            this.buttonCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckIn.ForeColor = System.Drawing.Color.White;
            this.buttonCheckIn.Image = global::Hotel_Management_System.Properties.Resources._64_check;
            this.buttonCheckIn.Location = new System.Drawing.Point(88, 396);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Padding = new System.Windows.Forms.Padding(5);
            this.buttonCheckIn.Size = new System.Drawing.Size(132, 132);
            this.buttonCheckIn.TabIndex = 11;
            this.buttonCheckIn.Text = "Check In";
            this.buttonCheckIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCheckIn.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Image = global::Hotel_Management_System.Properties.Resources._64_cross;
            this.buttonCancel.Location = new System.Drawing.Point(226, 396);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Padding = new System.Windows.Forms.Padding(5);
            this.buttonCancel.Size = new System.Drawing.Size(132, 132);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonCheckIn);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textLastName);
            this.panel1.Controls.Add(this.numNights);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textContact);
            this.panel1.Controls.Add(this.textEmail);
            this.panel1.Controls.Add(this.texFirstName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(41, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 562);
            this.panel1.TabIndex = 13;
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check In";
            ((System.ComponentModel.ISupportInitialize)(this.numNights)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textContact;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numNights;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel1;
    }
}