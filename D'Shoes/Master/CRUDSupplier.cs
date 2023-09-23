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
using System.Text.RegularExpressions;

namespace D_Shoes.Master
{
    public partial class CRUDSupplier : Form
    {
        String ID;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);
        public CRUDSupplier()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                IdOtomatis Id = new IdOtomatis();
                string sp = "sp_IdSupplier";
                Id.setID("SUP", sp);
                string id = Id.getID();
                string nama = txtName.Text;
                string brand = txtBrand.Text;
                string notel = txtPhoneNumber.Text;
                string alamat = txtAddress.Text;
                if (nama == "" || notel == "" || alamat == "")
                {
                    MessageBox.Show("Fill the data Correctly !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (notel.Length > 13 || notel.Length < 8)
                {
                    MessageBox.Show("Length of the phone number must be 8 - 13 digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhoneNumber.Text = "";
                    txtPhoneNumber.Focus();
                }
                else
                {
                    SqlCommand insert = new SqlCommand("sp_InsertSupplier", con);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("id_supplier", id);
                    insert.Parameters.AddWithValue("nama_supplier", nama);
                    insert.Parameters.AddWithValue("merk",  brand);
                    insert.Parameters.AddWithValue("no_telepon", notel);
                    insert.Parameters.AddWithValue("alamat", alamat);
                    insert.Parameters.AddWithValue("status", 1);

                    con.Open();
                    insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Succes to add data with ID " + id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {

        }

        private void CRUDSupplier_Load(object sender, EventArgs e)
        {
            try
            {
                btSave.Visible = true;
                btUpdate.Visible = false;
                btDelete.Visible = false;
                this.Text = string.Empty;
                this.DoubleBuffered = false;
                LoadData();
                this.CenterToScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }
        }
        void LoadData()
        {
            BindingSource binding1 = new BindingSource();
            try
            {
                txtName.Text = "";
                txtPhoneNumber.Text = "";
                txtAddress.Text = "";
                txtBrand.Text = "";
                try
                {
                    DataTable st = new DataTable();
                    SqlCommand loaddata = new SqlCommand("sp_LoadSupplier", con);
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
                dataGridView1.Columns[0].HeaderCell.Value = "Supplier ID";
                dataGridView1.Columns[1].HeaderCell.Value = "Name";
                dataGridView1.Columns[2].HeaderCell.Value = "Merk";
                dataGridView1.Columns[3].HeaderCell.Value = "Phone Number";
                dataGridView1.Columns[4].HeaderCell.Value = "Address";

                dataGridView1.Columns[0].Width = 120;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[3].Width = 140;
                dataGridView1.Columns[4].Width = 200;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtPhoneNumber.Text == "" || txtAddress.Text == "")
                {
                    MessageBox.Show("Fill the data Correctly !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPhoneNumber.Text.Length > 13 || txtPhoneNumber.Text.Length < 8)
                {
                    MessageBox.Show("Length of the phone number must be 8 - 13 digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhoneNumber.Text = "";
                    txtPhoneNumber.Focus();
                }
                else
                {
                    SqlCommand update = new SqlCommand("sp_UpdateSupplier", con);
                    update.CommandType = CommandType.StoredProcedure;
                    update.Parameters.AddWithValue("id_supplier", ID);
                    update.Parameters.AddWithValue("nama_supplier", txtName.Text);
                    update.Parameters.AddWithValue("merk", txtBrand.Text);
                    update.Parameters.AddWithValue("no_telepon", txtPhoneNumber.Text);
                    update.Parameters.AddWithValue("alamat", txtAddress.Text);
                    con.Open();
                    int result = Convert.ToInt32(update.ExecuteNonQuery());
                    con.Close();
                    if (result != 0)
                    {
                        MessageBox.Show("Successfully updated data !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessfully updated data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btDelete.Visible = true;
            btUpdate.Visible = true;
            btSave.Visible = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtPhoneNumber.Text = row.Cells[3].Value.ToString();
                txtBrand.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult yesno;
            yesno = MessageBox.Show("Sure delete this data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (yesno == DialogResult.Yes)
            {
                con.Open();
                SqlCommand update = new SqlCommand("sp_DeleteSupplier", con);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("id_supplier", ID);
                try
                {
                    update.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Data failed to delete !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtName.Text = "";
            txtBrand.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = txtSearch.Text;
                try
                {
                    con.Open();
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariSupplier", con);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("nama_supplier", cari);
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
                dataGridView1.Columns[0].HeaderCell.Value = "Supplier ID";
                dataGridView1.Columns[1].HeaderCell.Value = "Name";
                dataGridView1.Columns[2].HeaderCell.Value = "Merk";
                dataGridView1.Columns[3].HeaderCell.Value = "Phone Number";
                dataGridView1.Columns[4].HeaderCell.Value = "Address";

                dataGridView1.Columns[0].Width = 120;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[3].Width = 140;
                dataGridView1.Columns[4].Width = 200;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
