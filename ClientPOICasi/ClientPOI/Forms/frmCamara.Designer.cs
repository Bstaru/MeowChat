namespace ClientPOI.Forms
{
    partial class frmCamara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCamara));
            this.cam1 = new System.Windows.Forms.PictureBox();
            this.EndCam = new System.Windows.Forms.Button();
            this.cam2 = new System.Windows.Forms.PictureBox();
            this.cameras = new System.Windows.Forms.ComboBox();
            this.Empezar = new System.Windows.Forms.Button();
            this.oc = new System.Windows.Forms.Button();
            this.ddd = new System.Windows.Forms.Button();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.Empezar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam2)).BeginInit();
            this.SuspendLayout();
            // 
            // cam1
            // 
            this.cam1.Location = new System.Drawing.Point(37, 24);
            this.cam1.Name = "cam1";
            this.cam1.Size = new System.Drawing.Size(390, 290);
            this.cam1.TabIndex = 0;
            this.cam1.TabStop = false;
            // 
            // EndCam
            // 
            this.EndCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.EndCam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EndCam.Font = new System.Drawing.Font("Architects Daughter", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndCam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EndCam.Location = new System.Drawing.Point(249, 335);
            this.EndCam.Name = "EndCam";
            this.EndCam.Size = new System.Drawing.Size(178, 45);
            this.EndCam.TabIndex = 12;
            this.EndCam.Text = "Terminar";
            this.EndCam.UseVisualStyleBackColor = false;
            // 
            // cam2
            // 
            this.cam2.Location = new System.Drawing.Point(453, 24);
            this.cam2.Name = "cam2";
            this.cam2.Size = new System.Drawing.Size(390, 290);
            this.cam2.TabIndex = 13;
            this.cam2.TabStop = false;
            // 
            // cameras
            // 
            this.cameras.Font = new System.Drawing.Font("Architects Daughter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameras.FormattingEnabled = true;
            this.cameras.Location = new System.Drawing.Point(37, 339);
            this.cameras.Name = "cameras";
            this.cameras.Size = new System.Drawing.Size(134, 41);
            this.cameras.TabIndex = 14;
            this.cameras.Visible = false;
            // 
            // Empezar
            // 
            this.Empezar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.Empezar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Empezar.Font = new System.Drawing.Font("Architects Daughter", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empezar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Empezar.Location = new System.Drawing.Point(453, 335);
            this.Empezar.Name = "Empezar";
            this.Empezar.Size = new System.Drawing.Size(178, 45);
            this.Empezar.TabIndex = 15;
            this.Empezar.Text = "Empezar";
            this.Empezar.UseVisualStyleBackColor = false;
            this.Empezar.Visible = false;
            this.Empezar.Click += new System.EventHandler(this.Empezar_Click);
            // 
            // oc
            // 
            this.oc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.oc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oc.Font = new System.Drawing.Font("Architects Daughter", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.oc.Location = new System.Drawing.Point(679, 335);
            this.oc.Name = "oc";
            this.oc.Size = new System.Drawing.Size(66, 45);
            this.oc.TabIndex = 16;
            this.oc.Text = "oc";
            this.oc.UseVisualStyleBackColor = false;
            this.oc.Visible = false;
            // 
            // ddd
            // 
            this.ddd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.ddd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddd.Font = new System.Drawing.Font("Architects Daughter", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ddd.Location = new System.Drawing.Point(777, 335);
            this.ddd.Name = "ddd";
            this.ddd.Size = new System.Drawing.Size(66, 45);
            this.ddd.TabIndex = 17;
            this.ddd.Text = "d";
            this.ddd.UseVisualStyleBackColor = false;
            this.ddd.Visible = false;
            // 
            // tiempo
            // 
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // Empezar2
            // 
            this.Empezar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.Empezar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Empezar2.Font = new System.Drawing.Font("Architects Daughter", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empezar2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Empezar2.Location = new System.Drawing.Point(453, 335);
            this.Empezar2.Name = "Empezar2";
            this.Empezar2.Size = new System.Drawing.Size(178, 45);
            this.Empezar2.TabIndex = 18;
            this.Empezar2.Text = "Empezar";
            this.Empezar2.UseVisualStyleBackColor = false;
            this.Empezar2.Visible = false;
            this.Empezar2.Click += new System.EventHandler(this.Empezar2_Click_1);
            // 
            // frmCamara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(874, 414);
            this.Controls.Add(this.Empezar2);
            this.Controls.Add(this.ddd);
            this.Controls.Add(this.oc);
            this.Controls.Add(this.Empezar);
            this.Controls.Add(this.cameras);
            this.Controls.Add(this.cam2);
            this.Controls.Add(this.EndCam);
            this.Controls.Add(this.cam1);
            this.Font = new System.Drawing.Font("Architects Daughter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCamara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camara";
            this.Load += new System.EventHandler(this.frmCamara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cam1;
        private System.Windows.Forms.Button EndCam;
        private System.Windows.Forms.PictureBox cam2;
        private System.Windows.Forms.ComboBox cameras;
        private System.Windows.Forms.Button oc;
        private System.Windows.Forms.Button ddd;
        private System.Windows.Forms.Timer tiempo;
        public System.Windows.Forms.Button Empezar;
        public System.Windows.Forms.Button Empezar2;
    }
}