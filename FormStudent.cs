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
    public partial class FormStudent : Form
    {
        public FormStudent(Student student)
        {
            try
            {
                InitializeComponent();

                this.txtStudentID.Text = student.getId().ToString();
                this.txtStudentFName.Text = student.getfName();
                this.txtStudentLName.Text = student.getlName();
                this.txtStudentGroup.Text = student.getGroup();

                loadSubjects();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void dataGridSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridSubjects.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridSubjects.CurrentRow.Selected = true;
                    txtSubject.Text = dataGridSubjects.Rows[e.RowIndex].Cells["pavadinimas"].FormattedValue.ToString();

                    MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
                    mySqlConnection.Open();

                    int studId = Convert.ToInt32(this.txtStudentID.Text);
                    int subId = Convert.ToInt32(dataGridSubjects.Rows[e.RowIndex].Cells["id"].Value);

                    DataTable dataTable = new DataTable();
                    MySqlCommand mySqlCommand = new MySqlCommand("SELECT id, laikas, ivertis FROM ivertinimas WHERE studentas_id=" + studId + " AND dalykas_id=" + subId + "", mySqlConnection);
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    dataTable.Load(mySqlDataReader);

                    dataGridGrades.DataSource = dataTable;
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loadSubjects()
        {
            MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
            mySqlConnection.Open();

            DataTable dataTable = new DataTable();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT id, pavadinimas FROM dalykas WHERE id IN(SELECT dalykas_id FROM grupe_dalykas WHERE grupe_pav='" + this.txtStudentGroup.Text + "')", mySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            dataTable.Load(mySqlDataReader);

            dataGridSubjects.DataSource = dataTable;
        }
    }
}
