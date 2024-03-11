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
    public partial class EditModule : Form
    {
        private SortableBindingList<Module> Modules;
        private int RowIndex;

        public EditModule(SortableBindingList<Module> Modules, int RowIndex)
        {
            InitializeComponent();
            this.Modules = Modules;
            this.RowIndex = RowIndex;

            Module module = Modules[RowIndex];
            inputCode.Text = module.moduleCode;
            inputName.Text = module.moduleName;
            inputHours.Text = module.totalHours.ToString();
            inputStart.SelectionStart = module.startDate;
            inputEnd.SelectionEnd = module.endDate;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var moduleCode = inputCode.Text;
            var moduleName = inputName.Text;
            var totalHours = inputHours.Text;
            var startDate = inputStart.SelectionStart;
            var endDate = inputEnd.SelectionEnd;

            // var Message = $"{moduleCode} \n {moduleName} \n {totalHours} \n {startDate} \n {endDate}";
            // MessageBox.Show($"{Message}", "Module Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var module = new Module
            {
                moduleCode = moduleCode,
                moduleName = moduleName,
                totalHours = int.Parse(totalHours),
                startDate = startDate,
                endDate = endDate,
            };
            Modules.RemoveAt(RowIndex);
            Modules.Add(module);
            this.Close();
        }
    }
}
