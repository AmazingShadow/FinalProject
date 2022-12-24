namespace FinalProject2022.UI
{
    partial class Menu_hoadon
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_hoadon));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_luu = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHOADON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTONGTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHACHHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHITIETHOADONs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHACHHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_tongtien = new DevExpress.XtraEditors.TextEdit();
            this.dt_ngaytao = new DevExpress.XtraEditors.DateEdit();
            this.txt_makhachhang = new DevExpress.XtraEditors.TextEdit();
            this.txt_mahoadon = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tongtien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaytao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaytao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_makhachhang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mahoadon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3,
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_them,
            this.btn_xoa,
            this.btn_luu});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.FloatLocation = new System.Drawing.Point(210, 141);
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_them, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_luu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btn_them
            // 
            this.btn_them.Caption = "Thêm";
            this.btn_them.Id = 0;
            this.btn_them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.ImageOptions.Image")));
            this.btn_them.Name = "btn_them";
            this.btn_them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_them_ItemClick);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Caption = "Xóa";
            this.btn_xoa.Id = 1;
            this.btn_xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.ImageOptions.Image")));
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_xoa_ItemClick);
            // 
            // btn_luu
            // 
            this.btn_luu.Caption = "Lưu";
            this.btn_luu.Id = 2;
            this.btn_luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.ImageOptions.Image")));
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_luu_ItemClick);
            // 
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(907, 54);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 490);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(907, 18);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 54);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 436);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(907, 54);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 436);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.txt_tongtien);
            this.layoutControl1.Controls.Add(this.dt_ngaytao);
            this.layoutControl1.Controls.Add(this.txt_makhachhang);
            this.layoutControl1.Controls.Add(this.txt_mahoadon);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 54);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(907, 436);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.hOADONBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(476, 79);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(407, 333);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataSource = typeof(FinalProject2022.HOADON);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHOADON,
            this.colNGAYTAO,
            this.colTONGTIEN,
            this.colMAKHACHHANG,
            this.colCHITIETHOADONs,
            this.colKHACHHANG});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Tìm kiếm";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colMAHOADON
            // 
            this.colMAHOADON.AppearanceCell.BackColor = System.Drawing.Color.MediumAquamarine;
            this.colMAHOADON.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAHOADON.AppearanceCell.Options.UseBackColor = true;
            this.colMAHOADON.AppearanceCell.Options.UseFont = true;
            this.colMAHOADON.AppearanceHeader.BackColor = System.Drawing.Color.Turquoise;
            this.colMAHOADON.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAHOADON.AppearanceHeader.Options.UseBackColor = true;
            this.colMAHOADON.AppearanceHeader.Options.UseFont = true;
            this.colMAHOADON.Caption = "Mã hóa đơn";
            this.colMAHOADON.FieldName = "MAHOADON";
            this.colMAHOADON.MinWidth = 25;
            this.colMAHOADON.Name = "colMAHOADON";
            this.colMAHOADON.Visible = true;
            this.colMAHOADON.VisibleIndex = 0;
            this.colMAHOADON.Width = 94;
            // 
            // colNGAYTAO
            // 
            this.colNGAYTAO.AppearanceCell.BackColor = System.Drawing.Color.MediumAquamarine;
            this.colNGAYTAO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAYTAO.AppearanceCell.Options.UseBackColor = true;
            this.colNGAYTAO.AppearanceCell.Options.UseFont = true;
            this.colNGAYTAO.AppearanceHeader.BackColor = System.Drawing.Color.Turquoise;
            this.colNGAYTAO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAYTAO.AppearanceHeader.Options.UseBackColor = true;
            this.colNGAYTAO.AppearanceHeader.Options.UseFont = true;
            this.colNGAYTAO.Caption = "Ngày tạo";
            this.colNGAYTAO.FieldName = "NGAYTAO";
            this.colNGAYTAO.MinWidth = 25;
            this.colNGAYTAO.Name = "colNGAYTAO";
            this.colNGAYTAO.Visible = true;
            this.colNGAYTAO.VisibleIndex = 1;
            this.colNGAYTAO.Width = 94;
            // 
            // colTONGTIEN
            // 
            this.colTONGTIEN.AppearanceCell.BackColor = System.Drawing.Color.MediumAquamarine;
            this.colTONGTIEN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTONGTIEN.AppearanceCell.Options.UseBackColor = true;
            this.colTONGTIEN.AppearanceCell.Options.UseFont = true;
            this.colTONGTIEN.AppearanceHeader.BackColor = System.Drawing.Color.Turquoise;
            this.colTONGTIEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTONGTIEN.AppearanceHeader.Options.UseBackColor = true;
            this.colTONGTIEN.AppearanceHeader.Options.UseFont = true;
            this.colTONGTIEN.Caption = "Tổng tiền";
            this.colTONGTIEN.FieldName = "TONGTIEN";
            this.colTONGTIEN.MinWidth = 25;
            this.colTONGTIEN.Name = "colTONGTIEN";
            this.colTONGTIEN.Visible = true;
            this.colTONGTIEN.VisibleIndex = 2;
            this.colTONGTIEN.Width = 94;
            // 
            // colMAKHACHHANG
            // 
            this.colMAKHACHHANG.AppearanceCell.BackColor = System.Drawing.Color.MediumAquamarine;
            this.colMAKHACHHANG.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKHACHHANG.AppearanceCell.Options.UseBackColor = true;
            this.colMAKHACHHANG.AppearanceCell.Options.UseFont = true;
            this.colMAKHACHHANG.AppearanceHeader.BackColor = System.Drawing.Color.Turquoise;
            this.colMAKHACHHANG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKHACHHANG.AppearanceHeader.Options.UseBackColor = true;
            this.colMAKHACHHANG.AppearanceHeader.Options.UseFont = true;
            this.colMAKHACHHANG.Caption = "Mã khách hàng";
            this.colMAKHACHHANG.FieldName = "MAKHACHHANG";
            this.colMAKHACHHANG.MinWidth = 25;
            this.colMAKHACHHANG.Name = "colMAKHACHHANG";
            this.colMAKHACHHANG.Visible = true;
            this.colMAKHACHHANG.VisibleIndex = 3;
            this.colMAKHACHHANG.Width = 94;
            // 
            // colCHITIETHOADONs
            // 
            this.colCHITIETHOADONs.FieldName = "CHITIETHOADONs";
            this.colCHITIETHOADONs.MinWidth = 25;
            this.colCHITIETHOADONs.Name = "colCHITIETHOADONs";
            this.colCHITIETHOADONs.Width = 94;
            // 
            // colKHACHHANG
            // 
            this.colKHACHHANG.FieldName = "KHACHHANG";
            this.colKHACHHANG.MinWidth = 25;
            this.colKHACHHANG.Name = "colKHACHHANG";
            this.colKHACHHANG.Width = 94;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hOADONBindingSource, "TONGTIEN", true));
            this.txt_tongtien.Location = new System.Drawing.Point(200, 151);
            this.txt_tongtien.MenuManager = this.barManager1;
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien.Properties.Appearance.Options.UseFont = true;
            this.txt_tongtien.Size = new System.Drawing.Size(272, 28);
            this.txt_tongtien.StyleController = this.layoutControl1;
            this.txt_tongtien.TabIndex = 7;
            // 
            // dt_ngaytao
            // 
            this.dt_ngaytao.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hOADONBindingSource, "NGAYTAO", true));
            this.dt_ngaytao.EditValue = null;
            this.dt_ngaytao.Location = new System.Drawing.Point(200, 119);
            this.dt_ngaytao.MenuManager = this.barManager1;
            this.dt_ngaytao.Name = "dt_ngaytao";
            this.dt_ngaytao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngaytao.Properties.Appearance.Options.UseFont = true;
            this.dt_ngaytao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngaytao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngaytao.Size = new System.Drawing.Size(272, 28);
            this.dt_ngaytao.StyleController = this.layoutControl1;
            this.dt_ngaytao.TabIndex = 6;
            // 
            // txt_makhachhang
            // 
            this.txt_makhachhang.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hOADONBindingSource, "MAKHACHHANG", true));
            this.txt_makhachhang.Location = new System.Drawing.Point(200, 87);
            this.txt_makhachhang.MenuManager = this.barManager1;
            this.txt_makhachhang.Name = "txt_makhachhang";
            this.txt_makhachhang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makhachhang.Properties.Appearance.Options.UseFont = true;
            this.txt_makhachhang.Size = new System.Drawing.Size(272, 28);
            this.txt_makhachhang.StyleController = this.layoutControl1;
            this.txt_makhachhang.TabIndex = 5;
            // 
            // txt_mahoadon
            // 
            this.txt_mahoadon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hOADONBindingSource, "MAHOADON", true));
            this.txt_mahoadon.Location = new System.Drawing.Point(200, 55);
            this.txt_mahoadon.MenuManager = this.barManager1;
            this.txt_mahoadon.Name = "txt_mahoadon";
            this.txt_mahoadon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mahoadon.Properties.Appearance.Options.UseFont = true;
            this.txt_mahoadon.Size = new System.Drawing.Size(272, 28);
            this.txt_mahoadon.StyleController = this.layoutControl1;
            this.txt_mahoadon.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(907, 436);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup1.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(887, 416);
            this.layoutControlGroup1.Text = "Thông tin hóa đơn";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txt_mahoadon;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(452, 32);
            this.layoutControlItem1.Text = "Mã hóa đơn";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(164, 21);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txt_makhachhang;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(452, 32);
            this.layoutControlItem2.Text = "Mã khách hàng";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(164, 21);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.dt_ngaytao;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 64);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(452, 32);
            this.layoutControlItem3.Text = "Ngày tạo";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(164, 21);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.txt_tongtien;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(452, 265);
            this.layoutControlItem4.Text = "Tổng tiền";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(164, 21);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.gridControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(452, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(411, 361);
            this.layoutControlItem5.Text = "Danh sách hóa đơn";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(164, 21);
            // 
            // Menu_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Menu_hoadon";
            this.Size = new System.Drawing.Size(907, 508);
            this.Load += new System.EventHandler(this.Menu_hoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tongtien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaytao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaytao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_makhachhang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mahoadon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarButtonItem btn_xoa;
        private DevExpress.XtraBars.BarButtonItem btn_luu;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txt_tongtien;
        private DevExpress.XtraEditors.DateEdit dt_ngaytao;
        private DevExpress.XtraEditors.TextEdit txt_makhachhang;
        private DevExpress.XtraEditors.TextEdit txt_mahoadon;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHOADON;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTAO;
        private DevExpress.XtraGrid.Columns.GridColumn colTONGTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHACHHANG;
        private DevExpress.XtraGrid.Columns.GridColumn colCHITIETHOADONs;
        private DevExpress.XtraGrid.Columns.GridColumn colKHACHHANG;
    }
}
