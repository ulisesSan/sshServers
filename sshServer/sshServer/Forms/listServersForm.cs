using Org.BouncyCastle.Asn1.Cmp;
using sshServer.Services;
using sshServer.SQL.connector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sshServer.Forms
{
    public partial class listServersForm : Form
    {
        public listServersForm()
        {
            InitializeComponent();
            fillDataServer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addServer add = new addServer();
            add.Show();
        }

        private void fillDataServer()
        {
            dataServerTable.DataSource = null;
            dataServerTable.DataSource = Connector.getServers();
        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            fillDataServer();
        }

        private void dataServerTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            string serverName = dataServerTable.CurrentRow.Cells[1].Value.ToString();
            string serverIP = dataServerTable.CurrentRow.Cells[2].Value.ToString();
            string serverPass = dataServerTable.CurrentRow.Cells[3].Value.ToString();

            SshConnector.getSSHConnection(serverName,serverIP,serverPass);

            //MessageBox.Show(data);
        }
    }
}
