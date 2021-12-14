using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AkademineSistema
{
    public partial class FormAdmin : Form
    {
        public FormAdmin(Admin admin)
        {
            try
            {
                InitializeComponent();

                this.txtAdminFName.Text = admin.getfName();
                this.txtAdminLName.Text = admin.getlName();

                loadCombo();
                loadList();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        //----------------------------------------------------------------
        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            this.pnlSubject.Hide();
            this.pnlLector.Hide();
            this.pnlStudent.Hide();

            this.pnlGroup.Show();
        }
        private void btnCreateSubject_Click(object sender, EventArgs e)
        {
            this.pnlGroup.Hide();
            this.pnlLector.Hide();
            this.pnlStudent.Hide();

            this.pnlSubject.Show();
        }
        private void btnCreateLector_Click(object sender, EventArgs e)
        {
            this.pnlGroup.Hide();
            this.pnlSubject.Hide();
            this.pnlStudent.Hide();

            this.pnlLector.Show();
        }
        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            this.pnlGroup.Hide();
            this.pnlLector.Hide();
            this.pnlSubject.Hide();

            this.pnlStudent.Show();
        }
        //----------------------------------------------------------------
        private void btnCreateG_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase dataBase = new DataBase();
                Group group = new Group(this.txtNameG.Text);
                dataBase.insertGroup(group);
                this.txtNameG.Clear();

                loadCombo();
                loadList();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }
        private void btnCreateSub_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase dataBase = new DataBase();
                Subject subject = new Subject(int.Parse(this.txtIdSub.Text), this.txtNameSub.Text);
                string gName = this.listGroupSub.SelectedItem.ToString();
                dataBase.insertSubject(subject, gName);
                this.txtIdSub.Clear();
                this.txtNameSub.Clear();

                loadCombo();
                loadList();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
        private void btnCreateL_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
                mySqlConnection.Open();
                string subName = this.listSubjectL.SelectedItem.ToString();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM dalykas WHERE pavadinimas='"+ subName +"'", mySqlConnection);

                int subId=-1;
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    subId = mySqlDataReader.GetInt32("id");
                }
                mySqlDataReader.Close();

                DataBase dataBase = new DataBase();
                Lector lector = new Lector(int.Parse(this.txtIdL.Text), this.txtfNameL.Text, this.txtlNameL.Text, subId);
                dataBase.insertLector(lector);
                this.txtIdL.Clear();
                this.txtfNameL.Clear();
                this.txtlNameL.Clear();

                loadCombo();
                loadList();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void btnCreateS_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase dataBase = new DataBase();
                string gName = this.listGroupS.SelectedItem.ToString();
                Student student = new Student(int.Parse(this.txtIdS.Text), this.txtfNameS.Text, this.txtlNameS.Text, gName);
                dataBase.insertStudent(student);
                this.txtIdS.Clear();
                this.txtfNameS.Clear();
                this.txtlNameS.Clear();

                loadCombo();
                loadList();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }
        //----------------------------------------------------------------
        private void btnRemoveGroup_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase dataBase = new DataBase();
                string name = this.comboGroups.SelectedItem.ToString();
                dataBase.deleteGroup(name);
                this.comboGroups.Items.Remove(name);
                loadCombo();
                loadList();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
                mySqlConnection.Open();
                string name = this.comboSubjects.SelectedItem.ToString();
                MySqlCommand mySqlCommand = new MySqlCommand("Select * FROM dalykas WHERE pavadinimas='" + name + "'", mySqlConnection);
                int subId = -1;
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    subId = mySqlDataReader.GetInt32("id");
                }
                mySqlDataReader.Close();

                DataBase dataBase = new DataBase();
                dataBase.deleteSubject(subId);
                this.comboSubjects.Items.Remove(name);
                loadCombo();
                loadList();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void btnRemoveLector_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
                mySqlConnection.Open();
                string name = this.comboLectors.SelectedItem.ToString();
                MySqlCommand mySqlCommand = new MySqlCommand("Select * FROM destytojas WHERE vardas='" + name + "'", mySqlConnection);
                int lecId = -1;
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    lecId = mySqlDataReader.GetInt32("id");
                }
                mySqlDataReader.Close();

                DataBase dataBase = new DataBase();
                dataBase.deleteLector(lecId);
                this.comboLectors.Items.Remove(name);
                loadCombo();
                loadList();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
                mySqlConnection.Open();
                string name = this.comboStudents.SelectedItem.ToString();
                MySqlCommand mySqlCommand = new MySqlCommand("Select * FROM studentas WHERE vardas='" + name + "'", mySqlConnection);
                int studId = -1;
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    studId = mySqlDataReader.GetInt32("id");
                }
                mySqlDataReader.Close();

                DataBase dataBase = new DataBase();
                dataBase.deleteStudent(studId);
                this.comboStudents.Items.Remove(name);
                loadCombo();
                loadList();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        //-----------------------------------------------------------------
        public void loadCombo()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand;
                MySqlDataReader mySqlDataReader;

                mySqlCommand = new MySqlCommand("SELECT * FROM studentas", mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                this.comboStudents.Items.Clear();
                while (mySqlDataReader.Read())
                {
                    this.comboStudents.Items.Add(mySqlDataReader.GetString("vardas"));
                }
                mySqlDataReader.Close();

                mySqlCommand = new MySqlCommand("SELECT * FROM destytojas", mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                this.comboLectors.Items.Clear();
                while (mySqlDataReader.Read())
                {
                    this.comboLectors.Items.Add(mySqlDataReader.GetString("vardas"));
                }
                mySqlDataReader.Close();

                mySqlCommand = new MySqlCommand("SELECT * FROM dalykas", mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                this.comboSubjects.Items.Clear();
                while (mySqlDataReader.Read())
                {
                    this.comboSubjects.Items.Add(mySqlDataReader.GetString("pavadinimas"));
                }
                mySqlDataReader.Close();

                mySqlCommand = new MySqlCommand("SELECT * FROM grupe", mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                this.comboGroups.Items.Clear();
                while (mySqlDataReader.Read())
                {
                    this.comboGroups.Items.Add(mySqlDataReader.GetString("pavadinimas"));
                }
                mySqlDataReader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        public void loadList()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand;
                MySqlDataReader mySqlDataReader;

                mySqlCommand = new MySqlCommand("SELECT * FROM grupe", mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                this.listGroupSub.Items.Clear();
                this.listGroupS.Items.Clear();
                while (mySqlDataReader.Read())
                {
                    this.listGroupSub.Items.Add(mySqlDataReader.GetString("pavadinimas"));
                    this.listGroupS.Items.Add(mySqlDataReader.GetString("pavadinimas"));
                }
                mySqlDataReader.Close();

                mySqlCommand = new MySqlCommand("SELECT * FROM dalykas", mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                this.listSubjectL.Items.Clear();
                while (mySqlDataReader.Read())
                {
                    this.listSubjectL.Items.Add(mySqlDataReader.GetString("pavadinimas"));
                }
                mySqlDataReader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
