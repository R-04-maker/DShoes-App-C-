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
    public partial class StatusSepatuGaransi : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);
        string IDGr;
        string idTrs;
        string idShoes;
        public StatusSepatuGaransi()
        {
            InitializeComponent();
        }

        private void StatusSepatuGaransi_Load(object sender, EventArgs e)
        {
            //sp_UpdateStatusGaransi;
            LoadData();


        }
        public void LoadData()
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                try
                {
                    con.Open();
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_LoadGaransiStatus", con);
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
                dataGridView1.Columns[0].HeaderCell.Value = "Guaranty ID";
                dataGridView1.Columns[1].HeaderCell.Value = "Transaction ID";
                dataGridView1.Columns[2].HeaderCell.Value = "Shoe ID";
                dataGridView1.Columns[3].HeaderCell.Value = "Date In";
                dataGridView1.Columns[4].HeaderCell.Value = "Date Out";

                dataGridView1.Columns[0].Width = 150;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[4].Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand update = new SqlCommand("sp_UpdateStatusGaransi",con);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("id_TrsGaransi", IDGr);
                update.Parameters.AddWithValue("id_Transaksi", idTrs);
                update.Parameters.AddWithValue("id_sepatu", idShoes);
                try
                {
                    con.Open();
                    update.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update " + ex.Message);
                }

                MessageBox.Show("Data updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    try
                    {
                        IDGr = row.Cells[0].Value.ToString();
                        idTrs = row.Cells[1].Value.ToString();
                        idShoes = row.Cells[2].Value.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while compare transaction date:" + ex);
                    }
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
    }
}
