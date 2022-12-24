using DevExpress.XtraBars;
using FinalProject2022.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalProject2022
{
    public partial class MainMenu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        Main_Background main_background;
        Menu_Taikhoann taikhoan;
        Menu_Nhanvienkho nhanvienkho;
        Menu_Nhanvienbanhang nhanvienbanhang;
        Menu_Nhanvien nhanvien;
        Menu_Phieunhap phieunhap;
        Menu_Phieuxuat phieuxuat;
        Menu_chitietphieunhap chitietphieunhap;
        Menu_chitietphieuxuat chitietphieuxuat;
        Menu_hoadon hoadon;
        Menu_chitiethoadon chitiethoadon;
        Menu_loaihanghoa loaihanghoa;
        Menu_hanghoa hanghoa;
        Menu_khachhang khachhang;

        public MainMenu()
        {
            InitializeComponent();
        }

        // Taikhoa

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (main_background == null)
            {
                main_background = new Main_Background();
                main_background.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(main_background);
                main_background.BringToFront();
            }
            else
            {
                main_background.BringToFront();
            }
        }

        // Tài khoản
        private void mnTaikhoan_Click(object sender, EventArgs e)
        {
            if (taikhoan == null)
            {
                taikhoan = new Menu_Taikhoann();
                taikhoan.Dock = DockStyle.Fill;
                //taikhoan.HienThi();
                mainContainer.Controls.Add(taikhoan);
                taikhoan.BringToFront();
            }
            else
            {
                //taikhoan.HienThi();
                taikhoan.BringToFront();
                lplTieude.Caption = mnTaikhoan.Text;
            }
        }

        // Nhân viên kho
        private void mnNhanvienkho_Click(object sender, EventArgs e)
        {
            if (nhanvienkho == null)
            {
                nhanvienkho = new Menu_Nhanvienkho();
                nhanvienkho.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(nhanvienkho);
                nhanvienkho.BringToFront();
            }
            else
            {
                nhanvienkho.BringToFront();
                lplTieude.Caption = mnNhanvienkho.Text;
            }
        }

        // Nhân viên bán hàng
        private void mnNhanvienbanhang_Click(object sender, EventArgs e)
        {
            if (nhanvienbanhang == null)
            {
                nhanvienbanhang = new Menu_Nhanvienbanhang();
                nhanvienbanhang.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(nhanvienbanhang);
                nhanvienbanhang.BringToFront();
            }
            else
            {
                nhanvienbanhang.BringToFront();
                lplTieude.Caption = mnNhanvienbanhang.Text;
            }
        }

        // Nhân viên
        private void mnNhanvien_Click(object sender, EventArgs e)
        {
            if (nhanvien == null)
            {
                nhanvien = new Menu_Nhanvien();
                nhanvien.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(nhanvien);
                nhanvien.BringToFront();
            }
            else
            {
                nhanvien.BringToFront();
                lplTieude.Caption = mnNhanvien.Text;
            }
        }

        // Phiếu nhập hàng
        private void mnPhieunhap_Click(object sender, EventArgs e)
        {
            if (phieunhap == null)
            {
                phieunhap = new Menu_Phieunhap();
                phieunhap.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(phieunhap);
                phieunhap.BringToFront();
            }
            else
            {
                phieunhap.BringToFront();
                lplTieude.Caption = mnPhieunhap.Text;
            }
        }

        // Phiếu xuất hàng
        private void mnPhieuxuat_Click(object sender, EventArgs e)
        {
            if (phieuxuat == null)
            {
                phieuxuat = new Menu_Phieuxuat();
                phieuxuat.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(phieuxuat);
                phieuxuat.BringToFront();
            }
            else
            {
                phieuxuat.BringToFront();
                lplTieude.Caption = mnPhieuxuat.Text;
            }
        }

        // Chi tiết phiếu nhập
        private void mnPhieuhanghoa_Click(object sender, EventArgs e)
        {
            if (chitietphieunhap == null)
            {
                chitietphieunhap = new Menu_chitietphieunhap();
                chitietphieunhap.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(chitietphieunhap);
                chitietphieunhap.BringToFront();
            }
            else
            {
                chitietphieunhap.BringToFront();
                lplTieude.Caption = mnPhieuhanghoa.Text;
            }
        }

        // Chi tiết phiếu xuất
        private void mnPhieuhangxuat_Click(object sender, EventArgs e)
        {
            if (chitietphieuxuat == null)
            {
                chitietphieuxuat = new Menu_chitietphieuxuat();
                chitietphieuxuat.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(chitietphieuxuat);
                chitietphieuxuat.BringToFront();
            }
            else
            {
                chitietphieuxuat.BringToFront();
                lplTieude.Caption = mnPhieuhangxuat.Text;
            }
        }

        // Hóa đơn
        private void mnHoadon_Click(object sender, EventArgs e)
        {
            if (hoadon == null)
            {
                hoadon = new Menu_hoadon();
                hoadon.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(hoadon);
                hoadon.BringToFront();
            }
            else
            {
                hoadon.BringToFront();
                lplTieude.Caption = mnHoadon.Text;
            }
        }

        // Chi tiết hóa đơn
        private void mnChitiethoadon_Click(object sender, EventArgs e)
        {
            if (chitiethoadon == null)
            {
                chitiethoadon = new Menu_chitiethoadon();
                chitiethoadon.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(chitiethoadon);
                chitiethoadon.BringToFront();
            }
            else
            {
                chitiethoadon.BringToFront();
                lplTieude.Caption = mnChitiethoadon.Text;
            }
        }

        // Loại hàng hóa
        private void mnLoaihanghoa_Click(object sender, EventArgs e)
        {
            if (loaihanghoa == null)
            {
                loaihanghoa = new Menu_loaihanghoa();
                loaihanghoa.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(loaihanghoa);
                loaihanghoa.BringToFront();
            }
            else
            {
                loaihanghoa.BringToFront();
                lplTieude.Caption = mnLoaihanghoa.Text;
            }
        }

        // Hàng hóa
        private void mnHanghoa_Click(object sender, EventArgs e)
        {
            if (hanghoa == null)
            {
                hanghoa = new Menu_hanghoa();
                hanghoa.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(hanghoa);
                hanghoa.BringToFront();
            }
            else
            {
                hanghoa.BringToFront();
                lplTieude.Caption = mnHanghoa.Text;
            }
        }

        // Khách hàng
        private void mnKhachhang_Click(object sender, EventArgs e)
        {
            if (khachhang == null)
            {
                khachhang = new Menu_khachhang();
                khachhang.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(khachhang);
                khachhang.BringToFront();
            }
            else
            {
                khachhang.BringToFront();
                lplTieude.Caption = mnKhachhang.Text;
            }
        }
        
        // Thống kê nhân viên
        private void mnThongkenhanvien_Click(object sender, EventArgs e)
        {
            Thong_ke_nhanvien thongke_nhanvien = new Thong_ke_nhanvien();
            thongke_nhanvien.ShowDialog();
        }


        // Thống kê khách hàng
        private void mnThongkekhachhang_Click(object sender, EventArgs e)
        {
            Thongkekhachhang thongkekhachhang = new Thongkekhachhang();
            thongkekhachhang.ShowDialog();
        }
    }
}
