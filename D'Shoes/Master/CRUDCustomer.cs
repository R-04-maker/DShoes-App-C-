using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace D_Shoes.Master
{
    public partial class CRUDCustomer : Form
    {
        String ID;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);
        public CRUDCustomer()
        {
            InitializeComponent();
            
        }

        private static Regex email_validation()
        {
            string pattern = @"^[a-zA-Z0-9\w.]+[@]+[a-zA-Z0-9\w]+[.]+[a-zA-Z0-9\w]*$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        static Regex validate_emailaddress = email_validation();

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                IdOtomatis Id = new IdOtomatis();
                string sp = "sp_IdCustomer";
                Id.setID("CSR", sp);
                string ID = Id.getID();
                con.Close();
                string namaCus = tbName.Text;
                string phone = tbHp.Text;
                string alamat = tbAlamat.Text;
                string email = tbEmail.Text;
                if (namaCus == "" || phone == "" || alamat == "" || phone == "" || email == "")
                {
                    MessageBox.Show("Please, enter the data correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (phone.Length > 13 || phone.Length < 8)
                {
                    MessageBox.Show("Invalid Phone Number Length!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbHp.Text = "";
                    tbHp.Focus();
                }
                else if (validate_emailaddress.IsMatch(tbEmail.Text) != true)
                {
                    MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbEmail.Text = "";
                    tbEmail.Focus();
                }
                else
                {
                    SqlCommand insert = new SqlCommand("sp_InsertCustomer", con);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("Id_customer", ID);
                    insert.Parameters.AddWithValue("nama", namaCus);
                    insert.Parameters.AddWithValue("no_hp", phone);
                    insert.Parameters.AddWithValue("alamat", alamat);
                    insert.Parameters.AddWithValue("email", email);
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
        public void LoadData()
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                tbName.Text = "";
                tbHp.Text = "";
                tbAlamat.Text = "";
                tbEmail.Text = "";
                btSave.Visible = true;
                btUpdate.Visible = false;
                btDelete.Visible = false;
                try
                {
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_LoadCustomerNonMember", con);
                    view.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    DataGridView1.DataSource = bindingSource1;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                DataGridView1.Columns[0].HeaderCell.Value = "Customer ID";
                DataGridView1.Columns[1].HeaderCell.Value = "Customer Name";
                DataGridView1.Columns[2].HeaderCell.Value = "Phone Number";
                DataGridView1.Columns[3].HeaderCell.Value = "Address";
                DataGridView1.Columns[4].HeaderCell.Value = "Email";
                DataGridView1.Columns[0].Width = 125;
                DataGridView1.Columns[1].Width = 300;
                DataGridView1.Columns[2].Width = 200;
                DataGridView1.Columns[3].Width = 200;
                DataGridView1.Columns[4].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void CRUDCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btSave.Visible = false;
            btUpdate.Visible = true;
            btDelete.Visible = true;
            if (DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.DataGridView1.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                tbHp.Text = row.Cells[2].Value.ToString();
                tbAlamat.Text = row.Cells[3].Value.ToString();
                tbEmail.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ID;
                string namaCus = tbName.Text;
                string phone = tbHp.Text;
                string alamat = tbAlamat.Text;
                string email = tbEmail.Text;
                if (validate_emailaddress.IsMatch(tbEmail.Text) != true)
                {
                    MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbEmail.Text = "";
                    tbEmail.Focus();
                }
                else if (phone.Length > 13 || phone.Length < 8)
                {
                    MessageBox.Show("Invalid Phone Number Length!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbHp.Text = "";
                    tbHp.Focus();
                }
                else if (namaCus == "" || phone == "" || alamat == "" || phone == "" || email == "")
                {
                    MessageBox.Show("Please, enter the data correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    SqlCommand update = new SqlCommand("sp_UpdateCustomerNonMember", con);
                    update.CommandType = CommandType.StoredProcedure;
                    update.Parameters.AddWithValue("Id_customer", ID);
                    update.Parameters.AddWithValue("nama", namaCus);
                    update.Parameters.AddWithValue("no_hp", phone);
                    update.Parameters.AddWithValue("alamat", alamat);
                    update.Parameters.AddWithValue("email", email);
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

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Sure Delete this Data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                con.Open();
                SqlCommand update = new SqlCommand("sp_DeleteCustomerNonMember", con);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("id_customer", ID);
                try
                {
                    update.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Canceled delete data!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void caribtn_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            string cari = tbSearch.Text;

                try
                {
                    con.Open();
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariCustomer", con);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("nama_customer", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    DataGridView1.DataSource = bindingSource1;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                DataGridView1.Columns[0].HeaderCell.Value = "Customer ID";
                DataGridView1.Columns[1].HeaderCell.Value = "Customer Name";
                DataGridView1.Columns[2].HeaderCell.Value = "Phone Number";
                DataGridView1.Columns[3].HeaderCell.Value = "Address";
                DataGridView1.Columns[4].HeaderCell.Value = "Email";
                DataGridView1.Columns[0].Width = 125;
                DataGridView1.Columns[1].Width = 300;
                DataGridView1.Columns[2].Width = 200;
                DataGridView1.Columns[3].Width = 200;
                DataGridView1.Columns[4].Width = 200;
            }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            LoadData();
            tbName.Text = "";
            tbSearch.Text = "";
            tbHp.Text = "";
            tbAlamat.Text = "";
            tbEmail.Text = "";
            btSave.Visible = true;
            btDelete.Visible = false;
            btUpdate.Visible = false;
        }

        private void tbHp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    
}
