using System;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Prototype1
{
    public partial class Exam : Form
    {
        public Exam()
        {
            InitializeComponent();
        }

        Canva getinfo = new Canva();
        public static string subject = Canva.subject;
        public static string querySub = "";
        public static string querySubmit = "";
        public static string name = Canva.name;
        public static int Score = 0;
        public static string CorrectAns = "";
        public int Over = 0;
        public static int tries = 0;
        public static int ctrExamItem = 0;
        public static int ctrItem = 1;
        public static string StudentAns = "";
        public static string msg = "";
        public static List<int> arlist = new List<int> { };



        private void MathExam_Load(object sender, EventArgs e)
        {
            txtSubject.Text = Canva.subject;
            string stringconn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            MySqlCommand sqlcmd = new MySqlCommand();
            sqlconn.Open();
            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = sqlcmd.CommandText = "SELECT COUNT(*) as count_items FROM " + subject + "exam;";
            sqlcmd.ExecuteNonQuery();
            int ctrExamItem = Convert.ToInt32(sqlcmd.ExecuteScalar());
            for (int i = 1; i < ctrExamItem; i++)
            {
                arlist.Add(i);
            }
            //MessageBox.Show(ctrExamItem.ToString());
            sqlcmd.CommandText = sqlcmd.CommandText = "SELECT ExamItems FROM examinfo WHERE Subject = '" + subject.ToLower() + "'";
            sqlcmd.ExecuteNonQuery();
            int Over = Convert.ToInt32(sqlcmd.ExecuteScalar());
            sqlconn.Close();
         //   MessageBox.Show(Over.ToString());
            LoadQuestions(Over);
        }

        public string LoadQuestions(int counter)
        {
            var rnd = new Random();
            
            int count = arlist.Count;
            int start2 = rnd.Next(1, arlist.Count); ;
            //arlist.RemoveAt(start2);
            string s = String.Join(",", arlist);
           // MessageBox.Show(s);
            string query = "SELECT Question, A, B, C, D, CorrectAns from "+ subject.ToLower() +"exam WHERE TransID = '" + start2 + "'";
            string conn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(conn);
            MySqlCommand sqlcmd = new MySqlCommand(query, sqlconn);
           // MessageBox.Show(query);
            sqlconn.Open();
            MySqlDataReader reader;
            reader = sqlcmd.ExecuteReader();

            if (tries != counter ) {
                while (reader.Read())
                {
                    rtbQuestionMath.Text = ctrItem + ". "+  reader.GetValue(0).ToString();
                    choiceA.Text = reader.GetValue(1).ToString();
                    choiceB.Text = reader.GetValue(2).ToString();
                    choiceC.Text = reader.GetValue(3).ToString();
                    choiceD.Text = reader.GetValue(4).ToString();
                    CorrectAns = reader.GetValue(5).ToString();

                }
            }
            sqlconn.Close();
            return querySub;
        }

        public void reset()
        {
            choiceA.Checked = false;
            choiceB.Checked = false;
            choiceC.Checked = false;
            choiceD.Checked = false;
        }


       

        private void btnSubmit_Click(object sender, EventArgs e)
        {
                if (choiceA.Checked)
                {
                    StudentAns = choiceA.Text;

                }
                else if (choiceB.Checked)
                {
                    StudentAns = choiceB.Text;

                }
                else if (choiceC.Checked)
                {
                    StudentAns = choiceC.Text;

                }
                else if (choiceD.Checked)
                {
                    StudentAns = choiceD.Text;

                }
                if (StudentAns == CorrectAns)
                {
                    Score++;
                    tries++;
                    ctrItem++; 
                    reset();

                }
                else
                {
                    Score += 0;
                    tries++;
                    ctrItem++;
                    reset();
                }
            string stringconn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            MySqlCommand sqlcmd = new MySqlCommand();
            sqlconn.Open();
            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandText = sqlcmd.CommandText = "SELECT ExamItems FROM examinfo WHERE Subject = '" + subject.ToLower() + "'";
            sqlcmd.ExecuteNonQuery();
            int Over = Convert.ToInt32(sqlcmd.ExecuteScalar());
            sqlconn.Close();
            
          //  MessageBox.Show(Over.ToString() + " VS " + tries.ToString());


            if (tries != Over)
               {
               
                LoadQuestions(Over);
              //  MessageBox.Show(Over.ToString() + " VS " + tries.ToString());
               }
            else if (tries == Over)
               {
                int FS = ((Score / tries) * 50) + 50;
                SCRUD_Operations operations = new SCRUD_Operations();
                operations.AddExamTaker(subject, name);
                operations.UpdateExamTakerScore(subject, name, Score, tries,FS);
               

                MessageBox.Show("Quiz is Submitted");
                reset();
                Canva goHome= new Canva();
                this.Hide();
                goHome.Show();
            }
        }

        private void Exam_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
 }


