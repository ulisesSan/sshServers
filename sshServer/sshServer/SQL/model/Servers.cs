using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sshServer.SQL.model
{
    public class Servers
    {
        public int idServer { get; set; }
        public string serverName { get; set; }
        public string ipServer {  get; set; }
        public string serverPassword { get; set; }
        public string lastConnection { get; set; }
    }
}
