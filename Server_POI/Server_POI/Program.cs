using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Server.Clientee;
using System.Data;
using System.Threading;

using MySql.Data.MySqlClient;

public class SimpleTcpServer
{

    static private byte[] data = new byte[1024];
    static private byte[] data2 = new byte[1024]; //confirmacion de cliente existente en la base de datos
   // static private byte[] dataGame = new byte[1024];

    static IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);

    static Socket server = new Socket(AddressFamily.InterNetwork,
        SocketType.Stream, ProtocolType.Tcp);

    static Socket tempo = new Socket(AddressFamily.InterNetwork,
       SocketType.Stream, ProtocolType.Tcp);

    public static UdpClient DUDMandaruno;
    public static UdpClient DUDRecibiruno;
    public static UdpClient DUDMandardos;
    public static UdpClient DUDRecibirdos;

    static String IP1 = "";
    static String IP2 = "";
    static IPEndPoint sender = null;
    static IPEndPoint sender2 = null;

    static List<Socket> ClientSockets = new List<Socket>();
    static List<Clientee> Clients = new List<Clientee>();
    static string ip = null;

    static Thread video;
    static private byte[] bytevideo = new byte[60000];
    static private byte[] bytevideodos = new byte[60000];

    static String J1 = "";
    static String J2 = "";


    static MySqlConnection conn;

    public static void Main()
    {
        DUDRecibiruno = new UdpClient(9999);
        DUDRecibirdos = new UdpClient(666);

        conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=shineekey91; database=meowchat;");

        ConfigurarServer();
        Console.WriteLine("Esperando un morro...");
        server.BeginAccept(AceptarSocket, null);

        video = new Thread(camara);

        Console.ReadLine();

    }
    private static void ConfigurarServer()
    {
        IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName());

        foreach (IPAddress address in localip)
        {
            if (address.AddressFamily == AddressFamily.InterNetwork)
            {
                ip = Convert.ToString(address);
            }
        }
        server.Bind(ipep);
        server.Listen(10);
        Console.WriteLine("Connected to IP: " + ip);
    }
    private static void AceptarSocket(IAsyncResult AR)
    {
        try
        {
            tempo = server.EndAccept(AR);
            ClientSockets.Add(tempo);
            Console.WriteLine("Ya hay un morro!");
            ClientSockets[ClientSockets.Count - 1].BeginReceive(data, 0, 1024, SocketFlags.None, RecibirSocket, ClientSockets[ClientSockets.Count - 1]);
        }
        catch
        {

        }

        server.BeginAccept(AceptarSocket, null);
    }

    public static void RecibirSocket(IAsyncResult AR)
    {
        Socket current = (Socket)AR.AsyncState;
        int received = 0;

        try
        {
            received = current.EndReceive(AR);
        }
        catch (SocketException)
        {

        }

        byte[] datatempo = new byte[received];
        string[] words = new string[5];
        Array.Copy(data, datatempo, received);
        string text = Encoding.ASCII.GetString(datatempo);

        Console.WriteLine(text);

        words = text.Split('%');

        if (words[0] == "Login")
        {
            String UserStuff = ValidarLogin(words[1], words[2]);

            if (UserStuff == "")
            {

            }
            else
            {
                Clientee user = new Clientee();
                string[] words2 = new string[11];
                words2 = UserStuff.Split('#');
                user.userID = words2[0];
                user.userName = words2[1];
                user.userEmail = words2[2];

                user.userState = words[3];
                user.IP = words[4];

                user.buzz = words2[3];
                user.chat1 = words2[4];
                user.chat2 = words2[5];
                user.hora = words2[6];
                user.camara = words2[7];
                user.cuenta = words2[8];
                user.jugo = words2[9];
                user.mail = words2[10];

                Clients.Add(user);

                Console.WriteLine(Clients[Clients.Count - 1].userName + " esta " + Clients[Clients.Count - 1].userState);

                String topaz = "Login%" + words2[2] + "%" + words2[0] + "%" + words2[3] + "%" +
                    words2[4] + "%" + words2[5] + "%" + words2[6] + "%" + words2[7] + "%" + words2[8] + "%" + 
                    words2[9] + "%" + words2[10];

                data2 = Encoding.ASCII.GetBytes(topaz);

                ClientSockets[ClientSockets.Count - 1].Send(data2);
            }

        }
        else if (words[0] == "Logro")
        {
            byte[] dataLogro = new byte[1024];

            if (words[1] == "ora")
            {
                Console.WriteLine("Logro oraoraoraora!" + words[2]);
                loss(Int32.Parse(words[3]));
                String hra = "Logro%ora";
                dataLogro = Encoding.ASCII.GetBytes(hra);
                for (int i = 1; i <= ClientSockets.Count; i++)
                {
                    if (words[2] == Clients[i - 1].userName)
                    {
                        ClientSockets[i - 1].Send(dataLogro, dataLogro.Length, SocketFlags.None);
                    }
                }
              }
            if (words[1] == "boss")
            {
                Console.WriteLine("Logro BUZZ YOGHURT LIGHT!" + words[2]);
                yoghurt(Int32.Parse(words[3]));
                String bobo = "Logro%boss";
                dataLogro = Encoding.ASCII.GetBytes(bobo);
                for (int i = 1; i <= ClientSockets.Count; i++)
                {
                    if (words[2] == Clients[i - 1].userName)
                    {
                        ClientSockets[i - 1].Send(dataLogro, dataLogro.Length, SocketFlags.None);
                    }
                }
            }
            if (words[1] == "cind")
            {
                Console.WriteLine("Logro chat solito" + words[2]);
                Cind(Int32.Parse(words[3]));
                String indio = "Logro%cind";
                dataLogro = Encoding.ASCII.GetBytes(indio);
                for (int i = 1; i <= ClientSockets.Count; i++)
                {
                    if (words[2] == Clients[i - 1].userName)
                    {
                        ClientSockets[i - 1].Send(dataLogro, dataLogro.Length, SocketFlags.None);
                    }
                }
            }
            if (words[1] == "cgrup")
            {
                Console.WriteLine("Logro chat no solito" + words[2]);
                Cgru(Int32.Parse(words[3]));
                String indios = "Logro%cgrup";
                dataLogro = Encoding.ASCII.GetBytes(indios);
                for (int i = 1; i <= ClientSockets.Count; i++)
                {
                    if (words[2] == Clients[i - 1].userName)
                    {
                        ClientSockets[i - 1].Send(dataLogro, dataLogro.Length, SocketFlags.None);
                    }
                }
            }
            if (words[1] == "vidrio")
            {
                Console.WriteLine("Logro ia te vieron" + words[2]);
                camo(Int32.Parse(words[3]));
                String roio= "Logro%vidrio";
                dataLogro = Encoding.ASCII.GetBytes(roio);
                for (int i = 1; i <= ClientSockets.Count; i++)
                {
                    if (words[2] == Clients[i - 1].userName)
                    {
                        ClientSockets[i - 1].Send(dataLogro, dataLogro.Length, SocketFlags.None);
                    }
                }
            }
            if (words[1] == "cuenta")
            {
                Console.WriteLine("Logro ya estasss aqui" + words[2]);
                banco(Int32.Parse(words[3]));
                String jej = "Logro%cuenta";
                dataLogro = Encoding.ASCII.GetBytes(jej);
                for (int i = 1; i <= ClientSockets.Count; i++)
                {
                    if (words[2] == Clients[i - 1].userName)
                    {
                        ClientSockets[i - 1].Send(dataLogro, dataLogro.Length, SocketFlags.None);
                    }
                }
            }
            if (words[1] == "juego")
            {
                Console.WriteLine("Logro gatito" + words[2]);
                jugo(Int32.Parse(words[3]));
                String wea = "Logro%juego";
                dataLogro = Encoding.ASCII.GetBytes(wea);
                for (int i = 1; i <= ClientSockets.Count; i++)
                {
                    if (words[2] == Clients[i - 1].userName)
                    {
                        ClientSockets[i - 1].Send(dataLogro, dataLogro.Length, SocketFlags.None);
                    }
                }
            }
            if (words[1] == "email")
            {
                Console.WriteLine("Logro el correo ya llego anunciando su cancion y con emocion grito, correo!" + words[2]);
                jugo(Int32.Parse(words[3]));
                String weas = "Logro%email";
                dataLogro = Encoding.ASCII.GetBytes(weas);
                for (int i = 1; i <= ClientSockets.Count; i++)
                {
                    if (words[2] == Clients[i - 1].userName)
                    {
                        ClientSockets[i - 1].Send(dataLogro, dataLogro.Length, SocketFlags.None);
                    }
                }
            }
        }
        else if (words[0] == "Personal")
        {
            for (int i = 1; i <= ClientSockets.Count; i++)
            {
                if (words[1] == Clients[i - 1].userName || words[2] == Clients[i - 1].userName)
                {
                    ClientSockets[i - 1].Send(datatempo, received, SocketFlags.None);
                }
            }
        }
        else if (words[0] == "Grupal")
        {
            for (int i = 1; i <= ClientSockets.Count; i++)
            {
                ClientSockets[i - 1].Send(datatempo, received, SocketFlags.None);
            }
        }
        else if (words[0] == "Buzz")
        {
            for (int i = 1; i <= ClientSockets.Count; i++)
            {
                ClientSockets[i - 1].Send(datatempo, received, SocketFlags.None);
            }
        }
     
        else if (words[0] == "Videollamada")
        {
            for (int i = 1; i <= Clients.Count; i++)
            {
                if (words[2] == Clients[i - 1].userName)
                {
                    IP1 = Clients[i - 1].IP;
                }

                else if (words[1] == Clients[i - 1].userName)
                {
                    IP2 = Clients[i - 1].IP;
                }
            }
            for (int i = 1; i <= Clients.Count; i++)
            {
                byte[] udptem = new byte[20];
                string socketudp;

                if (words[2] == Clients[i - 1].userName)
                {
                    socketudp = "VideollamadaRecibir" + "%" + IP2 + "%" + words[1];
                    udptem = Encoding.ASCII.GetBytes(socketudp);
                    ClientSockets[i - 1].Send(udptem, udptem.Length, SocketFlags.None);
                }
                else if (words[1] == Clients[i - 1].userName)
                {
                    socketudp = "Videollamada" + "%" + IP1;
                    udptem = Encoding.ASCII.GetBytes(socketudp);
                    ClientSockets[i - 1].Send(udptem, udptem.Length, SocketFlags.None);
                }
            }

            DUDMandaruno = new UdpClient(IP1, 667);
            DUDMandardos = new UdpClient(IP2, 9998);

            sender = new IPEndPoint(IPAddress.Any, 666);
            sender2 = new IPEndPoint(IPAddress.Any, 9999);

            video.Start();
        }

        else if (words[0] == "YaEmpiezale")
        {
            byte[] OC = new byte[20];
            string OCtl = "Abueno%";
            OC = Encoding.ASCII.GetBytes(OCtl);
            for (int i = 1; i <= ClientSockets.Count; i++)
            {
                if (words[1] == Clients[i - 1].userName || words[2] == Clients[i - 1].userName)
                {
                    ClientSockets[i - 1].Send(OC, 7, SocketFlags.None);
                }
            }

        }        

        else if (words[0] == "Juego")
        {
            byte[] OC = new byte[20];
            string OCtl = "juego%" + words[1];
            OC = Encoding.ASCII.GetBytes(OCtl);

            J1 = words[1];
            J2 = words[2];

            for (int i = 1; i <= ClientSockets.Count; i++)
            {               
                if (words[2] == Clients[i - 1].userName)
                {
                    ClientSockets[i - 1].Send(OC, OC.Length, SocketFlags.None);
                }
            }
        }
        else if (words[0] == "Movimiento")
        {
            byte[] dataGame = new byte[1024];
            String gamo = "Movimiento%" + words[1] + "%" + words[2];
            dataGame = Encoding.ASCII.GetBytes(gamo);

            if (words[1] == "juno") { 
            for (int i = 1; i <= ClientSockets.Count; i++) 
            {                          
                if (J2 == Clients[i - 1].userName || J1 == Clients[i - 1])
                {
                    ClientSockets[i - 1].Send(dataGame, dataGame.Length, SocketFlags.None);
                }
             }
            }
            else if (words[1] == "jdos")
            {
                for (int i = 1; i <= ClientSockets.Count; i++)
                {
                    if (J2 == Clients[i - 1].userName || J1 == Clients[i - 1])
                    {
                        ClientSockets[i - 1].Send(dataGame, dataGame.Length, SocketFlags.None);
                    }
                }
            }
        }

        for (int i = 1; i <= ClientSockets.Count; i++)
        {

            ClientSockets[i - 1].BeginReceive(data, 0, 1024, SocketFlags.None, RecibirSocket, ClientSockets[i - 1]);
        }
    }

    public static void camara()
    {
        while (true)
        {
            bytevideo = DUDRecibirdos.Receive(ref sender);

            Console.WriteLine("Recibio" + sender.Address.ToString());
            Console.WriteLine("\n");

            DUDMandardos.Send(bytevideo, bytevideo.Length);

            Console.WriteLine("Mando" + IP2);
            Console.WriteLine("\n");

            bytevideodos = DUDRecibiruno.Receive(ref sender2);

            Console.WriteLine("Recibio" + sender2.Address.ToString());
            Console.WriteLine("\n");

            DUDMandaruno.Send(bytevideodos, bytevideodos.Length);

            Console.WriteLine("Mando" + IP1);
            Console.WriteLine("\n");
        }
    }

    //Todo lo de la base

    public static String ValidarLogin(String NombreU, String ContraU)
    {

        conn.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "ValidarLogin";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@usuario", NombreU);
        cmd.Parameters.AddWithValue("@contrase", ContraU);

        String UserStuff = "";

        MySqlDataReader reader = cmd.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                UserStuff = reader.GetString("IdU") + "#" + reader.GetString("NameU")
                + "# " + reader.GetString("emailU") + "#" + reader.GetString("buzz")
                + "#" + reader.GetString("chat1") + "#" + reader.GetString("chat2")
                + "#" + reader.GetString("hora") + "#" + reader.GetString("camara")
                + "#" + reader.GetString("cuenta") + "#" + reader.GetString("game")
                + "#" + reader.GetString("mail");

            }
            cmd.Dispose();
            reader.Close();
            conn.Close();
            return UserStuff;
        }

        else
        {
            cmd.Dispose();
            reader.Close();
            conn.Close();
            return "";
        }

        return "";
    }

    public static void loss(int id)
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "Logro";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@aidi",id);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        conn.Close();
    }
    public static void yoghurt(int id)
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "light";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@aidi", id);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        conn.Close();
    }
    public static void Cind(int id)
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "ChatInd";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@aidi", id);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        conn.Close();
    }
    public static void Cgru(int id)
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "ChatGrup";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@aidi", id);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        conn.Close();
    }
    public static void camo(int id)
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "camera";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@aidi", id);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        conn.Close();
    }
    public static void banco(int id)
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "cuento";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@aidi", id);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        conn.Close();
    }
    public static void jugo(int id)
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "juego";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@aidi", id);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        conn.Close();
    }
    public static void correo(int id)
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "email";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@aidi", id);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        conn.Close();
    }
}
