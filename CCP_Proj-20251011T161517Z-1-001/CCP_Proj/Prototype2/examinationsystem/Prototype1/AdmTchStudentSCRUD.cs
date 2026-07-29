using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prototype1
{
    public partial class AdmTchStudentSCRUD : Form
    {
        public AdmTchStudentSCRUD()
        {
            InitializeComponent();
        }

        public static string role = "";
        public static string action = "";
        Boolean flagnotification;

        public void errornotificationSearchStud()
        {
            flagnotification = false;
            if (txtEditStudID.Text.Length == 0)
            {
                errorProvider1.SetError(txtEditStudID, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtEditStudID, "");
            }
        }

        public void errornotificationEditStud()
        {
            flagnotification = false;
            if (txtEditStudName.Text.Length == 0)
            {
                errorProvider1.SetError(txtEditStudName, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtEditStudName, "");
            }

            if (txtEditStudEmail.Text.Length == 0)
            {
                errorProvider1.SetError(txtEditStudEmail, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtEditStudEmail, "");
            }

            if (txtEditStudPass.Text.Length == 0)
            {
                errorProvider1.SetError(txtEditStudPass, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtEditStudPass, "");
            }

            if (txtEditStudSec.Text.Length == 0)
            {
                errorProvider1.SetError(txtEditStudSec, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtEditStudSec, "");
            }

        }



        public void errornotificationAddStud()
        {
            flagnotification = false;
            if (txtAddStudName.Text.Length == 0)
            {
                errorProvider1.SetError(txtAddStudName, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtAddStudName, "");
            }

            if (txtAddStudEmail.Text.Length == 0)
            {
                errorProvider1.SetError(txtAddStudEmail, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtAddStudEmail, "");
            }

            if (txtAddStudPass.Text.Length == 0)
            {
                errorProvider1.SetError(txtAddStudPass, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtAddStudPass, "");
            }
            if (txtAddStudSec.Text.Length == 0)
            {
                errorProvider1.SetError(txtAddStudSec, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtAddStudSec, "");
            }


        }

        public void LoadStudent()
        {
            SCRUD_Operations operations = new SCRUD_Operations();
            DataSet set = new DataSet();
            set = operations.ViewStudent();
            dataGridView1.DataSource = set;
            dataGridView1.DataMember = "DataList";
        }

        public void LoadStudentHistory()
        {
            SCRUD_Operations operations = new SCRUD_Operations();
            DataSet set = new DataSet();
            set = operations.ViewStudentHistory();
            dataGridView2.DataSource = set;
            dataGridView2.DataMember = "DataList";
        }


        public void actionhistory(string action)
        {
            SCRUD_Operations operations = new SCRUD_Operations();
            operations.AddStudentSCRUDHistory(action);
        }



        private void btnBack2_Click(object sender, EventArgs e)
        {
            if (role == "Teacher")
            {
                TeacherSCRUD goBack = new TeacherSCRUD();
                this.Hide();
                goBack.Show();
            }
            else if (role == "Admin")
            {
                AdminSCRUD goBack = new AdminSCRUD();
                this.Hide();
                goBack.Show();
            }
        }

        private void AdmTchStudentSCRUD_Load(object sender, EventArgs e)
        {
            Form1 getData = new Form1();
            role = Form1.role;
            LoadStudent();
            LoadStudentHistory();
        }

        private void AdmTchStudentSCRUD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                errornotificationAddStud();
                if (flagnotification == false)
                {
                    string stringcon = "datasource=localhost; database=test_sql; username=root; password=''";
                    MySqlConnection mysqlconn = new MySqlConnection(stringcon);
                    MySqlCommand mysqlcmd = new MySqlCommand();
                    MySqlDataReader sqlDR;
                    mysqlconn.Open();
                    mysqlcmd.CommandType = CommandType.Text;
                    mysqlcmd.Connection = mysqlconn;
                    mysqlcmd.CommandText = "SELECT * FROM students WHERE Email='" + txtAddStudEmail.Text + "'" +
                        "OR Pass = '" + txtAddStudPass.Text + "'";
                    sqlDR = mysqlcmd.ExecuteReader();
                    sqlDR.Read();
                    if (sqlDR.HasRows)
                    {
                        MessageBox.Show("Student already exists!", "Database Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        action = "Added " + txtAddStudName.Text;
                        SCRUD_Operations operations = new SCRUD_Operations();
                        operations.AddStudent(txtAddStudID.Value, txtAddStudName.Text,
                        txtAddStudEmail.Text, txtAddStudPass.Text, txtAddStudSec.Text);
                        actionhistory(action);
                        AddClear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            try
            {
                errornotificationSearchStud();
                errornotificationEditStud();
                if (flagnotification == false)
                {
                    action = "Edited " + txtEditStudName.Text;
                    SCRUD_Operations operations = new SCRUD_Operations();
                    operations.UpdateStudent(txtEditStudID.Value, txtEditStudName.Text,
                    txtEditStudEmail.Text, txtEditStudPass.Text, txtEditStudSec.Text);
                    actionhistory(action);
                    EditClear();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                errornotificationSearchStud();
                if (flagnotification == false)
                {
                    string stringcon = "datasource=localhost; database=test_sql; username=root; password=''";
                    MySqlConnection mysqlconn = new MySqlConnection(stringcon);
                    MySqlCommand mysqlcmd = new MySqlCommand();
                    MySqlDataReader sqlDR;
                    mysqlconn.Open();
                    mysqlcmd.CommandType = CommandType.Text;
                    mysqlcmd.Connection = mysqlconn;
                    mysqlcmd.CommandText = "SELECT * FROM students WHERE TransID=" + txtEditStudID.Text;
                    sqlDR = mysqlcmd.ExecuteReader();
                    sqlDR.Read();
                    if (sqlDR.HasRows)
                    {
                        txtEditStudID.Text = sqlDR[0].ToString();
                        txtEditStudName.Text = sqlDR[1].ToString();
                        txtEditStudEmail.Text = sqlDR[2].ToString();
                        txtEditStudPass.Text = sqlDR[3].ToString();
                        txtEditStudSec.Text = sqlDR[4].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No Record Found!", "Database Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        EditClear();
                    }
                    mysqlconn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            try {
                action = "Deleted" + txtEditStudName.Text;
                SCRUD_Operations operations = new SCRUD_Operations();
                operations.DeleteStudent(txtEditStudID.Value);
                actionhistory(action);
                EditClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStudHistoryRefresh_Click(object sender, EventArgs e)
        {
            LoadStudentHistory();
        }

        public void AddClear()
        {
            txtAddStudID.Value = 0;
            txtAddStudName.Text = "";
            txtAddStudEmail.Text = "";
            txtAddStudPass.Text = "";
            txtAddStudSec.Text = "";
        }

        public void EditClear()
        {
            txtEditStudID.Value = 0;
            txtEditStudName.Text = "";
            txtEditStudEmail.Text = "";
            txtEditStudPass.Text = "";
            txtEditStudSec.Text = "";
        }
    }
}
