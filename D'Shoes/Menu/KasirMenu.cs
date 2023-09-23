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
    public partial class KasirMenu : Form
    {
        //fields
        private IconButton curentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public KasirMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
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
            public static Color color1 = Color.FromArgb( 255, 53, 53);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                if(curentBtn != (Button)senderBtn)
                {
                    DisableButton();
                    curentBtn = (IconButton)senderBtn;
                    curentBtn.BackColor = Color.FromArgb(37, 36, 81);
                    curentBtn.ForeColor = color;
                    curentBtn.TextAlign = ContentAlignment.MiddleCenter;
                    curentBtn.IconColor = color;
                    curentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                    curentBtn.ImageAlign = ContentAlignment.MiddleRight;
                }
            }
        }
        private void DisableButton()
        {
            if (curentBtn != null)
            {
                curentBtn.BackColor = Color.FromArgb(40, 37, 51);
                curentBtn.ForeColor = Color.Gainsboro;
                curentBtn.TextAlign = ContentAlignment.MiddleLeft;
                curentBtn.IconColor = Color.Gainsboro;
                curentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                curentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm,object btnSender)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(childForm);
            this.panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void btCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Master.CRUDCustomer(), sender);
        }

        public void btCourierTs_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Transaction.TransaksiMember(), sender);
        }

        private void btSuplierTs_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Transaction.TransaksiBeli(), sender);
        }

        private void bCustTs_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Transaction.TransaksiJual(), sender);
        }

        private void btKlaimGuaranty_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Transaction.TransaksiGaransi(), sender);
        }

        private void btSupplierStatus_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Transaction.StatusSupplier(), sender);
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.Login Form = new Menu.Login();
            Form.Show();
        }

        private void btShoes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new AdditionalForm.ViewShoesCashier(),sender);
            //this.Dock = DockStyle.Top;
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
            lblTitle.Text = "Cashier Menu";
            OpenChildForm(new CashierDashboard(), sender);

        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void KasirMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            OpenChildForm(new CashierDashboard(), sender);
        }

        //private void iconbtPerson_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new CashierDashboard());
        //}


    }
}
