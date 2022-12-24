namespace FinalProject2022.UI
{
    partial class Menu_Phieuxuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Phieuxuat));
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
            this.pHIEUXUATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPHIEUXUAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIADIEMXUAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYXUAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLYDOXUAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANHANVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHANVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHANGHOAs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_manhanvien = new DevExpress.XtraEditors.TextEdit();
            this.cb_diadiem = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_lydo = new DevExpress.XtraEditors.TextEdit();
            this.dt_ngayxuat = new DevExpress.XtraEditors.DateEdit();
            this.txt_maphieuxuat = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUXUATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manhanvien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_diadiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_lydo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngayxuat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngayxuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maphieuxuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(1267, 54);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 558);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1267, 18);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 54);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 504);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1267, 54);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 504);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.txt_manhanvien);
            this.layoutControl1.Controls.Add(this.cb_diadiem);
            this.layoutControl1.Controls.Add(this.txt_lydo);
            this.layoutControl1.Controls.Add(this.dt_ngayxuat);
            this.layoutControl1.Controls.Add(this.txt_maphieuxuat);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 54);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1267, 504);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.pHIEUXUATBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 187);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1243, 305);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // pHIEUXUATBindingSource
            // 
            this.pHIEUXUATBindingSource.DataSource = typeof(FinalProject2022.PHIEUXUAT);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPHIEUXUAT,
            this.colDIADIEMXUAT,
            this.colNGAYXUAT,
            this.colLYDOXUAT,
            this.colMANHANVIEN,
            this.colNHANVIEN,
            this.colHANGHOAs});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Tìm kiếm";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colMAPHIEUXUAT
            // 
            this.colMAPHIEUXUAT.AppearanceCell.BackColor = System.Drawing.Color.MediumAquamarine;
            this.colMAPHIEUXUAT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAPHIEUXUAT.AppearanceCell.Options.UseBackColor = true;
            this.colMAPHIEUXUAT.AppearanceCell.Options.UseFont = true;
            this.colMAPHIEUXUAT.AppearanceHeader.BackColor = System.Drawing.Color.Turquoise;
            this.colMAPHIEUXUAT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAPHIEUXUAT.AppearanceHeader.Options.UseBackColor = true;
            this.colMAPHIEUXUAT.AppearanceHeader.Options.UseFont = true;
            this.colMAPHIEUXUAT.Caption = "Mã phiếu xuất";
            this.colMAPHIEUXUAT.FieldName = "MAPHIEUXUAT";
            this.colMAPHIEUXUAT.MinWidth = 25;
            this.colMAPHIEUXUAT.Name = "colMAPHIEUXUAT";
            this.colMAPHIEUXUAT.Visible = true;
            this.colMAPHIEUXUAT.VisibleIndex = 0;
            this.colMAPHIEUXUAT.Width = 94;
            // 
            // colDIADIEMXUAT
            // 
            this.colDIADIEMXUAT.AppearanceCell.BackColor = System.Drawing.Color.MediumAquamarine;
            this.colDIADIEMXUAT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDIADIEMXUAT.AppearanceCell.Options.UseBackColor = true;
            this.colDIADIEMXUAT.AppearanceCell.Options.UseFont = true;
            this.colDIADIEMXUAT.AppearanceHeader.BackColor = System.Drawing.Color.Turquoise;
            this.colDIADIEMXUAT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDIADIEMXUAT.AppearanceHeader.Options.UseBackColor = true;
            this.colDIADIEMXUAT.AppearanceHeader.Options.UseFont = true;
            this.colDIADIEMXUAT.Caption = "Địa điểm xuất";
            this.colDIADIEMXUAT.FieldName = "DIADIEMXUAT";
            this.colDIADIEMXUAT.MinWidth = 25;
            this.colDIADIEMXUAT.Name = "colDIADIEMXUAT";
            this.colDIADIEMXUAT.Visible = true;
            this.colDIADIEMXUAT.VisibleIndex = 1;
            this.colDIADIEMXUAT.Width = 94;
            // 
            // colNGAYXUAT
            // 
            this.colNGAYXUAT.AppearanceCell.BackColor = System.Drawing.Color.MediumAquamarine;
            this.colNGAYXUAT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAYXUAT.AppearanceCell.Options.UseBackColor = true;
            this.colNGAYXUAT.AppearanceCell.Options.UseFont = true;
            this.colNGAYXUAT.AppearanceHeader.BackColor = System.Drawing.Color.Turquoise;
            this.colNGAYXUAT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAYXUAT.AppearanceHeader.Options.UseBackColor = true;
            this.colNGAYXUAT.AppearanceHeader.Options.UseFont = true;
            this.colNGAYXUAT.Caption = "Ngày xuất";
            this.colNGAYXUAT.FieldName = "NGAYXUAT";
            this.colNGAYXUAT.MinWidth = 25;
            this.colNGAYXUAT.Name = "colNGAYXUAT";
            this.colNGAYXUAT.Visible = true;
            this.colNGAYXUAT.VisibleIndex = 2;
            this.colNGAYXUAT.Width = 94;
            // 
            // colLYDOXUAT
            // 
            this.colLYDOXUAT.AppearanceCell.BackColor = System.Drawing.Color.MediumAquamarine;
            this.colLYDOXUAT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLYDOXUAT.AppearanceCell.Options.UseBackColor = true;
            this.colLYDOXUAT.AppearanceCell.Options.UseFont = true;
            this.colLYDOXUAT.AppearanceHeader.BackColor = System.Drawing.Color.Turquoise;
            this.colLYDOXUAT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLYDOXUAT.AppearanceHeader.Options.UseBackColor = true;
            this.colLYDOXUAT.AppearanceHeader.Options.UseFont = true;
            this.colLYDOXUAT.Caption = "Lý do xuất";
            this.colLYDOXUAT.FieldName = "LYDOXUAT";
            this.colLYDOXUAT.MinWidth = 25;
            this.colLYDOXUAT.Name = "colLYDOXUAT";
            this.colLYDOXUAT.Visible = true;
            this.colLYDOXUAT.VisibleIndex = 3;
            this.colLYDOXUAT.Width = 94;
            // 
            // colMANHANVIEN
            // 
            this.colMANHANVIEN.AppearanceCell.BackColor = System.Drawing.Color.MediumAquamarine;
            this.colMANHANVIEN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMANHANVIEN.AppearanceCell.Options.UseBackColor = true;
            this.colMANHANVIEN.AppearanceCell.Options.UseFont = true;
            this.colMANHANVIEN.AppearanceHeader.BackColor = System.Drawing.Color.Turquoise;
            this.colMANHANVIEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMANHANVIEN.AppearanceHeader.Options.UseBackColor = true;
            this.colMANHANVIEN.AppearanceHeader.Options.UseFont = true;
            this.colMANHANVIEN.Caption = "Mã nhân viên";
            this.colMANHANVIEN.FieldName = "MANHANVIEN";
            this.colMANHANVIEN.MinWidth = 25;
            this.colMANHANVIEN.Name = "colMANHANVIEN";
            this.colMANHANVIEN.Visible = true;
            this.colMANHANVIEN.VisibleIndex = 4;
            this.colMANHANVIEN.Width = 94;
            // 
            // colNHANVIEN
            // 
            this.colNHANVIEN.FieldName = "NHANVIEN";
            this.colNHANVIEN.MinWidth = 25;
            this.colNHANVIEN.Name = "colNHANVIEN";
            this.colNHANVIEN.Width = 94;
            // 
            // colHANGHOAs
            // 
            this.colHANGHOAs.FieldName = "HANGHOAs";
            this.colHANGHOAs.MinWidth = 25;
            this.colHANGHOAs.Name = "colHANGHOAs";
            this.colHANGHOAs.Width = 94;
            // 
            // txt_manhanvien
            // 
            this.txt_manhanvien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pHIEUXUATBindingSource, "MANHANVIEN", true));
            this.txt_manhanvien.Location = new System.Drawing.Point(1000, 87);
            this.txt_manhanvien.MenuManager = this.barManager1;
            this.txt_manhanvien.Name = "txt_manhanvien";
            this.txt_manhanvien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manhanvien.Properties.Appearance.Options.UseFont = true;
            this.txt_manhanvien.Size = new System.Drawing.Size(243, 28);
            this.txt_manhanvien.StyleController = this.layoutControl1;
            this.txt_manhanvien.TabIndex = 8;
            // 
            // cb_diadiem
            // 
            this.cb_diadiem.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pHIEUXUATBindingSource, "DIADIEMXUAT", true));
            this.cb_diadiem.Location = new System.Drawing.Point(1000, 55);
            this.cb_diadiem.MenuManager = this.barManager1;
            this.cb_diadiem.Name = "cb_diadiem";
            this.cb_diadiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_diadiem.Properties.Appearance.Options.UseFont = true;
            this.cb_diadiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_diadiem.Properties.Items.AddRange(new object[] {
            "Kho A",
            "Kho B",
            "Kho C",
            "Kho D"});
            this.cb_diadiem.Size = new System.Drawing.Size(243, 28);
            this.cb_diadiem.StyleController = this.layoutControl1;
            this.cb_diadiem.TabIndex = 7;
            // 
            // txt_lydo
            // 
            this.txt_lydo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pHIEUXUATBindingSource, "LYDOXUAT", true));
            this.txt_lydo.Location = new System.Drawing.Point(221, 119);
            this.txt_lydo.MenuManager = this.barManager1;
            this.txt_lydo.Name = "txt_lydo";
            this.txt_lydo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lydo.Properties.Appearance.Options.UseFont = true;
            this.txt_lydo.Size = new System.Drawing.Size(578, 28);
            this.txt_lydo.StyleController = this.layoutControl1;
            this.txt_lydo.TabIndex = 6;
            // 
            // dt_ngayxuat
            // 
            this.dt_ngayxuat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pHIEUXUATBindingSource, "NGAYXUAT", true));
            this.dt_ngayxuat.EditValue = null;
            this.dt_ngayxuat.Location = new System.Drawing.Point(221, 87);
            this.dt_ngayxuat.MenuManager = this.barManager1;
            this.dt_ngayxuat.Name = "dt_ngayxuat";
            this.dt_ngayxuat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngayxuat.Properties.Appearance.Options.UseFont = true;
            this.dt_ngayxuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngayxuat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngayxuat.Size = new System.Drawing.Size(578, 28);
            this.dt_ngayxuat.StyleController = this.layoutControl1;
            this.dt_ngayxuat.TabIndex = 5;
            // 
            // txt_maphieuxuat
            // 
            this.txt_maphieuxuat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pHIEUXUATBindingSource, "MAPHIEUXUAT", true));
            this.txt_maphieuxuat.Location = new System.Drawing.Point(221, 55);
            this.txt_maphieuxuat.MenuManager = this.barManager1;
            this.txt_maphieuxuat.Name = "txt_maphieuxuat";
            this.txt_maphieuxuat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maphieuxuat.Properties.Appearance.Options.UseFont = true;
            this.txt_maphieuxuat.Size = new System.Drawing.Size(578, 28);
            this.txt_maphieuxuat.StyleController = this.layoutControl1;
            this.txt_maphieuxuat.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1267, 504);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(1247, 151);
            this.layoutControlGroup1.Text = "Thông tin phiếu xuất";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txt_maphieuxuat;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(779, 32);
            this.layoutControlItem1.Text = "Mã phiếu xuất";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(185, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.dt_ngayxuat;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(779, 32);
            this.layoutControlItem2.Text = "Ngày xuất hàng";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(185, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.txt_lydo;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 64);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(779, 32);
            this.layoutControlItem3.Text = "Lý do xuất hàng";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(185, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.cb_diadiem;
            this.layoutControlItem4.Location = new System.Drawing.Point(779, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(444, 32);
            this.layoutControlItem4.Text = "Địa điểm xuất";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(185, 18);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.txt_manhanvien;
            this.layoutControlItem5.Location = new System.Drawing.Point(779, 32);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(444, 64);
            this.layoutControlItem5.Text = "Mã nhân viên";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(185, 18);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.gridControl1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 151);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(1247, 333);
            this.layoutControlItem6.Text = "Danh sách phiếu xuất";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(185, 21);
            // 
            // Menu_Phieuxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Menu_Phieuxuat";
            this.Size = new System.Drawing.Size(1267, 576);
            this.Load += new System.EventHandler(this.Menu_Phieuxuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUXUATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manhanvien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_diadiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_lydo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngayxuat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngayxuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maphieuxuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
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
        private System.Windows.Forms.BindingSource pHIEUXUATBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHIEUXUAT;
        private DevExpress.XtraGrid.Columns.GridColumn colDIADIEMXUAT;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYXUAT;
        private DevExpress.XtraGrid.Columns.GridColumn colLYDOXUAT;
        private DevExpress.XtraGrid.Columns.GridColumn colMANHANVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNHANVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHANGHOAs;
        private DevExpress.XtraEditors.TextEdit txt_manhanvien;
        private DevExpress.XtraEditors.ComboBoxEdit cb_diadiem;
        private DevExpress.XtraEditors.TextEdit txt_lydo;
        private DevExpress.XtraEditors.DateEdit dt_ngayxuat;
        private DevExpress.XtraEditors.TextEdit txt_maphieuxuat;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}
