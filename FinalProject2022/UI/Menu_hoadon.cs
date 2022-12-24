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
    public partial class Menu_hoadon : UserControl
    {
        QUANLYSIEUTHIEntities2 quanlysieuthi = new QUANLYSIEUTHIEntities2();
        string opt = "";

        public Menu_hoadon()
        {
            InitializeComponent();
        }

        // Function này sẽ xóa dữ liệu ở ô input để ta có thể nhập dữ liệu mới vào.
        public void clearData()
        {
            txt_mahoadon.Text = txt_makhachhang.Text = txt_tongtien.Text = "";
        }

        // Function này thực hiện chức năng thêm hóa đơn vào cơ sở dữ liệu.
        private void addHoadon()
        {
            // Tạo ra một đối tượng để lấy dữ liệu từ input
            HOADON hoadon = new HOADON
            {
                MAHOADON = txt_mahoadon.Text.Trim(),
                MAKHACHHANG = txt_makhachhang.Text.Trim(),
                NGAYTAO = DateTime.Parse(dt_ngaytao.Text.Trim()),
                TONGTIEN = int.Parse(txt_tongtien.Text.Trim())
            };

            // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu
            quanlysieuthi.HOADONs.Add(hoadon);
            quanlysieuthi.SaveChanges();
        }

        // Function này thực hiện chức năng chỉnh sửa dữ liệu
        private void updateHoadon()
        {
            // Tìm kiếm hóa đơn cần chỉnh sửa.
            HOADON hoadon = quanlysieuthi.HOADONs.Where(p => p.MAHOADON == txt_mahoadon.Text).SingleOrDefault();
            hoadon.MAKHACHHANG = txt_makhachhang.Text.Trim();
            hoadon.TONGTIEN = int.Parse(txt_tongtien.Text.Trim());

            // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu.
            quanlysieuthi.SaveChanges();
            clearData();
        }

        // Function này sẽ lấy dữ liệu hóa đơn từ cơ sở dữ liệu khi form được load.
        private void Menu_hoadon_Load(object sender, EventArgs e)
        {
            hOADONBindingSource.DataSource = quanlysieuthi.HOADONs.ToList();
        }

        // Function này xử lý sự kiện thêm chi tiết phiếu nhập hàng.
        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opt = "1";
            hOADONBindingSource.AddNew();
            txt_mahoadon.Focus();
        }

        // Function này xử lý sự kiện khi người dùng bấm vào nút lưu sẽ lưu thông tin đã nhập hoặc đã chỉnh sửa vào database.
        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra các ô input xem đã nhập hết chưa
            if (txt_mahoadon.Text != "" && txt_makhachhang.Text != "" && dt_ngaytao.Text != "" && txt_tongtien.Text != "")
            {

                if (opt == "1")
                {
                    // Khi opt bằng 1 thì hệ thống sẽ thực hiện chức năng thêm
                    addHoadon();
                }
                else
                {
                    // Khi opt khác 1 thì hệ thống sẽ thực hiện chức năng update
                    updateHoadon();
                }
                opt = "";
                // Sau khi thực hiện thêm hoặc chỉnh sửa dữ liệu thì load lại dữ liệu.
                Menu_hoadon_Load(sender, e);

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
                HOADON hoadon = quanlysieuthi.HOADONs.Where(p => p.MAHOADON == txt_mahoadon.Text).SingleOrDefault();

                // Thực hiện xóa tài khoản đã chọn ra khỏi cơ sở dữ liệu
                quanlysieuthi.HOADONs.Remove(hoadon);

                // Sau khi xóa thành công thì lưu dữ liệu mới sau khi xóa.
                quanlysieuthi.SaveChanges();
                Menu_hoadon_Load(sender, e);
                XtraMessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
