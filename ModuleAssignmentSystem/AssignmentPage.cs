using ModuleAssignmentSystem.Popups;
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
        public SortableBindingList<Module> Modules;
        public SortableBindingList<Tutor> Tutors;

        public AssignmentPage(SortableBindingList<Module> Modules, SortableBindingList<Tutor> Tutors)
        {
            InitializeComponent();
            this.Modules = Modules;
            this.Tutors = Tutors;

            moduleTable.DataSource = Modules;
            moduleTable.AllowUserToAddRows = false;
            moduleTable.MultiSelect = true;
            moduleTable.Columns["totalHours"].Visible = false;
            moduleTable.Columns["startDate"].Visible = false;
            moduleTable.Columns["endDate"].Visible = false;
            moduleTable.Columns["tutor"].Visible = false;

            moduleTable.Columns["moduleCode"].HeaderText = "Module Code";
            moduleTable.Columns["moduleName"].HeaderText = "Module Name";
            moduleTable.Columns["tutorName"].HeaderText = "Tutor";

            DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
            viewButtonColumn.Name = "View";
            viewButtonColumn.Text = "View";
            viewButtonColumn.UseColumnTextForButtonValue = true;
            moduleTable.Columns.Add(viewButtonColumn);

            DataGridViewButtonColumn assignButtonColumn = new DataGridViewButtonColumn();
            assignButtonColumn.Name = "Assign";
            assignButtonColumn.Text = "Assign";
            assignButtonColumn.UseColumnTextForButtonValue = true;
            moduleTable.Columns.Add(assignButtonColumn);
        }

        private void btnUnassign_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Unassign Tutor", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewCell cell in moduleTable.SelectedCells)
                {
                    var rowIndex = cell.RowIndex;
                    Module module = Modules[rowIndex];
                    module.tutor = null;
                    Modules.ResetItem(rowIndex);
                }
            }
        }

        private void moduleTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (moduleTable.Columns[e.ColumnIndex].Name == "View")
            {
                Form popup = new ViewModule(Modules, Tutors, e.RowIndex)
                {
                    TopLevel = true,
                    AutoScroll = false,
                    FormBorderStyle = FormBorderStyle.FixedSingle,
                };
                popup.ShowDialog(this);
            }
            else if (moduleTable.Columns[e.ColumnIndex].Name == "Assign")
            {
                Form popup = new AssignModule(Modules, Tutors, e.RowIndex)
                {
                    TopLevel = true,
                    AutoScroll = false,
                    FormBorderStyle = FormBorderStyle.FixedSingle,
                };
                popup.ShowDialog(this);
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in moduleTable.Rows)
            {
                if (row.Index < 0) return;
                row.Selected = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if ((cell.ValueType == typeof(string) || cell.ValueType == typeof(int)) && cell.Value != null)
                    {
                        string CellValue = cell.Value.ToString();
                        if (CellValue.StartsWith(search.Text, StringComparison.CurrentCultureIgnoreCase) && !string.IsNullOrEmpty(search.Text))
                        {
                            row.Selected = true;
                        }
                    }
                }
            }
        }
    }
}
