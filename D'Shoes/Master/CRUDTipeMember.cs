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
    public partial class CRUDTipeMember : Form
    {
        String ID;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);
        public CRUDTipeMember()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                IdOtomatis Id = new IdOtomatis();
                string sp = "sp_IdTipeMem";
                Id.setID("JMB", sp);
                string id = Id.getID();
                string jenis = txtMemberType.Text;
                if (jenis == "" || txtValidty.Text == "" || txtDiscount.Text == "" || txtPrice.Text == "")
                {
                    MessageBox.Show("Please, enter the data correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int valperiod = Convert.ToInt32(txtValidty.Text);
                    int discount = Convert.ToInt32(txtDiscount.Text);
                    decimal price = Convert.ToDecimal(txtPrice.Text);
                    SqlCommand insert = new SqlCommand("sp_InsertTipeMember", con);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("id_member", id);
                    insert.Parameters.AddWithValue("jenis_member", jenis);
                    insert.Parameters.AddWithValue("diskon", discount);
                    insert.Parameters.AddWithValue("masa_berlaku", valperiod);
                    insert.Parameters.AddWithValue("harga_member", price);
                    insert.Parameters.AddWithValue("status", 1);
                    con.Open();
                    insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data saved successfully with ID " + id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    Clear();
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
                btUpdate.Visible = false;
                btDelete.Visible = false;
                btSave.Visible = true;
                con.Open();
                try
                {
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_LoadTipeMember", con);
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
                dataGridView1.Columns[1].HeaderCell.Value = "Member Type";
                dataGridView1.Columns[2].HeaderCell.Value = "Discount (%)";
                dataGridView1.Columns[3].HeaderCell.Value = "Validity(day)";
                dataGridView1.Columns[4].HeaderCell.Value = "Member Price";
                dataGridView1.Columns[2].DefaultCellStyle.Format = " #\\%";
                dataGridView1.Columns[3].DefaultCellStyle.Format = " ### day";
                dataGridView1.Columns[4].DefaultCellStyle.Format = "Rp ###,##0.00";

                dataGridView1.Columns[1].Width = 125;
                dataGridView1.Columns[2].Width = 125;
                dataGridView1.Columns[3].Width = 125;
                dataGridView1.Columns[4].Width = 125;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
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
                txtMemberType.Text = row.Cells[1].Value.ToString();
                txtDiscount.Text = row.Cells[2].Value.ToString();
                txtValidty.Text = row.Cells[3].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString();
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text == "")
            {
                return;
            }
            else
            {
                txtPrice.Text = string.Format("{0:n0}", double.Parse(txtPrice.Text));
                txtPrice.SelectionStart = txtPrice.Text.Length;
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Sure delete this data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                con.Open();
                SqlCommand delete = new SqlCommand("sp_DeleteTipeMember", con);
                delete.CommandType = CommandType.StoredProcedure;
                delete.Parameters.AddWithValue("id", ID);
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

        private void CRUDTipeMember_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ID;
                string jenis = txtMemberType.Text;
                if (jenis == "" || txtValidty.Text == "" || txtDiscount.Text == "" || txtPrice.Text == "")
                {
                    MessageBox.Show("Please, enter the data correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int expired = Convert.ToInt32(txtValidty.Text);
                    int discount = Convert.ToInt32(txtDiscount.Text);
                    decimal price = Convert.ToDecimal(txtPrice.Text);
                    con.Open();
                    SqlCommand update = new SqlCommand("sp_UpdateTipeMember", con);
                    update.CommandType = CommandType.StoredProcedure;
                    update.Parameters.AddWithValue("id", id);
                    update.Parameters.AddWithValue("jenis", jenis);
                    update.Parameters.AddWithValue("diskon", discount);
                    update.Parameters.AddWithValue("expired", expired);
                    update.Parameters.AddWithValue("harga", price);
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
            txtMemberType.Text = "";
            txtDiscount.Text = "";
            txtPrice.Text = "";
            txtValidty.Text = "";
        }

        private void txtValidty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
