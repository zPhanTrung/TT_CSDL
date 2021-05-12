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

namespace TT_CSDL.SanPham
{
    public partial class ThemSP_Form : Form
    {
        private Shop db;
        SqlConnection connection;
        public ThemSP_Form()
        {
            InitializeComponent();
            db = new Shop();
            connection = (SqlConnection)db.Database.Connection;
            connection.Open();
            loaisp_cb.Items.Add("Truyện");
            loaisp_cb.Items.Add("Khác");
            loaisp_cb.SelectedItem = loaisp_cb.Items[0];
            db.THELOAIs.ToList().ForEach(s => theloai_clb.Items.Add(s.TenTheLoai));
            var res = db.TRANGTHAIs.ToList();
            foreach (TRANGTHAI item in res)
            {
                if(item.MaTT=="0"||item.MaTT=="1"||item.MaTT=="2")
                {
                    trangthai_cb.Items.Add(item.TenTT);
                }
            }
            ngaynhap_dkp.Value = DateTime.Today;
            
        }
        public ThemSP_Form(SANPHAM sp)
        {
            
            InitializeComponent();
            db = new Shop();
            connection = (SqlConnection)db.Database.Connection;
            connection.Open();
            loaisp_cb.Items.Add("Truyện");
            loaisp_cb.Items.Add("Khác");
            var res = db.TRANGTHAIs.ToList();
            foreach (TRANGTHAI item in res)
            {
                if (item.MaTT == "0" || item.MaTT == "1" || item.MaTT == "2")
                {
                    trangthai_cb.Items.Add(item.TenTT);
                }
            }

            ngaynhap_dkp.Value = DateTime.Today;
            masp_tb.Text = sp.MaSP;
            tensp_tb.Text = sp.Ten;
            loaisp_cb.Text = sp.LoaiSP;
            var phieugg = (from p in db.PHIEUGIAMGIAs where p.SuDung == true select p).ToList();
            phieugg.ForEach(s => magg_cb.Items.Add(s.MaGG));
            db.THELOAIs.ToList().ForEach(s => theloai_clb.Items.Add(s.TenTheLoai));

            if (sp.LoaiSP=="Truyện")
            {
                loaisp_cb.SelectedItem = loaisp_cb.Items[0];
                if (sp.TRUYEN != null)
                {
                    nxb_tb.Text = sp.TRUYEN.NhaXuatBan.ToString();
                    namxb_tb.Text = sp.TRUYEN.NamXB;
                    tacgia_tb.Text = sp.TRUYEN.TacGia;
                    quocgia_tb.Text = sp.TRUYEN.QuocGia;
                    var truyen_theloai_list = (from t in db.TRUYEN_THELOAI where t.MaSP == sp.MaSP select t).ToList();
                    for (int i = 0; i < theloai_clb.Items.Count; i++) 
                    {
                        foreach(var tt in truyen_theloai_list)
                        {
                            if(tt.THELOAI.TenTheLoai==theloai_clb.Items[i].ToString())
                            {
                                theloai_clb.SetItemChecked(i, true);
                            }
                        }
                    }
                }   
            }
            else if (sp.LoaiSP == "Khác")
            {
                loaisp_cb.SelectedItem = loaisp_cb.Items[1];
                xuatxu_tb.Text = sp.SPKHAC.XuatXu;
                ngaysx_dtp.Text = sp.SPKHAC.NgaySX.Value.ToString();
                hansd_dtp.Text = sp.SPKHAC.HanSD.Value.ToString();
            }

            ngaynhap_dkp.Value = DateTime.Parse(sp.NgayNhap.Value.ToString());
            magg_cb.Text = sp.MaGG;
            giagoc_tb.Text = sp.GiaGoc.ToString();
            giaban_tb.Text = sp.DonGia.ToString();
            if (sp.MaTT != null)
                trangthai_cb.Text = sp.TRANGTHAI.TenTT;
            soluong_tb.Text = sp.SoLuong.ToString();
            ghichu_tb.Text = sp.GhiChu;
        }

