namespace ModuleAssignmentSystem.Popups
{
    partial class AssignModule
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupTutor = new System.Windows.Forms.GroupBox();
            this.inputAssign = new System.Windows.Forms.ComboBox();
            this.lblAssign = new System.Windows.Forms.Label();
            this.groupModule = new System.Windows.Forms.GroupBox();
            this.outEnd = new System.Windows.Forms.Label();
            this.outStart = new System.Windows.Forms.Label();
            this.outHours = new System.Windows.Forms.Label();
            this.outName = new System.Windows.Forms.Label();
            this.outCode = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupTutor.SuspendLayout();
            this.groupModule.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupTutor);
            this.panel1.Controls.Add(this.groupModule);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAssign);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 303);
            this.panel1.TabIndex = 3;
            // 
            // groupTutor
            // 
            this.groupTutor.Controls.Add(this.inputAssign);
            this.groupTutor.Controls.Add(this.lblAssign);
            this.groupTutor.Location = new System.Drawing.Point(320, 69);
            this.groupTutor.Name = "groupTutor";
            this.groupTutor.Size = new System.Drawing.Size(277, 156);
            this.groupTutor.TabIndex = 16;
            this.groupTutor.TabStop = false;
            this.groupTutor.Text = "Tutor";
            // 
            // inputAssign
            // 
            this.inputAssign.FormattingEnabled = true;
            this.inputAssign.Location = new System.Drawing.Point(25, 63);
            this.inputAssign.Name = "inputAssign";
            this.inputAssign.Size = new System.Drawing.Size(154, 24);
            this.inputAssign.TabIndex = 1;
            // 
            // lblAssign
            // 
            this.lblAssign.AutoSize = true;
            this.lblAssign.Location = new System.Drawing.Point(22, 44);
            this.lblAssign.Name = "lblAssign";
            this.lblAssign.Size = new System.Drawing.Size(82, 16);
            this.lblAssign.TabIndex = 0;
            this.lblAssign.Text = "Assign Tutor";
            // 
            // groupModule
            // 
            this.groupModule.Controls.Add(this.outEnd);
            this.groupModule.Controls.Add(this.outStart);
            this.groupModule.Controls.Add(this.outHours);
            this.groupModule.Controls.Add(this.outName);
            this.groupModule.Controls.Add(this.outCode);
            this.groupModule.Controls.Add(this.lblEnd);
            this.groupModule.Controls.Add(this.lblStart);
            this.groupModule.Controls.Add(this.lblHours);
            this.groupModule.Controls.Add(this.lblName);
            this.groupModule.Controls.Add(this.lblCode);
            this.groupModule.Location = new System.Drawing.Point(30, 69);
            this.groupModule.Name = "groupModule";
            this.groupModule.Size = new System.Drawing.Size(277, 156);
            this.groupModule.TabIndex = 15;
            this.groupModule.TabStop = false;
            this.groupModule.Text = "Module";
            // 
            // outEnd
            // 
            this.outEnd.AutoSize = true;
            this.outEnd.Location = new System.Drawing.Point(110, 106);
            this.outEnd.Name = "outEnd";
            this.outEnd.Size = new System.Drawing.Size(66, 16);
            this.outEnd.TabIndex = 9;
            this.outEnd.Text = "End Date:";
            // 
            // outStart
            // 
            this.outStart.AutoSize = true;
            this.outStart.Location = new System.Drawing.Point(110, 87);
            this.outStart.Name = "outStart";
            this.outStart.Size = new System.Drawing.Size(69, 16);
            this.outStart.TabIndex = 8;
            this.outStart.Text = "Start Date:";
            // 
            // outHours
            // 
            this.outHours.AutoSize = true;
            this.outHours.Location = new System.Drawing.Point(110, 68);
            this.outHours.Name = "outHours";
            this.outHours.Size = new System.Drawing.Size(80, 16);
            this.outHours.TabIndex = 7;
            this.outHours.Text = "Total Hours:";
            // 
            // outName
            // 
            this.outName.AutoSize = true;
            this.outName.Location = new System.Drawing.Point(110, 49);
            this.outName.Name = "outName";
            this.outName.Size = new System.Drawing.Size(95, 16);
            this.outName.TabIndex = 6;
            this.outName.Text = "Module Name:";
            // 
            // outCode
            // 
            this.outCode.AutoSize = true;
            this.outCode.Location = new System.Drawing.Point(110, 30);
            this.outCode.Name = "outCode";
            this.outCode.Size = new System.Drawing.Size(91, 16);
            this.outCode.TabIndex = 5;
            this.outCode.Text = "Module Code:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(13, 106);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(66, 16);
            this.lblEnd.TabIndex = 4;
            this.lblEnd.Text = "End Date:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(13, 87);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(69, 16);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "Start Date:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(13, 68);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(80, 16);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Total Hours:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Module Name:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(13, 30);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(91, 16);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Module Code:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(187, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3);
            this.btnCancel.Size = new System.Drawing.Size(120, 35);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(320, 244);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Padding = new System.Windows.Forms.Padding(3);
            this.btnAssign.Size = new System.Drawing.Size(120, 35);
            this.btnAssign.TabIndex = 13;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(235, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Module Assignment";
            // 
            // AssignModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 303);
            this.Controls.Add(this.panel1);
            this.Name = "AssignModule";
            this.Text = "AssignModule";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupTutor.ResumeLayout(false);
            this.groupTutor.PerformLayout();
            this.groupModule.ResumeLayout(false);
            this.groupModule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupModule;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupTutor;
        private System.Windows.Forms.ComboBox inputAssign;
        private System.Windows.Forms.Label lblAssign;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label outEnd;
        private System.Windows.Forms.Label outStart;
        private System.Windows.Forms.Label outHours;
        private System.Windows.Forms.Label outName;
        private System.Windows.Forms.Label outCode;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblName;
    }
}