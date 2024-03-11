namespace ModuleAssignmentSystem
{
    partial class NewModule
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.inputEnd = new System.Windows.Forms.MonthCalendar();
            this.inputStart = new System.Windows.Forms.MonthCalendar();
            this.lblHours = new System.Windows.Forms.Label();
            this.inputHours = new System.Windows.Forms.NumericUpDown();
            this.lblName = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.inputCode = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputHours)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblEnd);
            this.panel1.Controls.Add(this.lblStart);
            this.panel1.Controls.Add(this.inputEnd);
            this.panel1.Controls.Add(this.inputStart);
            this.panel1.Controls.Add(this.lblHours);
            this.panel1.Controls.Add(this.inputHours);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.inputName);
            this.panel1.Controls.Add(this.lblCode);
            this.panel1.Controls.Add(this.inputCode);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 403);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(187, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3);
            this.btnCancel.Size = new System.Drawing.Size(120, 35);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(320, 356);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(3);
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(437, 114);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(63, 16);
            this.lblEnd.TabIndex = 11;
            this.lblEnd.Text = "End Date";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(127, 114);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(66, 16);
            this.lblStart.TabIndex = 10;
            this.lblStart.Text = "Start Date";
            // 
            // inputEnd
            // 
            this.inputEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputEnd.Location = new System.Drawing.Point(317, 133);
            this.inputEnd.Name = "inputEnd";
            this.inputEnd.TabIndex = 9;
            // 
            // inputStart
            // 
            this.inputStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputStart.Location = new System.Drawing.Point(13, 133);
            this.inputStart.Name = "inputStart";
            this.inputStart.TabIndex = 8;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(491, 50);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(77, 16);
            this.lblHours.TabIndex = 6;
            this.lblHours.Text = "Total Hours";
            // 
            // inputHours
            // 
            this.inputHours.Location = new System.Drawing.Point(494, 70);
            this.inputHours.Name = "inputHours";
            this.inputHours.Size = new System.Drawing.Size(105, 22);
            this.inputHours.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(259, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 16);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Module Name";
            // 
            // inputName
            // 
            this.inputName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputName.Location = new System.Drawing.Point(262, 70);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(200, 22);
            this.inputName.TabIndex = 3;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(28, 50);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(88, 16);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Module Code";
            // 
            // inputCode
            // 
            this.inputCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputCode.Location = new System.Drawing.Point(31, 70);
            this.inputCode.Name = "inputCode";
            this.inputCode.Size = new System.Drawing.Size(200, 22);
            this.inputCode.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(265, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(101, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Module";
            // 
            // NewModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 403);
            this.Controls.Add(this.panel1);
            this.Name = "NewModule";
            this.Text = "NewModule";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox inputCode;
        private System.Windows.Forms.MonthCalendar inputStart;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.NumericUpDown inputHours;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.MonthCalendar inputEnd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}