        private void them_btn_Click(object sender, EventArgs e)
        {
            DialogResult result;

            SqlCommand cmd = new SqlCommand("themSANPHAM", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            var tt = db.TRANGTHAIs.Where(s => s.TenTT.Equals(trangthai_cb.Text)).SingleOrDefault();
            var magg = db.PHIEUGIAMGIAs.Find(magg_cb.Text);
            try
            {
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@MaSP", SqlDbType = SqlDbType.VarChar, Value = masp_tb.Text });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@Ten", SqlDbType = SqlDbType.NVarChar, Value = tensp_tb.Text });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@LoaiSP", SqlDbType = SqlDbType.NVarChar, Value = loaisp_cb.Text });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@NgayNhap", SqlDbType = SqlDbType.DateTime, Value = ngaynhap_dkp.Text });
                if (magg != null)
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@MaGG", SqlDbType = SqlDbType.VarChar, Value = magg_cb.Text });
                if (giagoc_tb.Text != "")
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@GiaGoc", SqlDbType = SqlDbType.Money, Value = Convert.ToDecimal(giagoc_tb.Text) });
                if (giaban_tb.Text != "")
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@DonGia", SqlDbType = SqlDbType.Money, Value = Convert.ToDecimal(giaban_tb.Text) });
                if (tt != null)
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@MaTT", SqlDbType = SqlDbType.VarChar, Value = tt.MaTT });
                if (soluong_tb.Text != "")
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@SoLuong", SqlDbType = SqlDbType.SmallInt, Value = Convert.ToInt16(soluong_tb.Text) });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@GhiChu", SqlDbType = SqlDbType.VarChar, Value = ghichu_tb.Text });
            }
            catch
            {
                result = MessageBox.Show("Nhập sai dữ liệu", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //thêm vào bảng truyện vào spkhac
            if (loaisp_cb.Text == "Truyện")
            {
                SqlCommand cmd1 = new SqlCommand("themTRUYEN", connection);
                cmd1.CommandType = CommandType.StoredProcedure;     

                try
                {
                    cmd1.Parameters.Add(new SqlParameter { ParameterName = "@MaSP", SqlDbType = SqlDbType.VarChar, Value = masp_tb.Text });
                    cmd1.Parameters.Add(new SqlParameter { ParameterName = "@NXB", SqlDbType = SqlDbType.NVarChar, Value = nxb_tb.Text });
                    cmd1.Parameters.Add(new SqlParameter { ParameterName = "@Nam", SqlDbType = SqlDbType.VarChar, Value = namxb_tb.Text });
                    cmd1.Parameters.Add(new SqlParameter { ParameterName = "@TacGia", SqlDbType = SqlDbType.NVarChar, Value = tacgia_tb.Text });
                    cmd1.Parameters.Add(new SqlParameter { ParameterName = "@QuocGia", SqlDbType = SqlDbType.NVarChar, Value = quocgia_tb.Text });
                }
                catch
                {
                    result = MessageBox.Show("Nhập sai dữ liệu", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    var row_affect = cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();

                    if (theloai_clb.CheckedItems != null)
                    {
                        foreach (var item in theloai_clb.CheckedItems)
                        {
                            SqlCommand cmd2 = new SqlCommand("themTRUYEN_THELOAI", connection);
                            cmd2.CommandType = CommandType.StoredProcedure;
                            var res = db.THELOAIs.Where(s => s.TenTheLoai.Equals(item.ToString())).Single();
                            cmd2.Parameters.Add(new SqlParameter { ParameterName = "@MaSP", SqlDbType = SqlDbType.VarChar, Value = masp_tb.Text });
                            cmd2.Parameters.Add(new SqlParameter { ParameterName = "@MaTHELOAI", SqlDbType = SqlDbType.Int, Value = res.MaTheLoai });
                            cmd2.ExecuteNonQuery();
                        }
                    }

                    if (row_affect != 0)
                        result = MessageBox.Show("Thêm thành công", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    result = MessageBox.Show("Thêm không thành công", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (loaisp_cb.Text == "Khác")
            {
                SqlCommand cmd1 = new SqlCommand("themSPKHAC", connection);
                cmd1.CommandType = CommandType.StoredProcedure;
                try
                {
                    cmd1.Parameters.Add(new SqlParameter { ParameterName = "@MaSP", SqlDbType = SqlDbType.VarChar, Value = masp_tb.Text });
                    cmd1.Parameters.Add(new SqlParameter { ParameterName = "@XuatXu", SqlDbType = SqlDbType.NVarChar, Value = nxb_tb.Text });
                    cmd1.Parameters.Add(new SqlParameter { ParameterName = "@NgaySX", SqlDbType = SqlDbType.VarChar, Value = namxb_tb.Text });
                    cmd1.Parameters.Add(new SqlParameter { ParameterName = "@HanSD", SqlDbType = SqlDbType.NVarChar, Value = tacgia_tb.Text });
                }
                catch
                {
                    result = MessageBox.Show("Nhập sai dữ liệu", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    var row_affect = cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    if (row_affect != 0)
                        result = MessageBox.Show("Thêm thành công", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    result = MessageBox.Show("Thêm không thành công", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void sua_btn_Click(object sender, EventArgs e)
        {
            DialogResult result;

            SqlCommand cmd = new SqlCommand("suaSANPHAM", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            var tt = db.TRANGTHAIs.Where(s => s.TenTT.Equals(trangthai_cb.Text)).SingleOrDefault();
            var magg = db.PHIEUGIAMGIAs.Find(magg_cb.Text);
            try
            {
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@MaSP", SqlDbType = SqlDbType.VarChar, Value = masp_tb.Text });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@Ten", SqlDbType = SqlDbType.NVarChar, Value = tensp_tb.Text });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@LoaiSP", SqlDbType = SqlDbType.NVarChar, Value = loaisp_cb.Text });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@NgayNhap", SqlDbType = SqlDbType.DateTime, Value = DateTime.Parse(ngaynhap_dkp.Text) });
                if (magg != null)
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@MaGG", SqlDbType = SqlDbType.VarChar, Value = magg_cb.Text });
                if (giagoc_tb.Text != "")
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@GiaGoc", SqlDbType = SqlDbType.Decimal, Value = Convert.ToDecimal(giagoc_tb.Text) });
                if (giaban_tb.Text != "")
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@DonGia", SqlDbType = SqlDbType.Decimal, Value = Convert.ToDecimal(giaban_tb.Text) });
                if (tt != null)
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@MaTT", SqlDbType = SqlDbType.VarChar, Value = tt.MaTT });
                if (soluong_tb.Text != "")
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@SoLuong", SqlDbType = SqlDbType.SmallInt, Value = Convert.ToInt16(soluong_tb.Text) });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@GhiChu", SqlDbType = SqlDbType.VarChar, Value = ghichu_tb.Text });
            }
            catch
            {
                result = MessageBox.Show("Nhập sai dữ liệu", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var sp = db.SANPHAMs.Find(masp_tb.Text.ToString());
            if (sp == null)
            {
                result = MessageBox.Show("Mã sản phẩm không đúng", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SqlCommand cmd1 = null;
            SqlCommand cmd2 = null;
            SqlCommand cmd3 = null;
            if (loaisp_cb.Text=="Truyện")
            {
                if (sp.LoaiSP=="Truyện")
                {
                    cmd1 = new SqlCommand("suaTRUYEN", connection);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        cmd1.Parameters.Add(new SqlParameter { ParameterName = "@MaSP", SqlDbType = SqlDbType.VarChar, Value = masp_tb.Text });
                        cmd1.Parameters.Add(new SqlParameter { ParameterName = "@NXB", SqlDbType = SqlDbType.NVarChar, Value = nxb_tb.Text });
                        cmd1.Parameters.Add(new SqlParameter { ParameterName = "@Nam", SqlDbType = SqlDbType.VarChar, Value = namxb_tb.Text });
                        cmd1.Parameters.Add(new SqlParameter { ParameterName = "@TacGia", SqlDbType = SqlDbType.NVarChar, Value = tacgia_tb.Text });
                        cmd1.Parameters.Add(new SqlParameter { ParameterName = "@QuocGia", SqlDbType = SqlDbType.NVarChar, Value = quocgia_tb.Text });
                    }
                    catch
                    {
                        result = MessageBox.Show("Nhập sai dữ liệu", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // thêm vào bảng TRUYEN_THELOAI
                    var truyen_theloai_list = (from t in db.TRUYEN_THELOAI where t.MaSP == sp.MaSP select t).ToList();
                    List<string> tl_cu = new List<string>();
                    List<string> tl_moi = new List<string>();
                    
                    truyen_theloai_list.ForEach(s => tl_cu.Add(s.THELOAI.TenTheLoai));

                    foreach(var item in theloai_clb.CheckedItems)
                    {
                        tl_moi.Add(item.ToString());
                        var x = item.ToString();
                        Console.WriteLine();
                    }

                    List<string> xx = new List<string>(tl_cu);
                    List<string> ss = new List<string>(tl_moi);
                    foreach(var i in xx)
                    {
                        foreach(var j in ss)
                        {
                            if (i == j)
                            {
                                tl_cu.Remove(i);
                                tl_moi.Remove(j);
                            }
                        }
                    }

                    foreach(var item in tl_cu)
                    {
                        var tl = db.THELOAIs.Where(s => s.TenTheLoai.Equals(item.ToString())).Single();
                        cmd3 = new SqlCommand("xoaTRUYEN_THELOAI", connection);
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Parameters.Add(new SqlParameter { ParameterName = "@MaSP", SqlDbType = SqlDbType.VarChar, Value = masp_tb.Text });
                        cmd3.Parameters.Add(new SqlParameter { ParameterName = "@MaTHELOAI", SqlDbType = SqlDbType.Int, Value = tl.MaTheLoai });
                        cmd3.ExecuteNonQuery();
                    }

                    
                    foreach (var item in tl_moi)
                    {
                        var tl = db.THELOAIs.Where(s => s.TenTheLoai.Equals(item.ToString())).Single();
                        cmd3 = new SqlCommand("themTRUYEN_THELOAI", connection);
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Parameters.Add(new SqlParameter { ParameterName = "@MaSP", SqlDbType = SqlDbType.VarChar, Value = masp_tb.Text });
                        cmd3.Parameters.Add(new SqlParameter { ParameterName = "@MaTHELOAI", SqlDbType = SqlDbType.Int, Value =  tl.MaTheLoai});
                        cmd3.ExecuteNonQuery();
                    }

                }
                else if(sp.LoaiSP=="Khác")
                {
                    cmd1 = new SqlCommand("themTRUYEN", connection);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        cmd1.Parameters.Add(new SqlParameter { ParameterName = "@MaSP", SqlDbType = SqlDbType.VarChar, Value = masp_tb.Text });
                        cmd1.Parameters.Add(new SqlParameter { ParameterName = "@NXB", SqlDbType = SqlDbType.NVarChar, Value = nxb_tb.Text });
                        cmd1.Parameters.Add(new SqlParameter { ParameterName = "@Nam", SqlDbType = SqlDbType.VarChar, Value = namxb_tb.Text });
                        cmd1.Parameters.Add(new SqlParameter { ParameterName = "@TacGia", SqlDbType = SqlDbType.NVarChar, Value = tacgia_tb.Text });
                        cmd1.Parameters.Add(new SqlParameter { ParameterName = "@QuocGia", SqlDbType = SqlDbType.NVarChar, Value = quocgia_tb.Text });
                    }
                    catch
                    {
                        result = MessageBox.Show("Nhập sai dữ liệu", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    cmd2 = new SqlCommand("xoaSPKHAC", connection);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add(new SqlParameter { ParameterName = "@MaSP", SqlDbType = SqlDbType.VarChar, Value = masp_tb.Text });

                    //thêm vào bảng truyen_theloai
                    if (theloai_clb.CheckedItems != null)
                    {
                        foreach (var item in theloai_clb.CheckedItems)
                        {
                            cmd3 = new SqlCommand("themTRUYEN_THELOAI", connection);
                            cmd3.CommandType = CommandType.StoredProcedure;
                            var tl = db.THELOAIs.Where(s => s.TenTheLoai.Equals(item.ToString())).Single();
                            cmd3.Parameters.Add(new SqlParameter { ParameterName = "@MaSP", SqlDbType = SqlDbType.VarChar, Value = masp_tb.Text });
                            cmd3.Parameters.Add(new SqlParameter { ParameterName = "@MaTHELOAI", SqlDbType = SqlDbType.Int, Value = tl.MaTheLoai });
                            cmd3.ExecuteNonQuery();
                        }
                    }
                   
                }

                try
                {
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    if (cmd2 != null)
                        cmd2.ExecuteNonQuery();
                    result = MessageBox.Show("Sửa thành công", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    result = MessageBox.Show("Sửa không thành công", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            //xong
            else if(loaisp_cb.Text=="Khác")
            {
                if (sp.LoaiSP=="Khác")
                {
                    cmd1 = new SqlCommand("suaSPKHAC", connection);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        cmd1.Parameters.Add(new SqlParameter { ParameterName = "@MaSP", SqlDbType = SqlDbType.VarChar, Value = masp_tb.Text });
                        cmd1.Parameters.Add(new SqlParameter { ParameterName = "@XuatXu", SqlDbType = SqlDbType.NVarChar, Value = nxb_tb.Text });
                        cmd1.Parameters.Add(new SqlParameter { ParameterName = "@NgaySX", SqlDbType = SqlDbType.Date, Value = ngaysx_dtp.Text });
                        cmd1.Parameters.Add(new SqlParameter { ParameterName = "@HanSD", SqlDbType = SqlDbType.Date, Value = hansd_dtp.Text });
                    }
                    catch
                    {
                        result = MessageBox.Show("Nhập sai dữ liệu", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                else if(sp.LoaiSP=="Truyện")
                {
                    cmd1 = new SqlCommand("themSPKHAC", connection);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        cmd1.Parameters.Add(new SqlParameter { ParameterName = "@MaSP", SqlDbType = SqlDbType.VarChar, Value = masp_tb.Text });
                        cmd1.Parameters.Add(new SqlParameter { ParameterName = "@XuatXu", SqlDbType = SqlDbType.NVarChar, Value = nxb_tb.Text });
                        cmd1.Parameters.Add(new SqlParameter { ParameterName = "@NgaySX", SqlDbType = SqlDbType.Date, Value = ngaysx_dtp.Text });
                        cmd1.Parameters.Add(new SqlParameter { ParameterName = "@HanSD", SqlDbType = SqlDbType.Date, Value = hansd_dtp.Text });
                    }
                    catch
                    {
                        result = MessageBox.Show("Nhập sai dữ liệu", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    cmd2 = new SqlCommand("xoaTRUYEN", connection);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add(new SqlParameter { ParameterName = "@MaSP", SqlDbType = SqlDbType.VarChar, Value = masp_tb.Text }); 
                }
                
                try
                {
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    if (cmd2 != null)
                        cmd2.ExecuteNonQuery();

                    result = MessageBox.Show("Sửa thành công", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    result = MessageBox.Show("Sửa không thành công", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void loaisp_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            if(loaisp_cb.Text=="Truyện")
            {
                thongtin_truyen_pannel.Visible = true;
                thongtin_khac_pannel.Visible = false;
            }
            else if (loaisp_cb.Text == "Khác")
            {
                thongtin_khac_pannel.Visible = true;
                thongtin_truyen_pannel.Visible = false;
            }
        }


        private void thoat_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ThemSP_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void giagoc_tb_Leave(object sender, EventArgs e)
        {
            var magg = db.PHIEUGIAMGIAs.Find(magg_cb.Text);
            if (magg != null)
            {
                SqlCommand cmd = new SqlCommand("capnhat_PHIEUGIAMGIA", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@MaGG", SqlDbType = SqlDbType.VarChar, Value = magg.MaGG });
                cmd.ExecuteNonQuery();
                db = new Shop();
                magg = db.PHIEUGIAMGIAs.Find(magg_cb.Text);
                if(magg.SuDung==true)
                {
                    if (magg.SoTien != null)
                        giaban_tb.Text = (Convert.ToDecimal(giagoc_tb.Text) * (1 + magg.PhanTram / 100)).ToString();
                    else if (magg.PhanTram != null)
                        giaban_tb.Text = (Convert.ToDecimal(giagoc_tb.Text) - magg.SoTien).ToString();
                }

            }
        }

        private void chitiet_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
