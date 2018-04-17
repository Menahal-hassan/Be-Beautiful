namespace Frmregistration
{
    partial class frmresetpassward
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
            this.cmdok = new System.Windows.Forms.Button();
            this.lblpassward = new System.Windows.Forms.Label();
            this.lblconfirmpassward = new System.Windows.Forms.Label();
            this.txtpssward = new System.Windows.Forms.TextBox();
            this.txtconfirmpassward = new System.Windows.Forms.TextBox();
            this.cmdlogin = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdok
            // 
            this.cmdok.Location = new System.Drawing.Point(168, 181);
            this.cmdok.Name = "cmdok";
            this.cmdok.Size = new System.Drawing.Size(75, 23);
            this.cmdok.TabIndex = 0;
            this.cmdok.Text = "OK";
            this.cmdok.UseVisualStyleBackColor = true;
            this.cmdok.Click += new System.EventHandler(this.cmdok_Click);
            // 
            // lblpassward
            // 
            this.lblpassward.AutoSize = true;
            this.lblpassward.Location = new System.Drawing.Point(25, 72);
            this.lblpassward.Name = "lblpassward";
            this.lblpassward.Size = new System.Drawing.Size(52, 13);
            this.lblpassward.TabIndex = 2;
            this.lblpassward.Text = "passward";
            // 
            // lblconfirmpassward
            // 
            this.lblconfirmpassward.AutoSize = true;
            this.lblconfirmpassward.Location = new System.Drawing.Point(25, 125);
            this.lblconfirmpassward.Name = "lblconfirmpassward";
            this.lblconfirmpassward.Size = new System.Drawing.Size(90, 13);
            this.lblconfirmpassward.TabIndex = 3;
            this.lblconfirmpassward.Text = "Confirm passward";
            // 
            // txtpssward
            // 
            this.txtpssward.Location = new System.Drawing.Point(143, 65);
            this.txtpssward.Name = "txtpssward";
            this.txtpssward.Size = new System.Drawing.Size(100, 20);
            this.txtpssward.TabIndex = 5;
            this.txtpssward.TextChanged += new System.EventHandler(this.txtpssward_TextChanged);
            // 
            // txtconfirmpassward
            // 
            this.txtconfirmpassward.Location = new System.Drawing.Point(143, 122);
            this.txtconfirmpassward.Name = "txtconfirmpassward";
            this.txtconfirmpassward.Size = new System.Drawing.Size(100, 20);
            this.txtconfirmpassward.TabIndex = 6;
            // 
            // cmdlogin
            // 
            this.cmdlogin.Location = new System.Drawing.Point(40, 181);
            this.cmdlogin.Name = "cmdlogin";
            this.cmdlogin.Size = new System.Drawing.Size(75, 23);
            this.cmdlogin.TabIndex = 7;
            this.cmdlogin.Text = "Login";
            this.cmdlogin.UseVisualStyleBackColor = true;
            this.cmdlogin.Click += new System.EventHandler(this.cmdlogin_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(25, 29);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(60, 13);
            this.lblusername.TabIndex = 8;
            this.lblusername.Text = "User Name";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(143, 22);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 9;
            // 
            // frmresetpassward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.cmdlogin);
            this.Controls.Add(this.txtconfirmpassward);
            this.Controls.Add(this.txtpssward);
            this.Controls.Add(this.lblconfirmpassward);
            this.Controls.Add(this.lblpassward);
            this.Controls.Add(this.cmdok);
            this.Name = "frmresetpassward";
            this.Text = "frmresetpassward";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdok;
        private System.Windows.Forms.Label lblpassward;
        private System.Windows.Forms.Label lblconfirmpassward;
        private System.Windows.Forms.TextBox txtpssward;
        private System.Windows.Forms.TextBox txtconfirmpassward;
        private System.Windows.Forms.Button cmdlogin;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtusername;
    }
}