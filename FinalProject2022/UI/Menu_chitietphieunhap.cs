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
    public partial class Menu_chitietphieunhap : UserControl
    {
        QUANLYSIEUTHIEntities2 quanlysieuthi = new QUANLYSIEUTHIEntities2();
        string opt = "";
        public Menu_chitietphieunhap()
        {
            InitializeComponent();
        }

        // Function này sẽ xóa dữ liệu ở ô input để ta có thể nhập dữ liệu mới vào.
        public void clearData()
        {
            txt_maphieunhap.Text = txt_masanpham.Text = txt_soluong.Text = txt_dongia.Text =  "";
        }

        // Function này thực hiện chức năng thêm chi tiết phiếu nhập kho vào cơ sở dữ liệu.
        private void addChitietphieunhap()
        {
            // Tạo ra một đối tượng để lấy dữ liệu từ input
            PHIEUHANGHOA chitietphieu = new PHIEUHANGHOA
            {
                MAPHIEUNHAP = txt_maphieunhap.Text.Trim(),
                MASANPHAM = txt_masanpham.Text.Trim(),
                SOLUONG = int.Parse(txt_soluong.Text.Trim()),
                DONGIA = int.Parse(txt_dongia.Text.Trim())
            };

            // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu
            quanlysieuthi.PHIEUHANGHOAs.Add(chitietphieu);
            quanlysieuthi.SaveChanges();
        }

        // Function này thực hiện chức năng chỉnh sửa dữ liệu
        private void updateChitietphieunhap()
        {
            // Tìm kiếm nhân viên kho cần chỉnh sửa.
            PHIEUHANGHOA chitietphieu = quanlysieuthi.PHIEUHANGHOAs.Where(p => p.MAPHIEUNHAP == txt_maphieunhap.Text && p.MASANPHAM == txt_masanpham.Text).SingleOrDefault();
            chitietphieu.MASANPHAM = txt_masanpham.Text.Trim();
            chitietphieu.SOLUONG = int.Parse(txt_soluong.Text.Trim());
            chitietphieu.DONGIA = int.Parse(txt_dongia.Text.Trim());

            // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu.
            quanlysieuthi.SaveChanges();
            clearData();
        }



        // Function này sẽ lấy dữ liệu phiếu xuất từ cơ sở dữ liệu khi form được load.
        private void Menu_chitietphieunhap_Load(object sender, EventArgs e)
        {
            pHIEUHANGHOABindingSource.DataSource = quanlysieuthi.PHIEUHANGHOAs.ToList();
        }

        // Function này xử lý sự kiện thêm chi tiết phiếu nhập hàng.
        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opt = "1";
            pHIEUHANGHOABindingSource.AddNew();
            txt_maphieunhap.Focus();
        }

        // Function này xử lý sự kiện khi người dùng bấm vào nút lưu sẽ lưu thông tin đã nhập hoặc đã chỉnh sửa vào database.
        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra các ô input xem đã nhập hết chưa
            if (txt_maphieunhap.Text != "" && txt_masanpham.Text != "" && txt_soluong.Text != "" && txt_dongia.Text != "")
            {

                if (opt == "1")
                {
                    // Khi opt bằng 1 thì hệ thống sẽ thực hiện chức năng thêm
                    addChitietphieunhap();
                }
                else
                {
                    // Khi opt khác 1 thì hệ thống sẽ thực hiện chức năng update
                    updateChitietphieunhap();
                }
                opt = "";
                // Sau khi thực hiện thêm hoặc chỉnh sửa dữ liệu thì load lại dữ liệu.
                Menu_chitietphieunhap_Load(sender, e);

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
                // Tìm kiếm nhân viên kho mà người dùng đã chọn để xóa
                PHIEUHANGHOA chitietphieunhap = quanlysieuthi.PHIEUHANGHOAs.Where(p => p.MAPHIEUNHAP == txt_maphieunhap.Text && p.MASANPHAM == txt_masanpham.Text).SingleOrDefault();

                // Thực hiện xóa tài khoản đã chọn ra khỏi cơ sở dữ liệu
                quanlysieuthi.PHIEUHANGHOAs.Remove(chitietphieunhap);

                // Sau khi xóa thành công thì lưu dữ liệu mới sau khi xóa.
                quanlysieuthi.SaveChanges();
                Menu_chitietphieunhap_Load(sender, e);
                XtraMessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
