namespace SpotifyProject
{
    partial class SignIn
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btSignUp = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.btSignIn = new System.Windows.Forms.Button();
            this.btForgPassword = new System.Windows.Forms.Button();
            this.lbInvUsername = new System.Windows.Forms.Label();
            this.lbInvPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            resources.ApplyResources(this.pbLogo, "pbLogo");
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.TabStop = false;
            // 
            // btSignUp
            // 
            resources.ApplyResources(this.btSignUp, "btSignUp");
            this.btSignUp.BackColor = System.Drawing.Color.Black;
            this.btSignUp.ForeColor = System.Drawing.Color.Snow;
            this.btSignUp.Name = "btSignUp";
            this.btSignUp.UseVisualStyleBackColor = false;
            this.btSignUp.Click += new System.EventHandler(this.btSignUp_Click);
            // 
            // tbUsername
            // 
            resources.ApplyResources(this.tbUsername, "tbUsername");
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Enter);
            this.tbUsername.Leave += new System.EventHandler(this.tbUsername_Leave);
            // 
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // cbShowPassword
            // 
            resources.ApplyResources(this.cbShowPassword, "cbShowPassword");
            this.cbShowPassword.ForeColor = System.Drawing.Color.Cornsilk;
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // btSignIn
            // 
            resources.ApplyResources(this.btSignIn, "btSignIn");
            this.btSignIn.BackColor = System.Drawing.Color.Lime;
            this.btSignIn.ForeColor = System.Drawing.Color.Snow;
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.UseVisualStyleBackColor = false;
            this.btSignIn.Click += new System.EventHandler(this.btSignIn_Click);
            // 
            // btForgPassword
            // 
            resources.ApplyResources(this.btForgPassword, "btForgPassword");
            this.btForgPassword.BackColor = System.Drawing.Color.Black;
            this.btForgPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.btForgPassword.Name = "btForgPassword";
            this.btForgPassword.UseVisualStyleBackColor = false;
            // 
            // lbInvUsername
            // 
            resources.ApplyResources(this.lbInvUsername, "lbInvUsername");
            this.lbInvUsername.ForeColor = System.Drawing.Color.Red;
            this.lbInvUsername.Name = "lbInvUsername";
            // 
            // lbInvPassword
            // 
            resources.ApplyResources(this.lbInvPassword, "lbInvPassword");
            this.lbInvPassword.ForeColor = System.Drawing.Color.Red;
            this.lbInvPassword.Name = "lbInvPassword";
            // 
            // SignIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lbInvPassword);
            this.Controls.Add(this.lbInvUsername);
            this.Controls.Add(this.btForgPassword);
            this.Controls.Add(this.btSignIn);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btSignUp);
            this.Controls.Add(this.pbLogo);
            this.MaximizeBox = false;
            this.Name = "SignIn";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btSignUp;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.Button btSignIn;
        private System.Windows.Forms.Button btForgPassword;
        private System.Windows.Forms.Label lbInvUsername;
        private System.Windows.Forms.Label lbInvPassword;
    }
}

