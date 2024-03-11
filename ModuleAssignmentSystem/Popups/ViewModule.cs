using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuleAssignmentSystem.Popups
{
    public partial class ViewModule : Form
    {
        private BindingList<Module> Modules;
        private BindingList<Tutor> Tutors;
        private int RowIndex;

        public ViewModule(BindingList<Module> modules, BindingList<Tutor> tutors, int RowIndex)
        {
            InitializeComponent();
            this.Modules = modules;
            this.Tutors = tutors;
            this.RowIndex = RowIndex;

            Module module = Modules[RowIndex];
            outCode.Text = module.moduleCode;
            outName.Text = module.moduleName;
            outHours.Text = module.totalHours.ToString();
            outStart.Text = module.startDate.ToString();
            outEnd.Text = module.endDate.ToString();

            outId.Text = module.tutor?.tutorId;
            outTName.Text = module.tutor?.tutorName;
            outEmail.Text = module.tutor?.email;
            outPhone.Text = module.tutor?.phoneNumber;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
