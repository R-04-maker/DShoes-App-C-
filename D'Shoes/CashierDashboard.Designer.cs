namespace D_Shoes
{
    partial class CashierDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMemberTrans = new FontAwesome.Sharp.IconButton();
            this.lblSupplierTrans = new FontAwesome.Sharp.IconButton();
            this.lbCustomerTrans = new FontAwesome.Sharp.IconButton();
            this.lbEmployee = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoesSalesbyCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRG2_KEL09DataSet3 = new D_Shoes.PRG2_KEL09DataSet3();
            this.shoesSalesbyCategoryTableAdapter = new D_Shoes.PRG2_KEL09DataSet3TableAdapters.ShoesSalesbyCategoryTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoesSalesbyCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL09DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pieChart1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblMemberTrans);
            this.panel1.Controls.Add(this.lblSupplierTrans);
            this.panel1.Controls.Add(this.lbCustomerTrans);
            this.panel1.Controls.Add(this.lbEmployee);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(104, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 612);
            this.panel1.TabIndex = 1;
            // 
            // pieChart1
            // 
            this.pieChart1.BackColor = System.Drawing.Color.White;
            this.pieChart1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pieChart1.Location = new System.Drawing.Point(780, 136);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(441, 340);
            this.pieChart1.TabIndex = 17;
            this.pieChart1.Text = "pieChart1";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(367, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 39);
            this.label4.TabIndex = 16;
            this.label4.Text = "Member Transaction";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 39);
            this.label3.TabIndex = 15;
            this.label3.Text = "Supplier Transaction";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(367, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 39);
            this.label2.TabIndex = 14;
            this.label2.Text = "Customer Transaction";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Employee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMemberTrans
            // 
            this.lblMemberTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.lblMemberTrans.FlatAppearance.BorderSize = 2;
            this.lblMemberTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMemberTrans.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberTrans.ForeColor = System.Drawing.Color.White;
            this.lblMemberTrans.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.lblMemberTrans.IconColor = System.Drawing.Color.White;
            this.lblMemberTrans.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lblMemberTrans.IconSize = 80;
            this.lblMemberTrans.Location = new System.Drawing.Point(367, 315);
            this.lblMemberTrans.Name = "lblMemberTrans";
            this.lblMemberTrans.Size = new System.Drawing.Size(322, 217);
            this.lblMemberTrans.TabIndex = 8;
            this.lblMemberTrans.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMemberTrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lblMemberTrans.UseVisualStyleBackColor = false;
            // 
            // lblSupplierTrans
            // 
            this.lblSupplierTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.lblSupplierTrans.FlatAppearance.BorderSize = 2;
            this.lblSupplierTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSupplierTrans.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierTrans.ForeColor = System.Drawing.Color.White;
            this.lblSupplierTrans.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry;
            this.lblSupplierTrans.IconColor = System.Drawing.Color.White;
            this.lblSupplierTrans.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lblSupplierTrans.IconSize = 80;
            this.lblSupplierTrans.Location = new System.Drawing.Point(23, 315);
            this.lblSupplierTrans.Name = "lblSupplierTrans";
            this.lblSupplierTrans.Size = new System.Drawing.Size(322, 217);
            this.lblSupplierTrans.TabIndex = 7;
            this.lblSupplierTrans.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSupplierTrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lblSupplierTrans.UseVisualStyleBackColor = false;
            this.lblSupplierTrans.Click += new System.EventHandler(this.lblSupplier_Click);
            // 
            // lbCustomerTrans
            // 
            this.lbCustomerTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.lbCustomerTrans.FlatAppearance.BorderSize = 2;
            this.lbCustomerTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCustomerTrans.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerTrans.ForeColor = System.Drawing.Color.White;
            this.lbCustomerTrans.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.lbCustomerTrans.IconColor = System.Drawing.Color.White;
            this.lbCustomerTrans.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lbCustomerTrans.IconSize = 80;
            this.lbCustomerTrans.Location = new System.Drawing.Point(367, 81);
            this.lbCustomerTrans.Name = "lbCustomerTrans";
            this.lbCustomerTrans.Size = new System.Drawing.Size(322, 217);
            this.lbCustomerTrans.TabIndex = 6;
            this.lbCustomerTrans.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbCustomerTrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lbCustomerTrans.UseVisualStyleBackColor = false;
            this.lbCustomerTrans.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // lbEmployee
            // 
            this.lbEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.lbEmployee.FlatAppearance.BorderSize = 2;
            this.lbEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbEmployee.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployee.ForeColor = System.Drawing.Color.White;
            this.lbEmployee.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.lbEmployee.IconColor = System.Drawing.Color.White;
            this.lbEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lbEmployee.IconSize = 80;
            this.lbEmployee.Location = new System.Drawing.Point(23, 81);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(322, 217);
            this.lbEmployee.TabIndex = 5;
            this.lbEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lbEmployee.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shoesSalesbyCategoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1057, 459);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // shoesSalesbyCategoryBindingSource
            // 
            this.shoesSalesbyCategoryBindingSource.DataMember = "ShoesSalesbyCategory";
            this.shoesSalesbyCategoryBindingSource.DataSource = this.pRG2_KEL09DataSet3;
            // 
            // pRG2_KEL09DataSet3
            // 
            this.pRG2_KEL09DataSet3.DataSetName = "PRG2_KEL09DataSet3";
            this.pRG2_KEL09DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shoesSalesbyCategoryTableAdapter
            // 
            this.shoesSalesbyCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(833, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 39);
            this.label5.TabIndex = 19;
            this.label5.Text = "Top Category";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CashierDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1770, 724);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierDashboard";
            this.Text = "Cashier Dashboard";
            this.Load += new System.EventHandler(this.CashierDashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoesSalesbyCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL09DataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton lblMemberTrans;
        private FontAwesome.Sharp.IconButton lblSupplierTrans;
        private FontAwesome.Sharp.IconButton lbCustomerTrans;
        private FontAwesome.Sharp.IconButton lbEmployee;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PRG2_KEL09DataSet3 pRG2_KEL09DataSet3;
        private System.Windows.Forms.BindingSource shoesSalesbyCategoryBindingSource;
        private PRG2_KEL09DataSet3TableAdapters.ShoesSalesbyCategoryTableAdapter shoesSalesbyCategoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
    }
}