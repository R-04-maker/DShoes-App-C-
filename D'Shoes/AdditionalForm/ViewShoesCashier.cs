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
using System.IO;


namespace D_Shoes.AdditionalForm
{
    public partial class ViewShoesCashier : Form
    {
        String ID;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);
        public ViewShoesCashier()
        {
            InitializeComponent();
        }

        private void ViewSepatuKasir_Load(object sender, EventArgs e)
        {

        }

        private void ViewSepatuKasir_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRG2_KEL09DataSet1.tblKategoriSepatu' table. You can move, or remove it, as needed.
            this.tblKategoriSepatuTableAdapter.Fill(this.pRG2_KEL09DataSet1.tblKategoriSepatu);
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        public void LoadData()
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                cbCategory.Text = "-- Choose Shoes Category --";
                try
                {
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("Select * from LoadSepatu ", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dataGridView1.DataSource = bindingSource1;
                    DataGridViewColumn column = dataGridView1.Columns[8];
                    column.FillWeight = 200;
                    column.Width = 100;
                    ((DataGridViewImageColumn)dataGridView1.Columns[8]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                dataGridView1.Columns[0].FillWeight = 100;
                dataGridView1.Columns[0].HeaderCell.Value = "Shoes ID";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].HeaderCell.Value = "Shoes Name";
                dataGridView1.Columns[1].Width = 125;
                dataGridView1.Columns[2].HeaderCell.Value = "Category";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].HeaderCell.Value = "Merk";
                dataGridView1.Columns[3].Width = 125;
                dataGridView1.Columns[4].HeaderCell.Value = "Guaranty Type";
                dataGridView1.Columns[4].Width = 125;
                dataGridView1.Columns[5].HeaderCell.Value = "Stock";
                dataGridView1.Columns[5].Width = 50;
                dataGridView1.Columns[6].HeaderCell.Value = "Selling Price";
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[7].HeaderCell.Value = "Purchase Price";
                dataGridView1.Columns[7].Width = 150;
                dataGridView1.Columns[8].HeaderCell.Value = "Image";
                dataGridView1.Columns[8].Width = 200;
                dataGridView1.Columns[6].DefaultCellStyle.Format = "Rp ###,##0.00";
                dataGridView1.Columns[7].DefaultCellStyle.Format = "Rp ###,##0.00";
                dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = cbCategory.Text;
                try
                {
                    con.Open();
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariSepatubyKategori", con);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("category", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dataGridView1.DataSource = bindingSource1;
                    DataGridViewColumn column = dataGridView1.Columns[8];
                    column.FillWeight = 80;
                    //column.Width = 100;
                    ((DataGridViewImageColumn)dataGridView1.Columns[8]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                dataGridView1.Columns[0].FillWeight = 100;
                dataGridView1.Columns[0].HeaderCell.Value = "Shoes ID";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].HeaderCell.Value = "Shoes Name";
                dataGridView1.Columns[1].Width = 125;
                dataGridView1.Columns[2].HeaderCell.Value = "Category";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].HeaderCell.Value = "Merk";
                dataGridView1.Columns[3].Width = 125;
                dataGridView1.Columns[4].HeaderCell.Value = "Guaranty Type";
                dataGridView1.Columns[4].Width = 125;
                dataGridView1.Columns[5].HeaderCell.Value = "Stock";
                dataGridView1.Columns[5].Width = 50;
                dataGridView1.Columns[6].HeaderCell.Value = "Selling Price";
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[7].HeaderCell.Value = "Purchase Price";
                dataGridView1.Columns[7].Width = 150;
                dataGridView1.Columns[8].HeaderCell.Value = "Image";
                dataGridView1.Columns[8].Width = 200;
                dataGridView1.Columns[6].DefaultCellStyle.Format = "Rp ###,##0.00";
                dataGridView1.Columns[7].DefaultCellStyle.Format = "Rp ###,##0.00";
                dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                con.Close();
            }
            catch (NullReferenceException ex)
            {

            }            
        }

        private void caribtn_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = txtSearch.Text;
                try
                {
                    con.Open();
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariSepatu", con);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("nama_sepatu", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dataGridView1.DataSource = bindingSource1;
                    DataGridViewColumn column = dataGridView1.Columns[8];
                    column.FillWeight = 80;
                    column.Width = 100;
                    ((DataGridViewImageColumn)dataGridView1.Columns[8]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                dataGridView1.Columns[0].FillWeight = 100;
                dataGridView1.Columns[0].HeaderCell.Value = "Shoes ID";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].HeaderCell.Value = "Shoes Name";
                dataGridView1.Columns[1].Width = 125;
                dataGridView1.Columns[2].HeaderCell.Value = "Category";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].HeaderCell.Value = "Merk";
                dataGridView1.Columns[3].Width = 125;
                dataGridView1.Columns[4].HeaderCell.Value = "Guaranty Type";
                dataGridView1.Columns[4].Width = 125;
                dataGridView1.Columns[5].HeaderCell.Value = "Stock";
                dataGridView1.Columns[5].Width = 50;
                dataGridView1.Columns[6].HeaderCell.Value = "Selling Price";
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[7].HeaderCell.Value = "Purchase Price";
                dataGridView1.Columns[7].Width = 150;
                dataGridView1.Columns[8].HeaderCell.Value = "Image";
                dataGridView1.Columns[8].Width = 200;
                dataGridView1.Columns[6].DefaultCellStyle.Format = "Rp ###,##0.00";
                dataGridView1.Columns[7].DefaultCellStyle.Format = "Rp ###,##0.00";
                dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                con.Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
