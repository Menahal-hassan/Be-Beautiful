namespace Frmregistration
{
    partial class Frmlogin
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassward = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassward = new System.Windows.Forms.Label();
            this.cmdlogin = new System.Windows.Forms.Button();
            this.cmdregistration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(171, 104);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 0;
            // 
            // txtpassward
            // 
            this.txtpassward.Location = new System.Drawing.Point(171, 163);
            this.txtpassward.Name = "txtpassward";
            this.txtpassward.Size = new System.Drawing.Size(100, 20);
            this.txtpassward.TabIndex = 1;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(38, 111);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(86, 16);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "User Name";
            // 
            // lblpassward
            // 
            this.lblpassward.AutoSize = true;
            this.lblpassward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassward.Location = new System.Drawing.Point(46, 166);
            this.lblpassward.Name = "lblpassward";
            this.lblpassward.Size = new System.Drawing.Size(75, 16);
            this.lblpassward.TabIndex = 3;
            this.lblpassward.Text = "passward";
            // 
            // cmdlogin
            // 
            this.cmdlogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmdlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdlogin.Location = new System.Drawing.Point(196, 218);
            this.cmdlogin.Name = "cmdlogin";
            this.cmdlogin.Size = new System.Drawing.Size(75, 23);
            this.cmdlogin.TabIndex = 4;
            this.cmdlogin.Text = "Login";
            this.cmdlogin.UseVisualStyleBackColor = false;
            this.cmdlogin.Click += new System.EventHandler(this.cmdlogin_Click);
            // 
            // cmdregistration
            // 
            this.cmdregistration.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmdregistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdregistration.Location = new System.Drawing.Point(196, 274);
            this.cmdregistration.Name = "cmdregistration";
            this.cmdregistration.Size = new System.Drawing.Size(75, 23);
            this.cmdregistration.TabIndex = 5;
            this.cmdregistration.Text = "Registration";
            this.cmdregistration.UseVisualStyleBackColor = false;
            this.cmdregistration.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "To register click here";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(46, 228);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Reset password";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(115, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "LOGIN";
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 332);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdregistration);
            this.Controls.Add(this.cmdlogin);
            this.Controls.Add(this.lblpassward);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtpassward);
            this.Controls.Add(this.txtusername);
            this.Name = "Frmlogin";
            this.Text = "Frmlogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassward;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassward;
        private System.Windows.Forms.Button cmdlogin;
        private System.Windows.Forms.Button cmdregistration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}