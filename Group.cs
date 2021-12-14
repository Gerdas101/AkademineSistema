using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkademineSistema
{
    class Group
    {
        string name;

        public Group(string name)
        {
            if (name.Length <= 2 && name.Length >= 1)
            {
                this.name = name;
            }
            else
            {
                MessageBox.Show("Error: Group name must contain 1 or 2 characters");
            }
        }
        ~Group() { }
        public string getName()
        {
            return name;
        }
    }
}
