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
    public partial class Menu_Taikhoann : UserControl
    {
        QUANLYSIEUTHIEntities2 quanlysieuthi = new QUANLYSIEUTHIEntities2();
        string opt = "";

        public Menu_Taikhoann()
        {
            InitializeComponent();
        }

        // Function này sẽ xóa dữ liệu ở ô input để ta có thể nhập dữ liệu mới vào.
        public void clearData()
        {
            txt_username.Text = txt_password.Text = txt_manhanvien.Text = "";
        }

        // Function này dùng để load dữ liệu tài khoản từ database lên form khi form được load.
        private void Menu_Taikhoann_Load(object sender, EventArgs e)
        {
            tAIKHOANBindingSource.DataSource = quanlysieuthi.TAIKHOANs.ToList();
        }

        // Function này xử lý sự kiện thêm tài khoản.
        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opt = "1";
            tAIKHOANBindingSource.AddNew();
            txt_username.Focus();
        }

        // Function này thực hiện chức năng thêm user
        private void addUser()
        {
            TAIKHOAN taikhoan = new TAIKHOAN
            {
                TENDANGNHAP = txt_username.Text.Trim(),
                MANHANVIEN = txt_manhanvien.Text.Trim(),
                MATKHAU = txt_password.Text.Trim()
            };

            // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu
            quanlysieuthi.TAIKHOANs.Add(taikhoan);
            quanlysieuthi.SaveChanges();
        }

        // Function này thực hiện chức năng chỉnh sửa dữ liệu
        private void updateUser()
        {
            // Tìm kiếm user cần chỉnh sửa.
            TAIKHOAN taikhoan = quanlysieuthi.TAIKHOANs.Where(p => p.TENDANGNHAP == txt_username.Text).SingleOrDefault();
            taikhoan.MATKHAU = txt_password.Text;

            // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu
            quanlysieuthi.SaveChanges();
            clearData();
        }

        // Function này xử lý sự kiện khi người dùng bấm vào nút lưu sẽ lưu thông tin đã nhập hoặc đã chỉnh sửa vào database.
        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra các ô input xem đã nhập hết chưa
            if (txt_username.Text != "" && txt_manhanvien.Text != "" && txt_password.Text != "")
            {

                if (opt == "1")
                {
                    // Khi opt bằng 1 thì hệ thống sẽ thực hiện chức năng thêm
                    addUser();
                }
                else
                {
                    // Khi opt khác 1 thì hệ thống sẽ thực hiện chức năng update
                    updateUser();
                }
                opt = "";
                // Sau khi thực hiện thêm hoặc chỉnh sửa dữ liệu thì load lại dữ liệu.
                Menu_Taikhoann_Load(sender, e);

                XtraMessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK);
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
                // Tìm kiếm tài khoản mà người dùng đã chọn để xóa
                TAIKHOAN taikhoan = quanlysieuthi.TAIKHOANs.Where(p => p.TENDANGNHAP == txt_username.Text).SingleOrDefault();
                
                // Thực hiện xóa tài khoản đã chọn ra khỏi cơ sở dữ liệu
                quanlysieuthi.TAIKHOANs.Remove(taikhoan);

                // Sau khi xóa thành công thì lưu dữ liệu mới sau khi xóa.
                quanlysieuthi.SaveChanges();
                Menu_Taikhoann_Load(sender, e);
                XtraMessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
