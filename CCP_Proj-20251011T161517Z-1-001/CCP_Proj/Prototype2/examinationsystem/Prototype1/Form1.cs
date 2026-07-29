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


namespace Prototype1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string email = "";
        public static string role = "";
        
       

        string stringconn = "datasource=localhost; database=test_sql; username=root; password=''";

        Boolean flagnotification;
        public void Errornotification()
        {
            flagnotification = false;
            if (txtSchEmail.Text.Length == 0)
            {
                errorProvider1.SetError(txtSchEmail, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtSchEmail, "");
            }

            if (txtSchPass.Text == "")
            {
                errorProvider1.SetError(txtSchPass, "Please fill-up this area");
                flagnotification = true;
            }
            else
            {
                errorProvider1.SetError(txtSchPass, "");
            }
        }

        public void login(string queryInfo)
        {
          
            MySqlConnection databaseConnection = new MySqlConnection(stringconn);
            MySqlCommand commandDatabase = new MySqlCommand(queryInfo, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                Errornotification();
                if (flagnotification == false)
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();

                    if (reader.HasRows)
                    {
                        
                        while (reader.Read())
                        {
                            if (role == "Student")
                            {
                                MessageBox.Show("Student Logged In");
                                email = txtSchEmail.Text;
                                this.Hide();
                                Canva openCanva = new Canva();
                                openCanva.Show();
                            }else if (role == "Teacher")
                            {
                                MessageBox.Show("Teacher Logged In");
                                email = txtSchEmail.Text;
                                this.Hide();
                                TeacherSCRUD openTeacherSCRUD = new TeacherSCRUD();
                                openTeacherSCRUD.Show();
                               
                            }
                            else if (role == "Admin")
                            {
                                MessageBox.Show("Admin Logged In");
                                email = txtSchEmail.Text;
                                this.Hide();
                                AdminSCRUD openAdminSCRUD = new AdminSCRUD();
                                openAdminSCRUD.Show();
                            }
                            else 
                            {
                                MessageBox.Show("Undefined Info");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Info");
                    }
                    databaseConnection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM students WHERE Email='" + txtSchEmail.Text + "' AND Pass='" +
                txtSchPass.Text + "'";
            role = "Student";
            login(query);
          
        }

        private void btnLoginPersonell_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM teachers WHERE Email='" + txtSchEmail.Text + "' AND Pass='" +
                txtSchPass.Text + "'";
            role = "Teacher";
            login(query);
          
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM admin WHERE Email='" + txtSchEmail.Text + "' AND Pass='" +
               txtSchPass.Text + "'";
            role = "Admin";
            login(query);
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtSchPass.PasswordChar = '\0';
            }
            else
            {
                txtSchPass.PasswordChar = '*';
            }
        }
    }
}
