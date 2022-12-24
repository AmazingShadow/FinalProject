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
    public partial class Menu_chitiethoadon : UserControl
    {
        QUANLYSIEUTHIEntities2 quanlysieuthi = new QUANLYSIEUTHIEntities2();
        string opt = "";
        public Menu_chitiethoadon()
        {
            InitializeComponent();
        }

        // Function này sẽ xóa dữ liệu ở ô input để ta có thể nhập dữ liệu mới vào.
        public void clearData()
        {
            txt_mahoadon.Text = txt_masanpham.Text = txt_soluong.Text = txt_dongia.Text = "";
        }

        // Function này thực hiện chức năng thêm chi tiết hóa đơn vào cơ sở dữ liệu.
        private void addChitiethoadon()
        {
            // Tạo ra một đối tượng để lấy dữ liệu từ input
            CHITIETHOADON chitiethoadon = new CHITIETHOADON
            {
                MAHOADON = txt_mahoadon.Text.Trim(),
                MASANPHAM = txt_masanpham.Text.Trim(),
                SOLUONG = int.Parse(txt_soluong.Text.Trim()),
                DONGIA = int.Parse(txt_dongia.Text.Trim())
            };

            try
            {
                // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu
                quanlysieuthi.CHITIETHOADONs.Add(chitiethoadon);
                quanlysieuthi.SaveChanges();
                XtraMessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK);
            } catch(Exception e)
            {
                // Nếu không thành công thì thông báo lỗi.
                XtraMessageBox.Show("Hóa đơn này chưa được tạo ra, vui lòng xem lại dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Function này thực hiện chức năng chỉnh sửa dữ liệu
        private void updateChitiethoadon()
        {
            // Tìm kiếm hóa đơn cần chỉnh sửa.
            CHITIETHOADON chitiethoadon = quanlysieuthi.CHITIETHOADONs.Where(p => p.MAHOADON == txt_mahoadon.Text && p.MASANPHAM == txt_masanpham.Text).SingleOrDefault();
            chitiethoadon.SOLUONG = int.Parse(txt_soluong.Text.Trim());
            chitiethoadon.DONGIA = int.Parse(txt_dongia.Text.Trim());

            // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu.
            quanlysieuthi.SaveChanges();
            clearData();
        }

        // Function này sẽ lấy dữ liệu phiếu xuất từ cơ sở dữ liệu khi form được load.
        private void Menu_chitiethoadon_Load(object sender, EventArgs e)
        {
            cHITIETHOADONBindingSource.DataSource = quanlysieuthi.CHITIETHOADONs.ToList();
        }

        // Function này xử lý sự kiện thêm chi tiết hóa đơn.
        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opt = "1";
            cHITIETHOADONBindingSource.AddNew();
            txt_mahoadon.Focus();
        }

        // Function này xử lý sự kiện khi người dùng bấm vào nút lưu sẽ lưu thông tin đã nhập hoặc đã chỉnh sửa vào database.
        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra các ô input xem đã nhập hết chưa
            if (txt_mahoadon.Text != "" && txt_masanpham.Text != "" && txt_soluong.Text != "" && txt_dongia.Text != "")
            {

                if (opt == "1")
                {
                    // Khi opt bằng 1 thì hệ thống sẽ thực hiện chức năng thêm
                    addChitiethoadon();
                }
                else
                {
                    // Khi opt khác 1 thì hệ thống sẽ thực hiện chức năng update
                    updateChitiethoadon();
                    XtraMessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                opt = "";
                // Sau khi thực hiện thêm hoặc chỉnh sửa dữ liệu thì load lại dữ liệu.
                Menu_chitiethoadon_Load(sender, e);
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
                CHITIETHOADON chitiethoadon = quanlysieuthi.CHITIETHOADONs.Where(p => p.MAHOADON == txt_mahoadon.Text && p.MASANPHAM == txt_masanpham.Text).SingleOrDefault();

                // Thực hiện xóa tài khoản đã chọn ra khỏi cơ sở dữ liệu
                quanlysieuthi.CHITIETHOADONs.Remove(chitiethoadon);

                // Sau khi xóa thành công thì lưu dữ liệu mới sau khi xóa.
                quanlysieuthi.SaveChanges();
                Menu_chitiethoadon_Load(sender, e);
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
        // Bắt sự kiện nhập vào ô input số lượng.
        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkInputNumber(e);
        }
    }
}
