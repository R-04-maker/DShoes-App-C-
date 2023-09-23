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
    public partial class TransaksiJual : Form
    {
        string id;
        double beli, jual;
        int i;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);
        public TransaksiJual()
        {
            InitializeComponent();
        }

        private void TransaksiJual_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRG2_KEL09DataSet11.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.FillBy(this.pRG2_KEL09DataSet11.tblCustomer);

            // TODO: This line of code loads data into the 'pRG2_KEL09DataSet1.tblJenisPembayaran' table. You can move, or remove it, as needed.
            this.tblJenisPembayaranTableAdapter.FillBy(this.pRG2_KEL09DataSet1.tblJenisPembayaran);
            // TODO: This line of code loads data into the 'pRG2_KEL09DataSet1.tblSepatu' table. You can move, or remove it, as needed.
            this.tblSepatuTableAdapter.FillBy(this.pRG2_KEL09DataSet1.tblSepatu);
            Visible();
            Clear();
        }

        private void cbShoesName_SelectionChangeCommitted(object sender, EventArgs e)
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
                    string cari = cbShoesName.SelectedValue.ToString();
                    DataTable st = new DataTable();
                    SqlCommand search = new SqlCommand("sp_CariItem", con);
                    search.CommandType = CommandType.StoredProcedure;
                    search.Parameters.AddWithValue("id_sepatu", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(search);
                    adapter.Fill(st);
                    txtPrice.Text = string.Format("{0:n0}", double.Parse(st.Rows[0][6].ToString()));
                    txtStock.Text = (st.Rows[0][5].ToString());
                    txtGuarantyDesc.Text = st.Rows[0][4].ToString();
                    byte[] imgData = (byte[])st.Rows[0][8];
                    MemoryStream ms = new MemoryStream(imgData);
                    pbImage.Image = Image.FromStream(ms);
                    if(txtStock.Text == "0")
                    {
                        MessageBox.Show("out of stock shoes !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btCancelAdd_Click(object sender, EventArgs e)
        {
            Clear();
            dataGridView1.Rows.Clear();
            btCo.Text = "Checkout (0)";

        }
        public void Clear()
        {
            pbImage.Image = Properties.Resources.noimage;
            cbShoesName.Text = null;
            txtPrice.Text = null;
            txtStock.Text = null;
            txtQty.Text = null;
            txtGuarantyDesc.Text = null;
            pbImage.Image = Properties.Resources.noimage;
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
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    data = row.Cells[0].Value.ToString();
                    if (cbShoesName.SelectedValue.ToString().Equals(data))
                    {
                        MessageBox.Show("Data has been added !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if(txtQty.Text == "" || txtQty.Text == "0")
                {
                    MessageBox.Show("Fill in the quantity of Shoe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int qty = Convert.ToInt32(txtQty.Text);
                    int stock = Convert.ToInt32(txtStock.Text);
                    if ( qty > stock || qty == stock)
                    {
                        MessageBox.Show("Shoe stock is not enough!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            DataTable dt = new DataTable();
                            dt = (DataTable)dataGridView1.DataSource;
                            string id = cbShoesName.SelectedValue.ToString();
                            string nama = cbShoesName.Text;
                            string harga = txtPrice.Text;
                            string kuantitas = txtQty.Text;
                            double SubTotal = (Convert.ToDouble(harga)) * (Convert.ToDouble(kuantitas));
                            string sub =  string.Format("{0:n0}", double.Parse(SubTotal.ToString()));
                            string[] row = { id, nama, harga.ToString(),stock.ToString(),kuantitas, sub };
                            dataGridView1.Rows.Add(row);
                            i = i + 1;
                            btCo.Text = "Checkout (" + i + ")";
                            foreach (DataGridViewRow rows in dataGridView1.Rows)
                            {
                                double HT1 = Convert.ToDouble(rows.Cells[2].Value.ToString());
                                Hartot = Hartot + HT1;
                            }
                            lblSubTotal.Text = "SUBTOTAL : Rp. " + string.Format("{0:n0}", Double.Parse(Hartot.ToString()));
                            Clear();
                        } catch(Exception ex)
                        {
                            MessageBox.Show(""+ex);
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btCo.Enabled)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                int kuantitas = Convert.ToInt32(row.Cells[4].Value.ToString());
                int stok = Convert.ToInt32(row.Cells[3].Value.ToString());
                double hrg = Convert.ToDouble(row.Cells[2].Value.ToString());
                double HA;
                double HT2 = 0.0;
                string colname = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colname == "tambah")
                {
                    if ( (stok-kuantitas) == 1)
                    {
                        MessageBox.Show("Purchase exceeds stock quantity!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        kuantitas = kuantitas + 1;
                        if (row.Cells[3].Value.ToString() == "1")
                        {
                            MessageBox.Show("Out of shoe stock!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            HA = hrg * kuantitas;
                            row.Cells[4].Value = kuantitas;
                            row.Cells[5].Value = HA;
                        }
                    }
                }
                else if (colname == "kurang")
                {
                    kuantitas = kuantitas - 1;
                    if (kuantitas == 0)
                    {
                        DialogResult d;
                        d = MessageBox.Show("Delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (d == DialogResult.Yes)
                        {
                            dataGridView1.Rows.Remove(row);
                            i--;
                            btCo.Text = "Checkout (" + i + ")";
                        }
                        else
                        {
                            kuantitas = 1;
                        }
                    }
                    else
                    {
                        HA = hrg * kuantitas;
                        row.Cells[4].Value = kuantitas;
                        row.Cells[5].Value = HA;
                    }
                }
                dataGridView1.Columns[2].DefaultCellStyle.Format = "###,##0";
                dataGridView1.Columns[5].DefaultCellStyle.Format = "###,##0";
                foreach (DataGridViewRow rows in dataGridView1.Rows)
                {
                    double HT1 = Convert.ToDouble(rows.Cells[5].Value.ToString());
                    HT2 = HT2 + HT1;
                }
                lblSubTotal.Text = "SUBTOTAL : Rp. " + string.Format("{0:n0}", HT2);
            }
            else
            {
                return;
            }
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
                        double HT1 = Convert.ToDouble(row.Cells[5].Value.ToString());
                        HT2 = HT2 + HT1;
                    }
                    txtTotal.Text = string.Format("{0:n0}", Double.Parse(HT2.ToString()));
                    txtakhir.Text = string.Format("{0:n0}", Double.Parse(HT2.ToString()));
                    Clear();
                    rbNo.Checked = true;
                }
                else
                {
                    
                }
            }
        }

        private void txtSearchMemberId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand search = new SqlCommand("sp_CariMemberIDTrs", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(search);
                    search.CommandType = CommandType.StoredProcedure;
                    search.Parameters.AddWithValue("id_member", txtSearchMemberId.Text);
                    adapter.Fill(dt);
                    if(dt.Rows.Count != 0)
                    {
                        if (DateTime.Parse(dt.Rows[0][3].ToString()) < DateTime.Today)
                        {
                            MessageBox.Show("Member has expired since " + DateTime.Parse(dt.Rows[0][3].ToString()).ToShortDateString() + "!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtSearchMemberId.Text = "";
                        }
                        else
                        {
                            txtIdCust.Text = dt.Rows[0][1].ToString();
                            txtCustName.Text = dt.Rows[0][2].ToString();
                            double discount = Convert.ToDouble(dt.Rows[0][4].ToString());
                            double hargaItem = Convert.ToDouble(txtTotal.Text);
                            double ItemDisc = (hargaItem * (discount/100));
                            double Total = hargaItem - ItemDisc;
                            txtdiskonmem.Text = string.Format("{0:n0}", ItemDisc);
                            txtakhir.Text = string.Format("{0:n0}", Total);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID Member not found!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSearchMemberId.Text = "-- Member ID -- ";
                        rbYes.Checked = false;
                        rbNo.Checked = true;
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to Search Data ! \n Please Check Customer Data !" + ex);
                }
            }
        }

        private void cbSearchCustName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand search = new SqlCommand("sp_FillComboBoxCustomerTrs", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(search);
                    search.CommandType = CommandType.StoredProcedure;
                    search.Parameters.AddWithValue("nama", cbSearchCustName.Text);
                    adapter.Fill(dt);
                    cbSearchCustName.DataSource = dt;
                    cbSearchCustName.DisplayMember = "nama";
                    cbSearchCustName.ValueMember = "id_customer";
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void cbSearchCustName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string A = cbSearchCustName.SelectedText.ToString();
                txtCustName.Text = A;
                txtIdCust.Text = cbSearchCustName.SelectedValue.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double uang = 0;
            double total = 0;
            if (txtuang.Text == "")
            {
                txtuangkembali.Text = "0";
                return;
            }
            else if (uang < total)
            {
                MessageBox.Show("Input money is not enough!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    txtuang.Text = string.Format("{0:n0}", double.Parse(txtuang.Text));
                    txtuang.SelectionStart = txtuang.Text.Length;
                    uang = Convert.ToDouble(txtuang.Text);
                    total = Convert.ToDouble(txtakhir.Text);
                    double kembali = (uang - total);
                    txtuangkembali.Text = kembali.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtuangkembali_TextChanged(object sender, EventArgs e)
        {
            txtuangkembali.Text = string.Format("{0:n0}", double.Parse(txtuangkembali.Text));
        }

        private void cbShoesName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand search = new SqlCommand("sp_FillComboBox", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(search);
                    search.CommandType = CommandType.StoredProcedure;
                    search.Parameters.AddWithValue("nama_sepatu", cbShoesName.Text) ;
                    adapter.Fill(dt);
                    DataRow row = dt.NewRow();
                    //row[0] = 0;
                    row[1] = 0;
                    //dt.Rows.InsertAt(row, 0);
                    cbShoesName.DataSource = dt;
                    cbShoesName.DisplayMember = "nama_sepatu";
                    cbShoesName.ValueMember = "id_sepatu";
                    cbShoesName.Text = "";
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                } 
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbYes.Checked && txtSearchMemberId.Text == "" || rbNo.Checked && txtCustName.Text == "")
                {
                    MessageBox.Show("Fill the data correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(txtuang.Text == "")
                    {
                        MessageBox.Show("Enter money correctly !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        double uang = Convert.ToDouble(txtuang.Text);
                        double hargatotal = Convert.ToDouble(txtakhir.Text);
                        if(uang < hargatotal)
                        {
                            MessageBox.Show("Not enough money!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            IdOtomatis a = new IdOtomatis();
                            string sp = "sp_IdTrsJual";
                            a.setID("TRS", sp);
                            id = a.getID();
                            con.Close();
                            //Insert ke tabel transaski Customer
                            double disc = Convert.ToDouble(txtdiskonmem.Text);
                            double hartot = Convert.ToDouble(txtakhir.Text);
                            DateTime date = DateTime.Now;
                            string idcust = txtIdCust.Text;
                            string jnspembayaran = cmbMethodPayment.SelectedValue.ToString();
                            //insert ke table transaksi penjualan
                            SqlCommand insert = new SqlCommand("sp_InsertTrsJual",con);
                            insert.CommandType = CommandType.StoredProcedure;
                            insert.Parameters.AddWithValue("id_trs", id);
                            insert.Parameters.AddWithValue("id_customer",idcust);
                            insert.Parameters.AddWithValue("tgl_transaksi", date);
                            insert.Parameters.AddWithValue("diskon", disc);
                            insert.Parameters.AddWithValue("total_harga", hartot);
                            insert.Parameters.AddWithValue("id_jnsPemb", jnspembayaran);
                            con.Open();
                            insert.ExecuteNonQuery();
                            con.Close();
                            foreach(DataGridViewRow row in dataGridView1.Rows)
                            {
                                string shoesID = row.Cells["id_sepatu"].Value.ToString();
                                int qty = Convert.ToInt32(row.Cells["kuantitas"].Value);
                                //insert detil + update stock
                                SqlCommand updateStock = new SqlCommand("sp_UpdateShoeStock", con);
                                updateStock.CommandType = CommandType.StoredProcedure;
                                updateStock.Parameters.AddWithValue("idTrs",id);
                                updateStock.Parameters.AddWithValue("id_sepatu",shoesID);
                                updateStock.Parameters.AddWithValue("qty",qty);
                                updateStock.Parameters.AddWithValue("statusGaransi",2);
                                try
                                {
                                    con.Open();
                                    updateStock.ExecuteNonQuery();
                                }catch(Exception ex)
                                {
                                    MessageBox.Show("Failed to update and insert shoe transaction:" + ex.Message);
                                }
                                con.Close();
                            }
                            MessageBox.Show("Data saved successfully with ID " + id, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            i = 0;
                            Canceled();
                            dataGridView1.Rows.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to saved Shoe Stock : " + ex);
            }
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            if(rbYes.Checked)
            {
                txtSearchMemberId.Visible = true;
                cbSearchCustName.Visible = false;
            }
            else
            {
                return;
            }
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNo.Checked)
            {
                cbSearchCustName.Visible = true;
                txtSearchMemberId.Visible = false;
            }
            else
            {
                return;
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblJenisPembayaranTableAdapter.FillBy(this.pRG2_KEL09DataSet1.tblJenisPembayaran);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchMemberId_Enter(object sender, EventArgs e)
        {
            if (txtSearchMemberId.Text == "-- Member ID --") txtSearchMemberId.Text = "";
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtuang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtuangkembali_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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
            btAdd.Enabled = true;
            btCo.Enabled = true;
            btAdd.Enabled = true;
            btCancelAdd.Enabled = true;
            Visible();
            Clear();
            pbImage.Image = Properties.Resources.noimage;
            dataGridView1.Rows.Clear();
            lblSubTotal.Text = "SUBTOTAL : Rp. 0";
            btCo.Text = "Checkout (0)";
            txtSearchMemberId.Text = "-- Member ID --";
            cbSearchCustName.Text = "          -- Customer Name --";
            rbYes.Checked = false;
            rbNo.Checked = true;
            txtIdCust.Text = null;
            txtCustName.Text = null;
            txtTotal.Text = "0";
            txtdiskonmem.Text = "0";
            txtakhir.Text = "0";
            txtuang.Text = null;
            txtuangkembali.Text = "0";
            cmbMethodPayment.SelectedIndex = 0;
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tblSepatuTableAdapter.FillBy(this.pRG2_KEL09DataSet1.tblSepatu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cbSearchCustName_Enter(object sender, EventArgs e)
        {
            if (txtSearchMemberId.Text == "          -- Customer Name --") txtSearchMemberId.Text = "";
        }

        public void Visible()
        {
            pbImage.Image = Properties.Resources.noimage;
            panelDetail.Visible = false;
            txtIdCust.Enabled = false;
            txtCustName.Enabled = false;
        }
    }
}
