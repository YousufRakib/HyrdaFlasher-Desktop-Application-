using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyrdaFlasher
{
    public partial class login : Form
    {
        string walletAddress = "";
        public login(string wa)
        {
            InitializeComponent();
            walletAddress = wa;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "HydraFlasher" && txtPassword.Text == "f9237301064ab8b177815fd8fb0d0f")
            {
                excute objUI = new excute(walletAddress);
                objUI.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invaild");
            }

            //excute objUI = new excute(walletAddress);
            //objUI.Show();
            //this.Hide();
        }

     
        private void btnTelegram_Click(object sender, EventArgs e)
        {
            var uri = "https://t.me/hydraflasher";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }
    }
}
