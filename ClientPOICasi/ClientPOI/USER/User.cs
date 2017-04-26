using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ClientPOI.USER
{
    public class User
    {
        public String userName;
        public UserState userState;
        public Socket userSocket;
    }
}
