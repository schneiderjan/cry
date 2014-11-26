using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CRY
{
    class Encryption
    {
        private String input, output, cipher;

        public Encryption() { }

        public string CalculateIP(string input)
        {
            
            byte[] bytes = this.ToBinary(input);
            byte[] bytesAfterIP = new byte[16];

            bytesAfterIP[10] = bytes[0];
            bytesAfterIP[7] = bytes[1];
            bytesAfterIP[13] = bytes[2];
            bytesAfterIP[0] = bytes[3];
            bytesAfterIP[8] = bytes[4];
            bytesAfterIP[2] = bytes[5];
            bytesAfterIP[11] = bytes[6];
            bytesAfterIP[5] = bytes[7];
            bytesAfterIP[15] = bytes[8];
            bytesAfterIP[3] = bytes[9];
            bytesAfterIP[12] = bytes[10];
            bytesAfterIP[1] = bytes[11];
            bytesAfterIP[14] = bytes[12];
            bytesAfterIP[4] = bytes[13];
            bytesAfterIP[9] = bytes[14];
            bytesAfterIP[6] = bytes[15];

            string ipOutput = Encoding.UTF8.GetString(bytesAfterIP, 0, bytesAfterIP.Length);
            return ipOutput;
        }

        public byte[] ToBinary(string stringPassed)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            return encoding.GetBytes(stringPassed);
        }

        
    }
}
