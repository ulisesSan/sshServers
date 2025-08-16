using Org.BouncyCastle.Tls;
using sshServer.SQL.model;
using sshServer.utils;
using sshServer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sshServer.SQL.connector;

namespace sshServer.Forms
{
    public partial class addServer : Form
    {
        public addServer()
        {
            InitializeComponent();
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {

            if (txtPassword1.Text != null ||
                txtPassword1.Text.Equals(txtPassword2.Text))
            {
                string password = EncoderPassword.EncodeString(txtPassword1.Text);
                Servers server = new Servers()
                {
                    serverName = txtServerName.Text,
                    ipServer = txtIpServer.Text,
                    serverPassword = password

                };

                if (Connector.saveServerData(server))
                {
                    MessageBox.Show(Constants.successAdd);
                    this.Close();
                }
                else
                    MessageBox.Show("Error");
            }
            else
            {
                MessageBox.Show(Constants.passwordError);
            }   

        }


    }
}
