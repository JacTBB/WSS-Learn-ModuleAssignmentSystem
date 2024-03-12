using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuleAssignmentSystem
{
    public partial class LoginForm : Form
    {
        private MainForm MainForm;

        public LoginForm()
        {
            InitializeComponent();
            this.MainForm = new MainForm(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = inputUsername.Text;
            var password = inputPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Empty Credentials", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (username != "admin" || password != "123")
            {
                MessageBox.Show("Wrong Credentials", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MainForm.Show();
            this.Hide();
        }
    }
}
