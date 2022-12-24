using DevExpress.Utils.CodedUISupport;
using DevExpress.XtraBars.Ribbon;
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
    public partial class Menu_Nhanvien : UserControl
    {
        QUANLYSIEUTHIEntities2 quanlysieuthi = new QUANLYSIEUTHIEntities2();
        string opt = "";

        public Menu_Nhanvien()
        {
            InitializeComponent();
        }

        // Function này sẽ xóa dữ liệu ở ô input để ta có thể nhập dữ liệu mới vào.
        public void clearData()
        {
            txt_manhanvien.Text = txt_tennhanvien.Text = txt_diachi.Text = txt_luongcoban.Text = dt_ngaysinh.Text = txt_sđt.Text = cb_tilethunhap.Text = txt_maquanly.Text = "";
        }

        // Function này thực hiện chức năng thêm nhân viên bán hàng vào cơ sở dữ liệu.
        private void addNhanvien()
        {
            // Kiểm tra xem có phải là nhân viên quản lý hay không
            try
            {
                if (txt_maquanly.Text.ToString() != "")
                {
                    // Nếu không thì thực hiện proceduce đã viết sẵn trong cơ sở dữ liệu
                    quanlysieuthi.THEMNHANVIEN(
                                            txt_manhanvien.Text.Trim(),
                                            txt_tennhanvien.Text.Trim(),
                                            txt_diachi.Text.Trim(),
                                            float.Parse(txt_luongcoban.Text.Trim()),
                                            int.Parse(cb_diemthuong.Text.Trim()),
                                            DateTime.Parse(dt_ngaysinh.Text.Trim()),
                                            txt_sđt.Text.Trim(),
                                            txt_gioitinh.Text.Trim(),
                                            float.Parse(cb_tilethunhap.Text.Trim()),
                                            txt_maquanly.Text.Trim()
                                            );
                    XtraMessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Nếu là quản lý thì thực hiện proceduce đã viết sẵn trong cơ sở dữ liệu
                    quanlysieuthi.THEMQUANLY(
                                            txt_manhanvien.Text.Trim(),
                                            txt_tennhanvien.Text.Trim(),
                                            txt_diachi.Text.Trim(),
                                            float.Parse(txt_luongcoban.Text.Trim()),
                                            int.Parse(cb_diemthuong.Text.Trim()),
                                            DateTime.Parse(dt_ngaysinh.Text.Trim()),
                                            txt_sđt.Text.Trim(),
                                            txt_gioitinh.Text.Trim(),
                                            float.Parse(cb_tilethunhap.Text.Trim())
                                            );
                    XtraMessageBox.Show("Thêm quản lý thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch(Exception e)
            {
                XtraMessageBox.Show("Nhân viên hoặc số điện thoại đã tồn tại, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Function này thực hiện chức năng chỉnh sửa dữ liệu
        private void updateNhanvien()
        {
            try
            {
                if (txt_maquanly.Text.ToString() != "")
                {
                    quanlysieuthi.SUANHANVIEN(
                                             txt_manhanvien.Text.Trim(),
                                             txt_tennhanvien.Text.Trim(),
                                             txt_diachi.Text.Trim(),
                                             float.Parse(txt_luongcoban.Text.Trim()),
                                             int.Parse(cb_diemthuong.Text.Trim()),
                                             DateTime.Parse(dt_ngaysinh.Text.Trim()),
                                             txt_sđt.Text.Trim(),
                                             txt_gioitinh.Text.Trim(),
                                             float.Parse(cb_tilethunhap.Text.Trim()),
                                             txt_maquanly.Text.Trim()
                                             );
                    XtraMessageBox.Show("Sửa thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    quanlysieuthi.SUAQUANLY(
                                            txt_manhanvien.Text.Trim(),
                                            txt_tennhanvien.Text.Trim(),
                                            txt_diachi.Text.Trim(),
                                            float.Parse(txt_luongcoban.Text.Trim()),
                                            int.Parse(cb_diemthuong.Text.Trim()),
                                            DateTime.Parse(dt_ngaysinh.Text.Trim()),
                                            txt_sđt.Text.Trim(),
                                            txt_gioitinh.Text.Trim(),
                                            float.Parse(cb_tilethunhap.Text.Trim())
                                            );
                    XtraMessageBox.Show("Sửa thông tin quản lý thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch(Exception ex)
            {
                XtraMessageBox.Show("Nhân viên hoặc số điện thoại đã tồn tại, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            clearData();
        }

        // Function này dùng để load dữ liệu nhân viên từ database lên form khi form được load.
        private void Menu_Nhanvien_Load(object sender, EventArgs e)
        {
            nHANVIENBindingSource.DataSource = quanlysieuthi.NHANVIENs.ToList();
        }

        // Function này xử lý sự kiện thêm tài khoản.
        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opt = "1";
            nHANVIENBindingSource.AddNew();
            txt_manhanvien.Focus();
        }

        // Function này xử lý sự kiện khi người dùng bấm vào nút lưu sẽ lưu thông tin đã nhập hoặc đã chỉnh sửa vào database.
        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra các ô input xem đã nhập hết chưa
            if (txt_manhanvien.Text != "" && txt_tennhanvien.Text != "" && txt_diachi.Text != "" && txt_luongcoban.Text != "" && txt_sđt.Text != "")
            {

                if (opt == "1")
                {
                    // Khi opt bằng 1 thì hệ thống sẽ thực hiện chức năng thêm
                    addNhanvien();
                }
                else
                {
                    // Khi opt khác 1 thì hệ thống sẽ thực hiện chức năng update
                    updateNhanvien();
                }
                opt = "";
                // Sau khi thực hiện thêm hoặc chỉnh sửa dữ liệu thì load lại dữ liệu.
                Menu_Nhanvien_Load(sender, e);
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
                if (txt_maquanly.Text != "")
                {
                    quanlysieuthi.XOANHANVIEN(txt_manhanvien.Text.Trim());
                    Menu_Nhanvien_Load(sender, e);
                    XtraMessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    XtraMessageBox.Show("Không thể xóa quản lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        // Xử lý khi chọn chức vụ thì hệ thống tự gợi ý mã nhân viên.
        private void txt_chucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_manhanvien.Text = txt_maquanly.Text.Trim() == "Nhân viên kho" ? "K" : "B";
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
        private void txt_sđt_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkInputNumber(e);
        }

        // Bắt sự kiện nhập vào ô lương.
        private void txt_luongcoban_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkInputNumber(e);
        }
    }
}
