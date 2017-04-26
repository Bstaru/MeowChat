namespace ClientPOI.Forms
{
    partial class frmLogin
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.bttnEnter = new System.Windows.Forms.Button();
            this.chckBxRemeberMe = new System.Windows.Forms.CheckBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbEst = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Window;
            this.txtUser.Font = new System.Drawing.Font("Architects Daughter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(362, 239);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(214, 43);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "Natalie";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.BackColor = System.Drawing.Color.Transparent;
            this.lblServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Location = new System.Drawing.Point(676, 526);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(75, 18);
            this.lblServer.TabIndex = 3;
            this.lblServer.Text = "SERVER";
            this.lblServer.Visible = false;
            this.lblServer.Click += new System.EventHandler(this.lblServer_Click);
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtServer.Location = new System.Drawing.Point(757, 523);
            this.txtServer.Name = "txtServer";
            this.txtServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtServer.Size = new System.Drawing.Size(122, 24);
            this.txtServer.TabIndex = 4;
            this.txtServer.Text = "192.168.43.245";
            this.txtServer.Visible = false;
            this.txtServer.WordWrap = false;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // bttnEnter
            // 
            this.bttnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.bttnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEnter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnEnter.Location = new System.Drawing.Point(383, 441);
            this.bttnEnter.Name = "bttnEnter";
            this.bttnEnter.Size = new System.Drawing.Size(149, 45);
            this.bttnEnter.TabIndex = 11;
            this.bttnEnter.Text = "ENTRAR";
            this.bttnEnter.UseVisualStyleBackColor = false;
            this.bttnEnter.Click += new System.EventHandler(this.bttnEnter_Click);
            // 
            // chckBxRemeberMe
            // 
            this.chckBxRemeberMe.AutoSize = true;
            this.chckBxRemeberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBxRemeberMe.Location = new System.Drawing.Point(417, 338);
            this.chckBxRemeberMe.Name = "chckBxRemeberMe";
            this.chckBxRemeberMe.Size = new System.Drawing.Size(159, 28);
            this.chckBxRemeberMe.TabIndex = 12;
            this.chckBxRemeberMe.Text = "Remember me";
            this.chckBxRemeberMe.UseVisualStyleBackColor = true;
            this.chckBxRemeberMe.CheckedChanged += new System.EventHandler(this.chckBxRemeberMe_CheckedChanged);
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.SystemColors.Window;
            this.txtContra.Font = new System.Drawing.Font("Architects Daughter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(362, 295);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(214, 43);
            this.txtContra.TabIndex = 13;
            this.txtContra.Text = "shineekey";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::ClientPOI.Properties.Resources.u;
            this.pictureBox2.Location = new System.Drawing.Point(256, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(256, 288);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClientPOI.Properties.Resources.meowchat_logo;
            this.pictureBox1.Location = new System.Drawing.Point(292, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // cbEst
            // 
            this.cbEst.Font = new System.Drawing.Font("Architects Daughter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEst.FormattingEnabled = true;
            this.cbEst.Items.AddRange(new object[] {
            "Disponible",
            "Ausente ",
            "Desconectado",
            "Ocupado"});
            this.cbEst.Location = new System.Drawing.Point(362, 372);
            this.cbEst.Name = "cbEst";
            this.cbEst.Size = new System.Drawing.Size(214, 44);
            this.cbEst.TabIndex = 17;
            this.cbEst.Text = "Disponible";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Architects Daughter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(257, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "Estado";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEst);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.chckBxRemeberMe);
            this.Controls.Add(this.bttnEnter);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.txtUser);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button bttnEnter;
        private System.Windows.Forms.CheckBox chckBxRemeberMe;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbEst;
        private System.Windows.Forms.Label label1;
    }
}