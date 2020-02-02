using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DB
{
    class clsUser
    {
        private string strUser;

        public string User
        {
            get { return strUser; }
            set { strUser = value; }
        }
        private string strPass;

        public string Pass
        {
            get { return strPass; }
            set { strPass = value; }
        }
        private int intQuyen;

        public int Quyen
        {
            get { return intQuyen; }
            set { intQuyen = value; }
        }

    }
}
