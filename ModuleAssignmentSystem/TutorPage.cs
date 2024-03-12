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
    public partial class TutorPage : Form
    {
        public SortableBindingList<Tutor> Tutors;

        public TutorPage(SortableBindingList<Tutor> Tutors)
        {
            InitializeComponent();
            this.Tutors = Tutors;

            moduleTable.DataSource = Tutors;
            moduleTable.AllowUserToAddRows = false;
            moduleTable.MultiSelect = true;
            moduleTable.RowHeadersVisible = false;

            moduleTable.Columns["tutorId"].HeaderText = "Tutor ID";
            moduleTable.Columns["tutorName"].HeaderText = "Tutor Name";
            moduleTable.Columns["email"].HeaderText = "Email";
            moduleTable.Columns["phoneNumber"].HeaderText = "Phone No.";

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";
            moduleTable.Columns.Insert(0, checkBoxColumn);

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

        private void btnAddTutor_Click(object sender, EventArgs e)
        {
            Form popup = new NewTutor(Tutors)
            {
                TopLevel = true,
                AutoScroll = false,
                FormBorderStyle = FormBorderStyle.FixedSingle,
            };
            popup.ShowDialog(this);
        }

        private void btnDeleteTutor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Delete Tutor", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = moduleTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = moduleTable.Rows[i];
                    if (Convert.ToBoolean(row.Cells["checkBoxColumn"].Value) == true)
                    {
                        moduleTable.Rows.Remove(row);
                    }
                }
            }
        }

        private void moduleTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (moduleTable.Columns[e.ColumnIndex].Name == "Edit")
            {
                Form popup = new EditTutor(Tutors, e.RowIndex)
                {
                    TopLevel = true,
                    AutoScroll = false,
                    FormBorderStyle = FormBorderStyle.FixedSingle,
                };
                popup.ShowDialog(this);
            }
            else if (moduleTable.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Confirm?", "Delete Tutor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    moduleTable.Rows.RemoveAt(e.RowIndex);
                }
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
