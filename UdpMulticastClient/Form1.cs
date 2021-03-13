using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdpMulticastClient
{
    public partial class Form1 : Form
    {
        private UdpClient udpClient;
        private bool isConnected = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                string address = txtAddress.Text;
                int port;
                IPAddress ip = IPAddress.Parse(address);
                int.TryParse(txtPort.Text, out port);
                udpClient = new UdpClient(port);
                udpClient.JoinMulticastGroup(ip);
                udpClient.BeginReceive(DataReceived, null);
                btnConnect.Text = "Disconnect";
                btnConnect.BackColor = Color.Tomato;
                isConnected = true;
            }
            else
            {
                udpClient.Close();
                btnConnect.Text = "Connect";
                btnConnect.BackColor = Color.Chartreuse;
                isConnected = false;
            }
        }
        private void DataReceived(IAsyncResult ar)
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 0);
            byte[] data;
            try
            {
                data = udpClient.EndReceive(ar, ref ip);
                if (data.Length == 0)
                {
                    return;
                }
                udpClient.BeginReceive(DataReceived, null);
            }
            catch (Exception)
            {
                return;
            }
            this.BeginInvoke((Action<IPEndPoint, byte[]>)OnDataReceived, ip, data);
        }
        private void OnDataReceived(IPEndPoint endPoint, byte[] dataBytes)
        {
            string data = Encoding.Default.GetString(dataBytes);
            txtConsole.AppendText(string.Format("{0}\n", data));
        }
    }
}
