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
    public partial class AssignmentPage : Form
    {
        public BindingList<Module> Modules { get; set; } = new BindingList<Module>();

        public AssignmentPage()
        {
            InitializeComponent();

            // Modules = ModulePage

            // moduleTable.DataSource = Modules;
            moduleTable.AllowUserToAddRows = false;

            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            moduleTable.Columns.Add(editButtonColumn);

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            moduleTable.Columns.Add(deleteButtonColumn);
        }
    }
}
