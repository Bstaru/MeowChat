#region STREAMING
public void GetStream()
{
	while (startstream)     //SI HAY UN STREAMING, RECIBE LA IMAGEN COMO ARREGLO DE BYTES
	{
		Byte[] receiveBytes = socketrecibevideo.Receive(ref ipep);
		ReceiveStream(receiveBytes);
	}
}       //FUNCIÓN DEL HILO QUE CHECA SI HAY UN STREAMING ACTIVO

public void ReceiveStream(Byte[] byteImg)
{
	if (haystreaming == true)
	{
		imgchat = byteArrayToImage(byteImg);
		pb_you.SizeMode = PictureBoxSizeMode.StretchImage;
		pb_you.Image = imgchat;
	}
}           //RECIBE EL ARREGLO DE BYTES Y LO CONVIERTE A IMAGEN, LA CUAL SE PASA AL PICTUREBOX QUE MUESTRA AL OTRO USUARIO

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

public void SendStream(Image img)
{
	if (cb_encrypt.Checked == true)
	{
		UdpClient tempSocket = new UdpClient();
		Byte[] sendBytes = imageToByteArray(img);
		IPEndPoint tempipep = new IPEndPoint(ipa, 12446);
		tempSocket.Send(sendBytes, sendBytes.Length, tempipep);
	}
	else
	{
		UdpClient tempSocket = new UdpClient();
		Byte[] sendBytes = imageToByteArray(img);
		IPEndPoint tempipep = new IPEndPoint(ipa, 12446);
		tempSocket.Send(sendBytes, sendBytes.Length, tempipep);
	}
}                   //ENVÍA EL BYTE[] EEN QUE SE TRANSFORMO LA IMAGEN E INDICA QUE UN STREAMING HA COMENZADO
#endregion

#region OBTENER EL VIDEO/IMAGEN DE LA CAMARA
        
public void CargarDispositivos(FilterInfoCollection Dispositivos)
{
	for (int i = 0; i < Dispositivos.Count; i++) ;

	cb_selectcamera.Items.Add(Dispositivos[0].Name.ToString());
	cb_selectcamera.Text = cb_selectcamera.Items[0].ToString();
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
		MessageBox.Show("No tienes cámara");
	}
}

public void TerminarFuenteDeVideo()
{
	if (!(FuenteDeVideo == null))
		if (FuenteDeVideo.IsRunning)
		{
			FuenteDeVideo.SignalToStop();
			FuenteDeVideo = null;
		}
}

public void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
{
	Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
	pb_me.SizeMode = PictureBoxSizeMode.StretchImage;
	pb_me.Image = Imagen;
	imgstream = Imagen;
}

private void btn_selectcamera_Click(object sender, EventArgs e)
{
	if (btn_selectcamera.Text == "OK")
	{
		if (ExisteDispositivo)
		{
			FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cb_selectcamera.SelectedIndex].MonikerString);
			FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
			FuenteDeVideo.Start();
			btn_selectcamera.Text = "X";
			cb_selectcamera.Enabled = false;
			btn_beginstream.Enabled = true;
		}
		else
		{
			MessageBox.Show("Error: No se encuenta el Dispositivo");
		}
	}
	else
	{
		if (FuenteDeVideo.IsRunning)
		{
			TerminarFuenteDeVideo();
			btn_selectcamera.Text = "OK";
			btn_beginstream.Enabled = false;
			cb_selectcamera.Enabled = true;
		}
	}
}       //SELECCIONAR LA CAMARA DEL COMBOBOX

private void btn_beginstream_Click(object sender, EventArgs e)
{
	if (haystreaming == false)
	{
		tim_stream.Enabled = true;
		haystreaming = true;
	}
	else
	{
		tim_stream.Enabled = false;
		haystreaming = false;
	}
}        //INICIA EL STREAMING (BANDERAS)

private void tim_stream_Tick(object sender, EventArgs e)
{
	if (haystreaming == true)
	{
		startstream = true;
		SendStream(imgstream);
	}
	else
	{
		startstream = false;
	}
}              //(esta tambien)

private void btn_videochat_Click(object sender, EventArgs e)
{
	if (this.Width == 520)
	{
		this.BackgroundImage = P1POI.Properties.Resources.formachatprivado;
		this.Width = 770;
	}
	else
	{
		this.BackgroundImage = P1POI.Properties.Resources.formachatprivado2;
		this.Width = 520;
	}
}          //ABRE LAS OPCIONES DEL STREAM
#endregion