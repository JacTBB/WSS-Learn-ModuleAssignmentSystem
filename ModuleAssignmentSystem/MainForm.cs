using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuleAssignmentSystem
{
    public partial class MainForm : Form
    {
        public static SortableBindingList<Module> Modules { get; set; } = new SortableBindingList<Module>();
        public static SortableBindingList<Tutor> Tutors { get; set; } = new SortableBindingList<Tutor>();

        private void InitModules()
        {
            Modules.Add(new Module
            {
                moduleCode = "IT1154",
                moduleName = "Web Dev",
                totalHours = 60,
                startDate = DateTime.Now,
                endDate = DateTime.Now,
            });

            Modules.Add(new Module
            {
                moduleCode = "IT1166",
                moduleName = "App Dev Proj",
                totalHours = 60,
                startDate = DateTime.Now,
                endDate = DateTime.Now,
            });
        }

        private void InitTutors()
        {
            Tutors.Add(new Tutor
            {
                tutorId = "ID123",
                tutorName = "Tutor 1",
                email = "Tutor1@nyp.edu.sg",
                phoneNumber = "12345678"
            });

            Tutors.Add(new Tutor
            {
                tutorId = "ID123",
                tutorName = "Tutor 2",
                email = "Tutor2@nyp.edu.sg",
                phoneNumber = "87654321"
            });
        }

        Form homePage = new HomePage
        {
            TopLevel = false,
            AutoScroll = true,
            FormBorderStyle = FormBorderStyle.None,
        };
        Form modulePage = new ModulePage(Modules)
        {
            TopLevel = false,
            AutoScroll = true,
            FormBorderStyle = FormBorderStyle.None,
        };
        Form tutorPage = new TutorPage(Tutors)
        {
            TopLevel = false,
            AutoScroll = true,
            FormBorderStyle = FormBorderStyle.None,
        };
        Form assignmentPage = new AssignmentPage(Modules, Tutors)
        {
            TopLevel = false,
            AutoScroll = true,
            FormBorderStyle = FormBorderStyle.None,
        };

        public MainForm()
        {
            InitModules();
            InitTutors();
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
