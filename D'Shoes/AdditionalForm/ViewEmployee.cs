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

namespace D_Shoes.AdditionalForm
{
    public partial class ViewEmployee : Form
    {
        String ID;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);

        public ViewEmployee()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                con.Open();
                try
                {

                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_LoadViewPegawai", con);
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
                dataGridView1.Columns[1].HeaderCell.Value = "Role";
                dataGridView1.Columns[2].HeaderCell.Value = "Employee Name";
                dataGridView1.Columns[3].HeaderCell.Value = "NIK";
                dataGridView1.Columns[4].HeaderCell.Value = "Date of Birth";
                dataGridView1.Columns[5].HeaderCell.Value = "Gender";
                dataGridView1.Columns[6].HeaderCell.Value = "Phone Number";
                dataGridView1.Columns[7].HeaderCell.Value = "Username";
                dataGridView1.Columns[8].HeaderCell.Value = "Status";
                dataGridView1.Columns[0].Width = 150;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 175;
                dataGridView1.Columns[3].Width = 170;
                dataGridView1.Columns[4].Width = 150;
                dataGridView1.Columns[5].Width = 150;
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[7].Width = 150;
                dataGridView1.Columns[8].Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
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
            dataGridView1.Columns[8].Visible = false;
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
    }
}
