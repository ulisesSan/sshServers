using Renci.SshNet;
using sshServer.SQL.model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sshServer.Services
{
    internal class SshConnector
    {
        public static void getSSHConnection(string serverName,string ipServer,string pswd)
        {
            try{
                if (serverName == null || ipServer == null || pswd == null)
                {
                    MessageBox.Show("mensaje de errror al conseguir conexion al servicio ssh");
                }
                else
                {
                    string encodedPswd = EncoderPassword.DecodeString(pswd);

                    var client = new SshClient(ipServer, serverName, encodedPswd);

                    client.Connect();
                    Debug.WriteLine(client.ConnectionInfo.ServerVersion);

                    var result = client.RunCommand("ls -l");
                    Debug.WriteLine(result.Result);

                    MessageBox.Show(result.Result);

                    client.Disconnect();

                }
            }
            catch (Exception ex){
                Debug.WriteLine(ex);
                MessageBox.Show($"Failed to connect {ex.Message}");
            }
        }

    }
}
