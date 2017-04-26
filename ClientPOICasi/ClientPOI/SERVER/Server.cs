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

namespace ClientPOI.SERVER
{
    public class Server
    {
       public Server() {
            serverData = new byte[1024];
        }
       public string IP;
        public Socket serverSocket;
        public byte[] serverData;
        public string serverInput;
        public string serverStringData;
        public int serverRecv;

        public void sendMessage()
        {
            this.serverSocket.Send(Encoding.ASCII.GetBytes(this.serverInput));
            //Informacion que se envia servidor
            /*
            this.serverRecv = this.serverSocket.Receive(this.serverData);
            this.serverStringData = Encoding.ASCII.GetString(this.serverData, 0, this.serverRecv);
             */
            serverInput = "";

        }

        public void sendUserDescription(string userName, string userState) {
            this.serverInput = userName + "\r\n" + userState;
            this.serverSocket.Send(Encoding.ASCII.GetBytes(this.serverInput));

            serverInput = "";
        }
    }

    
}
