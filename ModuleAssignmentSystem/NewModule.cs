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
    public partial class NewModule : Form
    {
        private BindingList<Module> Modules;

        public NewModule(BindingList<Module> Modules)
        {
            InitializeComponent();
            this.Modules = Modules;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            Modules.Add(module);
            this.Close();
        }
    }
}
