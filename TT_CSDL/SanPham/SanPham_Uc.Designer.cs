
namespace TT_CSDL
{
    partial class SanPham_Uc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.them_btn = new System.Windows.Forms.Button();
            this.sua_btn = new System.Windows.Forms.Button();
            this.xoa_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaGoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timkiem_btn = new System.Windows.Forms.Button();
            this.tensp_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loaisp_cb = new System.Windows.Forms.ComboBox();
            this.lammoi_btn = new System.Windows.Forms.Button();
            this.ngaynhap_dkp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ngaynhap_checkbox = new System.Windows.Forms.CheckBox();
            this.theloai_clb = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.themtheloai_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // them_btn
            // 
            this.them_btn.Location = new System.Drawing.Point(108, 22);
            this.them_btn.Name = "them_btn";
            this.them_btn.Size = new System.Drawing.Size(103, 39);
            this.them_btn.TabIndex = 0;
            this.them_btn.Text = "Thêm mới";
            this.them_btn.UseVisualStyleBackColor = true;
            this.them_btn.Click += new System.EventHandler(this.them_btn_Click);
            // 
            // sua_btn
            // 
            this.sua_btn.Location = new System.Drawing.Point(248, 22);
            this.sua_btn.Name = "sua_btn";
            this.sua_btn.Size = new System.Drawing.Size(103, 39);
            this.sua_btn.TabIndex = 1;
            this.sua_btn.Text = "Sửa";
            this.sua_btn.UseVisualStyleBackColor = true;
            this.sua_btn.Click += new System.EventHandler(this.sua_btn_Click);
            // 
            // xoa_btn
            // 
            this.xoa_btn.Location = new System.Drawing.Point(393, 22);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Size = new System.Drawing.Size(103, 39);
            this.xoa_btn.TabIndex = 2;
            this.xoa_btn.Text = "Xóa";
            this.xoa_btn.UseVisualStyleBackColor = true;
            this.xoa_btn.Click += new System.EventHandler(this.xoa_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.Ten,
            this.LoaiSP,
            this.NgayNhap,
            this.GiamGia,
            this.GiaGoc,
            this.GiaBan,
            this.TrangThai,
            this.SoLuong,
            this.GhiChu});
            this.dataGridView1.Location = new System.Drawing.Point(1, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 415);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // LoaiSP
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LoaiSP.DefaultCellStyle = dataGridViewCellStyle8;
            this.LoaiSP.HeaderText = "Loại sản phẩm";
            this.LoaiSP.Name = "LoaiSP";
            this.LoaiSP.ReadOnly = true;
            // 
            // NgayNhap
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NgayNhap.DefaultCellStyle = dataGridViewCellStyle9;
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // GiamGia
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GiamGia.DefaultCellStyle = dataGridViewCellStyle10;
            this.GiamGia.HeaderText = "Giảm giá";
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.ReadOnly = true;
            // 
            // GiaGoc
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.GiaGoc.DefaultCellStyle = dataGridViewCellStyle11;
            this.GiaGoc.HeaderText = "Giá gốc";
            this.GiaGoc.Name = "GiaGoc";
            this.GiaGoc.ReadOnly = true;
            // 
            // GiaBan
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.GiaBan.DefaultCellStyle = dataGridViewCellStyle12;
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // TrangThai
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TrangThai.DefaultCellStyle = dataGridViewCellStyle13;
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // SoLuong
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle14;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // timkiem_btn
            // 
            this.timkiem_btn.Location = new System.Drawing.Point(890, 93);
            this.timkiem_btn.Name = "timkiem_btn";
            this.timkiem_btn.Size = new System.Drawing.Size(87, 39);
            this.timkiem_btn.TabIndex = 4;
            this.timkiem_btn.Text = "Tìm kiếm";
            this.timkiem_btn.UseVisualStyleBackColor = true;
            this.timkiem_btn.Click += new System.EventHandler(this.timkiem_btn_Click);
            // 
            // tensp_tb
            // 
            this.tensp_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tensp_tb.Location = new System.Drawing.Point(219, 93);
            this.tensp_tb.Name = "tensp_tb";
            this.tensp_tb.Size = new System.Drawing.Size(238, 22);
            this.tensp_tb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(105, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(105, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Loại sản phẩm";
            // 
            // loaisp_cb
            // 
            this.loaisp_cb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.loaisp_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loaisp_cb.FormattingEnabled = true;
            this.loaisp_cb.Location = new System.Drawing.Point(220, 135);
            this.loaisp_cb.Name = "loaisp_cb";
            this.loaisp_cb.Size = new System.Drawing.Size(238, 21);
            this.loaisp_cb.TabIndex = 8;
            // 
            // lammoi_btn
            // 
            this.lammoi_btn.Location = new System.Drawing.Point(541, 22);
            this.lammoi_btn.Name = "lammoi_btn";
            this.lammoi_btn.Size = new System.Drawing.Size(103, 39);
            this.lammoi_btn.TabIndex = 9;
            this.lammoi_btn.Text = "Tải lại";
            this.lammoi_btn.UseVisualStyleBackColor = true;
            this.lammoi_btn.Click += new System.EventHandler(this.lammoi_btn_Click);
            // 
            // ngaynhap_dkp
            // 
            this.ngaynhap_dkp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ngaynhap_dkp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaynhap_dkp.Location = new System.Drawing.Point(221, 174);
            this.ngaynhap_dkp.Name = "ngaynhap_dkp";
            this.ngaynhap_dkp.Size = new System.Drawing.Size(237, 20);
            this.ngaynhap_dkp.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(103, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngày nhập";
            // 
            // ngaynhap_checkbox
            // 
            this.ngaynhap_checkbox.AutoSize = true;
            this.ngaynhap_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ngaynhap_checkbox.Location = new System.Drawing.Point(476, 177);
            this.ngaynhap_checkbox.Name = "ngaynhap_checkbox";
            this.ngaynhap_checkbox.Size = new System.Drawing.Size(15, 14);
            this.ngaynhap_checkbox.TabIndex = 12;
            this.ngaynhap_checkbox.UseVisualStyleBackColor = true;
            // 
            // theloai_clb
            // 
            this.theloai_clb.CheckOnClick = true;
            this.theloai_clb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.theloai_clb.FormattingEnabled = true;
            this.theloai_clb.Location = new System.Drawing.Point(597, 93);
            this.theloai_clb.Name = "theloai_clb";
            this.theloai_clb.Size = new System.Drawing.Size(186, 106);
            this.theloai_clb.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(519, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Thể loại";
            // 
            // themtheloai_btn
            // 
            this.themtheloai_btn.Location = new System.Drawing.Point(789, 93);
            this.themtheloai_btn.Name = "themtheloai_btn";
            this.themtheloai_btn.Size = new System.Drawing.Size(39, 34);
            this.themtheloai_btn.TabIndex = 32;
            this.themtheloai_btn.Text = "...";
            this.themtheloai_btn.UseVisualStyleBackColor = true;
            this.themtheloai_btn.Click += new System.EventHandler(this.themtheloai_btn_Click);
            // 
            // SanPham_Uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.themtheloai_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.theloai_clb);
            this.Controls.Add(this.ngaynhap_checkbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ngaynhap_dkp);
            this.Controls.Add(this.lammoi_btn);
            this.Controls.Add(this.loaisp_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tensp_tb);
            this.Controls.Add(this.timkiem_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.xoa_btn);
            this.Controls.Add(this.sua_btn);
            this.Controls.Add(this.them_btn);
            this.Name = "SanPham_Uc";
            this.Size = new System.Drawing.Size(1040, 635);
            this.Load += new System.EventHandler(this.SanPham_Uc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button them_btn;
        private System.Windows.Forms.Button sua_btn;
        private System.Windows.Forms.Button xoa_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button timkiem_btn;
        private System.Windows.Forms.TextBox tensp_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox loaisp_cb;
        private System.Windows.Forms.Button lammoi_btn;
        private System.Windows.Forms.DateTimePicker ngaynhap_dkp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ngaynhap_checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaGoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.CheckedListBox theloai_clb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button themtheloai_btn;
    }
}
