using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkademineSistema
{
    class Subject
    {
        int id;
        string name;

        public Subject(int id, string name)
        {
            if(name != "")
            {
                this.id = id;
                this.name = name;
            }
            else
            {
                MessageBox.Show("Error: Field NAME cannot be empty");
            }
        }
        ~Subject() { }
        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }

    }
}
