namespace D_Shoes.AdditionalForm
{
    partial class ViewShoesCashier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblKategoriSepatuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tblKategoriSepatuBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pRG2_KEL09DataSet1 = new D_Shoes.PRG2_KEL09DataSet1();
            this.dataGridView1 = new ns1.BunifuCustomDataGrid();
            this.txtSearch = new ns1.BunifuMaterialTextbox();
            this.fKtblSepatutblKategoriSepatuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblKategoriSepatuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblKategoriSepatuTableAdapter = new D_Shoes.PRG2_KEL09DataSet1TableAdapters.tblKategoriSepatuTableAdapter();
            this.caribtn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tblKategoriSepatuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKategoriSepatuBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL09DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblSepatutblKategoriSepatuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKategoriSepatuBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(674, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 23);
            this.label1.TabIndex = 88;
            this.label1.Text = "Search by Category";
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategory.DataSource = this.tblKategoriSepatuBindingSource2;
            this.cbCategory.DisplayMember = "deskripsi_kategori";
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(678, 57);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(312, 30);
            this.cbCategory.TabIndex = 86;
            this.cbCategory.ValueMember = "id_kategori";
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // tblKategoriSepatuBindingSource2
            // 
            this.tblKategoriSepatuBindingSource2.DataMember = "tblKategoriSepatu";
            this.tblKategoriSepatuBindingSource2.DataSource = this.pRG2_KEL09DataSet1;
            // 
            // pRG2_KEL09DataSet1
            // 
            this.pRG2_KEL09DataSet1.DataSetName = "PRG2_KEL09DataSet1";
            this.pRG2_KEL09DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(20, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.Height = 200;
            this.dataGridView1.Size = new System.Drawing.Size(1365, 552);
            this.dataGridView1.TabIndex = 85;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.HintForeColor = System.Drawing.Color.White;
            this.txtSearch.HintText = "Search by Name";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.Color.White;
            this.txtSearch.LineIdleColor = System.Drawing.Color.White;
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtSearch.LineThickness = 3;
            this.txtSearch.Location = new System.Drawing.Point(1017, 57);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 30);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fKtblSepatutblKategoriSepatuBindingSource
            // 
            this.fKtblSepatutblKategoriSepatuBindingSource.DataSource = this.tblKategoriSepatuBindingSource;
            // 
            // tblKategoriSepatuTableAdapter
            // 
            this.tblKategoriSepatuTableAdapter.ClearBeforeFill = true;
            // 
            // caribtn
            // 
            this.caribtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caribtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.caribtn.FlatAppearance.BorderSize = 0;
            this.caribtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caribtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caribtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.caribtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.caribtn.IconColor = System.Drawing.Color.White;
            this.caribtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.caribtn.IconSize = 35;
            this.caribtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.caribtn.Location = new System.Drawing.Point(1326, 57);
            this.caribtn.Margin = new System.Windows.Forms.Padding(4);
            this.caribtn.Name = "caribtn";
            this.caribtn.Size = new System.Drawing.Size(59, 42);
            this.caribtn.TabIndex = 84;
            this.caribtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.caribtn.UseVisualStyleBackColor = false;
            this.caribtn.Click += new System.EventHandler(this.caribtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.caribtn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(29, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 759);
            this.panel1.TabIndex = 89;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ViewShoesCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1463, 798);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewShoesCashier";
            this.Text = "View Shoes";
            this.Load += new System.EventHandler(this.ViewSepatuKasir_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.tblKategoriSepatuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKategoriSepatuBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL09DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblSepatutblKategoriSepatuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKategoriSepatuBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tblKategoriSepatuBindingSource;
        private System.Windows.Forms.BindingSource tblSupplierBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
        private ns1.BunifuCustomDataGrid dataGridView1;
        private ns1.BunifuMaterialTextbox txtSearch;
        private System.Windows.Forms.BindingSource fKtblSepatutblKategoriSepatuBindingSource;
        private System.Windows.Forms.BindingSource tblKategoriSepatuBindingSource1;
        private PRG2_KEL09DataSet1 pRG2_KEL09DataSet1;
        private System.Windows.Forms.BindingSource tblKategoriSepatuBindingSource2;
        private PRG2_KEL09DataSet1TableAdapters.tblKategoriSepatuTableAdapter tblKategoriSepatuTableAdapter;
        private FontAwesome.Sharp.IconButton caribtn;
        private System.Windows.Forms.Panel panel1;
    }
}