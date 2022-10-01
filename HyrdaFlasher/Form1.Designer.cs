using System.Drawing;

namespace HyrdaFlasher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblWallet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSendTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnRandomAmount = new System.Windows.Forms.Button();
            this.rbtnBTC = new System.Windows.Forms.RadioButton();
            this.rbtnETH = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnSatByte = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChekcAddress = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblOs = new System.Windows.Forms.Label();
            this.lblOsPlatForm = new System.Windows.Forms.Label();
            this.lblVirtualMemory = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPhyisicalMomory = new System.Windows.Forms.Label();
            this.btnBroadcastTransaction = new System.Windows.Forms.Button();
            this.chkeAgree = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.conToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.walletSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telegramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ownerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wallet: ";
            // 
            // lblWallet
            // 
            this.lblWallet.AutoSize = true;
            this.lblWallet.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallet.Location = new System.Drawing.Point(54, 41);
            this.lblWallet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWallet.Name = "lblWallet";
            this.lblWallet.Size = new System.Drawing.Size(272, 24);
            this.lblWallet.TabIndex = 1;
            this.lblWallet.Text = "14f92373-0106-4ab8-b177-815fd8fb0d0f";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Send To: ";
            // 
            // txtSendTo
            // 
            this.txtSendTo.Location = new System.Drawing.Point(57, 66);
            this.txtSendTo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtSendTo.MaxLength = 50000;
            this.txtSendTo.Name = "txtSendTo";
            this.txtSendTo.Size = new System.Drawing.Size(266, 31);
            this.txtSendTo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(57, 98);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtAmount.MaxLength = 100;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(171, 31);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // btnRandomAmount
            // 
            this.btnRandomAmount.Location = new System.Drawing.Point(245, 102);
            this.btnRandomAmount.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnRandomAmount.Name = "btnRandomAmount";
            this.btnRandomAmount.Size = new System.Drawing.Size(78, 25);
            this.btnRandomAmount.TabIndex = 6;
            this.btnRandomAmount.Text = "Random Amount";
            this.btnRandomAmount.UseVisualStyleBackColor = true;
            this.btnRandomAmount.Click += new System.EventHandler(this.btnRandomAmount_Click);
            // 
            // rbtnBTC
            // 
            this.rbtnBTC.AutoSize = true;
            this.rbtnBTC.Checked = true;
            this.rbtnBTC.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBTC.Location = new System.Drawing.Point(57, 129);
            this.rbtnBTC.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rbtnBTC.Name = "rbtnBTC";
            this.rbtnBTC.Size = new System.Drawing.Size(58, 28);
            this.rbtnBTC.TabIndex = 7;
            this.rbtnBTC.TabStop = true;
            this.rbtnBTC.Text = "BTC";
            this.rbtnBTC.UseVisualStyleBackColor = true;
            // 
            // rbtnETH
            // 
            this.rbtnETH.AutoSize = true;
            this.rbtnETH.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnETH.Location = new System.Drawing.Point(121, 129);
            this.rbtnETH.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rbtnETH.Name = "rbtnETH";
            this.rbtnETH.Size = new System.Drawing.Size(58, 28);
            this.rbtnETH.TabIndex = 8;
            this.rbtnETH.TabStop = true;
            this.rbtnETH.Text = "ETH";
            this.rbtnETH.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.btnSatByte);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(7, 157);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 228);
            this.panel1.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-3, 177);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(320, 24);
            this.label12.TabIndex = 22;
            this.label12.Text = "**************************************************************";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(22, 192);
            this.label17.Margin = new System.Windows.Forms.Padding(1, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 29);
            this.label17.TabIndex = 15;
            this.label17.Text = "Timer";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(85, 160);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(117, 28);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Socks by 911";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(85, 121);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(136, 28);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Socks by VIP72";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnSatByte
            // 
            this.btnSatByte.Location = new System.Drawing.Point(75, 75);
            this.btnSatByte.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnSatByte.Name = "btnSatByte";
            this.btnSatByte.Size = new System.Drawing.Size(69, 28);
            this.btnSatByte.TabIndex = 12;
            this.btnSatByte.Text = "sat/byte";
            this.btnSatByte.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(7, 121);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 28);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Default Proxy";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 79);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(63, 31);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "1300";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(7, 43);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 28);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Transation Fee";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Advance Options";
            // 
            // btnChekcAddress
            // 
            this.btnChekcAddress.Location = new System.Drawing.Point(364, 386);
            this.btnChekcAddress.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnChekcAddress.Name = "btnChekcAddress";
            this.btnChekcAddress.Size = new System.Drawing.Size(75, 28);
            this.btnChekcAddress.TabIndex = 11;
            this.btnChekcAddress.Text = "Check Address";
            this.btnChekcAddress.UseVisualStyleBackColor = true;
            this.btnChekcAddress.Click += new System.EventHandler(this.btnChekcAddress_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Computer Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Phyisical Memory: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total Virtual Memory: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "AVAN Virtual Memory: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 154);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Os Version: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 176);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "OS Platform: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHost.Location = new System.Drawing.Point(7, 199);
            this.lblHost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(42, 24);
            this.lblHost.TabIndex = 16;
            this.lblHost.Text = "5555";
            this.lblHost.Click += new System.EventHandler(this.lblHost_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblOs);
            this.panel2.Controls.Add(this.lblOsPlatForm);
            this.panel2.Controls.Add(this.lblVirtualMemory);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lblPhyisicalMomory);
            this.panel2.Controls.Add(this.lblHost);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(186, 158);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 227);
            this.panel2.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 137);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(385, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "***************************************************************************";
            // 
            // lblOs
            // 
            this.lblOs.AutoSize = true;
            this.lblOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOs.Location = new System.Drawing.Point(65, 178);
            this.lblOs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOs.Name = "lblOs";
            this.lblOs.Size = new System.Drawing.Size(56, 25);
            this.lblOs.TabIndex = 20;
            this.lblOs.Text = "5555";
            // 
            // lblOsPlatForm
            // 
            this.lblOsPlatForm.AutoSize = true;
            this.lblOsPlatForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOsPlatForm.Location = new System.Drawing.Point(61, 154);
            this.lblOsPlatForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOsPlatForm.Name = "lblOsPlatForm";
            this.lblOsPlatForm.Size = new System.Drawing.Size(45, 25);
            this.lblOsPlatForm.TabIndex = 19;
            this.lblOsPlatForm.Text = "555";
            // 
            // lblVirtualMemory
            // 
            this.lblVirtualMemory.AutoSize = true;
            this.lblVirtualMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVirtualMemory.Location = new System.Drawing.Point(132, 81);
            this.lblVirtualMemory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVirtualMemory.Name = "lblVirtualMemory";
            this.lblVirtualMemory.Size = new System.Drawing.Size(0, 25);
            this.lblVirtualMemory.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(132, 113);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 25);
            this.label13.TabIndex = 17;
            this.label13.Text = "20155896699";
            // 
            // lblPhyisicalMomory
            // 
            this.lblPhyisicalMomory.AutoSize = true;
            this.lblPhyisicalMomory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhyisicalMomory.Location = new System.Drawing.Point(132, 50);
            this.lblPhyisicalMomory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhyisicalMomory.Name = "lblPhyisicalMomory";
            this.lblPhyisicalMomory.Size = new System.Drawing.Size(0, 25);
            this.lblPhyisicalMomory.TabIndex = 12;
            // 
            // btnBroadcastTransaction
            // 
            this.btnBroadcastTransaction.Location = new System.Drawing.Point(7, 386);
            this.btnBroadcastTransaction.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnBroadcastTransaction.Name = "btnBroadcastTransaction";
            this.btnBroadcastTransaction.Size = new System.Drawing.Size(112, 28);
            this.btnBroadcastTransaction.TabIndex = 12;
            this.btnBroadcastTransaction.Text = "Broadcast Transaction";
            this.btnBroadcastTransaction.UseVisualStyleBackColor = true;
            this.btnBroadcastTransaction.Click += new System.EventHandler(this.btnBroadcastTransaction_Click);
            // 
            // chkeAgree
            // 
            this.chkeAgree.AutoSize = true;
            this.chkeAgree.Location = new System.Drawing.Point(120, 391);
            this.chkeAgree.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.chkeAgree.Name = "chkeAgree";
            this.chkeAgree.Size = new System.Drawing.Size(351, 28);
            this.chkeAgree.TabIndex = 13;
            this.chkeAgree.Text = "I agree to only use C.F.T in agrement to the EULA";
            this.chkeAgree.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.conToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(462, 32);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 28);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(258, 34);
            this.toolStripMenuItem2.Text = "Download Bitcoin Core";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(258, 34);
            this.toolStripMenuItem3.Text = "Exit";
            // 
            // conToolStripMenuItem
            // 
            this.conToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.walletSettingsToolStripMenuItem});
            this.conToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conToolStripMenuItem.Name = "conToolStripMenuItem";
            this.conToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.conToolStripMenuItem.Text = "Settings";
            // 
            // walletSettingsToolStripMenuItem
            // 
            this.walletSettingsToolStripMenuItem.Name = "walletSettingsToolStripMenuItem";
            this.walletSettingsToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.walletSettingsToolStripMenuItem.Text = "Wallet Settings";
            this.walletSettingsToolStripMenuItem.Click += new System.EventHandler(this.walletSettingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactUsToolStripMenuItem,
            this.ownerToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 28);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mailToolStripMenuItem,
            this.telegramToolStripMenuItem});
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            // 
            // mailToolStripMenuItem
            // 
            this.mailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gmailToolStripMenuItem,
            this.protonToolStripMenuItem});
            this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
            this.mailToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.mailToolStripMenuItem.Text = "Mail";
            // 
            // gmailToolStripMenuItem
            // 
            this.gmailToolStripMenuItem.Name = "gmailToolStripMenuItem";
            this.gmailToolStripMenuItem.Size = new System.Drawing.Size(154, 34);
            this.gmailToolStripMenuItem.Text = "Gmail";
            this.gmailToolStripMenuItem.Click += new System.EventHandler(this.gmailToolStripMenuItem_Click);
            // 
            // protonToolStripMenuItem
            // 
            this.protonToolStripMenuItem.Name = "protonToolStripMenuItem";
            this.protonToolStripMenuItem.Size = new System.Drawing.Size(154, 34);
            this.protonToolStripMenuItem.Text = "Proton";
            this.protonToolStripMenuItem.Click += new System.EventHandler(this.protonToolStripMenuItem_Click);
            // 
            // telegramToolStripMenuItem
            // 
            this.telegramToolStripMenuItem.Name = "telegramToolStripMenuItem";
            this.telegramToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.telegramToolStripMenuItem.Text = "Telegram";
            this.telegramToolStripMenuItem.Click += new System.EventHandler(this.telegramToolStripMenuItem_Click);
            // 
            // ownerToolStripMenuItem
            // 
            this.ownerToolStripMenuItem.Name = "ownerToolStripMenuItem";
            this.ownerToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.ownerToolStripMenuItem.Text = "Owner";
            this.ownerToolStripMenuItem.Click += new System.EventHandler(this.ownerToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(326, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(462, 421);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkeAgree);
            this.Controls.Add(this.btnBroadcastTransaction);
            this.Controls.Add(this.btnChekcAddress);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbtnETH);
            this.Controls.Add(this.rbtnBTC);
            this.Controls.Add(this.btnRandomAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSendTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWallet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hydra flasher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWallet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSendTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnRandomAmount;
        private System.Windows.Forms.RadioButton rbtnBTC;
        private System.Windows.Forms.RadioButton rbtnETH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnSatByte;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnChekcAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOs;
        private System.Windows.Forms.Label lblOsPlatForm;
        private System.Windows.Forms.Label lblVirtualMemory;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPhyisicalMomory;
        private System.Windows.Forms.Button btnBroadcastTransaction;
        private System.Windows.Forms.CheckBox chkeAgree;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem conToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telegramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ownerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem protonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem walletSettingsToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
    }
}

