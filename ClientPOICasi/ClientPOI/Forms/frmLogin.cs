using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientPOI;
namespace ClientPOI.Forms
{
    public partial class frmLogin : Form
    {
        public static String NomU;
        public static String ContraU;
        public static String EstU;
        public static String emailU;
        public static String idU;

        //logros
        public static String zumba,chato1,chato2,camm,ora,cuenta,jugo,mail;
    

        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void bttnEnter_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "")
            {

                NomU = txtUser.Text;
                ContraU = txtContra.Text;
                EstU = cbEst.SelectedItem.ToString();

                frmMenu menu = new frmMenu();
                menu.Show();
                this.Hide();
            }
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void chckBxRemeberMe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblServer_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
