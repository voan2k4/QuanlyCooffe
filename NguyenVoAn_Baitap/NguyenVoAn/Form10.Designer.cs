using System;

namespace NguyenVoAn
{
    partial class Form10
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
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btEquals = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(31, 31);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(310, 48);
            this.tbDisplay.TabIndex = 26;
            this.tbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btEquals
            // 
            this.btEquals.Location = new System.Drawing.Point(268, 163);
            this.btEquals.Name = "btEquals";
            this.btEquals.Size = new System.Drawing.Size(73, 72);
            this.btEquals.TabIndex = 25;
            this.btEquals.Text = "=";
            this.btEquals.UseVisualStyleBackColor = true;
            this.btEquals.Click += new System.EventHandler(this.btEquals_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(189, 163);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 72);
            this.button6.TabIndex = 24;
            this.button6.Text = ".";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btMul
            // 
            this.btMul.Location = new System.Drawing.Point(110, 163);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(73, 72);
            this.btMul.TabIndex = 23;
            this.btMul.Text = "*";
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.Click += new System.EventHandler(this.btMul_Click);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(31, 163);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(73, 72);
            this.btPlus.TabIndex = 22;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(268, 85);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(73, 72);
            this.bt3.TabIndex = 21;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(189, 85);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(73, 72);
            this.bt2.TabIndex = 20;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(110, 85);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(73, 72);
            this.bt1.TabIndex = 19;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(31, 85);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(73, 72);
            this.bt0.TabIndex = 18;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 275);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.btEquals);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt0);
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btEquals;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt0;
    }
}