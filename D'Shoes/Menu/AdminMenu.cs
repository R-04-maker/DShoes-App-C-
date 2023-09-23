using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace D_Shoes
{
    public partial class AdminMenu : Form
    {
        //fields
        private IconButton curentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public AdminMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size =  new Size(30,60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 53, 53);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                //Button
                curentBtn = (IconButton)senderBtn;
                curentBtn.BackColor = Color.FromArgb(37, 36, 81);
                curentBtn.ForeColor = color;
                curentBtn.TextAlign = ContentAlignment.MiddleCenter;
                curentBtn.IconColor = color;
                curentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                curentBtn.ImageAlign = ContentAlignment.MiddleRight;
                
            }
        }
        private void DisableButton()
        {
            if(curentBtn != null)
            {
                curentBtn.BackColor = Color.FromArgb(40, 37, 51);
                curentBtn.ForeColor = Color.White;
                curentBtn.TextAlign = ContentAlignment.MiddleLeft;
                curentBtn.IconColor = Color.White;
                curentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                curentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void AdminMenu_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btShoes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new CRUDSepatu());
            lblTitle.Text = "Manage Shoes";

        }

        private void btCategory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Master.CRUDKatSepatu());
            lblTitle.Text = "Manage Shoes Category";
        }

        private void btSupplier_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Master.CRUDSupplier());
            lblTitle.Text = "Manage Supplier";
        }

        private void btMemberType_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Master.CRUDTipeMember());
            lblTitle.Text = "Manage Member Type";

        }

        private void btPayMethod_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Master.CRUDTipePembayaran());
            lblTitle.Text = "Manage Payment Method";

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Master.CRUDGaransi());
            lblTitle.Text = "Manage Warranty";
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.Login Form = new Menu.Login();
            Form.Show();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
            OpenChildForm(new AdminDashboard());
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            lblTitle.Text = "DASHBOARD";
        }

        private void btEmpType_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Master.CRUDJabatan());
            lblTitle.Text = "Manage Role";
        }

        private void btEmployee_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Master.CRUDPegawai());
            lblTitle.Text = "Manage Employee";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconbtPerson_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
            OpenChildForm(new AdminDashboard());
        }

        private void AdminMenu_Load_1(object sender, EventArgs e)
        {
            OpenChildForm(new AdminDashboard());
        }
    }
}
