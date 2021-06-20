
namespace AssignmentEntrySystem
{
    partial class AssignmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignmentForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnACreate = new System.Windows.Forms.Button();
            this.btnAEdit = new System.Windows.Forms.Button();
            this.btnADelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbAProgram = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAssignmentTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbASubjectName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpSubmittedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRealeaseDate = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvAssignmentDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignmentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "ASSIGNMENT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(494, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 40);
            this.panel2.TabIndex = 28;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Location = new System.Drawing.Point(1, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnACreate
            // 
            this.btnACreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnACreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnACreate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnACreate.Location = new System.Drawing.Point(0, 2);
            this.btnACreate.Name = "btnACreate";
            this.btnACreate.Size = new System.Drawing.Size(123, 48);
            this.btnACreate.TabIndex = 2;
            this.btnACreate.Text = "CREATE";
            this.btnACreate.UseVisualStyleBackColor = false;
            this.btnACreate.Click += new System.EventHandler(this.btnACreate_Click);
            // 
            // btnAEdit
            // 
            this.btnAEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAEdit.Location = new System.Drawing.Point(0, 48);
            this.btnAEdit.Name = "btnAEdit";
            this.btnAEdit.Size = new System.Drawing.Size(123, 48);
            this.btnAEdit.TabIndex = 3;
            this.btnAEdit.Text = "EDIT";
            this.btnAEdit.UseVisualStyleBackColor = false;
            this.btnAEdit.Click += new System.EventHandler(this.btnAEdit_Click);
            // 
            // btnADelete
            // 
            this.btnADelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnADelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnADelete.Location = new System.Drawing.Point(0, 94);
            this.btnADelete.Name = "btnADelete";
            this.btnADelete.Size = new System.Drawing.Size(123, 48);
            this.btnADelete.TabIndex = 4;
            this.btnADelete.Text = "DELETE";
            this.btnADelete.UseVisualStyleBackColor = false;
            this.btnADelete.Click += new System.EventHandler(this.btnADelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.cmbAProgram);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 40);
            this.panel1.TabIndex = 29;
            // 
            // cmbAProgram
            // 
            this.cmbAProgram.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAProgram.FormattingEnabled = true;
            this.cmbAProgram.Location = new System.Drawing.Point(165, 6);
            this.cmbAProgram.Name = "cmbAProgram";
            this.cmbAProgram.Size = new System.Drawing.Size(301, 28);
            this.cmbAProgram.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Program:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 21);
            this.label6.TabIndex = 53;
            this.label6.Text = "Submitted Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 52;
            this.label5.Text = "Release Date:";
            // 
            // txtAssignmentTitle
            // 
            this.txtAssignmentTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignmentTitle.Location = new System.Drawing.Point(165, 42);
            this.txtAssignmentTitle.Name = "txtAssignmentTitle";
            this.txtAssignmentTitle.Size = new System.Drawing.Size(301, 27);
            this.txtAssignmentTitle.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 50;
            this.label4.Text = "Assignment Title:";
            // 
            // cmbASubjectName
            // 
            this.cmbASubjectName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbASubjectName.FormattingEnabled = true;
            this.cmbASubjectName.Location = new System.Drawing.Point(165, 9);
            this.cmbASubjectName.Name = "cmbASubjectName";
            this.cmbASubjectName.Size = new System.Drawing.Size(301, 28);
            this.cmbASubjectName.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "Subject Name:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.dtpSubmittedDate);
            this.panel3.Controls.Add(this.dtpRealeaseDate);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cmbASubjectName);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtAssignmentTitle);
            this.panel3.Location = new System.Drawing.Point(12, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 145);
            this.panel3.TabIndex = 55;
            // 
            // dtpSubmittedDate
            // 
            this.dtpSubmittedDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSubmittedDate.Location = new System.Drawing.Point(165, 107);
            this.dtpSubmittedDate.Name = "dtpSubmittedDate";
            this.dtpSubmittedDate.Size = new System.Drawing.Size(301, 27);
            this.dtpSubmittedDate.TabIndex = 55;
            // 
            // dtpRealeaseDate
            // 
            this.dtpRealeaseDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRealeaseDate.Location = new System.Drawing.Point(165, 74);
            this.dtpRealeaseDate.Name = "dtpRealeaseDate";
            this.dtpRealeaseDate.Size = new System.Drawing.Size(301, 27);
            this.dtpRealeaseDate.TabIndex = 54;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAEdit);
            this.panel4.Controls.Add(this.btnADelete);
            this.panel4.Controls.Add(this.btnACreate);
            this.panel4.Location = new System.Drawing.Point(494, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(124, 144);
            this.panel4.TabIndex = 56;
            // 
            // dgvAssignmentDetails
            // 
            this.dgvAssignmentDetails.AllowUserToAddRows = false;
            this.dgvAssignmentDetails.AllowUserToDeleteRows = false;
            this.dgvAssignmentDetails.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.dgvAssignmentDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAssignmentDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignmentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignmentDetails.Location = new System.Drawing.Point(12, 260);
            this.dgvAssignmentDetails.Name = "dgvAssignmentDetails";
            this.dgvAssignmentDetails.ReadOnly = true;
            this.dgvAssignmentDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignmentDetails.Size = new System.Drawing.Size(607, 220);
            this.dgvAssignmentDetails.TabIndex = 57;
            this.dgvAssignmentDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignmentDetails_CellClick);
            // 
            // AssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(629, 491);
            this.Controls.Add(this.dgvAssignmentDetails);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssignmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Assignment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignmentDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnACreate;
        private System.Windows.Forms.Button btnAEdit;
        private System.Windows.Forms.Button btnADelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbAProgram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAssignmentTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbASubjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvAssignmentDetails;
        private System.Windows.Forms.DateTimePicker dtpSubmittedDate;
        private System.Windows.Forms.DateTimePicker dtpRealeaseDate;
    }
}