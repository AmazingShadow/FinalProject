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
    public partial class Menu_Phieunhap : UserControl
    {
        QUANLYSIEUTHIEntities2 quanlysieuthi = new QUANLYSIEUTHIEntities2();
        string opt = "";
        public Menu_Phieunhap()
        {
            InitializeComponent();
        }

        // Function này sẽ xóa dữ liệu ở ô input để ta có thể nhập dữ liệu mới vào.
        public void clearData()
        {
            txt_maphieunhap.Text = txt.Text = dt_ngaynhap.Text = cb_tenkho.Text = cb_donvivanchuyen.Text = txt_nguoigiaohang.Text = txt_diachi.Text = txt_thanhtien.Text = txt_manhanvien.Text = "";
        }

        // Function này thực hiện chức năng thêm phiếu nhập kho vào cơ sở dữ liệu.
        private void addPhieunhapkho()
        {
            try
            {
                PHIEUNHAP phieunhap = new PHIEUNHAP
                {
                    MAPHIEUNHAP = txt_maphieunhap.Text.Trim(),
                    TENNHACUNGCAP = txt.Text.Trim(),
                    NGAYNHAP = DateTime.Parse(dt_ngaynhap.Text.Trim()),
                    TENKHONHAP = cb_tenkho.Text.Trim(),
                    DONVIVANCHUYEN = cb_donvivanchuyen.Text.Trim(),
                    HOTENNGUOIGIAOHANG = txt_nguoigiaohang.Text.Trim(),
                    DIACHIKHO = txt_diachi.Text.Trim(),
                    THANHTIEN = float.Parse(txt_thanhtien.Text.Trim()),
                    MANHANVIEN = txt_manhanvien.Text.Trim(),
                };

                // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu
                quanlysieuthi.PHIEUNHAPs.Add(phieunhap);
                quanlysieuthi.SaveChanges();
                XtraMessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK);
            } catch(Exception ex)
            {
                XtraMessageBox.Show("Phiếu đã tồn tại, vui lòng xem lại dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Function này thực hiện chức năng chỉnh sửa dữ liệu phiếu nhập hàng.
        private void updatePhieunhaphang()
        {
            // Tìm kiếm nhân viên kho cần chỉnh sửa.
            PHIEUNHAP phieunhap = quanlysieuthi.PHIEUNHAPs.Where(p => p.MAPHIEUNHAP == txt_maphieunhap.Text).SingleOrDefault();
            phieunhap.TENNHACUNGCAP = txt_nhacungcap.Text.Trim();
            phieunhap.NGAYNHAP = DateTime.Parse(dt_ngaynhap.Text.Trim());
            phieunhap.TENKHONHAP = cb_tenkho.Text.Trim();
            phieunhap.DONVIVANCHUYEN = cb_donvivanchuyen.Text.Trim();
            phieunhap.HOTENNGUOIGIAOHANG = txt_nguoigiaohang.Text.Trim();
            phieunhap.DIACHIKHO = txt_diachi.Text.Trim();
            phieunhap.MANHANVIEN = txt_manhanvien.Text.Trim();
         
            // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu.
            quanlysieuthi.SaveChanges();
            clearData();
            XtraMessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK);
        }


        // Function này dùng để load dữ liệu phiếu nhập hàng từ database lên form khi form được load.
        private void Menu_Phieunhap_Load(object sender, EventArgs e)
        {
            pHIEUNHAPBindingSource2.DataSource = quanlysieuthi.PHIEUNHAPs.ToList();
        }

        // Function này xử lý sự kiện thêm phiếu nhập hàng mới vào cơ sở dữ liệu.
        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opt = "1";
            pHIEUNHAPBindingSource2.AddNew();
            txt_maphieunhap.Focus();
        }

        // Function này xử lý sự kiện khi người dùng bấm vào nút lưu sẽ lưu thông tin đã nhập hoặc đã chỉnh sửa vào database.
        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra các ô input xem đã nhập hết chưa
            if (txt_maphieunhap.Text != "" && txt.Text != "" && dt_ngaynhap.Text != "" && cb_tenkho.Text != "" && cb_donvivanchuyen.Text != "" && txt_nguoigiaohang.Text != "" && txt_diachi.Text != "" && txt_manhanvien.Text != "")
            {

                if (opt == "1")
                {
                    // Khi opt bằng 1 thì hệ thống sẽ thực hiện chức năng thêm
                    addPhieunhapkho();
                }
                else
                {
                    // Khi opt khác 1 thì hệ thống sẽ thực hiện chức năng update
                    updatePhieunhaphang();
                }
                opt = "";
                // Sau khi thực hiện thêm hoặc chỉnh sửa dữ liệu thì load lại dữ liệu.
                Menu_Phieunhap_Load(sender, e);

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
                PHIEUNHAP phieunhap = quanlysieuthi.PHIEUNHAPs.Where(p => p.MAPHIEUNHAP == txt_maphieunhap.Text).SingleOrDefault();

                // Thực hiện xóa tài khoản đã chọn ra khỏi cơ sở dữ liệu
                quanlysieuthi.PHIEUNHAPs.Remove(phieunhap);

                // Sau khi xóa thành công thì lưu dữ liệu mới sau khi xóa.
                quanlysieuthi.SaveChanges();
                Menu_Phieunhap_Load(sender, e);
                XtraMessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
