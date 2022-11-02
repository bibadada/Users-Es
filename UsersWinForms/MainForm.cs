using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            ShowLoginUserControl();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowLoginUserControl();
            loginUserControl.LoginSuccesful += LoginSuccessful;
        }

        private void LoginSuccessful(object sender, EventArgs e)
        {
            ShowUtentiUserControl();
        }

        private void ShowLoginUserControl()
        {
            loginUserControl.Visible = true;
            gestioneUtenti.Visible = false;
            logoutMenuItem.Enabled = false;
        }
        private void ShowUtentiUserControl()
        {
            loginUserControl.Visible = false;
            gestioneUtenti.Visible = true;
            logoutMenuItem.Enabled = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Davide Regnani - c 2022");
        }
    }
}
