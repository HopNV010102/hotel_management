
namespace WindowsFormsApp2
{
    partial class fdatphong
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
            this.txt_id_MKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_hd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id_p = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ngaydat = new System.Windows.Forms.TextBox();
            this.bt_datphong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id_MKH
            // 
            this.txt_id_MKH.Location = new System.Drawing.Point(159, 54);
            this.txt_id_MKH.Name = "txt_id_MKH";
            this.txt_id_MKH.Size = new System.Drawing.Size(157, 22);
            this.txt_id_MKH.TabIndex = 0;
            this.txt_id_MKH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã khách hàng :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 296);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng còn trống";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(762, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellclick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã hóa đơn :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_id_hd
            // 
            this.txt_id_hd.Location = new System.Drawing.Point(159, 13);
            this.txt_id_hd.Name = "txt_id_hd";
            this.txt_id_hd.Size = new System.Drawing.Size(157, 22);
            this.txt_id_hd.TabIndex = 0;
            this.txt_id_hd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Phòng :";
            // 
            // txt_id_p
            // 
            this.txt_id_p.Location = new System.Drawing.Point(159, 91);
            this.txt_id_p.Name = "txt_id_p";
            this.txt_id_p.Size = new System.Drawing.Size(157, 22);
            this.txt_id_p.TabIndex = 0;
            this.txt_id_p.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày đặt :";
            // 
            // txt_ngaydat
            // 
            this.txt_ngaydat.Location = new System.Drawing.Point(493, 13);
            this.txt_ngaydat.Name = "txt_ngaydat";
            this.txt_ngaydat.Size = new System.Drawing.Size(157, 22);
            this.txt_ngaydat.TabIndex = 0;
            this.txt_ngaydat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bt_datphong
            // 
            this.bt_datphong.BackColor = System.Drawing.Color.MediumBlue;
            this.bt_datphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_datphong.ForeColor = System.Drawing.Color.White;
            this.bt_datphong.Location = new System.Drawing.Point(424, 75);
            this.bt_datphong.Name = "bt_datphong";
            this.bt_datphong.Size = new System.Drawing.Size(104, 38);
            this.bt_datphong.TabIndex = 5;
            this.bt_datphong.Text = "Đặt phòng";
            this.bt_datphong.UseVisualStyleBackColor = false;
            this.bt_datphong.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(546, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hủy bỏ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fdatphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_datphong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ngaydat);
            this.Controls.Add(this.txt_id_hd);
            this.Controls.Add(this.txt_id_p);
            this.Controls.Add(this.txt_id_MKH);
            this.Name = "fdatphong";
            this.Text = "Đặt phòng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.close);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id_MKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id_hd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id_p;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ngaydat;
        private System.Windows.Forms.Button bt_datphong;
        private System.Windows.Forms.Button button1;
    }
}