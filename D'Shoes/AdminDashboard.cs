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
using System.Configuration;


namespace D_Shoes
{
    public partial class AdminDashboard : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);
        public AdminDashboard()
        {
            InitializeComponent();
            SqlCommand cmd;
            SqlCommand cmd1;
            SqlCommand cmd2;
            SqlCommand cmd3;
            SqlCommand cmd4;
            SqlCommand cmd5;
            SqlCommand cmd6;
            SqlCommand cmd7;
            string query = "SELECT COUNT (id_sepatu) FROM tblSepatu WHERE [status] = 1";
            string query1 = "SELECT COUNT (id_kategori) FROM tblKategoriSepatu WHERE [status] = 1";
            string query2 = "SELECT COUNT (id_supplier) FROM tblSupplier WHERE [status] = 1";
            string query3 = "SELECT COUNT (id_member) FROM tblTipeMember WHERE [status] = 1";
            string query4 = "SELECT COUNT (id_jnsPembayaran) FROM tblJenisPembayaran WHERE [status] = 1";
            string query5 = "SELECT COUNT (id_garansi) FROM tblGaransi WHERE [status] = 1";
            string query6 = "SELECT COUNT (id_pegawai) FROM tblPegawai WHERE [status] = 1";
            string query7 = "SELECT COUNT (id_jabatan) FROM tbljabatan WHERE [status] = 1";
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd1 = new SqlCommand(query1, con);
                cmd2 = new SqlCommand(query2, con);
                cmd3 = new SqlCommand(query3, con);
                cmd4 = new SqlCommand(query4, con);
                cmd5 = new SqlCommand(query5, con);
                cmd6 = new SqlCommand(query6, con);
                cmd7 = new SqlCommand(query7, con);

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                Int32 rows_count1 = Convert.ToInt32(cmd1.ExecuteScalar());
                Int32 rows_count2 = Convert.ToInt32(cmd2.ExecuteScalar());
                Int32 rows_count3 = Convert.ToInt32(cmd3.ExecuteScalar());
                Int32 rows_count4 = Convert.ToInt32(cmd4.ExecuteScalar());
                Int32 rows_count5 = Convert.ToInt32(cmd5.ExecuteScalar());
                Int32 rows_count6 = Convert.ToInt32(cmd6.ExecuteScalar());
                Int32 rows_count7 = Convert.ToInt32(cmd7.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                lblShoes.Text = rows_count.ToString();
                lblCategory.Text = rows_count1.ToString();
                lblSupplier.Text = rows_count2.ToString();
                lblMemberType.Text = rows_count3.ToString();
                lblPayMethod.Text = rows_count4.ToString();
                lblGuaranty.Text = rows_count5.ToString();
                lblEmployee.Text = rows_count6.ToString();
                lblEmployeeType.Text = rows_count7.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
