using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();

        public Form1()
        {
            InitializeComponent();

            var dbCheckerThread = new Thread(CheckSomethingInDb);
            dbCheckerThread.IsBackground = true;
            dbCheckerThread.Start();
            //Console.WriteLine("... the application is running further...");
            //Console.Read();

        }

        public  void CheckSomethingInDb()
        {
            while (true)
            {
                // do periodical check 
                Console.WriteLine("Periodical check");
                if (listBox1.InvokeRequired)
                {
                    listBox1.Invoke(new MethodInvoker(delegate { listBox1.Items.Add("Periodic check"); }));
                }
                //box.Text = "Periodical check";
                Thread.Sleep(5000);
            }
        }
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        private void Form1_Load(object sender, EventArgs e)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            textLocalIp.Text = GetLocalIP();
            textFriendsIp.Text = GetLocalIP();
            textLocalPort.Text = GetFreeTcpPort().ToString();
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            { // binding socket
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
                sck.Bind(epLocal);

                // connect to remote IP and port
                epRemote = new IPEndPoint(IPAddress.Parse(textFriendsIp.Text), Convert.ToInt32(textFriendsPort.Text));
                sck.Connect(epRemote);

                // starts to listen to an specific port
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new
                AsyncCallback(MessageCallBack), buffer);

                // release button to send message
                buttonSend.Enabled = true;
                buttonStart.Text = "Connected";
                buttonStart.Enabled = false;
                textMessage.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
        static int GetFreeTcpPort()
        {
            TcpListener l = new TcpListener(IPAddress.Loopback, 0);
            l.Start();
            int port = ((IPEndPoint)l.LocalEndpoint).Port;
            l.Stop();
            return port;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            { // converts from string to byte[]
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(textMessage.Text);

                // sending the message
                sck.Send(msg);

                // add to listbox
                listMessage.Items.Add("You: " + textMessage.Text);

                // clear txtMessage
                textMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MessageCallBack(IAsyncResult ar)
        {
            try
            {
                int size = sck.EndReceiveFrom(ar, ref epRemote);

                if (size > 0)
                { // used to help us on getting the data
                    byte[] receivedData = new byte[1464];

                    // getting the message data
                    receivedData = (byte[])ar.AsyncState;

                    // converts message data byte array to string
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);

                    // adding Message to the listbox
                    listMessage.Items.Add("Friend: " + receivedMessage);
                }

                // starts to listen the socket again
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }


    }
}
