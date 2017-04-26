using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using ClientPOI.USER;
using ClientPOI.SERVER;
using System.Threading;
using System.IO;
using System.Collections;
using System.Diagnostics;

namespace ClientPOI
{
    public partial class frmChat : Form
    {
        Server server;
        User MyUser;
        Thread waitingMessage;
        bool chatOn;
        Hashtable emojis;

        public string Usruru;
        public string Svruru;

        public frmChat()
        {

            server = new Server();
            waitingMessage = new Thread(new ThreadStart(WaittingMessage));
            chatOn = true;
            InitializeComponent();
            
        }
        public frmChat(string _Name,string _IP)
        {
            emojis = new Hashtable(4);
            
            emojis.Add(":v", ClientPOI.Properties.Resources.dosV);

            MyUser = new User();
            MyUser.userName = _Name;
                // switch (_State) { 
                //case "Connected":
                //    MyUser.userState = UserState.Connected;
                //    break;
                //case "Absent":
                //    MyUser.userState = UserState.Absent;
                //    break;
                //case "Busy":
                //    MyUser.userState = UserState.Busy;
                //    break;}
            server = new Server();
            server.IP = _IP;
            waitingMessage = new Thread(new ThreadStart(WaittingMessage));
            chatOn = true;
            InitializeComponent();
           
        }

        
        private void frmChat_Load(object sender, EventArgs e)
        {
            launchClient();
            lblUser.Text = Usruru;
            
        }

        public void WaittingMessage() {

            while (chatOn)
            {
                server.serverData = new byte[1024];
                server.serverRecv = 0;
                server.serverStringData = "";
                server.serverRecv = server.serverSocket.Receive(server.serverData);

                server.serverStringData = Encoding.ASCII.GetString(server.serverData, 0, server.serverRecv);
                if (server.serverStringData != "")
                {
                    this.SetText(server.serverStringData);
             
                }
            }
        }
        private void launchClient() {
            //End Point del cliente
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("192.168.43.245"), 20); //AQUI ESTA EL IP!!! cel /192.168.43.245 uni/ 10.1.112.27
            //Creacion del Socket
            server.serverSocket = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            try
            {
                //Tratar de conectarse al servidor con el EndPoint
                server.serverSocket.Connect(ipep);
            }
            catch (SocketException e)
            {
                //Mostrar error sino se logra
               MessageBox.Show("Imposible conectar con el servidor" + Environment.NewLine + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            server.sendUserDescription(MyUser.userName, MyUser.userState.ToString());
            waitingMessage.Start();
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            
            server.serverInput = MyUser.userName + ": " + txtMessage.Text + "\n";
            server.sendMessage();
            txtMessage.Text = "";
            txtMessage.Focus();    
        }
        
        private void frmChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                server.serverSocket.Send(Encoding.ASCII.GetBytes("exit"));
                chatOn = false;
                if (waitingMessage.IsAlive)
                    waitingMessage.Abort();
            }
            catch (SocketException) {
                //Mostrar error sino se logra
                //MessageBox.Show("Imposible conectar con el servidor" + Environment.NewLine + se.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(waitingMessage.IsAlive)
                waitingMessage.Join();
            Application.Exit();
        }

        private void txtChat_VisibleChanged(object sender, EventArgs e)
        {
            rTBChat.ScrollToCaret();
        }

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (this.rTBChat.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.rTBChat.AppendText(text);
                foreach (string emote in emojis.Keys)
                {
                    while (this.rTBChat.Text.Contains(emote))
                    {
                        int ind = this.rTBChat.Text.IndexOf(emote);
                        this.rTBChat.Select(ind, emote.Length);
                        Clipboard.SetImage((Image)emojis[emote]);
                        this.rTBChat.Paste();
                    }
                }
            }
        }

       public delegate void SetTextCallback(string message);

       public static bool SetStyle(Control c, ControlStyles Style, bool value)
        {
            bool retval = false;
            Type typeTB = typeof(Control);
            System.Reflection.MethodInfo misSetStyle = typeTB.GetMethod("SetStyle", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            if (misSetStyle != null && c != null) { misSetStyle.Invoke(c, new object[] { Style, value }); retval = true; }
            return retval;
        }
        


        private void rTBChat_TextChanged(object sender, EventArgs e)
        {
            
        }
  
        private void bttnExitChat_Click(object sender, EventArgs e)
        {
            server.serverInput = MyUser.userName + ": RIP, never forgetti" + "\n";
            server.sendMessage();
            this.Hide();
            
        }

        private void bttnEmoticon_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnSendFile_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario2_Click(object sender, EventArgs e)
        {

        }

        private void PicVideo1_Click(object sender, EventArgs e)
        {

        }

        private void PICPLAY_CHAT_Click(object sender, EventArgs e)
        {
          
        }

        private void PICCAM_CHAT_Click(object sender, EventArgs e)
        {
        }
    }
}
