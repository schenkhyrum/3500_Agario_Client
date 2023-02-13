using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model;
using NetworkingNS;
using Newtonsoft.Json;
using System.Diagnostics;

namespace ViewController
{
    public partial class Form1 : Form
    {
        private Preserved_Socket_State? server;

        public Form1()
        {
            InitializeComponent();
        }
    }
}
