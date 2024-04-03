using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BT01_SinhVien
{
    public partial class Form1 : Form
    {
        List<SinhVien> SinhViens = new List<SinhVien>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DocFile();
            KhoiTaoListBox();
        }

        private void KhoiTaoListBox()
        {
            lstSinhVien.DataSource = null;
            lstSinhVien.DisplayMember = "HoTen";
            lstSinhVien.ValueMember = "MaSV";
            lstSinhVien.DataSource = SinhViens;
        }

        private void DocFile()
        {
            string duong_dan = @"..\..\DuLieu\SinhVien.txt";
            string[] mang_dong = File.ReadAllLines(duong_dan);
            foreach (string chuoi_sv in mang_dong)
            {
                string[] mang_thanh_phan = chuoi_sv.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                SinhVien sv = new SinhVien();
                sv.MaSV = int.Parse(mang_thanh_phan[0]);
                sv.HoTen = mang_thanh_phan[1];
                sv.HocBong = int.Parse(mang_thanh_phan[2]);
                SinhViens.Add(sv);
            }
        }

        private void lstSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedIndex == -1)
                return;
            SinhVien sv = lstSinhVien.SelectedItem as SinhVien;
            GanDuLieu(sv);
        }

        private void GanDuLieu(SinhVien sv)
        {
            txtMaSinhVien.Text = sv.MaSV.ToString();
            txtHoTen.Text = sv.HoTen;
            txtHocBong.Text = sv.HocBong.ToString("#,##0$");
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
                if (ctl is TextBox)
                    (ctl as TextBox).Clear();
            txtMaSinhVien.Focus();
            txtMaSinhVien.ReadOnly = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedIndex == -1)
                return;
            DialogResult tl = MessageBox.Show("Bạn có muốn xoá sinh viên: " + txtHoTen.Text, "Xoá sinh viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                SinhVien svXoa = TimSinhVien(int.Parse(txtMaSinhVien.Text));
                SinhViens.Remove(svXoa);
                KhoiTaoListBox();
            }
        }

        private SinhVien TimSinhVien(int msv)
        {
            SinhVien kq = null;
            foreach(SinhVien sv in SinhViens)
                if (sv.MaSV == msv)
                    return sv;
                return kq; 
        }
    }
}
