namespace D_Shoes
{
    partial class ManagerMenu
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btHome = new FontAwesome.Sharp.IconButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btLogout = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconbtPerson = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btCourierTsReport = new FontAwesome.Sharp.IconButton();
            this.btSuplierTsReport = new FontAwesome.Sharp.IconButton();
            this.bCustTsReport = new FontAwesome.Sharp.IconButton();
            this.btEmpType = new FontAwesome.Sharp.IconButton();
            this.btEmployee = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(339, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 494);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::D_Shoes.Properties.Resources.d_shoes__8_;
            this.pictureBox2.Image = global::D_Shoes.Properties.Resources.d_shoes__8_;
            this.pictureBox2.Location = new System.Drawing.Point(573, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 289);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 134;
            this.pictureBox2.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panelTitleBar.Controls.Add(this.btHome);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Controls.Add(this.btLogout);
            this.panelTitleBar.Location = new System.Drawing.Point(339, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1032, 153);
            this.panelTitleBar.TabIndex = 5;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btHome
            // 
            this.btHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.btHome.IconColor = System.Drawing.Color.White;
            this.btHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btHome.IconSize = 60;
            this.btHome.Location = new System.Drawing.Point(814, 53);
            this.btHome.Name = "btHome";
            this.btHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btHome.Size = new System.Drawing.Size(85, 66);
            this.btHome.TabIndex = 4;
            this.btHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(183, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(667, 94);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "MANAGER MENU";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLogout
            // 
            this.btLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLogout.FlatAppearance.BorderSize = 0;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.ForeColor = System.Drawing.Color.White;
            this.btLogout.IconChar = FontAwesome.Sharp.IconChar.ShareSquare;
            this.btLogout.IconColor = System.Drawing.Color.White;
            this.btLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btLogout.IconSize = 60;
            this.btLogout.Location = new System.Drawing.Point(909, 53);
            this.btLogout.Name = "btLogout";
            this.btLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btLogout.Size = new System.Drawing.Size(85, 66);
            this.btLogout.TabIndex = 3;
            this.btLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.panel2.Controls.Add(this.iconbtPerson);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 153);
            this.panel2.TabIndex = 5;
            // 
            // iconbtPerson
            // 
            this.iconbtPerson.FlatAppearance.BorderSize = 0;
            this.iconbtPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtPerson.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtPerson.ForeColor = System.Drawing.Color.White;
            this.iconbtPerson.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconbtPerson.IconColor = System.Drawing.Color.White;
            this.iconbtPerson.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtPerson.IconSize = 100;
            this.iconbtPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtPerson.Location = new System.Drawing.Point(3, -3);
            this.iconbtPerson.Name = "iconbtPerson";
            this.iconbtPerson.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconbtPerson.Size = new System.Drawing.Size(606, 153);
            this.iconbtPerson.TabIndex = 2;
            this.iconbtPerson.Text = "Manager";
            this.iconbtPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtPerson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtPerson.UseVisualStyleBackColor = true;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.panelMenu.Controls.Add(this.btCourierTsReport);
            this.panelMenu.Controls.Add(this.btSuplierTsReport);
            this.panelMenu.Controls.Add(this.bCustTsReport);
            this.panelMenu.Controls.Add(this.btEmpType);
            this.panelMenu.Controls.Add(this.btEmployee);
            this.panelMenu.Location = new System.Drawing.Point(0, 153);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(341, 713);
            this.panelMenu.TabIndex = 4;
            // 
            // btCourierTsReport
            // 
            this.btCourierTsReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCourierTsReport.FlatAppearance.BorderSize = 0;
            this.btCourierTsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCourierTsReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCourierTsReport.ForeColor = System.Drawing.Color.White;
            this.btCourierTsReport.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.btCourierTsReport.IconColor = System.Drawing.Color.White;
            this.btCourierTsReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btCourierTsReport.IconSize = 60;
            this.btCourierTsReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCourierTsReport.Location = new System.Drawing.Point(0, 496);
            this.btCourierTsReport.Name = "btCourierTsReport";
            this.btCourierTsReport.Padding = new System.Windows.Forms.Padding(10, 20, 20, 0);
            this.btCourierTsReport.Size = new System.Drawing.Size(341, 124);
            this.btCourierTsReport.TabIndex = 11;
            this.btCourierTsReport.Text = "Member Transaction Report";
            this.btCourierTsReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCourierTsReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCourierTsReport.UseVisualStyleBackColor = true;
            this.btCourierTsReport.Click += new System.EventHandler(this.btCourierTsReport_Click);
            // 
            // btSuplierTsReport
            // 
            this.btSuplierTsReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSuplierTsReport.FlatAppearance.BorderSize = 0;
            this.btSuplierTsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuplierTsReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuplierTsReport.ForeColor = System.Drawing.Color.White;
            this.btSuplierTsReport.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.btSuplierTsReport.IconColor = System.Drawing.Color.White;
            this.btSuplierTsReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btSuplierTsReport.IconSize = 60;
            this.btSuplierTsReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSuplierTsReport.Location = new System.Drawing.Point(0, 372);
            this.btSuplierTsReport.Name = "btSuplierTsReport";
            this.btSuplierTsReport.Padding = new System.Windows.Forms.Padding(10, 20, 20, 0);
            this.btSuplierTsReport.Size = new System.Drawing.Size(341, 124);
            this.btSuplierTsReport.TabIndex = 10;
            this.btSuplierTsReport.Text = "Supplier Transaction Report";
            this.btSuplierTsReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSuplierTsReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSuplierTsReport.UseVisualStyleBackColor = true;
            this.btSuplierTsReport.Click += new System.EventHandler(this.btSuplierTsReport_Click);
            // 
            // bCustTsReport
            // 
            this.bCustTsReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.bCustTsReport.FlatAppearance.BorderSize = 0;
            this.bCustTsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCustTsReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCustTsReport.ForeColor = System.Drawing.Color.White;
            this.bCustTsReport.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.bCustTsReport.IconColor = System.Drawing.Color.White;
            this.bCustTsReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bCustTsReport.IconSize = 60;
            this.bCustTsReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCustTsReport.Location = new System.Drawing.Point(0, 248);
            this.bCustTsReport.Name = "bCustTsReport";
            this.bCustTsReport.Padding = new System.Windows.Forms.Padding(10, 20, 20, 0);
            this.bCustTsReport.Size = new System.Drawing.Size(341, 124);
            this.bCustTsReport.TabIndex = 9;
            this.bCustTsReport.Text = "Customer Transaction Report";
            this.bCustTsReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCustTsReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bCustTsReport.UseVisualStyleBackColor = true;
            this.bCustTsReport.Click += new System.EventHandler(this.bCustTsReport_Click);
            // 
            // btEmpType
            // 
            this.btEmpType.Dock = System.Windows.Forms.DockStyle.Top;
            this.btEmpType.FlatAppearance.BorderSize = 0;
            this.btEmpType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmpType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmpType.ForeColor = System.Drawing.Color.White;
            this.btEmpType.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btEmpType.IconColor = System.Drawing.Color.White;
            this.btEmpType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btEmpType.IconSize = 60;
            this.btEmpType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEmpType.Location = new System.Drawing.Point(0, 124);
            this.btEmpType.Name = "btEmpType";
            this.btEmpType.Padding = new System.Windows.Forms.Padding(10, 20, 20, 0);
            this.btEmpType.Size = new System.Drawing.Size(341, 124);
            this.btEmpType.TabIndex = 8;
            this.btEmpType.Text = "Role";
            this.btEmpType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEmpType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEmpType.UseVisualStyleBackColor = true;
            this.btEmpType.Click += new System.EventHandler(this.btEmpType_Click);
            // 
            // btEmployee
            // 
            this.btEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btEmployee.FlatAppearance.BorderSize = 0;
            this.btEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmployee.ForeColor = System.Drawing.Color.White;
            this.btEmployee.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btEmployee.IconColor = System.Drawing.Color.White;
            this.btEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btEmployee.IconSize = 60;
            this.btEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEmployee.Location = new System.Drawing.Point(0, 0);
            this.btEmployee.Name = "btEmployee";
            this.btEmployee.Padding = new System.Windows.Forms.Padding(10, 20, 20, 0);
            this.btEmployee.Size = new System.Drawing.Size(341, 124);
            this.btEmployee.TabIndex = 7;
            this.btEmployee.Text = "Employee";
            this.btEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEmployee.UseVisualStyleBackColor = true;
            this.btEmployee.Click += new System.EventHandler(this.btEmployee_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.pictureBox1.Image = global::D_Shoes.Properties.Resources.Vector_1;
            this.pictureBox1.Location = new System.Drawing.Point(339, 645);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1032, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 866);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerMenu";
            this.Text = "ManagerMenu";
            this.Load += new System.EventHandler(this.ManagerMenu_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconbtPerson;
        private FontAwesome.Sharp.IconButton btHome;
        private FontAwesome.Sharp.IconButton btLogout;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btEmployee;
        private FontAwesome.Sharp.IconButton btCourierTsReport;
        private FontAwesome.Sharp.IconButton btSuplierTsReport;
        private FontAwesome.Sharp.IconButton bCustTsReport;
        private FontAwesome.Sharp.IconButton btEmpType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}