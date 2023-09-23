namespace D_Shoes.Transaction
{
    partial class TransaksiMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransaksiMember));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btClear = new ns1.BunifuThinButton2();
            this.tbExpired = new System.Windows.Forms.TextBox();
            this.btSave = new ns1.BunifuThinButton2();
            this.label9 = new System.Windows.Forms.Label();
            this.tbKembalian = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPayment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTotalPay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMemberType = new System.Windows.Forms.ComboBox();
            this.tblTipeMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRG2_KEL09DataSet1 = new D_Shoes.PRG2_KEL09DataSet1();
            this.caribtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tblTipeMemberTableAdapter = new D_Shoes.PRG2_KEL09DataSet1TableAdapters.tblTipeMemberTableAdapter();
            this.dataGridView1 = new ns1.BunifuCustomDataGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustomerTableAdapter = new D_Shoes.PRG2_KEL09DataSet1TableAdapters.tblCustomerTableAdapter();
            this.cbCustomerName = new System.Windows.Forms.ComboBox();
            this.tblCustomerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipeMemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL09DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.cbCustomerName);
            this.panel1.Controls.Add(this.btClear);
            this.panel1.Controls.Add(this.tbExpired);
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbKembalian);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbPayment);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbTotalPay);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbMemberType);
            this.panel1.Controls.Add(this.caribtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbCustomerID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(22, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 573);
            this.panel1.TabIndex = 0;
            // 
            // btClear
            // 
            this.btClear.ActiveBorderThickness = 1;
            this.btClear.ActiveCornerRadius = 20;
            this.btClear.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(116)))), ((int)(((byte)(175)))));
            this.btClear.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btClear.ActiveLineColor = System.Drawing.Color.White;
            this.btClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btClear.BackgroundImage")));
            this.btClear.ButtonText = "Clear";
            this.btClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(116)))), ((int)(((byte)(175)))));
            this.btClear.IdleBorderThickness = 1;
            this.btClear.IdleCornerRadius = 20;
            this.btClear.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btClear.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(116)))), ((int)(((byte)(175)))));
            this.btClear.IdleLineColor = System.Drawing.Color.White;
            this.btClear.Location = new System.Drawing.Point(428, 467);
            this.btClear.Margin = new System.Windows.Forms.Padding(5);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(119, 56);
            this.btClear.TabIndex = 158;
            this.btClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // tbExpired
            // 
            this.tbExpired.Enabled = false;
            this.tbExpired.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExpired.Location = new System.Drawing.Point(408, 199);
            this.tbExpired.Name = "tbExpired";
            this.tbExpired.Size = new System.Drawing.Size(295, 32);
            this.tbExpired.TabIndex = 157;
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
            this.btSave.Location = new System.Drawing.Point(246, 467);
            this.btSave.Margin = new System.Windows.Forms.Padding(5);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(119, 56);
            this.btSave.TabIndex = 155;
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(402, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 23);
            this.label9.TabIndex = 154;
            this.label9.Text = "Rp";
            // 
            // tbKembalian
            // 
            this.tbKembalian.Enabled = false;
            this.tbKembalian.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKembalian.Location = new System.Drawing.Point(450, 406);
            this.tbKembalian.Name = "tbKembalian";
            this.tbKembalian.Size = new System.Drawing.Size(253, 32);
            this.tbKembalian.TabIndex = 153;
            this.tbKembalian.TextChanged += new System.EventHandler(this.tbKembalian_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(404, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 23);
            this.label10.TabIndex = 152;
            this.label10.Text = "Change Money";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(402, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 23);
            this.label7.TabIndex = 151;
            this.label7.Text = "Rp";
            // 
            // tbPayment
            // 
            this.tbPayment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPayment.Location = new System.Drawing.Point(450, 313);
            this.tbPayment.Name = "tbPayment";
            this.tbPayment.Size = new System.Drawing.Size(253, 32);
            this.tbPayment.TabIndex = 150;
            this.tbPayment.TextChanged += new System.EventHandler(this.tbPayment_TextChanged);
            this.tbPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPayment_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(404, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 149;
            this.label8.Text = "Money";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(45, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 23);
            this.label6.TabIndex = 148;
            this.label6.Text = "Rp";
            // 
            // tbTotalPay
            // 
            this.tbTotalPay.Enabled = false;
            this.tbTotalPay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalPay.Location = new System.Drawing.Point(93, 313);
            this.tbTotalPay.Name = "tbTotalPay";
            this.tbTotalPay.Size = new System.Drawing.Size(253, 32);
            this.tbTotalPay.TabIndex = 147;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 23);
            this.label5.TabIndex = 146;
            this.label5.Text = "Total Payment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(404, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 23);
            this.label4.TabIndex = 145;
            this.label4.Text = "Expired Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 23);
            this.label3.TabIndex = 143;
            this.label3.Text = "Member Type";
            // 
            // cbMemberType
            // 
            this.cbMemberType.DataSource = this.tblTipeMemberBindingSource;
            this.cbMemberType.DisplayMember = "jenis_member";
            this.cbMemberType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMemberType.FormattingEnabled = true;
            this.cbMemberType.Location = new System.Drawing.Point(51, 196);
            this.cbMemberType.Name = "cbMemberType";
            this.cbMemberType.Size = new System.Drawing.Size(295, 31);
            this.cbMemberType.TabIndex = 142;
            this.cbMemberType.ValueMember = "id_member";
            this.cbMemberType.SelectedIndexChanged += new System.EventHandler(this.cbMemberType_SelectedIndexChanged);
            // 
            // tblTipeMemberBindingSource
            // 
            this.tblTipeMemberBindingSource.DataMember = "tblTipeMember";
            this.tblTipeMemberBindingSource.DataSource = this.pRG2_KEL09DataSet1;
            // 
            // pRG2_KEL09DataSet1
            // 
            this.pRG2_KEL09DataSet1.DataSetName = "PRG2_KEL09DataSet1";
            this.pRG2_KEL09DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.caribtn.Location = new System.Drawing.Point(710, 91);
            this.caribtn.Margin = new System.Windows.Forms.Padding(4);
            this.caribtn.Name = "caribtn";
            this.caribtn.Size = new System.Drawing.Size(59, 42);
            this.caribtn.TabIndex = 141;
            this.caribtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.caribtn.UseVisualStyleBackColor = false;
            this.caribtn.Click += new System.EventHandler(this.caribtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(404, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 139;
            this.label1.Text = "Name";
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerID.Location = new System.Drawing.Point(51, 96);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(295, 32);
            this.tbCustomerID.TabIndex = 138;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 136;
            this.label2.Text = "Customer ID";
            // 
            // tblTipeMemberTableAdapter
            // 
            this.tblTipeMemberTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(23, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(650, 455);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(820, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 573);
            this.panel2.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(241, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 40);
            this.label11.TabIndex = 140;
            this.label11.Text = "Member List";
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.pRG2_KEL09DataSet1;
            // 
            // tblCustomerTableAdapter
            // 
            this.tblCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // cbCustomerName
            // 
            this.cbCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCustomerName.DataSource = this.tblCustomerBindingSource1;
            this.cbCustomerName.DisplayMember = "nama";
            this.cbCustomerName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomerName.FormattingEnabled = true;
            this.cbCustomerName.Location = new System.Drawing.Point(408, 97);
            this.cbCustomerName.Name = "cbCustomerName";
            this.cbCustomerName.Size = new System.Drawing.Size(295, 31);
            this.cbCustomerName.TabIndex = 160;
            this.cbCustomerName.ValueMember = "id_customer";
            this.cbCustomerName.SelectionChangeCommitted += new System.EventHandler(this.cbCustomerName_SelectionChangeCommitted);
            this.cbCustomerName.Click += new System.EventHandler(this.cbCustomerName_Click);
            this.cbCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCustomerName_KeyDown);
            // 
            // tblCustomerBindingSource1
            // 
            this.tblCustomerBindingSource1.DataMember = "tblCustomer";
            this.tblCustomerBindingSource1.DataSource = this.pRG2_KEL09DataSet1;
            // 
            // TransaksiMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1538, 619);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransaksiMember";
            this.Text = "Member Transaction";
            this.Load += new System.EventHandler(this.TransaksiMember_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipeMemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL09DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbKembalian;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTotalPay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMemberType;
        private FontAwesome.Sharp.IconButton caribtn;
        private System.Windows.Forms.TextBox tbExpired;
        private ns1.BunifuThinButton2 btSave;
        private ns1.BunifuThinButton2 btClear;
        private PRG2_KEL09DataSet1 pRG2_KEL09DataSet1;
        private System.Windows.Forms.BindingSource tblTipeMemberBindingSource;
        private PRG2_KEL09DataSet1TableAdapters.tblTipeMemberTableAdapter tblTipeMemberTableAdapter;
        private ns1.BunifuCustomDataGrid dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private PRG2_KEL09DataSet1TableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter;
        private System.Windows.Forms.ComboBox cbCustomerName;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource1;
    }
}