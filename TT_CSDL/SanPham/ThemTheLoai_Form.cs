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
    public partial class ThemTheLoai_Form : Form
    {
        Shop db;
        SqlConnection connection;
        public ThemTheLoai_Form()
        {
            InitializeComponent();
            db = new Shop();
            connection = (SqlConnection)db.Database.Connection;
            connection.Open();
        }

        private void them_Click(object sender, EventArgs e)
        {
            DialogResult result;

            SqlCommand cmd = new SqlCommand("themTHELOAI", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@MaTheLoai", SqlDbType = SqlDbType.Int, Value = Convert.ToInt32(matl_tb.Text) });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@TenTheLoai", SqlDbType = SqlDbType.NVarChar, Value = ten_tb.Text });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@GhiChu", SqlDbType = SqlDbType.NVarChar, Value = ghichu_tb.Text });
            }
            catch
            {
                result = MessageBox.Show("Nhập sai dữ liệu", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                cmd.ExecuteNonQuery();
                result = MessageBox.Show("Thêm thành công", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(db.THELOAIs.ToList());
            }
            catch
            {
                result = MessageBox.Show("Thêm không thành công! MaTheLoai đã tồn tại", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ThemTheLoai_Form_Load(object sender, EventArgs e)
        {
            var res = db.THELOAIs.ToList();
            LoadData(res);
        }

        private void LoadData(List<THELOAI> collection)
        {
            int index_row = -1;
            dataGridView1.Rows.Clear();
            foreach (THELOAI item in collection)
            {
                dataGridView1.Rows.Add();
                index_row++;
                dataGridView1.Rows[index_row].Cells["MaTL"].Value = item.MaTheLoai.ToString();
                dataGridView1.Rows[index_row].Cells["Ten"].Value = item.TenTheLoai;
                dataGridView1.Rows[index_row].Cells["GhiChu"].Value = item.GhiChu;
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            DialogResult result;
            SqlCommand cmd = new SqlCommand("suaTHELOAI", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            
            try
            {
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@MaTheLoai", SqlDbType = SqlDbType.Int, Value = Convert.ToInt32(matl_tb.Text) });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@TenTheLoai", SqlDbType = SqlDbType.NVarChar, Value = ten_tb.Text });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@GhiChu", SqlDbType = SqlDbType.NVarChar, Value = ghichu_tb.Text });
            }
            catch
            {
                result = MessageBox.Show("Nhập sai dữ liệu", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                cmd.ExecuteNonQuery();
                result = MessageBox.Show("Sửa thành công", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db = new Shop();
                LoadData(db.THELOAIs.ToList());
            }
            catch
            {
                result = MessageBox.Show("Sửa không thành công", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void xoa_Click(object sender, EventArgs e)
        {
            DialogResult result;
            SqlCommand cmd = new SqlCommand("xoaTHELOAI", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@MaTheLoai", SqlDbType = SqlDbType.Int, Value = Convert.ToInt32(matl_tb.Text) });
            }
            catch
            {
                result = MessageBox.Show("Nhập sai dữ liệu", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                cmd.ExecuteNonQuery();
                result = MessageBox.Show("Xóa thành công", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(db.THELOAIs.ToList());
            }
            catch
            {
                result = MessageBox.Show("Xóa không thành công", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            var row_index = dataGridView1.CurrentRow.Index;
            matl_tb.Text = dataGridView1.CurrentRow.Cells["MaTL"].Value.ToString();
            ten_tb.Text = dataGridView1.CurrentRow.Cells["Ten"].Value.ToString();
            ghichu_tb.Text = dataGridView1.CurrentRow.Cells["GhiChu"].Value.ToString();
        }
    }
}
