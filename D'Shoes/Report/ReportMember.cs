using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Shoes.Report
{
    public partial class MemberTs : Form
    {
        public MemberTs()
        {
            InitializeComponent();
        }

        private void MemberTs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsTsMember.tblTransaksiMember' table. You can move, or remove it, as needed.
            //this.tblTransaksiMemberTableAdapter.Fill(this.DsTsMember.tblTransaksiMember);
            dpDari.Value = DateTime.Now;
            dpSampai.Value = DateTime.Now;
            //this.tblTransaksiMemberTableAdapter.Fill(this.DsTsMember.tblTransaksiMember);

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            ReportParameter[] para = new ReportParameter[2];
            para[0] = new ReportParameter("dari", dpDari.Value.ToString("dd-MM-yyyy"));
            para[1] = new ReportParameter("sampai", dpSampai.Value.ToString("dd-MM-yyyy"));

            // Pass Parameters for Local Report
            reportViewer1.LocalReport.SetParameters(para);

            // TODO: This line of code loads data into the 'DsTsMember.tblTransaksiMember' table. You can move, or remove it, as needed.
            this.tblTransaksiMemberTableAdapter.Fill(this.DsTsMember.tblTransaksiMember, dpDari.Value.ToString("dd-MM-yyyy"), dpSampai.Value.ToString("dd-MM-yyyy"));
            this.reportViewer1.RefreshReport();
        }
    }
}
