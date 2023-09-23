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
    public partial class TransaksiGaransi : Form
    {
        string trsID;
        DateTime Trs;
        DateTime Expired;
        string id, search;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);
        public TransaksiGaransi()
        {
            InitializeComponent();
        }

        private void txtSearchIDTrans_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BindingSource bindingSource1 = new BindingSource();
                try
                {
                    search = txtSearchIDTrans.Text;
                    DataTable dt = new DataTable();
                    SqlCommand cari = new SqlCommand("sp_LoadDetilShoes", con);
                    cari.CommandType = CommandType.StoredProcedure;
                    cari.Parameters.AddWithValue("id_trs", search);
                    SqlDataAdapter adapter = new SqlDataAdapter(cari);
                    adapter.Fill(dt);
                    if(dt.Rows.Count != 0)
                    { 
                        DateTime exp = DateTime.Parse(dt.Rows[0][4].ToString());
                        double month = 30;
                        DateTime exp1 = exp.AddDays(month);
                        if (exp1 < DateTime.Today)
                        {
                            MessageBox.Show("Sorry, your warranty period has expired", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            bindingSource1.DataSource = dt;
                            dataGridView1.DataSource = bindingSource1;
                            con.Close();
                            dataGridView1.Columns[0].HeaderCell.Value = "Transaction ID";
                            dataGridView1.Columns[1].HeaderCell.Value = "Shoes ID";
                            dataGridView1.Columns[2].HeaderCell.Value = "Shoes Name";
                            dataGridView1.Columns[3].HeaderCell.Value = "Guaranty Description";
                            dataGridView1.Columns[4].Visible = false;
                            dataGridView1.Columns[5].Visible = false;
                            dataGridView1.Columns[0].Width = 145;
                            dataGridView1.Columns[1].Width = 125;
                            dataGridView1.Columns[2].Width = 170;
                            dataGridView1.Columns[3].Width = 200;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Transaction id not found or warranty has expired!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
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
                        trsID = row.Cells[0].Value.ToString();
                        txtShoeID.Text = row.Cells[1].Value.ToString();
                        txtShoeName.Text = row.Cells[2].Value.ToString();
                        txtGuaranty.Text = row.Cells[3].Value.ToString();
                    }
                    catch(Exception ex)
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

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                IdOtomatis a = new IdOtomatis();
                string sp = "sp_IdTrsGaransi";
                a.setID("TRSG", sp);
                id = a.getID();
                //Insert ke tabel transaski Customer
                string shoesID = txtShoeID.Text;
                search = txtSearchIDTrans.Text;
                string dateIn = cmbDateIn.Value.ToString("yyyy/MM/dd");
                string dateOut = cmbDateOut.Value.ToString("yyyy/MM/dd");
                string desc = txtDesc.Text;
                DateTime dateIndate = DateTime.Parse(cmbDateIn.Value.ToString());
                DateTime dateOutdate = DateTime.Parse(cmbDateOut.Value.ToString());
                if (dateIndate > dateOutdate) 
                {
                    MessageBox.Show("The out date must be after in date !","Information!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }else if (txtSearchIDTrans.Text == "" || txtShoeID.Text == "" || txtShoeName.Text == "" || txtGuaranty.Text == "" || txtDesc.Text == "")
                {
                    MessageBox.Show("Fill the data Correctly !", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //insert ke table transaksi penjualan
                    SqlCommand insert = new SqlCommand("sp_InsertTRSGaransi", con);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("id_trsGaransi", id);
                    insert.Parameters.AddWithValue("id_transaksi", trsID);
                    insert.Parameters.AddWithValue("id_sepatu", shoesID);
                    insert.Parameters.AddWithValue("tgl_masuk", dateIn);
                    insert.Parameters.AddWithValue("tgl_keluar", dateOut);
                    insert.Parameters.AddWithValue("keterangan", desc);
                    insert.Parameters.AddWithValue("status", 1);
                    con.Open();
                    insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data saved successfully with ID " + id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            StatusSepatuGaransi form = new StatusSepatuGaransi();
            form.Show();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            txtSearchIDTrans.Text = "";
            txtShoeName.Text = "";
            txtGuaranty.Text = "";
            txtDesc.Text = "";
            cmbDateIn.Value = DateTime.Now;
            cmbDateOut.Value = DateTime.Now;
        }

        private void TransaksiGaransi_Load(object sender, EventArgs e)
        {
            cmbDateIn.Value = DateTime.Now;
            cmbDateOut.Value = DateTime.Now;
        }
    }
}
