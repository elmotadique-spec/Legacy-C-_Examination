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
    public partial class Canva : Form
    {
        public Canva()
        {
            InitializeComponent();
        }

        public static string name = "";
        public static string subject = "";
        public static Boolean proceed = false;

        private void Canva_Load(object sender, EventArgs e)
        {
            Form1 getdata = new Form1();
            txtStudEmail.Text = Form1.email;

            string query = "SELECT Name, Section from students WHERE Email = '"+txtStudEmail.Text+"'";
            string conn = "datasource=localhost; database=test_sql; username=root; password=''";
            MySqlConnection sqlconn = new MySqlConnection(conn);
            MySqlCommand sqlcmd = new MySqlCommand(query, sqlconn);
            sqlconn.Open();
            MySqlDataReader reader;
            reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                txtStudName.Text = reader.GetValue(0).ToString();
                txtStudSec.Text = reader.GetValue(1).ToString();
                name = txtStudName.Text;
            }
            reader.Close();

            sqlcmd.CommandText = sqlcmd.CommandText = "SELECT Name from mathexamtakers WHERE Name = '" + txtStudName.Text + "'";
            reader = sqlcmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txtMathSc.Text = reader.GetValue(0).ToString();
                }
                reader.Close();
            }

            else
            {
                reader.Close();
                sqlcmd.CommandText = sqlcmd.CommandText = "SELECT ExamFS from mathgrade WHERE Name = '" + txtStudName.Text + "'";
                reader = sqlcmd.ExecuteReader();
                while (reader.Read())
                {
                    txtMathSc.Text = "You haven't taken this exam";
                }
            }
            reader.Close();


            sqlcmd.CommandText = sqlcmd.CommandText = "SELECT Name from scienceexamtakers WHERE Name = '" + txtStudName.Text + "'";
            reader = sqlcmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txtScienceSc.Text = reader.GetValue(0).ToString();
                }
                reader.Close();
            }

            else
            {
                reader.Close();
                sqlcmd.CommandText = sqlcmd.CommandText = "SELECT ExamFS from sciencegrade WHERE Name = '" + txtStudName.Text + "'";
                reader = sqlcmd.ExecuteReader();
                while (reader.Read())
                {
                    txtScienceSc.Text = "You haven't taken this exam";
                }
            }
            reader.Close();

            sqlcmd.CommandText = sqlcmd.CommandText = "SELECT Name from historyexamtakers WHERE Name = '" + txtStudName.Text + "'";
            reader = sqlcmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                sqlcmd.CommandText = sqlcmd.CommandText = "SELECT ExamFS from historygrade WHERE Name = '" + txtStudName.Text + "'";
                reader = sqlcmd.ExecuteReader();
                while (reader.Read())
                {
                    txtHistorySc.Text = reader.GetValue(0).ToString();
                }
                reader.Close();
            }

            else
            {
                reader.Close();
                sqlcmd.CommandText = sqlcmd.CommandText = "SELECT ExamFS from historygrade WHERE Name = '" + txtStudName.Text + "'";
                reader = sqlcmd.ExecuteReader();
                while (reader.Read())
                {
                    txtHistorySc.Text = "You haven't taken this exam";
                }
            }
            reader.Close();

            sqlcmd.CommandText = sqlcmd.CommandText = "SELECT Name from englishexamtakers WHERE Name = '" + txtStudName.Text + "'";
            reader = sqlcmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                sqlcmd.CommandText = sqlcmd.CommandText = "SELECT ExamFS from englishgrade WHERE Name = '" + txtStudName.Text + "'";
                reader = sqlcmd.ExecuteReader();
                while (reader.Read())
                {
                    txtEnglishSc.Text = reader.GetValue(0).ToString();
                }
                reader.Close();
            }

            else
            {
                reader.Close();
                sqlcmd.CommandText = sqlcmd.CommandText = "SELECT ExamFS from englishgrade WHERE Name = '" + txtStudName.Text + "'";
                reader = sqlcmd.ExecuteReader();
                while (reader.Read())
                {
                    txtEnglishSc.Text = "You haven't taken this exam";
                }
            }
            reader.Close();
            sqlconn.Close();
        }

        public void Confirm()
        {
            DialogResult dialogResult = MessageBox.Show("You only have 1 chance and no retakes", "Take this exam?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                proceed = true;
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        public void LoadExam(string query, string sub)
        {
            try
            {
                if (txtStudName.Text == "" && txtStudSec.Text == "")
                {
                    MessageBox.Show("Invalid student credentials");
                }
                else
                {
                    string stringconn = "datasource=localhost; database=test_sql; username=root; password=''";
                    MySqlConnection databaseConnection = new MySqlConnection(stringconn);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show("You have taken this exam! ");
                        }
                    }
                    else
                    {
                        Confirm();
                        if (proceed == true)
                        {
                            Exam takeExam = new Exam();
                            this.Hide();
                            subject = sub;
                            takeExam.Show();
                        }
                        else
                        {

                        }

                    }
                    databaseConnection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnMath_Click(object sender, EventArgs e)
        {
           
            string query = "SELECT * FROM mathexamTakers WHERE Name='" + txtStudName.Text + "'";
            string subject = "Math";
            LoadExam(query, subject);
        }

        private void btnScience_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM scienceexamTakers WHERE Name='" + txtStudName.Text + "'";
            string subject = "Science";
            LoadExam(query, subject);
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM englishexamTakers WHERE Name='" + txtStudName.Text + "'";
            string subject = "English";
            LoadExam(query, subject);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM historyexamTakers WHERE Name='" + txtStudName.Text + "'";
            string subject = "History";
            LoadExam(query, subject);
        }

        private void Canva_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 goBack = new Form1();
            this.Hide();
            goBack.Show();
        }
    }
}
