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

namespace D_Shoes.Transaction
{
    public partial class TransaksiBeli : Form
    {
        string id,cari;
        int i;
        string idSup;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);
        public TransaksiBeli()
        {
            InitializeComponent();
        }

        private void TransaksiBeli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRG2_KEL09DataSet1.tblJenisPembayaran' table. You can move, or remove it, as needed.
            this.tblJenisPembayaranTableAdapter.FillBy(this.pRG2_KEL09DataSet1.tblJenisPembayaran);
            // TODO: This line of code loads data into the 'pRG2_KEL09DataSet1.tblSupplier' table. You can move, or remove it, as needed.
            this.tblSupplierTableAdapter.FillBy(this.pRG2_KEL09DataSet1.tblSupplier);
            panelDetail.Visible = false;
            pbImage.Image = Properties.Resources.noimage;

        }

        private void cbShoesName_SelectionChangeCommitted(object sender, EventArgs e)
        {
             try
            {
                if (cbSupplier.SelectedValue == null)
                {
                    return;
                }
                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    idSup = cbSupplier.SelectedValue.ToString();
                    DataTable dt = new DataTable();
                    SqlCommand search = new SqlCommand("sp_FillComboBoxShoesName", con);
                    search.CommandType = CommandType.StoredProcedure;
                    search.Parameters.AddWithValue("id_supplier", idSup);
                    SqlDataAdapter adapter = new SqlDataAdapter(search);
                    adapter.Fill(dt);
                    DataRow row = dt.NewRow();
                    cbShoesName.DataSource = dt;
                    cbShoesName.DisplayMember = "nama_sepatu";
                    cbShoesName.ValueMember = "id_sepatu";
                    cbSupplier.Enabled = false;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void cbShoesName_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            try
            {
                if (cbShoesName.SelectedValue == null)
                {
                    return;
                }
                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cari = cbShoesName.SelectedValue.ToString();
                    DataTable st = new DataTable();
                    SqlCommand search = new SqlCommand("sp_CariItem", con);
                    search.CommandType = CommandType.StoredProcedure;
                    search.Parameters.AddWithValue("id_sepatu", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(search);
                    adapter.Fill(st);
                    txtPrice.Text = string.Format("{0:n0}", double.Parse(st.Rows[0][7].ToString()));
                    txtStock.Text = (st.Rows[0][5].ToString());
                    txtMerk.Text = st.Rows[0][2].ToString();
                    byte[] imgData = (byte[])st.Rows[0][8];
                    MemoryStream ms = new MemoryStream(imgData);
                    pbImage.Image = Image.FromStream(ms);
                    con.Close();
                    if (txtStock.Text == "0")
                    {
                        MessageBox.Show("out of stock shoes !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            double Hartot = 0.0;
            if (cbShoesName.SelectedValue == null)
            {
                MessageBox.Show("Fill the data correctly !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string data = string.Empty;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    data = row.Cells[0].Value.ToString();
                    if (cbShoesName.SelectedValue.ToString().Equals(data))
                    {
                        MessageBox.Show("Data has been added !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (txtQty.Text == "" || txtQty.Text == "0")
                {
                    MessageBox.Show("Fill in the quantity of Shoe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int qty = Convert.ToInt32(txtQty.Text);
                    int stock = Convert.ToInt32(txtStock.Text);
                    try
                    {
                        DataTable dt = new DataTable();
                        dt = (DataTable)dataGridView1.DataSource;
                        string id = cbShoesName.SelectedValue.ToString();
                        string nama = cbShoesName.Text;
                        string harga = txtPrice.Text;
                        string kuantitas = txtQty.Text;
                        string merk = txtMerk.Text;
                        double SubTotal = (Convert.ToDouble(harga)) * (Convert.ToDouble(kuantitas));
                        string sub = string.Format("{0:n0}", double.Parse(SubTotal.ToString()));
                        string[] row = { id, nama, merk, harga.ToString(), stock.ToString(), kuantitas, sub };
                        dataGridView1.Rows.Add(row);
                        i = i + 1;
                        btCo.Text = "Item (" + i + ")";
                        foreach (DataGridViewRow rows in dataGridView1.Rows)
                        {
                            double HT1 = Convert.ToDouble(rows.Cells[6].Value.ToString());
                            Hartot = Hartot + HT1;
                        }
                        lblSubTotal.Text = "SUBTOTAL : Rp. " + string.Format("{0:n0}", Double.Parse(Hartot.ToString()));
                        cbShoesName.Text = null;
                        txtPrice.Text = null;
                        txtStock.Text = null;
                        txtQty.Text = null;
                        txtMerk.Text = null;
                        pbImage.Image = Properties.Resources.noimage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
            }
        }
        public void Clear()
        {
            cbShoesName.Text = null;
            txtPrice.Text = null;
            txtStock.Text = null;
            txtQty.Text = null;
            txtMerk.Text = null;
            cbSupplier.Text = null;
            pbImage.Image = Properties.Resources.noimage;
        }

        private void btCancelAdd_Click(object sender, EventArgs e)
        {
            cbSupplier.Enabled = true;
            Clear();
            dataGridView1.Rows.Clear();
            btCo.Text = "Item (0)";

        }

        private void btCo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cart still empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult d;
                double HT2 = 0.0;
                d = MessageBox.Show("Checkout this cart ?", "Checkout item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panelDetail.Visible = true;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        double HT1 = Convert.ToDouble(row.Cells[6].Value.ToString());
                        HT2 = HT2 + HT1;
                    }
                    txtTotal.Text = string.Format("{0:n0}", Double.Parse(HT2.ToString()));
                    txtakhir.Text = string.Format("{0:n0}", Double.Parse(HT2.ToString()));
                    Clear();
                }
                else
                {
                    return;
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btCo.Enabled)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                int kuantitas = Convert.ToInt32(row.Cells[5].Value.ToString());
                int stok = Convert.ToInt32(row.Cells[4].Value.ToString());
                double hrg = Convert.ToDouble(row.Cells[3].Value.ToString());
                double HA;
                double HT2 = 0.0;
                string colname = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colname == "tambah")
                {
                    kuantitas = kuantitas + 1;
                    if (row.Cells[3].Value.ToString() == "0")
                    {
                        MessageBox.Show("Out of shoe stock !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        HA = hrg * kuantitas;
                        row.Cells[5].Value = kuantitas;
                        row.Cells[6].Value = HA;
                    }
                }
                else if (colname == "kurang")
                {
                    kuantitas = kuantitas - 1;
                    if (kuantitas == 0)
                    {
                        DialogResult d;
                        d = MessageBox.Show("Delete this item?", "Delete item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (d == DialogResult.Yes)
                        {
                            dataGridView1.Rows.Remove(row);
                            i--;
                            btCo.Text = "Item (" + i + ")";
                        }
                        else
                        {
                            kuantitas = 1;
                        }
                    }
                    else
                    {
                        HA = hrg * kuantitas;
                        row.Cells[5].Value = kuantitas;
                        row.Cells[6].Value = HA;
                    }
                }
                dataGridView1.Columns[6].DefaultCellStyle.Format = "###,##0";
                foreach (DataGridViewRow rows in dataGridView1.Rows)
                {
                    double HT1 = Convert.ToDouble(rows.Cells[6].Value.ToString());
                    HT2 = HT2 + HT1;
                }
                lblSubTotal.Text = "SUBTOTAL : Rp. " + string.Format("{0:n0}", HT2);
            }
            else
            {
                return;
            }

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                IdOtomatis a = new IdOtomatis();
                string sp = "sp_IdTrsBeli";
                a.setID("TRSP", sp);
                id = a.getID(); 
                con.Close();
                //Insert ke tabel transaski Customer
                double hartot = Convert.ToDouble(txtakhir.Text);
                DateTime date = DateTime.Now;
                SqlCommand insert = new SqlCommand("sp_InsertTrsBeli", con);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("id_trs", id);
                insert.Parameters.AddWithValue("id_supplier", idSup);
                insert.Parameters.AddWithValue("tgl_transaksi", date);
                insert.Parameters.AddWithValue("total_harga", hartot);
                insert.Parameters.AddWithValue("status", 0);
                con.Open();
                insert.ExecuteNonQuery();
                con.Close();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string shoesID = row.Cells["id_sepatu"].Value.ToString();
                    int qty = Convert.ToInt32(row.Cells["kuantitas"].Value);
                    SqlCommand updateStock = new SqlCommand("sp_UpdateShoeStockPemb", con);
                    updateStock.CommandType = CommandType.StoredProcedure;
                    updateStock.Parameters.AddWithValue("idTrs", id);
                    updateStock.Parameters.AddWithValue("id_sepatu", shoesID);
                    updateStock.Parameters.AddWithValue("qty", qty);
                    updateStock.Parameters.AddWithValue("status", 0);
                    try
                    {
                        con.Open();
                        updateStock.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to update and insert shoe transaction:" + ex.Message);
                    }
                    con.Close();
                }
                MessageBox.Show("Data saved successfully with ID " + id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                i = 0;
                Canceled();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to saved Shoe Stock : " + ex);
            }

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("All transaction data will be lost. Cancel transaction?", "Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                Canceled();
            }
            else
            {
                return;
            }
        }

        public void Canceled()
        {
            panel1.Enabled = true;
            panel2.Enabled = true;
            Clear();
            dataGridView1.Rows.Clear();
            panelDetail.Visible = false;
            txtTotal.Text = "0";
            txtakhir.Text = "0";
        }


        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}