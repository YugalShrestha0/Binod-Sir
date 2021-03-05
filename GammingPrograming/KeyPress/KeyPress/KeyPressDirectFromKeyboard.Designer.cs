namespace KeyPress
{
    partial class KeyPressDirectFromKeyboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyPressDirectFromKeyboard));
            this.pbAlien = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAlien
            // 
            this.pbAlien.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien.Image")));
            this.pbAlien.Location = new System.Drawing.Point(227, 160);
            this.pbAlien.Name = "pbAlien";
            this.pbAlien.Size = new System.Drawing.Size(77, 88);
            this.pbAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlien.TabIndex = 1;
            this.pbAlien.TabStop = false;
            this.pbAlien.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbAlien_MouseDown);
            // 
            // KeyPressDirectFromKeyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 471);
            this.Controls.Add(this.pbAlien);
            this.Name = "KeyPressDirectFromKeyboard";
            this.Text = "KeyPressDirectFromKeyboard";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDirectFromKeyboard_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAlien;
    }
}