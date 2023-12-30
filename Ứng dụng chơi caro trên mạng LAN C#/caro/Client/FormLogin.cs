using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using General;
using System.Runtime.Remoting.Channels;
using System.Collections;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Remoting;
using System.Threading;

namespace Client
{
    public partial class FormLogin : Form
    {
        internal IRemote obj;
        private String Username;
        private String IP;
        private WrapperTransporterClass wtc,wtc1;
        public FormLogin()
        {
            InitializeComponent();
            AcceptButton = btnOk;
            wtc = new WrapperTransporterClass();
           

        }

        private void MakeConnectionToServer(string IP)
        {
            try
            {
                BinaryClientFormatterSinkProvider clientProvider = new BinaryClientFormatterSinkProvider();
                BinaryServerFormatterSinkProvider serverProvider = new BinaryServerFormatterSinkProvider();
                serverProvider.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;

                IDictionary props = new Hashtable();
                props["port"] = 0;
                string s = System.Guid.NewGuid().ToString();
                props["name"] = s;
                props["typeFilterLevel"] = TypeFilterLevel.Full;

                HttpChannel chan = new HttpChannel(props, clientProvider, serverProvider);

                int Port = 6123;             
                ChannelServices.RegisterChannel(chan);                
                obj = (IRemote)Activator.GetObject(typeof(IRemote), "http://" + IP + ":" + Port + "/RemoteObject.soap", WellKnownObjectMode.SingleCall);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to server");
            }
        }

        private void rdbtnLocalhost_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnLocalhost.Checked == true)
            {
                txtIp.Enabled = false;
            }
            else
            {
                txtIp.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (rdbtnLocalhost.Checked)
            {
                IP = "127.0.0.1";
            }
            else
            {
                IP = txtIp.Text;
            }
            Username = txtDesiredName.Text;
            try
            {
                MakeConnectionToServer(IP);

                if (obj.SignIn(Username))
                {
                    (new Thread(new ThreadStart(RunFormChat))).Start();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to server of IP " + IP);
            }
        }

        private void RunFormChat()
        {
            Application.Run(new FormChat(obj, Username));
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
