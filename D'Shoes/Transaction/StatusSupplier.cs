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

namespace D_Shoes.Transaction
{
    public partial class StatusSupplier : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);
        string IDtrs;
        public StatusSupplier()
        {
            InitializeComponent();
        }

        private void StatusSupplier_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                LoadDataArrived();

            }catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void LoadData()
        {
            BindingSource binding1 = new BindingSource();
            try
            {
                try
                {
                    DataTable st = new DataTable();
                    SqlCommand loaddata = new SqlCommand("sp_LoadTrsPembOnProggress", con);
                    loaddata.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loaddata);
                    sqlDataAdapter.Fill(st);
                    binding1.DataSource = st;
                    dataGridView1.DataSource = binding1;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
                dataGridView1.Columns[0].HeaderCell.Value = "Transaction ID";
                dataGridView1.Columns[1].HeaderCell.Value = "Supplier Name";
                dataGridView1.Columns[2].HeaderCell.Value = "Employee Name";
                dataGridView1.Columns[3].HeaderCell.Value = "Order Date";
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].HeaderCell.Value = "Total Price";
                dataGridView1.Columns[6].HeaderCell.Value = "Status";
                dataGridView1.Columns[0].Width = 150;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[4].Width = 150;
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[5].DefaultCellStyle.Format = "Rp ###,##0.00";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void LoadDataArrived()
        {
            BindingSource binding1 = new BindingSource();
            try
            {
                try
                {
                    DataTable st = new DataTable();
                    SqlCommand loaddata = new SqlCommand("sp_LoadTrsPembArrived", con);
                    loaddata.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loaddata);
                    sqlDataAdapter.Fill(st);
                    binding1.DataSource = st;
                    dataGridView2.DataSource = binding1;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
                dataGridView2.Columns[0].HeaderCell.Value = "Transaction ID";
                dataGridView2.Columns[1].HeaderCell.Value = "Supplier Name";
                dataGridView2.Columns[2].HeaderCell.Value = "Employee Name";
                dataGridView2.Columns[3].HeaderCell.Value = "Order Date";
                dataGridView2.Columns[4].HeaderCell.Value = "Arrived Date";
                dataGridView2.Columns[5].HeaderCell.Value = "Total Price";
                dataGridView2.Columns[6].HeaderCell.Value = "Status";
                dataGridView2.Columns[0].Width = 150;
                dataGridView2.Columns[1].Width = 200;
                dataGridView2.Columns[2].Width = 150;
                dataGridView2.Columns[3].Width = 150;
                dataGridView2.Columns[4].Width = 150;
                dataGridView2.Columns[5].Width = 100;
                dataGridView2.Columns[6].Width = 150;
                dataGridView2.Columns[5].DefaultCellStyle.Format = "Rp ###,##0.00";

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            BindingSource bindingSource2 = new BindingSource();
            try
            {
                if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    try
                    {
                        IDtrs = row.Cells[0].Value.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex);
                    }
                    DataTable dt = new DataTable();
                    SqlCommand search = new SqlCommand("sp_LoadDetilPemb", con);
                    search.CommandType = CommandType.StoredProcedure;
                    search.Parameters.AddWithValue("id_trs", IDtrs);
                    SqlDataAdapter adapter = new SqlDataAdapter(search);
                    adapter.Fill(dt);
                    bindingSource1.DataSource = dt;
                    dataGridView3.DataSource = bindingSource1;
                    con.Close();
                    dataGridView3.Columns[0].HeaderCell.Value = "Transaction ID";
                    dataGridView3.Columns[1].HeaderCell.Value = "Shoe ID";
                    dataGridView3.Columns[2].HeaderCell.Value = "Quantity";
                    dataGridView3.Columns[0].Width = 150;
                    dataGridView3.Columns[1].Width = 145;
                    dataGridView3.Columns[2].Width = 100;

                }
                else
                {
                    MessageBox.Show("Choose 1 Row Data !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btArrived_Click(object sender, EventArgs e)
        {
            string idsepatu;
            try
            {
                con.Close();
                //Insert Transaki Supplier
                con.Open();
                SqlCommand update = new SqlCommand("sp_UpdateStatusTrsPembelian", con);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("@id_transaksi",IDtrs );
                update.ExecuteNonQuery();
                con.Close();
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    con.Open();
                    idsepatu = row.Cells[1].Value.ToString();
                    SqlCommand Update = new SqlCommand("sp_UpdateStatusDetil", con);
                    Update.CommandType = CommandType.StoredProcedure;
                    Update.Parameters.AddWithValue("id_transaksi", IDtrs);
                    Update.Parameters.AddWithValue("@id_sepatu", idsepatu);
                    try
                    {
                        Update.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to saved stock item: " + ex.Message);
                    }
                    con.Close();
                    LoadData();
                    LoadDataArrived();
                }
                MessageBox.Show("Stock Items Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Added Item Failed ! " + ex.Message); 
            }
        }
    }
}
