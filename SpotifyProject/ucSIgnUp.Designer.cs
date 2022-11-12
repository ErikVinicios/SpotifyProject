namespace SpotifyProject
{
    partial class ucSIgnUp
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSIgnUp));
            this.btSignIn = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btSignIn
            // 
            this.btSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSignIn.BackColor = System.Drawing.Color.Black;
            this.btSignIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignIn.ForeColor = System.Drawing.Color.Snow;
            this.btSignIn.Location = new System.Drawing.Point(340, 92);
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.Size = new System.Drawing.Size(94, 23);
            this.btSignIn.TabIndex = 18;
            this.btSignIn.Text = "SIGN IN";
            this.btSignIn.UseVisualStyleBackColor = false;
            this.btSignIn.Click += new System.EventHandler(this.btSignIn_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.tbUsername.Location = new System.Drawing.Point(224, 140);
            this.tbUsername.MaxLength = 30;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(326, 26);
            this.tbUsername.TabIndex = 19;
            this.tbUsername.Text = "Username";
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Enter);
            this.tbUsername.Leave += new System.EventHandler(this.tbUsername_Leave);
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.tbEmail.Location = new System.Drawing.Point(224, 184);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(326, 26);
            this.tbEmail.TabIndex = 20;
            this.tbEmail.Text = "Email";
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPassword.Location = new System.Drawing.Point(224, 230);
            this.tbPassword.MaxLength = 30;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(326, 26);
            this.tbPassword.TabIndex = 21;
            this.tbPassword.Text = "Password";
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // tbConfPassword
            // 
            this.tbConfPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbConfPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.tbConfPassword.Location = new System.Drawing.Point(224, 276);
            this.tbConfPassword.MaxLength = 30;
            this.tbConfPassword.Name = "tbConfPassword";
            this.tbConfPassword.Size = new System.Drawing.Size(326, 26);
            this.tbConfPassword.TabIndex = 22;
            this.tbConfPassword.Text = "Confirm Password";
            this.tbConfPassword.TextChanged += new System.EventHandler(this.tbConfPassword_TextChanged);
            this.tbConfPassword.Enter += new System.EventHandler(this.tbConfPassword_Enter);
            this.tbConfPassword.Leave += new System.EventHandler(this.tbConfPassword_Leave);
            // 
            // btCreate
            // 
            this.btCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCreate.BackColor = System.Drawing.Color.Lime;
            this.btCreate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreate.ForeColor = System.Drawing.Color.Snow;
            this.btCreate.Location = new System.Drawing.Point(224, 342);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(326, 26);
            this.btCreate.TabIndex = 23;
            this.btCreate.Text = "CREATE";
            this.btCreate.UseVisualStyleBackColor = false;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // lbInvUsername
            // 
            this.lbInvUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInvUsername.AutoSize = true;
            this.lbInvUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvUsername.ForeColor = System.Drawing.Color.Red;
            this.lbInvUsername.Location = new System.Drawing.Point(556, 146);
            this.lbInvUsername.Name = "lbInvUsername";
            this.lbInvUsername.Size = new System.Drawing.Size(40, 16);
            this.lbInvUsername.TabIndex = 24;
            this.lbInvUsername.Text = "error";
            this.lbInvUsername.Visible = false;
            // 
            // lbInvPassword
            // 
            this.lbInvPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInvPassword.AutoSize = true;
            this.lbInvPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvPassword.ForeColor = System.Drawing.Color.Red;
            this.lbInvPassword.Location = new System.Drawing.Point(556, 236);
            this.lbInvPassword.Name = "lbInvPassword";
            this.lbInvPassword.Size = new System.Drawing.Size(40, 16);
            this.lbInvPassword.TabIndex = 25;
            this.lbInvPassword.Text = "error";
            this.lbInvPassword.Visible = false;
            // 
            // lbInvEmail
            // 
            this.lbInvEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInvEmail.AutoSize = true;
            this.lbInvEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvEmail.ForeColor = System.Drawing.Color.Red;
            this.lbInvEmail.Location = new System.Drawing.Point(556, 190);
            this.lbInvEmail.Name = "lbInvEmail";
            this.lbInvEmail.Size = new System.Drawing.Size(40, 16);
            this.lbInvEmail.TabIndex = 26;
            this.lbInvEmail.Text = "error";
            this.lbInvEmail.Visible = false;
            // 
            // lbConfPassword
            // 
            this.lbConfPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbConfPassword.AutoSize = true;
            this.lbConfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfPassword.ForeColor = System.Drawing.Color.Red;
            this.lbConfPassword.Location = new System.Drawing.Point(556, 282);
            this.lbConfPassword.Name = "lbConfPassword";
            this.lbConfPassword.Size = new System.Drawing.Size(40, 16);
            this.lbConfPassword.TabIndex = 27;
            this.lbConfPassword.Text = "error";
            this.lbConfPassword.Visible = false;
            // 
            // lbPasswordForce
            // 
            this.lbPasswordForce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPasswordForce.AutoSize = true;
            this.lbPasswordForce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswordForce.ForeColor = System.Drawing.Color.Red;
            this.lbPasswordForce.Location = new System.Drawing.Point(430, 214);
            this.lbPasswordForce.Name = "lbPasswordForce";
            this.lbPasswordForce.Size = new System.Drawing.Size(33, 13);
            this.lbPasswordForce.TabIndex = 28;
            this.lbPasswordForce.Text = "error";
            this.lbPasswordForce.Visible = false;
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPassword.ForeColor = System.Drawing.Color.White;
            this.cbShowPassword.Location = new System.Drawing.Point(241, 308);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(113, 19);
            this.cbShowPassword.TabIndex = 29;
            this.cbShowPassword.Text = "Show password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.cbShowPassword);
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.Controls.Add(this.lbPasswordForce);
            this.panel1.Controls.Add(this.lbConfPassword);
            this.panel1.Controls.Add(this.btSignIn);
            this.panel1.Controls.Add(this.lbInvEmail);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.lbInvPassword);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.lbInvUsername);
            this.panel1.Controls.Add(this.tbConfPassword);
            this.panel1.Controls.Add(this.btCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 437);
            this.panel1.TabIndex = 30;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(183, 56);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 30;
            this.pbLogo.TabStop = false;
            // 
            // ucSIgnUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ucSIgnUp";
            this.Size = new System.Drawing.Size(784, 437);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSignIn;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}
