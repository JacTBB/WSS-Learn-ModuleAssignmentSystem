namespace ModuleAssignmentSystem
{
    partial class AssignmentPage
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
            this.btnUnassign = new System.Windows.Forms.Button();
            this.moduleTable = new System.Windows.Forms.DataGridView();
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
            this.lblTitle.Text = " Assignment";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUnassign
            // 
            this.btnUnassign.BackColor = System.Drawing.Color.IndianRed;
            this.btnUnassign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnassign.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnassign.ForeColor = System.Drawing.Color.White;
            this.btnUnassign.Location = new System.Drawing.Point(790, 72);
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.Padding = new System.Windows.Forms.Padding(3);
            this.btnUnassign.Size = new System.Drawing.Size(120, 35);
            this.btnUnassign.TabIndex = 13;
            this.btnUnassign.Text = "Unassign";
            this.btnUnassign.UseVisualStyleBackColor = false;
            this.btnUnassign.Click += new System.EventHandler(this.btnUnassign_Click);
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
            this.moduleTable.TabIndex = 11;
            this.moduleTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.moduleTable_CellContentClick);
            // 
            // AssignmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 353);
            this.Controls.Add(this.btnUnassign);
            this.Controls.Add(this.moduleTable);
            this.Controls.Add(this.lblTitle);
            this.Name = "AssignmentPage";
            this.Text = "AssignmentPage";
            ((System.ComponentModel.ISupportInitialize)(this.moduleTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnUnassign;
        private System.Windows.Forms.DataGridView moduleTable;
    }
}