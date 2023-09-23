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
using System.Text.RegularExpressions;

namespace D_Shoes.Master
{
    public partial class CRUDPegawai : Form
    {
        string ID;
        string jk = "";
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);
        public CRUDPegawai()
        {
            InitializeComponent();
        }


        private void CRUDPegawai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRG2_KEL09DataSet1.tblJabatan' table. You can move, or remove it, as needed.
            this.tblJabatanTableAdapter.FillBy(this.pRG2_KEL09DataSet1.tblJabatan);
            LoadData();
            btUpdate.Visible = false;
            btDelete.Visible = false;
            btSave.Visible = true;
        }

        void LoadData()
        {
                BindingSource bindingSource1 = new BindingSource();
                try
                {
                    con.Close();
                    cmbJabatan.SelectedIndex = -1;
                    tbEmployeeName.Text = "";
                    cmbJabatan.SelectedValue = "";
                    tbNIK.Text = "";
                    jk = "";
                    tbPhoneNumber.Text = "";
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                    cmbStatus.SelectedValue = "";
                    cmbDate.Value = DateTime.Now;
                    con.Open();
                    try
                    {
                    
                        DataTable st = new DataTable();
                        SqlCommand view = new SqlCommand("sp_LoadPegawai", con);
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
                    dataGridView1.Columns[0].HeaderCell.Value = "Employee ID";
                    dataGridView1.Columns[1].HeaderCell.Value = "Employee Name";
                    dataGridView1.Columns[2].HeaderCell.Value = "Role";
                    dataGridView1.Columns[3].HeaderCell.Value = "NIK";
                    dataGridView1.Columns[4].HeaderCell.Value = "Date of Birth";
                    dataGridView1.Columns[5].HeaderCell.Value = "Gender";
                    dataGridView1.Columns[6].HeaderCell.Value = "Phone Number";
                    dataGridView1.Columns[7].HeaderCell.Value = "Username";
                    dataGridView1.Columns[8].HeaderCell.Value = "Password";
                    dataGridView1.Columns[9].HeaderCell.Value = "Status";
                    dataGridView1.Columns[0].Width = 150;
                    dataGridView1.Columns[1].Width = 150;
                    dataGridView1.Columns[2].Width = 175;
                    dataGridView1.Columns[3].Width = 170;
                    dataGridView1.Columns[4].Width = 150;
                    dataGridView1.Columns[5].Width = 150;
                    dataGridView1.Columns[6].Width = 150;
                    dataGridView1.Columns[7].Width = 150;
                    dataGridView1.Columns[8].Width = 150;
                    dataGridView1.Columns[9].Width = 150;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
        }

        private void btSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                IdOtomatis Id = new IdOtomatis();
                string sp = "sp_IdPegawai";
                Id.setID("PGI", sp);
                string ID = Id.getID();
                string NamaEmp = tbEmployeeName.Text;
                string NIK = tbNIK.Text;
                string phone = tbPhoneNumber.Text;
                string usr = tbUsername.Text;
                string pw = tbPassword.Text;
                string date = cmbDate.Value.ToString("yyyy/MM/dd");
                DateTime ttl = DateTime.Parse(cmbDate.Value.ToString());
                DateTime datnow = DateTime.Today;
                if (rbLaki.Checked)
                {
                    jk = rbLaki.Text;
                }
                else
                {
                    jk = rbPerempuan.Text;
                }
                try
                {
                    con.Open();
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CekUsername", con);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("username", tbUsername.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    if (st.Rows.Count != 0)
                    {
                        MessageBox.Show("The username is no longer available !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (NamaEmp == "" || cmbJabatan.Text == "" || jk == "" || tbPhoneNumber.Text == "" || tbUsername.Text == "" || tbPassword.Text == "" || cmbStatus.Text == "")
                    {
                        MessageBox.Show("Please, enter the data correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ttl >= datnow)
                    {
                        MessageBox.Show("Sorry, wrong date of birth", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (phone.Length > 13 || phone.Length < 8)
                    {
                        MessageBox.Show("Length of the phone number must be 8 - 13 digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbPhoneNumber.Text = "";
                        tbPhoneNumber.Focus();
                    }
                    else if (NIK.Length != 16)
                    {
                        MessageBox.Show("NIK must consist of 16 digit numbers!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbNIK.Text = "";
                        tbNIK.Focus();
                    }
                    else
                    {
                        con.Close();
                        SqlCommand insert = new SqlCommand("sp_InsertPegawai", con);
                        insert.CommandType = CommandType.StoredProcedure;
                        insert.Parameters.AddWithValue("Id_pegawai", ID);
                        insert.Parameters.AddWithValue("Id_jabatan", cmbJabatan.SelectedValue);
                        insert.Parameters.AddWithValue("Nama_pegawai", NamaEmp);
                        insert.Parameters.AddWithValue("NIK", Convert.ToInt64(NIK));
                        insert.Parameters.AddWithValue("TTL", date);
                        insert.Parameters.AddWithValue("Jenis_kelamin", jk);
                        insert.Parameters.AddWithValue("No_telp", phone);
                        insert.Parameters.AddWithValue("Username", usr);
                        insert.Parameters.AddWithValue("Password", pw);
                        insert.Parameters.AddWithValue("Status", cmbStatus.SelectedIndex);
                        con.Open();
                        insert.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data saved successfully with ID " + ID, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ID;
                string NamaEmp = tbEmployeeName.Text;
                string date = cmbDate.Value.ToString("yyyy/MM/dd");
                string phone = tbPhoneNumber.Text;
                string NIK = tbNIK.Text;
                if (rbLaki.Checked)
                {
                    jk = rbLaki.Text;
                }
                else
                {
                    jk = rbPerempuan.Text;
                }
                DateTime ttl = DateTime.Parse(cmbDate.Value.ToString());
                DateTime datnow = DateTime.Today;

                con.Open();
                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("sp_CekUsername", con);
                view.CommandType = CommandType.StoredProcedure;
                view.Parameters.AddWithValue("username", tbUsername.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(view);
                adapter.Fill(st);
                if (NamaEmp == "" || cmbJabatan.Text == "" || tbNIK.Text == "" || date == "" || jk == "" || tbPhoneNumber.Text == "" 
                    || tbUsername.Text == "" || cmbStatus.Text == "")
                {
                    MessageBox.Show("Please, enter the data correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (phone.Length > 13 || phone.Length < 8)
                {
                    MessageBox.Show("Length of the phone number must be 8 - 13 digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbPhoneNumber.Text = "";
                    tbPhoneNumber.Focus();
                }
                else if (NIK.Length != 16)
                {
                    MessageBox.Show("NIK must consist of 16 digit numbers!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbNIK.Text = "";
                    tbNIK.Focus();
                }
                else if (ttl > datnow)
                {
                    MessageBox.Show("Sorry, wrong date of birth", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    con.Close();
                    SqlCommand update = new SqlCommand("sp_UpdatePegawai", con);
                    update.CommandType = CommandType.StoredProcedure;
                    update.Parameters.AddWithValue("Id_pegawai", ID);
                    update.Parameters.AddWithValue("Id_jabatan", cmbJabatan.SelectedValue);
                    update.Parameters.AddWithValue("Nama_pegawai", tbEmployeeName.Text);
                    update.Parameters.AddWithValue("NIK", tbNIK.Text);
                    update.Parameters.AddWithValue("TTL", date);
                    update.Parameters.AddWithValue("Jenis_kelamin", jk);
                    update.Parameters.AddWithValue("No_telp", tbPhoneNumber.Text);
                    update.Parameters.AddWithValue("Username", tbUsername.Text);
                    update.Parameters.AddWithValue("Password",tbPassword.Text);
                    update.Parameters.AddWithValue("Status", cmbStatus.SelectedIndex);
                    try
                    {
                        con.Open();
                        update.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to update " + ex.Message);
                    }
                    MessageBox.Show("Data updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    btUpdate.Visible = false;
                    btDelete.Visible = false;
                    btSave.Visible = true;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Sure delete this data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                con.Open();
                SqlCommand delete = new SqlCommand("sp_DeletePegawai", con);
                delete.CommandType = CommandType.StoredProcedure;
                delete.Parameters.AddWithValue("Id_pegawai", ID);
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
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btSave.Visible = false;
                btUpdate.Visible = true;
                btDelete.Visible = true;
                if (dataGridView1.SelectedRows.Count >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    ID = row.Cells[0].Value.ToString();
                    cmbJabatan.Text = row.Cells[2].Value.ToString();
                    tbEmployeeName.Text = row.Cells[1].Value.ToString();
                    tbNIK.Text = row.Cells[3].Value.ToString();
                    cmbDate.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());
                    jk = row.Cells[5].Value.ToString();
                    if (jk == "Male")
                    {
                        rbLaki.Checked = true;
                    }
                    else if (jk == "Female")
                    {
                        rbPerempuan.Checked = true;
                    }
                    tbPhoneNumber.Text = row.Cells[6].Value.ToString();
                    tbUsername.Text = row.Cells[7].Value.ToString();
                    tbPassword.Text = row.Cells[8].Value.ToString();
                    cmbStatus.Text = row.Cells[9].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void tbPassword_OnValueChanged(object sender, EventArgs e)
        {
            tbPassword.isPassword = true;
        }

        private void caribtn_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            string cari = txtSearch.Text;
            try
            {
                con.Open();
                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("sp_CariPegawai", con);
                view.CommandType = CommandType.StoredProcedure;
                view.Parameters.AddWithValue("nama_pegawai", cari);
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
            dataGridView1.Columns[0].HeaderCell.Value = "Employee ID";
            dataGridView1.Columns[1].HeaderCell.Value = "Employee Name";
            dataGridView1.Columns[2].HeaderCell.Value = "Role";
            dataGridView1.Columns[3].HeaderCell.Value = "NIK";
            dataGridView1.Columns[4].HeaderCell.Value = "Date of Birth";
            dataGridView1.Columns[5].HeaderCell.Value = "Gender";
            dataGridView1.Columns[6].HeaderCell.Value = "Phone Number";
            dataGridView1.Columns[7].HeaderCell.Value = "Username";
            dataGridView1.Columns[8].HeaderCell.Value = "Password"; 
            dataGridView1.Columns[9].HeaderCell.Value = "Status";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 175;
            dataGridView1.Columns[3].Width = 170;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.Columns[6].Width = 150;
            dataGridView1.Columns[7].Width = 150;
            dataGridView1.Columns[8].Width = 150;
            dataGridView1.Columns[9].Width = 150;
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
            txtSearch.Text = "";
            tbEmployeeName.Text = "";
            tbEmployeeName.Text = "";
            tbNIK.Text = "";
            cmbDate.ResetText();
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;
            tbPhoneNumber.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
            cmbStatus.Text = "";
            tbPassword.Enabled = true;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblJabatanTableAdapter.Fill(this.pRG2_KEL09DataSet1.tblJabatan);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tbNIK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbPhoneNumber.Text, @"^[0-9]{13}"))
            {
                MessageBox.Show("Max Length for Phone Number is 13 digit", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbPhoneNumber.Text = "";
            }
        }

        private void tbNIK_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbNIK.Text, @"^[0-9]{16}"))
            {
                MessageBox.Show("Max Length for NIK is 16 digit", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNIK.Text = "";
                tbNIK.Focus();
            }
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tblJabatanTableAdapter.FillBy(this.pRG2_KEL09DataSet1.tblJabatan);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void tbNIK_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPhoneNumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 8 && e.Value != null)
            {
                e.Value = new string('*',e.Value.ToString().Length);
            }
        }

    }
}
