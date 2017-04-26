namespace ClientPOI.Forms
{
    partial class frmFriends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFriends));
            this.lvAmigos = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEst2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lvAmigos
            // 
            this.lvAmigos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvAmigos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(95)))), ((int)(((byte)(120)))));
            this.lvAmigos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Estado});
            this.lvAmigos.Font = new System.Drawing.Font("Architects Daughter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAmigos.Location = new System.Drawing.Point(21, 121);
            this.lvAmigos.Name = "lvAmigos";
            this.lvAmigos.Size = new System.Drawing.Size(572, 319);
            this.lvAmigos.TabIndex = 57;
            this.lvAmigos.UseCompatibleStateImageBehavior = false;
            this.lvAmigos.View = System.Windows.Forms.View.Details;
            this.lvAmigos.SelectedIndexChanged += new System.EventHandler(this.lvAmigos_SelectedIndexChanged);
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 181;
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            this.Estado.Width = 384;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.lblUser.Font = new System.Drawing.Font("Architects Daughter", 24F);
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(481, 80);
            this.lblUser.TabIndex = 56;
            this.lblUser.Text = "Amigos";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.pictureBox3.Enabled = false;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(-45, -7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(880, 107);
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.label1.Font = new System.Drawing.Font("Architects Daughter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(261, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 36);
            this.label1.TabIndex = 59;
            this.label1.Text = "Estado";
            // 
            // cbEst2
            // 
            this.cbEst2.Font = new System.Drawing.Font("Architects Daughter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEst2.FormattingEnabled = true;
            this.cbEst2.Items.AddRange(new object[] {
            "Disponible",
            "Ausente ",
            "Desconectado",
            "Ocupado"});
            this.cbEst2.Location = new System.Drawing.Point(366, 31);
            this.cbEst2.Name = "cbEst2";
            this.cbEst2.Size = new System.Drawing.Size(214, 44);
            this.cbEst2.TabIndex = 58;
            // 
            // frmFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(618, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEst2);
            this.Controls.Add(this.lvAmigos);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFriends";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Friends";
            this.Load += new System.EventHandler(this.frmFriends_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAmigos;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEst2;
    }
}