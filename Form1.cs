using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//********** namespaces Necesarios
using System.IO;
using System.Net;
using WatsonTcp;
namespace TCPIPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WatsonTcpClient client = null;  // Declarar el cliente
        private void btnConnect_Click(object sender, EventArgs e)
        {
            txtStatus.Clear(); // Limpiar status
            // Activar/Desactivar Botones
            btnDisconnect.Enabled = true;
            btnConnect.Enabled = false;

            string ip = IPAddress.Parse(txtHost.Text).ToString(); // Obtener ip del servidor al que se conectará el cliente
            int port = Convert.ToInt32(txtPort.Text);// Obtener puerto del servidor al que se conectará el cliente
            client = new WatsonTcpClient(ip, port); // Crear una nueva instancia del Cliente

            // Eventos manejados por WatsonTcp
            client.Events.ServerConnected += ServerConnected; // Se dispara al conectarse al servidor
            client.Events.ServerDisconnected += ServerDisconnected; // Se dispara al desconectarse del servidor
            client.Events.MessageReceived += MessageReceived; // Se dispara al recibir un Mensaje desde el servidor
            client.Callbacks.SyncRequestReceived = SyncRequestReceived; // Se dispara al recibir una petición Sincronica
            try
            {
                client.Connect();
                client.Send("Cliente Conectandose");
            }
            catch (System.Net.Sockets.SocketException se)
            {
                txtStatus.Text += "No se encontro el Servidor \r\n";
                btnDisconnect.Enabled = false;
                btnConnect.Enabled = true;
            }



        }
        private void MessageReceived(object sender, MessageReceivedEventArgs args)
        {
            if (args.Metadata == null)
            {
                txtStatus.Invoke((MethodInvoker)delegate ()
                {
                    txtStatus.Text = Encoding.UTF8.GetString(args.Data) + "\r\n";
                });
            }
            else
            {
                Dictionary<object, object> md = args.Metadata;
                string type = (string)md["type"];
                switch (type)
                {
                    case "text":

                        string text = "Mensaje de: " + args.IpPort + ": " + Encoding.UTF8.GetString(args.Data) + "\r\n";
                        invokeTxt(text);
                        tabControl1.Invoke((MethodInvoker)delegate()
                        {

                            if (tabControl1.SelectedIndex != 0)
                                invokeLbl("Notificación: Tiene un Mensaje Nuevo", lblNotify);
                        });

                        break;
                    case "img":
                        MemoryStream ms = new MemoryStream(args.Data);
                        pbReceivedImage.Image = Image.FromStream(ms);
                        tabControl1.Invoke((MethodInvoker)delegate ()
                        {

                            if (tabControl1.SelectedIndex != 2)
                                invokeLbl("Notificación: Tiene un Mensaje Nuevo", lblNotify);
                        });
                        break;
                }
            }



        }

        static void ServerConnected(object sender, ConnectionEventArgs args)
        {
            Console.WriteLine("Server " + args.IpPort + " connected");
        }

        private void ServerDisconnected(object sender, DisconnectionEventArgs args)
        {

            string text = "Se perdio la conexión con el servidor" + "\r\n";


            invokeTxt(text);
            client = null;
            btnDisconnect.Invoke((MethodInvoker)delegate ()
            {
                btnDisconnect.Enabled = false;
            });
            btnConnect.Invoke((MethodInvoker)delegate ()
            {
                btnConnect.Enabled = true;
            });

        }

        static SyncResponse SyncRequestReceived(SyncRequest req)
        {
            return new SyncResponse(req, "Hello back at you!");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client == null || !client.Connected)
            {
                txtStatus.Text += "No Exite conexión con el servidor \r\n";
                return;
            }
            // Enviar Mensaje de texto
            if (!txtSend.Text.Equals(""))
            {
                string msg = txtSend.Text;
                string ipClient = txtIPClient.Text;
                Dictionary<object, object> md = new Dictionary<object, object>();
                md.Add("action", "sendTxt");
                md.Add("type", "broadcast");
                client.Send(msg, md);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDisconnect.Enabled = false;
            btnSendImageAll.Enabled = false;
            btnSendImageOne.Enabled = false;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (client != null && client.Connected)
            {
                client.Disconnect();
            }

            btnDisconnect.Enabled = false;
            btnConnect.Enabled = true;
        }

        private void btnSendOne_Click(object sender, EventArgs e)
        {
            if (client == null || !client.Connected)
            {
                txtStatus.Text += "No Exite conexión con el servidor \r\n";
                return;
            }
            if (!txtSend.Text.Equals(""))
            {
                string msg = txtSend.Text;
                string ipClient = txtIPClient.Text;
                Dictionary<object, object> md = new Dictionary<object, object>();
                md.Add("action", "sendTxt");
                md.Add("type", "one");
                md.Add("ipClient", ipClient);

                client.Send(msg, md);
            }
        }

        private void btnSendImageAll_Click(object sender, EventArgs e)
        {
            if (client == null || !client.Connected)
            {
                txtStatus.Text += "No Exite conexión con el servidor \r\n";
                return;
            }
            Dictionary<object, object> md = new Dictionary<object, object>();
            byte[] data = File.ReadAllBytes(openFileDialog.FileName);
            md.Add("action", "sendImg");
            md.Add("type", "broadcast");
            client.Send(data, md);
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Elija un archivo de imagen.....";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pbSelectedImage.Image = Image.FromFile(openFileDialog.FileName);
                btnSendImageAll.Enabled = true;
                btnSendImageOne.Enabled = true;
            }
        }

        private void btnSendImageOne_Click(object sender, EventArgs e)
        {
            if (client == null || !client.Connected)
            {
                txtStatus.Text += "No Exite conexión con el servidor \r\n";
                return;
            }
            string ipClient = txtIPClienteImg.Text;
            Dictionary<object, object> md = new Dictionary<object, object>();
            byte[] data = File.ReadAllBytes(openFileDialog.FileName);
            md.Add("action", "sendImg");
            md.Add("type", "one");
            md.Add("ipClient", ipClient);
            client.Send(data, md);
        }

        private void txtIPClient_TextChanged(object sender, EventArgs e)
        {
            txtIPClienteImg.Text = txtIPClient.Text;
        }

        private void txtIPClienteImg_TextChanged(object sender, EventArgs e)
        {
            txtIPClient.Text = txtIPClienteImg.Text;
        }
        private void invokeLbl(string txt, Label lbl)
        {
            lbl.Invoke((MethodInvoker)delegate ()
            {
                lbl.Text = txt;
            });
        }
        private void invokeTxt(string txt)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += txt;
            });
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {

                case 0:
                    {
                        lblNotify.Text = "";
                        break;
                    }
                case 2:
                    {
                        lblNotifyImg.Text = "";
                        break;
                    }
            }
        }
    }
}
