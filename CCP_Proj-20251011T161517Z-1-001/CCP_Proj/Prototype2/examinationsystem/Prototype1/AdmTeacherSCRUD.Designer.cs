
namespace Prototype1
{
    partial class AdmTeacherSCRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddTeacher = new System.Windows.Forms.TabPage();
            this.cmbTeachSub = new System.Windows.Forms.ComboBox();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.txtAddTeachPass = new System.Windows.Forms.TextBox();
            this.txtAddTeachEmail = new System.Windows.Forms.TextBox();
            this.txtAddTeachName = new System.Windows.Forms.TextBox();
            this.Tab = new System.Windows.Forms.TabPage();
            this.btnSearchTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.cmbEditTeachSub = new System.Windows.Forms.ComboBox();
            this.btnEditTeacher = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEditTeachID = new System.Windows.Forms.TextBox();
            this.txtEditTeachPass = new System.Windows.Forms.TextBox();
            this.txtEditTeachEmail = new System.Windows.Forms.TextBox();
            this.txtEditTeachName = new System.Windows.Forms.TextBox();
            this.ViewTeacher = new System.Windows.Forms.TabPage();
            this.btnViewTeachView = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HistoryTeacher = new System.Windows.Forms.TabPage();
            this.btnViewAdmTeacherHistory = new System.Windows.Forms.Button();
            this.dtgvHistoryEdit = new System.Windows.Forms.DataGridView();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.AddTeacher.SuspendLayout();
            this.Tab.SuspendLayout();
            this.ViewTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.HistoryTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistoryEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddTeacher);
            this.tabControl1.Controls.Add(this.Tab);
            this.tabControl1.Controls.Add(this.ViewTeacher);
            this.tabControl1.Controls.Add(this.HistoryTeacher);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(14, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 480);
            this.tabControl1.TabIndex = 0;
            // 
            // AddTeacher
            // 
            this.AddTeacher.BackColor = System.Drawing.Color.LightSalmon;
            this.AddTeacher.Controls.Add(this.cmbTeachSub);
            this.AddTeacher.Controls.Add(this.btnAddTeacher);
            this.AddTeacher.Controls.Add(this.label6);
            this.AddTeacher.Controls.Add(this.label5);
            this.AddTeacher.Controls.Add(this.label4);
            this.AddTeacher.Controls.Add(this.label3);
            this.AddTeacher.Controls.Add(this.label2);
            this.AddTeacher.Controls.Add(this.label1);
            this.AddTeacher.Controls.Add(this.txtTeacherID);
            this.AddTeacher.Controls.Add(this.txtAddTeachPass);
            this.AddTeacher.Controls.Add(this.txtAddTeachEmail);
            this.AddTeacher.Controls.Add(this.txtAddTeachName);
            this.AddTeacher.Location = new System.Drawing.Point(4, 30);
            this.AddTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddTeacher.Name = "AddTeacher";
            this.AddTeacher.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddTeacher.Size = new System.Drawing.Size(879, 446);
            this.AddTeacher.TabIndex = 0;
            this.AddTeacher.Text = "Add Teacher";
            this.AddTeacher.Click += new System.EventHandler(this.AddTeacher_Click);
            // 
            // cmbTeachSub
            // 
            this.cmbTeachSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeachSub.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTeachSub.FormattingEnabled = true;
            this.cmbTeachSub.Items.AddRange(new object[] {
            "Math",
            "Science",
            "History",
            "English"});
            this.cmbTeachSub.Location = new System.Drawing.Point(178, 308);
            this.cmbTeachSub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTeachSub.Name = "cmbTeachSub";
            this.cmbTeachSub.Size = new System.Drawing.Size(357, 31);
            this.cmbTeachSub.TabIndex = 30;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddTeacher.ForeColor = System.Drawing.Color.Brown;
            this.btnAddTeacher.Location = new System.Drawing.Point(736, 374);
            this.btnAddTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(106, 43);
            this.btnAddTeacher.TabIndex = 29;
            this.btnAddTeacher.Text = "ADD";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(40, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 26;
            this.label6.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(40, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(40, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Teacher ID";
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTeacherID.Location = new System.Drawing.Point(178, 72);
            this.txtTeacherID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(169, 32);
            this.txtTeacherID.TabIndex = 20;
            // 
            // txtAddTeachPass
            // 
            this.txtAddTeachPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddTeachPass.Location = new System.Drawing.Point(178, 247);
            this.txtAddTeachPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddTeachPass.Name = "txtAddTeachPass";
            this.txtAddTeachPass.Size = new System.Drawing.Size(357, 32);
            this.txtAddTeachPass.TabIndex = 18;
            // 
            // txtAddTeachEmail
            // 
            this.txtAddTeachEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddTeachEmail.Location = new System.Drawing.Point(178, 187);
            this.txtAddTeachEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddTeachEmail.Name = "txtAddTeachEmail";
            this.txtAddTeachEmail.Size = new System.Drawing.Size(357, 32);
            this.txtAddTeachEmail.TabIndex = 17;
            // 
            // txtAddTeachName
            // 
            this.txtAddTeachName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddTeachName.Location = new System.Drawing.Point(178, 129);
            this.txtAddTeachName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddTeachName.Name = "txtAddTeachName";
            this.txtAddTeachName.Size = new System.Drawing.Size(357, 32);
            this.txtAddTeachName.TabIndex = 15;
            // 
            // Tab
            // 
            this.Tab.BackColor = System.Drawing.Color.PeachPuff;
            this.Tab.Controls.Add(this.btnSearchTeacher);
            this.Tab.Controls.Add(this.btnDeleteTeacher);
            this.Tab.Controls.Add(this.cmbEditTeachSub);
            this.Tab.Controls.Add(this.btnEditTeacher);
            this.Tab.Controls.Add(this.label7);
            this.Tab.Controls.Add(this.label8);
            this.Tab.Controls.Add(this.label9);
            this.Tab.Controls.Add(this.label10);
            this.Tab.Controls.Add(this.label11);
            this.Tab.Controls.Add(this.label12);
            this.Tab.Controls.Add(this.txtEditTeachID);
            this.Tab.Controls.Add(this.txtEditTeachPass);
            this.Tab.Controls.Add(this.txtEditTeachEmail);
            this.Tab.Controls.Add(this.txtEditTeachName);
            this.Tab.Location = new System.Drawing.Point(4, 30);
            this.Tab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab.Name = "Tab";
            this.Tab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab.Size = new System.Drawing.Size(879, 446);
            this.Tab.TabIndex = 1;
            this.Tab.Text = "Edit Teacher";
            // 
            // btnSearchTeacher
            // 
            this.btnSearchTeacher.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchTeacher.ForeColor = System.Drawing.Color.Brown;
            this.btnSearchTeacher.Location = new System.Drawing.Point(350, 66);
            this.btnSearchTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchTeacher.Name = "btnSearchTeacher";
            this.btnSearchTeacher.Size = new System.Drawing.Size(99, 43);
            this.btnSearchTeacher.TabIndex = 44;
            this.btnSearchTeacher.Text = "Search";
            this.btnSearchTeacher.UseVisualStyleBackColor = true;
            this.btnSearchTeacher.Click += new System.EventHandler(this.btnSearchTeacher_Click);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteTeacher.ForeColor = System.Drawing.Color.Brown;
            this.btnDeleteTeacher.Location = new System.Drawing.Point(749, 380);
            this.btnDeleteTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(102, 45);
            this.btnDeleteTeacher.TabIndex = 43;
            this.btnDeleteTeacher.Text = "Delete";
            this.btnDeleteTeacher.UseVisualStyleBackColor = true;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
            // 
            // cmbEditTeachSub
            // 
            this.cmbEditTeachSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditTeachSub.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbEditTeachSub.FormattingEnabled = true;
            this.cmbEditTeachSub.Items.AddRange(new object[] {
            "Math",
            "Science",
            "History",
            "English"});
            this.cmbEditTeachSub.Location = new System.Drawing.Point(170, 323);
            this.cmbEditTeachSub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEditTeachSub.Name = "cmbEditTeachSub";
            this.cmbEditTeachSub.Size = new System.Drawing.Size(335, 31);
            this.cmbEditTeachSub.TabIndex = 42;
            // 
            // btnEditTeacher
            // 
            this.btnEditTeacher.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditTeacher.ForeColor = System.Drawing.Color.Brown;
            this.btnEditTeacher.Location = new System.Drawing.Point(749, 325);
            this.btnEditTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditTeacher.Name = "btnEditTeacher";
            this.btnEditTeacher.Size = new System.Drawing.Size(102, 45);
            this.btnEditTeacher.TabIndex = 41;
            this.btnEditTeacher.Text = "Edit";
            this.btnEditTeacher.UseVisualStyleBackColor = true;
            this.btnEditTeacher.Click += new System.EventHandler(this.btnEditTeacher_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(38, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 29);
            this.label7.TabIndex = 40;
            this.label7.Text = "Subject";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(38, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 29);
            this.label8.TabIndex = 39;
            this.label8.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(38, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 29);
            this.label9.TabIndex = 38;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(38, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 29);
            this.label10.TabIndex = 37;
            this.label10.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 21);
            this.label11.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(38, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 29);
            this.label12.TabIndex = 35;
            this.label12.Text = "Teacher ID";
            // 
            // txtEditTeachID
            // 
            this.txtEditTeachID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEditTeachID.Location = new System.Drawing.Point(170, 74);
            this.txtEditTeachID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEditTeachID.Name = "txtEditTeachID";
            this.txtEditTeachID.Size = new System.Drawing.Size(147, 32);
            this.txtEditTeachID.TabIndex = 34;
            this.txtEditTeachID.TextChanged += new System.EventHandler(this.txtEditTeachID_TextChanged);
            // 
            // txtEditTeachPass
            // 
            this.txtEditTeachPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEditTeachPass.Location = new System.Drawing.Point(170, 263);
            this.txtEditTeachPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEditTeachPass.Name = "txtEditTeachPass";
            this.txtEditTeachPass.Size = new System.Drawing.Size(335, 32);
            this.txtEditTeachPass.TabIndex = 33;
            // 
            // txtEditTeachEmail
            // 
            this.txtEditTeachEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEditTeachEmail.Location = new System.Drawing.Point(170, 200);
            this.txtEditTeachEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEditTeachEmail.Name = "txtEditTeachEmail";
            this.txtEditTeachEmail.Size = new System.Drawing.Size(335, 32);
            this.txtEditTeachEmail.TabIndex = 32;
            // 
            // txtEditTeachName
            // 
            this.txtEditTeachName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEditTeachName.Location = new System.Drawing.Point(170, 138);
            this.txtEditTeachName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEditTeachName.Name = "txtEditTeachName";
            this.txtEditTeachName.Size = new System.Drawing.Size(335, 32);
            this.txtEditTeachName.TabIndex = 31;
            // 
            // ViewTeacher
            // 
            this.ViewTeacher.BackColor = System.Drawing.Color.LightBlue;
            this.ViewTeacher.Controls.Add(this.btnViewTeachView);
            this.ViewTeacher.Controls.Add(this.dataGridView1);
            this.ViewTeacher.Location = new System.Drawing.Point(4, 29);
            this.ViewTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewTeacher.Name = "ViewTeacher";
            this.ViewTeacher.Size = new System.Drawing.Size(879, 447);
            this.ViewTeacher.TabIndex = 3;
            this.ViewTeacher.Text = "View Teachers";
            // 
            // btnViewTeachView
            // 
            this.btnViewTeachView.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewTeachView.ForeColor = System.Drawing.Color.Brown;
            this.btnViewTeachView.Location = new System.Drawing.Point(710, 362);
            this.btnViewTeachView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewTeachView.Name = "btnViewTeachView";
            this.btnViewTeachView.Size = new System.Drawing.Size(148, 53);
            this.btnViewTeachView.TabIndex = 1;
            this.btnViewTeachView.Text = "View Teachers";
            this.btnViewTeachView.UseVisualStyleBackColor = true;
            this.btnViewTeachView.Click += new System.EventHandler(this.btnViewTeachView_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(838, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // HistoryTeacher
            // 
            this.HistoryTeacher.BackColor = System.Drawing.Color.Thistle;
            this.HistoryTeacher.Controls.Add(this.btnViewAdmTeacherHistory);
            this.HistoryTeacher.Controls.Add(this.dtgvHistoryEdit);
            this.HistoryTeacher.Location = new System.Drawing.Point(4, 29);
            this.HistoryTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HistoryTeacher.Name = "HistoryTeacher";
            this.HistoryTeacher.Size = new System.Drawing.Size(879, 447);
            this.HistoryTeacher.TabIndex = 2;
            this.HistoryTeacher.Text = "History";
            this.HistoryTeacher.Click += new System.EventHandler(this.HistoryTeacher_Click);
            // 
            // btnViewAdmTeacherHistory
            // 
            this.btnViewAdmTeacherHistory.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewAdmTeacherHistory.ForeColor = System.Drawing.Color.Brown;
            this.btnViewAdmTeacherHistory.Location = new System.Drawing.Point(752, 349);
            this.btnViewAdmTeacherHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewAdmTeacherHistory.Name = "btnViewAdmTeacherHistory";
            this.btnViewAdmTeacherHistory.Size = new System.Drawing.Size(105, 54);
            this.btnViewAdmTeacherHistory.TabIndex = 1;
            this.btnViewAdmTeacherHistory.Text = "Refresh";
            this.btnViewAdmTeacherHistory.UseVisualStyleBackColor = true;
            this.btnViewAdmTeacherHistory.Click += new System.EventHandler(this.btnViewAdmTeacherHistory_Click);
            // 
            // dtgvHistoryEdit
            // 
            this.dtgvHistoryEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHistoryEdit.Location = new System.Drawing.Point(23, 35);
            this.dtgvHistoryEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvHistoryEdit.Name = "dtgvHistoryEdit";
            this.dtgvHistoryEdit.RowHeadersWidth = 51;
            this.dtgvHistoryEdit.RowTemplate.Height = 25;
            this.dtgvHistoryEdit.Size = new System.Drawing.Size(834, 295);
            this.dtgvHistoryEdit.TabIndex = 0;
            // 
            // btnBack2
            // 
            this.btnBack2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack2.ForeColor = System.Drawing.Color.Brown;
            this.btnBack2.Location = new System.Drawing.Point(782, 525);
            this.btnBack2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(115, 46);
            this.btnBack2.TabIndex = 3;
            this.btnBack2.Text = "Back";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AdmTeacherSCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnBack2);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdmTeacherSCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdmTeacherSCRUD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdmTeacherSCRUD_FormClosing);
            this.Load += new System.EventHandler(this.AdmTeacherSCRUD_Load);
            this.tabControl1.ResumeLayout(false);
            this.AddTeacher.ResumeLayout(false);
            this.AddTeacher.PerformLayout();
            this.Tab.ResumeLayout(false);
            this.Tab.PerformLayout();
            this.ViewTeacher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.HistoryTeacher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistoryEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddTeacher;
        private System.Windows.Forms.TabPage Tab;
        private System.Windows.Forms.TabPage HistoryTeacher;
        private System.Windows.Forms.ComboBox cmbTeachSub;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeacherID;
        private System.Windows.Forms.TextBox txtAddTeachPass;
        private System.Windows.Forms.TextBox txtAddTeachEmail;
        private System.Windows.Forms.TextBox txtAddTeachName;
        private System.Windows.Forms.Button btnSearchTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.ComboBox cmbEditTeachSub;
        private System.Windows.Forms.Button btnEditTeacher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEditTeachID;
        private System.Windows.Forms.TextBox txtEditTeachPass;
        private System.Windows.Forms.TextBox txtEditTeachEmail;
        private System.Windows.Forms.TextBox txtEditTeachName;
        private System.Windows.Forms.TabPage ViewTeacher;
        private System.Windows.Forms.Button btnViewTeachView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnViewAdmTeacherHistory;
        private System.Windows.Forms.DataGridView dtgvHistoryEdit;
        private System.Windows.Forms.Button btnBack2;
    }
}