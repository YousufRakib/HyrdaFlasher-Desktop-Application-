using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyrdaFlasher
{
    public partial class excute : Form
    {
        Bitmap bitmap;
        string walletAddress = "";
        public excute(string wa)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(excute));
            InitializeComponent();
            bitmap= new Bitmap ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            //bitmap = new Bitmap(Image.FromFile(Application.StartupPath + "\\Images\\hydra.png"));
            //bitmap = new Bitmap(Image.FromFile(@"D:\pic\hydra.png"));
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image=((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            //pictureBox2.Image = bitmap;
            walletAddress = wa;
        }

        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            if (counter > 50)
            {
                timer1.Stop();
                pictureBox2.Hide();
                label1.Text = "Wallet Address: " + walletAddress + " " +Environment.NewLine + "Fund Send Successfully" + Environment.NewLine + "Now Conncet Your Trust Wallet to Metamask."; 
            }
            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox2.Image = null;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = bitmap;

            counter++;
        }
    }
}
