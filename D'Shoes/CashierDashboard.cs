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
using LiveCharts;
using LiveCharts.Wpf;

namespace D_Shoes
{
    public partial class CashierDashboard : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);
        public CashierDashboard()
        {
            InitializeComponent();
            SqlCommand cmd;
            SqlCommand cmd1;
            SqlCommand cmd2;
            SqlCommand cmd3;
            string query = "SELECT COUNT (id_transaksi) FROM tblTransaksiPenjualan";
            string query1 = "SELECT COUNT (id_transaksi) FROM tblTransaksiPembelian WHERE [status] = 1";
            string query2 = "SELECT COUNT (id_pegawai) FROM tblPegawai WHERE [status] = 1";
            string query3 = "SELECT COUNT (id_member) FROM tblTransaksiMember";
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd1 = new SqlCommand(query1, con);
                cmd2 = new SqlCommand(query2, con);
                cmd3 = new SqlCommand(query3, con);
                

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                Int32 rows_count1 = Convert.ToInt32(cmd1.ExecuteScalar());
                Int32 rows_count2 = Convert.ToInt32(cmd2.ExecuteScalar());
                Int32 rows_count3 = Convert.ToInt32(cmd3.ExecuteScalar());
                
                cmd.Dispose();
                con.Close();

                lbEmployee.Text = rows_count2.ToString();
                lbCustomerTrans.Text = rows_count.ToString();
                lblSupplierTrans.Text = rows_count1.ToString();
                lblMemberTrans.Text = rows_count3.ToString();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        Func<ChartPoint, string> labelpoint = chartpoint => string.Format("({1:P})", chartpoint.Y, chartpoint.Participation);
        public void LoadChart()
        {
            try
            {
                SeriesCollection series = new SeriesCollection();
                foreach(var obj in this.pRG2_KEL09DataSet3.ShoesSalesbyCategory)
                    series.Add(new PieSeries() { Title = obj.Category.ToString(), Values = new ChartValues<int> { obj.Quantity }, DataLabels = true, LabelPoint = labelpoint });
                pieChart1.Series = series;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while load pie chart : " + ex);
            }
        }

        private void lblSupplier_Click(object sender, EventArgs e)
        {
            
        }

        private void lblCategory_Click(object sender, EventArgs e)
        {
            AdditionalForm.CustomerTransHIst Form = new AdditionalForm.CustomerTransHIst();
            Form.Show();
        }

        private void CashierDashboard_Load(object sender, EventArgs e)
        {
            pieChart1.LegendLocation = LegendLocation.Bottom;
            // TODO: This line of code loads data into the 'pRG2_KEL09DataSet3.ShoesSalesbyCategory' table. You can move, or remove it, as needed.
            this.shoesSalesbyCategoryTableAdapter.Fill(this.pRG2_KEL09DataSet3.ShoesSalesbyCategory);
            LoadChart();
            dataGridView1.Visible = false;
        }
    }
}
