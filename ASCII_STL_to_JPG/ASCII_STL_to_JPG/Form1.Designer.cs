namespace ASCII_STL_to_JPG
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
            this.btnStJ = new System.Windows.Forms.Button();
            this.btnJtS = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStJ
            // 
            this.btnStJ.Location = new System.Drawing.Point(66, 156);
            this.btnStJ.Name = "btnStJ";
            this.btnStJ.Size = new System.Drawing.Size(75, 23);
            this.btnStJ.TabIndex = 0;
            this.btnStJ.Text = "STL to JPG";
            this.btnStJ.UseVisualStyleBackColor = true;
            // 
            // btnJtS
            // 
            this.btnJtS.Location = new System.Drawing.Point(329, 156);
            this.btnJtS.Name = "btnJtS";
            this.btnJtS.Size = new System.Drawing.Size(75, 23);
            this.btnJtS.TabIndex = 1;
            this.btnJtS.Text = "JPG to STL";
            this.btnJtS.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 499);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 499);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnJtS);
            this.Controls.Add(this.btnStJ);
            this.Name = "Form1";
            this.Text = "ASCII STL to JPG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStJ;
        private System.Windows.Forms.Button btnJtS;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

