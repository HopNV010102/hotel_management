
namespace WindowsFormsApp2
{
    partial class fQLKS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQLKS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_thongke = new System.Windows.Forms.Button();
            this.bt_dichvu = new System.Windows.Forms.Button();
            this.bt_khachhang = new System.Windows.Forms.Button();
            this.bt_phong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_thongtin = new System.Windows.Forms.Button();
            this.bt_trogiup = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(25, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 204);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "XQJQ+6MC , P. Văn Quán , Hà Đông , Hà Nội ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOTEL HAU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bt_thongke);
            this.panel2.Controls.Add(this.bt_dichvu);
            this.panel2.Controls.Add(this.bt_khachhang);
            this.panel2.Controls.Add(this.bt_phong);
            this.panel2.Location = new System.Drawing.Point(25, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 125);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_thongke
            // 
            this.bt_thongke.BackColor = System.Drawing.Color.White;
            this.bt_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thongke.Location = new System.Drawing.Point(580, 21);
            this.bt_thongke.Name = "bt_thongke";
            this.bt_thongke.Size = new System.Drawing.Size(152, 75);
            this.bt_thongke.TabIndex = 0;
            this.bt_thongke.Text = "Thống kê";
            this.bt_thongke.UseVisualStyleBackColor = false;
            this.bt_thongke.Click += new System.EventHandler(this.bt_thongke_Click);
            // 
            // bt_dichvu
            // 
            this.bt_dichvu.BackColor = System.Drawing.Color.White;
            this.bt_dichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dichvu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_dichvu.Location = new System.Drawing.Point(394, 21);
            this.bt_dichvu.Name = "bt_dichvu";
            this.bt_dichvu.Size = new System.Drawing.Size(152, 75);
            this.bt_dichvu.TabIndex = 0;
            this.bt_dichvu.Text = "Dịch vụ";
            this.bt_dichvu.UseVisualStyleBackColor = false;
            this.bt_dichvu.Click += new System.EventHandler(this.bt_dichvu_Click);
            // 
            // bt_khachhang
            // 
            this.bt_khachhang.BackColor = System.Drawing.Color.White;
            this.bt_khachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_khachhang.Location = new System.Drawing.Point(204, 21);
            this.bt_khachhang.Name = "bt_khachhang";
            this.bt_khachhang.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bt_khachhang.Size = new System.Drawing.Size(152, 75);
            this.bt_khachhang.TabIndex = 0;
            this.bt_khachhang.Text = "Khách hàng";
            this.bt_khachhang.UseVisualStyleBackColor = false;
            this.bt_khachhang.Click += new System.EventHandler(this.bt_khachhang_Click);
            // 
            // bt_phong
            // 
            this.bt_phong.BackColor = System.Drawing.Color.White;
            this.bt_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_phong.Location = new System.Drawing.Point(19, 21);
            this.bt_phong.Name = "bt_phong";
            this.bt_phong.Size = new System.Drawing.Size(152, 75);
            this.bt_phong.TabIndex = 0;
            this.bt_phong.Text = "Phòng";
            this.bt_phong.UseVisualStyleBackColor = false;
            this.bt_phong.Click += new System.EventHandler(this.bt_phong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(699, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "XÂY DỰNG PHẦN MỀM QUẢN LÝ KHÁCH SẠN - ĐẠI HỌC KIẾN TRÚC HÀ NỘI - NHÓM 6";
            // 
            // bt_thongtin
            // 
            this.bt_thongtin.Location = new System.Drawing.Point(25, 5);
            this.bt_thongtin.Name = "bt_thongtin";
            this.bt_thongtin.Size = new System.Drawing.Size(95, 30);
            this.bt_thongtin.TabIndex = 2;
            this.bt_thongtin.Text = "Thông tin";
            this.bt_thongtin.UseVisualStyleBackColor = true;
            this.bt_thongtin.Click += new System.EventHandler(this.bt_thongtin_Click);
            // 
            // bt_trogiup
            // 
            this.bt_trogiup.Location = new System.Drawing.Point(131, 5);
            this.bt_trogiup.Name = "bt_trogiup";
            this.bt_trogiup.Size = new System.Drawing.Size(95, 30);
            this.bt_trogiup.TabIndex = 2;
            this.bt_trogiup.Text = "Trợ giúp";
            this.bt_trogiup.UseVisualStyleBackColor = true;
            this.bt_trogiup.Click += new System.EventHandler(this.bt_trogiup_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(241, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 30);
            this.button5.TabIndex = 2;
            this.button5.Text = "Đăng xuất";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // fQLKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bt_trogiup);
            this.Controls.Add(this.bt_thongtin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fQLKS";
            this.Text = "Quản lý khách sạn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_thongke;
        private System.Windows.Forms.Button bt_dichvu;
        private System.Windows.Forms.Button bt_khachhang;
        private System.Windows.Forms.Button bt_phong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_thongtin;
        private System.Windows.Forms.Button bt_trogiup;
        private System.Windows.Forms.Button button5;
    }
}