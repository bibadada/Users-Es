namespace UsersWinForms
{
    partial class LoginUserControl
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
            this.Titolo = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnPasswordDimenticata = new System.Windows.Forms.Button();
            this.pnlPasswordDimenticata = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.Mail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.pnlPasswordDimenticata.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titolo
            // 
            this.Titolo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titolo.Location = new System.Drawing.Point(16, 11);
            this.Titolo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titolo.Name = "Titolo";
            this.Titolo.Size = new System.Drawing.Size(735, 32);
            this.Titolo.TabIndex = 0;
            this.Titolo.Text = "Login";
            this.Titolo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Username
            // 
            this.Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Username.Location = new System.Drawing.Point(44, 44);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(655, 22);
            this.Username.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.Location = new System.Drawing.Point(44, 110);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(540, 22);
            this.Password.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(40, 25);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(43, 90);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(600, 158);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(606, 112);
            this.chkShowPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(102, 21);
            this.chkShowPassword.TabIndex = 6;
            this.chkShowPassword.Text = "Mostra pwd";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogin.Controls.Add(this.btnPasswordDimenticata);
            this.pnlLogin.Controls.Add(this.Username);
            this.pnlLogin.Controls.Add(this.chkShowPassword);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.Password);
            this.pnlLogin.Location = new System.Drawing.Point(15, 51);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(728, 214);
            this.pnlLogin.TabIndex = 7;
            // 
            // btnPasswordDimenticata
            // 
            this.btnPasswordDimenticata.Location = new System.Drawing.Point(44, 158);
            this.btnPasswordDimenticata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPasswordDimenticata.Name = "btnPasswordDimenticata";
            this.btnPasswordDimenticata.Size = new System.Drawing.Size(197, 28);
            this.btnPasswordDimenticata.TabIndex = 7;
            this.btnPasswordDimenticata.Text = "Password Dimenticata?";
            this.btnPasswordDimenticata.UseVisualStyleBackColor = true;
            this.btnPasswordDimenticata.Click += new System.EventHandler(this.btnPasswordDimenticata_Click);
            // 
            // pnlPasswordDimenticata
            // 
            this.pnlPasswordDimenticata.Controls.Add(this.btnCancel);
            this.pnlPasswordDimenticata.Controls.Add(this.btnOk);
            this.pnlPasswordDimenticata.Controls.Add(this.Mail);
            this.pnlPasswordDimenticata.Controls.Add(this.lblMail);
            this.pnlPasswordDimenticata.Location = new System.Drawing.Point(19, 47);
            this.pnlPasswordDimenticata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPasswordDimenticata.Name = "pnlPasswordDimenticata";
            this.pnlPasswordDimenticata.Size = new System.Drawing.Size(728, 273);
            this.pnlPasswordDimenticata.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(51, 102);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Annulla";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(600, 102);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Mail
            // 
            this.Mail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mail.Location = new System.Drawing.Point(51, 58);
            this.Mail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(648, 22);
            this.Mail.TabIndex = 1;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(47, 37);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(413, 17);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Inserisci la tua mail. Ti invieremo una mail di recupero password.";
            // 
            // LoginUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlPasswordDimenticata);
            this.Controls.Add(this.Titolo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginUserControl";
            this.Size = new System.Drawing.Size(767, 352);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlPasswordDimenticata.ResumeLayout(false);
            this.pnlPasswordDimenticata.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Titolo;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlPasswordDimenticata;
        private System.Windows.Forms.Button btnPasswordDimenticata;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Label lblMail;
    }
}

