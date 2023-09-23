namespace D_Shoes.Menu
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closebtn = new FontAwesome.Sharp.IconPictureBox();
            this.btExit = new ns1.BunifuThinButton2();
            this.cbPw = new System.Windows.Forms.CheckBox();
            this.btLogin = new ns1.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new ns1.BunifuMaterialTextbox();
            this.txtUsername = new ns1.BunifuMaterialTextbox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 631);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 240);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.closebtn);
            this.panel2.Controls.Add(this.btExit);
            this.panel2.Controls.Add(this.cbPw);
            this.panel2.Controls.Add(this.btLogin);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(723, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 631);
            this.panel2.TabIndex = 0;
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.closebtn.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.closebtn.IconColor = System.Drawing.Color.White;
            this.closebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closebtn.IconSize = 46;
            this.closebtn.Location = new System.Drawing.Point(408, 0);
            this.closebtn.Margin = new System.Windows.Forms.Padding(4);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(46, 48);
            this.closebtn.TabIndex = 103;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click_1);
            // 
            // btExit
            // 
            this.btExit.ActiveBorderThickness = 1;
            this.btExit.ActiveCornerRadius = 20;
            this.btExit.ActiveFillColor = System.Drawing.Color.Gray;
            this.btExit.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.btExit.ActiveLineColor = System.Drawing.Color.White;
            this.btExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.btExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btExit.BackgroundImage")));
            this.btExit.ButtonText = "Exit";
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.IdleBorderThickness = 1;
            this.btExit.IdleCornerRadius = 20;
            this.btExit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btExit.IdleForecolor = System.Drawing.Color.White;
            this.btExit.IdleLineColor = System.Drawing.Color.White;
            this.btExit.Location = new System.Drawing.Point(261, 458);
            this.btExit.Margin = new System.Windows.Forms.Padding(5);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(132, 54);
            this.btExit.TabIndex = 5;
            this.btExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btExit.Click += new System.EventHandler(this.btExit_Click_1);
            // 
            // cbPw
            // 
            this.cbPw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPw.AutoSize = true;
            this.cbPw.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPw.ForeColor = System.Drawing.Color.White;
            this.cbPw.Location = new System.Drawing.Point(88, 389);
            this.cbPw.Margin = new System.Windows.Forms.Padding(4);
            this.cbPw.Name = "cbPw";
            this.cbPw.Size = new System.Drawing.Size(158, 25);
            this.cbPw.TabIndex = 3;
            this.cbPw.Text = "Show Password";
            this.cbPw.UseVisualStyleBackColor = true;
            this.cbPw.CheckedChanged += new System.EventHandler(this.cbPw_CheckedChanged_1);
            // 
            // btLogin
            // 
            this.btLogin.ActiveBorderThickness = 1;
            this.btLogin.ActiveCornerRadius = 20;
            this.btLogin.ActiveFillColor = System.Drawing.Color.Gray;
            this.btLogin.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.btLogin.ActiveLineColor = System.Drawing.Color.White;
            this.btLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.btLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btLogin.BackgroundImage")));
            this.btLogin.ButtonText = "Log In";
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.IdleBorderThickness = 1;
            this.btLogin.IdleCornerRadius = 20;
            this.btLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btLogin.IdleForecolor = System.Drawing.Color.White;
            this.btLogin.IdleLineColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(56, 458);
            this.btLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(132, 54);
            this.btLogin.TabIndex = 4;
            this.btLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login Your Account !";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HintForeColor = System.Drawing.Color.White;
            this.txtPassword.HintText = "";
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.White;
            this.txtPassword.LineIdleColor = System.Drawing.Color.White;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(88, 332);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(282, 49);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter_1);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.HintForeColor = System.Drawing.Color.White;
            this.txtUsername.HintText = "";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.White;
            this.txtUsername.LineIdleColor = System.Drawing.Color.White;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtUsername.LineThickness = 3;
            this.txtUsername.Location = new System.Drawing.Point(88, 252);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(282, 50);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(723, 391);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 631);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuThinButton2 btExit;
        private System.Windows.Forms.CheckBox cbPw;
        private ns1.BunifuThinButton2 btLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuMaterialTextbox txtPassword;
        private ns1.BunifuMaterialTextbox txtUsername;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox closebtn;
        private System.Windows.Forms.Panel panel4;
    }
}