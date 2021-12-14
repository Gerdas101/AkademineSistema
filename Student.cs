using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkademineSistema
{
    public class Student
    {
        int id;
        string fName;
        string lName;
        string group;

        public Student(int id, string fName, string lName, string group)
        {
            if (fName != "" && lName != "")
            {
                this.id = id;
                this.fName = fName;
                this.lName = lName;
                this.group = group;
            }
            else
            {
                MessageBox.Show("Error: Fields F_NAME and L_Name cannot be empty");
            }
        }
        ~Student() { }

        public int getId()
        {
            return id;
        }
        public string getfName()
        {
            return fName;
        }
        public string getlName()
        {
            return lName;
        }
        public string getGroup()
        {
            return group;
        }


    }
}
