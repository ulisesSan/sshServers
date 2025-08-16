using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sshServer.Services
{
    internal class EncoderPassword
    {
        public static string EncodeString (string password)
        {
            return Convert.ToBase64String(Encoding.Unicode.GetBytes(password));
        }

        public static string DecodeString(string password) {

            return Encoding.Unicode.GetString(Convert.FromBase64String(password));

        }
    }
}
