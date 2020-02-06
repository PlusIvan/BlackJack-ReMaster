using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_ReMaster
{
    class Websocks
    {
        private static Boolean isconnected = false;
        private static string server_ip = "";
        public string ServerIP
        {
            get { return server_ip; }
            set { server_ip = value; }
        }
        public Boolean isConnected
        {
            get { return isconnected; }
            set { isconnected = value; }
        }
        public void Establish_Connection()
        {
            Form.CheckForIllegalCrossThreadCalls = false;
            var socket = IO.Socket($"http://127.0.0.1:3000");
            socket.On(Socket.EVENT_CONNECT, () =>
            {
                //socket.Emit("ping");
                isConnected = true;
            });
        }
        private var socket = IO.Socket($"http://127.0.0.1:3000");
        public void SendEvent()
        {
           
            socket.Emit("ping");
        }

    }
}
