namespace ProjectNoSQL
{
    partial class ForgotPassword
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
            this.lbl_EnterEmail = new System.Windows.Forms.Label();
            this.tb_EnterEmail = new System.Windows.Forms.TextBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.lbl_NotFound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_EnterEmail
            // 
            this.lbl_EnterEmail.AutoSize = true;
            this.lbl_EnterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EnterEmail.Location = new System.Drawing.Point(40, 40);
            this.lbl_EnterEmail.Name = "lbl_EnterEmail";
            this.lbl_EnterEmail.Size = new System.Drawing.Size(175, 20);
            this.lbl_EnterEmail.TabIndex = 5;
            this.lbl_EnterEmail.Text = "Please enter your Email";
            // 
            // tb_EnterEmail
            // 
            this.tb_EnterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EnterEmail.Location = new System.Drawing.Point(52, 86);
            this.tb_EnterEmail.Name = "tb_EnterEmail";
            this.tb_EnterEmail.Size = new System.Drawing.Size(360, 26);
            this.tb_EnterEmail.TabIndex = 7;
            // 
            // btn_Enter
            // 
            this.btn_Enter.AutoSize = true;
            this.btn_Enter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Enter.Location = new System.Drawing.Point(172, 173);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(120, 36);
            this.btn_Enter.TabIndex = 8;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // lbl_NotFound
            // 
            this.lbl_NotFound.BackColor = System.Drawing.Color.LightPink;
            this.lbl_NotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NotFound.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_NotFound.Location = new System.Drawing.Point(52, 134);
            this.lbl_NotFound.Name = "lbl_NotFound";
            this.lbl_NotFound.Size = new System.Drawing.Size(360, 26);
            this.lbl_NotFound.TabIndex = 10;
            this.lbl_NotFound.Text = "We could not find a user with that Email";
            this.lbl_NotFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_NotFound.Visible = false;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 241);
            this.Controls.Add(this.lbl_NotFound);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.tb_EnterEmail);
            this.Controls.Add(this.lbl_EnterEmail);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_EnterEmail;
        private System.Windows.Forms.TextBox tb_EnterEmail;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Label lbl_NotFound;
    }
}