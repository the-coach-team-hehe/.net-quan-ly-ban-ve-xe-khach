namespace Coach_Ticket_Management.Forms.MainForms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýChuyếnXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTuyếnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiXếToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_thongtinvexe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_showall = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpicker_ngaykhoihanh = new System.Windows.Forms.DateTimePicker();
            this.tb_machuyen = new System.Windows.Forms.TextBox();
            this.cbbox_tuyen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tenkhachhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mavexe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_inve = new System.Windows.Forms.Button();
            this.cbbox2_soghe = new System.Windows.Forms.ComboBox();
            this.tb2_tuyen = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb2_ngaykhoihanh = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbox2_loaive = new System.Windows.Forms.ComboBox();
            this.btn_toPickChuyen = new System.Windows.Forms.Button();
            this.tb2_giave = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb2_machuyen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb2_nhanvienbanve = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb2_tenkhachhang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb2_mave = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.loaiVeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBVXKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBVXK = new Coach_Ticket_Management.Database.QLBVXK();
            this.veXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiVeTableAdapter = new Coach_Ticket_Management.Database.QLBVXKTableAdapters.LoaiVeTableAdapter();
            this.veXeTableAdapter = new Coach_Ticket_Management.Database.QLBVXKTableAdapters.VeXeTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_thongtinvexe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiVeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVXKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVXK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veXeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýChuyếnXeToolStripMenuItem,
            this.quảnLýXeToolStripMenuItem,
            this.quảnLýTuyếnToolStripMenuItem,
            this.quảnLýTàiXếToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1328, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Image = global::Coach_Ticket_Management.Properties.Resources.user;
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýChuyếnXeToolStripMenuItem
            // 
            this.quảnLýChuyếnXeToolStripMenuItem.Image = global::Coach_Ticket_Management.Properties.Resources.coaches;
            this.quảnLýChuyếnXeToolStripMenuItem.Name = "quảnLýChuyếnXeToolStripMenuItem";
            this.quảnLýChuyếnXeToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.quảnLýChuyếnXeToolStripMenuItem.Text = "Quản lý chuyến xe";
            this.quảnLýChuyếnXeToolStripMenuItem.Click += new System.EventHandler(this.quảnLýChuyếnXeToolStripMenuItem_Click);
            // 
            // quảnLýXeToolStripMenuItem
            // 
            this.quảnLýXeToolStripMenuItem.Image = global::Coach_Ticket_Management.Properties.Resources.coach;
            this.quảnLýXeToolStripMenuItem.Name = "quảnLýXeToolStripMenuItem";
            this.quảnLýXeToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.quảnLýXeToolStripMenuItem.Text = "Quản lý xe";
            this.quảnLýXeToolStripMenuItem.Click += new System.EventHandler(this.quảnLýXeToolStripMenuItem_Click);
            // 
            // quảnLýTuyếnToolStripMenuItem
            // 
            this.quảnLýTuyếnToolStripMenuItem.Image = global::Coach_Ticket_Management.Properties.Resources.route;
            this.quảnLýTuyếnToolStripMenuItem.Name = "quảnLýTuyếnToolStripMenuItem";
            this.quảnLýTuyếnToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.quảnLýTuyếnToolStripMenuItem.Text = "Quản lý tuyến";
            this.quảnLýTuyếnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTuyếnToolStripMenuItem_Click);
            // 
            // quảnLýTàiXếToolStripMenuItem
            // 
            this.quảnLýTàiXếToolStripMenuItem.Image = global::Coach_Ticket_Management.Properties.Resources.driver;
            this.quảnLýTàiXếToolStripMenuItem.Name = "quảnLýTàiXếToolStripMenuItem";
            this.quảnLýTàiXếToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.quảnLýTàiXếToolStripMenuItem.Text = "Quản lý tài xế";
            this.quảnLýTàiXếToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTàiXếToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Image = global::Coach_Ticket_Management.Properties.Resources.report__1_;
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            this.báoCáoToolStripMenuItem.Click += new System.EventHandler(this.báoCáoToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Image = global::Coach_Ticket_Management.Properties.Resources.settings;
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Cài đặt";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // dataGridView_thongtinvexe
            // 
            this.dataGridView_thongtinvexe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_thongtinvexe.Location = new System.Drawing.Point(6, 113);
            this.dataGridView_thongtinvexe.Name = "dataGridView_thongtinvexe";
            this.dataGridView_thongtinvexe.RowHeadersWidth = 51;
            this.dataGridView_thongtinvexe.RowTemplate.Height = 24;
            this.dataGridView_thongtinvexe.Size = new System.Drawing.Size(944, 537);
            this.dataGridView_thongtinvexe.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_showall);
            this.groupBox1.Controls.Add(this.btn_timkiem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpicker_ngaykhoihanh);
            this.groupBox1.Controls.Add(this.tb_machuyen);
            this.groupBox1.Controls.Add(this.cbbox_tuyen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_tenkhachhang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_mavexe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView_thongtinvexe);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 656);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // btn_showall
            // 
            this.btn_showall.Location = new System.Drawing.Point(831, 62);
            this.btn_showall.Name = "btn_showall";
            this.btn_showall.Size = new System.Drawing.Size(119, 25);
            this.btn_showall.TabIndex = 16;
            this.btn_showall.Text = "Hiển thị tất cả";
            this.btn_showall.UseVisualStyleBackColor = true;
            this.btn_showall.Click += new System.EventHandler(this.btn_showall_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(708, 61);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(117, 25);
            this.btn_timkiem.TabIndex = 15;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày khởi hành";
            // 
            // dtpicker_ngaykhoihanh
            // 
            this.dtpicker_ngaykhoihanh.Location = new System.Drawing.Point(777, 26);
            this.dtpicker_ngaykhoihanh.Name = "dtpicker_ngaykhoihanh";
            this.dtpicker_ngaykhoihanh.Size = new System.Drawing.Size(173, 22);
            this.dtpicker_ngaykhoihanh.TabIndex = 13;
            // 
            // tb_machuyen
            // 
            this.tb_machuyen.Location = new System.Drawing.Point(433, 26);
            this.tb_machuyen.Name = "tb_machuyen";
            this.tb_machuyen.Size = new System.Drawing.Size(216, 22);
            this.tb_machuyen.TabIndex = 12;
            // 
            // cbbox_tuyen
            // 
            this.cbbox_tuyen.FormattingEnabled = true;
            this.cbbox_tuyen.Location = new System.Drawing.Point(433, 62);
            this.cbbox_tuyen.Name = "cbbox_tuyen";
            this.cbbox_tuyen.Size = new System.Drawing.Size(216, 24);
            this.cbbox_tuyen.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tuyến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã chuyến";
            // 
            // tb_tenkhachhang
            // 
            this.tb_tenkhachhang.Location = new System.Drawing.Point(132, 62);
            this.tb_tenkhachhang.Name = "tb_tenkhachhang";
            this.tb_tenkhachhang.Size = new System.Drawing.Size(208, 22);
            this.tb_tenkhachhang.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên khách hàng";
            // 
            // tb_mavexe
            // 
            this.tb_mavexe.Location = new System.Drawing.Point(132, 24);
            this.tb_mavexe.Name = "tb_mavexe";
            this.tb_mavexe.Size = new System.Drawing.Size(208, 22);
            this.tb_mavexe.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã vé xe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_inve);
            this.groupBox2.Controls.Add(this.cbbox2_soghe);
            this.groupBox2.Controls.Add(this.tb2_tuyen);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tb2_ngaykhoihanh);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbbox2_loaive);
            this.groupBox2.Controls.Add(this.btn_toPickChuyen);
            this.groupBox2.Controls.Add(this.tb2_giave);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb2_machuyen);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb2_nhanvienbanve);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb2_tenkhachhang);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb2_mave);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(978, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 493);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // btn_inve
            // 
            this.btn_inve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inve.Location = new System.Drawing.Point(125, 446);
            this.btn_inve.Name = "btn_inve";
            this.btn_inve.Size = new System.Drawing.Size(97, 41);
            this.btn_inve.TabIndex = 28;
            this.btn_inve.Text = "In vé";
            this.btn_inve.UseVisualStyleBackColor = true;
            this.btn_inve.Click += new System.EventHandler(this.btn_inve_Click);
            // 
            // cbbox2_soghe
            // 
            this.cbbox2_soghe.FormattingEnabled = true;
            this.cbbox2_soghe.Location = new System.Drawing.Point(134, 214);
            this.cbbox2_soghe.Name = "cbbox2_soghe";
            this.cbbox2_soghe.Size = new System.Drawing.Size(198, 24);
            this.cbbox2_soghe.TabIndex = 27;
            // 
            // tb2_tuyen
            // 
            this.tb2_tuyen.Location = new System.Drawing.Point(134, 105);
            this.tb2_tuyen.Name = "tb2_tuyen";
            this.tb2_tuyen.Size = new System.Drawing.Size(198, 22);
            this.tb2_tuyen.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Tuyến";
            // 
            // tb2_ngaykhoihanh
            // 
            this.tb2_ngaykhoihanh.Location = new System.Drawing.Point(134, 133);
            this.tb2_ngaykhoihanh.Name = "tb2_ngaykhoihanh";
            this.tb2_ngaykhoihanh.Size = new System.Drawing.Size(198, 22);
            this.tb2_ngaykhoihanh.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Ngày khởi hành";
            // 
            // cbbox2_loaive
            // 
            this.cbbox2_loaive.FormattingEnabled = true;
            this.cbbox2_loaive.Location = new System.Drawing.Point(134, 186);
            this.cbbox2_loaive.Name = "cbbox2_loaive";
            this.cbbox2_loaive.Size = new System.Drawing.Size(198, 24);
            this.cbbox2_loaive.TabIndex = 21;
            // 
            // btn_toPickChuyen
            // 
            this.btn_toPickChuyen.Location = new System.Drawing.Point(243, 159);
            this.btn_toPickChuyen.Name = "btn_toPickChuyen";
            this.btn_toPickChuyen.Size = new System.Drawing.Size(89, 23);
            this.btn_toPickChuyen.TabIndex = 20;
            this.btn_toPickChuyen.Text = "Chọn chuyến";
            this.btn_toPickChuyen.UseVisualStyleBackColor = true;
            this.btn_toPickChuyen.Click += new System.EventHandler(this.btn_toPickChuyen_Click);
            // 
            // tb2_giave
            // 
            this.tb2_giave.Location = new System.Drawing.Point(134, 244);
            this.tb2_giave.Name = "tb2_giave";
            this.tb2_giave.Size = new System.Drawing.Size(198, 22);
            this.tb2_giave.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "Giá vé";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Số ghế";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Loại vé";
            // 
            // tb2_machuyen
            // 
            this.tb2_machuyen.Location = new System.Drawing.Point(134, 160);
            this.tb2_machuyen.Name = "tb2_machuyen";
            this.tb2_machuyen.Size = new System.Drawing.Size(103, 22);
            this.tb2_machuyen.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Chuyến";
            // 
            // tb2_nhanvienbanve
            // 
            this.tb2_nhanvienbanve.Location = new System.Drawing.Point(134, 77);
            this.tb2_nhanvienbanve.Name = "tb2_nhanvienbanve";
            this.tb2_nhanvienbanve.Size = new System.Drawing.Size(198, 22);
            this.tb2_nhanvienbanve.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nhân viên bán vé";
            // 
            // tb2_tenkhachhang
            // 
            this.tb2_tenkhachhang.Location = new System.Drawing.Point(134, 49);
            this.tb2_tenkhachhang.Name = "tb2_tenkhachhang";
            this.tb2_tenkhachhang.Size = new System.Drawing.Size(198, 22);
            this.tb2_tenkhachhang.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Họ tên khách hàng";
            // 
            // tb2_mave
            // 
            this.tb2_mave.Location = new System.Drawing.Point(134, 21);
            this.tb2_mave.Name = "tb2_mave";
            this.tb2_mave.Size = new System.Drawing.Size(198, 22);
            this.tb2_mave.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã vé";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_huy);
            this.groupBox3.Controls.Add(this.btn_luu);
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Controls.Add(this.btn_xoa);
            this.groupBox3.Location = new System.Drawing.Point(978, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 157);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hành động";
            // 
            // btn_huy
            // 
            this.btn_huy.Image = global::Coach_Ticket_Management.Properties.Resources.cancel_24;
            this.btn_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huy.Location = new System.Drawing.Point(6, 111);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(146, 36);
            this.btn_huy.TabIndex = 24;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Image = global::Coach_Ticket_Management.Properties.Resources.save;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(163, 69);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(146, 36);
            this.btn_luu.TabIndex = 23;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = global::Coach_Ticket_Management.Properties.Resources.edit;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(6, 69);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(146, 36);
            this.btn_sua.TabIndex = 22;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Image = global::Coach_Ticket_Management.Properties.Resources.add;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(6, 27);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(146, 36);
            this.btn_them.TabIndex = 21;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = global::Coach_Ticket_Management.Properties.Resources.remove;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(163, 27);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(146, 36);
            this.btn_xoa.TabIndex = 20;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // loaiVeBindingSource
            // 
            this.loaiVeBindingSource.DataMember = "LoaiVe";
            this.loaiVeBindingSource.DataSource = this.qLBVXKBindingSource;
            // 
            // qLBVXKBindingSource
            // 
            this.qLBVXKBindingSource.DataSource = this.qLBVXK;
            this.qLBVXKBindingSource.Position = 0;
            // 
            // qLBVXK
            // 
            this.qLBVXK.DataSetName = "QLBVXK";
            this.qLBVXK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veXeBindingSource
            // 
            this.veXeBindingSource.DataMember = "VeXe";
            this.veXeBindingSource.DataSource = this.qLBVXKBindingSource;
            // 
            // loaiVeTableAdapter
            // 
            this.loaiVeTableAdapter.ClearBeforeFill = true;
            // 
            // veXeTableAdapter
            // 
            this.veXeTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1328, 699);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "QUẢN LÝ BÁN VÉ XE KHÁCH - CTMA";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_thongtinvexe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loaiVeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVXKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVXK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veXeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýChuyếnXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTuyếnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiXếToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_thongtinvexe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpicker_ngaykhoihanh;
        private System.Windows.Forms.TextBox tb_machuyen;
        private System.Windows.Forms.ComboBox cbbox_tuyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tenkhachhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_mavexe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.BindingSource qLBVXKBindingSource;
        private Database.QLBVXK qLBVXK;
        private System.Windows.Forms.BindingSource loaiVeBindingSource;
        private Database.QLBVXKTableAdapters.LoaiVeTableAdapter loaiVeTableAdapter;
        private System.Windows.Forms.BindingSource veXeBindingSource;
        private Database.QLBVXKTableAdapters.VeXeTableAdapter veXeTableAdapter;
        private System.Windows.Forms.ComboBox cbbox2_soghe;
        private System.Windows.Forms.TextBox tb2_tuyen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb2_ngaykhoihanh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbox2_loaive;
        private System.Windows.Forms.Button btn_toPickChuyen;
        private System.Windows.Forms.TextBox tb2_giave;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb2_machuyen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb2_nhanvienbanve;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb2_tenkhachhang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb2_mave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.Button btn_showall;
        private System.Windows.Forms.Button btn_inve;
    }
}
