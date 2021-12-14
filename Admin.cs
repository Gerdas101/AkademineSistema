using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademineSistema
{
    public class Admin
    {
        string fName;
        string lName;

        public Admin()
        {
            fName = "Admin";
            lName = "123456789";
        }

        public string getfName()
        {
            return fName;
        }
        public string getlName()
        {
            return lName;
        }

    }
}
