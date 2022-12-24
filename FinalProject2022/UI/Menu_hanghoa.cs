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
    public partial class Menu_hanghoa : UserControl
    {
        QUANLYSIEUTHIEntities2 quanlysieuthi = new QUANLYSIEUTHIEntities2();
        string opt = "";
        public Menu_hanghoa()
        {
            InitializeComponent();
        }

        // Function này sẽ xóa dữ liệu ở ô input để ta có thể nhập dữ liệu mới vào.
        public void clearData()
        {
            txt_masanpham.Text = txt_tensanpham.Text = cb_donvitinh.Text = dt_hansudung.Text = txt_maloai.Text =  "";
        }


        // Function này thực hiện chức năng thêm sản phẩm vào cơ sở dữ liệu.
        private void addHanghoa()
        {
            // Tạo ra một đối tượng để lấy dữ liệu từ input

            try
            {
                HANGHOA hanghoa = new HANGHOA
                {
                    MASANPHAM = txt_masanpham.Text.Trim(),
                    TENSANPHAM = txt_tensanpham.Text.Trim(),
                    HANSUDUNG = DateTime.Parse(dt_hansudung.Text.Trim()),
                    DONVITINH = cb_donvitinh.Text.Trim(),
                    MALOAI = txt_maloai.Text.Trim()
                };
                // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu
                quanlysieuthi.HANGHOAs.Add(hanghoa);
                quanlysieuthi.SaveChanges();
                XtraMessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                // Nếu không thành công thì thông báo lỗi.
                XtraMessageBox.Show("Sản phẩm này đã tồn tại hoặc mã loại không tồn tại, vui lòng xem lại dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Function này thực hiện chức năng chỉnh sửa dữ liệu
        private void updateHanghoa()
        {
            // Tìm kiếm hàng hóa cần chỉnh sửa.
            HANGHOA hanghoa = quanlysieuthi.HANGHOAs.Where(p => p.MASANPHAM == txt_masanpham.Text).SingleOrDefault();
            hanghoa.TENSANPHAM = txt_tensanpham.Text.Trim();
            hanghoa.HANSUDUNG = DateTime.Parse(dt_hansudung.Text.Trim());
            hanghoa.DONVITINH = cb_donvitinh.Text.Trim();
            hanghoa.MALOAI = txt_maloai.Text.Trim();

            // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu.
            quanlysieuthi.SaveChanges();
            clearData();
        }

        // Function này sẽ lấy dữ liệu hàng hóa từ cơ sở dữ liệu khi form được load.
        private void Menu_hanghoa_Load(object sender, EventArgs e)
        {
            hANGHOABindingSource.DataSource = quanlysieuthi.HANGHOAs.ToList();
        }

        // Function này xử lý sự kiện thêm hàng hóa vào cơ sở dữ liệu.
        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opt = "1";
            hANGHOABindingSource.AddNew();
            txt_masanpham.Focus();
        }

        // Function này xử lý sự kiện khi người dùng bấm vào nút lưu sẽ lưu thông tin đã nhập hoặc đã chỉnh sửa vào database.
        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra các ô input xem đã nhập hết chưa
            if (txt_masanpham.Text != "" && txt_tensanpham.Text != "" && cb_donvitinh.Text != "" && txt_maloai.Text != "")
            {

                if (opt == "1")
                {
                    // Khi opt bằng 1 thì hệ thống sẽ thực hiện chức năng thêm
                    addHanghoa();
                }
                else
                {
                    // Khi opt khác 1 thì hệ thống sẽ thực hiện chức năng update
                    updateHanghoa();
                    XtraMessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                opt = "";
                // Sau khi thực hiện thêm hoặc chỉnh sửa dữ liệu thì load lại dữ liệu.
                Menu_hanghoa_Load(sender, e);
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
                HANGHOA hanghoa = quanlysieuthi.HANGHOAs.Where(p => p.MASANPHAM == txt_masanpham.Text).SingleOrDefault();

                // Thực hiện xóa tài khoản đã chọn ra khỏi cơ sở dữ liệu
                quanlysieuthi.HANGHOAs.Remove(hanghoa);

                // Sau khi xóa thành công thì lưu dữ liệu mới sau khi xóa.
                quanlysieuthi.SaveChanges();
                Menu_hanghoa_Load(sender, e);
                XtraMessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
