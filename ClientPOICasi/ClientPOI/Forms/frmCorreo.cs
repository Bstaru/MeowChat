using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace ClientPOI.Forms
{
    public partial class frmCorreo : Form
    {
        public frmCorreo()
        {
            InitializeComponent();
        }

        private void frmCorreo_Load(object sender, EventArgs e)
        {

        }

        private void archivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbArchivo.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                MailMessage message = new MailMessage();
                message.From = new MailAddress(frmLogin.emailU);

                message.To.Add(txtToEmail.Text);
                message.Body = (txtContenidoEmail.Text);
                message.Subject = txtAsunEmail.Text;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;

                message.Attachments.Add(new Attachment(tbArchivo.Text));

                client.Credentials = new System.Net.NetworkCredential("bstaru95@gmail.com", "shineekey91");
                client.Send(message);
                message = null;

                MessageBox.Show("Se ha enviado tu wea al correo existosamente!");
                if (frmLogin.mail == "0")
                {
                    frmMenu.Cliente = Encoding.ASCII.GetBytes("Logro%email" + "%" + frmLogin.NomU + "%" + frmLogin.idU);
                    frmMenu.server.Send(frmMenu.Cliente);
                    MessageBox.Show("Nuevo logro!", "YEY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch //(Exception s)
            {
                MessageBox.Show("hubo error shavo D:!");
            }
        }
    }
}
