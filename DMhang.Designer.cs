namespace Chuong4_Part5
{
    partial class DMhang
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
            this.cmbMahang = new System.Windows.Forms.ComboBox();
            this.tblMahang = new System.Windows.Forms.Label();
            this.tblTenhang = new System.Windows.Forms.Label();
            this.cmbTenhang = new System.Windows.Forms.ComboBox();
            this.tblChatlieu = new System.Windows.Forms.Label();
            this.cmbChatlieu = new System.Windows.Forms.ComboBox();
            this.gridViewDMhang = new System.Windows.Forms.DataGridView();
            this.Mahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDMhang)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMahang
            // 
            this.cmbMahang.FormattingEnabled = true;
            this.cmbMahang.Location = new System.Drawing.Point(181, 51);
            this.cmbMahang.Name = "cmbMahang";
            this.cmbMahang.Size = new System.Drawing.Size(150, 28);
            this.cmbMahang.TabIndex = 0;
            // 
            // tblMahang
            // 
            this.tblMahang.AutoSize = true;
            this.tblMahang.Location = new System.Drawing.Point(48, 54);
            this.tblMahang.Name = "tblMahang";
            this.tblMahang.Size = new System.Drawing.Size(71, 20);
            this.tblMahang.TabIndex = 1;
            this.tblMahang.Text = "Mã hàng";
            // 
            // tblTenhang
            // 
            this.tblTenhang.AutoSize = true;
            this.tblTenhang.Location = new System.Drawing.Point(50, 121);
            this.tblTenhang.Name = "tblTenhang";
            this.tblTenhang.Size = new System.Drawing.Size(76, 20);
            this.tblTenhang.TabIndex = 3;
            this.tblTenhang.Text = "Tên hàng";
            // 
            // cmbTenhang
            // 
            this.cmbTenhang.FormattingEnabled = true;
            this.cmbTenhang.Location = new System.Drawing.Point(181, 118);
            this.cmbTenhang.Name = "cmbTenhang";
            this.cmbTenhang.Size = new System.Drawing.Size(150, 28);
            this.cmbTenhang.TabIndex = 2;
            // 
            // tblChatlieu
            // 
            this.tblChatlieu.AutoSize = true;
            this.tblChatlieu.Location = new System.Drawing.Point(428, 57);
            this.tblChatlieu.Name = "tblChatlieu";
            this.tblChatlieu.Size = new System.Drawing.Size(71, 20);
            this.tblChatlieu.TabIndex = 5;
            this.tblChatlieu.Text = "Chất liêu";
            // 
            // cmbChatlieu
            // 
            this.cmbChatlieu.FormattingEnabled = true;
            this.cmbChatlieu.Location = new System.Drawing.Point(561, 54);
            this.cmbChatlieu.Name = "cmbChatlieu";
            this.cmbChatlieu.Size = new System.Drawing.Size(150, 28);
            this.cmbChatlieu.TabIndex = 4;
            // 
            // gridViewDMhang
            // 
            this.gridViewDMhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDMhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahang,
            this.Tenhang,
            this.Gianhap,
            this.Giaban,
            this.Soluong});
            this.gridViewDMhang.Location = new System.Drawing.Point(12, 190);
            this.gridViewDMhang.Name = "gridViewDMhang";
            this.gridViewDMhang.RowHeadersWidth = 62;
            this.gridViewDMhang.RowTemplate.Height = 28;
            this.gridViewDMhang.Size = new System.Drawing.Size(776, 188);
            this.gridViewDMhang.TabIndex = 6;
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
            // DMhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridViewDMhang);
            this.Controls.Add(this.tblChatlieu);
            this.Controls.Add(this.cmbChatlieu);
            this.Controls.Add(this.tblTenhang);
            this.Controls.Add(this.cmbTenhang);
            this.Controls.Add(this.tblMahang);
            this.Controls.Add(this.cmbMahang);
            this.Name = "DMhang";
            this.Text = "DMhang";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDMhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.tblChatlieu = new System.Windows.Forms.Label();
            this.cmbChatlieu = new System.Windows.Forms.ComboBox();
            this.gridViewDMhang = new System.Windows.Forms.DataGridView();
            this.Mahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDMhang)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMahang
            // 
            this.cmbMahang.FormattingEnabled = true;
            this.cmbMahang.Location = new System.Drawing.Point(181, 51);
            this.cmbMahang.Name = "cmbMahang";
            this.cmbMahang.Size = new System.Drawing.Size(150, 28);
            this.cmbMahang.TabIndex = 0;
            // 
            // tblMahang
            // 
            this.tblMahang.AutoSize = true;
            this.tblMahang.Location = new System.Drawing.Point(48, 54);
            this.tblMahang.Name = "tblMahang";
            this.tblMahang.Size = new System.Drawing.Size(71, 20);
            this.tblMahang.TabIndex = 1;
            this.tblMahang.Text = "Mã hàng";
            // 
            // tblTenhang
            // 
            this.tblTenhang.AutoSize = true;
            this.tblTenhang.Location = new System.Drawing.Point(50, 121);
            this.tblTenhang.Name = "tblTenhang";
            this.tblTenhang.Size = new System.Drawing.Size(76, 20);
            this.tblTenhang.TabIndex = 3;
            this.tblTenhang.Text = "Tên hàng";
            // 
            // cmbTenhang
            // 
            this.cmbTenhang.FormattingEnabled = true;
            this.cmbTenhang.Location = new System.Drawing.Point(181, 118);
            this.cmbTenhang.Name = "cmbTenhang";
            this.cmbTenhang.Size = new System.Drawing.Size(150, 28);
            this.cmbTenhang.TabIndex = 2;
            // 
            // tblChatlieu
            // 
            this.tblChatlieu.AutoSize = true;
            this.tblChatlieu.Location = new System.Drawing.Point(428, 57);
            this.tblChatlieu.Name = "tblChatlieu";
            this.tblChatlieu.Size = new System.Drawing.Size(71, 20);
            this.tblChatlieu.TabIndex = 5;
            this.tblChatlieu.Text = "Chất liêu";
            // 
            // cmbChatlieu
            // 
            this.cmbChatlieu.FormattingEnabled = true;
            this.cmbChatlieu.Location = new System.Drawing.Point(561, 54);
            this.cmbChatlieu.Name = "cmbChatlieu";
            this.cmbChatlieu.Size = new System.Drawing.Size(150, 28);
            this.cmbChatlieu.TabIndex = 4;
            this.cmbChatlieu.Text = "Chất liệu";
            // 
            // gridViewDMhang
            // 
            this.gridViewDMhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDMhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahang,
            this.Tenhang,
            this.Gianhap,
            this.Giaban,
            this.Soluong});
            this.gridViewDMhang.Location = new System.Drawing.Point(12, 190);
            this.gridViewDMhang.Name = "gridViewDMhang";
            this.gridViewDMhang.RowHeadersWidth = 62;
            this.gridViewDMhang.RowTemplate.Height = 28;
            this.gridViewDMhang.Size = new System.Drawing.Size(776, 188);
            this.gridViewDMhang.TabIndex = 6;
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
            // DMhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridViewDMhang);
            this.Controls.Add(this.tblChatlieu);
            this.Controls.Add(this.cmbChatlieu);
            this.Controls.Add(this.tblTenhang);
            this.Controls.Add(this.cmbTenhang);
            this.Controls.Add(this.tblMahang);
            this.Controls.Add(this.cmbMahang);
            this.Name = "DMhang";
            this.Text = "DMhang";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDMhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.tblChatlieu = new System.Windows.Forms.Label();
            this.cmbChatlieu = new System.Windows.Forms.ComboBox();
            this.gridViewDMhang = new System.Windows.Forms.DataGridView();
            this.Mahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDMhang)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMahang
            // 
            this.cmbMahang.FormattingEnabled = true;
            this.cmbMahang.Location = new System.Drawing.Point(181, 51);
            this.cmbMahang.Name = "cmbMahang";
            this.cmbMahang.Size = new System.Drawing.Size(150, 28);
            this.cmbMahang.TabIndex = 0;
            // 
            // tblMahang
            // 
            this.tblMahang.AutoSize = true;
            this.tblMahang.Location = new System.Drawing.Point(48, 54);
            this.tblMahang.Name = "tblMahang";
            this.tblMahang.Size = new System.Drawing.Size(71, 20);
            this.tblMahang.TabIndex = 1;
            this.tblMahang.Text = "Mã hàng";
            // 
            // tblTenhang
            // 
            this.tblTenhang.AutoSize = true;
            this.tblTenhang.Location = new System.Drawing.Point(50, 121);
            this.tblTenhang.Name = "tblTenhang";
            this.tblTenhang.Size = new System.Drawing.Size(76, 20);
            this.tblTenhang.TabIndex = 3;
            this.tblTenhang.Text = "Tên hàng";
            // 
            // cmbTenhang
            // 
            this.cmbTenhang.FormattingEnabled = true;
            this.cmbTenhang.Location = new System.Drawing.Point(181, 118);
            this.cmbTenhang.Name = "cmbTenhang";
            this.cmbTenhang.Size = new System.Drawing.Size(150, 28);
            this.cmbTenhang.TabIndex = 2;
            // 
            // tblChatlieu
            // 
            this.tblChatlieu.AutoSize = true;
            this.tblChatlieu.Location = new System.Drawing.Point(428, 57);
            this.tblChatlieu.Name = "tblChatlieu";
            this.tblChatlieu.Size = new System.Drawing.Size(71, 20);
            this.tblChatlieu.TabIndex = 5;
            this.tblChatlieu.Text = "Chất liêu";
            // 
            // cmbChatlieu
            // 
            this.cmbChatlieu.FormattingEnabled = true;
            this.cmbChatlieu.Location = new System.Drawing.Point(561, 54);
            this.cmbChatlieu.Name = "cmbChatlieu";
            this.cmbChatlieu.Size = new System.Drawing.Size(150, 28);
            this.cmbChatlieu.TabIndex = 4;
            // 
            // gridViewDMhang
            // 
            this.gridViewDMhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDMhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahang,
            this.Tenhang,
            this.Gianhap,
            this.Giaban,
            this.Soluong});
            this.gridViewDMhang.Location = new System.Drawing.Point(12, 190);
            this.gridViewDMhang.Name = "gridViewDMhang";
            this.gridViewDMhang.RowHeadersWidth = 62;
            this.gridViewDMhang.RowTemplate.Height = 28;
            this.gridViewDMhang.Size = new System.Drawing.Size(776, 188);
            this.gridViewDMhang.TabIndex = 6;
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
            // DMhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridViewDMhang);
            this.Controls.Add(this.tblChatlieu);
            this.Controls.Add(this.cmbChatlieu);
            this.Controls.Add(this.tblTenhang);
            this.Controls.Add(this.cmbTenhang);
            this.Controls.Add(this.tblMahang);
            this.Controls.Add(this.cmbMahang);
            this.Name = "DMhang";
            this.Text = "DMhang";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDMhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.tblChatlieu = new System.Windows.Forms.Label();
            this.cmbChatlieu = new System.Windows.Forms.ComboBox();
            this.gridViewDMhang = new System.Windows.Forms.DataGridView();
            this.Mahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDMhang)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMahang
            // 
            this.cmbMahang.FormattingEnabled = true;
            this.cmbMahang.Location = new System.Drawing.Point(181, 51);
            this.cmbMahang.Name = "cmbMahang";
            this.cmbMahang.Size = new System.Drawing.Size(150, 28);
            this.cmbMahang.TabIndex = 0;
            // 
            // tblMahang
            // 
            this.tblMahang.AutoSize = true;
            this.tblMahang.Location = new System.Drawing.Point(48, 54);
            this.tblMahang.Name = "tblMahang";
            this.tblMahang.Size = new System.Drawing.Size(71, 20);
            this.tblMahang.TabIndex = 1;
            this.tblMahang.Text = "Mã hàng";
            // 
            // tblTenhang
            // 
            this.tblTenhang.AutoSize = true;
            this.tblTenhang.Location = new System.Drawing.Point(50, 121);
            this.tblTenhang.Name = "tblTenhang";
            this.tblTenhang.Size = new System.Drawing.Size(76, 20);
            this.tblTenhang.TabIndex = 3;
            this.tblTenhang.Text = "Tên hàng";
            // 
            // cmbTenhang
            // 
            this.cmbTenhang.FormattingEnabled = true;
            this.cmbTenhang.Location = new System.Drawing.Point(181, 118);
            this.cmbTenhang.Name = "cmbTenhang";
            this.cmbTenhang.Size = new System.Drawing.Size(150, 28);
            this.cmbTenhang.TabIndex = 2;
            // 
            // tblChatlieu
            // 
            this.tblChatlieu.AutoSize = true;
            this.tblChatlieu.Location = new System.Drawing.Point(428, 57);
            this.tblChatlieu.Name = "tblChatlieu";
            this.tblChatlieu.Size = new System.Drawing.Size(71, 20);
            this.tblChatlieu.TabIndex = 5;
            this.tblChatlieu.Text = "Chất liêu";
            // 
            // cmbChatlieu
            // 
            this.cmbChatlieu.FormattingEnabled = true;
            this.cmbChatlieu.Location = new System.Drawing.Point(561, 54);
            this.cmbChatlieu.Name = "cmbChatlieu";
            this.cmbChatlieu.Size = new System.Drawing.Size(150, 28);
            this.cmbChatlieu.TabIndex = 4;
            // 
            // gridViewDMhang
            // 
            this.gridViewDMhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDMhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahang,
            this.Tenhang,
            this.Gianhap,
            this.Giaban,
            this.Soluong});
            this.gridViewDMhang.Location = new System.Drawing.Point(12, 190);
            this.gridViewDMhang.Name = "gridViewDMhang";
            this.gridViewDMhang.RowHeadersWidth = 62;
            this.gridViewDMhang.RowTemplate.Height = 28;
            this.gridViewDMhang.Size = new System.Drawing.Size(776, 188);
            this.gridViewDMhang.TabIndex = 6;
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
            // DMhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridViewDMhang);
            this.Controls.Add(this.tblChatlieu);
            this.Controls.Add(this.cmbChatlieu);
            this.Controls.Add(this.tblTenhang);
            this.Controls.Add(this.cmbTenhang);
            this.Controls.Add(this.tblMahang);
            this.Controls.Add(this.cmbMahang);
            this.Name = "DMhang";
            this.Text = "DMhang";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDMhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.tblChatlieu = new System.Windows.Forms.Label();
            this.cmbChatlieu = new System.Windows.Forms.ComboBox();
            this.gridviewDanhmuchang = new System.Windows.Forms.DataGridView();
            this.Mahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDanhmuchang)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMahang
            // 
            this.cmbMahang.FormattingEnabled = true;
            this.cmbMahang.Location = new System.Drawing.Point(181, 51);
            this.cmbMahang.Name = "cmbMahang";
            this.cmbMahang.Size = new System.Drawing.Size(150, 28);
            this.cmbMahang.TabIndex = 0;
            // 
            // tblMahang
            // 
            this.tblMahang.AutoSize = true;
            this.tblMahang.Location = new System.Drawing.Point(48, 54);
            this.tblMahang.Name = "tblMahang";
            this.tblMahang.Size = new System.Drawing.Size(71, 20);
            this.tblMahang.TabIndex = 1;
            this.tblMahang.Text = "Mã hàng";
            // 
            // tblTenhang
            // 
            this.tblTenhang.AutoSize = true;
            this.tblTenhang.Location = new System.Drawing.Point(50, 121);
            this.tblTenhang.Name = "tblTenhang";
            this.tblTenhang.Size = new System.Drawing.Size(76, 20);
            this.tblTenhang.TabIndex = 3;
            this.tblTenhang.Text = "Tên hàng";
            // 
            // cmbTenhang
            // 
            this.cmbTenhang.FormattingEnabled = true;
            this.cmbTenhang.Location = new System.Drawing.Point(181, 118);
            this.cmbTenhang.Name = "cmbTenhang";
            this.cmbTenhang.Size = new System.Drawing.Size(150, 28);
            this.cmbTenhang.TabIndex = 2;
            // 
            // tblChatlieu
            // 
            this.tblChatlieu.AutoSize = true;
            this.tblChatlieu.Location = new System.Drawing.Point(428, 57);
            this.tblChatlieu.Name = "tblChatlieu";
            this.tblChatlieu.Size = new System.Drawing.Size(71, 20);
            this.tblChatlieu.TabIndex = 5;
            this.tblChatlieu.Text = "Chất liêu";
            // 
            // cmbChatlieu
            // 
            this.cmbChatlieu.FormattingEnabled = true;
            this.cmbChatlieu.Location = new System.Drawing.Point(561, 54);
            this.cmbChatlieu.Name = "cmbChatlieu";
            this.cmbChatlieu.Size = new System.Drawing.Size(150, 28);
            this.cmbChatlieu.TabIndex = 4;
            // 
            // gridviewDanhmuchang
            // 
            this.gridviewDanhmuchang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewDanhmuchang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahang,
            this.Tenhang,
            this.Gianhap,
            this.Giaban,
            this.Soluong});
            this.gridviewDanhmuchang.Location = new System.Drawing.Point(12, 190);
            this.gridviewDanhmuchang.Name = "gridviewDanhmuchang";
            this.gridviewDanhmuchang.RowHeadersWidth = 62;
            this.gridviewDanhmuchang.RowTemplate.Height = 28;
            this.gridviewDanhmuchang.Size = new System.Drawing.Size(776, 188);
            this.gridviewDanhmuchang.TabIndex = 6;
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
            // DMhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridviewDanhmuchang);
            this.Controls.Add(this.tblChatlieu);
            this.Controls.Add(this.cmbChatlieu);
            this.Controls.Add(this.tblTenhang);
            this.Controls.Add(this.cmbTenhang);
            this.Controls.Add(this.tblMahang);
            this.Controls.Add(this.cmbMahang);
            this.Name = "DMhang";
            this.Text = "DMhang";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDanhmuchang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.tblChatlieu = new System.Windows.Forms.Label();
            this.cmbChatlieu = new System.Windows.Forms.ComboBox();
            this.gridviewDanhmuchang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDanhmuchang)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMahang
            // 
            this.cmbMahang.FormattingEnabled = true;
            this.cmbMahang.Location = new System.Drawing.Point(181, 51);
            this.cmbMahang.Name = "cmbMahang";
            this.cmbMahang.Size = new System.Drawing.Size(150, 28);
            this.cmbMahang.TabIndex = 0;
            // 
            // tblMahang
            // 
            this.tblMahang.AutoSize = true;
            this.tblMahang.Location = new System.Drawing.Point(48, 54);
            this.tblMahang.Name = "tblMahang";
            this.tblMahang.Size = new System.Drawing.Size(71, 20);
            this.tblMahang.TabIndex = 1;
            this.tblMahang.Text = "Mã hàng";
            // 
            // tblTenhang
            // 
            this.tblTenhang.AutoSize = true;
            this.tblTenhang.Location = new System.Drawing.Point(50, 121);
            this.tblTenhang.Name = "tblTenhang";
            this.tblTenhang.Size = new System.Drawing.Size(76, 20);
            this.tblTenhang.TabIndex = 3;
            this.tblTenhang.Text = "Tên hàng";
            // 
            // cmbTenhang
            // 
            this.cmbTenhang.FormattingEnabled = true;
            this.cmbTenhang.Location = new System.Drawing.Point(181, 118);
            this.cmbTenhang.Name = "cmbTenhang";
            this.cmbTenhang.Size = new System.Drawing.Size(150, 28);
            this.cmbTenhang.TabIndex = 2;
            // 
            // tblChatlieu
            // 
            this.tblChatlieu.AutoSize = true;
            this.tblChatlieu.Location = new System.Drawing.Point(428, 57);
            this.tblChatlieu.Name = "tblChatlieu";
            this.tblChatlieu.Size = new System.Drawing.Size(71, 20);
            this.tblChatlieu.TabIndex = 5;
            this.tblChatlieu.Text = "Chất liêu";
            // 
            // cmbChatlieu
            // 
            this.cmbChatlieu.FormattingEnabled = true;
            this.cmbChatlieu.Location = new System.Drawing.Point(561, 54);
            this.cmbChatlieu.Name = "cmbChatlieu";
            this.cmbChatlieu.Size = new System.Drawing.Size(150, 28);
            this.cmbChatlieu.TabIndex = 4;
            // 
            // gridviewDanhmuchang
            // 
            this.gridviewDanhmuchang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewDanhmuchang.Location = new System.Drawing.Point(54, 185);
            this.gridviewDanhmuchang.Name = "gridviewDanhmuchang";
            this.gridviewDanhmuchang.RowHeadersWidth = 62;
            this.gridviewDanhmuchang.RowTemplate.Height = 28;
            this.gridviewDanhmuchang.Size = new System.Drawing.Size(680, 188);
            this.gridviewDanhmuchang.TabIndex = 6;
            // 
            // DMhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridviewDanhmuchang);
            this.Controls.Add(this.tblChatlieu);
            this.Controls.Add(this.cmbChatlieu);
            this.Controls.Add(this.tblTenhang);
            this.Controls.Add(this.cmbTenhang);
            this.Controls.Add(this.tblMahang);
            this.Controls.Add(this.cmbMahang);
            this.Name = "DMhang";
            this.Text = "DMhang";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDanhmuchang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.tblChatlieu = new System.Windows.Forms.Label();
            this.cmbChatlieu = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMahang
            // 
            this.cmbMahang.FormattingEnabled = true;
            this.cmbMahang.Location = new System.Drawing.Point(181, 51);
            this.cmbMahang.Name = "cmbMahang";
            this.cmbMahang.Size = new System.Drawing.Size(150, 28);
            this.cmbMahang.TabIndex = 0;
            // 
            // tblMahang
            // 
            this.tblMahang.AutoSize = true;
            this.tblMahang.Location = new System.Drawing.Point(48, 54);
            this.tblMahang.Name = "tblMahang";
            this.tblMahang.Size = new System.Drawing.Size(71, 20);
            this.tblMahang.TabIndex = 1;
            this.tblMahang.Text = "Mã hàng";
            // 
            // tblTenhang
            // 
            this.tblTenhang.AutoSize = true;
            this.tblTenhang.Location = new System.Drawing.Point(50, 121);
            this.tblTenhang.Name = "tblTenhang";
            this.tblTenhang.Size = new System.Drawing.Size(76, 20);
            this.tblTenhang.TabIndex = 3;
            this.tblTenhang.Text = "Tên hàng";
            // 
            // cmbTenhang
            // 
            this.cmbTenhang.FormattingEnabled = true;
            this.cmbTenhang.Location = new System.Drawing.Point(181, 118);
            this.cmbTenhang.Name = "cmbTenhang";
            this.cmbTenhang.Size = new System.Drawing.Size(150, 28);
            this.cmbTenhang.TabIndex = 2;
            // 
            // tblChatlieu
            // 
            this.tblChatlieu.AutoSize = true;
            this.tblChatlieu.Location = new System.Drawing.Point(428, 57);
            this.tblChatlieu.Name = "tblChatlieu";
            this.tblChatlieu.Size = new System.Drawing.Size(71, 20);
            this.tblChatlieu.TabIndex = 5;
            this.tblChatlieu.Text = "Chất liêu";
            // 
            // cmbChatlieu
            // 
            this.cmbChatlieu.FormattingEnabled = true;
            this.cmbChatlieu.Location = new System.Drawing.Point(561, 54);
            this.cmbChatlieu.Name = "cmbChatlieu";
            this.cmbChatlieu.Size = new System.Drawing.Size(150, 28);
            this.cmbChatlieu.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(680, 188);
            this.dataGridView1.TabIndex = 6;
            // 
            // DMhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tblChatlieu);
            this.Controls.Add(this.cmbChatlieu);
            this.Controls.Add(this.tblTenhang);
            this.Controls.Add(this.cmbTenhang);
            this.Controls.Add(this.tblMahang);
            this.Controls.Add(this.cmbMahang);
            this.Name = "DMhang";
            this.Text = "DMhang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.tblChatlieu = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMahang
            // 
            this.cmbMahang.FormattingEnabled = true;
            this.cmbMahang.Location = new System.Drawing.Point(181, 51);
            this.cmbMahang.Name = "cmbMahang";
            this.cmbMahang.Size = new System.Drawing.Size(150, 28);
            this.cmbMahang.TabIndex = 0;
            // 
            // tblMahang
            // 
            this.tblMahang.AutoSize = true;
            this.tblMahang.Location = new System.Drawing.Point(48, 54);
            this.tblMahang.Name = "tblMahang";
            this.tblMahang.Size = new System.Drawing.Size(71, 20);
            this.tblMahang.TabIndex = 1;
            this.tblMahang.Text = "Mã hàng";
            // 
            // tblTenhang
            // 
            this.tblTenhang.AutoSize = true;
            this.tblTenhang.Location = new System.Drawing.Point(50, 121);
            this.tblTenhang.Name = "tblTenhang";
            this.tblTenhang.Size = new System.Drawing.Size(76, 20);
            this.tblTenhang.TabIndex = 3;
            this.tblTenhang.Text = "Tên hàng";
            // 
            // cmbTenhang
            // 
            this.cmbTenhang.FormattingEnabled = true;
            this.cmbTenhang.Location = new System.Drawing.Point(181, 118);
            this.cmbTenhang.Name = "cmbTenhang";
            this.cmbTenhang.Size = new System.Drawing.Size(150, 28);
            this.cmbTenhang.TabIndex = 2;
            // 
            // tblChatlieu
            // 
            this.tblChatlieu.AutoSize = true;
            this.tblChatlieu.Location = new System.Drawing.Point(428, 57);
            this.tblChatlieu.Name = "tblChatlieu";
            this.tblChatlieu.Size = new System.Drawing.Size(71, 20);
            this.tblChatlieu.TabIndex = 5;
            this.tblChatlieu.Text = "Chất liêu";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(561, 54);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 28);
            this.comboBox3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(680, 188);
            this.dataGridView1.TabIndex = 6;
            // 
            // DMhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tblChatlieu);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.tblTenhang);
            this.Controls.Add(this.cmbTenhang);
            this.Controls.Add(this.tblMahang);
            this.Controls.Add(this.cmbMahang);
            this.Name = "DMhang";
            this.Text = "DMhang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.tblChatlieu = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMahang
            // 
            this.cmbMahang.FormattingEnabled = true;
            this.cmbMahang.Location = new System.Drawing.Point(181, 51);
            this.cmbMahang.Name = "cmbMahang";
            this.cmbMahang.Size = new System.Drawing.Size(150, 28);
            this.cmbMahang.TabIndex = 0;
            // 
            // tblMahang
            // 
            this.tblMahang.AutoSize = true;
            this.tblMahang.Location = new System.Drawing.Point(48, 54);
            this.tblMahang.Name = "tblMahang";
            this.tblMahang.Size = new System.Drawing.Size(71, 20);
            this.tblMahang.TabIndex = 1;
            this.tblMahang.Text = "Mã hàng";
            // 
            // tblTenhang
            // 
            this.tblTenhang.AutoSize = true;
            this.tblTenhang.Location = new System.Drawing.Point(50, 121);
            this.tblTenhang.Name = "tblTenhang";
            this.tblTenhang.Size = new System.Drawing.Size(76, 20);
            this.tblTenhang.TabIndex = 3;
            this.tblTenhang.Text = "Tên hàng";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(181, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 28);
            this.comboBox2.TabIndex = 2;
            // 
            // tblChatlieu
            // 
            this.tblChatlieu.AutoSize = true;
            this.tblChatlieu.Location = new System.Drawing.Point(428, 57);
            this.tblChatlieu.Name = "tblChatlieu";
            this.tblChatlieu.Size = new System.Drawing.Size(71, 20);
            this.tblChatlieu.TabIndex = 5;
            this.tblChatlieu.Text = "Chất liêu";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(561, 54);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 28);
            this.comboBox3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(680, 188);
            this.dataGridView1.TabIndex = 6;
            // 
            // DMhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tblChatlieu);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.tblTenhang);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.tblMahang);
            this.Controls.Add(this.cmbMahang);
            this.Name = "DMhang";
            this.Text = "DMhang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.tblChatlieu = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // tblMahang
            // 
            this.tblMahang.AutoSize = true;
            this.tblMahang.Location = new System.Drawing.Point(48, 54);
            this.tblMahang.Name = "tblMahang";
            this.tblMahang.Size = new System.Drawing.Size(71, 20);
            this.tblMahang.TabIndex = 1;
            this.tblMahang.Text = "Mã hàng";
            // 
            // tblTenhang
            // 
            this.tblTenhang.AutoSize = true;
            this.tblTenhang.Location = new System.Drawing.Point(50, 121);
            this.tblTenhang.Name = "tblTenhang";
            this.tblTenhang.Size = new System.Drawing.Size(76, 20);
            this.tblTenhang.TabIndex = 3;
            this.tblTenhang.Text = "Tên hàng";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(181, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 28);
            this.comboBox2.TabIndex = 2;
            // 
            // tblChatlieu
            // 
            this.tblChatlieu.AutoSize = true;
            this.tblChatlieu.Location = new System.Drawing.Point(428, 57);
            this.tblChatlieu.Name = "tblChatlieu";
            this.tblChatlieu.Size = new System.Drawing.Size(71, 20);
            this.tblChatlieu.TabIndex = 5;
            this.tblChatlieu.Text = "Chất liêu";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(561, 54);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 28);
            this.comboBox3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(680, 188);
            this.dataGridView1.TabIndex = 6;
            // 
            // DMhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tblChatlieu);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.tblTenhang);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.tblMahang);
            this.Controls.Add(this.comboBox1);
            this.Name = "DMhang";
            this.Text = "DMhang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // tblMahang
            // 
            this.tblMahang.AutoSize = true;
            this.tblMahang.Location = new System.Drawing.Point(48, 54);
            this.tblMahang.Name = "tblMahang";
            this.tblMahang.Size = new System.Drawing.Size(71, 20);
            this.tblMahang.TabIndex = 1;
            this.tblMahang.Text = "Mã hàng";
            // 
            // tblTenhang
            // 
            this.tblTenhang.AutoSize = true;
            this.tblTenhang.Location = new System.Drawing.Point(50, 121);
            this.tblTenhang.Name = "tblTenhang";
            this.tblTenhang.Size = new System.Drawing.Size(76, 20);
            this.tblTenhang.TabIndex = 3;
            this.tblTenhang.Text = "Tên hàng";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(181, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 28);
            this.comboBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chất liêu";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(561, 54);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 28);
            this.comboBox3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(680, 188);
            this.dataGridView1.TabIndex = 6;
            // 
            // DMhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.tblTenhang);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.tblMahang);
            this.Controls.Add(this.comboBox1);
            this.Name = "DMhang";
            this.Text = "DMhang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // tblMahang
            // 
            this.tblMahang.AutoSize = true;
            this.tblMahang.Location = new System.Drawing.Point(48, 54);
            this.tblMahang.Name = "tblMahang";
            this.tblMahang.Size = new System.Drawing.Size(71, 20);
            this.tblMahang.TabIndex = 1;
            this.tblMahang.Text = "Mã hàng";
            // 
            // tblTenhang
            // 
            this.tblTenhang.AutoSize = true;
            this.tblTenhang.Location = new System.Drawing.Point(50, 121);
            this.tblTenhang.Name = "tblTenhang";
            this.tblTenhang.Size = new System.Drawing.Size(51, 20);
            this.tblTenhang.TabIndex = 3;
            this.tblTenhang.Text = "label2";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(181, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 28);
            this.comboBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(561, 54);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 28);
            this.comboBox3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(680, 188);
            this.dataGridView1.TabIndex = 6;
            // 
            // DMhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.tblTenhang);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.tblMahang);
            this.Controls.Add(this.comboBox1);
            this.Name = "DMhang";
            this.Text = "DMhang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // tblMahang
            // 
            this.tblMahang.AutoSize = true;
            this.tblMahang.Location = new System.Drawing.Point(48, 54);
            this.tblMahang.Name = "tblMahang";
            this.tblMahang.Size = new System.Drawing.Size(71, 20);
            this.tblMahang.TabIndex = 1;
            this.tblMahang.Text = "Mã hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(181, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 28);
            this.comboBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(561, 54);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 28);
            this.comboBox3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(680, 188);
            this.dataGridView1.TabIndex = 6;
            // 
            // DMhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.tblMahang);
            this.Controls.Add(this.comboBox1);
            this.Name = "DMhang";
            this.Text = "DMhang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(181, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 28);
            this.comboBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(561, 54);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 28);
            this.comboBox3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(452, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // DMhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "DMhang";
            this.Text = "DMhang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // DMhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Name = "DMhang";
            this.Text = "DMhang";
            this.ResumeLayout(false);

            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(489, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // DMhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Name = "DMhang";
            this.Text = "DMhang";
            this.ResumeLayout(false);

        }

        #endregion
    }
}