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
    public partial class WalletSetting : Form
    {
        public static string SetValueForBroadCast = "";
        public WalletSetting()
        {
            InitializeComponent();
        }

        private void btnIntegrateSetttung_Click(object sender, EventArgs e)
        {
            if (txtAddress.TextLength < 20)
            {
                MessageBox.Show("Invaild wallet address");
                return;
            }
          
            if (richTextBox1.Text.Trim() == "AAAAB3NzaC1yc2EAAAADAQABAAABAQDBZGFefYyFYKSW8dJYQ7F0VztW8E3EbDXYjH7hmjCl1vhfjJKLYCwY7mBth5d4pmmlyUIuKGazcW17K2PPDRWLYI72Vh+VN7tEW0ekP+YBChM37WzDvQ33ZLP9LRxwNeCUI9BAuNDHw7ljUCYqH6Fgm2WXgxrRr/qiIo3HrxIiVIo2s4hmHQXrRuQAEdmKVsIah6FZLgov0wSTGBiRP1HGRfA73/izgsvzUpdDZVsFcE8v7hQSy+kebMhZEeLvgBG966KLOd5UtQxT9tkxnfk1UpoLPwsHAqBdMBd4wMBMYeOotZqqcvawqlHb1W1pjwbnoeQY3EZ4gkLus93lTnAl")
            {
                MessageBox.Show("Success");
                SetValueForBroadCast = "Ok";
                Form1 objUI = new Form1();
                objUI.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

      
    }
}
