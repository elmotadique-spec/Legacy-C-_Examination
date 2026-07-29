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
    public partial class TeachGradesSCRUD : Form
    {
        public static string Subject = "";
        Boolean flagnotification;
        public static decimal final = 0;
        public TeachGradesSCRUD()
        {
            InitializeComponent();
        }

        private void TeachGradesSCRUD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void errornotificationConv()
        {
            flagnotification = false;
            if (txtExamItems.Value < txtExamRS.Value)
            {
                errorProvider1.SetError(txtExamRS, "Raw score can't be bigger than items");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtExamRS, "");
            }
        }

        public void errornotificationsearch()
        {
            flagnotification = false;
            if (txtCGID.Value == 0 )
            {
                errorProvider1.SetError(txtCGID, "Please input a correct ID");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtCGID, "");
            }
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                errornotificationConv();
                if (flagnotification == false)
                {
                    txtCGExam.Value = ((txtExamRS.Value / txtExamItems.Value) * 50) + 50;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Check for the values inserted into the Converter", "Invalid input");
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                errornotificationConv();
                if (flagnotification == false)
                {
                    final = ((txtCGAss1.Value + txtCGAss2.Value) * 5) +
                    ((txtCGQuiz1.Value + txtCGQuiz2.Value) * 10) +
                    (txtCGProj.Value * 30) + (txtCGExam.Value * 40);
                    txtFinalGrade.Value = final / 100;

                   if (txtFinalGrade.Value >= 94 && txtFinalGrade.Value <= 100)
                   {
                        txtGradeEquivalent.Text = "1.00";
                   }
                   else if (Convert.ToInt64(txtFinalGrade.Value) >= 88.5 && Convert.ToInt64(txtFinalGrade.Value) <= 93.99)
                   {
                        txtGradeEquivalent.Text = "1.25";
                   }
                   else if (Convert.ToInt64(txtFinalGrade.Value) >= 83 && Convert.ToInt64(txtFinalGrade.Value) <= 88.49)
                   {
                        txtGradeEquivalent.Text = "1.50";
                   }
                   else if (Convert.ToInt64(txtFinalGrade.Value) >= 77.5 && Convert.ToInt64(txtFinalGrade.Value) <= 82.99)
                   {
                        txtGradeEquivalent.Text = "1.75";
                   }
                   else if (Convert.ToInt64(txtFinalGrade.Value) >= 72 && Convert.ToInt64(txtFinalGrade.Value) <= 77.49)
                   {
                        txtGradeEquivalent.Text = "2.00";
                   }
                   else if (Convert.ToInt64(txtFinalGrade.Value) >= 65.5 && Convert.ToInt64(txtFinalGrade.Value) <= 71.99)
                   {
                        txtGradeEquivalent.Text = "2.25";
                   }
                   else if (Convert.ToInt64(txtFinalGrade.Value) >= 61 && Convert.ToInt64(txtFinalGrade.Value) <= 65.49)
                   {
                        txtGradeEquivalent.Text = "2.50";
                   }
                   else if (Convert.ToInt64(txtFinalGrade.Value) >= 55.5 && Convert.ToInt64(txtFinalGrade.Value) <= 60.99)
                   {
                        txtGradeEquivalent.Text = "2.75";
                   }
                   else if (Convert.ToInt64(txtFinalGrade.Value) >= 50 && Convert.ToInt64(txtFinalGrade.Value) <= 55.49)
                   {
                        txtGradeEquivalent.Text = "3.00";
                   }
                   else if (Convert.ToInt64(txtFinalGrade.Value) >= 0 && Convert.ToInt64(txtFinalGrade.Value) <= 49.99)
                   {
                        txtGradeEquivalent.Text = "Invalid";
                   }
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Please Check for the values inserted into the Converter", "Invalid input");
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            TeacherSCRUD teacherSCRUD = new TeacherSCRUD();
            this.Hide();
            teacherSCRUD.Show();
        }

        public void LoadStudentGrades()
        {
            SCRUD_Operations operations = new SCRUD_Operations();
            DataSet set = new DataSet();
            set = operations.ViewStudentGrade(Subject.ToLower());
            dataGridView1.DataSource = set;
            dataGridView1.DataMember = "DataList";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCGAss1.Value = 50;
            txtCGAss2.Value = 50;
            txtCGQuiz1.Value = 50;
            txtCGQuiz2.Value = 50;
            txtCGProj.Value = 50;
            txtCGExam.Value = 50;
            txtCGName.Text = "";
            txtCGEmail.Text = "";
            txtCGID.Value = 0;
            txtExamRS.Value = 0;
            txtExamItems.Value = 0;
            txtFinalGrade.Value = 50;
            txtGradeEquivalent.Text = "";
         }

        private void TeachGradesSCRUD_Load(object sender, EventArgs e)
        {
            
            TeacherSCRUD teacherSCRUD = new TeacherSCRUD();
            Subject = TeacherSCRUD.subject;
            LoadStudentGrades();
        }

        private void btnUpdateGrade_Click(object sender, EventArgs e)
        {
            try
            {
                errornotificationConv();
                if (flagnotification == false)
                {
                    SCRUD_Operations operations = new SCRUD_Operations();
                    operations.UpdateStudentGrade(txtCGID.Value, txtCGName.Text, Subject.ToLower(), txtCGAss1.Value, txtCGAss2.Value, txtCGQuiz1.Value, txtCGQuiz2.Value,
                    txtCGProj.Value, txtExamRS.Value, txtExamItems.Value, txtCGExam.Value, txtFinalGrade.Value, txtGradeEquivalent.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Check for the values inserted", "Invalid input");
            }
        }

        private void btnRefreshGradeView_Click(object sender, EventArgs e)
        {
            
            LoadStudentGrades();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            errornotificationsearch();
            {
                try
                {
                    
                    string stringcon = "database=test_sql; username=root; datasource=localhost; password=''";
                    MySqlConnection mysqlconn = new MySqlConnection(stringcon);
                    MySqlCommand mysqlcmd = new MySqlCommand();
                    MySqlDataReader sqlDR;
                    mysqlconn.Open();
                    mysqlcmd.CommandType = CommandType.Text;
                    mysqlcmd.Connection = mysqlconn;
                    mysqlcmd.CommandText = "SELECT * FROM " + Subject.ToLower() + "grade WHERE TransID=" + txtCGID.Value;
                    sqlDR = mysqlcmd.ExecuteReader();
                    sqlDR.Read();
                    if (sqlDR.HasRows)
                    {
                        txtCGName.Text = sqlDR[1].ToString();
                        txtCGEmail.Text = sqlDR[2].ToString();
                        txtCGAss1.Value = decimal.Parse(sqlDR[3].ToString());
                        txtCGAss2.Value = decimal.Parse(sqlDR[4].ToString());
                        txtCGQuiz1.Value = decimal.Parse(sqlDR[5].ToString());
                        txtCGQuiz2.Value = decimal.Parse(sqlDR[6].ToString());
                        txtCGProj.Value = decimal.Parse(sqlDR[7].ToString());
                        txtExamRS.Value = decimal.Parse(sqlDR[8].ToString());
                        txtExamItems.Value = decimal.Parse(sqlDR[9].ToString());
                        txtCGExam.Value = decimal.Parse(sqlDR[10].ToString());
                        txtFinalGrade.Value = decimal.Parse(sqlDR[11].ToString());
                        txtGradeEquivalent.Text = sqlDR[12].ToString();

                    }
                    else
                    {
                        MessageBox.Show("No Record Found!", "Database Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                    mysqlconn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnArrange_Click(object sender, EventArgs e)
        {
            SCRUD_Operations operations = new SCRUD_Operations();
            DataSet set = new DataSet();
            set = operations.ArrangeStudentGrade(Subject.ToLower());
            dataGridView1.DataSource = set;
            dataGridView1.DataMember = "DataList";
        }
    }
}
