namespace D_Shoes.Master
{
    partial class CRUDPegawai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDPegawai));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.tbPhoneNumber = new ns1.BunifuMaterialTextbox();
            this.cmbJabatan = new System.Windows.Forms.ComboBox();
            this.tblJabatanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pRG2_KEL09DataSet1 = new D_Shoes.PRG2_KEL09DataSet1();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.tbPassword = new ns1.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDate = new ns1.BunifuDatepicker();
            this.tbUsername = new ns1.BunifuMaterialTextbox();
            this.tbNIK = new ns1.BunifuMaterialTextbox();
            this.tbEmployeeName = new ns1.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tblJabatanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caribtn = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new ns1.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCancel = new ns1.BunifuThinButton2();
            this.dataGridView1 = new ns1.BunifuCustomDataGrid();
            this.btDelete = new ns1.BunifuThinButton2();
            this.btUpdate = new ns1.BunifuThinButton2();
            this.btSave = new ns1.BunifuThinButton2();
            this.tblJabatanTableAdapter = new D_Shoes.PRG2_KEL09DataSet1TableAdapters.tblJabatanTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblJabatanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL09DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJabatanBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tbPhoneNumber);
            this.panel1.Controls.Add(this.cmbJabatan);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbDate);
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.Controls.Add(this.tbNIK);
            this.panel1.Controls.Add(this.tbEmployeeName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(60, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 713);
            this.panel1.TabIndex = 124;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLaki);
            this.groupBox1.Controls.Add(this.rbPerempuan);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(44, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 83);
            this.groupBox1.TabIndex = 136;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLaki.ForeColor = System.Drawing.Color.White;
            this.rbLaki.Location = new System.Drawing.Point(43, 29);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(74, 25);
            this.rbLaki.TabIndex = 111;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Male";
            this.rbLaki.UseVisualStyleBackColor = true;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerempuan.ForeColor = System.Drawing.Color.White;
            this.rbPerempuan.Location = new System.Drawing.Point(174, 29);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(91, 25);
            this.rbPerempuan.TabIndex = 112;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Female";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.tbPhoneNumber.HintForeColor = System.Drawing.Color.White;
            this.tbPhoneNumber.HintText = "Phone Number";
            this.tbPhoneNumber.isPassword = false;
            this.tbPhoneNumber.LineFocusedColor = System.Drawing.Color.White;
            this.tbPhoneNumber.LineIdleColor = System.Drawing.Color.White;
            this.tbPhoneNumber.LineMouseHoverColor = System.Drawing.Color.White;
            this.tbPhoneNumber.LineThickness = 4;
            this.tbPhoneNumber.Location = new System.Drawing.Point(44, 413);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(344, 53);
            this.tbPhoneNumber.TabIndex = 125;
            this.tbPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhoneNumber_KeyPress_1);
            // 
            // cmbJabatan
            // 
            this.cmbJabatan.DataSource = this.tblJabatanBindingSource1;
            this.cmbJabatan.DisplayMember = "nama_jabatan";
            this.cmbJabatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJabatan.FormattingEnabled = true;
            this.cmbJabatan.Location = new System.Drawing.Point(44, 133);
            this.cmbJabatan.Name = "cmbJabatan";
            this.cmbJabatan.Size = new System.Drawing.Size(340, 33);
            this.cmbJabatan.TabIndex = 135;
            this.cmbJabatan.ValueMember = "id_jabatan";
            // 
            // tblJabatanBindingSource1
            // 
            this.tblJabatanBindingSource1.DataMember = "tblJabatan";
            this.tblJabatanBindingSource1.DataSource = this.pRG2_KEL09DataSet1;
            // 
            // pRG2_KEL09DataSet1
            // 
            this.pRG2_KEL09DataSet1.DataSetName = "PRG2_KEL09DataSet1";
            this.pRG2_KEL09DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(46, 623);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 134;
            this.label5.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Inactive",
            "Active"});
            this.cmbStatus.Location = new System.Drawing.Point(44, 653);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(342, 33);
            this.cmbStatus.TabIndex = 133;
            // 
            // tbPassword
            // 
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.HintForeColor = System.Drawing.Color.White;
            this.tbPassword.HintText = "Password";
            this.tbPassword.isPassword = false;
            this.tbPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbPassword.LineIdleColor = System.Drawing.Color.White;
            this.tbPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbPassword.LineThickness = 4;
            this.tbPassword.Location = new System.Drawing.Point(44, 557);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(344, 44);
            this.tbPassword.TabIndex = 132;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassword.OnValueChanged += new System.EventHandler(this.tbPassword_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 131;
            this.label1.Text = "Date of Birth";
            // 
            // cmbDate
            // 
            this.cmbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.cmbDate.BorderRadius = 0;
            this.cmbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDate.ForeColor = System.Drawing.Color.White;
            this.cmbDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.cmbDate.FormatCustom = null;
            this.cmbDate.Location = new System.Drawing.Point(44, 270);
            this.cmbDate.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(344, 40);
            this.cmbDate.TabIndex = 130;
            this.cmbDate.Value = new System.DateTime(2022, 6, 16, 19, 55, 22, 609);
            // 
            // tbUsername
            // 
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.White;
            this.tbUsername.HintForeColor = System.Drawing.Color.White;
            this.tbUsername.HintText = "Username";
            this.tbUsername.isPassword = false;
            this.tbUsername.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbUsername.LineIdleColor = System.Drawing.Color.White;
            this.tbUsername.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbUsername.LineThickness = 4;
            this.tbUsername.Location = new System.Drawing.Point(44, 488);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(344, 44);
            this.tbUsername.TabIndex = 129;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbNIK
            // 
            this.tbNIK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNIK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNIK.ForeColor = System.Drawing.Color.White;
            this.tbNIK.HintForeColor = System.Drawing.Color.White;
            this.tbNIK.HintText = "NIK";
            this.tbNIK.isPassword = false;
            this.tbNIK.LineFocusedColor = System.Drawing.Color.White;
            this.tbNIK.LineIdleColor = System.Drawing.Color.White;
            this.tbNIK.LineMouseHoverColor = System.Drawing.Color.White;
            this.tbNIK.LineThickness = 4;
            this.tbNIK.Location = new System.Drawing.Point(44, 173);
            this.tbNIK.Margin = new System.Windows.Forms.Padding(4);
            this.tbNIK.Name = "tbNIK";
            this.tbNIK.Size = new System.Drawing.Size(344, 53);
            this.tbNIK.TabIndex = 123;
            this.tbNIK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNIK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNIK_KeyPress_1);
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmployeeName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmployeeName.ForeColor = System.Drawing.Color.White;
            this.tbEmployeeName.HintForeColor = System.Drawing.Color.White;
            this.tbEmployeeName.HintText = "Employee Name";
            this.tbEmployeeName.isPassword = false;
            this.tbEmployeeName.LineFocusedColor = System.Drawing.Color.White;
            this.tbEmployeeName.LineIdleColor = System.Drawing.Color.White;
            this.tbEmployeeName.LineMouseHoverColor = System.Drawing.Color.White;
            this.tbEmployeeName.LineThickness = 4;
            this.tbEmployeeName.Location = new System.Drawing.Point(44, 13);
            this.tbEmployeeName.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.Size = new System.Drawing.Size(344, 53);
            this.tbEmployeeName.TabIndex = 122;
            this.tbEmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 101;
            this.label2.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 102;
            // 
            // caribtn
            // 
            this.caribtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.caribtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            this.caribtn.Location = new System.Drawing.Point(365, 33);
            this.caribtn.Margin = new System.Windows.Forms.Padding(4);
            this.caribtn.Name = "caribtn";
            this.caribtn.Size = new System.Drawing.Size(41, 42);
            this.caribtn.TabIndex = 126;
            this.caribtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.caribtn.UseVisualStyleBackColor = false;
            this.caribtn.Click += new System.EventHandler(this.caribtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.HintForeColor = System.Drawing.Color.White;
            this.txtSearch.HintText = "Search by Name";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.Color.White;
            this.txtSearch.LineIdleColor = System.Drawing.Color.White;
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtSearch.LineThickness = 4;
            this.txtSearch.Location = new System.Drawing.Point(19, 24);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(337, 53);
            this.txtSearch.TabIndex = 97;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.btCancel);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.caribtn);
            this.panel2.Controls.Add(this.btDelete);
            this.panel2.Controls.Add(this.btUpdate);
            this.panel2.Controls.Add(this.btSave);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(493, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1137, 713);
            this.panel2.TabIndex = 125;
            // 
            // btCancel
            // 
            this.btCancel.ActiveBorderThickness = 1;
            this.btCancel.ActiveCornerRadius = 20;
            this.btCancel.ActiveFillColor = System.Drawing.Color.White;
            this.btCancel.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btCancel.ActiveLineColor = System.Drawing.Color.White;
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCancel.BackgroundImage")));
            this.btCancel.ButtonText = "Cancel";
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.IdleBorderThickness = 1;
            this.btCancel.IdleCornerRadius = 20;
            this.btCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btCancel.IdleForecolor = System.Drawing.Color.White;
            this.btCancel.IdleLineColor = System.Drawing.Color.White;
            this.btCancel.Location = new System.Drawing.Point(173, 623);
            this.btCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(119, 56);
            this.btCancel.TabIndex = 126;
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCancel.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(17, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 436);
            this.dataGridView1.TabIndex = 127;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
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
            this.btDelete.Location = new System.Drawing.Point(302, 557);
            this.btDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(119, 56);
            this.btDelete.TabIndex = 106;
            this.btDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.ActiveBorderThickness = 1;
            this.btUpdate.ActiveCornerRadius = 20;
            this.btUpdate.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(116)))), ((int)(((byte)(175)))));
            this.btUpdate.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btUpdate.ActiveLineColor = System.Drawing.Color.White;
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
            this.btUpdate.Location = new System.Drawing.Point(173, 557);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(119, 56);
            this.btUpdate.TabIndex = 105;
            this.btUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
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
            this.btSave.Location = new System.Drawing.Point(44, 557);
            this.btSave.Margin = new System.Windows.Forms.Padding(5);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(119, 56);
            this.btSave.TabIndex = 104;
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSave.Click += new System.EventHandler(this.btSave_Click_1);
            // 
            // tblJabatanTableAdapter
            // 
            this.tblJabatanTableAdapter.ClearBeforeFill = true;
            // 
            // CRUDPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1691, 773);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDPegawai";
            this.Text = "Manage Employee";
            this.Load += new System.EventHandler(this.CRUDPegawai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblJabatanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL09DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJabatanBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbJabatan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbStatus;
        private ns1.BunifuMaterialTextbox tbPassword;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuDatepicker cmbDate;
        private ns1.BunifuMaterialTextbox tbUsername;
        private FontAwesome.Sharp.IconButton caribtn;
        private ns1.BunifuMaterialTextbox tbPhoneNumber;
        private ns1.BunifuMaterialTextbox tbNIK;
        private ns1.BunifuMaterialTextbox tbEmployeeName;
        private ns1.BunifuMaterialTextbox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuThinButton2 btDelete;
        private ns1.BunifuThinButton2 btUpdate;
        private ns1.BunifuThinButton2 btSave;
        private System.Windows.Forms.BindingSource tblJabatanBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private ns1.BunifuCustomDataGrid dataGridView1;
        private ns1.BunifuThinButton2 btCancel;
        private PRG2_KEL09DataSet1 pRG2_KEL09DataSet1;
        private System.Windows.Forms.BindingSource tblJabatanBindingSource1;
        private PRG2_KEL09DataSet1TableAdapters.tblJabatanTableAdapter tblJabatanTableAdapter;
    }
}