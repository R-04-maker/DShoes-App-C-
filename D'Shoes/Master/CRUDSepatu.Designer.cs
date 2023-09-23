namespace D_Shoes
{
    partial class CRUDSepatu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDSepatu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new ns1.BunifuCustomDataGrid();
            this.caribtn = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new ns1.BunifuMaterialTextbox();
            this.btSave = new ns1.BunifuThinButton2();
            this.btUpdate = new ns1.BunifuThinButton2();
            this.btDelete = new ns1.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtHargaJual = new System.Windows.Forms.TextBox();
            this.txtHargaBeli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGuaranty = new System.Windows.Forms.ComboBox();
            this.tblGaransiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRG2_KEL09DataSet1 = new D_Shoes.PRG2_KEL09DataSet1();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.btHapusGambar = new FontAwesome.Sharp.IconButton();
            this.btUploadGambar = new FontAwesome.Sharp.IconButton();
            this.pbGambar = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStock = new ns1.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.tblSupplierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbKategoriSepatu = new System.Windows.Forms.ComboBox();
            this.tblKategoriSepatuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamaSepatu = new ns1.BunifuMaterialTextbox();
            this.tblSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblKategoriSepatuTableAdapter = new D_Shoes.PRG2_KEL09DataSet1TableAdapters.tblKategoriSepatuTableAdapter();
            this.tblSupplierTableAdapter = new D_Shoes.PRG2_KEL09DataSet1TableAdapters.tblSupplierTableAdapter();
            this.tblGaransiTableAdapter = new D_Shoes.PRG2_KEL09DataSet1TableAdapters.tblGaransiTableAdapter();
            this.pRG2_KEL09DataSet = new D_Shoes.PRG2_KEL09DataSet();
            this.loadSepatuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadSepatuTableAdapter = new D_Shoes.PRG2_KEL09DataSetTableAdapters.LoadSepatuTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblGaransiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL09DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGambar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKategoriSepatuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL09DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadSepatuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.caribtn);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(672, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 739);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(14, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(896, 482);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // caribtn
            // 
            this.caribtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.caribtn.Location = new System.Drawing.Point(851, 41);
            this.caribtn.Margin = new System.Windows.Forms.Padding(4);
            this.caribtn.Name = "caribtn";
            this.caribtn.Size = new System.Drawing.Size(59, 42);
            this.caribtn.TabIndex = 84;
            this.caribtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.caribtn.UseVisualStyleBackColor = false;
            this.caribtn.Click += new System.EventHandler(this.caribtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.HintForeColor = System.Drawing.Color.White;
            this.txtSearch.HintText = "Search by Name";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.Color.White;
            this.txtSearch.LineIdleColor = System.Drawing.Color.White;
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtSearch.LineThickness = 3;
            this.txtSearch.Location = new System.Drawing.Point(637, 41);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(273, 53);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btSave.ButtonText = "Save";
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btSave.IdleBorderThickness = 1;
            this.btSave.IdleCornerRadius = 20;
            this.btSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btSave.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btSave.IdleLineColor = System.Drawing.Color.White;
            this.btSave.Location = new System.Drawing.Point(23, 587);
            this.btSave.Margin = new System.Windows.Forms.Padding(5);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(119, 56);
            this.btSave.TabIndex = 9;
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.ActiveBorderThickness = 1;
            this.btUpdate.ActiveCornerRadius = 20;
            this.btUpdate.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(116)))), ((int)(((byte)(175)))));
            this.btUpdate.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btUpdate.ActiveLineColor = System.Drawing.Color.White;
            this.btUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btUpdate.BackgroundImage")));
            this.btUpdate.ButtonText = "Update";
            this.btUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(116)))), ((int)(((byte)(175)))));
            this.btUpdate.IdleBorderThickness = 1;
            this.btUpdate.IdleCornerRadius = 20;
            this.btUpdate.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btUpdate.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(116)))), ((int)(((byte)(175)))));
            this.btUpdate.IdleLineColor = System.Drawing.Color.White;
            this.btUpdate.Location = new System.Drawing.Point(162, 587);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(119, 56);
            this.btUpdate.TabIndex = 10;
            this.btUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.ActiveBorderThickness = 1;
            this.btDelete.ActiveCornerRadius = 20;
            this.btDelete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(134)))), ((int)(((byte)(22)))));
            this.btDelete.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btDelete.ActiveLineColor = System.Drawing.Color.White;
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDelete.BackgroundImage")));
            this.btDelete.ButtonText = "Delete";
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(134)))), ((int)(((byte)(22)))));
            this.btDelete.IdleBorderThickness = 1;
            this.btDelete.IdleCornerRadius = 20;
            this.btDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btDelete.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(134)))), ((int)(((byte)(22)))));
            this.btDelete.IdleLineColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(300, 587);
            this.btDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(119, 56);
            this.btDelete.TabIndex = 11;
            this.btDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.txtHargaJual);
            this.panel2.Controls.Add(this.txtHargaBeli);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbGuaranty);
            this.panel2.Controls.Add(this.bunifuThinButton21);
            this.panel2.Controls.Add(this.btHapusGambar);
            this.panel2.Controls.Add(this.btUploadGambar);
            this.panel2.Controls.Add(this.pbGambar);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtStock);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbSupplier);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbKategoriSepatu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNamaSepatu);
            this.panel2.Controls.Add(this.btDelete);
            this.panel2.Controls.Add(this.btUpdate);
            this.panel2.Controls.Add(this.btSave);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(27, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 739);
            this.panel2.TabIndex = 5;
            // 
            // txtHargaJual
            // 
            this.txtHargaJual.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHargaJual.Location = new System.Drawing.Point(353, 549);
            this.txtHargaJual.Name = "txtHargaJual";
            this.txtHargaJual.Size = new System.Drawing.Size(242, 30);
            this.txtHargaJual.TabIndex = 8;
            this.txtHargaJual.TextChanged += new System.EventHandler(this.txtHargaJual_TextChanged);
            this.txtHargaJual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHargaJual_KeyPress);
            // 
            // txtHargaBeli
            // 
            this.txtHargaBeli.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHargaBeli.Location = new System.Drawing.Point(54, 549);
            this.txtHargaBeli.Name = "txtHargaBeli";
            this.txtHargaBeli.Size = new System.Drawing.Size(242, 30);
            this.txtHargaBeli.TabIndex = 7;
            this.txtHargaBeli.TextChanged += new System.EventHandler(this.txtHargaBeli_TextChanged);
            this.txtHargaBeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHargaBeli_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 21);
            this.label7.TabIndex = 129;
            this.label7.Text = "Warranty Type";
            // 
            // cmbGuaranty
            // 
            this.cmbGuaranty.DataSource = this.tblGaransiBindingSource;
            this.cmbGuaranty.DisplayMember = "jenis_garansi";
            this.cmbGuaranty.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGuaranty.FormattingEnabled = true;
            this.cmbGuaranty.Location = new System.Drawing.Point(23, 461);
            this.cmbGuaranty.Name = "cmbGuaranty";
            this.cmbGuaranty.Size = new System.Drawing.Size(273, 29);
            this.cmbGuaranty.TabIndex = 6;
            this.cmbGuaranty.ValueMember = "id_garansi";
            // 
            // tblGaransiBindingSource
            // 
            this.tblGaransiBindingSource.DataMember = "tblGaransi";
            this.tblGaransiBindingSource.DataSource = this.pRG2_KEL09DataSet1;
            // 
            // pRG2_KEL09DataSet1
            // 
            this.pRG2_KEL09DataSet1.DataSetName = "PRG2_KEL09DataSet1";
            this.pRG2_KEL09DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Cancel";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(162, 644);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(119, 56);
            this.bunifuThinButton21.TabIndex = 12;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btHapusGambar
            // 
            this.btHapusGambar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHapusGambar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHapusGambar.ForeColor = System.Drawing.Color.White;
            this.btHapusGambar.IconChar = FontAwesome.Sharp.IconChar.Eject;
            this.btHapusGambar.IconColor = System.Drawing.Color.White;
            this.btHapusGambar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btHapusGambar.IconSize = 30;
            this.btHapusGambar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHapusGambar.Location = new System.Drawing.Point(502, 332);
            this.btHapusGambar.Name = "btHapusGambar";
            this.btHapusGambar.Size = new System.Drawing.Size(122, 42);
            this.btHapusGambar.TabIndex = 120;
            this.btHapusGambar.Text = "Delete";
            this.btHapusGambar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHapusGambar.UseVisualStyleBackColor = true;
            this.btHapusGambar.Click += new System.EventHandler(this.btHapusGambar_Click);
            // 
            // btUploadGambar
            // 
            this.btUploadGambar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUploadGambar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUploadGambar.ForeColor = System.Drawing.Color.White;
            this.btUploadGambar.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.btUploadGambar.IconColor = System.Drawing.Color.White;
            this.btUploadGambar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btUploadGambar.IconSize = 30;
            this.btUploadGambar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUploadGambar.Location = new System.Drawing.Point(353, 332);
            this.btUploadGambar.Name = "btUploadGambar";
            this.btUploadGambar.Size = new System.Drawing.Size(122, 42);
            this.btUploadGambar.TabIndex = 119;
            this.btUploadGambar.Text = "Browse";
            this.btUploadGambar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUploadGambar.UseVisualStyleBackColor = true;
            this.btUploadGambar.Click += new System.EventHandler(this.btUploadGambar_Click);
            // 
            // pbGambar
            // 
            this.pbGambar.Image = global::D_Shoes.Properties.Resources.noimage;
            this.pbGambar.Location = new System.Drawing.Point(350, 67);
            this.pbGambar.Name = "pbGambar";
            this.pbGambar.Size = new System.Drawing.Size(274, 252);
            this.pbGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGambar.TabIndex = 117;
            this.pbGambar.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(19, 512);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 21);
            this.label9.TabIndex = 116;
            this.label9.Text = "Purchase Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(315, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 115;
            this.label8.Text = "Selling Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(315, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 21);
            this.label6.TabIndex = 112;
            this.label6.Text = "Rp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 21);
            this.label5.TabIndex = 111;
            this.label5.Text = "Rp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 108;
            this.label4.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.ForeColor = System.Drawing.Color.White;
            this.txtStock.HintForeColor = System.Drawing.Color.White;
            this.txtStock.HintText = "";
            this.txtStock.isPassword = false;
            this.txtStock.LineFocusedColor = System.Drawing.Color.White;
            this.txtStock.LineIdleColor = System.Drawing.Color.White;
            this.txtStock.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtStock.LineThickness = 3;
            this.txtStock.Location = new System.Drawing.Point(23, 354);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(273, 53);
            this.txtStock.TabIndex = 5;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 106;
            this.label3.Text = "Merk";
            // 
            // cbSupplier
            // 
            this.cbSupplier.DataSource = this.tblSupplierBindingSource1;
            this.cbSupplier.DisplayMember = "merk";
            this.cbSupplier.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(23, 295);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(273, 29);
            this.cbSupplier.TabIndex = 4;
            this.cbSupplier.ValueMember = "id_supplier";
            // 
            // tblSupplierBindingSource1
            // 
            this.tblSupplierBindingSource1.DataMember = "tblSupplier";
            this.tblSupplierBindingSource1.DataSource = this.pRG2_KEL09DataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 104;
            this.label1.Text = "Shoes Category";
            // 
            // cbKategoriSepatu
            // 
            this.cbKategoriSepatu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbKategoriSepatu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKategoriSepatu.DataSource = this.tblKategoriSepatuBindingSource;
            this.cbKategoriSepatu.DisplayMember = "deskripsi_kategori";
            this.cbKategoriSepatu.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKategoriSepatu.FormattingEnabled = true;
            this.cbKategoriSepatu.Location = new System.Drawing.Point(23, 198);
            this.cbKategoriSepatu.Name = "cbKategoriSepatu";
            this.cbKategoriSepatu.Size = new System.Drawing.Size(273, 29);
            this.cbKategoriSepatu.TabIndex = 3;
            this.cbKategoriSepatu.ValueMember = "id_kategori";
            // 
            // tblKategoriSepatuBindingSource
            // 
            this.tblKategoriSepatuBindingSource.DataMember = "tblKategoriSepatu";
            this.tblKategoriSepatuBindingSource.DataSource = this.pRG2_KEL09DataSet1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 102;
            this.label2.Text = "Shoes Name";
            // 
            // txtNamaSepatu
            // 
            this.txtNamaSepatu.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNamaSepatu.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaSepatu.ForeColor = System.Drawing.Color.White;
            this.txtNamaSepatu.HintForeColor = System.Drawing.Color.White;
            this.txtNamaSepatu.HintText = "";
            this.txtNamaSepatu.isPassword = false;
            this.txtNamaSepatu.LineFocusedColor = System.Drawing.Color.White;
            this.txtNamaSepatu.LineIdleColor = System.Drawing.Color.White;
            this.txtNamaSepatu.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtNamaSepatu.LineThickness = 3;
            this.txtNamaSepatu.Location = new System.Drawing.Point(23, 80);
            this.txtNamaSepatu.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamaSepatu.Name = "txtNamaSepatu";
            this.txtNamaSepatu.Size = new System.Drawing.Size(273, 53);
            this.txtNamaSepatu.TabIndex = 2;
            this.txtNamaSepatu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tblSupplierBindingSource
            // 
            this.tblSupplierBindingSource.DataMember = "tblSupplier";
            this.tblSupplierBindingSource.DataSource = this.pRG2_KEL09DataSet1;
            // 
            // tblKategoriSepatuTableAdapter
            // 
            this.tblKategoriSepatuTableAdapter.ClearBeforeFill = true;
            // 
            // tblSupplierTableAdapter
            // 
            this.tblSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // tblGaransiTableAdapter
            // 
            this.tblGaransiTableAdapter.ClearBeforeFill = true;
            // 
            // pRG2_KEL09DataSet
            // 
            this.pRG2_KEL09DataSet.DataSetName = "PRG2_KEL09DataSet";
            this.pRG2_KEL09DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loadSepatuBindingSource
            // 
            this.loadSepatuBindingSource.DataMember = "LoadSepatu";
            this.loadSepatuBindingSource.DataSource = this.pRG2_KEL09DataSet;
            // 
            // loadSepatuTableAdapter
            // 
            this.loadSepatuTableAdapter.ClearBeforeFill = true;
            // 
            // CRUDSepatu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1624, 792);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDSepatu";
            this.Text = "Manage Shoes";
            this.Load += new System.EventHandler(this.CRUDSepatu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblGaransiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL09DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGambar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKategoriSepatuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL09DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadSepatuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuCustomDataGrid dataGridView1;
        private FontAwesome.Sharp.IconButton caribtn;
        private ns1.BunifuMaterialTextbox txtSearch;
        private ns1.BunifuThinButton2 btSave;
        private ns1.BunifuThinButton2 btUpdate;
        private ns1.BunifuThinButton2 btDelete;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuMaterialTextbox txtNamaSepatu;
        private FontAwesome.Sharp.IconButton btUploadGambar;
        private System.Windows.Forms.PictureBox pbGambar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHargaJual;
        private System.Windows.Forms.TextBox txtHargaBeli;
        private System.Windows.Forms.Label label4;
        private ns1.BunifuMaterialTextbox txtStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKategoriSepatu;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btHapusGambar;
        private PRG2_KEL09DataSet1 pRG2_KEL09DataSet1;
        private System.Windows.Forms.BindingSource tblKategoriSepatuBindingSource;
        private PRG2_KEL09DataSet1TableAdapters.tblKategoriSepatuTableAdapter tblKategoriSepatuTableAdapter;
        private System.Windows.Forms.BindingSource tblSupplierBindingSource;
        private PRG2_KEL09DataSet1TableAdapters.tblSupplierTableAdapter tblSupplierTableAdapter;
        private System.Windows.Forms.BindingSource tblSupplierBindingSource1;
        private ns1.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGuaranty;
        private System.Windows.Forms.BindingSource tblGaransiBindingSource;
        private PRG2_KEL09DataSet1TableAdapters.tblGaransiTableAdapter tblGaransiTableAdapter;
        private PRG2_KEL09DataSet pRG2_KEL09DataSet;
        private System.Windows.Forms.BindingSource loadSepatuBindingSource;
        private PRG2_KEL09DataSetTableAdapters.LoadSepatuTableAdapter loadSepatuTableAdapter;
    }
}