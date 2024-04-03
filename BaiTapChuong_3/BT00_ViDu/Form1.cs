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
    }
}
