using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Media;

namespace ClientPOI.Forms
{
    public partial class frmShatt : Form
    {
        
        private byte[] data = new byte[1024]; //recibir
        private byte[] datados = new byte[1024]; //enviar
        private byte[] datatres = new byte[1024]; //juego
        private byte[] datacuatro = new byte[1024]; //zumbido
        private byte[] datacinco = new byte[1024]; //juego2

        Thread recibirInfo;
      
        Hashtable emojis;

        string conversacion;
        public static String NombreDeChat;

        public bool personal;

        public bool libertad = false;

        Cifrado cifri;

        public frmShatt()
        {
            InitializeComponent();
            cifri = new Cifrado();
        }

        private void frmShatt_Load(object sender, EventArgs e)
        {
            recibirInfo = new Thread(recibir);
            recibirInfo.Start();

            emojis = new Hashtable(16);

            emojis.Add(":v", ClientPOI.Properties.Resources.dosV);
            emojis.Add(":D", ClientPOI.Properties.Resources.alegre);
            emojis.Add("amor", ClientPOI.Properties.Resources.amorsh);
            emojis.Add("DIO", ClientPOI.Properties.Resources.DIO);
            emojis.Add("xD", ClientPOI.Properties.Resources.ekisde);
            emojis.Add("xP", ClientPOI.Properties.Resources.ekispe);
            emojis.Add("angry", ClientPOI.Properties.Resources.enojado);
            emojis.Add(":)", ClientPOI.Properties.Resources.feliz);
            emojis.Add(">.<", ClientPOI.Properties.Resources.jum);
            emojis.Add(":P", ClientPOI.Properties.Resources.lengua);
            emojis.Add("lennyface", ClientPOI.Properties.Resources.lennyface);
            emojis.Add("T_T", ClientPOI.Properties.Resources.llorar);
            emojis.Add("superangry", ClientPOI.Properties.Resources.masenojado);
            emojis.Add("poop", ClientPOI.Properties.Resources.poop);
            emojis.Add("D:", ClientPOI.Properties.Resources.susto);
            emojis.Add(":(", ClientPOI.Properties.Resources.triste);

            txtMessage.Focus();            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (personal == true)
            {
                if (checkEnc.Checked)
                {
                    EnviarData("Personal%" + NombreDeChat + "%" + frmLogin.NomU + "%" + cifri.Encriptar(txtMessage.Text));
                }
                else
                {
                    EnviarData("Personal%" + NombreDeChat + "%" + frmLogin.NomU + "%" + txtMessage.Text);
                }
            }
            else
            {
                if (checkEnc.Checked)
                {
                    EnviarData("Grupal%" + NombreDeChat + "%" + frmLogin.NomU + "%" + cifri.Encriptar(txtMessage.Text));
                }
                else
                {
                    EnviarData("Grupal%" + NombreDeChat + "%" + frmLogin.NomU + "%" + txtMessage.Text);
                }


            }

            txtMessage.Text = "";

        }

        public void EnviarData(String mensaje)
        {
            try
            {
                datados = Encoding.ASCII.GetBytes(mensaje);
                frmMenu.server.Send(datados, 0, datados.Length, SocketFlags.None);

            }
            catch
            {

            }
        }
        public void recibir()
        {

            while (true)
            {
                NombreDeChat = lb_User2.Text;

                if (frmMenu.AQuien == NombreDeChat || frmMenu.DeQuien == NombreDeChat)
                {
                    if (frmMenu.personal || frmMenu.grupal)
                    {
                        frmMenu.personal = false;
                        frmMenu.grupal = false;

                        try
                        {
                            String poo = cifri.Desencriptar(frmMenu.mensajenuevo);
                            conversacion = conversacion + "\n" + frmMenu.DeQuien + ": " + poo;
                            agregarconv(conversacion);

                        }
                        catch
                        {
                            conversacion = conversacion + "\n" + frmMenu.DeQuien + ": " + frmMenu.mensajenuevo;
                            agregarconv(conversacion);
                        }
                    }
                }
                if (frmMenu.chatbuzz == true)
                {
                    buzzido();
                    frmMenu.chatbuzz = false;
                }
                

                Thread.Sleep(2000);
            }
        }

        public void agregarconv(string txt)
        {
            if (rTBChat.InvokeRequired)
                rTBChat.Invoke((MethodInvoker)delegate ()
                {
                    agregarconv(txt);
                });
            else
            {
                rTBChat.Text = txt;
                rTBChat.SelectionStart = rTBChat.Text.Length;
                rTBChat.ScrollToCaret();
            }
        }

        private void rTBChat_TextChanged(object sender, EventArgs e)
        {
            AddEmojis();
        }

