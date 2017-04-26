using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientPOI.Forms
{
    public partial class frmFriends : Form
    {
        public static string NombreDeChat;
        List<String> Contacts = new List<String>();
        //public static string Estado;

        public frmFriends()
        {
            InitializeComponent();
         
        }

        public void add(String Nombre, String Estado)
        {
            String[] row = {Nombre, Estado};
            ListViewItem item = new ListViewItem(row);
            item.ForeColor = Color.White;
            lvAmigos.Items.Add(item);
        }

        private void frmFriends_Load(object sender, EventArgs e)
        {
            if(frmLogin.NomU == "Tomas")
            {
                Contacts.Add("Alfredo");
                Contacts.Add("Natalie");
            }

            if(frmLogin.NomU == "Natalie")
            {
                Contacts.Add("Tomas");
                Contacts.Add("Alfredo");
            }
          
            if(frmLogin.NomU == "Alfredo")
            {
                Contacts.Add("Tomas");
                Contacts.Add("Natalie");
            }
          

            int count = 0;
            foreach (String contact in Contacts)
            {
                if (frmLogin.NomU != contact)
                {
                    add(Contacts[count], "Desconectado");
                    count++;
                }
            }
        }

        private void lvAmigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAmigos.SelectedItems.Count > 0)
            {
                NombreDeChat = lvAmigos.SelectedItems[0].SubItems[0].Text;
                frmShatt pto = new frmShatt();

                lvAmigos.SelectedItems[0].UseItemStyleForSubItems = false;
                pto.lb_User2.Text = NombreDeChat;
                pto.lb_User.Text = frmLogin.NomU;
                pto.personal = true;
                pto.Show();
                if (frmLogin.chato1 == "0")
                {
                    frmMenu.Cliente = Encoding.ASCII.GetBytes("Logro%cind" + "%" + frmLogin.NomU + "%" + frmLogin.idU);
                    frmMenu.server.Send(frmMenu.Cliente);
                    MessageBox.Show("Nuevo logro!", "YEY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
