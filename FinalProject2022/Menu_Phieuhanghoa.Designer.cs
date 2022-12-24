namespace WindowGUI
{
    partial class Menu_Phieuhanghoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMasanphamPHH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaphieunhapPHH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSuaPHH = new System.Windows.Forms.Button();
            this.btnXoaPHH = new System.Windows.Forms.Button();
            this.btnTaoPHH = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(258, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 46);
            this.label1.TabIndex = 28;
            this.label1.Text = "Phiếu hàng hóa";
            // 
            // txtMasanphamPHH
            // 
            this.txtMasanphamPHH.Location = new System.Drawing.Point(335, 103);
            this.txtMasanphamPHH.Name = "txtMasanphamPHH";
            this.txtMasanphamPHH.Size = new System.Drawing.Size(180, 22);
            this.txtMasanphamPHH.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(168, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // txtMaphieunhapPHH
            // 
            this.txtMaphieunhapPHH.Location = new System.Drawing.Point(335, 53);
            this.txtMaphieunhapPHH.Name = "txtMaphieunhapPHH";
            this.txtMaphieunhapPHH.Size = new System.Drawing.Size(180, 22);
            this.txtMaphieunhapPHH.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(168, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Mã phiếu nhập:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 68);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMaphieunhapPHH);
            this.groupBox2.Controls.Add(this.txtMasanphamPHH);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(0, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 171);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu hàng hóa";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(674, 183);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phiếu hàng hóa";
            // 
            // btnSuaPHH
            // 
            this.btnSuaPHH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaPHH.Location = new System.Drawing.Point(680, 357);
            this.btnSuaPHH.Name = "btnSuaPHH";
            this.btnSuaPHH.Size = new System.Drawing.Size(104, 35);
            this.btnSuaPHH.TabIndex = 64;
            this.btnSuaPHH.Text = "Sửa";
            this.btnSuaPHH.UseVisualStyleBackColor = true;
            // 
            // btnXoaPHH
            // 
            this.btnXoaPHH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaPHH.Location = new System.Drawing.Point(680, 303);
            this.btnXoaPHH.Name = "btnXoaPHH";
            this.btnXoaPHH.Size = new System.Drawing.Size(104, 35);
            this.btnXoaPHH.TabIndex = 63;
            this.btnXoaPHH.Text = "Xóa";
            this.btnXoaPHH.UseVisualStyleBackColor = true;
            // 
            // btnTaoPHH
            // 
            this.btnTaoPHH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoPHH.Location = new System.Drawing.Point(680, 212);
            this.btnTaoPHH.Name = "btnTaoPHH";
            this.btnTaoPHH.Size = new System.Drawing.Size(104, 36);
            this.btnTaoPHH.TabIndex = 62;
            this.btnTaoPHH.Text = "Tạo";
            this.btnTaoPHH.UseVisualStyleBackColor = true;
            // 
            // Menu_Phieuhanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSuaPHH);
            this.Controls.Add(this.btnXoaPHH);
            this.Controls.Add(this.btnTaoPHH);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Menu_Phieuhanghoa";
            this.Text = "Phiếu hàng hóa";
            this.Load += new System.EventHandler(this.Menu_Phieuhanghoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMasanphamPHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaphieunhapPHH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSuaPHH;
        private System.Windows.Forms.Button btnXoaPHH;
        private System.Windows.Forms.Button btnTaoPHH;
    }
}