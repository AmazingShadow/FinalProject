namespace FinalProject2022
{
    partial class Thong_ke_nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thong_ke_nhanvien));
            this.rp_nhanvien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_xemds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rp_nhanvien
            // 
            this.rp_nhanvien.Location = new System.Drawing.Point(-2, 135);
            this.rp_nhanvien.Name = "rp_nhanvien";
            this.rp_nhanvien.ServerReport.BearerToken = null;
            this.rp_nhanvien.Size = new System.Drawing.Size(927, 411);
            this.rp_nhanvien.TabIndex = 0;
            // 
            // btn_xemds
            // 
            this.btn_xemds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_xemds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xemds.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemds.Image = ((System.Drawing.Image)(resources.GetObject("btn_xemds.Image")));
            this.btn_xemds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xemds.Location = new System.Drawing.Point(578, 49);
            this.btn_xemds.Name = "btn_xemds";
            this.btn_xemds.Size = new System.Drawing.Size(177, 48);
            this.btn_xemds.TabIndex = 1;
            this.btn_xemds.Text = "Xem danh sách";
            this.btn_xemds.UseVisualStyleBackColor = true;
            this.btn_xemds.Click += new System.EventHandler(this.btn_xemds_Click);
            // 
            // Thong_ke_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 545);
            this.Controls.Add(this.btn_xemds);
            this.Controls.Add(this.rp_nhanvien);
            this.Name = "Thong_ke_nhanvien";
            this.Text = "Thong_ke_nhanvien";
            this.Load += new System.EventHandler(this.Thong_ke_nhanvien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp_nhanvien;
        private System.Windows.Forms.Button btn_xemds;
    }
}