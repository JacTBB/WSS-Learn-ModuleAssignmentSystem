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
        public SortableBindingList<Module> Modules;

        public ModulePage(SortableBindingList<Module> Modules)
        {
            InitializeComponent();
            this.Modules = Modules;

            moduleTable.DataSource = Modules;
            moduleTable.AllowUserToAddRows = false;
            moduleTable.Columns["tutor"].Visible = false;
            moduleTable.Columns["tutorName"].Visible = false;

            moduleTable.Columns["moduleCode"].HeaderText = "Module Code";
            moduleTable.Columns["moduleName"].HeaderText = "Module Name";
            moduleTable.Columns["totalHours"].HeaderText = "Total Hours";
            moduleTable.Columns["startDate"].HeaderText = "Start Date";
            moduleTable.Columns["endDate"].HeaderText = "End Date";

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

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            Form popup = new NewModule(Modules)
            {
                TopLevel = true,
                AutoScroll = false,
                FormBorderStyle = FormBorderStyle.FixedSingle,
            };
            popup.ShowDialog(this);
        }

        private void btnDeleteModule_Click(object sender, EventArgs e)
        {
            int rowIndex = moduleTable.CurrentCell.RowIndex;
            if (MessageBox.Show("Confirm?", "Delete Module", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                moduleTable.Rows.RemoveAt(rowIndex);
            }
        }

        private void moduleTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (moduleTable.Columns[e.ColumnIndex].Name == "Edit")
            {
                Form popup = new EditModule(Modules, e.RowIndex)
                {
                    TopLevel = true,
                    AutoScroll = false,
                    FormBorderStyle = FormBorderStyle.FixedSingle,
                };
                popup.ShowDialog(this);
            }
            else if (moduleTable.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Confirm?", "Delete Module", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    moduleTable.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
