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
    public partial class ModulePage : Form
    {
        public List<Module> Modules { get; set; }

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

        public ModulePage()
        {
            InitializeComponent();

            Modules = new List<Module>();
            InitModules();

            moduleTable.DataSource = Modules;
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            Form popup = new NewModule
            {
                TopLevel = true,
                AutoScroll = false,
                FormBorderStyle = FormBorderStyle.FixedSingle,
            };
            popup.ShowDialog(this);
        }
    }
}
