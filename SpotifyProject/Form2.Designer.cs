namespace SpotifyProject
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.btSignIn = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbConfPassword = new System.Windows.Forms.TextBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.lbInvUsername = new System.Windows.Forms.Label();
            this.lbInvPassword = new System.Windows.Forms.Label();
            this.lbInvEmail = new System.Windows.Forms.Label();
            this.lbConfPassword = new System.Windows.Forms.Label();
            this.lbPasswordForce = new System.Windows.Forms.Label();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btSignIn
            // 
            this.btSignIn.BackColor = System.Drawing.Color.Black;
            this.btSignIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignIn.ForeColor = System.Drawing.Color.Snow;
            this.btSignIn.Location = new System.Drawing.Point(339, 135);
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.Size = new System.Drawing.Size(94, 23);
            this.btSignIn.TabIndex = 4;
            this.btSignIn.Text = "SIGN IN";
            this.btSignIn.UseVisualStyleBackColor = false;
            this.btSignIn.Click += new System.EventHandler(this.btCSignIn_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(298, 55);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(183, 56);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // tbUsername
            // 
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.tbUsername.Location = new System.Drawing.Point(223, 183);
            this.tbUsername.MaxLength = 30;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(326, 26);
            this.tbUsername.TabIndex = 6;
            this.tbUsername.Text = "Username";
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Enter);
            this.tbUsername.Leave += new System.EventHandler(this.tbUsername_Leave);
            // 
            // tbEmail
            // 
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.tbEmail.Location = new System.Drawing.Point(223, 227);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(326, 26);
            this.tbEmail.TabIndex = 7;
            this.tbEmail.Text = "Email";
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPassword.Location = new System.Drawing.Point(223, 273);
            this.tbPassword.MaxLength = 30;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(326, 26);
            this.tbPassword.TabIndex = 8;
            this.tbPassword.Text = "Password";
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // tbConfPassword
            // 
            this.tbConfPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.tbConfPassword.Location = new System.Drawing.Point(223, 319);
            this.tbConfPassword.MaxLength = 30;
            this.tbConfPassword.Name = "tbConfPassword";
            this.tbConfPassword.Size = new System.Drawing.Size(326, 26);
            this.tbConfPassword.TabIndex = 9;
            this.tbConfPassword.Text = "Confirm Password";
            this.tbConfPassword.TextChanged += new System.EventHandler(this.tbConfPassword_TextChanged);
            this.tbConfPassword.Enter += new System.EventHandler(this.tbConfPassword_Enter);
            this.tbConfPassword.Leave += new System.EventHandler(this.tbConfPassword_Leave);
            // 
            // btCreate
            // 
            this.btCreate.BackColor = System.Drawing.Color.Lime;
            this.btCreate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreate.ForeColor = System.Drawing.Color.Snow;
            this.btCreate.Location = new System.Drawing.Point(223, 385);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(326, 26);
            this.btCreate.TabIndex = 10;
            this.btCreate.Text = "CREATE";
            this.btCreate.UseVisualStyleBackColor = false;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // lbInvUsername
            // 
            this.lbInvUsername.AutoSize = true;
            this.lbInvUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvUsername.ForeColor = System.Drawing.Color.Red;
            this.lbInvUsername.Location = new System.Drawing.Point(555, 189);
            this.lbInvUsername.Name = "lbInvUsername";
            this.lbInvUsername.Size = new System.Drawing.Size(40, 16);
            this.lbInvUsername.TabIndex = 11;
            this.lbInvUsername.Text = "error";
            this.lbInvUsername.Visible = false;
            // 
            // lbInvPassword
            // 
            this.lbInvPassword.AutoSize = true;
            this.lbInvPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvPassword.ForeColor = System.Drawing.Color.Red;
            this.lbInvPassword.Location = new System.Drawing.Point(555, 279);
            this.lbInvPassword.Name = "lbInvPassword";
            this.lbInvPassword.Size = new System.Drawing.Size(40, 16);
            this.lbInvPassword.TabIndex = 12;
            this.lbInvPassword.Text = "error";
            this.lbInvPassword.Visible = false;
            // 
            // lbInvEmail
            // 
            this.lbInvEmail.AutoSize = true;
            this.lbInvEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvEmail.ForeColor = System.Drawing.Color.Red;
            this.lbInvEmail.Location = new System.Drawing.Point(555, 233);
            this.lbInvEmail.Name = "lbInvEmail";
            this.lbInvEmail.Size = new System.Drawing.Size(40, 16);
            this.lbInvEmail.TabIndex = 13;
            this.lbInvEmail.Text = "error";
            this.lbInvEmail.Visible = false;
            // 
            // lbConfPassword
            // 
            this.lbConfPassword.AutoSize = true;
            this.lbConfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfPassword.ForeColor = System.Drawing.Color.Red;
            this.lbConfPassword.Location = new System.Drawing.Point(555, 325);
            this.lbConfPassword.Name = "lbConfPassword";
            this.lbConfPassword.Size = new System.Drawing.Size(40, 16);
            this.lbConfPassword.TabIndex = 14;
            this.lbConfPassword.Text = "error";
            this.lbConfPassword.Visible = false;
            // 
            // lbPasswordForce
            // 
            this.lbPasswordForce.AutoSize = true;
            this.lbPasswordForce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswordForce.ForeColor = System.Drawing.Color.Red;
            this.lbPasswordForce.Location = new System.Drawing.Point(429, 257);
            this.lbPasswordForce.Name = "lbPasswordForce";
            this.lbPasswordForce.Size = new System.Drawing.Size(33, 13);
            this.lbPasswordForce.TabIndex = 15;
            this.lbPasswordForce.Text = "error";
            this.lbPasswordForce.Visible = false;
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPassword.ForeColor = System.Drawing.Color.White;
            this.cbShowPassword.Location = new System.Drawing.Point(240, 351);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(113, 19);
            this.cbShowPassword.TabIndex = 16;
            this.cbShowPassword.Text = "Show password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.lbPasswordForce);
            this.Controls.Add(this.lbConfPassword);
            this.Controls.Add(this.lbInvEmail);
            this.Controls.Add(this.lbInvPassword);
            this.Controls.Add(this.lbInvUsername);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.tbConfPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btSignIn);
            this.Controls.Add(this.pbLogo);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSignIn;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbConfPassword;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Label lbInvUsername;
        private System.Windows.Forms.Label lbInvPassword;
        private System.Windows.Forms.Label lbInvEmail;
        private System.Windows.Forms.Label lbConfPassword;
        private System.Windows.Forms.Label lbPasswordForce;
        private System.Windows.Forms.CheckBox cbShowPassword;
    }
}