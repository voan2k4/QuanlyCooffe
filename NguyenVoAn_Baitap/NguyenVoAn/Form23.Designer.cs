using System.Drawing;
using System.Windows.Forms;

namespace NguyenVoAn
{
    partial class Form23
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
            this.btLeft = new System.Windows.Forms.Button();
            this.btFile = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLeft
            // 
            this.btLeft.Location = new System.Drawing.Point(102, 201);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(48, 35);
            this.btLeft.TabIndex = 0;
            this.btLeft.Text = "<-";
            this.btLeft.UseVisualStyleBackColor = true;
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(231, 211);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(86, 25);
            this.btFile.TabIndex = 1;
            this.btFile.Text = "File....";
            this.btFile.UseVisualStyleBackColor = true;
            // 
            // btRight
            // 
            this.btRight.Location = new System.Drawing.Point(157, 201);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(49, 35);
            this.btRight.TabIndex = 2;
            this.btRight.Text = "->";
            this.btRight.UseVisualStyleBackColor = true;
            // 
            // Form23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 480);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.btLeft);
            this.Name = "Form23";
            this.Text = "Form23";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btLeft;
        private Button btFile;
        private Button btRight;
    }
}