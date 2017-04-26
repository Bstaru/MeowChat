using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ClientPOI.Forms
{
    public partial class frmMenu : Form
    {
        public static List<string> straycats = new List<string>();

        public string _User;
        public Thread recibirInfo;

        public static string ip = null;

        public static byte[] Cliente = new byte[1024];
        private static byte[] data = new byte[1024];
        private static byte[] dataLogros = new byte[1024];

        public static int recv;
        public static string stringData;

        public static bool personal, grupal,OCtl;
        public static string AQuien = " ";
        public static string DeQuien= " ";
        public static string mensajenuevo;

        public static string NombrePerVideollamda ="";

        public static UdpClient DudMandar;

        public static IPEndPoint ipepudp = null;
        public static IPEndPoint ipepudpRecibir = null;

        public static int puestomandar = 0;
        public static int puestoescuchar = 0;

        public static bool ireceive, yousend = false;

        //public static String ip_server = "192.168.1.67";
        public static String ip_server = "127.0.0.1";
        public static IPEndPoint ipep = new IPEndPoint(
             IPAddress.Parse (ip_server), 9050);

        public static Socket server = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);

        public static bool chatbuzz =false;

        public string msg;

        Cifrado enc;

        public frmMenu() {
            InitializeComponent();
            conectar();
            enc = new Cifrado();
        }

        public void conectar()
        {
            try
            {
                IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName());

                foreach (IPAddress address in localip)
                {
                    if (address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        ip = Convert.ToString(address);
                    }

                }

                server.Connect(ipep);
                Cliente = Encoding.ASCII.GetBytes("Login%" + frmLogin.NomU + "%" + frmLogin.ContraU + "%" + frmLogin.EstU + "%" + ip);
                server.Send(Cliente);

                recibirInfo = new Thread(recibir);
                recibirInfo.Start();
            }
            catch (SocketException)
            {
                 return;
            }
        }

        public void recibir()
        {
           while (true)
            {
                recv = server.Receive(data);
                stringData = Encoding.ASCII.GetString(data, 0, recv);
                string[] words = new string[4];

                words = stringData.Split('%');

                if (words[0] == "Login")
                {
                    frmLogin.emailU = words[1];
                    frmLogin.idU = words[2];

                    frmLogin.zumba = words[3];
                    frmLogin.chato1 = words[4];
                    frmLogin.chato2 = words[5];
                    frmLogin.ora = words[6];
                    frmLogin.camm = words[7];
                    frmLogin.cuenta = words[8];
                    frmLogin.jugo = words[9];
                    frmLogin.mail = words[10];


                    if (frmLogin.zumba == "1")
                    {
                        pic_logro2.Image = ClientPOI.Properties.Resources.buzzz;
                    }

                    if (frmLogin.chato1 == "1")
                    {
                        pic_logro3.Image = ClientPOI.Properties.Resources.chat;
                    }
                    if (frmLogin.chato2 == "1")
                    {
                        pic_logro4.Image = ClientPOI.Properties.Resources.chatgrupal;
                    }
                    if (frmLogin.ora == "1")
                    {
                        pic_logro5.Image = ClientPOI.Properties.Resources.reloj;
                    }
                    if (frmLogin.camm == "1")
                    {
                        pic_logro6.Image = ClientPOI.Properties.Resources.camaraa;
                    }
                    if (frmLogin.cuenta == "1")
                    {
                        pic_logro1.Image = ClientPOI.Properties.Resources.nuevaCuenta;
                    }
                    if (frmLogin.jugo == "1")
                    {
                        pic_logro7.Image = ClientPOI.Properties.Resources.gamo;
                    }
                    if (frmLogin.mail == "1")
                    {
                        pic_logro8.Image = ClientPOI.Properties.Resources.mail;
                    }
                }
                            
                else if (words[0] == "Logro")
                {
                    if (words[1] == "ora")
                    {
                        pic_logro5.Image = ClientPOI.Properties.Resources.reloj;
                    }
                    if (words[1] == "cgrup")
                    {
                        pic_logro4.Image = ClientPOI.Properties.Resources.chatgrupal;
                    }
                    if (words[1] == "cind")
                    {
                        pic_logro3.Image = ClientPOI.Properties.Resources.chat;
                    }
                    if (words[1] == "boss")
                    {
                        pic_logro2.Image = ClientPOI.Properties.Resources.buzzz;
                    }
                    if (words[1] == "vidrio")
                    {
                        pic_logro6.Image = ClientPOI.Properties.Resources.camaraa;
                    }
                    if (words[1] == "cuenta")
                    {
                        pic_logro1.Image = ClientPOI.Properties.Resources.nuevaCuenta;
                    }
                    if (words[1] == "juego")
                    {
                        pic_logro7.Image = ClientPOI.Properties.Resources.gamo;
                    }
                    if (words[1] == "email")
                    {
                        pic_logro8.Image = ClientPOI.Properties.Resources.mail;
                    }
                }

                else if (words[0] == "Personal" || words[0] == "Grupal")
                {
                    mensajenuevo = words[3];
                    AQuien = words[1];
                    DeQuien = words[2];

                    if (words[0] == "Personal")
                    {
                        personal = true;
                        grupal = false;

                     
                    }
                    if (words[0] == "Grupal")
                    {
                        personal = false;
                        grupal = true;
                    }
                }

                else if (words[0] == "Videollamada")
                {
                    yousend = true;
                    DudMandar = new UdpClient(ip_server, 9999);

                }

                else if (words[0] == "VideollamadaRecibir")
                {
                    ireceive = true;
                    DudMandar = new UdpClient(ip_server, 666);

                    DialogResult boton = MessageBox.Show(words[2] + "quiere hacer una llamada contigo", "EY", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (boton == DialogResult.OK)
                    {
                        //funcion que no va aqui porque no es necesaria
                        NombrePerVideollamda = words[2];
                        frmCamara camis = new frmCamara();
                        camis.Empezar.Visible = true;
                        camis.ShowDialog();
                    }
                }
                else if (words[0] == "Abueno")
                {
                    OCtl = true;
                }

                else if (words[0] == "juego")
                {
                    DialogResult boton = MessageBox.Show(words[1] + " quiere juegar", "EY", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (boton == DialogResult.OK)
                    {

                        frmGame Game = new frmGame();
                        frmGame.osorio = false;

                        Game.PIC1.Enabled = false;
                        Game.PIC2.Enabled = false;
                        Game.PIC3.Enabled = false;
                        Game.PIC4.Enabled = false;
                        Game.PIC5.Enabled = false;
                        Game.PIC6.Enabled = false;
                        Game.PIC7.Enabled = false;
                        Game.PIC8.Enabled = false;
                        Game.PIC9.Enabled = false;

                        //Game.Parent = null;
                        Game.ShowDialog();
                        break;
                        
                    }
                }
              
                else if (words[0] == "Buzz")
                {
                    chatbuzz = true;
                }
                Thread.Sleep(1000);
                }
        }
       

        private void frmMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblUser.Text = frmLogin.NomU;
            lbEstado.Text = frmLogin.EstU;
        }
        

        private void PicChat_Click(object sender, EventArgs e)
        {
            frmShatt pto = new frmShatt();
            pto.personal = false;
            pto.ShowDialog();
            if (frmLogin.chato2 == "0") { 
            Cliente = Encoding.ASCII.GetBytes("Logro%cgrup" + "%" + frmLogin.NomU + "%" + frmLogin.idU);
            server.Send(Cliente);
            MessageBox.Show("Nuevo logro!", "YEY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("G");

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DialogResult loggingout = MessageBox.Show("Estas saliendo ahora ¿estás seguro?", "WARNING",
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (loggingout == DialogResult.Yes)
            {
                frmLogin Login = new frmLogin();
                Login.Show();
                this.Close();
            }
        }

        private void PicMail_Click(object sender, EventArgs e)
        {
            frmCorreo Correo = new frmCorreo();
            Correo.Show();
        }

        private void PicPlay_Click(object sender, EventArgs e)
        {
            frmGame Game = new frmGame();
            Game.Show();
        }

        private void PicNoti_Click(object sender, EventArgs e)
        {
            frmNoti Noti = new frmNoti();
            Noti.Show();
        }

        private void PicFriends_Click(object sender, EventArgs e)
        {
            frmFriends Amiguis = new frmFriends();
         
            Amiguis.Show();

        }
        private void lblDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nuevo logro!", "YEY",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Cliente = Encoding.ASCII.GetBytes("Logro%ora"+ "%" + frmLogin.NomU + "%" + frmLogin.idU);
            server.Send(Cliente);
        }
        





        //private void bttnLogOut_Click(object sender, EventArgs e)
        //{
        //    DialogResult loggingout = MessageBox.Show("Estas saliendo ahora ¿estás seguro?", "WARNING", 
        //                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //    if (loggingout == DialogResult.Yes)
        //    {
        //        frmLogin Login = new frmLogin();
        //        Login.Show(); 
        //        this.Close();
        //    }
        //}
        private void chanceStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void pctrBxAvatar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pic_logro2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }


    }
}
