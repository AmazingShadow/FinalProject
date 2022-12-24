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
    public partial class Menu_Nhanvienkho : UserControl
    {
        QUANLYSIEUTHIEntities2 quanlysieuthi = new QUANLYSIEUTHIEntities2();
        string opt = "";

        public Menu_Nhanvienkho()
        {
            InitializeComponent();
        }

        // Function này sẽ xóa dữ liệu ở ô input để ta có thể nhập dữ liệu mới vào.
        public void clearData()
        {
            txt_manhanvien.Text = cb_khuvucquanly.Text = "";
        }

        // Function này dùng để load dữ liệu nhân viên kho từ database lên form khi form được load.
        private void Menu_Nhanvienkho_Load(object sender, EventArgs e)
        {
            nHANVIENKHOBindingSource.DataSource = quanlysieuthi.NHANVIENKHOes.ToList();
        }

        // Function này thực hiện chức năng thêm nhân viên kho vào cơ sở dữ liệu.
        private void addNhanvienKho()
        {
            NHANVIENKHO nhanvienkho = new NHANVIENKHO
            {
                MANHANVIEN = txt_manhanvien.Text.Trim(),
                KHUVUCQUANLY = cb_khuvucquanly.Text.Trim()
            };

            // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu
            quanlysieuthi.NHANVIENKHOes.Add(nhanvienkho);
            quanlysieuthi.SaveChanges();
        }

        // Function này thực hiện chức năng chỉnh sửa dữ liệu
        private void updateNhanvienKho()
        {
            // Tìm kiếm nhân viên kho cần chỉnh sửa.
            NHANVIENKHO nhanvienkho = quanlysieuthi.NHANVIENKHOes.Where(p => p.MANHANVIEN == txt_manhanvien.Text).SingleOrDefault();
            nhanvienkho.KHUVUCQUANLY = cb_khuvucquanly.Text.Trim();

            // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu.
            quanlysieuthi.SaveChanges();
            clearData();
        }

        // Function này xử lý sự kiện thêm tài khoản.
        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opt = "1";
            nHANVIENKHOBindingSource.AddNew();
            txt_manhanvien.Focus();
        }

        // Function này xử lý sự kiện khi người dùng bấm vào nút lưu sẽ lưu thông tin đã nhập hoặc đã chỉnh sửa vào database.
        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra các ô input xem đã nhập hết chưa
            if (txt_manhanvien.Text != "" && cb_khuvucquanly.Text != "")
            {

                if (opt == "1")
                {
                    // Khi opt bằng 1 thì hệ thống sẽ thực hiện chức năng thêm
                    addNhanvienKho();
                }
                else
                {
                    // Khi opt khác 1 thì hệ thống sẽ thực hiện chức năng update
                    updateNhanvienKho();
                }
                opt = "";
                // Sau khi thực hiện thêm hoặc chỉnh sửa dữ liệu thì load lại dữ liệu.
                Menu_Nhanvienkho_Load(sender, e);

                XtraMessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập đủ thông tin vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }
       

        // Function này thực hiện thao tác xóa dữ liệu mà người dùng cần xóa.
        private void btn_xoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Tìm kiếm nhân viên kho mà người dùng đã chọn để xóa
                NHANVIENKHO nhanvienkho = quanlysieuthi.NHANVIENKHOes.Where(p => p.MANHANVIEN == txt_manhanvien.Text).SingleOrDefault();

                // Thực hiện xóa tài khoản đã chọn ra khỏi cơ sở dữ liệu
                quanlysieuthi.NHANVIENKHOes.Remove(nhanvienkho);

                // Sau khi xóa thành công thì lưu dữ liệu mới sau khi xóa.
                quanlysieuthi.SaveChanges();
                Menu_Nhanvienkho_Load(sender, e);
                XtraMessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
