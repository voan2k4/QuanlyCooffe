namespace NguyenVoAn
{
    partial class Form9
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
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btCong = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.tbSoY = new System.Windows.Forms.TextBox();
            this.tbSoX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbKetQua
            // 
            this.tbKetQua.Location = new System.Drawing.Point(112, 120);
            this.tbKetQua.Multiline = true;
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.Size = new System.Drawing.Size(296, 179);
            this.tbKetQua.TabIndex = 30;
            this.tbKetQua.TextChanged += new System.EventHandler(this.tbKetqua_TextChanged);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(323, 305);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(85, 33);
            this.btThoat.TabIndex = 29;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btNhan
            // 
            this.btNhan.Location = new System.Drawing.Point(224, 305);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(93, 33);
            this.btNhan.TabIndex = 28;
            this.btNhan.Text = "Nhân";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(139, 305);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(79, 33);
            this.btCong.TabIndex = 27;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(23, 305);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(81, 33);
            this.btLuu.TabIndex = 26;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // tbSoY
            // 
            this.tbSoY.Location = new System.Drawing.Point(112, 72);
            this.tbSoY.Name = "tbSoY";
            this.tbSoY.Size = new System.Drawing.Size(296, 22);
            this.tbSoY.TabIndex = 25;
            // 
            // tbSoX
            // 
            this.tbSoX.Location = new System.Drawing.Point(112, 29);
            this.tbSoX.Name = "tbSoX";
            this.tbSoX.Size = new System.Drawing.Size(296, 22);
            this.tbSoX.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 383);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.tbSoY);
            this.Controls.Add(this.tbSoX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKetQua;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.TextBox tbSoY;
        private System.Windows.Forms.TextBox tbSoX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}