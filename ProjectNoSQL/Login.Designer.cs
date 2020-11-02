namespace ProjectNoSQL
{
    partial class Login
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
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.lbl_Incorrect = new System.Windows.Forms.Label();
            this.lbl_Forgot = new System.Windows.Forms.Label();
            this.chb_RememberMe = new System.Windows.Forms.CheckBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Title1 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Title2 = new System.Windows.Forms.Label();
            this.pnl_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Login
            // 
            this.pnl_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Login.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Login.Controls.Add(this.lbl_Incorrect);
            this.pnl_Login.Controls.Add(this.lbl_Forgot);
            this.pnl_Login.Controls.Add(this.chb_RememberMe);
            this.pnl_Login.Controls.Add(this.btn_Login);
            this.pnl_Login.Controls.Add(this.tb_Password);
            this.pnl_Login.Controls.Add(this.lbl_Title1);
            this.pnl_Login.Controls.Add(this.tb_Email);
            this.pnl_Login.Controls.Add(this.lbl_Password);
            this.pnl_Login.Controls.Add(this.lbl_Email);
            this.pnl_Login.Controls.Add(this.lbl_Title2);
            this.pnl_Login.Location = new System.Drawing.Point(412, 140);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(1080, 720);
            this.pnl_Login.TabIndex = 0;
            // 
            // lbl_Incorrect
            // 
            this.lbl_Incorrect.BackColor = System.Drawing.Color.LightPink;
            this.lbl_Incorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Incorrect.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Incorrect.Location = new System.Drawing.Point(360, 262);
            this.lbl_Incorrect.Name = "lbl_Incorrect";
            this.lbl_Incorrect.Size = new System.Drawing.Size(360, 26);
            this.lbl_Incorrect.TabIndex = 9;
            this.lbl_Incorrect.Text = "Incorrect username or password";
            this.lbl_Incorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Incorrect.Visible = false;
            // 
            // lbl_Forgot
            // 
            this.lbl_Forgot.AutoSize = true;
            this.lbl_Forgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Forgot.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Forgot.Location = new System.Drawing.Point(603, 470);
            this.lbl_Forgot.Name = "lbl_Forgot";
            this.lbl_Forgot.Size = new System.Drawing.Size(117, 16);
            this.lbl_Forgot.TabIndex = 8;
            this.lbl_Forgot.Text = "Forgot Password?";
            this.lbl_Forgot.Click += new System.EventHandler(this.lbl_Forgot_Click);
            this.lbl_Forgot.MouseEnter += new System.EventHandler(this.lbl_Forgot_MouseEnter);
            this.lbl_Forgot.MouseLeave += new System.EventHandler(this.lbl_Forgot_MouseLeave);
            // 
            // chb_RememberMe
            // 
            this.chb_RememberMe.AutoSize = true;
            this.chb_RememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_RememberMe.Location = new System.Drawing.Point(360, 469);
            this.chb_RememberMe.Name = "chb_RememberMe";
            this.chb_RememberMe.Size = new System.Drawing.Size(117, 20);
            this.chb_RememberMe.TabIndex = 7;
            this.chb_RememberMe.Text = "Remember me";
            this.chb_RememberMe.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.AutoSize = true;
            this.btn_Login.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Login.Location = new System.Drawing.Point(480, 522);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(120, 36);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(360, 436);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(360, 26);
            this.tb_Password.TabIndex = 5;
            // 
            // lbl_Title1
            // 
            this.lbl_Title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title1.Location = new System.Drawing.Point(360, 143);
            this.lbl_Title1.Name = "lbl_Title1";
            this.lbl_Title1.Size = new System.Drawing.Size(360, 30);
            this.lbl_Title1.TabIndex = 1;
            this.lbl_Title1.Text = "NoDesk: TGG";
            this.lbl_Title1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(360, 330);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(360, 26);
            this.tb_Email.TabIndex = 4;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(356, 413);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(78, 20);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(356, 307);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(48, 20);
            this.lbl_Email.TabIndex = 2;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Title2
            // 
            this.lbl_Title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Title2.Location = new System.Drawing.Point(360, 203);
            this.lbl_Title2.Name = "lbl_Title2";
            this.lbl_Title2.Size = new System.Drawing.Size(360, 40);
            this.lbl_Title2.TabIndex = 0;
            this.lbl_Title2.Text = "Please Provide login credentials to login to NoDesk for The Garden Group";
            this.lbl_Title2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1001);
            this.Controls.Add(this.pnl_Login);
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Title1;
        private System.Windows.Forms.Label lbl_Title2;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Forgot;
        private System.Windows.Forms.CheckBox chb_RememberMe;
        private System.Windows.Forms.Label lbl_Incorrect;
    }
}