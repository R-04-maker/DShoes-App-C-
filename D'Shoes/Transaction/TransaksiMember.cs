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


namespace D_Shoes.Transaction
{
    public partial class TransaksiMember : Form
    {
        String ID;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);
        double uang;
        double harga;
        double kembali;
        string fee;
        decimal number;
        decimal number2;
        DateTime datenow;
        DateTime addedDateTime;
        int a;
        public TransaksiMember()
        {
            InitializeComponent();

        }

        private void TransaksiMember_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'pRG2_KEL09DataSet1.tblTipeMember' table. You can move, or remove it, as needed.
                this.tblTipeMemberTableAdapter.FillBy(this.pRG2_KEL09DataSet1.tblTipeMember);
                datenow = DateTime.Now;
                LoadDataGridView();
                this.tblCustomerTableAdapter.FillBy(this.pRG2_KEL09DataSet1.tblCustomer);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        
        public void LoadData()
        {

            tbCustomerID.Text = "";
            cbCustomerName.Text = "";
            cbMemberType.Text = "-- Choose Member Type --";
            tbExpired.Text = "";
            tbTotalPay.Text = "";
            tbPayment.Text = "";
            try
            {
                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("LoadDataCustomerToMemberForm", con);
                view.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(view);
                adapter.Fill(st);
                con.Open();
                tbCustomerID.Text = st.Rows[0][0].ToString();
                cbCustomerName.Text = st.Rows[0][1].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        public void LoadDataGridView()
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("sp_LoadDataMember", con);
                view.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(view);
                adapter.Fill(st);
                bindingSource1.DataSource = st;
                dataGridView1.DataSource = bindingSource1;

                //MessageBox.Show("Customer ID not a member");
                con.Close();
                dataGridView1.Columns[0].HeaderCell.Value = "Member ID";
                dataGridView1.Columns[1].HeaderCell.Value = "ID Cust";
                dataGridView1.Columns[2].HeaderCell.Value = "Name";
                dataGridView1.Columns[3].HeaderCell.Value = "Member Type";
                dataGridView1.Columns[4].HeaderCell.Value = "Expired Date";
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void cbMemberType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMemberType.SelectedValue != null)
            {
                string masaberlaku;
                try
                {
                    con.Open();
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_masaberlaku", con);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("id", cbMemberType.SelectedValue.ToString());
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    masaberlaku = st.Rows[0][0].ToString();
                    addedDateTime = DateTime.Now.AddDays(Convert.ToInt32(masaberlaku));
                    tbExpired.Text = addedDateTime.ToShortDateString();
                    tbTotalPay.Text = string.Format("{0:n0}", Double.Parse(st.Rows[0][1].ToString()));
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblTipeMemberTableAdapter.FillBy(this.pRG2_KEL09DataSet1.tblTipeMember);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tbPayment_TextChanged(object sender, EventArgs e)
        {
            double uang = 0;
            double total = 0;
            if (tbPayment.Text == "")
            {
                tbKembalian.Text = "0";
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
                    tbPayment.Text = string.Format("{0:n0}", double.Parse(tbPayment.Text));
                    tbPayment.SelectionStart = tbPayment.Text.Length;
                    uang = Convert.ToDouble(tbPayment.Text);
                    total = Convert.ToDouble(tbTotalPay.Text);
                    double kembali = (uang - total);
                    tbKembalian.Text = kembali.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            tbCustomerID.Text = "";
            cbCustomerName.Text = "";
            cbMemberType.Text = "-- Choose Member Type --";
            tbExpired.Text = "";
            tbTotalPay.Text = "";
            tbPayment.Text = "";
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbPayment.Text == "")
                {
                    MessageBox.Show("Please enter the money correctly!!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbPayment.Focus();
                }
                else
                {
                    double uang = Convert.ToDouble(tbPayment.Text);
                    double hargatotal = Convert.ToDouble(tbTotalPay.Text);
                    if (uang < hargatotal)
                    {
                        MessageBox.Show("Less amount of money!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        IdOtomatis Id = new IdOtomatis();
                        string sp = "sp_IdMember";
                        Id.setID("MB", sp);
                        string ID = Id.getID();
                        string CustId = tbCustomerID.Text;
                        string MemberType = cbMemberType.SelectedValue.ToString();
                        double total_payment = Convert.ToDouble(tbTotalPay.Text);
                        SqlCommand insert = new SqlCommand("sp_InsertTransaksiMember", con);
                        insert.CommandType = CommandType.StoredProcedure;
                        insert.Parameters.AddWithValue("id_member", ID);
                        insert.Parameters.AddWithValue("id_customer", CustId);
                        insert.Parameters.AddWithValue("id_jnsMember", MemberType);
                        insert.Parameters.AddWithValue("tgldaftar", datenow);
                        insert.Parameters.AddWithValue("tgl_expired", addedDateTime);
                        insert.Parameters.AddWithValue("biaya", total_payment);
                        string data = string.Empty;
                        DateTime expired;
                        a = 1;
                        try
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                data = row.Cells[1].Value.ToString();
                                expired = DateTime.Parse(row.Cells[4].Value.ToString());
                                expired.ToShortDateString();
                                string datenow = DateTime.Today.ToShortDateString();
                                if (CustId.Equals(data))
                                {
                                    if (expired > DateTime.Today)
                                    {
                                        MessageBox.Show("Customer has been registered as a member until " + expired + "!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        a = 0;
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Member validity period has expired " + expired + ", Please re-register", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        a = 1;
                                        return;
                                    }
                                }
                                a = 1;
                            }
                        }
                        catch (NullReferenceException ex)
                        {
                            //null data in rows
                        }
                        if (a == 1)
                        {
                            try
                            {
                                con.Open();
                                insert.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Data saved successfully with ID " + ID, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("" + ex);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Data failed to save");
                        }
                        LoadData();
                        LoadDataGridView();
                        Clear();
                        a = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void caribtn_Click(object sender, EventArgs e)
        {
            try
            {
                string cari = cbCustomerName.Text;
                try
                {
                    con.Open();
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariCustomer", con);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("nama_customer", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    con.Close();
                    if(st.Rows.Count != 0)
                    {
                        tbCustomerID.Text = st.Rows[0][0].ToString();
                        cbCustomerName.Text = st.Rows[0][1].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Customer Not Found!! \nInput Correct Name or Input New Customer", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbKembalian_TextChanged(object sender, EventArgs e)
        {
            tbKembalian.Text = string.Format("{0:n0}", double.Parse(tbKembalian.Text));
        }

        private void cbCustomerName_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cbCustomerName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbCustomerID.Text = cbCustomerName.SelectedValue.ToString();
        }

        private void cbCustomerName_Click(object sender, EventArgs e)
        {

        }
    }
}