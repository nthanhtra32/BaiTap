using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Chuong4_Part5
{
    public partial class frmChatlieu : Form
    {
        public frmChatlieu()
        {
            InitializeComponent();
        }

        private void frmChatlieu_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            //mo ket noi
            try
            {
                DAO.OpenConnection();
                string sql = "select*fromtblChatlieu";
                SqlDataAdapter myAdap = new SqlDataAdapter(sql, DAO.conn);
                DataTable tblChatlieu = new DataTable();
                myAdap.Fill(tblChatlieu);
                gridviewChatlieu.DataSource = tblChatlieu;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO.closeconnection();

            }
        }

        private void gridviewChatlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMachatlieu.Text = gridviewChatlieu.CurrentRow.Cells["Machatlieu"].Value.ToString();
            txtTenchatlieu.Text = gridviewChatlieu.CurrentRow.Cells["Tenchatlieu"].Value.ToString();
            txtMachatlieu.Enabled = false;  //them la enabled=true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update tblChatlieu set Tenchatlieu=N'" + txtTenchatlieu.Text.Trim() + "'where Machatlieu='"
                + txtMachatlieu.Text + "'";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.closeconnection();
            LoadDataGridView(); //load lai data
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblChatlieu where Machatlieu='" + txtMachatlieu.Text + "'";
            SqlCommand cmd = new SqlCommand();
            DAO.OpenConnection();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.closeconnection();
            LoadDataGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMachatlieu.Enabled = true;
            txtTenchatlieu.Enabled = true;
            // xoa dulieu trong textbox
            txtMachatlieu.Text = "";
            txtTenchatlieu.Text = "";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMachatlieu.Text == "")
            {
                MessageBox.Show("ban chua nhap ma chat lieu");
                txtMachatlieu.Focus();
                return;

            }
            if (txtTenchatlieu.Text == "")
            {
                MessageBox.Show("ban chua nhap ten chat lieu");
                txtTenchatlieu.Focus();
                return;
            }
            string sqlCheckKey = "select*from tblChatlieu where Machatlieu= '"
                + txtMachatlieu.Text.Trim() + "'";
            DAO.OpenConnection();
            if (DAO.CheckKeyExit(sqlCheckKey))
            {
                MessageBox.Show("Ma chat lieu da ton tai");
                DAO.closeconnection();
                txtMachatlieu.Focus();
                return;
            }
            else
            {
                string sql = "insert into tblChatlieu values('" +
                txtMachatlieu.Text.Trim() + "', N' " +
                txtTenchatlieu.Text.Trim() + "')";

                DAO.OpenConnection();
                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                DAO.closeconnection();
                LoadDataGridView();
            }


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 