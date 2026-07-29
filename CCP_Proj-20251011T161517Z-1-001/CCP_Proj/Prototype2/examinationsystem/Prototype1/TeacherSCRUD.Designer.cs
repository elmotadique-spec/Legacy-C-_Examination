
namespace Prototype1
{
    partial class TeacherSCRUD
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
            this.btnGradesScurd = new System.Windows.Forms.Button();
            this.btnExamScrud = new System.Windows.Forms.Button();
            this.btnStudScrud = new System.Windows.Forms.Button();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGradesScurd
            // 
            this.btnGradesScurd.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGradesScurd.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGradesScurd.ForeColor = System.Drawing.Color.Black;
            this.btnGradesScurd.Location = new System.Drawing.Point(145, 296);
            this.btnGradesScurd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGradesScurd.Name = "btnGradesScurd";
            this.btnGradesScurd.Size = new System.Drawing.Size(622, 104);
            this.btnGradesScurd.TabIndex = 6;
            this.btnGradesScurd.Text = "Grades SCRUD";
            this.btnGradesScurd.UseVisualStyleBackColor = false;
            this.btnGradesScurd.Click += new System.EventHandler(this.btnGradesScurd_Click);
            // 
            // btnExamScrud
            // 
            this.btnExamScrud.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExamScrud.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExamScrud.Location = new System.Drawing.Point(145, 184);
            this.btnExamScrud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExamScrud.Name = "btnExamScrud";
            this.btnExamScrud.Size = new System.Drawing.Size(622, 104);
            this.btnExamScrud.TabIndex = 5;
            this.btnExamScrud.Text = "Exam SCRUD";
            this.btnExamScrud.UseVisualStyleBackColor = false;
            this.btnExamScrud.Click += new System.EventHandler(this.btnExamScrud_Click);
            // 
            // btnStudScrud
            // 
            this.btnStudScrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStudScrud.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStudScrud.Location = new System.Drawing.Point(145, 72);
            this.btnStudScrud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStudScrud.Name = "btnStudScrud";
            this.btnStudScrud.Size = new System.Drawing.Size(622, 104);
            this.btnStudScrud.TabIndex = 4;
            this.btnStudScrud.Text = "Student SCRUD";
            this.btnStudScrud.UseVisualStyleBackColor = false;
            this.btnStudScrud.Click += new System.EventHandler(this.btnStudScrud_Click);
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(64, 439);
            this.txtSub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(114, 27);
            this.txtSub.TabIndex = 7;
            this.txtSub.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.Brown;
            this.btnLogout.Location = new System.Drawing.Point(740, 509);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(124, 52);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // TeacherSCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.btnGradesScurd);
            this.Controls.Add(this.btnExamScrud);
            this.Controls.Add(this.btnStudScrud);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TeacherSCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherSCRUD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherSCRUD_FormClosing);
            this.Load += new System.EventHandler(this.TeacherSCRUD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGradesScurd;
        private System.Windows.Forms.Button btnExamScrud;
        private System.Windows.Forms.Button btnStudScrud;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.Button btnLogout;
    }
}