using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Chuong4_Part5
{
    public partial class DMH : Form
    {
        public DMH()
        {
            InitializeComponent();
        }
        private void DMH_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            LoadDataToGridView();
            fillDataToCombo();
            DAO.closeconnection();
        }
        private void LoadDataToGridView()
        {
            string sql = "Select * from tblHang";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            gridViewDMH.DataSource = table;
        }
        public void fillDataToCombo()
        {
            string sql = "Select * from tblChatlieu";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbChatlieu.DataSource = table;
            cmbChatlieu.ValueMember = "Machatlieu";
            cmbChatlieu.DisplayMember = "Tenchatlieu";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenhang.Text = "";
            txtMahang.Text = "";
            txtGianhap.Text = "";
            txtGiaban.Text = "";
            txtSoluong.Text = "";
            cmbChatlieu.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //kiểm tra dữ liệu
            //các trường ko được trống
            if (txtMahang.Text == "")
            {
                MessageBox.Show("Bạn ko được để trống mã hàng");
                txtMahang.Focus();
                return;
            }
           if (txtTenhang.Text == "")
            {
                MessageBox.Show(" Bạn ko được để trống tên hàng");
                txtTenhang.Focus();
                return;
            }
           if(cmbChatlieu.SelectedIndex==-1)
            {
                MessageBox.Show("Bạn chưa chọn chất liệu");
                return;
            }
           if (txtGiaban.Text == "")
            {
                MessageBox.Show("Bạn ko được để trống giá bán");
                txtGiaban.Focus();
                return;

            }
            if (txtGianhap.Text == "")
            {
                MessageBox.Show("Bạn ko được để trống giá nhập");
                txtGianhap.Focus();
                return;

            }
            if (txtSoluong.Text == "")
            {
                MessageBox.Show("Bạn ko được để trống số lượng");
                txtSoluong.Focus();
                return;
            }
            string sql = "select*from tblHang where Mahang='" +
                txtMahang.Text.Trim() + "'";
            DAO.OpenConnection();
            if (DAO.CheckKeyExit(sql))
            {
                MessageBox.Show("Mã hàng đã tồn tại");
                txtMahang.Focus();
                DAO.closeconnection();
                return;

            }
            else
            {
                sql = "insert into tblHang (Mahang,Tenhang,Gianhap,Giaban,"+"Soluong,Machatlieu,Anh,Ghichu)"+ 
                    "values ('" + txtMahang.Text.Trim() + "',N'" + txtTenhang.Text.Trim()
                    + "'," + txtGianhap.Text + "," + txtGiaban.Text.Trim() + "," + txtSoluong.Text.Trim() + ",'"
                    + cmbChatlieu.SelectedValue.ToString() + "',null,null)";
                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                MessageBox.Show(sql);

                cmd.ExecuteNonQuery();
                LoadDataToGridView();
                fillDataToCombo();
                DAO.closeconnection();
            }
        }
    }
}
//đưa ảnh vào csdl ở trang 155
//để thay đổi thông tin của combobox sử dụng.... ở trang 157,158