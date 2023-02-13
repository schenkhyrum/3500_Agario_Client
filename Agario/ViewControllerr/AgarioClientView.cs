using Microsoft.Extensions.Logging;
using Model;
using NetworkingNS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ViewController
{
    public partial class AgarioClientView : Form
    {
        List<Circle> circles = new List<Circle>();

        private Preserved_Socket_State? server;

        ILogger logger;
        public AgarioClientView()
        {
            InitializeComponent();
            Connect(new object(), new EventArgs());
        }

        private void Connect(object sender, EventArgs eventArgs)
        {
            if(this.server != null && this.server.socket.Connected)
            {
                logger?.LogDebug("Shutting down the connection.");
                this.server.socket.Shutdown(System.Net.Sockets.SocketShutdown.Both);
                return;
            }

            Debug.WriteLine("Asking networking code to connect to server.");
            this.server = Networking.Connect_to_Server(Contact_Established, "localhost");
        }
        /// <summary>
        /// This method assigns the data received handler and gets the 
        /// </summary>
        /// <param name="obj">Preserved Socket State from Networking.</param>
        private void Contact_Established(Preserved_Socket_State obj)
        {
            Debug.WriteLine("Contact Established");
            obj.on_data_received_handler = GetPlayer;
            Networking.Send(obj.socket, "aname\n");
            
            Networking.await_more_data(obj);
        }

        private void GetPlayer(Preserved_Socket_State obj)
        {
            Invalidate();
            Debug.WriteLine(obj.Message);
            Circle player = JsonConvert.DeserializeObject<Circle>(obj.Message);
        }
    }
}
