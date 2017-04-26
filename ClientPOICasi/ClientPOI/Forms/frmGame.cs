using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ClientPOI.Forms
{
    public partial class frmGame : Form
    {
        Thread gato;
        public int PuntosP1;
        public int PuntosP2;
        
        public static bool osorio;
        public static bool[] p1 = new bool[9];
        public static bool[] p2 = new bool[9];

   
        public frmGame()
        {
            InitializeComponent();

            //gato = new Thread(juego);
            //gato.Start();

            for (int i = 0; i > p1.Length; i++)
            {
                p1[i] = false;
                p2[i] = false;
                PuntosP1 = 0;
                PuntosP2 = 0;
            }
        }

        private void frmGame_Load(object sender, EventArgs e)
        {

        }

        public void juego()
        {
            //----------HORIZONTALES--------------
            while (true){
                if (p1[0] == true && p1[1] == true && p1[2] == true || p2[0] == true && p2[1] == true && p2[2] == true)
                {
                    MessageBox.Show("GANASTE SHAVO :V");
                    puntaje();
                    reset();
                }
                else if (p1[3] == true && p1[4] == true && p1[5] == true || p2[3] == true && p2[4] == true && p2[5] == true)
                {
                    MessageBox.Show("GANASTE SHAVO :V");
                    puntaje();
                    reset();
                }
                else if (p1[6] == true && p1[7] == true && p1[8] == true || p2[6] == true && p2[7] == true && p2[8] == true)
                {
                    MessageBox.Show("GANASTE SHAVO :V");
                    puntaje();
                    reset();
                }
                //---------VERTICALES--------------
                else if (p1[0] == true && p1[3] == true && p1[6] == true || p2[0] == true && p2[3] == true && p2[6] == true)
                {
                    MessageBox.Show("GANASTE SHAVO :V");
                    puntaje();
                    reset();
                }

                else if (p1[1] == true && p1[4] == true && p1[7] == true || p2[1] == true && p2[4] == true && p2[7] == true)
                {
                    MessageBox.Show("GANASTE SHAVO :V");
                    puntaje();
                    reset();
                }

                else if (p1[2] == true && p1[5] == true && p1[8] == true || p2[2] == true && p2[5] == true && p2[8] == true)
                {
                    MessageBox.Show("GANASTE SHAVO :V");                    
                    puntaje();
                    reset();
                }

                //------------DIAGONALES----------------------
                else if (p1[0] == true && p1[4] == true && p1[8] == true || p2[0] == true && p2[4] == true && p2[8] == true)
                {
                    MessageBox.Show("GANASTE SHAVO :V");
                    puntaje();
                    reset();
                }
                else if (p1[2] == true && p1[4] == true && p1[6] == true || p2[2] == true && p2[4] == true && p2[6] == true)
                {
                    MessageBox.Show("GANASTE SHAVO :V");
                    puntaje();
                    reset();
                }
            }
        }

        public void puntaje()
        {
            if (p1[0] == true && p1[1] == true && p1[2] == true)
            {
                PuntosP1 = PuntosP1 + 1;
                sc1.Text = "Score= " + PuntosP1;
                reset();
                
                
            }else if ( p2[0] == true && p2[1] == true && p2[2] == true){

                PuntosP2 = PuntosP2 + 1;
                //txtP2.Text = "Score= " + PuntosP2;
                reset();
            }

            if (p1[3] == true && p1[4] == true && p1[5] == true)
            {
                PuntosP1 = PuntosP1 + 1;
                //txtP1.Text = txtP1.Text + 1;
                reset();

            }
            else if (p2[3] == true && p2[4] == true && p2[5] == true)
            {
                //txtP2.Text = txtP2.Text + 1;
                PuntosP2 = PuntosP2 + 1;
                reset();
            }

            if (p1[6] == true && p1[7] == true && p1[8] == true)
            {
                PuntosP1 = PuntosP1 + 1;
                reset();
                //txtP1.Text = txtP1.Text + 1;
            }
            else if (p2[6] == true && p2[7] == true && p2[8] == true)
            {
                PuntosP2 = PuntosP2 + 1;
                reset();
                //txtP2.Text = txtP2.Text + 1;
            }


            if (p1[0] == true && p1[3] == true && p1[6] == true)
            {

                PuntosP1 = PuntosP1 + 1;
                reset();
                //txtP1.Text = txtP1.Text + 1;
            }
            else if (p2[0] == true && p2[3] == true && p2[6] == true)
            {
                //txtP2.Text = txtP2.Text + 1;
                PuntosP2 = PuntosP2 + 1;
                reset();
            }

            if (p1[1] == true && p1[4] == true && p1[7] == true)
            {
                PuntosP1 = PuntosP1 + 1;
                reset();
                //txtP1.Text = txtP1.Text + 1;
            }
            else if (p2[1] == true && p2[4] == true && p2[7] == true)
            {

                PuntosP2 = PuntosP2 + 1;
                reset();
                //txtP2.Text = txtP2.Text + 1;
            }


            if (p1[2] == true && p1[5] == true && p1[8] == true)
            {
                //txtP1.Text = txtP1.Text + 1;

                PuntosP1 = PuntosP1 + 1;
                reset();
            }
            else if (p2[2] == true && p2[5] == true && p2[8] == true)
            {
                //txtP2.Text = txtP2.Text + 1;

                PuntosP2 = PuntosP2 + 1;
                reset();
            }


            if (p1[0] == true && p1[4] == true && p1[8] == true)
            {
                //txtP1.Text = txtP1.Text + 1;
                PuntosP1 = PuntosP1 + 1;
                reset();
            }
            else if (p2[0] == true && p2[4] == true && p2[8] == true)
            {
                //txtP2.Text = txtP2.Text + 1;

                PuntosP2 = PuntosP2 + 1;
                reset();
            }
            

            if (p1[2] == true && p1[4] == true && p1[6] == true)
            {
                //txtP1.Text = txtP1.Text + 1;

                PuntosP1 = PuntosP1 + 1;
                reset();
            }
            else if (p2[2] == true && p2[4] == true && p2[6] == true)
            {
                //txtP2.Text = txtP2.Text + 1;

                PuntosP2 = PuntosP2 + 1;
                reset();
            }
        }
        
        public void reset() {
        p1[0] = false;
        p1[1] = false;
        p1[2] = false;
        p1[3] = false;
        p1[4] = false;
        p1[5] = false;
        p1[6] = false;
        p1[7] = false;
        p1[8] = false;

        p2[0] = false;
        p2[1] = false;
        p2[2] = false;
        p2[3] = false;
        p2[4] = false;
        p2[5] = false;
        p2[6] = false;
        p2[7] = false;
        p2[8] = false;

        PIC1.Image = null;
        PIC2.Image = null;
        PIC3.Image = null;
        PIC4.Image = null;
        PIC5.Image = null;
        PIC6.Image = null;
        PIC7.Image = null;
        PIC8.Image = null;
        PIC9.Image = null;
    }


        public static byte[] movi = new byte[1024];

        private void PIC1_Click(object sender, EventArgs e)
        {
            if (osorio)
            {
                PIC1.Image = ClientPOI.Properties.Resources.CIRCULO;
                p1[0] = true;

               movi = Encoding.ASCII.GetBytes("Movimiento%juno%1");
               frmMenu.server.Send(movi);

            }
            else
            {
                PIC1.Image = ClientPOI.Properties.Resources.CRUZ;
                p2[0] = true;

                movi = Encoding.ASCII.GetBytes("Movimiento%jdos%1");
                frmMenu.server.Send(movi);
            }
        }

        private void PIC2_Click(object sender, EventArgs e)
        {
            if (osorio)
            {
                PIC2.Image = ClientPOI.Properties.Resources.CIRCULO;
                p1[1] = true;

                movi = Encoding.ASCII.GetBytes("Movimiento%juno%2");
                frmMenu.server.Send(movi);
            }
            else
            {
                PIC2.Image = ClientPOI.Properties.Resources.CRUZ;
                p2[1] = true;

                movi = Encoding.ASCII.GetBytes("Movimiento%jdos%2");
                frmMenu.server.Send(movi);
            }
        }

        private void PIC3_Click_1(object sender, EventArgs e)
        {
            if (osorio)
            {
                PIC3.Image = ClientPOI.Properties.Resources.CIRCULO;
                p1[2] = true;
                movi = Encoding.ASCII.GetBytes("Movimiento%juno%3");
                frmMenu.server.Send(movi);
            }
            else
            {
                PIC3.Image = ClientPOI.Properties.Resources.CRUZ;
                p2[2] = true;
                movi = Encoding.ASCII.GetBytes("Movimiento%jdos%3");
                frmMenu.server.Send(movi);
            }
        }

        private void PIC4_Click_1(object sender, EventArgs e)
        {
            if (osorio)
            {
                PIC4.Image = ClientPOI.Properties.Resources.CIRCULO;
                p1[3] = true;
                movi = Encoding.ASCII.GetBytes("Movimiento%juno%4");
                frmMenu.server.Send(movi);
            }
            else
            {
                PIC4.Image = ClientPOI.Properties.Resources.CRUZ;
                p2[3] = true;
                movi = Encoding.ASCII.GetBytes("Movimiento%jdos%4");
                frmMenu.server.Send(movi);
            }
        }

        private void PIC5_Click_1(object sender, EventArgs e)
        {
            if (osorio)
            {
                PIC5.Image = ClientPOI.Properties.Resources.CIRCULO;
                p1[4] = true;
                movi = Encoding.ASCII.GetBytes("Movimiento%juno%5");
                frmMenu.server.Send(movi);
            }
            else
            {
                PIC5.Image = ClientPOI.Properties.Resources.CRUZ;
                p2[4] = true;
                movi = Encoding.ASCII.GetBytes("Movimiento%jdos%5");
                frmMenu.server.Send(movi);
            }
        }

        private void PIC6_Click_1(object sender, EventArgs e)
        {
            if (osorio)
            {
                PIC6.Image = ClientPOI.Properties.Resources.CIRCULO;
                p1[5] = true;
                movi = Encoding.ASCII.GetBytes("Movimiento%juno%6");
                frmMenu.server.Send(movi);
            }
            else
            {
                PIC6.Image = ClientPOI.Properties.Resources.CRUZ;
                p2[5] = true;
                movi = Encoding.ASCII.GetBytes("Movimiento%jdos%6");
                frmMenu.server.Send(movi);
            }
        }

        private void PIC7_Click_1(object sender, EventArgs e)
        {
            if (osorio)
            {
                PIC7.Image = ClientPOI.Properties.Resources.CIRCULO;
                p1[6] = true;
                movi = Encoding.ASCII.GetBytes("Movimiento%juno%7");
                frmMenu.server.Send(movi);
            }
            else
            {
                PIC7.Image = ClientPOI.Properties.Resources.CRUZ;
                p2[6] = true;
                movi = Encoding.ASCII.GetBytes("Movimiento%jdos%7");
                frmMenu.server.Send(movi);
            }
        }

        private void PIC8_Click_1(object sender, EventArgs e)
        {
            if (osorio)
            {
                PIC8.Image = ClientPOI.Properties.Resources.CIRCULO;
                p1[7] = true;
                movi = Encoding.ASCII.GetBytes("Movimiento%juno%8");
                frmMenu.server.Send(movi);
            }
            else
            {
                PIC8.Image = ClientPOI.Properties.Resources.CRUZ;
                p2[7] = true;
                movi = Encoding.ASCII.GetBytes("Movimiento%jdos%8");
                frmMenu.server.Send(movi);
            }
        }

        private void PIC9_Click_1(object sender, EventArgs e)
        {
            if (osorio)
            {
                PIC9.Image = ClientPOI.Properties.Resources.CIRCULO;
                p1[8] = true;
                movi = Encoding.ASCII.GetBytes("Movimiento%juno%9");
                frmMenu.server.Send(movi);
            }
            else
            {
                PIC9.Image = ClientPOI.Properties.Resources.CRUZ;
                p2[8] = true;
                movi = Encoding.ASCII.GetBytes("Movimiento%jdos%9");
                frmMenu.server.Send(movi);
            }
        }

        private void btnOk_game_Click(object sender, EventArgs e)
        {
            //puntaje();       
          
            //sc2.Text = "Score= " + PuntosP2;
            //sc1.Text = "Score= " + PuntosP1;

            PIC1.Enabled = false;
            PIC2.Enabled = false;
            PIC3.Enabled = false;
            PIC4.Enabled = false;
            PIC5.Enabled = false;
            PIC6.Enabled = false;
            PIC7.Enabled = false;
            PIC8.Enabled = false;
            PIC9.Enabled = false;

            if (osorio)
            {
                J1cat.Image = ClientPOI.Properties.Resources.frame;
                J2cat.Image = ClientPOI.Properties.Resources.jejcaaat;
            }
            else
            {
                J2cat.Image = ClientPOI.Properties.Resources.frame;
                J1cat.Image = ClientPOI.Properties.Resources.jejcaaat;
            }
        }
    }
}
