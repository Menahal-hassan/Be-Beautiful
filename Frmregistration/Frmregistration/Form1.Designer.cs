namespace frmregistration
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmdlogin = new System.Windows.Forms.Button();
            this.cmdregister = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.CheckBox();
            this.makeupArtist = new System.Windows.Forms.CheckBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphonenumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.admin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdlogin
            // 
            this.cmdlogin.BackColor = System.Drawing.Color.White;
            this.cmdlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdlogin.ForeColor = System.Drawing.Color.Fuchsia;
            this.cmdlogin.Location = new System.Drawing.Point(30, 416);
            this.cmdlogin.Name = "cmdlogin";
            this.cmdlogin.Size = new System.Drawing.Size(213, 53);
            this.cmdlogin.TabIndex = 34;
            this.cmdlogin.Text = "Login";
            this.cmdlogin.UseVisualStyleBackColor = false;
            // 
            // cmdregister
            // 
            this.cmdregister.BackColor = System.Drawing.Color.White;
            this.cmdregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdregister.ForeColor = System.Drawing.Color.Fuchsia;
            this.cmdregister.Location = new System.Drawing.Point(404, 416);
            this.cmdregister.Name = "cmdregister";
            this.cmdregister.Size = new System.Drawing.Size(213, 53);
            this.cmdregister.TabIndex = 33;
            this.cmdregister.Text = "REGISTER";
            this.cmdregister.UseVisualStyleBackColor = false;
            this.cmdregister.Click += new System.EventHandler(this.cmdregister_Click);
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.BackColor = System.Drawing.Color.White;
            this.customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.Color.Fuchsia;
            this.customer.Location = new System.Drawing.Point(235, 365);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(131, 29);
            this.customer.TabIndex = 32;
            this.customer.Text = "Customer";
            this.customer.UseVisualStyleBackColor = false;
            // 
            // makeupArtist
            // 
            this.makeupArtist.AutoSize = true;
            this.makeupArtist.BackColor = System.Drawing.Color.White;
            this.makeupArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeupArtist.ForeColor = System.Drawing.Color.Fuchsia;
            this.makeupArtist.Location = new System.Drawing.Point(404, 365);
            this.makeupArtist.Name = "makeupArtist";
            this.makeupArtist.Size = new System.Drawing.Size(179, 29);
            this.makeupArtist.TabIndex = 31;
            this.makeupArtist.Text = "MakeUp Artist";
            this.makeupArtist.UseVisualStyleBackColor = false;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(235, 210);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(220, 29);
            this.txtaddress.TabIndex = 30;
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Location = new System.Drawing.Point(235, 151);
            this.txtphonenumber.Multiline = true;
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(220, 29);
            this.txtphonenumber.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Fuchsia;
            this.label6.Location = new System.Drawing.Point(8, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Fuchsia;
            this.label5.Location = new System.Drawing.Point(8, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Phone Number";
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Location = new System.Drawing.Point(235, 321);
            this.txtconfirmpassword.Multiline = true;
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(220, 29);
            this.txtconfirmpassword.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Fuchsia;
            this.label4.Location = new System.Drawing.Point(4, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Confirm Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(235, 257);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(220, 29);
            this.txtpassword.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(4, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(235, 82);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(220, 29);
            this.txtusername.TabIndex = 22;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.White;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblusername.Location = new System.Drawing.Point(4, 82);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(132, 29);
            this.lblusername.TabIndex = 21;
            this.lblusername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Papyrus", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(-3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 51);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sign in to avail our exciting new collection!!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(655, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.BackColor = System.Drawing.Color.White;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.Color.Fuchsia;
            this.admin.Location = new System.Drawing.Point(88, 365);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(96, 29);
            this.admin.TabIndex = 35;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 502);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.cmdlogin);
            this.Controls.Add(this.cmdregister);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.makeupArtist);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtphonenumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtconfirmpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdlogin;
        private System.Windows.Forms.Button cmdregister;
        private System.Windows.Forms.CheckBox customer;
        private System.Windows.Forms.CheckBox makeupArtist;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtphonenumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox admin;
    }
}

