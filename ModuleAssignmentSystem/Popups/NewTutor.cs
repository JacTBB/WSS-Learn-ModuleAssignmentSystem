using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Configuration;

namespace ModuleAssignmentSystem
{
    public partial class NewTutor : Form
    {
        private SortableBindingList<Tutor> Tutors;

        public NewTutor(SortableBindingList<Tutor> Tutors)
        {
            InitializeComponent();
            this.Tutors = Tutors;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var tutorId = inputId.Text;
            var tutorName = inputName.Text;
            var email = inputEmail.Text;
            var phoneNumber = inputPhoneNumber.Text;

            var tutor = new Tutor
            {
                tutorId = tutorId,
                tutorName = tutorName,
                email = email,
                phoneNumber = phoneNumber
            };
            Tutors.Add(tutor);
            this.Close();
        }
    }
}
