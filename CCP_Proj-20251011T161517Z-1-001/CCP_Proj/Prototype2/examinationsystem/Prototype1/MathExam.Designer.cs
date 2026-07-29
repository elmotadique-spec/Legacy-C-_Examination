
namespace Prototype1
{
    partial class Exam
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
            this.rtbQuestionMath = new System.Windows.Forms.RichTextBox();
            this.choiceA = new System.Windows.Forms.RadioButton();
            this.choiceB = new System.Windows.Forms.RadioButton();
            this.choiceC = new System.Windows.Forms.RadioButton();
            this.choiceD = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbQuestionMath
            // 
            this.rtbQuestionMath.Enabled = false;
            this.rtbQuestionMath.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbQuestionMath.Location = new System.Drawing.Point(57, 37);
            this.rtbQuestionMath.Name = "rtbQuestionMath";
            this.rtbQuestionMath.Size = new System.Drawing.Size(666, 96);
            this.rtbQuestionMath.TabIndex = 0;
            this.rtbQuestionMath.Text = "";
            // 
            // choiceA
            // 
            this.choiceA.AutoSize = true;
            this.choiceA.Location = new System.Drawing.Point(21, 22);
            this.choiceA.Name = "choiceA";
            this.choiceA.Size = new System.Drawing.Size(14, 13);
            this.choiceA.TabIndex = 1;
            this.choiceA.TabStop = true;
            this.choiceA.UseVisualStyleBackColor = true;
            // 
            // choiceB
            // 
            this.choiceB.AutoSize = true;
            this.choiceB.Location = new System.Drawing.Point(360, 22);
            this.choiceB.Name = "choiceB";
            this.choiceB.Size = new System.Drawing.Size(14, 13);
            this.choiceB.TabIndex = 2;
            this.choiceB.TabStop = true;
            this.choiceB.UseVisualStyleBackColor = true;
            // 
            // choiceC
            // 
            this.choiceC.AutoSize = true;
            this.choiceC.Location = new System.Drawing.Point(21, 60);
            this.choiceC.Name = "choiceC";
            this.choiceC.Size = new System.Drawing.Size(14, 13);
            this.choiceC.TabIndex = 3;
            this.choiceC.TabStop = true;
            this.choiceC.UseVisualStyleBackColor = true;
            // 
            // choiceD
            // 
            this.choiceD.AutoSize = true;
            this.choiceD.Location = new System.Drawing.Point(360, 60);
            this.choiceD.Name = "choiceD";
            this.choiceD.Size = new System.Drawing.Size(14, 13);
            this.choiceD.TabIndex = 4;
            this.choiceD.TabStop = true;
            this.choiceD.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.choiceD);
            this.groupBox1.Controls.Add(this.choiceA);
            this.groupBox1.Controls.Add(this.choiceB);
            this.groupBox1.Controls.Add(this.choiceC);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(57, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.Color.Brown;
            this.btnSubmit.Location = new System.Drawing.Point(606, 287);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(116, 33);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Next Question";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Enabled = false;
            this.txtSubject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubject.Location = new System.Drawing.Point(57, 296);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(100, 27);
            this.txtSubject.TabIndex = 7;
            this.txtSubject.Visible = false;
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(771, 351);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbQuestionMath);
            this.Name = "Exam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exam_FormClosing);
            this.Load += new System.EventHandler(this.MathExam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbQuestionMath;
        private System.Windows.Forms.RadioButton choiceA;
        private System.Windows.Forms.RadioButton choiceB;
        private System.Windows.Forms.RadioButton choiceC;
        private System.Windows.Forms.RadioButton choiceD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtSubject;
    }
}