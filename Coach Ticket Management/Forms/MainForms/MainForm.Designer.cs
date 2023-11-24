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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýChuyếnXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTuyếnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiXếToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLBVXK = new Coach_Ticket_Management.Database.QLBVXK();
            this.qLBVXKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiVeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiVeTableAdapter = new Coach_Ticket_Management.Database.QLBVXKTableAdapters.LoaiVeTableAdapter();
            this.veXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veXeTableAdapter = new Coach_Ticket_Management.Database.QLBVXKTableAdapters.VeXeTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVXK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVXKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiVeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veXeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýChuyếnXeToolStripMenuItem,
            this.quảnLýXeToolStripMenuItem,
            this.quảnLýTuyếnToolStripMenuItem,
            this.quảnLýTàiXếToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1328, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(970, 537);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 656);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(1001, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 539);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 22);
            this.textBox2.TabIndex = 5;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chuyến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tuyến";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(1001, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 111);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hành động";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(433, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(216, 24);
            this.comboBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(433, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(216, 22);
            this.textBox3.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(777, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 22);
            this.dateTimePicker1.TabIndex = 13;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(756, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = global::Coach_Ticket_Management.Properties.Resources.save;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(163, 69);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 36);
            this.button5.TabIndex = 23;
            this.button5.Text = "Lưu";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::Coach_Ticket_Management.Properties.Resources.edit;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(6, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 36);
            this.button4.TabIndex = 22;
            this.button4.Text = "Sửa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::Coach_Ticket_Management.Properties.Resources.add;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(6, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 36);
            this.button2.TabIndex = 21;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::Coach_Ticket_Management.Properties.Resources.remove;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(163, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 36);
            this.button3.TabIndex = 20;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Image = global::Coach_Ticket_Management.Properties.Resources.user;
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // quảnLýChuyếnXeToolStripMenuItem
            // 
            this.quảnLýChuyếnXeToolStripMenuItem.Image = global::Coach_Ticket_Management.Properties.Resources.coaches;
            this.quảnLýChuyếnXeToolStripMenuItem.Name = "quảnLýChuyếnXeToolStripMenuItem";
            this.quảnLýChuyếnXeToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.quảnLýChuyếnXeToolStripMenuItem.Text = "Quản lý chuyến xe";
            // 
            // quảnLýXeToolStripMenuItem
            // 
            this.quảnLýXeToolStripMenuItem.Image = global::Coach_Ticket_Management.Properties.Resources.coach;
            this.quảnLýXeToolStripMenuItem.Name = "quảnLýXeToolStripMenuItem";
            this.quảnLýXeToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.quảnLýXeToolStripMenuItem.Text = "Quản lý xe";
            // 
            // quảnLýTuyếnToolStripMenuItem
            // 
            this.quảnLýTuyếnToolStripMenuItem.Image = global::Coach_Ticket_Management.Properties.Resources.route;
            this.quảnLýTuyếnToolStripMenuItem.Name = "quảnLýTuyếnToolStripMenuItem";
            this.quảnLýTuyếnToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.quảnLýTuyếnToolStripMenuItem.Text = "Quản lý tuyến";
            // 
            // quảnLýTàiXếToolStripMenuItem
            // 
            this.quảnLýTàiXếToolStripMenuItem.Image = global::Coach_Ticket_Management.Properties.Resources.driver;
            this.quảnLýTàiXếToolStripMenuItem.Name = "quảnLýTàiXếToolStripMenuItem";
            this.quảnLýTàiXếToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.quảnLýTàiXếToolStripMenuItem.Text = "Quản lý tài xế";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Image = global::Coach_Ticket_Management.Properties.Resources.settings;
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Cài đặt";
            // 
            // qLBVXK
            // 
            this.qLBVXK.DataSetName = "QLBVXK";
            this.qLBVXK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLBVXKBindingSource
            // 
            this.qLBVXKBindingSource.DataSource = this.qLBVXK;
            this.qLBVXKBindingSource.Position = 0;
            // 
            // loaiVeBindingSource
            // 
            this.loaiVeBindingSource.DataMember = "LoaiVe";
            this.loaiVeBindingSource.DataSource = this.qLBVXKBindingSource;
            // 
            // loaiVeTableAdapter
            // 
            this.loaiVeTableAdapter.ClearBeforeFill = true;
            // 
            // veXeBindingSource
            // 
            this.veXeBindingSource.DataMember = "VeXe";
            this.veXeBindingSource.DataSource = this.qLBVXKBindingSource;
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "QUẢN LÝ BÁN VÉ XE KHÁCH - CTMA";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLBVXK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVXKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiVeBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource qLBVXKBindingSource;
        private Database.QLBVXK qLBVXK;
        private System.Windows.Forms.BindingSource loaiVeBindingSource;
        private Database.QLBVXKTableAdapters.LoaiVeTableAdapter loaiVeTableAdapter;
        private System.Windows.Forms.BindingSource veXeBindingSource;
        private Database.QLBVXKTableAdapters.VeXeTableAdapter veXeTableAdapter;
    }
}
