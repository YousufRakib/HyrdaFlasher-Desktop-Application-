using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyrdaFlasher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string name = System.Environment.MachineName;
            lblHost.Text = "Host Name: " + name;
            ulong ram = (new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory) / (1024);
            lblPhyisicalMomory.Text = ram.ToString() + " Bytes";
            ComputerInfo myCompInfo = new ComputerInfo();
            ulong VirtualMemory = (new Microsoft.VisualBasic.Devices.ComputerInfo().TotalVirtualMemory);
            lblVirtualMemory.Text = VirtualMemory.ToString();
            OperatingSystem os = Environment.OSVersion;
            lblOsPlatForm.Text = os.ToString();
            OperatingSystem os1 = Environment.OSVersion;
            PlatformID pid = os.Platform;
            lblOs.Text = pid.ToString();
            

            timer1.Start();
            // ManagementObjectSearcher Search = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");

            //foreach (ManagementObject Mobject in Search.Get())
            //{


            //    double Ram_Bytes = (Convert.ToDouble(Mobject["TotalPhysicalMemory"]));

            //    MessageBox.Show("RAM Size in Kilo Bytes: {0}", (Ram_Bytes / 1024).ToString());
            //    MessageBox.Show("RAM Size in Mega Bytes: {0}", (Ram_Bytes / 1048576).ToString());
            //    MessageBox.Show("RAM Size in Giga Bytes: {0}", (Ram_Bytes / 1073741824).ToString());
            //}


        }



        private void telegramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var uri = "https://t.me/hydraflasher";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void ownerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            popUp objUI = new popUp();
            objUI.Show();

        }



        private void btnChekcAddress_Click(object sender, EventArgs e)
        {
            var uri = "https://hydraflasher.com/?fbclid=IwAR0zkbhSc7L67oRxXRyOwYPs5d3IRiRRpFaLiJukOyqQwWZ7UOlNkgx5wj0";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void btnBroadcastTransaction_Click(object sender, EventArgs e)
        {
            if (txtSendTo.TextLength < 20)
            {
                MessageBox.Show("Invaild wallet address");
                return;
            }
            if (txtAmount.Text != "")
            {
                if (Convert.ToDouble(txtAmount.Text) < 0 || Convert.ToDouble(txtAmount.Text) > 101)
                {
                    MessageBox.Show("Insert valid amount");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Insert valid amount");
                return;
            }

            if (!chkeAgree.Checked)
            {
                MessageBox.Show("Please  agree to only use C.F.T in agrement to the EULA");
                return;
            }
            if (WalletSetting.SetValueForBroadCast == "" || WalletSetting.SetValueForBroadCast != "Ok")
            {
                MessageBox.Show("Please  excute hash code");
                return;
            }
            if (chkeAgree.Checked == true && WalletSetting.SetValueForBroadCast == "Ok")
            {
                login objUI = new login(txtSendTo.Text);
                objUI.Show();
            }

            //login objUI = new login(txtSendTo.Text);
            //objUI.Show();
        }

        private void gmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var uri = "mailto:hydrabtcflasher@gmail.com";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void protonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var uri = "mailto:hydraflasher@protonmail.com";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void walletSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WalletSetting objUI = new WalletSetting();
            objUI.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblHost_Click(object sender, EventArgs e)
        {

        }



        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var uri = "https://hydraflasher.com/";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void btnRandomAmount_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "1.2";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // / Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label17.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }
    }
}
