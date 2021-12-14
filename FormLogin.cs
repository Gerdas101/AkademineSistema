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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
                mySqlConnection.Open();

                string fName = this.Username.Text;
                string lName = this.Password.Text;
                string q = "Select * FROM destytojas WHERE vardas='" + fName + "' AND pavarde='" + lName + "'";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(q, mySqlConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    int id;
                    int subjectId;
                    MySqlCommand mySqlCommand = new MySqlCommand(q, mySqlConnection);
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    if (mySqlDataReader.Read())
                    {
                        id = mySqlDataReader.GetInt32("id");
                        subjectId = mySqlDataReader.GetInt32("dalykas_id");

                        Lector lector = new Lector(id, fName, lName, subjectId);
                        FormLector formLector = new FormLector(lector);
                        formLector.Show();
                    }
                    mySqlDataReader.Close();
                }
                else
                {
                    q = "Select * FROM studentas WHERE vardas='" + fName + "' AND pavarde='" + lName + "'";
                    mySqlDataAdapter = new MySqlDataAdapter(q, mySqlConnection);
                    dataTable = new DataTable();
                    mySqlDataAdapter.Fill(dataTable);
                    if (dataTable.Rows.Count == 1)
                    {
                        int id;
                        string groupName;
                        MySqlCommand mySqlCommand = new MySqlCommand(q, mySqlConnection);
                        MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                        if (mySqlDataReader.Read())
                        {
                            id = mySqlDataReader.GetInt32("id");
                            groupName = mySqlDataReader.GetString("grupe_pav");

                            Student student = new Student(id, fName, lName, groupName);
                            FormStudent formStudent = new FormStudent(student);
                            formStudent.Show();
                        }
                        mySqlDataReader.Close();
                    }
                    else
                    {
                        if (fName == "Admin" && lName == "123456789")
                        {
                            Admin admin = new Admin();
                            FormAdmin formAdmin = new FormAdmin(admin);
                            formAdmin.Show();
                        }
                        else
                        {
                            MessageBox.Show("Error: Incorect Username or password");
                        }
                    }
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }
    }
}
