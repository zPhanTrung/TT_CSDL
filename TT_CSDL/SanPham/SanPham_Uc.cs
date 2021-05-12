using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TT_CSDL.Entities;
using TT_CSDL.SanPham;


namespace TT_CSDL
{
    public partial class SanPham_Uc : UserControl
    {
        Shop db;
        
        List<SANPHAM> current_list = new List<SANPHAM>();
        public SanPham_Uc()
        {
            InitializeComponent();
            db = new Shop();
        }

        private void SanPham_Uc_Load(object sender, EventArgs e)
        {
            loaisp_cb.Items.Add("truyện");
            loaisp_cb.Items.Add("khác");
            db.THELOAIs.ToList().ForEach(s => theloai_clb.Items.Add(s.TenTheLoai));
            current_list = db.SANPHAMs.ToList();
            LoadData(current_list);
        }

        private void LoadData(List<SANPHAM> collection)
        {
            int index_row = -1;
            dataGridView1.Rows.Clear();
            foreach (SANPHAM item in collection)
            {
                dataGridView1.Rows.Add();
                index_row++;
                dataGridView1.Rows[index_row].Cells["MaSP"].Value = item.MaSP;
                dataGridView1.Rows[index_row].Cells["Ten"].Value = item.Ten;
                dataGridView1.Rows[index_row].Cells["LoaiSP"].Value = item.LoaiSP;
                dataGridView1.Rows[index_row].Cells["NgayNhap"].Value = item.NgayNhap;
                if (item.MaGG != null && item.PHIEUGIAMGIA.PhanTram != null)
                    dataGridView1.Rows[index_row].Cells["GiamGia"].Value = item.PHIEUGIAMGIA.PhanTram.ToString() + "%";
                else if(item.MaGG!=null)
                    dataGridView1.Rows[index_row].Cells["GiamGia"].Value = item.PHIEUGIAMGIA.SoTien.ToString();
                dataGridView1.Rows[index_row].Cells["GiaGoc"].Value = item.GiaGoc;
                dataGridView1.Rows[index_row].Cells["GiaBan"].Value = item.DonGia;
                if (item.MaTT != null)
                    dataGridView1.Rows[index_row].Cells["TrangThai"].Value = item.TRANGTHAI.TenTT;
                dataGridView1.Rows[index_row].Cells["SoLuong"].Value = item.SoLuong;
                dataGridView1.Rows[index_row].Cells["GhiChu"].Value = item.GhiChu;
            }
        }
        private void them_btn_Click(object sender, EventArgs e)
        {
            ThemSP_Form themsp = new ThemSP_Form();
            themsp.Show();
        }

        private void lammoi_btn_Click(object sender, EventArgs e)
        {
            db = new Shop();
            current_list = db.SANPHAMs.ToList();
            LoadData(current_list);
        }

        private void xoa_btn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            db = new Shop();
            SqlConnection connection = (SqlConnection)db.Database.Connection;
            connection.Open();
            SqlCommand cmd = new SqlCommand("xoaSANPHAM", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                var masp = dataGridView1.CurrentRow.Cells["MaSP"].Value.ToString();
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@MaSP", SqlDbType = SqlDbType.VarChar, Value = masp });
                var row_affect = cmd.ExecuteNonQuery();
                result = MessageBox.Show("Xóa thành công", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lammoi_btn.PerformClick();
            }
            catch
            {
                result = MessageBox.Show("Xóa không thành công", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
        }

        private void sua_btn_Click(object sender, EventArgs e)
        {
            ThemSP_Form themsp = new ThemSP_Form(db.SANPHAMs.Find(dataGridView1.CurrentRow.Cells["MaSP"].Value.ToString()));
            themsp.Show();
        }

        private void timkiem_btn_Click(object sender, EventArgs e)
        {
            List<SANPHAM> result = db.SANPHAMs.ToList();
           
            if (tensp_tb.Text != "" || loaisp_cb.Text != "" || ngaynhap_checkbox.Checked == true || theloai_clb.CheckedItems != null)
            {
                if (tensp_tb.Text != "")
                {
                    result = (from sp in result where sp.Ten.Contains(tensp_tb.Text) select sp).ToList();
                }
                if (loaisp_cb.Text != "")
                {
                    result = (from sp in result where sp.LoaiSP.Contains(loaisp_cb.Text) select sp).ToList();
                }
                if (ngaynhap_checkbox.Checked == true)
                {
                    result = (from sp in result where 
                              sp.NgayNhap.Value.Day.ToString().Equals(ngaynhap_dkp.Value.Day.ToString()) &&
                              sp.NgayNhap.Value.Month.ToString().Equals(ngaynhap_dkp.Value.Month.ToString()) &&
                              sp.NgayNhap.Value.Year.ToString().Equals(ngaynhap_dkp.Value.Year.ToString())
                              select sp).ToList();
                }
                if(theloai_clb.CheckedItems != null)
                {
                    foreach(var item in theloai_clb.CheckedItems)
                    {
                        result = (from sp in result
                                 join tl in db.TRUYEN_THELOAI on
                                    sp.MaSP equals tl.MaSP where tl.THELOAI.TenTheLoai == item.ToString()
                                 select sp).ToList();
                    }  
                }
                if(result!=null)
                {
                    current_list = result;
                    LoadData(current_list);
                }
            }
            else return;
        }

        private void themtheloai_btn_Click(object sender, EventArgs e)
        {
            ThemTheLoai_Form themtl = new ThemTheLoai_Form();
            themtl.Show();
        }
    }
}
