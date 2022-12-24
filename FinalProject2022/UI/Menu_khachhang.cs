using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject2022.UI
{
    public partial class Menu_khachhang : UserControl
    {
        QUANLYSIEUTHIEntities2 quanlysieuthi = new QUANLYSIEUTHIEntities2();
        string opt = "";

        public Menu_khachhang()
        {
            InitializeComponent();
        }

        // Function này sẽ xóa dữ liệu ở ô input để ta có thể nhập dữ liệu mới vào.
        public void clearData()
        {
            txt_makhachhang.Text = txt_tenkhachhang.Text = txt_diachi.Text = txt_loaikhachhang.Text = dt_ngaysinh.Text = txt_sodienthoai.Text = "";
        }

        // Function này thực hiện chức năng thêm nhân viên kho vào cơ sở dữ liệu.
        private void addKhachhang()
        {
            try
            {
                KHACHHANG khachhang = new KHACHHANG
                {
                    MAKHACHHANG = txt_makhachhang.Text.Trim(),
                    TENKHACHHANG = txt_tenkhachhang.Text.Trim(),
                    LOAIKHACHHANG = txt_loaikhachhang.Text.Trim(),
                    NGAYSINH = DateTime.Parse(dt_ngaysinh.Text.Trim()),
                    SDT = txt_sodienthoai.Text.Trim(),
                    DIACHI = txt_diachi.Text.Trim()
                };

                // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu
                quanlysieuthi.KHACHHANGs.Add(khachhang);
                quanlysieuthi.SaveChanges();
                XtraMessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK);
                clearData();
            } catch(Exception ex)
            {
                XtraMessageBox.Show("Khách hàng hoặc số điện thoại đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Function này thực hiện chức năng chỉnh sửa dữ liệu
        private void updateKhachhang()
        {
            
            // Tìm kiếm nhân viên kho cần chỉnh sửa.
            KHACHHANG khachhang = quanlysieuthi.KHACHHANGs.Where(p => p.MAKHACHHANG == txt_makhachhang.Text).SingleOrDefault();
            khachhang.TENKHACHHANG = txt_tenkhachhang.Text.Trim();
            khachhang.LOAIKHACHHANG = txt_loaikhachhang.Text.Trim();
            khachhang.NGAYSINH = DateTime.Parse(dt_ngaysinh.Text.Trim());
            khachhang.SDT = txt_sodienthoai.Text.Trim();
            khachhang.DIACHI = txt_diachi.Text.Trim();

            // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu.
            quanlysieuthi.SaveChanges();
            XtraMessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK);
            clearData();
         
        }

        // Function này dùng để load dữ liệu khách hàng từ database lên form khi form được load.
        private void Menu_khachhang_Load(object sender, EventArgs e)
        {
            kHACHHANGBindingSource.DataSource = quanlysieuthi.KHACHHANGs.ToList();
        }

        // Function này xử lý sự kiện thêm tài khoản.
        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opt = "1";
            kHACHHANGBindingSource.AddNew();
            txt_makhachhang.Focus();
        }

        // Function này xử lý sự kiện khi người dùng bấm vào nút lưu sẽ lưu thông tin đã nhập hoặc đã chỉnh sửa vào database.
        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra các ô input xem đã nhập hết chưa
            if (txt_makhachhang.Text != "" && txt_tenkhachhang.Text != "" && txt_diachi.Text != "" && txt_loaikhachhang.Text != "" && txt_sodienthoai.Text != "" && dt_ngaysinh.Text != "")
            {

                if (opt == "1")
                {
                    // Khi opt bằng 1 thì hệ thống sẽ thực hiện chức năng thêm
                    addKhachhang();
                }
                else
                {
                    // Khi opt khác 1 thì hệ thống sẽ thực hiện chức năng update
                    updateKhachhang();
                }
                opt = "";
                // Sau khi thực hiện thêm hoặc chỉnh sửa dữ liệu thì load lại dữ liệu.
                Menu_khachhang_Load(sender, e);
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập đủ thông tin vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        // Function này thực hiện thao tác xóa dữ liệu mà người dùng cần xóa.
        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Tìm kiếm nhân viên kho mà người dùng đã chọn để xóa
                KHACHHANG khachhang = quanlysieuthi.KHACHHANGs.Where(p => p.MAKHACHHANG == txt_makhachhang.Text).SingleOrDefault();

                // Thực hiện xóa tài khoản đã chọn ra khỏi cơ sở dữ liệu
                quanlysieuthi.KHACHHANGs.Remove(khachhang);

                // Sau khi xóa thành công thì lưu dữ liệu mới sau khi xóa.
                quanlysieuthi.SaveChanges();
                Menu_khachhang_Load(sender, e);
                XtraMessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Function này ngăn người dùng nhập chữ trong một số input.
        private void checkInputNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        // Bắt sự kiện nhập vào ô input số điện thoại.
        private void txt_sodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkInputNumber(e);
        }
    }
}
