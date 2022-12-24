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
    public partial class Menu_loaihanghoa : UserControl
    {
        QUANLYSIEUTHIEntities2 quanlysieuthi = new QUANLYSIEUTHIEntities2();
        string opt = "";

        public Menu_loaihanghoa()
        {
            InitializeComponent();
        }

        // Function này sẽ xóa dữ liệu ở ô input để ta có thể nhập dữ liệu mới vào.
        public void clearData()
        {
            txt_maloaihang.Text = txt_tenloai.Text = "";
        }

        // Function này thực hiện chức năng thêm loại sản phẩm vào cơ sở dữ liệu.
        private void addLoaihanghoa()
        {
            // Tạo ra một đối tượng để lấy dữ liệu từ input
            LOAIHANGHOA loaihanghoa = new LOAIHANGHOA
            {
                MALOAI = txt_maloaihang.Text.Trim(),
                TENLOAI = txt_tenloai.Text.Trim()
            };

            try
            {
                // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu
                quanlysieuthi.LOAIHANGHOAs.Add(loaihanghoa);
                quanlysieuthi.SaveChanges();
                XtraMessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                // Nếu không thành công thì thông báo lỗi.
                XtraMessageBox.Show("Loại hàng này đã tồn tại, vui lòng xem lại dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Function này thực hiện chức năng chỉnh sửa dữ liệu
        private void updateLoaihanghoa()
        {
            // Tìm kiếm hóa đơn cần chỉnh sửa.
            LOAIHANGHOA loaihanghoa = quanlysieuthi.LOAIHANGHOAs.Where(p => p.MALOAI == txt_maloaihang.Text).SingleOrDefault();
            loaihanghoa.TENLOAI = txt_tenloai.Text.Trim();
            
            // Thực hiện lưu dữ liệu vừa nhập vào cơ sở dữ liệu.
            quanlysieuthi.SaveChanges();
            clearData();
        }

        // Function này sẽ lấy dữ liệu loại hàng hóa từ cơ sở dữ liệu khi form được load.
        private void Menu_loaihanghoa_Load(object sender, EventArgs e)
        {
            lOAIHANGHOABindingSource.DataSource = quanlysieuthi.LOAIHANGHOAs.ToList();
        }

        // Function này xử lý sự kiện thêm loại hàng hóa.
        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opt = "1";
            lOAIHANGHOABindingSource.AddNew();
            txt_maloaihang.Focus();
        }

        // Function này xử lý sự kiện khi người dùng bấm vào nút lưu sẽ lưu thông tin đã nhập hoặc đã chỉnh sửa vào database.
        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra các ô input xem đã nhập hết chưa
            if (txt_maloaihang.Text != "" && txt_tenloai.Text != "")
            {

                if (opt == "1")
                {
                    // Khi opt bằng 1 thì hệ thống sẽ thực hiện chức năng thêm
                    addLoaihanghoa();
                }
                else
                {
                    // Khi opt khác 1 thì hệ thống sẽ thực hiện chức năng update
                    updateLoaihanghoa();
                    XtraMessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                opt = "";
                // Sau khi thực hiện thêm hoặc chỉnh sửa dữ liệu thì load lại dữ liệu.
                Menu_loaihanghoa_Load(sender, e);
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
                LOAIHANGHOA loaihanghoa = quanlysieuthi.LOAIHANGHOAs.Where(p => p.MALOAI == txt_maloaihang.Text).SingleOrDefault();

                // Thực hiện xóa tài khoản đã chọn ra khỏi cơ sở dữ liệu
                quanlysieuthi.LOAIHANGHOAs.Remove(loaihanghoa);

                // Sau khi xóa thành công thì lưu dữ liệu mới sau khi xóa.
                quanlysieuthi.SaveChanges();
                Menu_loaihanghoa_Load(sender, e);
                XtraMessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
