using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace D_Shoes.AdditionalForm
{
    public partial class CustomerTransHIst : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);
        public CustomerTransHIst()
        {
            InitializeComponent();
        }

        private void SupplierTransHIst_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                con.Open();
                try
                {

                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_LoadTransHistPenjualan", con);
                    view.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dataGridView1.DataSource = bindingSource1;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                dataGridView1.Columns[0].HeaderCell.Value = "Transaction ID";
                dataGridView1.Columns[1].HeaderCell.Value = "Customer ID";
                dataGridView1.Columns[2].HeaderCell.Value = "Employee ID";
                dataGridView1.Columns[3].HeaderCell.Value = "Transaction Date";
                dataGridView1.Columns[4].HeaderCell.Value = "Discount";
                dataGridView1.Columns[5].HeaderCell.Value = "Total Price";
                dataGridView1.Columns[6].HeaderCell.Value = "Payment Method ID";

                dataGridView1.Columns[0].Width = 150;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 175;
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[4].Width = 150;
                dataGridView1.Columns[5].Width = 150;
                dataGridView1.Columns[6].Width = 150;

                dataGridView1.Columns[4].DefaultCellStyle.Format = "Rp ###,##0.00";
                dataGridView1.Columns[5].DefaultCellStyle.Format = "Rp ###,##0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
