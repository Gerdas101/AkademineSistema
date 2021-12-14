using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AkademineSistema
{
    class DataBase
    {
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;
        public DataBase()
        {
            
        }
        //------INSERT---------------------------------
        public void insertStudent(Student student)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
            mySqlConnection.Open();

            int id = student.getId();
            string fName = student.getfName();
            string lName = student.getlName();
            string group = student.getGroup();

            mySqlCommand = new MySqlCommand("INSERT INTO studentas(`id`, `vardas`, `pavarde`, `grupe_pav`) VALUES(" + id + ", '" + fName + "', '" + lName + "', '" + group + "')", mySqlConnection);

            mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read()) { }
            mySqlDataReader.Close();
        }
        public void insertLector(Lector lector)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
            mySqlConnection.Open();

            int id = lector.getId();
            string fName = lector.getfName();
            string lName = lector.getlName();
            int subjectId = lector.getSubjectID();

            mySqlCommand = new MySqlCommand("INSERT INTO destytojas(`id`, `vardas`, `pavarde`, `dalykas_id`) VALUES(" + id + ", '" + fName + "', '" + lName + "', "+ subjectId +")", mySqlConnection);

            mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read()) { }
            mySqlDataReader.Close();
        }
        public void insertGroup(Group group)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
            mySqlConnection.Open();

            string name = group.getName();

            mySqlCommand = new MySqlCommand("INSERT INTO grupe(`pavadinimas`) VALUES('" + name + "')", mySqlConnection);

            mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read()) { }
            mySqlDataReader.Close();
        }
        public void insertSubject(Subject subject, string gName)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
            mySqlConnection.Open();

            int id = subject.getId();
            string name = subject.getName();

            mySqlCommand = new MySqlCommand("INSERT INTO dalykas(`id`, `pavadinimas`) VALUES(" + id + ", '" + name + "')", mySqlConnection);
            mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read()) { }
            mySqlDataReader.Close();

            mySqlCommand = new MySqlCommand("INSERT INTO grupe_dalykas(`dalykas_id`, `grupe_pav`) VALUES(" + id + ", '" + gName + "')", mySqlConnection);
            mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read()) { }
            mySqlDataReader.Close();
        }
        //------DELETE---------------------------------
        public void deleteStudent(int id)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
            mySqlConnection.Open();

            mySqlCommand = new MySqlCommand("DELETE FROM studentas WHERE id=" + id + "", mySqlConnection);

            mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read()) { }
            mySqlDataReader.Close();

        }
        public void deleteLector(int id)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
            mySqlConnection.Open();

            mySqlCommand = new MySqlCommand("DELETE FROM destytojas WHERE id=" + id + "", mySqlConnection);

            mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read()) { }
            mySqlDataReader.Close();
        }
        public void deleteGroup(string name)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
            mySqlConnection.Open();

            mySqlCommand = new MySqlCommand("DELETE FROM grupe WHERE pavadinimas='" + name + "'", mySqlConnection);

            mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read()) { }
            mySqlDataReader.Close();

        }
        public void deleteSubject(int id)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
            mySqlConnection.Open();

            mySqlCommand = new MySqlCommand("DELETE FROM dalykas WHERE id=" + id + "", mySqlConnection);

            mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read()) { }
            mySqlDataReader.Close();

        }
        //---------------------------------------------
        
    }
}
