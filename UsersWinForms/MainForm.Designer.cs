namespace UsersWinForms
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginUserControl = new UsersWinForms.LoginUserControl();
            this.gestioneUtenti = new UsersWinForms.GestioneUtenti();
            this.datiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.smGUtenti = new System.Windows.Forms.ToolStripMenuItem();
            this.smGAccessi = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.datiToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1152, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutMenuItem,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // logoutMenuItem
            // 
            this.logoutMenuItem.Name = "logoutMenuItem";
            this.logoutMenuItem.Size = new System.Drawing.Size(139, 26);
            this.logoutMenuItem.Text = "Logout";
            this.logoutMenuItem.Click += new System.EventHandler(this.logoutMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(139, 26);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // loginUserControl
            // 
            this.loginUserControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginUserControl.Location = new System.Drawing.Point(188, 122);
            this.loginUserControl.Margin = new System.Windows.Forms.Padding(5);
            this.loginUserControl.Name = "loginUserControl";
            this.loginUserControl.Size = new System.Drawing.Size(767, 352);
            this.loginUserControl.TabIndex = 1;
            // 
            // gestioneUtenti
            // 
            this.gestioneUtenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gestioneUtenti.Genders = null;
            this.gestioneUtenti.Location = new System.Drawing.Point(0, 33);
            this.gestioneUtenti.Margin = new System.Windows.Forms.Padding(5);
            this.gestioneUtenti.Name = "gestioneUtenti";
            this.gestioneUtenti.SearchSexIndex = -1;
            this.gestioneUtenti.SearchText = "";
            this.gestioneUtenti.Size = new System.Drawing.Size(1152, 575);
            this.gestioneUtenti.TabIndex = 2;
            this.gestioneUtenti.UsersList = null;
            // 
            // datiToolStripMenuItem
            // 
            this.datiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smGUtenti,
            this.smGAccessi});
            this.datiToolStripMenuItem.Name = "datiToolStripMenuItem";
            this.datiToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.datiToolStripMenuItem.Text = "Dati";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(30, 24);
            this.toolStripMenuItem1.Text = "?";
            // 
            // smGUtenti
            // 
            this.smGUtenti.Name = "smGUtenti";
            this.smGUtenti.Size = new System.Drawing.Size(224, 26);
            this.smGUtenti.Text = "Gestione Utenti";
            // 
            // smGAccessi
            // 
            this.smGAccessi.Name = "smGAccessi";
            this.smGAccessi.Size = new System.Drawing.Size(224, 26);
            this.smGAccessi.Text = "Gestione Accessi";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 601);
            this.Controls.Add(this.loginUserControl);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.gestioneUtenti);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private LoginUserControl loginUserControl;
        private GestioneUtenti gestioneUtenti;
        private System.Windows.Forms.ToolStripMenuItem datiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smGUtenti;
        private System.Windows.Forms.ToolStripMenuItem smGAccessi;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}