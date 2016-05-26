namespace QLNS_win
{
    partial class DuAn
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
            this.dgvDuAn = new System.Windows.Forms.DataGridView();
            this.tbCongViec = new System.Windows.Forms.TextBox();
            this.tbNgayThamGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.tbSeach = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.cbDuan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDuAn
            // 
            this.dgvDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuAn.Location = new System.Drawing.Point(12, 93);
            this.dgvDuAn.Name = "dgvDuAn";
            this.dgvDuAn.RowTemplate.Height = 24;
            this.dgvDuAn.Size = new System.Drawing.Size(1061, 294);
            this.dgvDuAn.TabIndex = 0;
            this.dgvDuAn.SelectionChanged += new System.EventHandler(this.dgvDuAn_SelectionChanged);
            // 
            // tbCongViec
            // 
            this.tbCongViec.Location = new System.Drawing.Point(500, 412);
            this.tbCongViec.Name = "tbCongViec";
            this.tbCongViec.Size = new System.Drawing.Size(159, 22);
            this.tbCongViec.TabIndex = 3;
            // 
            // tbNgayThamGia
            // 
            this.tbNgayThamGia.Location = new System.Drawing.Point(500, 478);
            this.tbNgayThamGia.Name = "tbNgayThamGia";
            this.tbNgayThamGia.Size = new System.Drawing.Size(159, 22);
            this.tbNgayThamGia.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dự án";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Công việc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày tham gia";
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btThem.Location = new System.Drawing.Point(92, 543);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(125, 39);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm mới";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCapNhat.Location = new System.Drawing.Point(233, 544);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(118, 39);
            this.btCapNhat.TabIndex = 10;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.UseVisualStyleBackColor = false;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.Red;
            this.btHuy.Location = new System.Drawing.Point(485, 542);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(75, 39);
            this.btHuy.TabIndex = 11;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // tbSeach
            // 
            this.tbSeach.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSeach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbSeach.ForeColor = System.Drawing.SystemColors.Window;
            this.tbSeach.Location = new System.Drawing.Point(856, 31);
            this.tbSeach.Multiline = true;
            this.tbSeach.Name = "tbSeach";
            this.tbSeach.Size = new System.Drawing.Size(203, 34);
            this.tbSeach.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(701, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(129, 417);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(172, 24);
            this.cbNhanVien.TabIndex = 14;
            // 
            // cbDuan
            // 
            this.cbDuan.FormattingEnabled = true;
            this.cbDuan.Location = new System.Drawing.Point(129, 483);
            this.cbDuan.Name = "cbDuan";
            this.cbDuan.Size = new System.Drawing.Size(172, 24);
            this.cbDuan.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(325, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 39);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quản Lý Dự Án";
            // 
            // btXoa
            // 
            this.btXoa.ForeColor = System.Drawing.Color.Red;
            this.btXoa.Location = new System.Drawing.Point(371, 544);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(89, 38);
            this.btXoa.TabIndex = 17;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // DuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1085, 611);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDuan);
            this.Controls.Add(this.cbNhanVien);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSeach);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNgayThamGia);
            this.Controls.Add(this.tbCongViec);
            this.Controls.Add(this.dgvDuAn);
            this.Name = "DuAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDuAn;
        private System.Windows.Forms.TextBox tbCongViec;
        private System.Windows.Forms.TextBox tbNgayThamGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.TextBox tbSeach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.ComboBox cbDuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btXoa;
    }
}

