namespace D_Shoes.Master
{
    partial class CRUDTipePembayaran
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDTipePembayaran));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new ns1.BunifuCustomDataGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaymentNumber = new ns1.BunifuMaterialTextbox();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.btDelete = new ns1.BunifuThinButton2();
            this.btUpdate = new ns1.BunifuThinButton2();
            this.btSave = new ns1.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJenisPemb = new ns1.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(535, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 685);
            this.panel1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.dataGridView1.Location = new System.Drawing.Point(45, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(662, 504);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtPaymentNumber);
            this.panel2.Controls.Add(this.bunifuThinButton21);
            this.panel2.Controls.Add(this.btDelete);
            this.panel2.Controls.Add(this.btUpdate);
            this.panel2.Controls.Add(this.btSave);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtJenisPemb);
            this.panel2.Location = new System.Drawing.Point(78, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 685);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 102;
            this.label1.Text = "Payment Number";
            // 
            // txtPaymentNumber
            // 
            this.txtPaymentNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaymentNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPaymentNumber.ForeColor = System.Drawing.Color.White;
            this.txtPaymentNumber.HintForeColor = System.Drawing.Color.White;
            this.txtPaymentNumber.HintText = "";
            this.txtPaymentNumber.isPassword = false;
            this.txtPaymentNumber.LineFocusedColor = System.Drawing.Color.White;
            this.txtPaymentNumber.LineIdleColor = System.Drawing.Color.White;
            this.txtPaymentNumber.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtPaymentNumber.LineThickness = 3;
            this.txtPaymentNumber.Location = new System.Drawing.Point(23, 283);
            this.txtPaymentNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentNumber.Name = "txtPaymentNumber";
            this.txtPaymentNumber.Size = new System.Drawing.Size(273, 53);
            this.txtPaymentNumber.TabIndex = 101;
            this.txtPaymentNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPaymentNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaymentNumber_KeyPress);
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
            this.bunifuThinButton21.Location = new System.Drawing.Point(160, 443);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(119, 56);
            this.bunifuThinButton21.TabIndex = 100;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
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
            this.btDelete.Location = new System.Drawing.Point(291, 389);
            this.btDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(119, 56);
            this.btDelete.TabIndex = 95;
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
            this.btUpdate.Location = new System.Drawing.Point(160, 389);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(119, 56);
            this.btUpdate.TabIndex = 94;
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
            this.btSave.Location = new System.Drawing.Point(23, 389);
            this.btSave.Margin = new System.Windows.Forms.Padding(5);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(119, 56);
            this.btSave.TabIndex = 93;
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Payment Method";
            // 
            // txtJenisPemb
            // 
            this.txtJenisPemb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJenisPemb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtJenisPemb.ForeColor = System.Drawing.Color.White;
            this.txtJenisPemb.HintForeColor = System.Drawing.Color.White;
            this.txtJenisPemb.HintText = "";
            this.txtJenisPemb.isPassword = false;
            this.txtJenisPemb.LineFocusedColor = System.Drawing.Color.White;
            this.txtJenisPemb.LineIdleColor = System.Drawing.Color.White;
            this.txtJenisPemb.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtJenisPemb.LineThickness = 3;
            this.txtJenisPemb.Location = new System.Drawing.Point(23, 182);
            this.txtJenisPemb.Margin = new System.Windows.Forms.Padding(4);
            this.txtJenisPemb.Name = "txtJenisPemb";
            this.txtJenisPemb.Size = new System.Drawing.Size(273, 53);
            this.txtJenisPemb.TabIndex = 5;
            this.txtJenisPemb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CRUDTipePembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1364, 791);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDTipePembayaran";
            this.Text = "Manage Payment Method";
            this.Load += new System.EventHandler(this.CRUDTipePembayaran_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuCustomDataGrid dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuThinButton2 btDelete;
        private ns1.BunifuThinButton2 btUpdate;
        private ns1.BunifuThinButton2 btSave;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuMaterialTextbox txtJenisPemb;
        private ns1.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuMaterialTextbox txtPaymentNumber;
    }
}