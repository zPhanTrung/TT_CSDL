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

namespace TT_CSDL
{
    public partial class MainForm : Form
    {
        SanPham_Uc sanpham;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DangNhap.Instance.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           if(!panel1.Controls.Contains(sanpham))
           {
                sanpham = new SanPham_Uc();
                panel1.Controls.Add(sanpham);
                sanpham.Dock = DockStyle.Fill;
                sanpham.BringToFront();
           }
           else
                sanpham.BringToFront();
        }
    }
}
