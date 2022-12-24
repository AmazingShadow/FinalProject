using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DevExpress.XtraRichEdit.Commands;

namespace FinalProject2022
{
    public partial class Thong_ke_nhanvien : Form
    {
        QUANLYSIEUTHIEntities2 quanlysieuthi = new QUANLYSIEUTHIEntities2();
        public Thong_ke_nhanvien()
        {
            InitializeComponent();
        }

        private void Thong_ke_nhanvien_Load(object sender, EventArgs e)
        {
            // Ẩn report khi không muốn xuất report nhân viên
            rp_nhanvien.Visible = false;
        }

        private void btn_xemds_Click(object sender, EventArgs e)
        {
            // Hiện report
            rp_nhanvien.Visible = true;

            // Lấy ds nhân viên
            List<NHANVIEN> lst_nhanvien = quanlysieuthi.NHANVIENs.ToList();

            // Truyền report
            this.rp_nhanvien.LocalReport.ReportPath = "./Thongkenhanvien.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", lst_nhanvien);
            rp_nhanvien.LocalReport.DataSources.Clear();

            rp_nhanvien.LocalReport.DataSources.Add(reportDataSource);
            this.rp_nhanvien.RefreshReport();
        }
    }
}
