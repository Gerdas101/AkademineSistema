using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkademineSistema
{
    public class Lector
    {
        int id;
        string fName;
        string lName;
        int subjectId;

        public Lector(int id, string fName, string lName, int subjectId)
        {
            if(fName != "" && lName != "")
            {
                this.id = id;
                this.fName = fName;
                this.lName = lName;
                this.subjectId = subjectId;
            }
            else
            {
                MessageBox.Show("Error: Fields F_NAME and L_Name cannot be empty");
            }
            
        }
        ~Lector() { }
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
        public int getSubjectID()
        {
            return subjectId;
        }
    }
}
