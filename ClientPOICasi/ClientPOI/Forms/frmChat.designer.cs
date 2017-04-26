namespace ClientPOI
{
    partial class frmChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChat));
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.rTBChat = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.bttnExitChat = new System.Windows.Forms.Button();
            this.bttnEmoticon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PICPLAY_CHAT = new System.Windows.Forms.PictureBox();
            this.PICCAM_CHAT = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICPLAY_CHAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICCAM_CHAT)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.White;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Font = new System.Drawing.Font("Architects Daughter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(23, 454);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(390, 42);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // rTBChat
            // 
            this.rTBChat.BackColor = System.Drawing.Color.White;
            this.rTBChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTBChat.Font = new System.Drawing.Font("Architects Daughter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBChat.Location = new System.Drawing.Point(23, 13);
            this.rTBChat.Margin = new System.Windows.Forms.Padding(4);
            this.rTBChat.Name = "rTBChat";
            this.rTBChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rTBChat.Size = new System.Drawing.Size(482, 390);
            this.rTBChat.TabIndex = 3;
            this.rTBChat.Text = "";
            this.rTBChat.TextChanged += new System.EventHandler(this.rTBChat_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.Font = new System.Drawing.Font("Architects Daughter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(421, 454);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 42);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "OK!";
            this.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // bttnExitChat
            // 
            this.bttnExitChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(27)))));
            this.bttnExitChat.Font = new System.Drawing.Font("Architects Daughter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExitChat.Location = new System.Drawing.Point(596, 503);
            this.bttnExitChat.Margin = new System.Windows.Forms.Padding(4);
            this.bttnExitChat.Name = "bttnExitChat";
            this.bttnExitChat.Size = new System.Drawing.Size(103, 51);
            this.bttnExitChat.TabIndex = 10;
            this.bttnExitChat.Text = "SALIR";
            this.bttnExitChat.UseVisualStyleBackColor = false;
            this.bttnExitChat.Click += new System.EventHandler(this.bttnExitChat_Click);
            // 
            // bttnEmoticon
            // 
            this.bttnEmoticon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.bttnEmoticon.Font = new System.Drawing.Font("Architects Daughter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEmoticon.Location = new System.Drawing.Point(23, 411);
            this.bttnEmoticon.Margin = new System.Windows.Forms.Padding(4);
            this.bttnEmoticon.Name = "bttnEmoticon";
            this.bttnEmoticon.Size = new System.Drawing.Size(84, 35);
            this.bttnEmoticon.TabIndex = 12;
            this.bttnEmoticon.Text = "EMOJI";
            this.bttnEmoticon.UseVisualStyleBackColor = false;
            this.bttnEmoticon.Click += new System.EventHandler(this.bttnEmoticon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(559, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 179);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(559, 317);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 179);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // PICPLAY_CHAT
            // 
            this.PICPLAY_CHAT.Image = global::ClientPOI.Properties.Resources.play;
            this.PICPLAY_CHAT.Location = new System.Drawing.Point(543, 197);
            this.PICPLAY_CHAT.Name = "PICPLAY_CHAT";
            this.PICPLAY_CHAT.Size = new System.Drawing.Size(92, 74);
            this.PICPLAY_CHAT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PICPLAY_CHAT.TabIndex = 18;
            this.PICPLAY_CHAT.TabStop = false;
            this.PICPLAY_CHAT.Click += new System.EventHandler(this.PICPLAY_CHAT_Click);
            // 
            // PICCAM_CHAT
            // 
            this.PICCAM_CHAT.Image = global::ClientPOI.Properties.Resources.video;
            this.PICCAM_CHAT.Location = new System.Drawing.Point(655, 191);
            this.PICCAM_CHAT.Name = "PICCAM_CHAT";
            this.PICCAM_CHAT.Size = new System.Drawing.Size(99, 86);
            this.PICCAM_CHAT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PICCAM_CHAT.TabIndex = 17;
            this.PICCAM_CHAT.TabStop = false;
            this.PICCAM_CHAT.Click += new System.EventHandler(this.PICCAM_CHAT_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Architects Daughter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUser.Location = new System.Drawing.Point(612, 274);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(67, 36);
            this.lblUser.TabIndex = 19;
            this.lblUser.Text = "label1";
            // 
            // frmChat
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 590);
            this.ControlBox = false;
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.PICPLAY_CHAT);
            this.Controls.Add(this.PICCAM_CHAT);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttnEmoticon);
            this.Controls.Add(this.bttnExitChat);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rTBChat);
            this.Controls.Add(this.txtMessage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 20);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChat";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHATT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChat_FormClosing);
            this.Load += new System.EventHandler(this.frmChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICPLAY_CHAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICCAM_CHAT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.RichTextBox rTBChat;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button bttnExitChat;
        private System.Windows.Forms.Button bttnEmoticon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PICPLAY_CHAT;
        private System.Windows.Forms.PictureBox PICCAM_CHAT;
        private System.Windows.Forms.Label lblUser;
    }
}