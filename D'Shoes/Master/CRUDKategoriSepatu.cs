using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace D_Shoes.Master
{
    public partial class CRUDKatSepatu : Form
    {
        String ID;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);
        public CRUDKatSepatu()
        {
            InitializeComponent();
        }

        private void CRUDKatSepatu_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = string.Empty;
                this.DoubleBuffered = false;
                LoadData();
                this.CenterToScreen();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        void LoadData()
        {
            BindingSource binding1 = new BindingSource();
            try
            {
                btSave.Visible = true;
                btDelete.Visible = false;
                btUpdate.Visible = false;
                txtDesc.Text = "";
                try
                {
                    DataTable st = new DataTable();
                    SqlCommand loaddata = new SqlCommand("sp_LoadKategoriSepatu", con);
                    loaddata.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loaddata);
                    sqlDataAdapter.Fill(st);
                    binding1.DataSource = st;
                    dataGridView1.DataSource = binding1;
                    con.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
                dataGridView1.Columns[0].HeaderCell.Value = "Category ID";
                dataGridView1.Columns[1].HeaderCell.Value = "Shoes Category";
                dataGridView1.Columns[0].Width = 150;
                dataGridView1.Columns[1].Width = 320;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }


        private void btCancel_Click(object sender, EventArgs e)
        {
            LoadData();
            this.Hide();
            AdminMenu adm = new AdminMenu();
            adm.Show();
        }


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btSave.Visible = false;
            btDelete.Visible = true;
            btUpdate.Visible = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                txtDesc.Text = row.Cells[1].Value.ToString();
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDesc.Text == "")
                {
                    MessageBox.Show("Fill the data Correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand update = new SqlCommand("sp_UpdateKategoriSepatu", con);
                    update.CommandType = CommandType.StoredProcedure;

                    update.Parameters.AddWithValue("id_kategori", ID);
                    update.Parameters.AddWithValue("deskripsi_kategori", txtDesc.Text);
                    con.Open();
                    int result = Convert.ToInt32(update.ExecuteNonQuery());
                    con.Close();
                    if (result != 0)
                    {
                        MessageBox.Show("Data succesfully Updated data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unsuccesfully update data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            DialogResult yesno;
            yesno = MessageBox.Show("Sure to delete this data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (yesno == DialogResult.Yes)
            {
                con.Open();
                SqlCommand update = new SqlCommand("sp_DeleteKategoriSepatu", con);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("id_kategori", ID);
                try
                {
                    if(ID == "JNS0001")
                    {
                        MessageBox.Show("this data cannot be deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        update.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Canceled delete data!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            LoadData();
            btSave.Visible = true;
            btDelete.Visible = false;
            btUpdate.Visible = false;
            txtDesc.Text = "";
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                IdOtomatis Id = new IdOtomatis();
                string sp = "sp_IdKategoriSepatu";
                Id.setID("JNS", sp);
                string id = Id.getID();
                string deskripsi = txtDesc.Text;
                if (deskripsi == "")
                {
                    MessageBox.Show("Fill the data Correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand insert = new SqlCommand("sp_InsertKategoriSepatu", con);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("id_kategori", id);
                    insert.Parameters.AddWithValue("deskripsi_kategori", deskripsi);
                    insert.Parameters.AddWithValue("status", 1);
                    con.Open();
                    insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Succesfully saved data with ID " + id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
