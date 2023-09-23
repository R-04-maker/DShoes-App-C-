using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using PagedList;


namespace D_Shoes
{
    public partial class CRUDSepatu : Form
    {
        String ID;
        double beli, jual;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);
        public CRUDSepatu()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                IdOtomatis a = new IdOtomatis();
                string sp = "sp_IdSepatu";
                a.setID("SP", sp);
                string id = a.getID();
                string nama = txtNamaSepatu.Text;
                if (nama == "" || txtStock.Text == "" || txtHargaBeli.Text == "" || txtHargaJual.Text == "" || cbKategoriSepatu.SelectedValue == null || cbSupplier.SelectedValue == null)
                {
                    MessageBox.Show("Please Fill the Data Correctly !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (beli >= jual)
                {
                    MessageBox.Show("Selling price must be more than the purchase price !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtStock.Text == "0")
                {
                    MessageBox.Show("Stock cannot be empty or zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    string kategori = cbKategoriSepatu.SelectedValue.ToString();
                    string supplier = cbSupplier.SelectedValue.ToString();
                    string garansi = cmbGuaranty.SelectedValue.ToString();
                    int stock = int.Parse(txtStock.Text);
                    decimal harga1 = Convert.ToDecimal(txtHargaBeli.Text);
                    decimal harga2 = Convert.ToDecimal(txtHargaJual.Text);
                    MemoryStream stream = new MemoryStream();
                    pbGambar.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();

                    SqlCommand insert = new SqlCommand("sp_InsertSepatu", con);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("id_sepatu", id);
                    insert.Parameters.AddWithValue("id_kategori", kategori);
                    insert.Parameters.AddWithValue("id_supplier", supplier);
                    insert.Parameters.AddWithValue("id_garansi", garansi);
                    insert.Parameters.AddWithValue("nama_sepatu", nama);
                    insert.Parameters.AddWithValue("stock", stock);
                    insert.Parameters.AddWithValue("harga_beli", harga1);
                    insert.Parameters.AddWithValue("harga_jual", harga2);
                    insert.Parameters.AddWithValue("gbr", pic);
                    insert.Parameters.AddWithValue("status", 1);
                    con.Open();
                    insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Succesfully save the Data !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cbKategoriSepatu.SelectedIndex = -1;
                cbSupplier.SelectedIndex = -1;
                txtNamaSepatu.Text = "";
                txtStock.Text = "";
                txtHargaJual.Text = "";
                txtHargaBeli.Text = "";
                pbGambar.Image = Properties.Resources.noimage;
                btUpdate.Visible = false;
                btDelete.Visible = false;
                btSave.Visible = true;
                cbKategoriSepatu.Text = "-- Choose Shoes Category --";
                cbSupplier.Text = "-- Choose Shoes Merk --";
                try
                {
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_LoadSepatu", con);
                    view.CommandType = CommandType.StoredProcedure;
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
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[6].HeaderCell.Value = "Selling Price";
                dataGridView1.Columns[6].Width = 200;
                dataGridView1.Columns[7].HeaderCell.Value = "Purchase Price";
                dataGridView1.Columns[7].Width = 200;
                dataGridView1.Columns[8].HeaderCell.Value = "Image";
                dataGridView1.Columns[8].Width = 100;
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

        private async void CRUDSepatu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRG2_KEL09DataSet1.tblGaransi' table. You can move, or remove it, as needed.
            this.tblGaransiTableAdapter.FillBy(this.pRG2_KEL09DataSet1.tblGaransi);
            // TODO: This line of code loads data into the 'pRG2_KEL09DataSet1.tblSupplier' table. You can move, or remove it, as needed.
            this.tblSupplierTableAdapter.FillBy(this.pRG2_KEL09DataSet1.tblSupplier);
            // TODO: This line of code loads data into the 'pRG2_KEL09DataSet1.tblKategoriSepatu' table. You can move, or remove it, as needed.
            this.tblKategoriSepatuTableAdapter.Fill(this.pRG2_KEL09DataSet1.tblKategoriSepatu);
            try
            {
                LoadData();
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ID;
                string nama = txtNamaSepatu.Text;
                if (beli >= jual)
                {
                    MessageBox.Show("Selling price must be more than the purchase price !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtStock.Text == "0")
                {
                    MessageBox.Show("Stock cannot be empty or zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (nama == "" || txtStock.Text == "" || txtHargaBeli.Text == "" || txtHargaJual.Text == "" || cbKategoriSepatu.SelectedValue == null || cbSupplier.SelectedValue == null)
                {
                    MessageBox.Show("Please FIll the data Correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string jenis = cbKategoriSepatu.SelectedValue.ToString();
                    string supplier = cbSupplier.SelectedValue.ToString();
                    string kategori = cbKategoriSepatu.SelectedValue.ToString();
                    string garansi = cmbGuaranty.SelectedValue.ToString();
                    int stock = int.Parse(txtStock.Text);
                    decimal harga1 = Convert.ToDecimal(txtHargaBeli.Text);
                    decimal harga2 = Convert.ToDecimal(txtHargaJual.Text);
                    MemoryStream stream = new MemoryStream();
                    pbGambar.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    con.Open();
                    SqlCommand update = new SqlCommand("sp_UpdateSepatu", con);
                    update.CommandType = CommandType.StoredProcedure;
                    update.Parameters.AddWithValue("id_sepatu", id);
                    update.Parameters.AddWithValue("id_kategori", kategori);
                    update.Parameters.AddWithValue("id_supplier", supplier);
                    update.Parameters.AddWithValue("id_garansi", garansi);
                    update.Parameters.AddWithValue("nama_sepatu", nama);
                    update.Parameters.AddWithValue("stock", stock);
                    update.Parameters.AddWithValue("harga_beli", harga1);
                    update.Parameters.AddWithValue("harga_jual", harga2);
                    update.Parameters.AddWithValue("gbr", pic);
                    try
                    {
                        update.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data Updated Successfully !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to update: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("Are You Sure delete data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand update = new SqlCommand("sp_DeleteSepatu", con);
                    update.CommandType = CommandType.StoredProcedure;
                    update.Parameters.AddWithValue("id_sepatu", ID);
                    try
                    {
                        update.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to delete " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Data failed to delete!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pbGambar.Image = Properties.Resources.noimage;
            cbKategoriSepatu.SelectedIndex = -1;
            cbSupplier.SelectedIndex = -1;
            txtNamaSepatu.Text = "";
            txtStock.Text = "";
            txtHargaJual.Text = "";
            txtHargaBeli.Text = "";
            btSave.Visible = false;
            btUpdate.Visible = true;
            btDelete.Visible = true;
            try
            {
                if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    ID = row.Cells[0].Value.ToString();
                    cbKategoriSepatu.Text = row.Cells[2].Value.ToString();
                    cbSupplier.Text = row.Cells[3].Value.ToString();
                    txtNamaSepatu.Text = row.Cells[1].Value.ToString();
                    txtStock.Text = row.Cells[5].Value.ToString();
                    cmbGuaranty.Text = row.Cells[4].Value.ToString();
                    txtHargaJual.Text = row.Cells[6].Value.ToString();
                    txtHargaBeli.Text = row.Cells[7].Value.ToString();
                    try
                    {
                        byte[] imgData = (byte[])row.Cells[8].Value;
                        MemoryStream ms = new MemoryStream(imgData);
                        pbGambar.Image = Image.FromStream(ms);
                    }catch(Exception ex)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Choose 1 Row Data !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btUploadGambar_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File(*.jpg; *.jpeg; *.png) |  *.jpg;*.jpeg; *.png";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        string Filename = openFileDialog.FileName;
                        if (myStream.Length > 512000)
                        {
                            MessageBox.Show("The file size is too big! Please select a file with a maximum size of 5 MB!");
                        }
                        else
                        {
                            pbGambar.Load(Filename);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btHapusGambar_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure to delete this data image?", "Delet Image", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                pbGambar.Image = Properties.Resources.noimage;
            }
            else
            {
                MessageBox.Show("Image undelete!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblKategoriSepatuTableAdapter.Fill(this.pRG2_KEL09DataSet1.tblKategoriSepatu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblKategoriSepatuTableAdapter.Fill(this.pRG2_KEL09DataSet1.tblKategoriSepatu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHargaBeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHargaJual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHargaBeli_TextChanged(object sender, EventArgs e)
        {
            if (txtHargaBeli.Text == "")
            {
                return;
            }
            else
            {
                beli = double.Parse(txtHargaBeli.Text);
            }
            txtHargaBeli.Text = string.Format("{0:n0}", double.Parse(txtHargaBeli.Text));
            txtHargaBeli.SelectionStart = txtHargaBeli.Text.Length;
        }

        private void txtHargaJual_TextChanged(object sender, EventArgs e)
        {
            if (txtHargaJual.Text == "")
            {
                return;
            }
            else
            {
                jual = double.Parse(txtHargaJual.Text);
            }
            txtHargaJual.Text = string.Format("{0:n0}", double.Parse(txtHargaJual.Text));
            txtHargaJual.SelectionStart = txtHargaJual.Text.Length;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            LoadData();
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tblKategoriSepatuTableAdapter.FillBy(this.pRG2_KEL09DataSet1.tblKategoriSepatu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.tblSupplierTableAdapter.FillBy(this.pRG2_KEL09DataSet1.tblSupplier);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
                this.tblGaransiTableAdapter.FillBy(this.pRG2_KEL09DataSet1.tblGaransi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Clear();    
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
                dataGridView1.Columns[1].HeaderCell.Value = "Category";
                dataGridView1.Columns[1].Width = 125;
                dataGridView1.Columns[2].HeaderCell.Value = "Merk";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].HeaderCell.Value = "Shoes Name";
                dataGridView1.Columns[3].Width = 125;
                dataGridView1.Columns[4].HeaderCell.Value = "Guaranty Type";
                dataGridView1.Columns[4].Width = 125;
                dataGridView1.Columns[5].HeaderCell.Value = "Stock";
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[6].HeaderCell.Value = "Selling Price";
                dataGridView1.Columns[6].Width = 200;
                dataGridView1.Columns[7].HeaderCell.Value = "Purchase Price";
                dataGridView1.Columns[7].Width = 200;
                dataGridView1.Columns[8].HeaderCell.Value = "Image";
                dataGridView1.Columns[8].Width = 100;
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
    }
}
