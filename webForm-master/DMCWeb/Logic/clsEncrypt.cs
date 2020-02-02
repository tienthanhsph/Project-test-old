using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMCWeb.Logic
{
    public class clsEncrypt
    {
        public String GetMD5(String text)
        {
            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(text);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }
    }
}