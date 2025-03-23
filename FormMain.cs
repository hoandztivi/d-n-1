using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlythucungv2._0.formcon;

namespace quanlythucungv2._0
{
    public partial class FormMain: Form
    {
        private string quyenTruyCap;
        public FormMain(string quyenTruyCap)
        {
            InitializeComponent();
            this.quyenTruyCap = quyenTruyCap;
        }

        //hàm add form lên gruopbox grbHTTT
        public void AddForm(Form form)
        {
            //xóa các control có trên gruopbox
            this.grbHTTT.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            //bỏ viền form
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            //this.Text = form.Text;
            this.grbHTTT.Controls.Add(form);
            form.Show();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            if (quyenTruyCap == "quanly")
            {
                menuStrip1.Enabled = true;
            }
            else if (quyenTruyCap == "nhanvien")
            {
                menuNV.Enabled = false;
                quảnLýThúCưngToolStripMenuItem.Enabled = false;
            }
            var form = new FormChaoMung();
            AddForm(form);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap formDangNhap = new dangnhap();
            formDangNhap.Show();
            this.Dispose();
        }

        private void quảnLýThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormQuanLyThuCung();
            AddForm(form);
        }

        private void danhSáchThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormDSThuCung();
            AddForm(form);
        }

        private void menuNV_Click(object sender, EventArgs e)
        {
            var form = new FormQuanLyNhanVien();
            AddForm(form);
        }
    }
}
