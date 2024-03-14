﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class frm_dangnhap : Form
    {
        LOPDUNGCHUNG lopDungChung = new LOPDUNGCHUNG();
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT (*) from TAIKHOAN where TENDN = '" + txt_TaiKhoan.Text + "' and MATKHAU = '" + txt_MatKhau.Text + "'";
            int kq = (int)lopDungChung.LayGT(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                frm_homepage sv = new frm_homepage();
                sv.Show();
            }
            else MessageBox.Show("Sai tên hoặc mật khẩu, đăng nhập thất bại");
        }

        private void ck_HienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_HienThiMatKhau.Checked == true)
                txt_MatKhau.UseSystemPasswordChar = false;
            else txt_MatKhau.UseSystemPasswordChar = true;
        }
    }
}
