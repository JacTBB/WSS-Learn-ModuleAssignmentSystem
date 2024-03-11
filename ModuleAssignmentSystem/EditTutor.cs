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
    public partial class EditTutor : Form
    {
        private BindingList<Tutor> Tutors;
        private int RowIndex;

        public EditTutor(BindingList<Tutor> Tutors, int RowIndex)
        {
            InitializeComponent();
            this.Tutors = Tutors;
            this.RowIndex = RowIndex;

            Tutor tutor = Tutors[RowIndex];
            inputId.Text = tutor.tutorId;
            inputName.Text = tutor.tutorName;
            inputEmail.Text = tutor.email;
            inputPhoneNumber.Text = tutor.phoneNumber;
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

            // var Message = $"{tutorId} \n {tutorName} \n {email} \n {phoneNumber}";
            // MessageBox.Show($"{Message}", "Module Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var tutor = new Tutor
            {
                tutorId = tutorId,
                tutorName = tutorName,
                email = email,
                phoneNumber = phoneNumber
            };
            Tutors.RemoveAt(RowIndex);
            Tutors.Add(tutor);
            this.Close();
        }   
    }
}
