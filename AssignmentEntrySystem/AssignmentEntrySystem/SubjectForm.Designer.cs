
namespace AssignmentEntrySystem
{
    partial class SubjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvSubjectDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubjectCode = new System.Windows.Forms.TextBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubClose = new System.Windows.Forms.Button();
            this.btnSubDelete = new System.Windows.Forms.Button();
            this.btnSubEdit = new System.Windows.Forms.Button();
            this.btnSubAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSubProgram = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCredit
            // 
            this.txtCredit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredit.Location = new System.Drawing.Point(144, 90);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(215, 27);
            this.txtCredit.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // dgvSubjectDetails
            // 
            this.dgvSubjectDetails.AllowUserToAddRows = false;
            this.dgvSubjectDetails.AllowUserToDeleteRows = false;
            this.dgvSubjectDetails.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            this.dgvSubjectDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSubjectDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubjectDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjectDetails.Location = new System.Drawing.Point(11, 236);
            this.dgvSubjectDetails.Name = "dgvSubjectDetails";
            this.dgvSubjectDetails.ReadOnly = true;
            this.dgvSubjectDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjectDetails.Size = new System.Drawing.Size(487, 214);
            this.dgvSubjectDetails.TabIndex = 22;
            this.dgvSubjectDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjectDetails_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "MANAGE SUBJECT";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.cmbSubProgram);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCredit);
            this.groupBox1.Controls.Add(this.txtSubjectCode);
            this.groupBox1.Controls.Add(this.txtSubjectName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 157);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Provide all the Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Program:";
            // 
            // txtSubjectCode
            // 
            this.txtSubjectCode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectCode.Location = new System.Drawing.Point(144, 59);
            this.txtSubjectCode.Name = "txtSubjectCode";
            this.txtSubjectCode.Size = new System.Drawing.Size(215, 27);
            this.txtSubjectCode.TabIndex = 5;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectName.Location = new System.Drawing.Point(144, 28);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(215, 27);
            this.txtSubjectName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Credit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Subject Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subject Name:";
            // 
            // btnSubClose
            // 
            this.btnSubClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSubClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubClose.Location = new System.Drawing.Point(1, 117);
            this.btnSubClose.Name = "btnSubClose";
            this.btnSubClose.Size = new System.Drawing.Size(110, 40);
            this.btnSubClose.TabIndex = 3;
            this.btnSubClose.Text = "CLOSE";
            this.btnSubClose.UseVisualStyleBackColor = false;
            this.btnSubClose.Click += new System.EventHandler(this.btnSClose_Click);
            // 
            // btnSubDelete
            // 
            this.btnSubDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSubDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubDelete.Location = new System.Drawing.Point(1, 79);
            this.btnSubDelete.Name = "btnSubDelete";
            this.btnSubDelete.Size = new System.Drawing.Size(110, 40);
            this.btnSubDelete.TabIndex = 2;
            this.btnSubDelete.Text = "DELETE";
            this.btnSubDelete.UseVisualStyleBackColor = false;
            this.btnSubDelete.Click += new System.EventHandler(this.btnSubDelete_Click);
            // 
            // btnSubEdit
            // 
            this.btnSubEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSubEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubEdit.Location = new System.Drawing.Point(1, 40);
            this.btnSubEdit.Name = "btnSubEdit";
            this.btnSubEdit.Size = new System.Drawing.Size(110, 40);
            this.btnSubEdit.TabIndex = 1;
            this.btnSubEdit.Text = "EDIT";
            this.btnSubEdit.UseVisualStyleBackColor = false;
            this.btnSubEdit.Click += new System.EventHandler(this.btnSubEdit_Click);
            // 
            // btnSubAdd
            // 
            this.btnSubAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSubAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubAdd.Location = new System.Drawing.Point(1, 1);
            this.btnSubAdd.Name = "btnSubAdd";
            this.btnSubAdd.Size = new System.Drawing.Size(110, 40);
            this.btnSubAdd.TabIndex = 0;
            this.btnSubAdd.Text = "ADD";
            this.btnSubAdd.UseVisualStyleBackColor = false;
            this.btnSubAdd.Click += new System.EventHandler(this.btnSubAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSubClose);
            this.panel1.Controls.Add(this.btnSubDelete);
            this.panel1.Controls.Add(this.btnSubEdit);
            this.panel1.Controls.Add(this.btnSubAdd);
            this.panel1.Location = new System.Drawing.Point(385, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 157);
            this.panel1.TabIndex = 21;
            // 
            // cmbSubProgram
            // 
            this.cmbSubProgram.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubProgram.FormattingEnabled = true;
            this.cmbSubProgram.Location = new System.Drawing.Point(144, 123);
            this.cmbSubProgram.Name = "cmbSubProgram";
            this.cmbSubProgram.Size = new System.Drawing.Size(215, 28);
            this.cmbSubProgram.TabIndex = 9;
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(509, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvSubjectDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvSubjectDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubjectCode;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubClose;
        private System.Windows.Forms.Button btnSubDelete;
        private System.Windows.Forms.Button btnSubEdit;
        private System.Windows.Forms.Button btnSubAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSubProgram;
    }
}