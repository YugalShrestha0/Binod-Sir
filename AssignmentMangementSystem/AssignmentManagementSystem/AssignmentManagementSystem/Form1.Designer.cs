namespace AssignmentManagementSystem
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enroolmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assigmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assigmentReleaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentHandoverToTeachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedAssignmentFromTeachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblDateTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 689);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(1170, 10);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(133, 20);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "Date And Time:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.enroolmentToolStripMenuItem,
            this.assigmentToolStripMenuItem,
            this.feedbackToolStripMenuItem,
            this.resultToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.teachersToolStripMenuItem,
            this.programToolStripMenuItem,
            this.semesterToolStripMenuItem,
            this.batchToolStripMenuItem,
            this.subjectToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // teachersToolStripMenuItem
            // 
            this.teachersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("teachersToolStripMenuItem.Image")));
            this.teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            this.teachersToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.teachersToolStripMenuItem.Text = "Teachers";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // semesterToolStripMenuItem
            // 
            this.semesterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("semesterToolStripMenuItem.Image")));
            this.semesterToolStripMenuItem.Name = "semesterToolStripMenuItem";
            this.semesterToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.semesterToolStripMenuItem.Text = "Semester";
            // 
            // batchToolStripMenuItem
            // 
            this.batchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("batchToolStripMenuItem.Image")));
            this.batchToolStripMenuItem.Name = "batchToolStripMenuItem";
            this.batchToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.batchToolStripMenuItem.Text = "Batch";
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("subjectToolStripMenuItem.Image")));
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.subjectToolStripMenuItem.Text = "Subjects";
            this.subjectToolStripMenuItem.Click += new System.EventHandler(this.subjectToolStripMenuItem_Click);
            // 
            // enroolmentToolStripMenuItem
            // 
            this.enroolmentToolStripMenuItem.Name = "enroolmentToolStripMenuItem";
            this.enroolmentToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.enroolmentToolStripMenuItem.Text = "Enrollment";
            // 
            // assigmentToolStripMenuItem
            // 
            this.assigmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assignmentEntryToolStripMenuItem,
            this.assigmentReleaseToolStripMenuItem,
            this.assignmentReceiptToolStripMenuItem,
            this.assignmentHandoverToTeachersToolStripMenuItem,
            this.receivedAssignmentFromTeachersToolStripMenuItem});
            this.assigmentToolStripMenuItem.Name = "assigmentToolStripMenuItem";
            this.assigmentToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.assigmentToolStripMenuItem.Text = "Assignment";
            // 
            // assignmentEntryToolStripMenuItem
            // 
            this.assignmentEntryToolStripMenuItem.Name = "assignmentEntryToolStripMenuItem";
            this.assignmentEntryToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.assignmentEntryToolStripMenuItem.Text = "Assignment Entry";
            // 
            // assigmentReleaseToolStripMenuItem
            // 
            this.assigmentReleaseToolStripMenuItem.Name = "assigmentReleaseToolStripMenuItem";
            this.assigmentReleaseToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.assigmentReleaseToolStripMenuItem.Text = "Assigment Release";
            // 
            // assignmentReceiptToolStripMenuItem
            // 
            this.assignmentReceiptToolStripMenuItem.Name = "assignmentReceiptToolStripMenuItem";
            this.assignmentReceiptToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.assignmentReceiptToolStripMenuItem.Text = "Assignment Receipt";
            // 
            // assignmentHandoverToTeachersToolStripMenuItem
            // 
            this.assignmentHandoverToTeachersToolStripMenuItem.Name = "assignmentHandoverToTeachersToolStripMenuItem";
            this.assignmentHandoverToTeachersToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.assignmentHandoverToTeachersToolStripMenuItem.Text = "Assignment Handover To Teachers";
            // 
            // receivedAssignmentFromTeachersToolStripMenuItem
            // 
            this.receivedAssignmentFromTeachersToolStripMenuItem.Name = "receivedAssignmentFromTeachersToolStripMenuItem";
            this.receivedAssignmentFromTeachersToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.receivedAssignmentFromTeachersToolStripMenuItem.Text = "Received Assignment From Teachers";
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.feedbackToolStripMenuItem.Text = "Feedback";
            // 
            // resultToolStripMenuItem
            // 
            this.resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            this.resultToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.resultToolStripMenuItem.Text = "Result";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentReportToolStripMenuItem,
            this.teacherReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // studentReportToolStripMenuItem
            // 
            this.studentReportToolStripMenuItem.Name = "studentReportToolStripMenuItem";
            this.studentReportToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.studentReportToolStripMenuItem.Text = "Student Report";
            // 
            // teacherReportToolStripMenuItem
            // 
            this.teacherReportToolStripMenuItem.Name = "teacherReportToolStripMenuItem";
            this.teacherReportToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.teacherReportToolStripMenuItem.Text = "Teacher Report";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Assignment Mangement System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enroolmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assigmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignmentEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assigmentReleaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignmentReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignmentHandoverToTeachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receivedAssignmentFromTeachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherReportToolStripMenuItem;
    }
}

