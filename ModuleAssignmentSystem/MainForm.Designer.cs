namespace ModuleAssignmentSystem
{
    partial class MainForm
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
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnAssignment = new System.Windows.Forms.Button();
            this.btnTutor = new System.Windows.Forms.Button();
            this.btnModule = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelOuter = new System.Windows.Forms.Panel();
            this.panelNav.SuspendLayout();
            this.panelOuter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNav.Controls.Add(this.btnProfile);
            this.panelNav.Controls.Add(this.btnAssignment);
            this.panelNav.Controls.Add(this.btnTutor);
            this.panelNav.Controls.Add(this.btnModule);
            this.panelNav.Controls.Add(this.btnHome);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(982, 50);
            this.panelNav.TabIndex = 0;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(782, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(200, 50);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Welcome, User 1";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnAssignment
            // 
            this.btnAssignment.BackColor = System.Drawing.Color.Transparent;
            this.btnAssignment.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAssignment.FlatAppearance.BorderSize = 0;
            this.btnAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignment.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignment.ForeColor = System.Drawing.Color.White;
            this.btnAssignment.Location = new System.Drawing.Point(300, 0);
            this.btnAssignment.Name = "btnAssignment";
            this.btnAssignment.Size = new System.Drawing.Size(250, 50);
            this.btnAssignment.TabIndex = 3;
            this.btnAssignment.Text = "Module Assignment";
            this.btnAssignment.UseVisualStyleBackColor = false;
            this.btnAssignment.Click += new System.EventHandler(this.btnAssignment_Click);
            // 
            // btnTutor
            // 
            this.btnTutor.BackColor = System.Drawing.Color.Transparent;
            this.btnTutor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTutor.FlatAppearance.BorderSize = 0;
            this.btnTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutor.ForeColor = System.Drawing.Color.White;
            this.btnTutor.Location = new System.Drawing.Point(200, 0);
            this.btnTutor.Name = "btnTutor";
            this.btnTutor.Size = new System.Drawing.Size(100, 50);
            this.btnTutor.TabIndex = 2;
            this.btnTutor.Text = "Tutor";
            this.btnTutor.UseVisualStyleBackColor = false;
            this.btnTutor.Click += new System.EventHandler(this.btnTutor_Click);
            // 
            // btnModule
            // 
            this.btnModule.BackColor = System.Drawing.Color.Transparent;
            this.btnModule.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModule.FlatAppearance.BorderSize = 0;
            this.btnModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModule.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModule.ForeColor = System.Drawing.Color.White;
            this.btnModule.Location = new System.Drawing.Point(100, 0);
            this.btnModule.Name = "btnModule";
            this.btnModule.Size = new System.Drawing.Size(100, 50);
            this.btnModule.TabIndex = 1;
            this.btnModule.Text = "Module";
            this.btnModule.UseVisualStyleBackColor = false;
            this.btnModule.Click += new System.EventHandler(this.btnModule_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 50);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(20, 20);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelMain.Size = new System.Drawing.Size(942, 380);
            this.panelMain.TabIndex = 2;
            // 
            // panelOuter
            // 
            this.panelOuter.Controls.Add(this.panelMain);
            this.panelOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOuter.Location = new System.Drawing.Point(0, 50);
            this.panelOuter.Name = "panelOuter";
            this.panelOuter.Padding = new System.Windows.Forms.Padding(20);
            this.panelOuter.Size = new System.Drawing.Size(982, 420);
            this.panelOuter.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 470);
            this.Controls.Add(this.panelOuter);
            this.Controls.Add(this.panelNav);
            this.Name = "MainForm";
            this.Text = "MainPage";
            this.panelNav.ResumeLayout(false);
            this.panelOuter.ResumeLayout(false);
            this.panelOuter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnAssignment;
        private System.Windows.Forms.Button btnTutor;
        private System.Windows.Forms.Button btnModule;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelOuter;
    }
}