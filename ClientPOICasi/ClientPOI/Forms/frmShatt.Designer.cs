namespace ClientPOI.Forms
{
    partial class frmShatt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShatt));
            this.lb_User = new System.Windows.Forms.Label();
            this.lb_User2 = new System.Windows.Forms.Label();
            this.bttnEmoticon = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.rTBChat = new System.Windows.Forms.RichTextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.PICPLAY_CHAT = new System.Windows.Forms.PictureBox();
            this.PICCAM_CHAT = new System.Windows.Forms.PictureBox();
            this.PICBUZZ = new System.Windows.Forms.PictureBox();
            this.checkEnc = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PICPLAY_CHAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICCAM_CHAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICBUZZ)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Font = new System.Drawing.Font("Architects Daughter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_User.Location = new System.Drawing.Point(391, 337);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(114, 36);
            this.lb_User.TabIndex = 29;
            this.lb_User.Text = "USUARIO";
            this.lb_User.Click += new System.EventHandler(this.lb_User_Click);
            // 
            // lb_User2
            // 
            this.lb_User2.AutoSize = true;
            this.lb_User2.Font = new System.Drawing.Font("Architects Daughter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_User2.Location = new System.Drawing.Point(391, 29);
            this.lb_User2.Name = "lb_User2";
            this.lb_User2.Size = new System.Drawing.Size(298, 36);
            this.lb_User2.TabIndex = 28;
            this.lb_User2.Text = "Nombre Grupo/Usuario2";
            this.lb_User2.Click += new System.EventHandler(this.lb_User2_Click);
            // 
            // bttnEmoticon
            // 
            this.bttnEmoticon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.bttnEmoticon.Font = new System.Drawing.Font("Architects Daughter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEmoticon.Location = new System.Drawing.Point(420, 470);
            this.bttnEmoticon.Margin = new System.Windows.Forms.Padding(4);
            this.bttnEmoticon.Name = "bttnEmoticon";
            this.bttnEmoticon.Size = new System.Drawing.Size(103, 40);
            this.bttnEmoticon.TabIndex = 25;
            this.bttnEmoticon.Text = "EMOJI";
            this.bttnEmoticon.UseVisualStyleBackColor = false;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.Font = new System.Drawing.Font("Architects Daughter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(300, 470);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 42);
            this.btnSend.TabIndex = 23;
            this.btnSend.Text = "OK!";
            this.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rTBChat
            // 
            this.rTBChat.BackColor = System.Drawing.Color.White;
            this.rTBChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTBChat.Font = new System.Drawing.Font("Architects Daughter", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBChat.Location = new System.Drawing.Point(23, 29);
            this.rTBChat.Margin = new System.Windows.Forms.Padding(4);
            this.rTBChat.Name = "rTBChat";
            this.rTBChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rTBChat.Size = new System.Drawing.Size(361, 390);
            this.rTBChat.TabIndex = 22;
            this.rTBChat.Text = "";
            this.rTBChat.TextChanged += new System.EventHandler(this.rTBChat_TextChanged);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.White;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Font = new System.Drawing.Font("Architects Daughter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(23, 470);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(268, 42);
            this.txtMessage.TabIndex = 21;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // PICPLAY_CHAT
            // 
            this.PICPLAY_CHAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.PICPLAY_CHAT.Image = global::ClientPOI.Properties.Resources.play;
            this.PICPLAY_CHAT.Location = new System.Drawing.Point(420, 375);
            this.PICPLAY_CHAT.Name = "PICPLAY_CHAT";
            this.PICPLAY_CHAT.Size = new System.Drawing.Size(70, 62);
            this.PICPLAY_CHAT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PICPLAY_CHAT.TabIndex = 27;
            this.PICPLAY_CHAT.TabStop = false;
            this.PICPLAY_CHAT.Click += new System.EventHandler(this.PICPLAY_CHAT_Click);
            // 
            // PICCAM_CHAT
            // 
            this.PICCAM_CHAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.PICCAM_CHAT.Image = global::ClientPOI.Properties.Resources.video;
            this.PICCAM_CHAT.Location = new System.Drawing.Point(496, 375);
            this.PICCAM_CHAT.Name = "PICCAM_CHAT";
            this.PICCAM_CHAT.Size = new System.Drawing.Size(89, 74);
            this.PICCAM_CHAT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PICCAM_CHAT.TabIndex = 26;
            this.PICCAM_CHAT.TabStop = false;
            this.PICCAM_CHAT.Click += new System.EventHandler(this.PICCAM_CHAT_Click);
            // 
            // PICBUZZ
            // 
            this.PICBUZZ.Image = ((System.Drawing.Image)(resources.GetObject("PICBUZZ.Image")));
            this.PICBUZZ.Location = new System.Drawing.Point(591, 375);
            this.PICBUZZ.Name = "PICBUZZ";
            this.PICBUZZ.Size = new System.Drawing.Size(67, 74);
            this.PICBUZZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PICBUZZ.TabIndex = 30;
            this.PICBUZZ.TabStop = false;
            this.PICBUZZ.Click += new System.EventHandler(this.PICBUZZ_Click);
            // 
            // checkEnc
            // 
            this.checkEnc.AutoSize = true;
            this.checkEnc.Font = new System.Drawing.Font("Architects Daughter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEnc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkEnc.Location = new System.Drawing.Point(530, 474);
            this.checkEnc.Name = "checkEnc";
            this.checkEnc.Size = new System.Drawing.Size(164, 34);
            this.checkEnc.TabIndex = 31;
            this.checkEnc.Text = "¿Encriptado?";
            this.checkEnc.UseVisualStyleBackColor = true;
            // 
            // frmShatt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(690, 540);
            this.Controls.Add(this.checkEnc);
            this.Controls.Add(this.PICBUZZ);
            this.Controls.Add(this.lb_User);
            this.Controls.Add(this.lb_User2);
            this.Controls.Add(this.PICPLAY_CHAT);
            this.Controls.Add(this.PICCAM_CHAT);
            this.Controls.Add(this.bttnEmoticon);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rTBChat);
            this.Controls.Add(this.txtMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShatt";
            this.Text = "CHAT";
            this.Load += new System.EventHandler(this.frmShatt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PICPLAY_CHAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICCAM_CHAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICBUZZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_User;
        public System.Windows.Forms.Label lb_User2;
        private System.Windows.Forms.PictureBox PICPLAY_CHAT;
        private System.Windows.Forms.PictureBox PICCAM_CHAT;
        private System.Windows.Forms.Button bttnEmoticon;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rTBChat;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.PictureBox PICBUZZ;
        private System.Windows.Forms.CheckBox checkEnc;
    }
}