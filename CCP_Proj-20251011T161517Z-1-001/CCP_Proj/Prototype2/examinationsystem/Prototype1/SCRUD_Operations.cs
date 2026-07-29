using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace Prototype1
{
    class SCRUD_Operations
    {

        //Global Function
        public static string querySubmit = "";
        public string determine(string subject)
        {
            
            if (subject == "Math")
            {
                querySubmit = "math";
            }
            else if (subject == "English")
            {
                querySubmit = "english";
            }
            else if (subject == "Science")
            {
                querySubmit = "science";
            }
            else if (subject == "History")
            {
                querySubmit = "history";
            }
            return querySubmit;
        }
        //EXAM SCRUD *SCRUD Exam questionnaire by Teacher

        public void AddExamQuestion(string subject, string Question, String ChoiceA, String ChoiceB, String ChoiceC, String ChoiceD, String CorrectAns)
        {
            string conn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(conn);
            MySqlCommand sqlcmd = new MySqlCommand();
            sqlconn.Open();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "INSERT INTO " + subject + " VALUES (0, '" + Question + "', '" + ChoiceA + "', " +
                        "'" + ChoiceB + "', '" + ChoiceC + "', '" + ChoiceD + "', '" + CorrectAns + "')";
            sqlcmd.Connection = sqlconn;
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
            MessageBox.Show("Record SAVED!");
        }

        public void EditExamQuestion(int transID, string subject, string Question, String ChoiceA, String ChoiceB, String ChoiceC, String ChoiceD, String CorrectAns)
        {
            string conn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(conn);
            MySqlCommand sqlcmd = new MySqlCommand();
            sqlconn.Open();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "UPDATE " + subject + " SET Question = '" + Question +
                        "',A ='" + ChoiceA +
                        "',B ='" + ChoiceB +
                        "',C ='" + ChoiceC +
                        "',D ='" + ChoiceD +
                        "',CorrectAns ='" + CorrectAns +
                        "' WHERE TransID =" + transID;
            sqlcmd.Connection = sqlconn;
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
            MessageBox.Show("Record UPDATED!");
        }

        public void EditExamInfo( string subject, decimal items)
        {
            string conn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(conn);
            MySqlCommand sqlcmd = new MySqlCommand();
            sqlconn.Open();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "UPDATE examinfo SET Examitems= " + items + 
                        " WHERE Subject ='" + subject.ToLower()+ "'";
            sqlcmd.Connection = sqlconn;
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
            MessageBox.Show("Record UPDATED!");
        }

        public DataSet ViewExamQuestions(string subject)
        {
            string conn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection mysqlcon = new MySqlConnection(conn);
            MySqlCommand mysqlcmd = new MySqlCommand();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            mysqlcon.Open();
            mysqlcmd.CommandText = "SELECT * FROM " + subject + "exam ;";
            mysqlcmd.CommandType = CommandType.Text;
            mysqlcmd.Connection = mysqlcon;
            mysqlcmd.ExecuteNonQuery();
            sqlDA.SelectCommand = mysqlcmd;
            sqlDA.Fill(ds, "DataList");
            return ds;
        }

        public DataSet ViewExamInfo(string subject)
        {
            string conn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection mysqlcon = new MySqlConnection(conn);
            MySqlCommand mysqlcmd = new MySqlCommand();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            mysqlcon.Open();
            mysqlcmd.CommandText = "SELECT * FROM examinfo WHERE Subject = '" + subject.ToLower() + "';";
            mysqlcmd.CommandType = CommandType.Text;
            mysqlcmd.Connection = mysqlcon;
            mysqlcmd.ExecuteNonQuery();
            sqlDA.SelectCommand = mysqlcmd;
            sqlDA.Fill(ds, "DataList");
            return ds;
        }


        public DataSet ViewExamSCRUDHistory(string Subject)
        {
            string conn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection mysqlcon = new MySqlConnection(conn);
            MySqlCommand mysqlcmd = new MySqlCommand();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            mysqlcon.Open();
            mysqlcmd.CommandText = "SELECT * FROM actionhistoryexam WHERE Subject= '" + Subject + "';";
            mysqlcmd.CommandType = CommandType.Text;
            mysqlcmd.Connection = mysqlcon;
            mysqlcmd.ExecuteNonQuery();
            sqlDA.SelectCommand = mysqlcmd;
            sqlDA.Fill(ds, "DataList");
            return ds;
        }

        public void DeleteExamQuestion(int transID, string subject)
        {
            string stringconn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            MySqlCommand sqlcmd = new MySqlCommand();
            sqlconn.Open();

            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "DELETE FROM" + subject + "exam WHERE transID=" + transID;
            sqlcmd.Connection = sqlconn;
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();

            MessageBox.Show("Record Deleted");
        }

        public void AddExamSCRUDHistory(string action, string Subject)
        {
            string stringconn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            MySqlCommand sqlcmd = new MySqlCommand();
            sqlconn.Open();
            sqlcmd.CommandText = "insert into actionhistoryexam values(0, '" + action + "', '" + Subject + "', '" + DateTime.Now + "')";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlconn;
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
        }




        //ADM_Teacher SCRUD  *SCRUD Teachers by Admin

        public void AddTeacher(string Name, string Email, string Pass, string Subject)
        {
            string stringconn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            MySqlCommand sqlcmd = new MySqlCommand();
            sqlconn.Open();
            sqlcmd.CommandText = "insert into teachers values(0, '" + Name + "', '" + Email + "', " +
                "'" + Pass + "', '" + Subject + "')"; ;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlconn;
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
            MessageBox.Show("Record is saved to database", "Data Save");
        }

        public void AddTeacherSCRUDHistory(string action)
        {
            string stringconn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            MySqlCommand sqlcmd = new MySqlCommand();
            sqlconn.Open();
            sqlcmd.CommandText = "insert into actionhistory values(0, '" + action + "','" + DateTime.Now + "')";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlconn;
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
        }

        public DataSet ViewTeacherList()
        {
            string conn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection mysqlcon = new MySqlConnection(conn);
            MySqlCommand mysqlcmd = new MySqlCommand();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            mysqlcon.Open();
            mysqlcmd.CommandText = "SELECT * FROM teachers";
            mysqlcmd.CommandType = CommandType.Text;
            mysqlcmd.Connection = mysqlcon;
            mysqlcmd.ExecuteNonQuery();
            sqlDA.SelectCommand = mysqlcmd;
            sqlDA.Fill(ds, "DataList");
            return ds;
        }

        public DataSet ViewAdmTeacherSCRUDHistory()
        {
            string conn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection mysqlcon = new MySqlConnection(conn);
            MySqlCommand mysqlcmd = new MySqlCommand();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            mysqlcon.Open();
            mysqlcmd.CommandText = "SELECT * FROM actionhistory";
            mysqlcmd.CommandType = CommandType.Text;
            mysqlcmd.Connection = mysqlcon;
            mysqlcmd.ExecuteNonQuery();
            sqlDA.SelectCommand = mysqlcmd;
            sqlDA.Fill(ds, "DataList");
            return ds;
        }

        public void DeleteTeacher(int transID)
        {
            string stringconn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            MySqlCommand sqlcmd = new MySqlCommand();
            sqlconn.Open();

            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "DELETE FROM teachers WHERE transID=" + transID;
            sqlcmd.Connection = sqlconn;
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();

            MessageBox.Show("Record Deleted");
        }

        public void EditTeacher(int transID, string Name, string Email, string Pass, string Subject)
        {
            string conn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(conn);
            MySqlCommand sqlcmd = new MySqlCommand();
            sqlconn.Open();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "UPDATE teachers SET TransID = '" + transID +
                        "',Name ='" + Name +
                        "',Email ='" + Email +
                        "',Pass ='" + Pass +
                        "',Subject ='" + Subject +
                        "' WHERE TransID =" + transID;
            sqlcmd.Connection = sqlconn;
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
            MessageBox.Show("Record UPDATED!");
        }



        //EXAM TAKERS SCRUD  *SCRUD OPs by seeing people who take the exam (includes students submition of Exam)

        public void AddExamTaker(string subject, string name)
        {
            determine(subject);
            string stringconn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            MySqlCommand sqlcmd = new MySqlCommand();

            sqlconn.Open();

            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = sqlcmd.CommandText = "INSERT INTO " + querySubmit +"examTakers VALUES (0, '" + name + "','" + DateTime.Now + "')"; ;
            sqlcmd.Connection = sqlconn;
            sqlcmd.ExecuteNonQuery();

            sqlconn.Close();
        }

        public void UpdateExamTakerScore(string subject, string name,decimal ExamRS, decimal ExamItem,decimal ExamFS)
        {
            determine(subject);
            string stringconn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            MySqlCommand sqlcmd = new MySqlCommand();

            sqlconn.Open();

            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = sqlcmd.CommandText = "UPDATE " + subject + "grade SET ExamRS = " + ExamRS +
                        ",ExamItem =" + ExamItem +
                        ",ExamFS =" + ExamFS +
                        " WHERE Name ='" + name + "'";
            sqlcmd.Connection = sqlconn;
            sqlcmd.ExecuteNonQuery();

            sqlconn.Close();
        }


        public DataSet ViewExamTaker(string subject)
        {
           
            string conn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection mysqlcon = new MySqlConnection(conn);
            MySqlCommand mysqlcmd = new MySqlCommand();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            mysqlcon.Open();
            mysqlcmd.CommandText = "SELECT * FROM " +subject+ "examtakers";
            mysqlcmd.CommandType = CommandType.Text;
            mysqlcmd.Connection = mysqlcon;
            mysqlcmd.ExecuteNonQuery();
            sqlDA.SelectCommand = mysqlcmd;
            sqlDA.Fill(ds, "DataList");
            return ds;
        }



        //Teacher Grades SCRUD * Computation and updating for students Grades 

        public DataSet ViewStudentGrade(string subject)
        {

            string conn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection mysqlcon = new MySqlConnection(conn);
            MySqlCommand mysqlcmd = new MySqlCommand();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            mysqlcon.Open();
            mysqlcmd.CommandText = "SELECT * FROM " + subject + "grade";
            mysqlcmd.CommandType = CommandType.Text;
            mysqlcmd.Connection = mysqlcon;
            mysqlcmd.ExecuteNonQuery();
            sqlDA.SelectCommand = mysqlcmd;
            sqlDA.Fill(ds, "DataList");
            return ds;
        }

        public DataSet ArrangeStudentGrade(string subject)
        {

            string conn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection mysqlcon = new MySqlConnection(conn);
            MySqlCommand mysqlcmd = new MySqlCommand();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            mysqlcon.Open();
            mysqlcmd.CommandText = "SELECT * FROM " + subject + "grade ORDER BY ExamFS DESC";
            mysqlcmd.CommandType = CommandType.Text;
            mysqlcmd.Connection = mysqlcon;
            mysqlcmd.ExecuteNonQuery();
            sqlDA.SelectCommand = mysqlcmd;
            sqlDA.Fill(ds, "DataList");
            return ds;
        }

        public void UpdateStudentGrade(decimal transID,string name, string subject, decimal Ass1, decimal Ass2, decimal Quiz1, 
            decimal Quiz2, decimal proj, decimal ExamRS, decimal ExamItem, decimal ExamScore, decimal FinalScore, 
            string GradeEquiv )
        {
            string conn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(conn);
            MySqlCommand sqlcmd = new MySqlCommand();
            sqlconn.Open();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "UPDATE " + subject + "grade SET Assign1 = " + Ass1 +
                        ",Assign2 =" + Ass2 +
                        ",Q1 =" + Quiz1 +
                        ",Q2 =" + Quiz2 +
                        ",Proj =" + proj +
                        ",ExamRS =" + ExamRS +
                        ",ExamItem =" + ExamItem +
                        ",ExamFS =" + ExamScore +
                        ",FinalGrade =" + FinalScore +
                        ",FinalGradeEquiv ='" + GradeEquiv +
                        "' WHERE (TransID =" + transID + 
                        " AND Name ='" + name + "')";
            sqlcmd.Connection = sqlconn;
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
            MessageBox.Show("Record UPDATED!");
        }


        //STUDENT SCRUD * Teacher or Admin SCRUD operations on STUDENTS
        public void AddStudent(decimal transID, string Name, string Email, string Pass, string Section)
        {
            string stringconn = "datasource=localhost; database=test_sql; username=root; password=''" ;
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            MySqlCommand sqlcmd = new MySqlCommand();
            sqlconn.Open();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandText = sqlcmd.CommandText = "INSERT INTO students VALUES (0, " +
                "'" + Name + "'," +
                "'" + Email +"' ," +
                "'" + Pass + "'," +
                "'" + Section +"')"; 
            sqlcmd.ExecuteNonQuery();
            sqlcmd.CommandText = sqlcmd.CommandText = "INSERT INTO mathgrade VALUES (0, " +
               "'" + Name + "'," +
               "'" + Email + "' ," +
               "" + 50 + "," +   //a1
               "" + 50 + "," +   //a2
               "" + 50 + "," +   //q1
               "" + 50 + "," +   //q2
               "" + 50 + "," +   //proj
               "" + 0 + "," +    //ExamRS
               "" + 0 + "," +    //ExamItems
               "" + 50 + "," +   //ExamFS
               "" + 50 + "," +   //FinalGrade
               "'" + "" + "')";  //FinalGradeEquivalence
            sqlcmd.ExecuteNonQuery();
            sqlcmd.CommandText = sqlcmd.CommandText = "INSERT INTO historygrade VALUES (0, " +
              "'" + Name + "'," +
              "'" + Email + "' ," +
              "" + 50 + "," +   //a1
              "" + 50 + "," +   //a2
              "" + 50 + "," +   //q1
              "" + 50 + "," +   //q2
              "" + 50 + "," +   //proj
              "" + 0 + "," +    //ExamRS
              "" + 0 + "," +    //ExamItems
              "" + 50 + "," +   //ExamFS
              "" + 50 + "," +   //FinalGrade
              "'" + "" + "')";  //FinalGradeEquivalence
            sqlcmd.ExecuteNonQuery();
            sqlcmd.CommandText = sqlcmd.CommandText = "INSERT INTO sciencegrade VALUES (0, " +
              "'" + Name + "'," +
              "'" + Email + "' ," +
              "" + 50 + "," +   //a1
              "" + 50 + "," +   //a2
              "" + 50 + "," +   //q1
              "" + 50 + "," +   //q2
              "" + 50 + "," +   //proj
              "" + 0 + "," +    //ExamRS
              "" + 0 + "," +    //ExamItems
              "" + 50 + "," +   //ExamFS
              "" + 50 + "," +   //FinalGrade
              "'" + "" + "')";  //FinalGradeEquivalence
            sqlcmd.ExecuteNonQuery();
            sqlcmd.CommandText = sqlcmd.CommandText = "INSERT INTO englishgrade VALUES (0, " +
              "'" + Name + "'," +
              "'" + Email + "' ," +
              "" + 50 + "," +   //a1
              "" + 50 + "," +   //a2
              "" + 50 + "," +   //q1
              "" + 50 + "," +   //q2
              "" + 50 + "," +   //proj
              "" + 0 + "," +    //ExamRS
              "" + 0 + "," +    //ExamItems
              "" + 50 + "," +   //ExamFS
              "" + 50 + "," +   //FinalGrade
              "'" + "" + "')";  //FinalGradeEquivalence
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
            MessageBox.Show("Record Added!");
        }


        public void UpdateStudent(decimal transID, string Name, string Email, string Pass, string Section)
        {
            string conn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(conn);
            MySqlCommand sqlcmd = new MySqlCommand();
            sqlconn.Open();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "UPDATE students SET TransID = '" + transID +
                        "',Name ='" + Name +
                        "',Email ='" + Email +
                        "',Pass ='" + Pass +
                        "',Section ='" + Section +
                        "' WHERE TransID =" + transID;
            sqlcmd.Connection = sqlconn;
            sqlcmd.Connection = sqlconn;
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
            MessageBox.Show("Record UPDATED!");
        }

        public DataSet ViewStudent()
        {

            string conn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection mysqlcon = new MySqlConnection(conn);
            MySqlCommand mysqlcmd = new MySqlCommand();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            mysqlcon.Open();
            mysqlcmd.CommandText = "SELECT * FROM students";
            mysqlcmd.CommandType = CommandType.Text;
            mysqlcmd.Connection = mysqlcon;
            mysqlcmd.ExecuteNonQuery();
            sqlDA.SelectCommand = mysqlcmd;
            sqlDA.Fill(ds, "DataList");
            return ds;
        }

        public DataSet ViewStudentHistory()
        {

            string conn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection mysqlcon = new MySqlConnection(conn);
            MySqlCommand mysqlcmd = new MySqlCommand();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            mysqlcon.Open();
            mysqlcmd.CommandText = "SELECT * FROM actionhistorystudent";
            mysqlcmd.CommandType = CommandType.Text;
            mysqlcmd.Connection = mysqlcon;
            mysqlcmd.ExecuteNonQuery();
            sqlDA.SelectCommand = mysqlcmd;
            sqlDA.Fill(ds, "DataList");
            return ds;
        }

        public void DeleteStudent(decimal transID)
        {
            string stringconn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            MySqlCommand sqlcmd = new MySqlCommand();
            sqlconn.Open();

            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "DELETE FROM students WHERE transID=" + transID;
            sqlcmd.Connection = sqlconn;
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();

            MessageBox.Show("Record Deleted");
        }

        public void AddStudentSCRUDHistory(string action)
        {
            string stringconn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            MySqlCommand sqlcmd = new MySqlCommand();
            sqlconn.Open();
            sqlcmd.CommandText = "insert into actionhistorystudent values(0, '" + action + "','" + DateTime.Now + "')";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlconn;
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
        }

    }
}