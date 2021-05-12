
namespace TT_CSDL
{
    partial class DangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taikhoan_tb = new System.Windows.Forms.TextBox();
            this.matkhau_tb = new System.Windows.Forms.TextBox();
            this.dangnhap_btn = new System.Windows.Forms.Button();
            this.thoat_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(192, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // taikhoan_tb
            // 
            this.taikhoan_tb.Location = new System.Drawing.Point(296, 128);
            this.taikhoan_tb.Name = "taikhoan_tb";
            this.taikhoan_tb.Size = new System.Drawing.Size(175, 22);
            this.taikhoan_tb.TabIndex = 2;
            this.taikhoan_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.taikhoan_tb_KeyDown);
            // 
            // matkhau_tb
            // 
            this.matkhau_tb.Location = new System.Drawing.Point(296, 176);
            this.matkhau_tb.Name = "matkhau_tb";
            this.matkhau_tb.Size = new System.Drawing.Size(175, 22);
            this.matkhau_tb.TabIndex = 3;
            this.matkhau_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.matkhau_tb_KeyDown);
            // 
            // dangnhap_btn
            // 
            this.dangnhap_btn.Location = new System.Drawing.Point(244, 246);
            this.dangnhap_btn.Name = "dangnhap_btn";
            this.dangnhap_btn.Size = new System.Drawing.Size(93, 34);
            this.dangnhap_btn.TabIndex = 4;
            this.dangnhap_btn.Text = "Đăng nhập";
            this.dangnhap_btn.UseVisualStyleBackColor = true;
            this.dangnhap_btn.Click += new System.EventHandler(this.dangnhap_btn_Click);
            // 
            // thoat_btn
            // 
            this.thoat_btn.Location = new System.Drawing.Point(369, 246);
            this.thoat_btn.Name = "thoat_btn";
            this.thoat_btn.Size = new System.Drawing.Size(93, 34);
            this.thoat_btn.TabIndex = 5;
            this.thoat_btn.Text = "Thoát";
            this.thoat_btn.UseVisualStyleBackColor = true;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 482);
            this.Controls.Add(this.thoat_btn);
            this.Controls.Add(this.dangnhap_btn);
            this.Controls.Add(this.matkhau_tb);
            this.Controls.Add(this.taikhoan_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangNhap";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox taikhoan_tb;
        private System.Windows.Forms.TextBox matkhau_tb;
        private System.Windows.Forms.Button dangnhap_btn;
        private System.Windows.Forms.Button thoat_btn;
    }
}

