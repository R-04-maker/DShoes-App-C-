namespace D_Shoes.Master
{
    partial class CRUDGaransi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDGaransi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new ns1.BunifuCustomDataGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btRefresh = new ns1.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGuarantyDesc = new ns1.BunifuMaterialTextbox();
            this.btDelete = new ns1.BunifuThinButton2();
            this.btUpdate = new ns1.BunifuThinButton2();
            this.btSave = new ns1.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGuarantyType = new ns1.BunifuMaterialTextbox();
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
            this.panel1.Location = new System.Drawing.Point(528, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 685);
            this.panel1.TabIndex = 12;
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(36, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(886, 504);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.btRefresh);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbGuarantyDesc);
            this.panel2.Controls.Add(this.btDelete);
            this.panel2.Controls.Add(this.btUpdate);
            this.panel2.Controls.Add(this.btSave);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbGuarantyType);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(90, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 685);
            this.panel2.TabIndex = 13;
            // 
            // btRefresh
            // 
            this.btRefresh.ActiveBorderThickness = 1;
            this.btRefresh.ActiveCornerRadius = 20;
            this.btRefresh.ActiveFillColor = System.Drawing.Color.White;
            this.btRefresh.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btRefresh.ActiveLineColor = System.Drawing.Color.White;
            this.btRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRefresh.BackgroundImage")));
            this.btRefresh.ButtonText = "Cancel";
            this.btRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRefresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.ForeColor = System.Drawing.Color.White;
            this.btRefresh.IdleBorderThickness = 1;
            this.btRefresh.IdleCornerRadius = 20;
            this.btRefresh.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btRefresh.IdleForecolor = System.Drawing.Color.White;
            this.btRefresh.IdleLineColor = System.Drawing.Color.White;
            this.btRefresh.Location = new System.Drawing.Point(160, 508);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(119, 56);
            this.btRefresh.TabIndex = 102;
            this.btRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 97;
            this.label1.Text = "Description";
            // 
            // tbGuarantyDesc
            // 
            this.tbGuarantyDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGuarantyDesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGuarantyDesc.ForeColor = System.Drawing.Color.White;
            this.tbGuarantyDesc.HintForeColor = System.Drawing.Color.White;
            this.tbGuarantyDesc.HintText = "";
            this.tbGuarantyDesc.isPassword = false;
            this.tbGuarantyDesc.LineFocusedColor = System.Drawing.Color.White;
            this.tbGuarantyDesc.LineIdleColor = System.Drawing.Color.White;
            this.tbGuarantyDesc.LineMouseHoverColor = System.Drawing.Color.White;
            this.tbGuarantyDesc.LineThickness = 3;
            this.tbGuarantyDesc.Location = new System.Drawing.Point(23, 290);
            this.tbGuarantyDesc.Margin = new System.Windows.Forms.Padding(4);
            this.tbGuarantyDesc.Name = "tbGuarantyDesc";
            this.tbGuarantyDesc.Size = new System.Drawing.Size(387, 53);
            this.tbGuarantyDesc.TabIndex = 96;
            this.tbGuarantyDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btDelete.Location = new System.Drawing.Point(291, 442);
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
            this.btUpdate.Location = new System.Drawing.Point(160, 442);
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
            this.btSave.Location = new System.Drawing.Point(23, 442);
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
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Warranty Type";
            // 
            // tbGuarantyType
            // 
            this.tbGuarantyType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGuarantyType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGuarantyType.ForeColor = System.Drawing.Color.White;
            this.tbGuarantyType.HintForeColor = System.Drawing.Color.White;
            this.tbGuarantyType.HintText = "";
            this.tbGuarantyType.isPassword = false;
            this.tbGuarantyType.LineFocusedColor = System.Drawing.Color.White;
            this.tbGuarantyType.LineIdleColor = System.Drawing.Color.White;
            this.tbGuarantyType.LineMouseHoverColor = System.Drawing.Color.White;
            this.tbGuarantyType.LineThickness = 3;
            this.tbGuarantyType.Location = new System.Drawing.Point(23, 174);
            this.tbGuarantyType.Margin = new System.Windows.Forms.Padding(4);
            this.tbGuarantyType.Name = "tbGuarantyType";
            this.tbGuarantyType.Size = new System.Drawing.Size(387, 53);
            this.tbGuarantyType.TabIndex = 5;
            this.tbGuarantyType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CRUDGaransi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1619, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDGaransi";
            this.Text = "Manage Guaranty";
            this.Load += new System.EventHandler(this.CRUDEkpedisi_Load);
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
        private ns1.BunifuMaterialTextbox tbGuarantyType;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuMaterialTextbox tbGuarantyDesc;
        private ns1.BunifuThinButton2 btRefresh;
    }
}