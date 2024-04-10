
namespace BT02_GhiNFile
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.lstSinhVien = new System.Windows.Forms.ListBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtHocBong = new System.Windows.Forms.TextBox();
            this.lblHocBong = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.lblMaSinhVien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(292, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 26);
            this.button1.TabIndex = 32;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstSinhVien
            // 
            this.lstSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSinhVien.ForeColor = System.Drawing.Color.Blue;
            this.lstSinhVien.FormattingEnabled = true;
            this.lstSinhVien.ItemHeight = 20;
            this.lstSinhVien.Location = new System.Drawing.Point(0, 180);
            this.lstSinhVien.Name = "lstSinhVien";
            this.lstSinhVien.Size = new System.Drawing.Size(423, 224);
            this.lstSinhVien.TabIndex = 31;
            this.lstSinhVien.SelectedIndexChanged += new System.EventHandler(this.lstSinhVien_SelectedIndexChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Location = new System.Drawing.Point(122, 135);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 26);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTiep
            // 
            this.btnTiep.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiep.ForeColor = System.Drawing.Color.Blue;
            this.btnTiep.Location = new System.Drawing.Point(207, 135);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(75, 26);
            this.btnTiep.TabIndex = 29;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Location = new System.Drawing.Point(37, 135);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 26);
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtHocBong
            // 
            this.txtHocBong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocBong.ForeColor = System.Drawing.Color.Black;
            this.txtHocBong.Location = new System.Drawing.Point(150, 91);
            this.txtHocBong.Name = "txtHocBong";
            this.txtHocBong.Size = new System.Drawing.Size(204, 26);
            this.txtHocBong.TabIndex = 27;
            // 
            // lblHocBong
            // 
            this.lblHocBong.AutoSize = true;
            this.lblHocBong.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocBong.ForeColor = System.Drawing.Color.Blue;
            this.lblHocBong.Location = new System.Drawing.Point(26, 95);
            this.lblHocBong.Name = "lblHocBong";
            this.lblHocBong.Size = new System.Drawing.Size(75, 19);
            this.lblHocBong.TabIndex = 26;
            this.lblHocBong.Text = "Học bổng";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(150, 48);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(204, 26);
            this.txtHoTen.TabIndex = 25;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.Color.Blue;
            this.lblHoTen.Location = new System.Drawing.Point(26, 52);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(119, 19);
            this.lblHoTen.TabIndex = 24;
            this.lblHoTen.Text = "Họ tên sinh viên";
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSinhVien.ForeColor = System.Drawing.Color.Black;
            this.txtMaSinhVien.Location = new System.Drawing.Point(150, 4);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.ReadOnly = true;
            this.txtMaSinhVien.Size = new System.Drawing.Size(204, 26);
            this.txtMaSinhVien.TabIndex = 23;
            // 
            // lblMaSinhVien
            // 
            this.lblMaSinhVien.AutoSize = true;
            this.lblMaSinhVien.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSinhVien.ForeColor = System.Drawing.Color.Blue;
            this.lblMaSinhVien.Location = new System.Drawing.Point(26, 8);
            this.lblMaSinhVien.Name = "lblMaSinhVien";
            this.lblMaSinhVien.Size = new System.Drawing.Size(95, 19);
            this.lblMaSinhVien.TabIndex = 22;
            this.lblMaSinhVien.Text = "Mã sinh viên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstSinhVien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTiep);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtHocBong);
            this.Controls.Add(this.lblHocBong);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.lblMaSinhVien);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstSinhVien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtHocBong;
        private System.Windows.Forms.Label lblHocBong;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label lblMaSinhVien;
    }
}

