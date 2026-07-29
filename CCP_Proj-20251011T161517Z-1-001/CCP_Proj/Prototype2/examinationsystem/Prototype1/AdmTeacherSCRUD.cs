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
    public partial class AdmTeacherSCRUD : Form
    {
        public AdmTeacherSCRUD()
        {
            InitializeComponent();
        }

        Boolean flagnotification;
        public static string action = "";

        public void actionhistory(string action)
        {
            SCRUD_Operations operations = new SCRUD_Operations();
            operations.AddTeacherSCRUDHistory(action);

        }


        public void errornotification()
        {
            flagnotification = false;
            if (txtAddTeachEmail.Text.Length == 0)
            {
                errorProvider1.SetError(txtAddTeachEmail, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtAddTeachEmail, "");
            }

            if (txtAddTeachName.Text == "")
            {
                errorProvider1.SetError(txtAddTeachName, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtAddTeachName, "");
            }
            if (txtAddTeachPass.Text.Length == 0)
            {
                errorProvider1.SetError(txtAddTeachPass, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtAddTeachPass, "");
            }
            if (cmbTeachSub.Text.Length == 0)
            {
                errorProvider1.SetError(cmbTeachSub, "Please choose a subject");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(cmbTeachSub, "");
            }
            
        }

        public void errornotificationEditTeach()
        {
            flagnotification = false;
            if (txtEditTeachID.Text.Length == 0)
            {
                errorProvider1.SetError(txtEditTeachID, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtEditTeachID, "");
            }
        }

        public void errornotificationEditTeach2()
        {
            flagnotification = false;
            if (txtEditTeachName.Text.Length == 0)
            {
                errorProvider1.SetError(txtEditTeachName, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtEditTeachName, "");
            }
            if (txtEditTeachEmail.Text.Length == 0)
            {
                errorProvider1.SetError(txtEditTeachEmail, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtEditTeachEmail, "");
            }
            if (txtEditTeachPass.Text.Length == 0)
            {
                errorProvider1.SetError(txtEditTeachPass, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtEditTeachPass, "");
            }
            if (cmbEditTeachSub.Text.Length == 0)
            {
                errorProvider1.SetError(cmbEditTeachSub, "Please choose a subject");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(cmbEditTeachSub, "");
            }
        }

       

        public void LoadTeachers()
        {
            try
            {
                DataSet set = new DataSet();
                SCRUD_Operations operations = new SCRUD_Operations();
                set = operations.ViewTeacherList();
                dataGridView1.DataSource = set;
                dataGridView1.DataMember = "DataList";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadAdmTeachersHistory()
        {
            try
            {
                DataSet set = new DataSet();
                SCRUD_Operations operations = new SCRUD_Operations();
                set = operations.ViewAdmTeacherSCRUDHistory();
                dtgvHistoryEdit.DataSource = set;
                dtgvHistoryEdit.DataMember = "DataList";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void searchEditTeach()
        {

            try
            {
                errornotificationEditTeach();
                if (flagnotification == false)

                {
                    string stringcon = "datasource=localhost; database=test_sql; username=root; password=''";
                    MySqlConnection mysqlconn = new MySqlConnection(stringcon);
                    MySqlCommand mysqlcmd = new MySqlCommand();
                    MySqlDataReader sqlDR;
                    mysqlconn.Open();
                    mysqlcmd.CommandType = CommandType.Text;
                    mysqlcmd.Connection = mysqlconn;
                    mysqlcmd.CommandText = "SELECT * FROM teachers WHERE TransID=" + txtEditTeachID.Text;
                    sqlDR = mysqlcmd.ExecuteReader();
                    sqlDR.Read();
                    if (sqlDR.HasRows)
                    {
                        txtEditTeachID.Text = sqlDR[0].ToString();
                        txtEditTeachName.Text = sqlDR[1].ToString();
                        txtEditTeachEmail.Text = sqlDR[2].ToString();
                        txtEditTeachPass.Text = sqlDR[3].ToString();
                        cmbEditTeachSub.Text = sqlDR[4].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No Record Found!", "Database Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    mysqlconn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                errornotification();
                if (flagnotification == false)

                {
                    string action = "Added Teacher " + txtAddTeachName.Text;
                    SCRUD_Operations operations = new SCRUD_Operations();
                    operations.AddTeacher(txtAddTeachName.Text,txtAddTeachEmail.Text,txtAddTeachPass.Text,cmbTeachSub.Text);
                    actionhistory(action);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        
        private void btnSearchTeacher_Click(object sender, EventArgs e)
        {
            searchEditTeach();
        }

        private void txtEditTeachID_TextChanged(object sender, EventArgs e)
        {
            if (txtEditTeachID.TextLength != 0)
            {
                searchEditTeach();
            }else
            {

            }
        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                errornotificationEditTeach2();
                if (flagnotification == false)
                {
                    string action = "Edited Teacher " + txtEditTeachName.Text;
  
                    SCRUD_Operations operations = new SCRUD_Operations();
                    operations.EditTeacher(int.Parse(txtEditTeachID.Text),txtEditTeachName.Text,
                        txtEditTeachEmail.Text,txtEditTeachPass.Text,cmbEditTeachSub.Text);
                    actionhistory(action);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnViewTeachView_Click(object sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void AdmTeacherSCRUD_Load(object sender, EventArgs e)
        {
            LoadTeachers();
            LoadAdmTeachersHistory();
        }

        private void btnViewAdmTeacherHistory_Click(object sender, EventArgs e)
        {
            LoadAdmTeachersHistory();
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                errornotificationEditTeach();
                if (flagnotification == false)

                {
                    string action = "Deleted Teacher ID no. " + txtEditTeachID.Text ;
                    SCRUD_Operations operations = new SCRUD_Operations();
                    operations.DeleteTeacher(int.Parse(txtEditTeachID.Text));
                    actionhistory(action);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       
        private void btnBack2_Click(object sender, EventArgs e)
        {

            AdminSCRUD goBack = new AdminSCRUD();
            this.Hide();
            goBack.Show();
        }

        private void AdmTeacherSCRUD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddTeacher_Click(object sender, EventArgs e)
        {

        }

        private void HistoryTeacher_Click(object sender, EventArgs e)
        {

        }
    }
}

