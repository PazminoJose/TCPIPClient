
namespace TCPIPClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIPClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSendOne = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnSendAll = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSendImageOne = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIPClienteImg = new System.Windows.Forms.TextBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.pbSelectedImage = new System.Windows.Forms.PictureBox();
            this.btnSendImageAll = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pbReceivedImage = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNotify = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblNotifyImg = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedImage)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReceivedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(65, 98);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(125, 27);
            this.txtHost.TabIndex = 2;
            this.txtHost.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(251, 98);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(125, 27);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "2000";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(410, 89);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 45);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(526, 89);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(105, 45);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Desconectar";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 150);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(619, 640);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtIPClient);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnSendOne);
            this.tabPage1.Controls.Add(this.txtStatus);
            this.tabPage1.Controls.Add(this.btnSendAll);
            this.tabPage1.Controls.Add(this.txtSend);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(611, 607);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enviar Texto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mensaje:";
            // 
            // txtIPClient
            // 
            this.txtIPClient.Location = new System.Drawing.Point(86, 105);
            this.txtIPClient.Name = "txtIPClient";
            this.txtIPClient.Size = new System.Drawing.Size(143, 27);
            this.txtIPClient.TabIndex = 5;
            this.txtIPClient.TextChanged += new System.EventHandler(this.txtIPClient_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP Cliente:";
            // 
            // btnSendOne
            // 
            this.btnSendOne.Location = new System.Drawing.Point(245, 96);
            this.btnSendOne.Name = "btnSendOne";
            this.btnSendOne.Size = new System.Drawing.Size(133, 45);
            this.btnSendOne.TabIndex = 3;
            this.btnSendOne.Text = "Enviar A Cliente";
            this.btnSendOne.UseVisualStyleBackColor = true;
            this.btnSendOne.Click += new System.EventHandler(this.btnSendOne_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(6, 161);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(596, 443);
            this.txtStatus.TabIndex = 2;
            // 
            // btnSendAll
            // 
            this.btnSendAll.Location = new System.Drawing.Point(417, 96);
            this.btnSendAll.Name = "btnSendAll";
            this.btnSendAll.Size = new System.Drawing.Size(185, 45);
            this.btnSendAll.TabIndex = 1;
            this.btnSendAll.Text = "Enviar a Todos";
            this.btnSendAll.UseVisualStyleBackColor = true;
            this.btnSendAll.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(6, 49);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(596, 27);
            this.txtSend.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnSendImageOne);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtIPClienteImg);
            this.tabPage2.Controls.Add(this.btnSelectImage);
            this.tabPage2.Controls.Add(this.pbSelectedImage);
            this.tabPage2.Controls.Add(this.btnSendImageAll);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(611, 607);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Enviar Imagen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Previsualizar Imagen:";
            // 
            // btnSendImageOne
            // 
            this.btnSendImageOne.Location = new System.Drawing.Point(252, 29);
            this.btnSendImageOne.Name = "btnSendImageOne";
            this.btnSendImageOne.Size = new System.Drawing.Size(135, 54);
            this.btnSendImageOne.TabIndex = 1;
            this.btnSendImageOne.Text = "Enviar a Cliente";
            this.btnSendImageOne.UseVisualStyleBackColor = true;
            this.btnSendImageOne.Click += new System.EventHandler(this.btnSendImageOne_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "IP Cliente:";
            // 
            // txtIPClienteImg
            // 
            this.txtIPClienteImg.Location = new System.Drawing.Point(83, 43);
            this.txtIPClienteImg.Name = "txtIPClienteImg";
            this.txtIPClienteImg.Size = new System.Drawing.Size(143, 27);
            this.txtIPClienteImg.TabIndex = 7;
            this.txtIPClienteImg.TextChanged += new System.EventHandler(this.txtIPClienteImg_TextChanged);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(20, 107);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(156, 41);
            this.btnSelectImage.TabIndex = 4;
            this.btnSelectImage.Text = "Seleccionar Imagen";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // pbSelectedImage
            // 
            this.pbSelectedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSelectedImage.Location = new System.Drawing.Point(20, 154);
            this.pbSelectedImage.Name = "pbSelectedImage";
            this.pbSelectedImage.Size = new System.Drawing.Size(569, 419);
            this.pbSelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSelectedImage.TabIndex = 2;
            this.pbSelectedImage.TabStop = false;
            // 
            // btnSendImageAll
            // 
            this.btnSendImageAll.Location = new System.Drawing.Point(428, 29);
            this.btnSendImageAll.Name = "btnSendImageAll";
            this.btnSendImageAll.Size = new System.Drawing.Size(161, 54);
            this.btnSendImageAll.TabIndex = 0;
            this.btnSendImageAll.Text = "Enviar a Todos";
            this.btnSendImageAll.UseVisualStyleBackColor = true;
            this.btnSendImageAll.Click += new System.EventHandler(this.btnSendImageAll_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pbReceivedImage);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(611, 607);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Imagen Recibida";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pbReceivedImage
            // 
            this.pbReceivedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbReceivedImage.Location = new System.Drawing.Point(12, 17);
            this.pbReceivedImage.Name = "pbReceivedImage";
            this.pbReceivedImage.Size = new System.Drawing.Size(587, 587);
            this.pbReceivedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbReceivedImage.TabIndex = 1;
            this.pbReceivedImage.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Conectarse a:";
            // 
            // lblNotify
            // 
            this.lblNotify.AutoSize = true;
            this.lblNotify.Location = new System.Drawing.Point(346, 8);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(0, 20);
            this.lblNotify.TabIndex = 8;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openD";
            // 
            // lblNotifyImg
            // 
            this.lblNotifyImg.AutoSize = true;
            this.lblNotifyImg.Location = new System.Drawing.Point(346, 41);
            this.lblNotifyImg.Name = "lblNotifyImg";
            this.lblNotifyImg.Size = new System.Drawing.Size(0, 20);
            this.lblNotifyImg.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 802);
            this.Controls.Add(this.lblNotifyImg);
            this.Controls.Add(this.lblNotify);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TCP/IP CLIENT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedImage)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReceivedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSendAll;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSendOne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIPClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbSelectedImage;
        private System.Windows.Forms.Button btnSendImageOne;
        private System.Windows.Forms.Button btnSendImageAll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.TextBox txtIPClienteImg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pbReceivedImage;
        private System.Windows.Forms.Label lblNotify;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblNotifyImg;
    }
}

