namespace ResultProcessingApp_Marksheet_
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtObtainedMark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculatePercentageAndGrade = new System.Windows.Forms.Button();
            this.btnAddToMarksheet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMarksheet = new System.Windows.Forms.DataGridView();
            this.s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarksheet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtObtainedMark);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSubjectName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtRollNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtStudentName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 85);
            this.panel1.TabIndex = 34;
            // 
            // txtObtainedMark
            // 
            this.txtObtainedMark.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObtainedMark.Location = new System.Drawing.Point(436, 43);
            this.txtObtainedMark.Name = "txtObtainedMark";
            this.txtObtainedMark.Size = new System.Drawing.Size(71, 29);
            this.txtObtainedMark.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Obtained Marks:";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectName.Location = new System.Drawing.Point(134, 45);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(152, 29);
            this.txtSubjectName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Subject Name:";
            // 
            // txtRollNo
            // 
            this.txtRollNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRollNo.Location = new System.Drawing.Point(436, 6);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(71, 29);
            this.txtRollNo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Roll No.:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(137, 6);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(190, 29);
            this.txtStudentName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.BackColor = System.Drawing.Color.Gainsboro;
            this.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrade.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(410, 419);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(56, 32);
            this.lblGrade.TabIndex = 33;
            this.lblGrade.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(322, 419);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 30);
            this.label10.TabIndex = 32;
            this.label10.Text = "GRADE:";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPercentage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(169, 419);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(27, 32);
            this.lblPercentage.TabIndex = 31;
            this.lblPercentage.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 30);
            this.label7.TabIndex = 30;
            this.label7.Text = "PERCENTAGE:";
            // 
            // btnCalculatePercentageAndGrade
            // 
            this.btnCalculatePercentageAndGrade.BackColor = System.Drawing.Color.White;
            this.btnCalculatePercentageAndGrade.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatePercentageAndGrade.Location = new System.Drawing.Point(224, 161);
            this.btnCalculatePercentageAndGrade.Name = "btnCalculatePercentageAndGrade";
            this.btnCalculatePercentageAndGrade.Size = new System.Drawing.Size(309, 40);
            this.btnCalculatePercentageAndGrade.TabIndex = 29;
            this.btnCalculatePercentageAndGrade.Text = "Calculate Percentage and Grade";
            this.btnCalculatePercentageAndGrade.UseVisualStyleBackColor = false;
            this.btnCalculatePercentageAndGrade.Click += new System.EventHandler(this.btnCalculatePercentageAndGrade_Click);
            // 
            // btnAddToMarksheet
            // 
            this.btnAddToMarksheet.BackColor = System.Drawing.Color.White;
            this.btnAddToMarksheet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToMarksheet.Location = new System.Drawing.Point(16, 161);
            this.btnAddToMarksheet.Name = "btnAddToMarksheet";
            this.btnAddToMarksheet.Size = new System.Drawing.Size(181, 40);
            this.btnAddToMarksheet.TabIndex = 28;
            this.btnAddToMarksheet.Text = "Add to Marksheet";
            this.btnAddToMarksheet.UseVisualStyleBackColor = false;
            this.btnAddToMarksheet.Click += new System.EventHandler(this.btnAddToMarksheet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 39);
            this.label1.TabIndex = 27;
            this.label1.Text = "ISMT RESULT PROCESSING SOFTWARE";
            // 
            // dgvMarksheet
            // 
            this.dgvMarksheet.AllowUserToAddRows = false;
            this.dgvMarksheet.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMarksheet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMarksheet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarksheet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMarksheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarksheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.s,
            this.sn,
            this.f,
            this.p,
            this.o,
            this.stat});
            this.dgvMarksheet.Location = new System.Drawing.Point(16, 217);
            this.dgvMarksheet.Name = "dgvMarksheet";
            this.dgvMarksheet.ReadOnly = true;
            this.dgvMarksheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarksheet.Size = new System.Drawing.Size(517, 181);
            this.dgvMarksheet.TabIndex = 35;
            // 
            // s
            // 
            this.s.HeaderText = "S.No.";
            this.s.Name = "s";
            this.s.ReadOnly = true;
            // 
            // sn
            // 
            this.sn.HeaderText = "Subject Name";
            this.sn.Name = "sn";
            this.sn.ReadOnly = true;
            // 
            // f
            // 
            this.f.HeaderText = "Full Mark";
            this.f.Name = "f";
            this.f.ReadOnly = true;
            // 
            // p
            // 
            this.p.HeaderText = "Pass Mark";
            this.p.Name = "p";
            this.p.ReadOnly = true;
            // 
            // o
            // 
            this.o.HeaderText = "Obtained Mark";
            this.o.Name = "o";
            this.o.ReadOnly = true;
            // 
            // stat
            // 
            this.stat.HeaderText = "Status";
            this.stat.Name = "stat";
            this.stat.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalculatePercentageAndGrade);
            this.Controls.Add(this.btnAddToMarksheet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMarksheet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarksheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtObtainedMark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculatePercentageAndGrade;
        private System.Windows.Forms.Button btnAddToMarksheet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMarksheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn s;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn f;
        private System.Windows.Forms.DataGridViewTextBoxColumn p;
        private System.Windows.Forms.DataGridViewTextBoxColumn o;
        private System.Windows.Forms.DataGridViewTextBoxColumn stat;
    }
}

