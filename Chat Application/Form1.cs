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
namespace Chat_Application
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint eplocal, epremote;
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
            sck = new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket,SocketOptionName.ReuseAddress,true);
            txtlocalip.Text = getlocalip();
            txtremoteip.Text = getlocalip();
        }
        private string getlocalip() {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach( IPAddress ip in host.AddressList ){
            if(ip.AddressFamily==AddressFamily.InterNetwork){
                return ip.ToString();
            }
            }
        return "127.0.0.1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eplocal = new IPEndPoint(IPAddress.Parse(txtlocalip.Text),Convert.ToInt32(txtlocalport.Text));
            sck.Bind(eplocal);
            epremote = new IPEndPoint(IPAddress.Parse(txtremoteip.Text),Convert.ToInt32(txtremoteport.Text));
            sck.Connect(epremote);
            buffer=new byte[1500];
            sck.BeginReceiveFrom(buffer,0,buffer.Length,SocketFlags.None, ref epremote,new AsyncCallback (messagecallback),buffer);
        }
        void messagecallback( IAsyncResult aresult ) {
            try
            {
                byte[] recievedata = (byte[])aresult.AsyncState;
                ASCIIEncoding aencoding = new ASCIIEncoding();
                string recievemessage = aencoding.GetString(recievedata);
                messages.Items.Add("Friend :" + recievemessage);
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epremote, new AsyncCallback(messagecallback), buffer);
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aencoding = new ASCIIEncoding();
            byte [] sendingmessage=new byte[1500];
            sendingmessage = aencoding.GetBytes(txtmessages.Text);
            sck.Send(sendingmessage);
            messages.Items.Add("ME :"+txtmessages.Text);
            txtmessages.Text = "";
        }
    
    }
}
