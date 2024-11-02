using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Example
{
    partial class Form11
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btInto = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btEquals = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btDot = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(51, 39);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(349, 57);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "MC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "MR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(193, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "MS";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(264, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "M+";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(335, 103);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 38);
            this.button5.TabIndex = 5;
            this.button5.Text = "M-";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(335, 147);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 38);
            this.button6.TabIndex = 10;
            this.button6.Text = "√";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(264, 147);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 38);
            this.button7.TabIndex = 9;
            this.button7.Text = "±";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(193, 147);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(65, 38);
            this.button8.TabIndex = 8;
            this.button8.Text = "C";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(121, 147);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(65, 38);
            this.button9.TabIndex = 7;
            this.button9.Text = "CE";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(50, 147);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(65, 38);
            this.button10.TabIndex = 6;
            this.button10.Text = "⭠";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(335, 192);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(65, 38);
            this.button11.TabIndex = 15;
            this.button11.Text = "%";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btInto
            // 
            this.btInto.Location = new System.Drawing.Point(264, 192);
            this.btInto.Name = "btInto";
            this.btInto.Size = new System.Drawing.Size(65, 38);
            this.btInto.TabIndex = 14;
            this.btInto.Text = "/";
            this.btInto.UseVisualStyleBackColor = true;
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(193, 192);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(65, 38);
            this.bt9.TabIndex = 13;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(121, 192);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(65, 38);
            this.bt8.TabIndex = 12;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(50, 192);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(65, 38);
            this.bt7.TabIndex = 11;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(335, 236);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(65, 38);
            this.button16.TabIndex = 20;
            this.button16.Text = "1/x";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // btMul
            // 
            this.btMul.Location = new System.Drawing.Point(264, 236);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(65, 38);
            this.btMul.TabIndex = 19;
            this.btMul.Text = "*";
            this.btMul.UseVisualStyleBackColor = true;
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(193, 236);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(65, 38);
            this.bt6.TabIndex = 18;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(121, 236);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(65, 38);
            this.bt5.TabIndex = 17;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(50, 236);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(65, 38);
            this.bt4.TabIndex = 16;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            // 
            // btEquals
            // 
            this.btEquals.Location = new System.Drawing.Point(335, 281);
            this.btEquals.Name = "btEquals";
            this.btEquals.Size = new System.Drawing.Size(65, 83);
            this.btEquals.TabIndex = 25;
            this.btEquals.Text = "=";
            this.btEquals.UseVisualStyleBackColor = true;
            // 
            // btMinus
            // 
            this.btMinus.Location = new System.Drawing.Point(264, 281);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(65, 38);
            this.btMinus.TabIndex = 24;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(193, 281);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(65, 38);
            this.bt3.TabIndex = 23;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(121, 281);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(65, 38);
            this.bt2.TabIndex = 22;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(50, 281);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(65, 38);
            this.bt1.TabIndex = 21;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(264, 326);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(65, 38);
            this.btPlus.TabIndex = 26;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            // 
            // btDot
            // 
            this.btDot.Location = new System.Drawing.Point(193, 326);
            this.btDot.Name = "btDot";
            this.btDot.Size = new System.Drawing.Size(65, 38);
            this.btDot.TabIndex = 27;
            this.btDot.Text = ".";
            this.btDot.UseVisualStyleBackColor = true;
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(50, 326);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(136, 38);
            this.bt0.TabIndex = 28;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 400);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btDot);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.btEquals);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btInto);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDisplay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button btInto;
        private Button bt9;
        private Button bt8;
        private Button bt7;
        private Button button16;
        private Button btMul;
        private Button bt6;
        private Button bt5;
        private Button bt4;
        private Button btEquals;
        private Button btMinus;
        private Button bt3;
        private Button bt2;
        private Button bt1;
        private Button btPlus;
        private Button btDot;
        private Button bt0;
    }
}