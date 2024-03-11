namespace ModuleAssignmentSystem
{
    partial class ModulePage
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
            this.moduleTable = new System.Windows.Forms.DataGridView();
            this.btnAddModule = new System.Windows.Forms.Button();
            this.btnDeleteModule = new System.Windows.Forms.Button();
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
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Module";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.moduleTable.TabIndex = 5;
            this.moduleTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.moduleTable_CellContentClick);
            // 
            // btnAddModule
            // 
            this.btnAddModule.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddModule.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddModule.ForeColor = System.Drawing.Color.White;
            this.btnAddModule.Location = new System.Drawing.Point(790, 72);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Padding = new System.Windows.Forms.Padding(3);
            this.btnAddModule.Size = new System.Drawing.Size(120, 35);
            this.btnAddModule.TabIndex = 6;
            this.btnAddModule.Text = "Add Module";
            this.btnAddModule.UseVisualStyleBackColor = false;
            this.btnAddModule.Click += new System.EventHandler(this.btnAddModule_Click);
            // 
            // btnDeleteModule
            // 
            this.btnDeleteModule.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteModule.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteModule.ForeColor = System.Drawing.Color.White;
            this.btnDeleteModule.Location = new System.Drawing.Point(664, 72);
            this.btnDeleteModule.Name = "btnDeleteModule";
            this.btnDeleteModule.Padding = new System.Windows.Forms.Padding(3);
            this.btnDeleteModule.Size = new System.Drawing.Size(120, 35);
            this.btnDeleteModule.TabIndex = 7;
            this.btnDeleteModule.Text = "Delete";
            this.btnDeleteModule.UseVisualStyleBackColor = false;
            this.btnDeleteModule.Click += new System.EventHandler(this.btnDeleteModule_Click);
            // 
            // ModulePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(944, 353);
            this.Controls.Add(this.btnDeleteModule);
            this.Controls.Add(this.btnAddModule);
            this.Controls.Add(this.moduleTable);
            this.Controls.Add(this.lblTitle);
            this.Name = "ModulePage";
            this.Text = "ModulePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.moduleTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView moduleTable;
        private System.Windows.Forms.Button btnAddModule;
        private System.Windows.Forms.Button btnDeleteModule;
    }
}