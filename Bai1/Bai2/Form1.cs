using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Bai2
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da_hoinghi;
        DataSet ds_hoinghi;
        DataColumn[] key = new DataColumn[1];
        SqlCommand cmd = new SqlCommand();
        string strsql;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=A209PC02;Initial Catalog=QL_HoiNghi;Integrated Security=True");
            string strSelect = "select * from HoiNghi";
            da_hoinghi = new SqlDataAdapter(strSelect, conn);
            ds_hoinghi = new DataSet();
            da_hoinghi.Fill(ds_hoinghi, "HoiNghi");
            key[0] = ds_hoinghi.Tables["HoiNghi"].Columns[0];
            ds_hoinghi.Tables["HoiNghi"].PrimaryKey = key;
        }
        void Databingding(DataTable pDT)
        {
            txtMaHoiNghi.DataBindings.Clear();
            txtTenHoiNghi.DataBindings.Clear();
            txtSoNguoiThamGia.DataBindings.Clear();

            txtMaHoiNghi.DataBindings.Add("Text", pDT, "MaHN");
            txtTenHoiNghi.DataBindings.Add("Text", pDT, "TenHN");
            txtSoNguoiThamGia.DataBindings.Add("Text", pDT, "SoNguoiThamGia");


            da_hoinghi.Fill(ds_hoinghi, "HoiNghi");
            cbbLoaiPhong.DataSource = ds_hoinghi.Tables[0];
            cbbLoaiPhong.DisplayMember = "LoaiPhong";
            cbbLoaiPhong.ValueMember = "MaHN";
        }
        void loadGrid()
        {
            dgvDSPHN.DataSource = ds_hoinghi.Tables[0];
            Databingding(ds_hoinghi.Tables[0]);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow newrow = ds_hoinghi.Tables[0].NewRow();
            newrow["MaHN"] = txtMaHoiNghi.Text;
            newrow["TenHN"] = txtTenHoiNghi.Text;
            newrow["SoNguoiThamGia"] = txtSoNguoiThamGia.Text;
            newrow["LoaiPhong"] = cbbLoaiPhong.Text;
            ds_hoinghi.Tables[0].Rows.Add(newrow);
            //SqlCommandBuilder cB = new SqlCommandBuilder(da_hoinghi);
            //da_hoinghi.Update(ds_hoinghi, "HoiNghi");
        }

        private void btnLuuThemMoi_Click(object sender, EventArgs e)
        {
            //SqlCommandBuilder cB = new SqlCommandBuilder(da_hoinghi);
            //da_hoinghi.Update(ds_hoinghi, "HoiNghi");
            //txtMaHoiNghi.Clear();
            //txtTenHoiNghi.Clear();
            //txtSoNguoiThamGia.Clear();
        }

        private void btnXoaPhongHN_Click(object sender, EventArgs e)
        {
            DataRow dr = ds_hoinghi.Tables[0].Rows.Find(txtMaHoiNghi.Text);
            if (dr != null)
            {
                dr.Delete();
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {

        }

        private void cbbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadGrid();
        }
    }
}
