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
    public partial class txtAddID : Form
    {
        public txtAddID()
        {
            InitializeComponent();
        }

        public static string Subject = "";
        public static string querySub = "";

        Boolean flagnotification;
        public static string action = "";

        //VALIDATION
        public void errornotificationAdd()
        {
            flagnotification = false;
            if (rtbAddQues.Text.Length == 0)
            {
                errorProvider1.SetError(rtbAddQues, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(rtbAddQues, "");
            }

            if (txtAddQuesCA.Text.Length == 0)
            {
                errorProvider1.SetError(txtAddQuesCA, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtAddQuesCA, "");
            }
            if (txtAddQuesCB.Text.Length == 0)
            {
                errorProvider1.SetError(txtAddQuesCB, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtAddQuesCB, "");
            }
            if (txtAddQuesCC.Text.Length == 0)
            {
                errorProvider1.SetError(txtAddQuesCC, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtAddQuesCC, "");
            }
            if (txtAddQuesCD.Text.Length == 0)
            {
                errorProvider1.SetError(txtAddQuesCD, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtAddQuesCD, "");
            }
            if (txtAddQuesCorAns.Text.Length == 0)
            {
                errorProvider1.SetError(txtAddQuesCorAns, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtAddQuesCorAns, "");
            }
            if (txtAddQuesCorAns.Text == txtAddQuesCA.Text || txtAddQuesCorAns.Text == txtAddQuesCB.Text
                || txtAddQuesCorAns.Text == txtAddQuesCC.Text || txtAddQuesCorAns.Text == txtAddQuesCD.Text) 
            {
                errorProvider1.SetError(txtAddQuesCorAns, "There are no correct answers");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtAddQuesCorAns, "");
            }
        }

        public void errornotificationEditQues()
        {
            flagnotification = false;
            if (txtEditQuesID.Text.Length == 0)
            {
                errorProvider1.SetError(txtEditQuesID, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtEditQuesID, "");
            }
            if (rtbEditQues.Text.Length == 0)
            {
                errorProvider1.SetError(rtbEditQues, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(rtbEditQues, "");
            }
            if (txtEditQuesCA.Text.Length == 0)
            {
                errorProvider1.SetError(txtEditQuesCA, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtEditQuesCA, "");
            }
            if (txtEditQuesCB.Text.Length == 0)
            {
                errorProvider1.SetError(txtEditQuesCB, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtEditQuesCB, "");
            }
            if (txtEditQuesCC.Text.Length == 0)
            {
                errorProvider1.SetError(txtEditQuesCC, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtEditQuesCC, "");
            }
            if (txtEditQuesCD.Text.Length == 0)
            {
                errorProvider1.SetError(txtEditQuesCD, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtEditQuesCD, "");
            }
            if (txtEditQuesCorAns.Text == txtEditQuesCA.Text || txtEditQuesCorAns.Text == txtEditQuesCB.Text
               || txtEditQuesCorAns.Text == txtEditQuesCC.Text || txtEditQuesCorAns.Text == txtEditQuesCD.Text)
            {
                errorProvider1.SetError(txtEditQuesCorAns, "");
            }
            else
            {
                errorProvider1.SetError(txtEditQuesCorAns, "There are no correct answers");
                flagnotification = true;
            }
        }



        public void actionhistoryexam(string action)
        {
            SCRUD_Operations operations = new SCRUD_Operations();
            operations.AddExamSCRUDHistory(action, Subject);
        }

        private void ExamSCRUD_Load(object sender, EventArgs e)
        {
            identifySub(Subject);
            TeacherSCRUD getSub = new TeacherSCRUD();
            Subject = TeacherSCRUD.subject;
            loadQues();
            loadHistory();
            loadExamTaker();
            LoadExamInfo();
            txtEditQuesID.Minimum = 0;
            txtExamSetSub.Text = Subject;
        }

        public void identifySub(string Subject)
        {
            if (Subject == "Math")
            {
                querySub = "mathexam";
            }
            else if (Subject == "Science")
            {
                querySub = "scienceexam";
            }
            else if (Subject == "History")
            {
                querySub = "historyexam";
            }
            else if (Subject == "English")
            {
                querySub = "englishexam";
            }
        }

        public void loadQues()
        {
            try
            {
                DataSet set = new DataSet();
                SCRUD_Operations operations = new SCRUD_Operations();
                set = operations.ViewExamQuestions(Subject);
                dataGridView1.DataSource = set;
                dataGridView1.DataMember = "DataList";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadHistory()
        {
             try
             {
              DataSet set = new DataSet();
              SCRUD_Operations operations = new SCRUD_Operations();
              set = operations.ViewExamSCRUDHistory(Subject);
              dataGridView2.DataSource = set;
              dataGridView2.DataMember = "DataList";
             }
             catch (Exception ex)
             {
                MessageBox.Show(ex.Message);
             }
        }

        public void loadExamTaker()
        {
            try
            {
                DataSet set = new DataSet();
                SCRUD_Operations operations = new SCRUD_Operations();
                set = operations.ViewExamTaker(Subject);
                dataGridView3.DataSource = set;
                dataGridView3.DataMember = "DataList";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadExamInfo()
        {
            try
            {
                SCRUD_Operations operations = new SCRUD_Operations();
                DataSet set = new DataSet();
                set = operations.ViewExamInfo(Subject);
                dataGridView4.DataSource = set;
                dataGridView4.DataMember = "DataList";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnViewQues_Click(object sender, EventArgs e)
        {
            loadQues();
        }

        private void btnAddQues_Click(object sender, EventArgs e)
        {
            try
            { 
                errornotificationAdd();
                if (flagnotification == false)
                {
                    identifySub(Subject);
                    string action = "Added Question ";
                    SCRUD_Operations operations = new SCRUD_Operations();
                    operations.AddExamQuestion(querySub, rtbAddQues.Text, txtAddQuesCA.Text, txtAddQuesCB.Text,txtAddQuesCC.Text,txtAddQuesCD.Text,txtAddQuesCorAns.Text);
                    actionhistoryexam(action);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void clearEdit()
        {
            txtEditQuesID.Text = "";
            rtbEditQues.Text = "";
            txtEditQuesCA.Text = "";
            txtEditQuesCB.Text = "";
            txtEditQuesCC.Text = "";
            txtEditQuesCD.Text = "";
            txtEditQuesCorAns.Text = "";
        }
        private void btnEditQuesSearch_Click(object sender, EventArgs e)
        {
            try
            {
                identifySub(Subject);
                string stringcon = "datasource=localhost; database=test_sql; username=root; password=''";
                MySqlConnection mysqlconn = new MySqlConnection(stringcon);
                MySqlCommand mysqlcmd = new MySqlCommand();
                MySqlDataReader sqlDR;
                mysqlconn.Open();
                mysqlcmd.CommandType = CommandType.Text;
                mysqlcmd.Connection = mysqlconn;
                mysqlcmd.CommandText = "SELECT * FROM " + querySub + " WHERE TransID=" + txtEditQuesID.Text;
                sqlDR = mysqlcmd.ExecuteReader();
                sqlDR.Read();
                if (sqlDR.HasRows)
                {
                    txtEditQuesID.Text = sqlDR[0].ToString();
                    rtbEditQues.Text = sqlDR[1].ToString();
                    txtEditQuesCA.Text = sqlDR[2].ToString();
                    txtEditQuesCB.Text = sqlDR[3].ToString();
                    txtEditQuesCC.Text = sqlDR[4].ToString();
                    txtEditQuesCD.Text = sqlDR[5].ToString();
                    txtEditQuesCorAns.Text = sqlDR[6].ToString();

                }
                else
                {
                    MessageBox.Show("No Record Found!", "Database Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clearEdit();
                }
                mysqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnEditQuesEdit_Click(object sender, EventArgs e)
        {
            try
            {
                errornotificationEditQues();
                if (flagnotification == false)
                {
                    identifySub(Subject);
                    string action = "Edited question " + txtEditQuesID.Text;
                    SCRUD_Operations operations = new SCRUD_Operations();
                    operations.EditExamQuestion(int.Parse(txtEditQuesID.Text),querySub, rtbEditQues.Text, txtEditQuesCA.Text, txtEditQuesCB.Text, txtEditQuesCC.Text, txtEditQuesCD.Text, txtEditQuesCorAns.Text);
                    actionhistoryexam(action);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtEditQuesDelete_Click(object sender, EventArgs e)
        {
            try
            {
                identifySub(Subject);
            string action = "Deleted question " + txtEditQuesID.Text;
            SCRUD_Operations operations = new SCRUD_Operations();
            operations.DeleteExamQuestion(int.Parse(txtEditQuesID.Text),Subject);
            actionhistoryexam(action);
            clearEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No record found", "No record");
            }
        }


        private void txtAddID_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnViewHistoryEditExam_Click(object sender, EventArgs e)
        {
            loadHistory();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TeacherSCRUD goBack = new TeacherSCRUD();
            this.Hide();
            goBack.Show();
        }

        private void btnRefreshExamT_Click(object sender, EventArgs e)
        {
            loadExamTaker();
        }

        private void btnRefExamInfo_Click(object sender, EventArgs e)
        {
            LoadExamInfo();
        }

        private void btnUpdateExamInfo_Click(object sender, EventArgs e)
        {
            try
            {
                SCRUD_Operations operations = new SCRUD_Operations();
                operations.EditExamInfo(Subject, txtExamSetItem.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    } 
}
