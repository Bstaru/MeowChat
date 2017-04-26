namespace ClientPOI.Forms
{
    partial class frmCorreo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCorreo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.txtToEmail = new System.Windows.Forms.TextBox();
            this.txtAsunEmail = new System.Windows.Forms.TextBox();
            this.txtContenidoEmail = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbArchivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.archivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Architects Daughter", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(48, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Architects Daughter", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(7, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "ASUNTO:";
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.btnSendEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSendEmail.Location = new System.Drawing.Point(593, 434);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(178, 45);
            this.btnSendEmail.TabIndex = 13;
            this.btnSendEmail.Text = "Enviar";
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // txtToEmail
            // 
            this.txtToEmail.Location = new System.Drawing.Point(176, 14);
            this.txtToEmail.Name = "txtToEmail";
            this.txtToEmail.Size = new System.Drawing.Size(524, 38);
            this.txtToEmail.TabIndex = 14;
            // 
            // txtAsunEmail
            // 
            this.txtAsunEmail.Location = new System.Drawing.Point(176, 81);
            this.txtAsunEmail.Name = "txtAsunEmail";
            this.txtAsunEmail.Size = new System.Drawing.Size(524, 38);
            this.txtAsunEmail.TabIndex = 15;
            // 
            // txtContenidoEmail
            // 
            this.txtContenidoEmail.Location = new System.Drawing.Point(25, 230);
            this.txtContenidoEmail.Multiline = true;
            this.txtContenidoEmail.Name = "txtContenidoEmail";
            this.txtContenidoEmail.Size = new System.Drawing.Size(746, 198);
            this.txtContenidoEmail.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbArchivo
            // 
            this.tbArchivo.Location = new System.Drawing.Point(176, 154);
            this.tbArchivo.Name = "tbArchivo";
            this.tbArchivo.Size = new System.Drawing.Size(524, 38);
            this.tbArchivo.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Architects Daughter", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(7, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 50);
            this.label3.TabIndex = 18;
            this.label3.Text = "ARCHIVO:";
            // 
            // archivo
            // 
            this.archivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.archivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.archivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.archivo.Location = new System.Drawing.Point(706, 152);
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(65, 45);
            this.archivo.TabIndex = 19;
            this.archivo.Text = "...";
            this.archivo.UseVisualStyleBackColor = false;
            this.archivo.Click += new System.EventHandler(this.archivo_Click);
            // 
            // frmCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(796, 500);
            this.Controls.Add(this.archivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbArchivo);
            this.Controls.Add(this.txtContenidoEmail);
            this.Controls.Add(this.txtAsunEmail);
            this.Controls.Add(this.txtToEmail);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmCorreo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correo";
            this.Load += new System.EventHandler(this.frmCorreo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.TextBox txtToEmail;
        private System.Windows.Forms.TextBox txtAsunEmail;
        private System.Windows.Forms.TextBox txtContenidoEmail;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbArchivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button archivo;
    }
}