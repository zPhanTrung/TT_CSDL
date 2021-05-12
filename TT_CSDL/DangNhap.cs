using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TT_CSDL.Entities;

namespace TT_CSDL
{
    public partial class DangNhap : Form
    {
        private Shop db;
        MainForm mainform;
        private static DangNhap s_instance = null;
        public DangNhap()
        {
            InitializeComponent();
            db = new Shop();
        }

        static public DangNhap Instance
        {
            get
            {
                if (s_instance == null)
                    s_instance = new DangNhap();
                return s_instance;
            }
            set
            {
                s_instance = null;
            }
        }

        private void dangnhap_btn_Click(object sender, EventArgs e)
        {
            //var res = (from tk in db.TAIKHOANs where tk.TenDN.Equals(taikhoan_tb.Text) && tk.MatKhau.Equals(matkhau_tb.Text) select tk).Single();
            //if (res != null)
            //{
            //    mainform = new MainForm();
            //    mainform.Show();
            //    Instance.Hide();
            //    matkhau_tb.Text = null;
            //}
            mainform = new MainForm();
            mainform.Show();
            Instance.Hide();
            matkhau_tb.Text = null;
        }

        private void matkhau_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dangnhap_btn.PerformClick();
            }
        }

        private void taikhoan_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dangnhap_btn.PerformClick();
            }
        }

       
    }
}
