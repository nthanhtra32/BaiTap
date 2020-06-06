namespace Chuong4_Part5
{
    partial class DMH
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
            this.tlbMahang = new System.Windows.Forms.Label();
            this.tblTenhang = new System.Windows.Forms.Label();
            this.cmbChatlieu = new System.Windows.Forms.ComboBox();
            this.tblChatlieu = new System.Windows.Forms.Label();
            this.gridViewDMH = new System.Windows.Forms.DataGridView();
            this.tblGianhap = new System.Windows.Forms.Label();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.txtGianhap = new System.Windows.Forms.TextBox();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.tblGiaban = new System.Windows.Forms.Label();
            this.tblSoluong = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.tblXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.Mahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Machatlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDMH)).BeginInit();
            this.SuspendLayout();
            // 
            // tlbMahang
            // 
            this.tlbMahang.AutoSize = true;
            this.tlbMahang.Location = new System.Drawing.Point(45, 66);
            this.tlbMahang.Name = "tlbMahang";
            this.tlbMahang.Size = new System.Drawing.Size(71, 20);
            this.tlbMahang.TabIndex = 0;
            this.tlbMahang.Text = "Mã hàng";
            // 
            // tblTenhang
            // 
            this.tblTenhang.AutoSize = true;
            this.tblTenhang.Location = new System.Drawing.Point(45, 164);
            this.tblTenhang.Name = "tblTenhang";
            this.tblTenhang.Size = new System.Drawing.Size(76, 20);
            this.tblTenhang.TabIndex = 2;
            this.tblTenhang.Text = "Tên hàng";
            // 
            // cmbChatlieu
            // 
            this.cmbChatlieu.FormattingEnabled = true;
            this.cmbChatlieu.Location = new System.Drawing.Point(527, 63);
            this.cmbChatlieu.Name = "cmbChatlieu";
            this.cmbChatlieu.Size = new System.Drawing.Size(121, 28);
            this.cmbChatlieu.TabIndex = 5;
            // 
            // tblChatlieu
            // 
            this.tblChatlieu.AutoSize = true;
            this.tblChatlieu.Location = new System.Drawing.Point(422, 66);
            this.tblChatlieu.Name = "tblChatlieu";
            this.tblChatlieu.Size = new System.Drawing.Size(71, 20);
            this.tblChatlieu.TabIndex = 4;
            this.tblChatlieu.Text = "Chất liệu";
            // 
            // gridViewDMH
            // 
            this.gridViewDMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahang,
            this.Tenhang,
            this.Gianhap,
            this.Giaban,
            this.Soluong,
            this.Machatlieu,
            this.Anh,
            this.Ghichu});
            this.gridViewDMH.Location = new System.Drawing.Point(3, 294);
            this.gridViewDMH.Name = "gridViewDMH";
            this.gridViewDMH.RowHeadersWidth = 62;
            this.gridViewDMH.RowTemplate.Height = 28;
            this.gridViewDMH.Size = new System.Drawing.Size(1249, 196);
            this.gridViewDMH.TabIndex = 6;
            // 
            // tblGianhap
            // 
            this.tblGianhap.AutoSize = true;
            this.tblGianhap.Location = new System.Drawing.Point(45, 234);
            this.tblGianhap.Name = "tblGianhap";
            this.tblGianhap.Size = new System.Drawing.Size(74, 20);
            this.tblGianhap.TabIndex = 7;
            this.tblGianhap.Text = "Giá nhập";
            // 
            // txtMahang
            // 
            this.txtMahang.Location = new System.Drawing.Point(151, 66);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(100, 26);
            this.txtMahang.TabIndex = 8;
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(151, 164);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(100, 26);
            this.txtTenhang.TabIndex = 9;
            // 
            // txtGianhap
            // 
            this.txtGianhap.Location = new System.Drawing.Point(151, 234);
            this.txtGianhap.Name = "txtGianhap";
            this.txtGianhap.Size = new System.Drawing.Size(100, 26);
            this.txtGianhap.TabIndex = 10;
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(527, 138);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(121, 26);
            this.txtGiaban.TabIndex = 11;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(527, 234);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(121, 26);
            this.txtSoluong.TabIndex = 12;
            // 
            // tblGiaban
            // 
            this.tblGiaban.AutoSize = true;
            this.tblGiaban.Location = new System.Drawing.Point(442, 135);
            this.tblGiaban.Name = "tblGiaban";
            this.tblGiaban.Size = new System.Drawing.Size(65, 20);
            this.tblGiaban.TabIndex = 13;
            this.tblGiaban.Text = "Giá bán";
            // 
            // tblSoluong
            // 
            this.tblSoluong.AutoSize = true;
            this.tblSoluong.Location = new System.Drawing.Point(442, 237);
            this.tblSoluong.Name = "tblSoluong";
            this.tblSoluong.Size = new System.Drawing.Size(72, 20);
            this.tblSoluong.TabIndex = 14;
            this.tblSoluong.Text = "Số lượng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(84, 531);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tblXoa
            // 
            this.tblXoa.Location = new System.Drawing.Point(244, 531);
            this.tblXoa.Name = "tblXoa";
            this.tblXoa.Size = new System.Drawing.Size(75, 30);
            this.tblXoa.TabIndex = 16;
            this.tblXoa.Text = "Xóa";
            this.tblXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(446, 531);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(673, 531);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(853, 531);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 30);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Mahang
            // 
            this.Mahang.HeaderText = "Mã hàng";
            this.Mahang.MinimumWidth = 8;
            this.Mahang.Name = "Mahang";
            this.Mahang.Width = 150;
            // 
            // Tenhang
            // 
            this.Tenhang.HeaderText = "Tên hàng";
            this.Tenhang.MinimumWidth = 8;
            this.Tenhang.Name = "Tenhang";
            this.Tenhang.Width = 150;
            // 
            // Gianhap
            // 
            this.Gianhap.HeaderText = "Giá nhập";
            this.Gianhap.MinimumWidth = 8;
            this.Gianhap.Name = "Gianhap";
            this.Gianhap.Width = 150;
            // 
            // Giaban
            // 
            this.Giaban.HeaderText = "Giá bán";
            this.Giaban.MinimumWidth = 8;
            this.Giaban.Name = "Giaban";
            this.Giaban.Width = 150;
            // 
            // Soluong
            // 
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 8;
            this.Soluong.Name = "Soluong";
            this.Soluong.Width = 150;
            // 
            // Machatlieu
            // 
            this.Machatlieu.HeaderText = "Mã chất liệu";
            this.Machatlieu.MinimumWidth = 8;
            this.Machatlieu.Name = "Machatlieu";
            this.Machatlieu.Width = 150;
            // 
            // Anh
            // 
            this.Anh.HeaderText = "Ảnh";
            this.Anh.MinimumWidth = 8;
            this.Anh.Name = "Anh";
            this.Anh.Width = 150;
            // 
            // Ghichu
            // 
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.MinimumWidth = 8;
            this.Ghichu.Name = "Ghichu";
            this.Ghichu.Width = 150;
            // 
            // DMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 633);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.tblXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tblSoluong);
            this.Controls.Add(this.tblGiaban);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtGiaban);
            this.Controls.Add(this.txtGianhap);
            this.Controls.Add(this.txtTenhang);
            this.Controls.Add(this.txtMahang);
            this.Controls.Add(this.tblGianhap);
            this.Controls.Add(this.gridViewDMH);
            this.Controls.Add(this.cmbChatlieu);
            this.Controls.Add(this.tblChatlieu);
            this.Controls.Add(this.tblTenhang);
            this.Controls.Add(this.tlbMahang);
            this.Name = "DMH";
            this.Text = "DMH";
            this.Load += new System.EventHandler(this.DMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tlbMahang;
        private System.Windows.Forms.Label tblTenhang;
        private System.Windows.Forms.ComboBox cmbChatlieu;
        private System.Windows.Forms.Label tblChatlieu;
        private System.Windows.Forms.DataGridView gridViewDMH;
        private System.Windows.Forms.Label tblGianhap;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.TextBox txtGianhap;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label tblGiaban;
        private System.Windows.Forms.Label tblSoluong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button tblXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machatlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
    }
}