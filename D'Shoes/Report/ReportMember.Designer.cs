﻿namespace D_Shoes.Report
{
    partial class MemberTs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberTs));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblTransaksiMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsTsMember = new D_Shoes.Report.DsTsMember();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dpSampai = new ns1.BunifuDatepicker();
            this.dpDari = new ns1.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSave = new ns1.BunifuThinButton2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblTransaksiMemberTableAdapter = new D_Shoes.Report.DsTsMemberTableAdapters.tblTransaksiMemberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransaksiMemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsTsMember)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblTransaksiMemberBindingSource
            // 
            this.tblTransaksiMemberBindingSource.DataMember = "tblTransaksiMember";
            this.tblTransaksiMemberBindingSource.DataSource = this.DsTsMember;
            // 
            // DsTsMember
            // 
            this.DsTsMember.DataSetName = "DsTsMember";
            this.DsTsMember.EnforceConstraints = false;
            this.DsTsMember.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.dpSampai);
            this.panel1.Controls.Add(this.dpDari);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(249, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 779);
            this.panel1.TabIndex = 2;
            // 
            // dpSampai
            // 
            this.dpSampai.BackColor = System.Drawing.Color.Firebrick;
            this.dpSampai.BorderRadius = 0;
            this.dpSampai.ForeColor = System.Drawing.Color.White;
            this.dpSampai.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpSampai.FormatCustom = null;
            this.dpSampai.Location = new System.Drawing.Point(561, 130);
            this.dpSampai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpSampai.Name = "dpSampai";
            this.dpSampai.Size = new System.Drawing.Size(393, 44);
            this.dpSampai.TabIndex = 102;
            this.dpSampai.Value = new System.DateTime(2022, 7, 13, 20, 10, 41, 99);
            // 
            // dpDari
            // 
            this.dpDari.BackColor = System.Drawing.Color.Firebrick;
            this.dpDari.BorderRadius = 0;
            this.dpDari.ForeColor = System.Drawing.Color.White;
            this.dpDari.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpDari.FormatCustom = null;
            this.dpDari.Location = new System.Drawing.Point(114, 130);
            this.dpDari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpDari.Name = "dpDari";
            this.dpDari.Size = new System.Drawing.Size(393, 44);
            this.dpDari.TabIndex = 101;
            this.dpDari.Value = new System.DateTime(2022, 7, 13, 20, 10, 38, 317);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(561, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 100;
            this.label2.Text = "Until";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 99;
            this.label1.Text = "From";
            // 
            // btSave
            // 
            this.btSave.ActiveBorderThickness = 1;
            this.btSave.ActiveCornerRadius = 20;
            this.btSave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btSave.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btSave.ActiveLineColor = System.Drawing.Color.White;
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSave.BackgroundImage")));
            this.btSave.ButtonText = "View";
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.Firebrick;
            this.btSave.IdleBorderThickness = 1;
            this.btSave.IdleCornerRadius = 20;
            this.btSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btSave.IdleForecolor = System.Drawing.Color.Firebrick;
            this.btSave.IdleLineColor = System.Drawing.Color.White;
            this.btSave.Location = new System.Drawing.Point(992, 130);
            this.btSave.Margin = new System.Windows.Forms.Padding(5);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(119, 44);
            this.btSave.TabIndex = 97;
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblTransaksiMemberBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "D_Shoes.Report1TsMember.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(114, 198);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(997, 540);
            this.reportViewer1.TabIndex = 1;
            // 
            // tblTransaksiMemberTableAdapter
            // 
            this.tblTransaksiMemberTableAdapter.ClearBeforeFill = true;
            // 
            // MemberTs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1810, 889);
            this.Controls.Add(this.panel1);
            this.Name = "MemberTs";
            this.Text = "Member Transaction Report";
            this.Load += new System.EventHandler(this.MemberTs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblTransaksiMemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsTsMember)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuThinButton2 btSave;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuDatepicker dpSampai;
        private ns1.BunifuDatepicker dpDari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource tblTransaksiMemberBindingSource;
        private DsTsMember DsTsMember;
        private DsTsMemberTableAdapters.tblTransaksiMemberTableAdapter tblTransaksiMemberTableAdapter;
    }
}