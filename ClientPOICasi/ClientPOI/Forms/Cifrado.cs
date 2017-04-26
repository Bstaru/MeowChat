using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPOI.Forms
{
    public class Cifrado
    {
        string result;
        byte[] data;

        public string Encriptar(string msg)
        {
            result = string.Empty;
            data = Encoding.Unicode.GetBytes(msg);
            result = Convert.ToBase64String(data);
            data = null;
            return result;
        }

        public string Desencriptar(string msg)
        {
            result = string.Empty;
            data = Convert.FromBase64String(msg);
            result = Encoding.Unicode.GetString(data);
            return result;
        }
    }
}
