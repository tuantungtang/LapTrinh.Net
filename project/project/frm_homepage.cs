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
    public partial class frm_homepage : Form
    {
        public frm_homepage()
        {
            InitializeComponent();
        }

        private void quanLiSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_cafe"] == null)
            {
                frm_cafe sach = new frm_cafe();
                sach.MdiParent = this;
                sach.Show();
            }
            else
            {
                Application.OpenForms["frm_cafe"].Activate();
            }
        }
    }
}
