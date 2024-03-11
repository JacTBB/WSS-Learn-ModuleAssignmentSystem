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
    public partial class MainForm : Form
    {
        Form homePage = new HomePage
        {
            TopLevel = false,
            AutoScroll = true,
            FormBorderStyle = FormBorderStyle.None,
        };
        Form modulePage = new ModulePage
        {
            TopLevel = false,
            AutoScroll = true,
            FormBorderStyle = FormBorderStyle.None,
        };
        Form tutorPage = new TutorPage
        {
            TopLevel = false,
            AutoScroll = true,
            FormBorderStyle = FormBorderStyle.None,
        };
        Form assignmentPage = new AssignmentPage
        {
            TopLevel = false,
            AutoScroll = true,
            FormBorderStyle = FormBorderStyle.None,
        };

        public MainForm()
        {
            InitializeComponent();

            panelMain.Controls.Add(homePage);
            panelMain.Controls.Add(modulePage);
            panelMain.Controls.Add(tutorPage);
            panelMain.Controls.Add(assignmentPage);

            homePage.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            homePage.Show();
            modulePage.Hide();
            tutorPage.Hide();
            assignmentPage.Hide();
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            homePage.Hide();
            modulePage.Show();
            tutorPage.Hide();
            assignmentPage.Hide();
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            homePage.Hide();
            modulePage.Hide();
            tutorPage.Show();
            assignmentPage.Hide();
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            homePage.Hide();
            modulePage.Hide();
            tutorPage.Hide();
            assignmentPage.Show();
        }
    }
}
