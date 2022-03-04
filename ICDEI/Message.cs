using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ICDEI
{
    public partial class Message : Form
    {
        Socket sock;
        EndPoint eplocal, epremote;
        byte[] buffer;

        public Message()
        {
            InitializeComponent();
           
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Message_Load(object sender, EventArgs e)
        { //set up a new socket
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            //get ip
            lsl.Text = GetLocalIP();    
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            //binding socket

            eplocal = new IPEndPoint(IPAddress.Parse(lsl.Text), Convert.ToInt32(pport.Text));
            sock.Bind(eplocal);

            //Connecting to remote ip
            epremote = new IPEndPoint(IPAddress.Parse(rip.Text), Convert.ToInt32(pport.Text));

            sock.Connect(epremote);

            //listening the port
            buffer = new byte[1500];
            sock.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epremote, new AsyncCallback(Messagecallback), buffer);
        }

        private void Messagecallback(IAsyncResult aresult)
        {
            try
            {
                byte[] recieved_data = new byte[1500];
                recieved_data = (byte[])aresult.AsyncState;

                //converting byte array to string

                ASCIIEncoding aencoding = new ASCIIEncoding();
                string recvmessage = aencoding.GetString(recieved_data);
                //adding message to listbox
                chatd.Items.Add("Friend : " + recvmessage);

                buffer = new byte[1500];
                sock.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epremote, new AsyncCallback(Messagecallback), buffer);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error");
            }
                
        }

        private void chatd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {
            //convert string messae to byte
            ASCIIEncoding aencoding = new ASCIIEncoding();
            byte[] sendingmessage = new byte[1500];
            sendingmessage = aencoding.GetBytes(stext.Text);
            //sending encoded message

            sock.Send(sendingmessage);
            //adding to the list box

            chatd.Items.Add("Me : " + stext.Text);
            stext.Text = "";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
    }
}
