namespace Coach_Ticket_Management.Forms.ActionForms
{
    partial class PickChuyen
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
            this.dataGridView_thongtinchuyen = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbox_tuyen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpicker_ngaykhoihanh = new System.Windows.Forms.DateTimePicker();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_chon = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_thongtinchuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_thongtinchuyen
            // 
            this.dataGridView_thongtinchuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_thongtinchuyen.Location = new System.Drawing.Point(12, 116);
            this.dataGridView_thongtinchuyen.Name = "dataGridView_thongtinchuyen";
            this.dataGridView_thongtinchuyen.RowHeadersWidth = 51;
            this.dataGridView_thongtinchuyen.RowTemplate.Height = 24;
            this.dataGridView_thongtinchuyen.Size = new System.Drawing.Size(739, 298);
            this.dataGridView_thongtinchuyen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tuyến";
            // 
            // cbbox_tuyen
            // 
            this.cbbox_tuyen.FormattingEnabled = true;
            this.cbbox_tuyen.Location = new System.Drawing.Point(86, 23);
            this.cbbox_tuyen.Name = "cbbox_tuyen";
            this.cbbox_tuyen.Size = new System.Drawing.Size(201, 24);
            this.cbbox_tuyen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày khởi hành";
            // 
            // dtpicker_ngaykhoihanh
            // 
            this.dtpicker_ngaykhoihanh.Location = new System.Drawing.Point(539, 23);
            this.dtpicker_ngaykhoihanh.Name = "dtpicker_ngaykhoihanh";
            this.dtpicker_ngaykhoihanh.Size = new System.Drawing.Size(201, 22);
            this.dtpicker_ngaykhoihanh.TabIndex = 4;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(342, 66);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(96, 33);
            this.btn_timkiem.TabIndex = 5;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_chon
            // 
            this.btn_chon.Location = new System.Drawing.Point(283, 429);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Size = new System.Drawing.Size(112, 34);
            this.btn_chon.TabIndex = 6;
            this.btn_chon.Text = "Chọn";
            this.btn_chon.UseVisualStyleBackColor = true;
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(401, 429);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(112, 34);
            this.btn_huy.TabIndex = 7;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // PickChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 475);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_chon);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.dtpicker_ngaykhoihanh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbox_tuyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_thongtinchuyen);
            this.Name = "PickChuyen";
            this.Text = "CHỌN CHUYẾN";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_thongtinchuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_thongtinchuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbox_tuyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpicker_ngaykhoihanh;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_chon;
        private System.Windows.Forms.Button btn_huy;
    }
}