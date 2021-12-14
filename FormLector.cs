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
    public partial class FormLector : Form
    {
        int subId;
        int studId;
        public FormLector(Lector lector)
        {
            try
            {
                InitializeComponent();

                this.txtLectorID.Text = lector.getId().ToString();
                this.txtLectorFName.Text = lector.getfName();
                this.txtLectorLName.Text = lector.getlName();
                subId = lector.getSubjectID();

                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM dalykas WHERE id=" + subId + "", mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    this.txtLectorSubject.Text = mySqlDataReader.GetString("pavadinimas");
                }
                mySqlDataReader.Close();

                loadStudents(lector.getSubjectID());
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        //----------------------------------------------------------------------
        private void dataGridStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridStudents.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridStudents.CurrentRow.Selected = true;
                    txtStudent.Text = dataGridStudents.Rows[e.RowIndex].Cells["vardas"].FormattedValue.ToString();

                    MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
                    mySqlConnection.Open();

                    studId = Convert.ToInt32(dataGridStudents.Rows[e.RowIndex].Cells["id"].Value);

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
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
                mySqlConnection.Open();

                int grade = Convert.ToInt32(this.txtGrade.Text);
                string date = DateTime.Now.ToString("yyyy/MM/dd");

                MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO ivertinimas(studentas_id, dalykas_id, ivertis, laikas) VALUES(" + studId + ", " + subId + ", " + grade + ", '" + date + "')", mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read()) { }
                mySqlDataReader.Close();

                DataTable dataTable = new DataTable();
                mySqlCommand = new MySqlCommand("SELECT id, laikas, ivertis FROM ivertinimas WHERE studentas_id=" + studId + " AND dalykas_id=" + subId + "", mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                dataTable.Load(mySqlDataReader);

                dataGridGrades.DataSource = dataTable;
            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
                mySqlConnection.Open();

                int grade = Convert.ToInt32(this.txtEditGrade.Text);
                int id = int.Parse(this.textBoxGrade.Text);

                MySqlCommand mySqlCommand = new MySqlCommand("UPDATE ivertinimas SET ivertis= " + grade + " WHERE id=" + id + "", mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read()) { }
                mySqlDataReader.Close();

                DataTable dataTable = new DataTable();
                mySqlCommand = new MySqlCommand("SELECT id, laikas, ivertis FROM ivertinimas WHERE studentas_id=" + studId + " AND dalykas_id=" + subId + "", mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                dataTable.Load(mySqlDataReader);

                dataGridGrades.DataSource = dataTable;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void dataGridGrades_CellClick(object sender, DataGridViewCellEventArgs a)
        {
            try
            {
                if (dataGridGrades.Rows[a.RowIndex].Cells[a.ColumnIndex].Value != null)
                {
                    dataGridGrades.CurrentRow.Selected = true;
                    this.textBoxGrade.Text = dataGridGrades.Rows[a.RowIndex].Cells["id"].FormattedValue.ToString();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        public void loadStudents(int id)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=LabasLabas12; database=akademinesistema");
            mySqlConnection.Open();

            DataTable dataTable = new DataTable();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT id, vardas, pavarde FROM studentas WHERE grupe_pav IN(SELECT grupe_pav FROM grupe_dalykas WHERE dalykas_id=" + id + ")", mySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            dataTable.Load(mySqlDataReader);

            dataGridStudents.DataSource = dataTable;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
