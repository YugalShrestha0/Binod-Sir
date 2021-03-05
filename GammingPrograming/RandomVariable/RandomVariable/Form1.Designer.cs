namespace RandomVariable
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
            this.btnRandomVariable = new System.Windows.Forms.Button();
            this.lblRandomVariableX = new System.Windows.Forms.Label();
            this.lblRandomVariableY = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbAlien = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblDecreaseSpeed = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandomVariable
            // 
            this.btnRandomVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomVariable.Location = new System.Drawing.Point(12, 12);
            this.btnRandomVariable.Name = "btnRandomVariable";
            this.btnRandomVariable.Size = new System.Drawing.Size(203, 58);
            this.btnRandomVariable.TabIndex = 0;
            this.btnRandomVariable.Text = "Increase Speed";
            this.btnRandomVariable.UseVisualStyleBackColor = true;
            this.btnRandomVariable.Click += new System.EventHandler(this.btnRandomVariable_Click);
            // 
            // lblRandomVariableX
            // 
            this.lblRandomVariableX.AutoSize = true;
            this.lblRandomVariableX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomVariableX.Location = new System.Drawing.Point(240, 182);
            this.lblRandomVariableX.Name = "lblRandomVariableX";
            this.lblRandomVariableX.Size = new System.Drawing.Size(27, 29);
            this.lblRandomVariableX.TabIndex = 1;
            this.lblRandomVariableX.Text = "0";
            // 
            // lblRandomVariableY
            // 
            this.lblRandomVariableY.AutoSize = true;
            this.lblRandomVariableY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomVariableY.Location = new System.Drawing.Point(240, 229);
            this.lblRandomVariableY.Name = "lblRandomVariableY";
            this.lblRandomVariableY.Size = new System.Drawing.Size(27, 29);
            this.lblRandomVariableY.TabIndex = 2;
            this.lblRandomVariableY.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y";
            // 
            // pbAlien
            // 
            this.pbAlien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbAlien.ErrorImage = null;
            this.pbAlien.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien.Image")));
            this.pbAlien.Location = new System.Drawing.Point(44, 299);
            this.pbAlien.Name = "pbAlien";
            this.pbAlien.Size = new System.Drawing.Size(48, 53);
            this.pbAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlien.TabIndex = 3;
            this.pbAlien.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterval.Location = new System.Drawing.Point(82, 93);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(27, 29);
            this.lblInterval.TabIndex = 4;
            this.lblInterval.Text = "0";
            // 
            // lblDecreaseSpeed
            // 
            this.lblDecreaseSpeed.AutoSize = true;
            this.lblDecreaseSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecreaseSpeed.Location = new System.Drawing.Point(340, 93);
            this.lblDecreaseSpeed.Name = "lblDecreaseSpeed";
            this.lblDecreaseSpeed.Size = new System.Drawing.Size(27, 29);
            this.lblDecreaseSpeed.TabIndex = 6;
            this.lblDecreaseSpeed.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(245, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Decrease Speed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDecreaseSpeed);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.pbAlien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRandomVariableY);
            this.Controls.Add(this.lblRandomVariableX);
            this.Controls.Add(this.btnRandomVariable);
            this.Name = "Form1";
            this.Text = "Ramdom Variable";
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandomVariable;
        private System.Windows.Forms.Label lblRandomVariableX;
        private System.Windows.Forms.Label lblRandomVariableY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbAlien;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblDecreaseSpeed;
        private System.Windows.Forms.Button button1;
    }
}

