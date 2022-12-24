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

namespace FinalProject2022
{
    public partial class Thongkekhachhang : Form
    {
        QUANLYSIEUTHIEntities2 quanlysieuthi = new QUANLYSIEUTHIEntities2();

        public Thongkekhachhang()
        {
            InitializeComponent();
        }

        private void Thongkekhachhang_Load(object sender, EventArgs e)
        {
            // Ẩn report khi không muốn xuất report khách hàng.
            rp_khachhang.Visible = false;
            this.rp_khachhang.RefreshReport();
        }


        // Khi bấm vào button hiện danh sách thì report sẽ được hiện ra.
        private void btn_xemds_Click(object sender, EventArgs e)
        {
            // Hiện report
            rp_khachhang.Visible = true;

            // Lấy ds khách hàng
            List<KHACHHANG> lst_khachhang = quanlysieuthi.KHACHHANGs.ToList();

            // Truyền report
            this.rp_khachhang.LocalReport.ReportPath = "./Thongkekhachhang.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("Danhsachkhachhang", lst_khachhang);
            rp_khachhang.LocalReport.DataSources.Clear();

            rp_khachhang.LocalReport.DataSources.Add(reportDataSource);
            this.rp_khachhang.RefreshReport();
        }
    }
}
