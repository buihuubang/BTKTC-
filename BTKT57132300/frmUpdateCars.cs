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
    public partial class frmUpdateCars : Form
    {
        public frmUpdateCars()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmUpdateCars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLXEDataSet.Xe' table. You can move, or remove it, as needed.
            this.xeTableAdapter.Fill(this.qLXEDataSet.Xe);

        }

        void Load_DL()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7MH332Q\SQLEXPRESS;Initial Catalog=QLXE;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Xe", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgCars.DataSource = ds.Tables[0];
            con.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7MH332Q\SQLEXPRESS;Initial Catalog=QLXE;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Xe", con);
            DataSet ds = new DataSet(); 
            da.Fill(ds, "Xe");
            DataTable dt = ds.Tables["Xe"];
            DataRow row = dt.NewRow();
            row["MaXe"] = txtMaXe.Text;
            row["BienSoXe"] = txtBienSoXe.Text;
            row["HangSanXuat"] = txtHangSanXuat.Text;
            row["TongSoGhe"] = txtTongSoGhe.Text;
            dt.Rows.Add(row);
            string insert_str = "Insert into Xe(MaXe,BienSoXe,HangSanXuat,TongSoGhe) values (@maxe,@biensoxe,@hangsanxuat,@tongsoghe)";
            SqlCommand cmd = new SqlCommand(insert_str, con);
            cmd.Parameters.Add("@maxe", SqlDbType.NVarChar, 50, "MaXe");
            cmd.Parameters.Add("@biensoxe", SqlDbType.NVarChar, 50, "BienSoXe");
            cmd.Parameters.Add("@hangsanxuat", SqlDbType.NVarChar, 50, "HangSanXuat");
            cmd.Parameters.Add("@tongsoghe", SqlDbType.NVarChar, 50, "TongSoGhe");
            da.InsertCommand = cmd;
            da.Update(ds, "Xe");
            Load_DL();
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7MH332Q\SQLEXPRESS;Initial Catalog=QLXE;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Xe", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Xe");
            DataTable dt = ds.Tables["Xe"];
            DataRow row = dt.NewRow();
            DataColumn[] primaryKeys = new DataColumn[] { dt.Columns[0] };
            dt.PrimaryKey = primaryKeys;
            row = dt.Rows.Find(txtMaXe.Text);
            row["MaXe"] = txtMaXe.Text;
            row.Delete();
            string delete_str = "delete from Xe where MaXe=@maxe";
            SqlCommand cmd = new SqlCommand(delete_str, con);
            cmd.Parameters.Add("@maxe", SqlDbType.NVarChar, 50, "Maxe");
            da.DeleteCommand = cmd;
            da.Update(ds, "Xe");
            Load_DL();
            con.Close();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7MH332Q\SQLEXPRESS;Initial Catalog=QLXE;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Xe", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Xe");
            DataTable dt = ds.Tables["Xe"];
            DataRow row = dt.NewRow();
            DataColumn[] primaryKeys = new DataColumn[] { dt.Columns[0] };
            dt.PrimaryKey = primaryKeys;
            row = dt.Rows.Find(txtMaXe.Text);
            row["MaXe"] = txtMaXe.Text;
            row["BienSoXe"] = txtBienSoXe.Text;
            row["HangSanXuat"] = txtHangSanXuat.Text;
            row["TongSoGhe"] = txtTongSoGhe;
            string update_str = "update Xe set BienSoXe=@biensoxe, HangSanXuat=@hangsanxuat, TongSoGhe=@tongsoghe where MaXe=@maxe";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
