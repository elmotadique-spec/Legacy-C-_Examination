using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prototype1
{
    public partial class AdminSCRUD : Form
    {
        public AdminSCRUD()
        {
            InitializeComponent();
        }

        private void btnATeachScrud_Click(object sender, EventArgs e)
        {
            AdmTeacherSCRUD openAdmTeacherSCRUD = new AdmTeacherSCRUD();
            this.Hide();
            openAdmTeacherSCRUD.Show();
        }

        private void btnAStudScrud_Click(object sender, EventArgs e)
        {
            AdmTchStudentSCRUD admTchStudentSCRUD = new AdmTchStudentSCRUD();
            this.Hide();
            admTchStudentSCRUD.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
             Form1 goBack = new Form1();
             this.Hide();
             goBack.Show();
            
        }
    }
}
