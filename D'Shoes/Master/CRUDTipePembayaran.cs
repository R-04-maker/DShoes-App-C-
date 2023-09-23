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

namespace D_Shoes.Master
{
    public partial class CRUDTipePembayaran : Form
    {
        String ID;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);
        public CRUDTipePembayaran()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                btUpdate.Visible = false;
                btDelete.Visible = false;
                btSave.Visible = true;
                //con.Open();
                try
                {
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_LoadJenisPembayaran", con);
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
                dataGridView1.Columns[0].HeaderCell.Value = "ID";
                dataGridView1.Columns[1].HeaderCell.Value = "Payment Method";
                dataGridView1.Columns[2].HeaderCell.Value = "Payment Number";
                dataGridView1.Columns[0].Width = 125;
                dataGridView1.Columns[1].Width = 125;
                dataGridView1.Columns[2].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                IdOtomatis Id = new IdOtomatis();
                string sp = "sp_IdJenisPemb";
                Id.setID("PAY", sp);
                string id = Id.getID();
                string jenis = txtJenisPemb.Text;
                string noPemb = txtPaymentNumber.Text;
                if (jenis == "" || noPemb == "")
                {
                    MessageBox.Show("Please, enter the data correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand insert = new SqlCommand("sp_InsertJenisPembayaran", con);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("id_jnsPembayaran", id);
                    insert.Parameters.AddWithValue("nama_jnsPembayaran", jenis);
                    insert.Parameters.AddWithValue("no_pembayaran", noPemb);
                    insert.Parameters.AddWithValue("status", 1);
                    con.Open();
                    insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data saved successfully with ID " + id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btSave.Visible = false;
            btUpdate.Visible = true;
            btDelete.Visible = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                txtJenisPemb.Text = row.Cells[1].Value.ToString();
                txtPaymentNumber.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ID;
                string jenis = txtJenisPemb.Text;
                string noPemb = txtPaymentNumber.Text;
                if (jenis == "" || noPemb == "")
                {
                    MessageBox.Show("Please, enter the data correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    SqlCommand update = new SqlCommand("sp_UpdateJenisPembayaran", con);
                    update.CommandType = CommandType.StoredProcedure;
                    update.Parameters.AddWithValue("id", id);
                    update.Parameters.AddWithValue("nama_jenis", jenis);
                    update.Parameters.AddWithValue("no_pembayaran", noPemb);
                    try
                    {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            Clear();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Sure delete this data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                con.Open();
                SqlCommand delete = new SqlCommand("sp_DeleteJenisPembayaran", con);
                delete.CommandType = CommandType.StoredProcedure;
                delete.Parameters.AddWithValue("id", ID);
                try
                {
                    if(ID == "PAY0001")
                    {
                        MessageBox.Show("this data cannot be deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        delete.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Data failed to delete!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            Clear();
        }

        private void CRUDTipePembayaran_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            LoadData();
            btSave.Visible = true;
            btDelete.Visible = false;
            btUpdate.Visible = false;
            txtJenisPemb.Text = "";
            txtPaymentNumber.Text = "";
        }

        private void txtPaymentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
