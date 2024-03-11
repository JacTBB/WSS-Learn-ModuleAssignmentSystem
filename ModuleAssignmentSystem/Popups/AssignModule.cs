using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ModuleAssignmentSystem.Popups
{
    public partial class AssignModule : Form
    {
        private SortableBindingList<Module> Modules;
        private SortableBindingList<Tutor> Tutors;
        private int RowIndex;

        public AssignModule(SortableBindingList<Module> modules, SortableBindingList<Tutor> tutors, int RowIndex)
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

            foreach (Tutor tutor in tutors)
            {
                bool isTutorAssigned = Modules.Any(m => m.tutor == tutor);

                if (!isTutorAssigned)
                {
                    inputAssign.Items.Add(tutor.tutorName);
                }
            }
            if (module.tutor != null)
            {
                inputAssign.SelectedItem = module.tutor.tutorName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            var tutorName = inputAssign.SelectedItem;
            var tutor = Tutors.FirstOrDefault(t => t.tutorName == tutorName);

            var module = Modules[RowIndex];
            module.tutor = tutor;
            Modules.ResetItem(RowIndex);
            this.Close();
        }
    }
}
