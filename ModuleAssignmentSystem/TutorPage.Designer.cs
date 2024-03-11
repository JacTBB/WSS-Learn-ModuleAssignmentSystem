namespace ModuleAssignmentSystem
{
    partial class TutorPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDeleteTutor = new System.Windows.Forms.Button();
            this.btnAddTutor = new System.Windows.Forms.Button();
            this.moduleTable = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.moduleTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(944, 30);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Tutor";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeleteTutor
            // 
            this.btnDeleteTutor.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTutor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTutor.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTutor.Location = new System.Drawing.Point(664, 72);
            this.btnDeleteTutor.Name = "btnDeleteTutor";
            this.btnDeleteTutor.Padding = new System.Windows.Forms.Padding(3);
            this.btnDeleteTutor.Size = new System.Drawing.Size(120, 35);
            this.btnDeleteTutor.TabIndex = 10;
            this.btnDeleteTutor.Text = "Delete";
            this.btnDeleteTutor.UseVisualStyleBackColor = false;
            this.btnDeleteTutor.Click += new System.EventHandler(this.btnDeleteTutor_Click);
            // 
            // btnAddTutor
            // 
            this.btnAddTutor.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTutor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTutor.ForeColor = System.Drawing.Color.White;
            this.btnAddTutor.Location = new System.Drawing.Point(790, 72);
            this.btnAddTutor.Name = "btnAddTutor";
            this.btnAddTutor.Padding = new System.Windows.Forms.Padding(3);
            this.btnAddTutor.Size = new System.Drawing.Size(120, 35);
            this.btnAddTutor.TabIndex = 9;
            this.btnAddTutor.Text = "Add Tutor";
            this.btnAddTutor.UseVisualStyleBackColor = false;
            this.btnAddTutor.Click += new System.EventHandler(this.btnAddTutor_Click);
            // 
            // moduleTable
            // 
            this.moduleTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.moduleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moduleTable.GridColor = System.Drawing.Color.WhiteSmoke;
            this.moduleTable.Location = new System.Drawing.Point(28, 113);
            this.moduleTable.Name = "moduleTable";
            this.moduleTable.RowHeadersWidth = 51;
            this.moduleTable.RowTemplate.Height = 24;
            this.moduleTable.Size = new System.Drawing.Size(882, 202);
            this.moduleTable.TabIndex = 8;
            this.moduleTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.moduleTable_CellContentClick);
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(501, 85);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(55, 20);
            this.lblSearch.TabIndex = 17;
            this.lblSearch.Text = "Search:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // search
            // 
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search.Location = new System.Drawing.Point(558, 81);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 22);
            this.search.TabIndex = 16;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // TutorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 353);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.search);
            this.Controls.Add(this.btnDeleteTutor);
            this.Controls.Add(this.btnAddTutor);
            this.Controls.Add(this.moduleTable);
            this.Controls.Add(this.lblTitle);
            this.Name = "TutorPage";
            this.Text = "TutorPage";
            ((System.ComponentModel.ISupportInitialize)(this.moduleTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDeleteTutor;
        private System.Windows.Forms.Button btnAddTutor;
        private System.Windows.Forms.DataGridView moduleTable;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox search;
    }
}