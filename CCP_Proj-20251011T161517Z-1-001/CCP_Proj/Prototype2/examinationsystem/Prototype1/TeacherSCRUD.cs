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
    public partial class TeacherSCRUD : Form
    {
        public TeacherSCRUD()
        {
            InitializeComponent();
        }

        public static string subject = "";
        public static string email = "";

        private void btnStudScrud_Click(object sender, EventArgs e)
        {
            AdmTchStudentSCRUD admTchStudentSCRUD = new AdmTchStudentSCRUD();
            this.Hide();
            admTchStudentSCRUD.Show();
        }

        private void TeacherSCRUD_Load(object sender, EventArgs e)
        {
            Form1 getdata = new Form1();
            email = Form1.email;
            string query = "SELECT Subject from teachers WHERE Email = '" + email + "'";
            string conn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(conn);
            MySqlCommand sqlcmd = new MySqlCommand(query, sqlconn);

            sqlconn.Open();

            MySqlDataReader reader;
            reader = sqlcmd.ExecuteReader();

            while (reader.Read())
            {
               subject = reader.GetValue(0).ToString();
            }
            sqlconn.Close();
                    
        }

        private void btnExamScrud_Click(object sender, EventArgs e)
        {
            txtAddID openExamSCRUD = new txtAddID();
            
            this.Hide();
            openExamSCRUD.Show();
        }

        private void TeacherSCRUD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGradesScurd_Click(object sender, EventArgs e)
        {
            TeachGradesSCRUD openteachGradesSCRUD = new TeachGradesSCRUD();
            this.Hide();
            openteachGradesSCRUD.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
                Form1 goBack = new Form1();
                this.Hide();
                goBack.Show();
            
        }
    }
}
