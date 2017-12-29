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

namespace BTKT57132300
{
    public partial class frmUpdateTrip : Form
    {
        public frmUpdateTrip()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmUpdateTrip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLXEDataSet.ChuyenXe' table. You can move, or remove it, as needed.
            this.chuyenXeTableAdapter.Fill(this.qLXEDataSet.ChuyenXe);

        }

        void Load_DL()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7MH332Q\SQLEXPRESS;Initial Catalog=QLXE;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From ChuyenXe", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgTrip.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7MH332Q\SQLEXPRESS;Initial Catalog=QLXE;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From ChuyenXe", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "ChuyenXe");
            DataTable dt = ds.Tables["ChuyenXe"];
            DataRow row = dt.NewRow();
            row["Ngay"] = DateVal.Text;
            row["MaXe"] = txtMaXe.Text;
            row["TaiXe"] = txtTaiXe.Text;
            row["NoiDen"] = txtNoiDen.Text;
            row["SoVe"] = txtSoVe.Text;
            dt.Rows.Add(row);
            string insert_str = "Insert into ChuyenXe(Ngay,MaXe,TaiXe,NoiDen,SoVe) values (@ngay,@maxe,@taixe,@noiden,@sove)";
            SqlCommand cmd = new SqlCommand(insert_str, con);
            cmd.Parameters.Add("@ngay", SqlDbType.NVarChar, 50, "Ngay");
            cmd.Parameters.Add("@maxe", SqlDbType.NVarChar, 50, "Maxe");
            cmd.Parameters.Add("@taixe", SqlDbType.NVarChar, 50, "TaiXe");
            cmd.Parameters.Add("@noiden", SqlDbType.NVarChar, 50, "NoiDen");
            cmd.Parameters.Add("@sove", SqlDbType.NVarChar, 50, "SoVe");
            da.InsertCommand = cmd;
            da.Update(ds, "ChuyenXe");
            Load_DL();
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7MH332Q\SQLEXPRESS;Initial Catalog=QLXE;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From ChuyenXe", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "ChuyenXe");
            DataTable dt = ds.Tables["ChuyenXe"];
            DataRow row = dt.NewRow();
            DataColumn[] primaryKeys = new DataColumn[] { dt.Columns[0] };
            dt.PrimaryKey = primaryKeys;
            row = dt.Rows.Find(txtMaXe.Text);
            row["MaXe"] = txtMaXe.Text;
            row.Delete();
            string delete_str = "delete from ChuyenXe where MaXe=@maxe";
            SqlCommand cmd = new SqlCommand(delete_str, con);
            cmd.Parameters.Add("@maxe", SqlDbType.NVarChar, 50, "Maxe");
            da.DeleteCommand = cmd;
            da.Update(ds, "ChuyenXe");
            Load_DL();
            con.Close();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7MH332Q\SQLEXPRESS;Initial Catalog=QLXE;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From ChuyenXe", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "ChuyenXe");
            DataTable dt = ds.Tables["ChuyenXe"];
            DataRow row = dt.NewRow();
            DataColumn[] primaryKeys = new DataColumn[] { dt.Columns[0] };
            dt.PrimaryKey = primaryKeys;
            row = dt.Rows.Find(txtMaXe.Text);
            row["MaXe"] = txtMaXe.Text;
            row["Ngay"] = DateVal.Text;
            row["TaiXe"] = txtTaiXe.Text;
            row["NoiDen"] = txtNoiDen.Text;
            row["SoVe"] = txtSoVe.Text;
            string update_str = "update Xe set Ngay=@ngay, TaiXe=@taixe, NoiDen=@noiden where MaXe=@maxe";
            SqlCommand cmd = new SqlCommand(update_str, con);
            cmd.Parameters.Add("@maxe", SqlDbType.NVarChar, 50, "MaXe");
            cmd.Parameters.Add("@biensoxe", SqlDbType.NVarChar, 50, "BienSoXe");
            cmd.Parameters.Add("@hangsanxuat", SqlDbType.NVarChar, 50, "HangSanXuat");
            cmd.Parameters.Add("@tongsoghe", SqlDbType.NVarChar, 50, "TongSoGhe");
            da.UpdateCommand = cmd;
            da.Update(ds, "Xe");
            Load_DL();
            con.Close();
        }

    }
}
