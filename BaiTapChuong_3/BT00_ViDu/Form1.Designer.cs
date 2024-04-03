
namespace BT00_ViDu
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
            this.lstKhoa = new System.Windows.Forms.ListBox();
            this.btnDirectoryExists = new System.Windows.Forms.Button();
            this.btnDirectoryGetFiles = new System.Windows.Forms.Button();
            this.btnDirectoryInfoExists = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnGhiFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstKhoa
            // 
            this.lstKhoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstKhoa.FormattingEnabled = true;
            this.lstKhoa.ItemHeight = 19;
            this.lstKhoa.Location = new System.Drawing.Point(0, 0);
            this.lstKhoa.Name = "lstKhoa";
            this.lstKhoa.Size = new System.Drawing.Size(390, 309);
            this.lstKhoa.TabIndex = 0;
            // 
            // btnDirectoryExists
            // 
            this.btnDirectoryExists.Location = new System.Drawing.Point(407, 17);
            this.btnDirectoryExists.Name = "btnDirectoryExists";
            this.btnDirectoryExists.Size = new System.Drawing.Size(220, 43);
            this.btnDirectoryExists.TabIndex = 1;
            this.btnDirectoryExists.Text = "Directory Exists";
            this.btnDirectoryExists.UseVisualStyleBackColor = true;
            this.btnDirectoryExists.Click += new System.EventHandler(this.btnDirectoryExists_Click);
            // 
            // btnDirectoryGetFiles
            // 
            this.btnDirectoryGetFiles.Location = new System.Drawing.Point(407, 74);
            this.btnDirectoryGetFiles.Name = "btnDirectoryGetFiles";
            this.btnDirectoryGetFiles.Size = new System.Drawing.Size(220, 43);
            this.btnDirectoryGetFiles.TabIndex = 1;
            this.btnDirectoryGetFiles.Text = "DirectoryGetFiles";
            this.btnDirectoryGetFiles.UseVisualStyleBackColor = true;
            this.btnDirectoryGetFiles.Click += new System.EventHandler(this.btnDirectoryGetFiles_Click);
            // 
            // btnDirectoryInfoExists
            // 
            this.btnDirectoryInfoExists.Location = new System.Drawing.Point(407, 131);
            this.btnDirectoryInfoExists.Name = "btnDirectoryInfoExists";
            this.btnDirectoryInfoExists.Size = new System.Drawing.Size(220, 43);
            this.btnDirectoryInfoExists.TabIndex = 1;
            this.btnDirectoryInfoExists.Text = "DirectoryInfo Exists";
            this.btnDirectoryInfoExists.UseVisualStyleBackColor = true;
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(407, 188);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(220, 43);
            this.btnSplit.TabIndex = 1;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnGhiFile
            // 
            this.btnGhiFile.Location = new System.Drawing.Point(407, 245);
            this.btnGhiFile.Name = "btnGhiFile";
            this.btnGhiFile.Size = new System.Drawing.Size(220, 43);
            this.btnGhiFile.TabIndex = 1;
            this.btnGhiFile.Text = "Ghi File";
            this.btnGhiFile.UseVisualStyleBackColor = true;
            this.btnGhiFile.Click += new System.EventHandler(this.btnGhiFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 309);
            this.Controls.Add(this.btnGhiFile);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnDirectoryInfoExists);
            this.Controls.Add(this.btnDirectoryGetFiles);
            this.Controls.Add(this.btnDirectoryExists);
            this.Controls.Add(this.lstKhoa);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Directory & Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstKhoa;
        private System.Windows.Forms.Button btnDirectoryExists;
        private System.Windows.Forms.Button btnDirectoryGetFiles;
        private System.Windows.Forms.Button btnDirectoryInfoExists;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnGhiFile;
    }
}

