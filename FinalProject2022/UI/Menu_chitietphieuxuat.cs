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
    public partial class Menu_chitietphieuxuat : UserControl
    {
        QUANLYSIEUTHIEntities2 quanlysieuthi = new QUANLYSIEUTHIEntities2();
        string opt = "";
        public Menu_chitietphieuxuat()
        {
            InitializeComponent();
        }

        // Function này sẽ xóa dữ liệu ở ô input để ta có thể nhập dữ liệu mới vào.
        public void clearData()
        {
            txt_maphieuxuat.Text = txt_masanpham.Text = txt_soluong.Text = txt_dongia.Text = "";
        }

        // Function này thực hiện chức năng thêm chi tiết phiếu xuất kho vào cơ sở dữ liệu.
        private void addChitietphieuxuat()
        {
            // Tạo ra một đối tượng để lấy dữ liệu từ input
            PHIEUHANGXUAT phieuxuat = new PHIEUHANGXUAT()
            {
                MAPHIEUXUAT = txt_maphieuxuat.Text.Trim(),
                MASANPHAM = txt_masanpham.Text.Trim(),
                SOLUONG = int.Parse(txt_soluong.Text.Trim()),
                DONGIA = int.Parse(txt_dongia.Text.Trim())
            };

            // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu
            quanlysieuthi.PHIEUHANGXUATs.Add(phieuxuat);
            quanlysieuthi.SaveChanges();
        }

        // Function này thực hiện chức năng chỉnh sửa dữ liệu
        private void updateChitietphieuxuat()
        {
            // Tìm kiếm chi tiết phiếu cần chỉnh sửa cần chỉnh sửa.
            PHIEUHANGXUAT phieuxuat = quanlysieuthi.PHIEUHANGXUATs.Where(p => p.MAPHIEUXUAT == txt_maphieuxuat.Text && p.MASANPHAM == txt_masanpham.Text ).SingleOrDefault();
            phieuxuat.SOLUONG = int.Parse(txt_soluong.Text.Trim());
            phieuxuat.DONGIA = int.Parse(txt_dongia.Text.Trim());

            // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu.
            quanlysieuthi.SaveChanges();
            clearData();
        }

        // Function này sẽ lấy dữ liệu phiếu xuất từ cơ sở dữ liệu khi form được load.
        private void Menu_chitietphieuxuat_Load(object sender, EventArgs e)
        {
            pHIEUHANGXUATBindingSource.DataSource = quanlysieuthi.PHIEUHANGXUATs.ToList();
        }

        // Function này xử lý sự kiện thêm chi tiết phiếu xuất hàng.
        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opt = "1";
            pHIEUHANGXUATBindingSource.AddNew();
            txt_maphieuxuat.Focus();
        }

        // Function này xử lý sự kiện khi người dùng bấm vào nút lưu sẽ lưu thông tin đã nhập hoặc đã chỉnh sửa vào database.
        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra các ô input xem đã nhập hết chưa
            if (txt_maphieuxuat.Text != "" && txt_masanpham.Text != "" && txt_soluong.Text != "" && txt_dongia.Text != "")
            {

                if (opt == "1")
                {
                    // Khi opt bằng 1 thì hệ thống sẽ thực hiện chức năng thêm
                    addChitietphieuxuat();
                }
                else
                {
                    // Khi opt khác 1 thì hệ thống sẽ thực hiện chức năng update
                    updateChitietphieuxuat();
                }
                opt = "";
                // Sau khi thực hiện thêm hoặc chỉnh sửa dữ liệu thì load lại dữ liệu.
                Menu_chitietphieuxuat_Load(sender, e);

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
                PHIEUHANGXUAT phieuxuat = quanlysieuthi.PHIEUHANGXUATs.Where(p => p.MAPHIEUXUAT == txt_maphieuxuat.Text && p.MASANPHAM == txt_masanpham.Text).SingleOrDefault();

                // Thực hiện xóa tài khoản đã chọn ra khỏi cơ sở dữ liệu
                quanlysieuthi.PHIEUHANGXUATs.Remove(phieuxuat);

                // Sau khi xóa thành công thì lưu dữ liệu mới sau khi xóa.
                quanlysieuthi.SaveChanges();
                Menu_chitietphieuxuat_Load(sender, e);
                XtraMessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
