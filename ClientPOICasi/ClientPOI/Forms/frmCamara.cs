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

using System.Media;
using System.Diagnostics;
using System.IO;

using AForge.Video;
using AForge.Video.DirectShow;

namespace ClientPOI.Forms
{
    public partial class frmCamara : Form
    {
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo;
        bool ExisteDispositivo;

        Bitmap imgstream;
        Image imgchat;

        public static bool haystreaming = false;
        bool startstream = false;
        public bool yaempezo = false;
        public static UdpClient DudRecibir;


        public frmCamara()
        {
            InitializeComponent();

            if (frmMenu.yousend)
            {
                DudRecibir = new UdpClient(9998);
            }
            if (frmMenu.ireceive)
            {
                DudRecibir = new UdpClient(667);
            }

            BuscarDispositivos();
        }

        private void frmCamara_Load(object sender, EventArgs e)
        {
        }

        public void BuscarDispositivos()
        {
            try
            {
                DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (DispositivoDeVideo.Count == 0)
                {
                    ExisteDispositivo = false;
                }
                else
                {
                    ExisteDispositivo = true;
                    CargarDispositivos(DispositivoDeVideo);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No tienes cámara .... pndjo");
            }
        }

        public void CargarDispositivos (FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++) ;

            cameras.Items.Add(Dispositivos[0].Name.ToString());
            cameras.Text = cameras.Items[0].ToString();

            if (ExisteDispositivo)
            {
                FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cameras.SelectedIndex].MonikerString);
                FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
                FuenteDeVideo.Start();
                oc.Text = "X";
                cameras.Enabled = false;
                Empezar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error: No se encontro el dispositivo de video");
            }
        }

        public void Video_NuevoFrame (object sender, NewFrameEventArgs eventArgs)
        {
            if (yaempezo == false)
            {
                if (cam1.InvokeRequired)
                    cam1.Invoke((MethodInvoker)delegate ()
                {
                    Video_NuevoFrame(sender, eventArgs);
                });
                else
                {
                    Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
                    cam1.SizeMode = PictureBoxSizeMode.StretchImage;
                    cam1.Image = Imagen;
                    imgstream = Imagen;
                    startstream = false;

                     if (haystreaming)
                    {
                        if (frmMenu.ireceive)
                        {
                            GetStream();
                            SendStream(imgstream);
                        }
                        if (frmMenu.yousend)
                        {
                            SendStream(imgstream);
                            GetStream();                                                     
                        }
                    }

                }
            }
            else
            {
                haystreaming = true;
                yaempezo = false;
                startstream = true;

                if (frmMenu.ireceive)
                { 
                    //GetStream();
                    SendStream(imgstream);
                }
                if (frmMenu.yousend)
                {
                    SendStream(imgstream);
                    GetStream();
                }
            }
        }

        private void Empezar_Click(object sender, EventArgs e)
        {
            byte[] videojej = new byte[1024];
            videojej = Encoding.ASCII.GetBytes("YaEmpiezale%" + frmMenu.NombrePerVideollamda + "%" + frmLogin.NomU);
            frmMenu.server.Send(videojej);
            yaempezo = true;

        }

        public Byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }       //CONVIERTE LA IMAGEN A BYTE[]

        public Image byteArrayToImage(Byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }   //CONVIERTE EL BYTE[] A IMAGEN

        public void GetStream()
        {
            if (haystreaming)
            {
                IPEndPoint sender = null;
                if (frmMenu.ireceive)
                {
                    sender = new IPEndPoint(IPAddress.Any, 667);
                }

                if (frmMenu.yousend)
                {
                    sender = new IPEndPoint(IPAddress.Any, 9998);
                }

                Byte[] receiveBytes = DudRecibir.Receive(ref sender);
                ReceiveStream(receiveBytes);
            }
        }
        public void SendStream(Image img)
        {
            Image newimage = ResizeImage(img, new Size(640, 480));
            Byte[] sendBytes = imageToByteArray(newimage);
            frmMenu.DudMandar.Send(sendBytes, sendBytes.Length);
        }

        public static Image ResizeImage (Image image, Size newSize)
        {
            Image newImage = new Bitmap(newSize.Width, newSize.Height);

            using (Graphics GFX = Graphics.FromImage((Bitmap)newImage))
            {
                GFX.DrawImage(image, new Rectangle(Point.Empty, newSize));
            }
            return newImage;
        }

        public void ReceiveStream (Byte[] byteImg)
        {
            if(haystreaming == true)
            {
                imgchat = byteArrayToImage(byteImg);
                cam2.SizeMode = PictureBoxSizeMode.StretchImage;
                cam2.Image = imgchat;
            }
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            if (haystreaming)
            {
                startstream = true;
                SendStream(imgstream);
                GetStream();
            }
            else
            {
                startstream = false;
            }
        }



        private void Empezar2_Click_1(object sender, EventArgs e)
        {
            haystreaming = true;
        }
    }
}
