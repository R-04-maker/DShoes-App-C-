using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace D_Shoes.Master
{
    public partial class CRUDGaransi : Form
    {
        string ID;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);
        public CRUDGaransi()
        {
            InitializeComponent();
        }

        private void CRUDEkpedisi_Load(object sender, EventArgs e)
        {
            LoadData();
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
                tbGuarantyType.Text = row.Cells[1].Value.ToString();
                tbGuarantyDesc.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Sure delete this data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                con.Open();
                SqlCommand delete = new SqlCommand("sp_DeleteGaransi", con);
                delete.CommandType = CommandType.StoredProcedure;
                delete.Parameters.AddWithValue("id_garansi", ID);
                try
                {
                    delete.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
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
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ID;
                string NamaEx = tbGuarantyType.Text;
                string desc = tbGuarantyDesc.Text;
                if (NamaEx == "" || tbGuarantyDesc.Text == "")
                {
                    MessageBox.Show("Please, enter the data correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    SqlCommand update = new SqlCommand("sp_UpdateGaransi", con);
                    update.CommandType = CommandType.StoredProcedure;
                    update.Parameters.AddWithValue("id_garansi", ID);
                    update.Parameters.AddWithValue("jenis_garansi", NamaEx);
                    update.Parameters.AddWithValue("deskripsi", desc);
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
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                IdOtomatis Id = new IdOtomatis();
                string sp = "sp_IdGaransi";
                Id.setID("GR", sp);
                string ID = Id.getID();
                con.Close();
                string NamaEx = tbGuarantyType.Text;
                string desc = tbGuarantyDesc.Text;
                if (NamaEx == "" || desc == "")
                {
                    MessageBox.Show("Please, enter the data correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand insert = new SqlCommand("sp_InsertGaransi", con);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("id_garansi", ID);
                    insert.Parameters.AddWithValue("jenis_garansi", NamaEx);
                    insert.Parameters.AddWithValue("deskripsi", desc);
                    insert.Parameters.AddWithValue("status", 1);
                    con.Open();
                    insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data saved successfully with ID " + ID, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        void LoadData()
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                tbGuarantyType.Text = "";
                tbGuarantyDesc.Text = "";
                btUpdate.Visible = false;
                btDelete.Visible = false;
                btSave.Visible = true;
                con.Open();
                try
                {
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_LoadGaransi", con);
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
                dataGridView1.Columns[0].HeaderCell.Value = "Guranty ID";
                dataGridView1.Columns[1].HeaderCell.Value = "Guaranty Type";
                dataGridView1.Columns[2].HeaderCell.Value = "Description";
                dataGridView1.Columns[0].Width = 125;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 400;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        public void Clear()
        {
            LoadData();
            btSave.Visible = true;
            btDelete.Visible = false;
            btUpdate.Visible = false;
            tbGuarantyDesc.Text = "";
            tbGuarantyType.Text = "";
        }

        private void btRefresh_Click_1(object sender, EventArgs e)
        {
            Clear();
        }
    }
}