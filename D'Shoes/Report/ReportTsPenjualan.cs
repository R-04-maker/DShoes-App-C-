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
    public partial class ReportTsPenjualan : Form
    {
        public ReportTsPenjualan()
        {
            InitializeComponent();
        }

        private void ReportTsPenjualan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsTsPenjualan.tblTransaksiPenjualan' table. You can move, or remove it, as needed.
            // this.tblTransaksiPenjualanTableAdapter.Fill(this.DsTsPenjualan.tblTransaksiPenjualan);
            dpDari.Value = DateTime.Now;
            dpSampai.Value = DateTime.Now;
            // this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            ReportParameter[] para = new ReportParameter[2];
            para[0] = new ReportParameter("dari", dpDari.Value.ToString("dd-MM-yyyy"));
            para[1] = new ReportParameter("sampai", dpSampai.Value.ToString("dd-MM-yyyy"));

            // Pass Parameters for Local Report
            reportViewer1.LocalReport.SetParameters(para);

            // TODO: This line of code loads data into the 'dsLaporan.dtPenjualan' table. You can move, or remove it, as needed..
            this.tblTransaksiPenjualanTableAdapter.Fill(this.DsTsPenjualan.tblTransaksiPenjualan, dpDari.Value.ToString("dd-MM-yyyy"), dpSampai.Value.ToString("dd-MM-yyyy"));
            this.reportViewer1.RefreshReport();
        }
    }
}
