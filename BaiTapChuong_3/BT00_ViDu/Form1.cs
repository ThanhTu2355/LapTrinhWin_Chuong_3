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

namespace BT00_ViDu
{
    public partial class Form1 : Form
    {
        List<Khoa> Khoas = new List<Khoa>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DocKhoa();
            KhoiTaoListBox();
        }

        private void KhoiTaoListBox()
        {
            lstKhoa.DataSource = null;
            lstKhoa.DisplayMember = "TenKH";
            lstKhoa.ValueMember = "MaKH";
            lstKhoa.DataSource = Khoas;
        }

        private void DocKhoa()
        {
            string duong_dan = @"..\..\DATA\Khoa.txt";
            string[] mang_dong = File.ReadAllLines(duong_dan);
            foreach(string chuoi_khoa in mang_dong)
            {
                string[] mang_thanh_phan = chuoi_khoa.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                Khoa kh = new Khoa();
                kh.MaKH = mang_thanh_phan[0];
                kh.TenKH = mang_thanh_phan[1];
                Khoas.Add(kh);
            }    
        }

        private void btnDirectoryExists_Click(object sender, EventArgs e)
        {
            string duong_dan = @"D:\DATA\LapTrinhWin_Chuong_3";
            if (Directory.Exists(duong_dan))
                MessageBox.Show("Đường dẫn ĐÚNG");
            else
                MessageBox.Show("Đường dẫn SAI");
        }

        private void btnDirectoryGetFiles_Click(object sender, EventArgs e)
        {
            string duong_dan = @"..\..\..\..\TestGetFiles";
            string[] danh_sach_duong_dan = Directory.GetFiles(duong_dan, "*.jpg");
            foreach (string duong_dan_file in danh_sach_duong_dan)
                MessageBox.Show(duong_dan_file);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string chuoi = "Tôi đi học lập Trình";
            string[] chiou_thanh_phan=chuoi.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            Khoas.Add(new Khoa { MaKH = "LG", TenKH = "Chuỗi cung ứng" });
            string duong_dan= @"..\..\DATA\Khoa.txt";
            List<string> danh_sach_chuoi_khoa = new List<string>();
            foreach(Khoa kh in Khoas)
            {
                string chuoi_khoa = kh.MaKH + ":" + kh.TenKH;
                danh_sach_chuoi_khoa.Add(chuoi_khoa);
            }
            File.WriteAllLines(duong_dan, danh_sach_chuoi_khoa);
        }
    }
}