        public void AddEmojis()
        {
            foreach(string emote in emojis.Keys)
            {
                while (rTBChat.Text.Contains(emote))
                {
                    int ind = rTBChat.Text.IndexOf(emote);
                    rTBChat.Select(ind, emote.Length);
                    Clipboard.SetImage((Image)emojis[emote]);
                    rTBChat.Paste();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mini(sender, e);

        }

        //EMPEZAR VIDEOLLAMADA
        private void PICCAM_CHAT_Click(object sender, EventArgs e)
        {
            string conec = "Videollamada%" + frmLogin.NomU + "%" + lb_User2.Text;
            datados = Encoding.ASCII.GetBytes(conec);
            frmMenu.server.Send(datados, 0, datados.Length, SocketFlags.None);
            frmCamara camis = new frmCamara();
            camis.Empezar2.Visible = true;
            camis.Show();
            if (frmLogin.camm == "0")
            {
                frmMenu.Cliente = Encoding.ASCII.GetBytes("Logro%vidrio" + "%" + frmLogin.NomU + "%" + frmLogin.idU);
                frmMenu.server.Send(frmMenu.Cliente);
                MessageBox.Show("Nuevo logro!", "YEY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //EMPEZAR JUEGO
        private void PICPLAY_CHAT_Click(object sender, EventArgs e)
        {
            string juego = "Juego%" + frmLogin.NomU + "%" + lb_User2.Text;
            datatres = Encoding.ASCII.GetBytes(juego);
            frmMenu.server.Send(datatres, 0, datatres.Length, SocketFlags.None);
            frmGame.osorio = true;
            frmGame Game = new frmGame();
            Game.Show();

            if (frmLogin.jugo == "0")
            {
                frmMenu.Cliente = Encoding.ASCII.GetBytes("Logro%juego" + "%" + frmLogin.NomU + "%" + frmLogin.idU);
                frmMenu.server.Send(frmMenu.Cliente);
                MessageBox.Show("Nuevo logro!", "YEY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        //ENVIAR BUZZ
        private void PICBUZZ_Click(object sender, EventArgs e)
        {
            string bozzo = "Buzz%" + frmLogin.NomU + "%" + lb_User2.Text;
            datacuatro = Encoding.ASCII.GetBytes(bozzo);
            frmMenu.server.Send(datacuatro, 0, datacuatro.Length, SocketFlags.None);
            if (frmLogin.zumba == "0")
            {
                frmMenu.Cliente = Encoding.ASCII.GetBytes("Logro%boss" + "%" + frmLogin.NomU + "%" + frmLogin.idU);
                frmMenu.server.Send(frmMenu.Cliente);
                MessageBox.Show("Nuevo logro!", "YEY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        public void buzzido()
        {
            frmShatt pelea = new frmShatt();

            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    buzzido();
                });
            }
            else
            {            

                Point mov = default(Point);
                Point def = default(Point);
                mov = def = this.Location;
                System.Media.SoundPlayer zumbido= new System.Media.SoundPlayer(Properties.Resources.buzzu);
                zumbido.Play();
               
                // SystemSounds.Hand.Play();
                for (int i = 0; i <= 500; i++)
                {
                    for (int j = 0; j <= 4; j++)
                    {
                        switch (j)
                        {
                            case 0:
                                mov.X = def.X + 10;
                                mov.Y = def.Y + 10;
                                break;
                            case 1:
                                mov.X = def.X - 10;
                                mov.Y = def.Y - 10;
                                break;
                            case 2:
                                mov.X = def.X + 10;
                                mov.Y = def.Y - 10;
                                break;
                            case 3:
                                mov.Y = def.X - 10;
                                mov.Y = def.Y + 10;
                                break;
                        }
                        this.Location = mov;
                    }
                }
                

               this.Location = def;
               this.Refresh();
            }
        }

        //ENTER
        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (personal == true)
                {
                    if (checkEnc.Checked)
                    {
                        EnviarData("Personal%" + NombreDeChat + "%" + frmLogin.NomU + "%" + cifri.Encriptar(txtMessage.Text));
                    }
                    else
                    {
                        EnviarData("Personal%" + NombreDeChat + "%" + frmLogin.NomU + "%" + txtMessage.Text);
                    }
                }
                else
                {
                    if (checkEnc.Checked)
                    {
                        EnviarData("Grupal%" + NombreDeChat + "%" + frmLogin.NomU + "%" + cifri.Encriptar(txtMessage.Text));
                    }
                    else
                    {
                        EnviarData("Grupal%" + NombreDeChat + "%" + frmLogin.NomU + "%" + txtMessage.Text);
                    }
                }

                txtMessage.Text = "";
            }
        }

        private void lb_User2_Click(object sender, EventArgs e)
        {

        }

        private void lb_User_Click(object sender, EventArgs e)
        {

        }

        private void mini(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            }
        }
    }
}
