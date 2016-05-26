namespace QLNS_win
{
    partial class Main
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
            this.btDuAn = new System.Windows.Forms.Button();
            this.btLuong = new System.Windows.Forms.Button();
            this.btNhanVien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDuAn
            // 
            this.btDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDuAn.Image = global::QLNS_win.Properties.Resources.pr;
            this.btDuAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDuAn.Location = new System.Drawing.Point(457, 329);
            this.btDuAn.Name = "btDuAn";
            this.btDuAn.Size = new System.Drawing.Size(184, 66);
            this.btDuAn.TabIndex = 2;
            this.btDuAn.Text = "Dự án";
            this.btDuAn.UseVisualStyleBackColor = true;
            this.btDuAn.Click += new System.EventHandler(this.btDuAn_Click);
            // 
            // btLuong
            // 
            this.btLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuong.Image = global::QLNS_win.Properties.Resources.money;
            this.btLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuong.Location = new System.Drawing.Point(256, 329);
            this.btLuong.Name = "btLuong";
            this.btLuong.Size = new System.Drawing.Size(167, 64);
            this.btLuong.TabIndex = 1;
            this.btLuong.Text = "Lương";
            this.btLuong.UseVisualStyleBackColor = true;
            this.btLuong.Click += new System.EventHandler(this.btLuong_Click);
            // 
            // btNhanVien
            // 
            this.btNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhanVien.Image = global::QLNS_win.Properties.Resources.nv1;
            this.btNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNhanVien.Location = new System.Drawing.Point(12, 329);
            this.btNhanVien.Name = "btNhanVien";
            this.btNhanVien.Size = new System.Drawing.Size(202, 64);
            this.btNhanVien.TabIndex = 0;
            this.btNhanVien.Text = "Nhân viên";
            this.btNhanVien.UseVisualStyleBackColor = true;
            this.btNhanVien.Click += new System.EventHandler(this.btNhanVien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản Lý Nhân Sự";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::QLNS_win.Properties.Resources.cm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(657, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDuAn);
            this.Controls.Add(this.btLuong);
            this.Controls.Add(this.btNhanVien);
            this.DoubleBuffered = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNhanVien;
        private System.Windows.Forms.Button btLuong;
        private System.Windows.Forms.Button btDuAn;
        private System.Windows.Forms.Label label1;

    }
}