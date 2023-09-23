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
using System.Windows.Forms;
using System.Configuration;

namespace D_Shoes.Menu
{
    public partial class Login : Form
    {
        string jabatan;
        string id,nama;
        public string userrr;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Shoes.Properties.Settings.Setting"].ConnectionString);
        private Form currchildform;
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 592);
        }
        private void openChildForm(Form childform)
        {
            currchildform = new Menu.Login();
            if (currchildform != null)
            {
                currchildform.Close();
            }
            currchildform = childform;
            childform.TopLevel = false;
            //childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel1.Controls.Add(childform);
            panel1.Tag = childform;
            childform.BringToFront();
            childform.Show();
            childform.WindowState = FormWindowState.Maximized;
        }
        private void btLogin_Click_1(object sender, EventArgs e)
        {
            string usr = txtUsername.Text;
            string pass = txtPassword.Text;
            try
            {
                con.Open();
                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("sp_LoginUsr", con);
                view.CommandType = CommandType.StoredProcedure;
                view.Parameters.AddWithValue("username", usr);
                view.Parameters.AddWithValue("password", pass);
                SqlDataAdapter adapter = new SqlDataAdapter(view);
                adapter.Fill(st);
                con.Close();
                if (st.Rows.Count != 0)
                {
                    if (st.Rows[0][3].ToString() == "0")
                    {
                        MessageBox.Show("Incorrect Username/Password !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        id = st.Rows[0][0].ToString();
                        jabatan = st.Rows[0][1].ToString();
                        nama = st.Rows[0][2].ToString();
                        if (jabatan == "Manager")
                        {
                            MessageBox.Show("Successfully Logged in as Manager!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ManagerMenu Form = new ManagerMenu();
                            Form.Show();
                            PegawaiLogin();
                            this.Hide();
                        }
                        else if (jabatan == "Admin")
                        {
                            MessageBox.Show("Successfully Logged in as Admin!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AdminMenu Form = new AdminMenu();
                            Form.Show();
                            PegawaiLogin();
                            this.Hide();
                        }
                        else if (jabatan == "Cashier")
                        {
                            MessageBox.Show("Successfully Logged in as Cashier!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KasirMenu Form = new KasirMenu();
                            Form.Show();
                            PegawaiLogin();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("You don't have access to logged in", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        cbPw.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show(" Incorrect Username/Password. Login Denied ", " Error! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void cbPw_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbPw.Checked)
            {
                txtPassword.isPassword = false;
            }
            else
            {
                txtPassword.isPassword = true;
            }
        }

        private void txtPassword_Enter_1(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void btExit_Click_1(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Sure exit program ??", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void closebtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void PegawaiLogin()
        {
            con.Open();
            SqlCommand login = new SqlCommand("sp_SavePegawaiLogin", con);
            login.CommandType = CommandType.StoredProcedure;
            login.Parameters.AddWithValue("@id", id);
            login.Parameters.AddWithValue("@nama_pegawai", nama);
            try
            {
                login.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save pegawai login: " + ex.Message);
            }
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
