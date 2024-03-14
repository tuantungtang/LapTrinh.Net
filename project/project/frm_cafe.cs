using System;
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
    public partial class frm_cafe : Form
    {
        LOPDUNGCHUNG lopDungChung = new LOPDUNGCHUNG();
        public frm_cafe()
        {
            InitializeComponent();
        }

        private void cb_LoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dt_Sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void load()
        {
            string sql = "Select * from CAFE";
            //DataTable dt = lopchung.LoadDL(sql);
            dt_cafe.DataSource = lopDungChung.LoadDL(sql);
        }
        private void frm_cafe_Load(object sender, EventArgs e)
        {
            load();
            string sql = "Select * from PHANLOAI";
            cb_phanLoai.DataSource = lopDungChung.LoadDL(sql);
            cb_phanLoai.DisplayMember = "TENLOAI";
            cb_phanLoai.ValueMember = "MALOAI";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "insert into CAFE values ('" + txb_masp.Text + "',N'" + txb_tensp.Text + "',N'" + txb_Mota.Text + "',N'" + txb_trangthai.Text + "','" + cb_phanLoai.SelectedValue + "')";
            int kq = lopDungChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Them san pham thanh cong");
            else MessageBox.Show("Them san pham that bai");
            load();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete CAFE where MASP = '" + txb_masp.Text + "'";
            int kq = lopDungChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Xoa san pham thanh cong");
            else MessageBox.Show("Xoa san pham that bai ");
            load();
        }

        private void dt_cafe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_masp.Text = dt_cafe.CurrentRow.Cells["MASP"].Value.ToString();
            txb_tensp.Text = dt_cafe.CurrentRow.Cells["TENSP"].Value.ToString();
            txb_Mota.Text = dt_cafe.CurrentRow.Cells["MOTA"].Value.ToString();
            txb_trangthai.Text = dt_cafe.CurrentRow.Cells["TRANGTHAI"].Value.ToString();
            cb_phanLoai.SelectedValue = dt_cafe.CurrentRow.Cells["PHANLOAI"].Value.ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "update cafe set TENSP= N'" + txb_tensp.Text + "',MOTA= N'" + txb_Mota.Text + "',TRANGTHAI= N'" + txb_trangthai.Text + "',PHANLOAI ='" + cb_phanLoai.SelectedValue + "' where MASP='" + txb_masp.Text + "'";
            int kq = lopDungChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Sua san pham thanh cong");
            else MessageBox.Show("Sua san pham that bai");
            load();
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT (*) from CAFE";
            int soSP = (int)lopDungChung.LayGT(sql);
            txb_soLuong.Text = soSP.ToString();
        }
    }
}
